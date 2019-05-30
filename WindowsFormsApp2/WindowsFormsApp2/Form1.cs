using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        SerialPort com = new SerialPort();

        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            com.PortName = "COM1";
            com.BaudRate = 19200;
            com.DataBits = 8;
            com.Parity = Parity.None;
            com.StopBits = StopBits.One;
            com.Encoding = Encoding.Default;
            com.Open();
            
            byte[] readbri = { 0x40, 0x04, 0x03, 0xff, 0x31, 0xff, 0x76 };
            com.Write(readbri, 0, readbri.Length);

            byte[] readedbri = new byte[10];

            com.Read(readedbri, 0, readedbri.Length);
            string showread = null;
            for (int i = 0; i < readedbri.Length; i++)
            {
                showread = showread +" "+ Convert.ToString(readedbri[i],16);
            }

            MessageBox.Show(showread.ToUpper());

            //byte[] readedbri = new byte[com.BytesToRead];
            /*
            if (backgroundWorker.IsBusy != true)
            {
                backgroundWorker.WorkerReportsProgress = true;
                backgroundWorker.RunWorkerAsync();
            }*/
        }
        /*
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (; ; )
            {
                backgroundWorker.ReportProgress(0);
                Thread.Sleep(200);
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lb1.Text = DateTime.Now.ToString();
            lb1.Refresh();
        }*/
    }
}
