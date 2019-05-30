using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.ComponentModel;
using System.Threading;

namespace HPSC_1005_4_LS
{
    public partial class BrightnessChange : Form
    {
        LightSource com = new LightSource();
        bool ComOpen = false;

        public BrightnessChange ()
        {
            InitializeComponent();

            foreach (string com in SerialPort.GetPortNames())
            {
                comboBox_com.Items.Add(com);
            }
            if (comboBox_com.Items.Count > 0)
            { comboBox_com.SelectedIndex = 0; }

            for (int i = 0x00; i <=0xFF; i++)
            {
                comboBox_id.Items.Add(string.Format("{0:x2}",i).ToUpper());
                comboBox_idchg.Items.Add(string.Format("{0:x2}", i).ToUpper());
            }
            comboBox_id.SelectedIndex = 0;
        }

        private void btn_con_Click(object sender, EventArgs e)
        {
            if (ComOpen == false )//&& !com.IsOpen())
            {
                try
                {
                    com.ConnectSet(comboBox_com.Text);
                    com.Open();
                    ComOpen = true;
                    comboBox_com.Enabled = false;
                    groupBox_brightch.Enabled = true;
                    groupBox_id.Enabled = true;
                    btn_con.Text = "Disconnect";
                }
                catch
                {
                    MessageBox.Show("Please check this port is not occupied.");
                }
            }
            else if (ComOpen = true && com.IsOpen())
            {
                com.Close();
                if (!com.IsOpen())
                {
                    bkWorker.WorkerReportsProgress = false;
                    bkWorker.CancelAsync();
                    bkWorker.Dispose();
                    ComOpen = false;
                    comboBox_com.Enabled = true;
                    groupBox_brightch.Enabled = false;
                    groupBox_id.Enabled = false;
                    btn_idsec.Enabled = true;
                    btn_idresel.Enabled = false;
                    comboBox_id.Enabled = true;
                    btn_con.Text = "Connect";
                    label_curid.Text = "N/A";
                    label1_L1b.Text = "N/A";
                    label1_L2b.Text = "N/A";
                    label1_L3b.Text = "N/A";
                    label1_L4b.Text = "N/A";
                    return;
                }
            }
        }

        private void btn_brichg_Click(object sender, EventArgs e)
        {
            try
            {
                int L1 = -1, L2 = -1, L3 = -1, L4 = -1;

                if (checkBox_L1.Checked)
                {
                    L1 = Convert.ToInt16(numericUpDown_L1.Value);
                }
                if (checkBox_L2.Checked)
                {
                    L2 = Convert.ToInt16(numericUpDown_L2.Value);
                }
                if (checkBox_L3.Checked)
                {
                    L3 = Convert.ToInt16(numericUpDown_L3.Value);
                }
                if (checkBox_L4.Checked)
                {
                    L4 = Convert.ToInt16(numericUpDown_L4.Value);
                }

                com.ChangeBrightness(label_curid.Text, L1, L2, L3, L4);
            }
            catch
            {
                MessageBox.Show("Please select an id.");
            }
        }

        private void btn_chgid_Click(object sender, EventArgs e)
        {
            label_curid.Text = comboBox_idchg.Text;
            com.ChangeID(comboBox_id.Text,comboBox_idchg.Text);
        }

        private void btn_idsec_Click(object sender, EventArgs e)
        {
            label_curid.Text = comboBox_id.Text;
            label_curid.Refresh();
            bkWorker.WorkerReportsProgress = true;
            bkWorker.RunWorkerAsync();
            comboBox_id.Enabled = false;
            btn_idsec.Enabled = false;
            btn_idresel.Enabled = true;
        }

        private void btn_idresel_Click(object sender, EventArgs e)
        {
            bkWorker.CancelAsync();
            bkWorker.Dispose();
            comboBox_id.Enabled = true;
            btn_idsec.Enabled = true;
            btn_idresel.Enabled = false;
            com.DiscardInBuffer();
            label_curid.Text = "N/A";
            label1_L1b.Text = "N/A";
            label1_L2b.Text = "N/A";
            label1_L3b.Text = "N/A";
            label1_L4b.Text = "N/A";
        }
        
        private void bkWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (; ; )
            {
                if (bkWorker.CancellationPending == true)
                {
                    e.Cancel = true;
                    bkWorker.Dispose();
                    bkWorker.WorkerReportsProgress = false;
                    return;
                }
                Thread.Sleep(50);
                bkWorker.ReportProgress(0);
            }
        }

        private void bkWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (bkWorker.CancellationPending == true)
                return;

            byte[] showOnUI = new byte[11];
            showOnUI = com.ShowBrightness(label_curid.Text);

            if (showOnUI[10] == 0)
            {
                label1_L1b.Text = "N/A";
                label1_L2b.Text = "N/A";
                label1_L3b.Text = "N/A";
                label1_L4b.Text = "N/A";
                return;
            }

            com.DiscardInBuffer();
            label1_L1b.Text = showOnUI[5].ToString();
            label1_L2b.Text = showOnUI[6].ToString();
            label1_L3b.Text = showOnUI[7].ToString();
            label1_L4b.Text = showOnUI[8].ToString();
        }

        private void BrightnessChange_FormClosing(object sender, FormClosingEventArgs e)
        {
            bkWorker.CancelAsync();
            bkWorker.WorkerReportsProgress = false;
            bkWorker.Dispose();
        }
    }
}
