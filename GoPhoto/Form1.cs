using System;
using System.Windows.Forms;

namespace GoPhoto
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        clBoothFunctions booth;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            booth = new clBoothFunctions(ref pbCameraView, ref lbCountdown);
            pbCameraView.SizeMode = PictureBoxSizeMode.StretchImage;
            cbCameraSelect.DataSource = booth.camera.inputDevices;
            cbCameraSelect.SelectedIndex = -1;

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            booth.camera.Start(cbCameraSelect.SelectedIndex);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            booth.camera.Close();
        }

        // I'll Move this to a class at a later stage.
        private void btStartCamera_Click(object sender, EventArgs e)
        {
            booth.NewBoothPhoto();
        }

        // I'll move this to class at a later stage as well as do some stuff in the config for this.
        private void btFullScreen_Click(object sender, EventArgs e)
        {
            
            if(btFullScreen.Text == "Full Screen")
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                btFullScreen.Text = "Window Mode";
            }
            else
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                btFullScreen.Text = "Full Screen";
            }
        }


    }
}
