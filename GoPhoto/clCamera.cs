using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoPhoto
{
    class clCamera
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        public List<String> inputDevices;
        public PictureBox pBox;
        public List<Bitmap> images;

        public clCamera(ref PictureBox _pictureBox)
        {
            RefreshCameras();
            pBox = _pictureBox;
        }

        public void RefreshCameras()
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (filterInfoCollection.Count == 0)
            {
                MessageBox.Show("No Input Devices Detected.");
            }

            inputDevices = new List<string>();
            foreach (FilterInfo device in filterInfoCollection)
            {
                inputDevices.Add(device.Name);
            }
        }
        
        public void Start(int camera)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[camera].MonikerString);
            videoCaptureDevice.NewFrame += FinalFrame_NewFrame;
            videoCaptureDevice.Start();
        }

        //c# webcam capture picture
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                Bitmap oldBitmap = (Bitmap)pBox.BackgroundImage;
                pBox.BackgroundImage = (Bitmap)eventArgs.Frame.Clone();
                if (oldBitmap != null)
                {
                    oldBitmap.Dispose();
                }

            }
            catch (Exception e)
            {

            }

            
        }

        public void Close()
        {
            if (videoCaptureDevice.IsRunning == true)
                videoCaptureDevice.Stop();
        }


        public Bitmap TakePhoto()
        {
            using (Bitmap image = (Bitmap)pBox.BackgroundImage)
            {
                Bitmap img = new Bitmap(image);
                return img;
            }

        }


        public Bitmap GeneratePostCard(Image image1, Image image2, Image image3, Image image4)
        {
            Bitmap bmp = new Bitmap(1800, 1200, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawImage(image1, 72, 75, 800, 500);
                g.DrawImage(image2, 926, 75, 800, 500);
                g.DrawImage(image3, 72, 625, 800, 500);
                g.DrawImage(image4, 926, 625, 800, 500);
            }
            return bmp;

        }

    }
}
