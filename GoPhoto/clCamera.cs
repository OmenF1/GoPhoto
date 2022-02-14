using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
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

        public clCamera(PictureBox _pictureBox)
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
            pBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        public void Close()
        {
            if (videoCaptureDevice.IsRunning == true)
                videoCaptureDevice.Stop();
        }

        public async void  save_Click()
        {
            if (pBox.Image != null)
            {
                Bitmap imageOne;
                Bitmap imageTwo;
                Bitmap imageFinal;
                //Save First
                Bitmap varBmp = new Bitmap(pBox.Image);
                imageOne = new Bitmap(varBmp);
                await Task.Delay(3600);
                varBmp = new Bitmap(pBox.Image);
                imageTwo = new Bitmap(varBmp);
                imageFinal = new Bitmap(MergeTwoImages(imageOne, imageTwo));
                imageFinal.Save(@"C:\Users\Owen\Desktop\test.jpg", ImageFormat.Jpeg);




                //newBitmap
                ////Now Dispose to free the memory
                imageOne.Dispose();
                imageOne = null;
                imageTwo.Dispose();
                imageTwo = null;
                imageFinal.Dispose();
                imageFinal = null;
                Console.WriteLine("Saved!");
            }
            else
            { MessageBox.Show("null exception"); }
        }

        public Bitmap TakePhoto()
        {
            using(Bitmap image = new Bitmap(pBox.Image))
            {
                Bitmap img = new Bitmap(image);
                return img;
            }

        }

        public Bitmap MergeTwoImages(Image firstImage, Image secondImage)
        {
            if (firstImage == null)
            {
                throw new ArgumentNullException("firstImage");
            }

            if (secondImage == null)
            {
                throw new ArgumentNullException("secondImage");
            }

            int outputImageWidth = firstImage.Width > secondImage.Width ? firstImage.Width : secondImage.Width;

            int outputImageHeight = firstImage.Height + secondImage.Height + 1;

            Bitmap outputImage = new Bitmap(outputImageWidth, outputImageHeight, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            using (Graphics graphics = Graphics.FromImage(outputImage))
            {
                graphics.DrawImage(firstImage, new Rectangle(new Point(), firstImage.Size),
                    new Rectangle(new Point(), firstImage.Size), GraphicsUnit.Pixel);
                graphics.DrawImage(secondImage, new Rectangle(new Point(0, firstImage.Height + 1), secondImage.Size),
                    new Rectangle(new Point(), secondImage.Size), GraphicsUnit.Pixel);
            }

            return outputImage;
        }
    }
}
