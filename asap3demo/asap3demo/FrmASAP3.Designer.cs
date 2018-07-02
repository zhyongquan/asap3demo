namespace asap3demo
{
    partial class FrmASAP3
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.grpPUMA = new System.Windows.Forms.GroupBox();
            this.btnSELECT = new System.Windows.Forms.Button();
            this.btnGETLOOKUPTABLE = new System.Windows.Forms.Button();
            this.btnSETPARAMETER = new System.Windows.Forms.Button();
            this.btnGETPARAMETER = new System.Windows.Forms.Button();
            this.btnGETONLINEVALUE = new System.Windows.Forms.Button();
            this.btnACQUISITION = new System.Windows.Forms.Button();
            this.btnIDENTIFY = new System.Windows.Forms.Button();
            this.btnINIT = new System.Windows.Forms.Button();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSELECTTABLE = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpPUMA.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 59);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INCA";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(190, 22);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 21);
            this.txtPort.TabIndex = 3;
            this.txtPort.Text = "22222";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(45, 22);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 21);
            this.txtIP.TabIndex = 2;
            this.txtIP.Text = "127.0.0.1";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(8, 20);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(282, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // grpPUMA
            // 
            this.grpPUMA.Controls.Add(this.btnSELECTTABLE);
            this.grpPUMA.Controls.Add(this.btnSELECT);
            this.grpPUMA.Controls.Add(this.btnGETLOOKUPTABLE);
            this.grpPUMA.Controls.Add(this.btnSETPARAMETER);
            this.grpPUMA.Controls.Add(this.btnGETPARAMETER);
            this.grpPUMA.Controls.Add(this.btnGETONLINEVALUE);
            this.grpPUMA.Controls.Add(this.btnACQUISITION);
            this.grpPUMA.Controls.Add(this.btnIDENTIFY);
            this.grpPUMA.Controls.Add(this.btnINIT);
            this.grpPUMA.Controls.Add(this.btnEXIT);
            this.grpPUMA.Controls.Add(this.btnConnect);
            this.grpPUMA.Location = new System.Drawing.Point(12, 77);
            this.grpPUMA.Name = "grpPUMA";
            this.grpPUMA.Size = new System.Drawing.Size(301, 345);
            this.grpPUMA.TabIndex = 5;
            this.grpPUMA.TabStop = false;
            this.grpPUMA.Text = "PUMA";
            // 
            // btnSELECT
            // 
            this.btnSELECT.Location = new System.Drawing.Point(8, 107);
            this.btnSELECT.Name = "btnSELECT";
            this.btnSELECT.Size = new System.Drawing.Size(282, 23);
            this.btnSELECT.TabIndex = 12;
            this.btnSELECT.Text = "3.SELECT DESCRIPTION-FILE AND BINARY FILE";
            this.btnSELECT.UseVisualStyleBackColor = true;
            this.btnSELECT.Click += new System.EventHandler(this.btnSELECT_Click);
            // 
            // btnGETLOOKUPTABLE
            // 
            this.btnGETLOOKUPTABLE.Location = new System.Drawing.Point(8, 281);
            this.btnGETLOOKUPTABLE.Name = "btnGETLOOKUPTABLE";
            this.btnGETLOOKUPTABLE.Size = new System.Drawing.Size(282, 23);
            this.btnGETLOOKUPTABLE.TabIndex = 11;
            this.btnGETLOOKUPTABLE.Text = "9.GET LOOKUP TABLE FROM AP-S ";
            this.btnGETLOOKUPTABLE.UseVisualStyleBackColor = true;
            this.btnGETLOOKUPTABLE.Click += new System.EventHandler(this.btnGETLOOKUPTABLE_Click);
            // 
            // btnSETPARAMETER
            // 
            this.btnSETPARAMETER.Location = new System.Drawing.Point(8, 223);
            this.btnSETPARAMETER.Name = "btnSETPARAMETER";
            this.btnSETPARAMETER.Size = new System.Drawing.Size(282, 23);
            this.btnSETPARAMETER.TabIndex = 10;
            this.btnSETPARAMETER.Text = "7.SET PARAMETER ON AP-S ";
            this.btnSETPARAMETER.UseVisualStyleBackColor = true;
            this.btnSETPARAMETER.Click += new System.EventHandler(this.btnSETPARAMETER_Click);
            // 
            // btnGETPARAMETER
            // 
            this.btnGETPARAMETER.Location = new System.Drawing.Point(8, 194);
            this.btnGETPARAMETER.Name = "btnGETPARAMETER";
            this.btnGETPARAMETER.Size = new System.Drawing.Size(282, 23);
            this.btnGETPARAMETER.TabIndex = 9;
            this.btnGETPARAMETER.Text = "6.GET PARAMETER FROM AP-S ";
            this.btnGETPARAMETER.UseVisualStyleBackColor = true;
            this.btnGETPARAMETER.Click += new System.EventHandler(this.btnGETPARAMETER_Click);
            // 
            // btnGETONLINEVALUE
            // 
            this.btnGETONLINEVALUE.Location = new System.Drawing.Point(8, 165);
            this.btnGETONLINEVALUE.Name = "btnGETONLINEVALUE";
            this.btnGETONLINEVALUE.Size = new System.Drawing.Size(282, 23);
            this.btnGETONLINEVALUE.TabIndex = 8;
            this.btnGETONLINEVALUE.Text = "5.GET ONLINE VALUE";
            this.btnGETONLINEVALUE.UseVisualStyleBackColor = true;
            this.btnGETONLINEVALUE.Click += new System.EventHandler(this.btnGETONLINEVALUE_Click);
            // 
            // btnACQUISITION
            // 
            this.btnACQUISITION.Location = new System.Drawing.Point(8, 136);
            this.btnACQUISITION.Name = "btnACQUISITION";
            this.btnACQUISITION.Size = new System.Drawing.Size(282, 23);
            this.btnACQUISITION.TabIndex = 7;
            this.btnACQUISITION.Text = "4.PARAMETER FOR VALUE ACQUISITION  ";
            this.btnACQUISITION.UseVisualStyleBackColor = true;
            this.btnACQUISITION.Click += new System.EventHandler(this.btnACQUISITION_Click);
            // 
            // btnIDENTIFY
            // 
            this.btnIDENTIFY.Location = new System.Drawing.Point(8, 78);
            this.btnIDENTIFY.Name = "btnIDENTIFY";
            this.btnIDENTIFY.Size = new System.Drawing.Size(282, 23);
            this.btnIDENTIFY.TabIndex = 6;
            this.btnIDENTIFY.Text = "2.IDENTIFY";
            this.btnIDENTIFY.UseVisualStyleBackColor = true;
            this.btnIDENTIFY.Click += new System.EventHandler(this.btnIDENTIFY_Click);
            // 
            // btnINIT
            // 
            this.btnINIT.Location = new System.Drawing.Point(8, 49);
            this.btnINIT.Name = "btnINIT";
            this.btnINIT.Size = new System.Drawing.Size(282, 23);
            this.btnINIT.TabIndex = 5;
            this.btnINIT.Text = "1.INIT";
            this.btnINIT.UseVisualStyleBackColor = true;
            this.btnINIT.Click += new System.EventHandler(this.btnINIT_Click);
            // 
            // btnEXIT
            // 
            this.btnEXIT.Location = new System.Drawing.Point(8, 310);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(282, 23);
            this.btnEXIT.TabIndex = 4;
            this.btnEXIT.Text = "10.EXIT";
            this.btnEXIT.UseVisualStyleBackColor = true;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(3, 17);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(420, 402);
            this.txtLog.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtLog);
            this.groupBox3.Location = new System.Drawing.Point(319, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 422);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Log";
            // 
            // btnSELECTTABLE
            // 
            this.btnSELECTTABLE.Location = new System.Drawing.Point(8, 252);
            this.btnSELECTTABLE.Name = "btnSELECTTABLE";
            this.btnSELECTTABLE.Size = new System.Drawing.Size(282, 23);
            this.btnSELECTTABLE.TabIndex = 13;
            this.btnSELECTTABLE.Text = "8.SELECT LOOKUP TABLE ";
            this.btnSELECTTABLE.UseVisualStyleBackColor = true;
            this.btnSELECTTABLE.Click += new System.EventHandler(this.btnSELECTTABLE_Click);
            // 
            // FrmASAP3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 439);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpPUMA);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmASAP3";
            this.Text = "ASAP3 DEMO";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpPUMA.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox grpPUMA;
        private System.Windows.Forms.Button btnINIT;
        private System.Windows.Forms.Button btnIDENTIFY;
        private System.Windows.Forms.Button btnACQUISITION;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGETONLINEVALUE;
        private System.Windows.Forms.Button btnGETPARAMETER;
        private System.Windows.Forms.Button btnGETLOOKUPTABLE;
        private System.Windows.Forms.Button btnSETPARAMETER;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.Button btnSELECT;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnSELECTTABLE;
    }
}

