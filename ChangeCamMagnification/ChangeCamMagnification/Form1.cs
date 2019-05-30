using System;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Threading;
using System.IO.Ports;
using System.ComponentModel;

namespace ChangeCamMagnification
{
    public partial class Form1 : Form
    {
        SerialPort com = new SerialPort();
        PomeasCam ChangeCam = new PomeasCam();
        
        long[] savelocation = new long[10];

        private void display()
        {
            
            string current_locate = Convert.ToString(savelocation[comboBox_locate.SelectedIndex]);
            if (savelocation[comboBox_locate.SelectedIndex] == -10)
                current_locate = "N/A";

            label_locate.Visible = true;
            label_pos.Visible = true;
            label_locate.Text = (comboBox_locate.SelectedIndex + 1).ToString();
            label_locate.Refresh();
            label_pos.Text = current_locate;
            label_pos.Refresh();
        }

        public Form1()
        {
            InitializeComponent();

            comboBox_locate.SelectedIndex = 0;
            for (int i = 0; i < savelocation.Length; i++)
            { savelocation[i] = -10; }

            foreach (string com in SerialPort.GetPortNames())
            {
                select_com_box.Items.Add(com);
            }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            bool checkComm = ChangeCam.OpenComm(0, select_com_box.SelectedIndex);
            if (!checkComm)
            {
                MessageBox.Show("Please check you device is avalible.");
                return;
            }
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.RunWorkerAsync();

            btn_connect.Enabled = false;
            btn_disconnect.Enabled = true;
            groupBox_dst.Enabled = true;
            groupBox_auto.Enabled = true;
            tslb_max.Visible = true;
            tslb_status.Visible = true;
            tslb_pos.Visible = true;

            tslb_max.Text = Convert.ToString(ChangeCam.MaxLength(0));
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            ChangeCam.CloseComm(0);
            backgroundWorker.WorkerReportsProgress = false;
            backgroundWorker.CancelAsync();
            btn_connect.Enabled = true;
            btn_disconnect.Enabled = false;
            groupBox_dst.Enabled = false;
            groupBox_auto.Enabled = false;
            tslb_max.Visible = false;
            tslb_status.Visible = false;
            tslb_pos.Visible = false;

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            ChangeCam.Home(0);            
        }

        private void btn_moveto_Click(object sender, EventArgs e)
        {        
            long Dst = Convert.ToInt64(this.TBox_dst.Text);
            if (Dst < 0 || Dst > ChangeCam.MaxLength(0))
            {
                MessageBox.Show("Please enter the number between 0~18500");
                return;
            }
            ChangeCam.Goto(0, Dst);            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            long locate_tmp = savelocation[comboBox_locate.SelectedIndex];
            bool datacheck = long.TryParse(textBox_save.Text, out savelocation[comboBox_locate.SelectedIndex]);

            if (Convert.ToInt64(textBox_save.Text) < 0 || Convert.ToInt64(textBox_save.Text) > ChangeCam.MaxLength(0))
            {
                MessageBox.Show("Please enter the number between 0~18500");
                savelocation[comboBox_locate.SelectedIndex] = locate_tmp;
            }
            else if (datacheck == false)
            {
                MessageBox.Show("Wrong data type entered.");
                savelocation[comboBox_locate.SelectedIndex] = locate_tmp;
            }

            display();
        }

        private void btn_memove_Click(object sender, EventArgs e)
        {
            if (savelocation[comboBox_locate.SelectedIndex] == -10)
            {
                MessageBox.Show("Please select an avalible location.");
                return;
            }
            ChangeCam.Goto(0, Convert.ToInt64(savelocation[comboBox_locate.SelectedIndex]));
        }

        private void btn_meautomove_Click(object sender, EventArgs e)
        {
            for (int i=0;i<savelocation.Length;i++)
            {                
                if (savelocation[i] == -10) continue;

                ChangeCam.Goto(0, savelocation[i]);

                label_locate.Visible = true;
                label_pos.Visible = true;

                label_locate.Text = (i + 1).ToString();
                label_locate.Refresh();

                label_pos.Text = Convert.ToString(savelocation[i]);
                label_pos.Refresh();
                do
                {
                    if (ChangeCam.Status(0) == 1) break;
                } while (true);
                Thread.Sleep(100);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            savelocation[comboBox_locate.SelectedIndex] = -10;
            display();
        }

        private void comboBox_locate_SelectedIndexChanged(object sender, EventArgs e)
        {
            display();
        }
        
        private void btn_savexml_Click(object sender, EventArgs e)
        {                       
            XDocument locatexml = new XDocument(new XDeclaration("1.0","UTF-8","yes"));
            int[] xmlSave = new int[10];

            XElement root = new XElement("DSTPOS");
            for (int i = 1; i <= 10; i++)
            {
                XElement child = new XElement("MOVETO",
                    new XElement("LOCATE", i),
                    new XElement("POSITION",
                        new XAttribute("SE", savelocation[i - 1])));

                root.Add(child);
            }
            
            SaveFileDialog savexml = new SaveFileDialog();
            savexml.DefaultExt = "xml";
            savexml.Filter = "XML file (*.xml)|*.xml";
            savexml.RestoreDirectory = true;

            if (savexml.ShowDialog() == DialogResult.OK)
            {
                locatexml = new XDocument(root);
                locatexml.Save(savexml.FileName);
            }

        }

        private void btn_loadxml_Click(object sender, EventArgs e)
        {
            OpenFileDialog openxml = new OpenFileDialog();
            openxml.InitialDirectory = ".\\";
            openxml.Filter = "XML file (*.xml|*.xml";

            if (openxml.ShowDialog() == DialogResult.OK)
            {
                var loadedxml = XDocument.Load(openxml.FileName).Element("DSTPOS").Elements("MOVETO");
                label_filename.Visible = true;
                label_filename.Text = openxml.FileName;

                foreach (var readxml in loadedxml)
                {
                    int i = Convert.ToInt16(readxml.Element("LOCATE").Value);
                    savelocation[i-1] = Convert.ToInt64(readxml.Element("POSITION").Attribute("SE").Value);
                }

                display();
            }


        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (; ; )
            {
                if (backgroundWorker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    backgroundWorker.ReportProgress(0);
                    Thread.Sleep(200);
                }
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (backgroundWorker.CancellationPending == true)
                return;

            switch (ChangeCam.Status(0))
            {
                case 0:
                    tslb_status.Text = ("Moving...");
                    break;

                case 1:
                    tslb_status.Text = ("Stop");
                    break;

                case 2:
                    tslb_status.Text = ("Error!");
                    break;
            }

            tslb_pos.Text = Convert.ToString(ChangeCam.Position(0));
        }
    }
}
