using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asap3demo
{
    public partial class FrmASAP3 : Form
    {
        private TcpClient m_PUMA;
        private NetworkStream m_Stream;
        private int m_EmulatorLUN = 0;
        private List<string> m_ValueNames = new List<string>();
        private string m_Parameter = "";
        delegate void SetTextCallback(string text);
        public FrmASAP3()
        {
            InitializeComponent();
            m_PUMA = new TcpClient();
        }
        private void WriteLog(string log)
        {
            if (txtLog.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(WriteLog);
                txtLog.Invoke(d, new object[] { log });
            }
            else
            {
                txtLog.AppendText(string.Format("{0}:{1}\r\n", DateTime.Now, log));
            } 
        }
        private void WriteData(byte[] data)
        {
            //add length and checksum
            List<byte> list = new List<byte>();
            ushort length = (ushort)(data.Length+4);
            list.Add((byte)(length / 256));//from high to low
            list.Add((byte)(length % 256));
            list.AddRange(data);
            int checksum = length;
            for (int i = 0; i < data.Length / 2; i++)
            {
                checksum += data[2 * i] * 256 + data[2 * i + 1];
            }
            list.Add((byte)(checksum / 256));//from high to low
            list.Add((byte)(checksum % 256));
            data = list.ToArray();
            m_Stream.Write(data, 0, data.Length);
            
        }
        private void ReadData()
        {
            //Thread.Sleep(100);
            byte[] buffer=new byte[1024];
            int len = m_Stream.Read(buffer, 0, buffer.Length);
            while (len > 0)
            {
                byte[] data = new byte[len];
                Array.Copy(buffer, data, len);
                if (data.Length > 8)//ignore length<8
                {
                    int command = data[2] * 256 + data[3];
                    switch (command)
                    {
                        case 2:
                        case 15:
                            break;
                        case 3:
                            m_EmulatorLUN = data[6] * 256 + data[7];
                            WriteLog(string.Format("Emulator LUN:{0}", m_EmulatorLUN));
                            break;
                        case 14:
                            float[] values = new float[4];
                            for (int i = 0; i < 4; i++)
                            {
                                byte[] val = new byte[4];
                                Array.Copy(data, i * 4 + 6, val, 0, 4);
                                Array.Reverse(val);
                                values[i] = BitConverter.ToSingle(val, 0);
                            }
                            WriteLog(string.Format("{0}, Value={1}, Minimum value={2}, Maximum value={3}, Minimum Increment={4}",
                                m_Parameter, values[0], values[1], values[2], values[3]));
                            break;
                        case 19:
                            int count = data[6] * 256 + data[7];
                            if (count == m_ValueNames.Count)
                            {
                                string log = "";
                                for (int i = 0; i < count; i++)
                                {
                                    byte[] val = new byte[4];
                                    Array.Copy(data, i * 4 + 8, val, 0, 4);
                                    Array.Reverse(val);
                                    float value = BitConverter.ToSingle(val, 0);
                                    log += string.Format("{0}={1}, ", m_ValueNames[i], value);
                                }
                                WriteLog(log);
                            }
                            break;
                        case 20:
                            string version = string.Format("{0}.{1}", data[6], data[7]);
                            string mc = Encoding.ASCII.GetString(data, 10, data.Length - 12);
                            WriteLog(string.Format("Protocol version number:{0}, MC system name:{1}", version, mc));
                            break;
                        default:
                            break;
                    }
                }
                len = m_Stream.Read(buffer, 0, buffer.Length);
            }
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            m_PUMA.Connect(IPAddress.Parse(txtIP.Text), int.Parse(txtPort.Text));
            m_Stream = m_PUMA.GetStream();
            Thread thread = new Thread(ReadData);
            thread.Start();
            WriteLog("connect to ip: " + txtIP.Text + ", port: " + txtPort.Text);
        }

        private void btnINIT_Click(object sender, EventArgs e)
        {
            List<byte> list = new List<byte>();
            list.Add(0);//command:2
            list.Add(2);
            WriteData(list.ToArray());
            WriteLog(btnINIT.Text);
        }

        private void btnIDENTIFY_Click(object sender, EventArgs e)
        {
            List<byte> list = new List<byte>();
            list.Add(0);//command: 20
            list.Add(20);
            list.Add(2);//version: 2.1
            list.Add(1);
            list.AddRange(GetString("PUMA"));
            WriteData(list.ToArray());
            WriteLog(btnIDENTIFY.Text);
        }
        private List<byte> GetString(string str)
        {
            List<byte> list = new List<byte>();
            int len = str.Length;
            list.Add((byte)(len / 256));//high
            list.Add((byte)(len % 256));//low
            list.AddRange(Encoding.ASCII.GetBytes(str));
            if (len % 2 > 0)
                list.Add(0);//length must be even, not odd
            return list;
        }

        private void btnSELECT_Click(object sender, EventArgs e)
        {
            //it's better if this option is unchecked: General->Create new DS at Download within MCS
            string a2l = "A Top Folder 1\\Demo03";
            string hex = "Demo03\\Demo03";
            List<byte> list = new List<byte>();
            list.Add(0);//command: 3
            list.Add(3);
            list.AddRange(GetString(a2l));
            list.AddRange(GetString(hex));
            list.Add(0);
            list.Add(0);
            WriteData(list.ToArray());
            WriteLog(btnSELECT.Text);
        }

        private void btnACQUISITION_Click(object sender, EventArgs e)
        {
            m_ValueNames.Clear();
            m_ValueNames.Add("Output");
            int interval = 100;
            List<byte> list = new List<byte>();
            list.Add(0);//command: 12
            list.Add(12);
            list.Add((byte)(m_EmulatorLUN / 256));
            list.Add((byte)(m_EmulatorLUN % 256));
            list.Add((byte)(interval / 256));
            list.Add((byte)(interval % 256));
            list.Add((byte)(m_ValueNames.Count / 256));
            list.Add((byte)(m_ValueNames.Count % 256));
            foreach (string name in m_ValueNames)
                list.AddRange(GetString(name));
            WriteData(list.ToArray());
            WriteLog(btnACQUISITION.Text);
        }

        private void btnGETONLINEVALUE_Click(object sender, EventArgs e)
        {
            //make sure ASAP3 option is checked: Online->Switch MC-S to online
            List<byte> list = new List<byte>();
            list.Add(0);//command: 19
            list.Add(19);
            WriteData(list.ToArray());
            WriteLog(btnGETONLINEVALUE.Text);
        }

        private void btnGETPARAMETER_Click(object sender, EventArgs e)
        {
            m_Parameter = "DEMO_CONSTANT_1";
            List<byte> list = new List<byte>();
            list.Add(0);//command: 14
            list.Add(14);
            list.Add((byte)(m_EmulatorLUN / 256));
            list.Add((byte)(m_EmulatorLUN % 256));
            list.AddRange(GetString(m_Parameter));
            WriteData(list.ToArray());
            WriteLog(btnGETPARAMETER.Text);
        }

        private void btnSETPARAMETER_Click(object sender, EventArgs e)
        {
            float value = 0;
            m_Parameter = "DEMO_CONSTANT_1";
            List<byte> list = new List<byte>();
            list.Add(0);//command: 15
            list.Add(15);
            list.Add((byte)(m_EmulatorLUN / 256));
            list.Add((byte)(m_EmulatorLUN % 256));
            list.AddRange(GetString(m_Parameter));
            byte[] val = BitConverter.GetBytes(value);
            Array.Reverse(val);
            list.AddRange(val);
            WriteData(list.ToArray());
            WriteLog(btnSETPARAMETER.Text);
        }
        private void btnSELECTTABLE_Click(object sender, EventArgs e)
        {

        }

        private void btnGETLOOKUPTABLE_Click(object sender, EventArgs e)
        {

        }


        private void btnEXIT_Click(object sender, EventArgs e)
        {
            List<byte> list = new List<byte>();
            list.Add(0);//command: 50
            list.Add(50);
            WriteData(list.ToArray());
            WriteLog(btnEXIT.Text);
        }
    }
}
