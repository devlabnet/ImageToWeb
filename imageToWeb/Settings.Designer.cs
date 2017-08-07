namespace imageToWeb {
    partial class SettingForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.lblMaxSize = new System.Windows.Forms.Label();
            this.MaxSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.MaxSizeLabel = new System.Windows.Forms.Label();
            this.QualityLabel = new System.Windows.Forms.Label();
            this.QualityTrackBar = new System.Windows.Forms.TrackBar();
            this.lblQuality = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MaxSizeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QualityTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.AutoSize = true;
            this.buttonOK.Location = new System.Drawing.Point(342, 148);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(95, 39);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(496, 148);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonCancel.Size = new System.Drawing.Size(95, 39);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // lblMaxSize
            // 
            this.lblMaxSize.AutoSize = true;
            this.lblMaxSize.Font = new System.Drawing.Font("Comic Sans MS", 8.142858F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxSize.Location = new System.Drawing.Point(13, 22);
            this.lblMaxSize.Name = "lblMaxSize";
            this.lblMaxSize.Size = new System.Drawing.Size(149, 29);
            this.lblMaxSize.TabIndex = 2;
            this.lblMaxSize.Text = "Maximum Size";
            this.lblMaxSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MaxSizeTrackBar
            // 
            this.MaxSizeTrackBar.AutoSize = false;
            this.MaxSizeTrackBar.Location = new System.Drawing.Point(173, 21);
            this.MaxSizeTrackBar.Name = "MaxSizeTrackBar";
            this.MaxSizeTrackBar.Size = new System.Drawing.Size(350, 40);
            this.MaxSizeTrackBar.TabIndex = 4;
            this.MaxSizeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.MaxSizeTrackBar.MouseCaptureChanged += new System.EventHandler(this.MaxSizeTrackBar_MouseCaptureChanged);
            // 
            // MaxSizeLabel
            // 
            this.MaxSizeLabel.AutoSize = true;
            this.MaxSizeLabel.Location = new System.Drawing.Point(553, 22);
            this.MaxSizeLabel.Name = "MaxSizeLabel";
            this.MaxSizeLabel.Size = new System.Drawing.Size(73, 29);
            this.MaxSizeLabel.TabIndex = 5;
            this.MaxSizeLabel.Text = "00000";
            this.MaxSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QualityLabel
            // 
            this.QualityLabel.AutoSize = true;
            this.QualityLabel.Location = new System.Drawing.Point(553, 76);
            this.QualityLabel.Name = "QualityLabel";
            this.QualityLabel.Size = new System.Drawing.Size(73, 29);
            this.QualityLabel.TabIndex = 8;
            this.QualityLabel.Text = "00000";
            this.QualityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QualityTrackBar
            // 
            this.QualityTrackBar.AutoSize = false;
            this.QualityTrackBar.Location = new System.Drawing.Point(173, 75);
            this.QualityTrackBar.Name = "QualityTrackBar";
            this.QualityTrackBar.Size = new System.Drawing.Size(350, 40);
            this.QualityTrackBar.TabIndex = 7;
            this.QualityTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // lblQuality
            // 
            this.lblQuality.AutoSize = true;
            this.lblQuality.Font = new System.Drawing.Font("Comic Sans MS", 8.142858F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuality.Location = new System.Drawing.Point(13, 76);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(81, 29);
            this.lblQuality.TabIndex = 6;
            this.lblQuality.Text = "Quality";
            this.lblQuality.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::imageToWeb.Properties.Resources.united_states_of_america_flag_3d_round_icon_64;
            this.pictureBox2.Location = new System.Drawing.Point(106, 141);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.UsClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::imageToWeb.Properties.Resources.france_flag_3d_round_icon_64;
            this.pictureBox1.Location = new System.Drawing.Point(31, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.FrClicked);
            // 
            // SettingForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(642, 212);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.QualityLabel);
            this.Controls.Add(this.QualityTrackBar);
            this.Controls.Add(this.lblQuality);
            this.Controls.Add(this.MaxSizeLabel);
            this.Controls.Add(this.MaxSizeTrackBar);
            this.Controls.Add(this.lblMaxSize);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.142858F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.ShowInTaskbar = false;
            this.Text = "Settings0";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.MaxSizeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QualityTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label lblMaxSize;
        private System.Windows.Forms.TrackBar MaxSizeTrackBar;
        private System.Windows.Forms.Label MaxSizeLabel;
        private System.Windows.Forms.Label QualityLabel;
        private System.Windows.Forms.TrackBar QualityTrackBar;
        private System.Windows.Forms.Label lblQuality;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}