using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;

namespace MilaraRobotCycleTest
{
    public partial class Form1 : Form
    {
        SerialPort Com;
        int TestCount = 1;
        string convertToText;
        char[] ReadRobotReply = new char[5];
        byte[] RecieveFromRobot = new byte[16];

        public Form1()
        {
            InitializeComponent();

            foreach (string comName in SerialPort.GetPortNames())
            {
                comboBox_PortSelect.Items.Add(comName);
            }
            if (comboBox_PortSelect.Items.Count > 0)
            { comboBox_PortSelect.SelectedIndex = 0; }
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {

            if (!Com.IsOpen)
            {
                try
                {
                    Com = new SerialPort(comboBox_PortSelect.Text, 115200, Parity.None, 8, StopBits.One);
                    Com.Encoding = Encoding.Default;
                    Com.Open();
                    Com.Write(".POW\r");
                    Thread.Sleep(500);
                    Com.Write("SON\r");
                    comboBox_PortSelect.Enabled = false;
                    btn_Connect.Text = "Disconnect";
                }
                catch
                {
                    MessageBox.Show("Please check this port is not occupied.");
                }
            }
            else if (Com.IsOpen)
            {
                Com.Close();
                if (!Com.IsOpen)
                {
                    comboBox_PortSelect.Enabled = true;
                    return;
                }
            }
        }

        private void button_loadTxt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openCmdFile = new OpenFileDialog();
            openCmdFile.InitialDirectory = ".\\";
            openCmdFile.Filter = "TXT File (*.txt|*.txt";

            string tmpRead;

            if (openCmdFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader readCmd = new StreamReader(@openCmdFile.FileName);
                tmpRead = readCmd.ReadToEnd();
                richTextBox_cmdInput.Text = tmpRead;
            }
        }

        private void button_testAction_Click(object sender, EventArgs e)
        {
            if (bkWorker_action.IsBusy == false)
            {
                TestCount = 1;
                richTextBox_replayFromRobot.Clear();
                bkWorker_action.WorkerReportsProgress = true;
                bkWorker_action.RunWorkerAsync();
                richTextBox_cmdInput.Enabled = false;
                button_testAction.Text = "Stop!";
            }
            else
            {
                bkWorker_action.WorkerReportsProgress = false;
                richTextBox_cmdInput.Enabled = true;
                bkWorker_action.CancelAsync();
                bkWorker_action.Dispose();
                button_testAction.Text = "Action!";
            }
        }

        private void richTextBox_replayFromRobot_TextChanged(object sender, EventArgs e)
        {
            richTextBox_replayFromRobot.SelectionStart = richTextBox_replayFromRobot.TextLength;
            richTextBox_replayFromRobot.ScrollToCaret();
        }

        private void bkWorker_action_DoWork(object sender, DoWorkEventArgs e)
        {
            while(true)
            {
                if (bkWorker_action.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    bkWorker_action.ReportProgress(0);
                    Thread.Sleep(500);
                }
            }
        }

        private void bkWorker_action_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            richTextBox_replayFromRobot.AppendText("=========Test " + TestCount + " =========\r");
            TestCount++;

            for (int i = 0; i < richTextBox_cmdInput.Lines.Length; i++)
           {
                Com.Write(richTextBox_cmdInput.Lines[i] + "\r");
                Com.Read(ReadRobotReply, 0, ReadRobotReply.Length);
                convertToText = new string(ReadRobotReply);
                richTextBox_replayFromRobot.AppendText(convertToText + "\r");

                Thread.Sleep(100);

                Com.Write("STA\r");
                RecieveFromRobot = Encoding.Default.GetBytes(ReadRobotReply);
                while (RecieveFromRobot[7] == 1 || RecieveFromRobot[8] ==1)
                {
                    Thread.Sleep(100);
                    Com.Write("STA\r");
                }
            }
        }
    }
}
