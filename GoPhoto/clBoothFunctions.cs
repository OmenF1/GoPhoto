using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoPhoto
{
    class clBoothFunctions
    {
        public System.Windows.Forms.Label cLabel;
        public clCamera camera;
        System.Windows.Forms.Timer timer1;
        private int duration = 5;
        private int loopCount = 0;

        public clBoothFunctions(ref System.Windows.Forms.PictureBox _pBox , ref System.Windows.Forms.Label _cLabel)
        {
            cLabel = _cLabel;
            camera = new clCamera(ref _pBox);
        }


        private void count_down(object sender, EventArgs e)
        {

            if (duration == 0)
            {
                cLabel.Text = "Say Cheese!";
                timer1.Stop();
                Task.Delay(2000);
                duration = 5;
                camera.images.Add(camera.TakePhoto());
                if (loopCount < 3)
                {
                    loopCount++;

                    timer1.Start();
                }
                else
                {
                    loopCount = 0;
                    using (Bitmap imageFinal = new Bitmap(camera.GeneratePostCard(camera.images[0], camera.images[1], camera.images[2], camera.images[3])))
                    {
                        imageFinal.Save(@"C:\Temp\test.jpg", ImageFormat.Jpeg);
                    }
                    foreach (Bitmap item in camera.images)
                    {
                        item.Dispose();
                    }
                    camera.images.Clear();
                    cLabel.Text = "Countdown";
                }

            }
            else if (duration > 0)
            {
                duration--;
                cLabel.Text = duration.ToString();
            }
        }

        public void NewBoothPhoto()
        {
            
            camera.images = new List<Bitmap>();
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(count_down);
            timer1.Interval = 1000;
            timer1.Start();
        }
    }
}
