﻿namespace imageToWeb {
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
            ((System.ComponentModel.ISupportInitialize)(this.MaxSizeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QualityTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.AutoSize = true;
            this.buttonOK.Location = new System.Drawing.Point(180, 154);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(95, 33);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(361, 154);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonCancel.Size = new System.Drawing.Size(95, 33);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // lblMaxSize
            // 
            this.lblMaxSize.AutoSize = true;
            this.lblMaxSize.Location = new System.Drawing.Point(13, 22);
            this.lblMaxSize.Name = "lblMaxSize";
            this.lblMaxSize.Size = new System.Drawing.Size(159, 23);
            this.lblMaxSize.TabIndex = 2;
            this.lblMaxSize.Text = "Maximum Size";
            this.lblMaxSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MaxSizeTrackBar
            // 
            this.MaxSizeTrackBar.Location = new System.Drawing.Point(173, 21);
            this.MaxSizeTrackBar.Name = "MaxSizeTrackBar";
            this.MaxSizeTrackBar.Size = new System.Drawing.Size(350, 80);
            this.MaxSizeTrackBar.TabIndex = 4;
            this.MaxSizeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.MaxSizeTrackBar.MouseCaptureChanged += new System.EventHandler(this.MaxSizeTrackBar_MouseCaptureChanged);
            // 
            // MaxSizeLabel
            // 
            this.MaxSizeLabel.AutoSize = true;
            this.MaxSizeLabel.Location = new System.Drawing.Point(553, 22);
            this.MaxSizeLabel.Name = "MaxSizeLabel";
            this.MaxSizeLabel.Size = new System.Drawing.Size(75, 23);
            this.MaxSizeLabel.TabIndex = 5;
            this.MaxSizeLabel.Text = "00000";
            this.MaxSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QualityLabel
            // 
            this.QualityLabel.AutoSize = true;
            this.QualityLabel.Location = new System.Drawing.Point(553, 76);
            this.QualityLabel.Name = "QualityLabel";
            this.QualityLabel.Size = new System.Drawing.Size(75, 23);
            this.QualityLabel.TabIndex = 8;
            this.QualityLabel.Text = "00000";
            this.QualityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QualityTrackBar
            // 
            this.QualityTrackBar.Location = new System.Drawing.Point(173, 75);
            this.QualityTrackBar.Name = "QualityTrackBar";
            this.QualityTrackBar.Size = new System.Drawing.Size(350, 80);
            this.QualityTrackBar.TabIndex = 7;
            this.QualityTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // lblQuality
            // 
            this.lblQuality.AutoSize = true;
            this.lblQuality.Location = new System.Drawing.Point(13, 76);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(85, 23);
            this.lblQuality.TabIndex = 6;
            this.lblQuality.Text = "Quality";
            this.lblQuality.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.Controls.Add(this.QualityLabel);
            this.Controls.Add(this.QualityTrackBar);
            this.Controls.Add(this.lblQuality);
            this.Controls.Add(this.MaxSizeLabel);
            this.Controls.Add(this.MaxSizeTrackBar);
            this.Controls.Add(this.lblMaxSize);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.ShowInTaskbar = false;
            this.Text = "Settings0";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.MaxSizeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QualityTrackBar)).EndInit();
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
    }
}