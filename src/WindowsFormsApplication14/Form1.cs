using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication14
{
    public partial class form1 : Form
    {
        Bitmap OvImage = new Bitmap(120, 160);  
        public form1()
        {
            InitializeComponent();
            serialPort1.Encoding = Encoding.GetEncoding("GB2312");                                  //串口接收编码
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(PortDataReceivedEvent); //串口数据接收事件 
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;                   //
        }
        int serReadStat = 1;
        private void PortDataReceivedEvent(object sender, SerialDataReceivedEventArgs args) //串口数据接收
        {
            int count;
            int i, j;
            /**
             * 当状态为1的时候
             * */
            if(serReadStat == 1)
            {
                count = serialPort1.BytesToRead;
                if(count == 1)
                {
                    byte[] Data = new byte[serialPort1.BytesToRead];
                    serialPort1.Read(Data, 0, Data.Length);//读
                    foreach (byte MyData in Data)
                    {
                        if(MyData == (byte)0xa0)
                        {
                            serReadStat = 2;
                        }
                    }
                }
            }
            /**
             * 当状态为2的时候
             * */
            if(serReadStat == 2)
            {
                count = serialPort1.BytesToRead;
                if (count == 1)
                {
                    byte[] Data = new byte[serialPort1.BytesToRead];
                    serialPort1.Read(Data, 0, Data.Length);//读
                    foreach (byte MyData in Data)
                    {
                        if (MyData == (byte)0x00)
                        {
                            serReadStat = 3;
                        }
                    }
                }
            }
            /**
             * 开始存数据
             * */
            if (serReadStat == 2)
            {
                count = serialPort1.BytesToRead;
                if (count == 38400)
                {
                    byte[] Data = new byte[serialPort1.BytesToRead];
                    serialPort1.Read(Data, 0, Data.Length);//读
                    for (i = 0; i < 120; i++)
                    {
                        for (j = 0; j < 160; j++)
                        {
                            Int32 n565Color = Data[i * j * 2] + ((Int32)Data[i * j * 2 + 1] << 8);
                            Int32 cRed = (n565Color & 0xf800) >> 8;
                            Int32 cGreen = (n565Color & 0x07e0) >> 3;
                            Int32 cBlue = (n565Color & 0x001f) << 3;
                            Color newColor = Color.FromArgb(cRed, cGreen, cBlue);
                            OvImage.SetPixel(i, j, newColor);
                        }
                    }
                    pictureBox1.Image = OvImage;   
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();

            int i = 0;
            int j = 0;
            byte[] Data = new byte[38400];
            for (i = 0; i < 120; i++)
            {
                for (j = 0; j < 160; j++)
                {
                    int rg = rd.Next();
                    Data[i * j * 2] = (byte)rg;
                    Data[i * j * 2 + 1] = (byte)rg;
                }
            }
            for (i = 0; i < 120; i++)
            {
                for (j = 0; j < 160; j++)
                {
                    Int32 n565Color = Data[i * j * 2] + ((Int32)Data[i * j * 2 + 1] << 8);
                    Int32 cRed = (n565Color & 0xf800) >> 8;
                    Int32 cGreen = (n565Color & 0x07e0) >> 3;
                    Int32 cBlue = (n565Color & 0x001f) << 3;
                    Color newColor = Color.FromArgb(cRed, cGreen, cBlue);
                    OvImage.SetPixel(i, j, newColor);  
                }
            }
            pictureBox1.Image = OvImage;
        }

        private void btn_ScanSer_Click(object sender, EventArgs e)
        {
            SerchAndAddSerialToComboBox(serialPort1, box_ComNum);
        }
        private void SerchAndAddSerialToComboBox(SerialPort MyPort, ComboBox MyBox)
        {
            string Buffer = "";
            MyBox.Items.Clear();
            for (int i = 1; i < 20; i++)
            {
                try
                {
                    Buffer = "COM" + i.ToString();
                    MyPort.PortName = Buffer;
                    MyPort.Open();
                    MyBox.Items.Add(Buffer);
                    MyPort.Close();
                }
                catch
                {
                    //
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                }
                catch { }
                btn_OpenSer.Text = "打开串口";
            }
            else
            {
                try
                {
                    serialPort1.PortName = box_ComNum.Text;
                    serialPort1.BaudRate = Convert.ToInt32(box_Bund.Text, 10);//切换波特率
                    serialPort1.Open();
                    btn_OpenSer.Text = "关闭串口";
                }
                catch
                {
                    MessageBox.Show("打开串口失败", "错误");
                }
            }
        }
    }
}
