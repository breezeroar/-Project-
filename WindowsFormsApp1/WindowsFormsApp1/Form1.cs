using System;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text;
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        char[] sendCMD = new char[20];
        byte[] sht = { 0x4D,0x56,0x41, 0x20, 0x52, 0x31, 0x20, 0x35, 0x30, 0x30, 0x30, 0x0D};
        byte[] ss = { 0x4D, 0x56, 0x41, 0x20, 0x52, 0x31, 0x20, 0x2D, 0x35, 0x30, 0x30, 0x30, 0x0D };
        string[] cow = new string[20];
        string go = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SerialPort com = new SerialPort("COM2", 115200, Parity.None, 8, StopBits.One);
            com.Open();/*
            go = "MVA R1 3000.";
            sht = Encoding.ASCII.GetBytes(go);
            for (int i = 0; i < sht.Length; i++)
            {
                ss[i] = byte.Parse(sht[i].ToString(), NumberStyles.HexNumber);
            }
            
            sendCMD = go.ToCharArray();
            for (int i = 0; i < sendCMD.Length; i++)
            {
                sht[i] = byte.Parse(sendCMD[i].ToString(), NumberStyles.HexNumber);
            }
            com.Write(sht, 0, sht.Length);*/
            com.Write("MVA R1 10000\r");
            Thread.Sleep(1000);/*
            go = "MVA R1 -3000.";
            sht = Encoding.ASCII.GetBytes(go);
            for (int i = 0; i < sht.Length; i++)
            {
                ss[i] = byte.Parse(sht[i].ToString(), NumberStyles.HexNumber);
            }
            sendCMD = go.ToCharArray();
            for (int i = 0; i < sendCMD.Length; i++)
            {
                sht[i] = byte.Parse(sendCMD[i].ToString(), NumberStyles.HexNumber);
            }*/
            com.Write("MVA R1 0\r");
            Thread.Sleep(1000);
            com.Write("MVA T 5000\r");
            Thread.Sleep(1000);
            com.Write("MVA R2 5000\r");
            Thread.Sleep(1000);
            com.Write("MVA T -1000\r");
            Thread.Sleep(1000);
            com.Write("MVA R2 2000\r");
            Thread.Sleep(1000);
            com.Write("MVA R1 10000\r");
            Thread.Sleep(1000);
            com.Write("MVA R2 10000\r");
            Thread.Sleep(1000);
            com.Write("MVA T -5000\r");
            Thread.Sleep(1000);
            com.Write("MVA T 0\r");
            Thread.Sleep(1000);
            com.Write("MVA R1 0\r");
            Thread.Sleep(1000);
            com.Write("MVA R2 0\r");
            Thread.Sleep(1000);
            com.DiscardInBuffer();
            com.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this bt2");
        }
    }
}
