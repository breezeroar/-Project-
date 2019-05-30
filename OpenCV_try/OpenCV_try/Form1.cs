using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace OpenCV_try
{
    public partial class OpenCV_Test : Form
    {
        public OpenCV_Test()
        {
            InitializeComponent();
        }

        Mat imgTemp = null;        

        private void button_loadimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
                textBox_path.Text = open.FileName;
        }

        private void button_original_Click(object sender, EventArgs e)
        {
            Image<Bgr, byte> originalImage = new Image<Bgr, byte>(textBox_path.Text).Resize(400, 400, Inter.Linear);
            imgTemp = originalImage.Mat;
            //pictureBox.Image = originalImage.ToBitmap();
        }

        private void button_color_Click(object sender, EventArgs e)
        {
            Image<Bgr,byte> colorImage = new Image<Bgr, byte>(imgTemp.Bitmap).Resize(400, 400, Inter.Linear);
            imgTemp = colorImage.Mat;
            //pictureBox.Image = colorImage.ToBitmap();
        }

        private void button_gray_Click(object sender, EventArgs e)
        {
            Image<Gray, byte> grayImage = new Image<Gray, byte>(imgTemp.Bitmap).Resize(400, 400, Inter.Linear);
            imgTemp = grayImage.Mat;
            //pictureBox.Image = grayImage.ToBitmap();

        }

        private void button_threshold_Click(object sender, EventArgs e)
        {
            Gray thresholdValue = new Gray(55);
            Image<Gray, byte> thresholdImage = imgTemp.ToImage<Gray, byte>().ThresholdBinary(thresholdValue, new Gray(255));
            imgTemp = thresholdImage.Mat;
            //pictureBox.Image = thresholdImage.ToBitmap();
        }

        private void button_erode_Click(object sender, EventArgs e)
        {
            Image<Gray, byte> erodeImage = imgTemp.ToImage<Gray, byte>().Erode(2);
            imgTemp = erodeImage.Mat;
            //pictureBox.Image = erodeImage.ToBitmap();
        }

        private void textBox_path_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Image<Bgr, byte> loadImage = new Image<Bgr, byte>(textBox_path.Text).Resize(400, 400, Inter.Linear);
                imgTemp = loadImage.Mat;
                //pictureBox.Image = loadImage.ToBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}