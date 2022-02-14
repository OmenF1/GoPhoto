
namespace GoPhoto
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbCameraSelect = new System.Windows.Forms.ComboBox();
            this.lbSelectCamera = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.pbCameraView = new System.Windows.Forms.PictureBox();
            this.btStartCamera = new System.Windows.Forms.Button();
            this.btFullScreen = new System.Windows.Forms.Button();
            this.lbCountdown = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCameraView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCameraSelect
            // 
            this.cbCameraSelect.FormattingEnabled = true;
            this.cbCameraSelect.Location = new System.Drawing.Point(3, 25);
            this.cbCameraSelect.Name = "cbCameraSelect";
            this.cbCameraSelect.Size = new System.Drawing.Size(84, 21);
            this.cbCameraSelect.TabIndex = 0;
            // 
            // lbSelectCamera
            // 
            this.lbSelectCamera.AutoSize = true;
            this.lbSelectCamera.Location = new System.Drawing.Point(6, 9);
            this.lbSelectCamera.Name = "lbSelectCamera";
            this.lbSelectCamera.Size = new System.Drawing.Size(76, 13);
            this.lbSelectCamera.TabIndex = 1;
            this.lbSelectCamera.Text = "Select Camera";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(3, 52);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(84, 25);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // pbCameraView
            // 
            this.pbCameraView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCameraView.Location = new System.Drawing.Point(93, 52);
            this.pbCameraView.Name = "pbCameraView";
            this.pbCameraView.Size = new System.Drawing.Size(1159, 617);
            this.pbCameraView.TabIndex = 3;
            this.pbCameraView.TabStop = false;
            // 
            // btStartCamera
            // 
            this.btStartCamera.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btStartCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btStartCamera.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStartCamera.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btStartCamera.Location = new System.Drawing.Point(3, 278);
            this.btStartCamera.Name = "btStartCamera";
            this.btStartCamera.Size = new System.Drawing.Size(84, 97);
            this.btStartCamera.TabIndex = 4;
            this.btStartCamera.Text = "Start";
            this.btStartCamera.UseVisualStyleBackColor = false;
            this.btStartCamera.Click += new System.EventHandler(this.btStartCamera_Click);
            // 
            // btFullScreen
            // 
            this.btFullScreen.Location = new System.Drawing.Point(3, 83);
            this.btFullScreen.Name = "btFullScreen";
            this.btFullScreen.Size = new System.Drawing.Size(84, 25);
            this.btFullScreen.TabIndex = 5;
            this.btFullScreen.Text = "Full Screen";
            this.btFullScreen.UseVisualStyleBackColor = true;
            this.btFullScreen.Click += new System.EventHandler(this.btFullScreen_Click);
            // 
            // lbCountdown
            // 
            this.lbCountdown.BackColor = System.Drawing.Color.Transparent;
            this.lbCountdown.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountdown.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbCountdown.Location = new System.Drawing.Point(619, -1);
            this.lbCountdown.Name = "lbCountdown";
            this.lbCountdown.Size = new System.Drawing.Size(391, 50);
            this.lbCountdown.TabIndex = 6;
            this.lbCountdown.Text = "Countdown";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 530);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 139);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Get Image";
            this.groupBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "http://photobooth.co.za/12312/12312.jpg";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(57, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 101);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbCountdown);
            this.Controls.Add(this.btFullScreen);
            this.Controls.Add(this.btStartCamera);
            this.Controls.Add(this.pbCameraView);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.lbSelectCamera);
            this.Controls.Add(this.cbCameraSelect);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "GoPhoto";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCameraView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCameraSelect;
        private System.Windows.Forms.Label lbSelectCamera;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.PictureBox pbCameraView;
        private System.Windows.Forms.Button btStartCamera;
        private System.Windows.Forms.Button btFullScreen;
        private System.Windows.Forms.Label lbCountdown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

