using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.ComponentModel;
using System.Threading;
using System.Text;

namespace MilaraRobotControl
{
    public partial class Form : System.Windows.Forms.Form
    {
        SerialPort Com;
        char[] CpoRead = new char[30];
        char[] SpdRead = new char[30];
        byte[] StaRead = new byte[16];
        byte[] PerRead = new byte[12];

        public Form()
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
                    bkWorker_cpo.WorkerReportsProgress = true;
                    btn_home.Enabled = true;
                    groupBox_moveMent.Enabled = true;
                    groupBox_spdSetting.Enabled = true;
                    groupBox_systemControl.Enabled = true;
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
                    btn_Connect.Text = "Connect";
                    comboBox_PortSelect.Enabled = true;
                    btn_home.Enabled = false;
                    groupBox_moveMent.Enabled = false;
                    groupBox_spdSetting.Enabled = false;
                    groupBox_systemControl.Enabled = false;
                    label_tCpo.Text = "N/A";
                    label_r1Cpo.Text = "N/A";
                    label_r2Cpo.Text = "N/A";
                    label_zCpo.Text = "N/A";
                    bkWorker_cpo.WorkerReportsProgress = false;
                    bkWorker_cpo.CancelAsync();
                    return;
                }
            }
        }

        private void bkWorker_cpo_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (bkWorker_cpo.CancellationPending == true)
                {
                    e.Cancel = true;
                    bkWorker_cpo.Dispose();
                    bkWorker_cpo.WorkerReportsProgress = false;
                    break;
                }
                Thread.Sleep(100);
                bkWorker_cpo.ReportProgress(0);
            }
        }

        private void bkWorker_cpo_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (bkWorker_cpo.CancellationPending == true)
            { return; }
            
            Com.Write("CPO\r");
            Com.Read(CpoRead, 0, CpoRead.Length);
            Com.Write("SPD\r");
            Com.Read(SpdRead, 0, SpdRead.Length);
            string cpoStr = new string(CpoRead);
            string spdStr = new string(SpdRead);
            string[] cpoResult = cpoStr.Split(',');
            string[] spdResult = spdStr.Split(',');
            label_tCpo.Text = cpoResult[0] + "/" + spdResult[0];
            label_r1Cpo.Text = cpoResult[1] + "/" + spdResult[1];
            label_r2Cpo.Text = cpoResult[2] + "/" + spdResult[2];
            label_zCpo.Text = cpoResult[3] + "/" + spdResult[3];

            Com.Write("STA\r");
            Com.Read(StaRead, 0, StaRead.Length);

            for (int i = 0; i < StaRead.Length; i++)
            {
                switch (StaRead[i])
                {
                    case 0:
                        ((CheckBox)Controls.Find("checkBox" + (i + 1).ToString(),true)[0]).Checked = false;
                        break;
                    case 1:
                        ((CheckBox)Controls.Find("checkBox" + (i + 1).ToString(),true)[0]).Checked = true;
                        break;
                }
            }            
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Com.Write("HOM\r");
            Thread.Sleep(100);
            Com.Write("RMP\r");
        }

        private void btn_powerSwitch_Click(object sender, EventArgs e)
        {
            Com.Write("PER\r");
            Com.Read(PerRead, 0, PerRead.Length);
            if (PerRead[11] == 1)
            {
                Com.Write(".POW\r");
                toolStripStatusLabel_PowerStatus.Text = "ON";
            }
            else
            {
                Com.Write(".NOP\r");
                toolStripStatusLabel_PowerStatus.Text = "off";
            }
        }

        private void btn_servoSwitch_Click(object sender, EventArgs e)
        {
            if (StaRead[10] == 1)
            {
                Com.Write("SON\r");
            }
            else
            {
                Com.Write("SOF\r");
            }
        }

        private void btn_vacuumSwitch_Click(object sender, EventArgs e)
        {
            if (StaRead[3] == 0)
            {
                Com.Write("VON\r");
            }
            else
            {
                Com.Write("VOF\r");
            }
        }

        private void button_resetRobot_Click(object sender, EventArgs e)
        {
            Com.Write(".RES\r");
        }

        private void button_tAction_Click(object sender, EventArgs e)
        {
            Com.Write("MVA T " + numericUpDown_tPosition.Value.ToString() + "\r");
        }

        private void button_r1Action_Click(object sender, EventArgs e)
        {
            Com.Write("MVA R1 " + numericUpDown_r1Position.Value.ToString() + "\r");
        }

        private void button_r2Action_Click(object sender, EventArgs e)
        {
            Com.Write("MVA R2 " + numericUpDown_r2Position.Value.ToString() + "\r");
        }

        private void button_zAction_Click(object sender, EventArgs e)
        {
            Com.Write("MVA Z " + numericUpDown_zPosition.Value.ToString() + "\r");
        }

        private void button_tParameterSet_Click(object sender, EventArgs e)
        {
            Com.Write(comboBox_axisParameter.Text + " T " + numericUpDown_tSpd.Value.ToString() + "\r");
        }

        private void button_r1ParameterSet_Click(object sender, EventArgs e)
        {
            Com.Write(comboBox_axisParameter.Text + " R1 " + numericUpDown_r1Spd.Value.ToString() + "\r");
        }

        private void button_r2ParameterSet_Click(object sender, EventArgs e)
        {
            Com.Write(comboBox_axisParameter.Text + " R2 " + numericUpDown_r2Spd.Value.ToString() + "\r");
        }

        private void button_zParameterSet_Click(object sender, EventArgs e)
        {
            Com.Write(comboBox_axisParameter.Text + " Z " + numericUpDown_zSpd.Value.ToString() + "\r");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

