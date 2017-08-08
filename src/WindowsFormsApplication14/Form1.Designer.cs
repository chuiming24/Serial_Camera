namespace WindowsFormsApplication14
{
    partial class form1
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_OpenSer = new System.Windows.Forms.Button();
            this.btn_ScanSer = new System.Windows.Forms.Button();
            this.box_Bund = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.box_ComNum = new System.Windows.Forms.ComboBox();
            this.端口 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.box_From = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 160);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "测试随机颜色图片";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(242, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 201);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "传输原图";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.box_From);
            this.groupBox2.Controls.Add(this.btn_OpenSer);
            this.groupBox2.Controls.Add(this.btn_ScanSer);
            this.groupBox2.Controls.Add(this.box_Bund);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.box_ComNum);
            this.groupBox2.Controls.Add(this.端口);
            this.groupBox2.Location = new System.Drawing.Point(26, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 166);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设置";
            // 
            // btn_OpenSer
            // 
            this.btn_OpenSer.Location = new System.Drawing.Point(8, 130);
            this.btn_OpenSer.Name = "btn_OpenSer";
            this.btn_OpenSer.Size = new System.Drawing.Size(184, 23);
            this.btn_OpenSer.TabIndex = 11;
            this.btn_OpenSer.Text = "打开串口";
            this.btn_OpenSer.UseVisualStyleBackColor = true;
            this.btn_OpenSer.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_ScanSer
            // 
            this.btn_ScanSer.Location = new System.Drawing.Point(8, 101);
            this.btn_ScanSer.Name = "btn_ScanSer";
            this.btn_ScanSer.Size = new System.Drawing.Size(184, 23);
            this.btn_ScanSer.TabIndex = 4;
            this.btn_ScanSer.Text = "扫描串口";
            this.btn_ScanSer.UseVisualStyleBackColor = true;
            this.btn_ScanSer.Click += new System.EventHandler(this.btn_ScanSer_Click);
            // 
            // box_Bund
            // 
            this.box_Bund.AutoCompleteCustomSource.AddRange(new string[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "115200"});
            this.box_Bund.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_Bund.FormattingEnabled = true;
            this.box_Bund.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "115200"});
            this.box_Bund.Location = new System.Drawing.Point(72, 49);
            this.box_Bund.Name = "box_Bund";
            this.box_Bund.Size = new System.Drawing.Size(120, 20);
            this.box_Bund.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "波特率";
            // 
            // box_ComNum
            // 
            this.box_ComNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_ComNum.FormattingEnabled = true;
            this.box_ComNum.Location = new System.Drawing.Point(72, 20);
            this.box_ComNum.Name = "box_ComNum";
            this.box_ComNum.Size = new System.Drawing.Size(120, 20);
            this.box_ComNum.TabIndex = 1;
            // 
            // 端口
            // 
            this.端口.AutoSize = true;
            this.端口.Location = new System.Drawing.Point(18, 28);
            this.端口.Name = "端口";
            this.端口.Size = new System.Drawing.Size(29, 12);
            this.端口.TabIndex = 0;
            this.端口.Text = "端口";
            // 
            // serialPort1
            // 
            this.serialPort1.ReadBufferSize = 65535;
            // 
            // box_From
            // 
            this.box_From.AutoCompleteCustomSource.AddRange(new string[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "115200"});
            this.box_From.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box_From.FormattingEnabled = true;
            this.box_From.Items.AddRange(new object[] {
            "RGB565",
            "YUV"});
            this.box_From.Location = new System.Drawing.Point(72, 75);
            this.box_From.Name = "box_From";
            this.box_From.Size = new System.Drawing.Size(120, 20);
            this.box_From.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "格式";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 233);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "form1";
            this.Text = "串口摄像头二值化阀值调节器";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_OpenSer;
        private System.Windows.Forms.Button btn_ScanSer;
        private System.Windows.Forms.ComboBox box_Bund;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox box_ComNum;
        private System.Windows.Forms.Label 端口;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox box_From;
    }
}

