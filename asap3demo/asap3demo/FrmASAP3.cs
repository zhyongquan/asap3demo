using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asap3demo
{
    public partial class FrmASAP3 : Form
    {
        private TcpClient m_PUMA;
        private NetworkStream m_Stream;
        public FrmASAP3()
        {
            InitializeComponent();
            m_PUMA = new TcpClient();
        }
        private void WriteLog(string log)
        {
            txtLog.AppendText(string.Format("{0}:{1}\r\n", DateTime.Now, log));
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
        private byte[] ReadData()
        {
            byte[] buffer=new byte[1024];
            int len = m_Stream.Read(buffer, 0, buffer.Length);
            byte[] data = new byte[len];
            Array.Copy(buffer, data, len);
            return data;
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            m_PUMA.Connect(IPAddress.Parse(txtIP.Text), int.Parse(txtPort.Text));
            m_Stream = m_PUMA.GetStream();
            WriteLog("connect to ip: " + txtIP.Text + ", port: " + txtPort.Text);
        }

        private void btnINIT_Click(object sender, EventArgs e)
        {
            List<byte> list = new List<byte>();
            list.Add(0);
            list.Add(2);
            WriteData(list.ToArray());
            ReadData();
            WriteLog(btnINIT.Text);
        }

        private void btnIDENTIFY_Click(object sender, EventArgs e)
        {
            List<byte> list = new List<byte>();
            list.Add(0);
            list.Add(20);
            list.Add(2);//version
            list.Add(1);
            list.Add(0);//length of PUMA
            list.Add(4);
            list.AddRange(Encoding.ASCII.GetBytes("PUMA"));
            WriteData(list.ToArray());
            ReadData();
            WriteLog(btnIDENTIFY.Text);
        }
    }
}
