using System;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Basler.Pylon;
using System.Drawing;

namespace OpenCV_Basler_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Camera Cam = new Camera();

        private void Form1_Load(object sender, EventArgs e)
        {/*
            MessageBox.Show(Cam.CameraInfo[CameraInfoKey.ModelName]);
            Cam.Open();
            Cam.StreamGrabber.Start();

            IGrabResult grabResult = Cam.StreamGrabber.RetrieveResult(5000, TimeoutHandling.ThrowException);
            pictureBox.Image = grabResult.;*/
        }

        private void GetBuffer(Byte[] imageBuffer, long width, long height, int camIndex)
        {
            int w = (int)width;
            int h = (int)height;
            Bitmap bmp;
            BitmapFactory.CreateBitmap(out bmp, w, h, false);
            BitmapFactory.UpdateBitmap(bmp, imageBuffer, w, h, false);
            Image<Gray, byte> img = new Image<Gray, byte>(bmp);
            Image<Rgb, byte> imgRgb = new Image<Rgb, byte>(img.Size);
            CvInvoke.CvtColor(img, imgRgb, ColorConversion.BayerRg2Rgb);
            CvInvoke.Imshow(camIndex.ToString(), imgRgb);
        }
    }
}
