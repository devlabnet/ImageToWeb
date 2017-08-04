namespace imageToWeb {
    partial class Settings {
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
            this.label1 = new System.Windows.Forms.Label();
            this.MaxSizeTrackBar = new System.Windows.Forms.TrackBar();
            this.MaxSizeLabel = new System.Windows.Forms.Label();
            this.QualityLabel = new System.Windows.Forms.Label();
            this.QualityTrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MaxSizeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QualityTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.AutoSize = true;
            this.buttonOK.Location = new System.Drawing.Point(233, 156);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(87, 35);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(418, 156);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonCancel.Size = new System.Drawing.Size(87, 35);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Max Size";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MaxSizeTrackBar
            // 
            this.MaxSizeTrackBar.AutoSize = false;
            this.MaxSizeTrackBar.Location = new System.Drawing.Point(154, 32);
            this.MaxSizeTrackBar.Name = "MaxSizeTrackBar";
            this.MaxSizeTrackBar.Size = new System.Drawing.Size(450, 60);
            this.MaxSizeTrackBar.TabIndex = 4;
            this.MaxSizeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.MaxSizeTrackBar.MouseCaptureChanged += new System.EventHandler(this.MaxSizeTrackBar_MouseCaptureChanged);
            // 
            // MaxSizeLabel
            // 
            this.MaxSizeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxSizeLabel.Location = new System.Drawing.Point(624, 32);
            this.MaxSizeLabel.Name = "MaxSizeLabel";
            this.MaxSizeLabel.Size = new System.Drawing.Size(94, 40);
            this.MaxSizeLabel.TabIndex = 5;
            this.MaxSizeLabel.Text = "00000";
            this.MaxSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QualityLabel
            // 
            this.QualityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QualityLabel.Location = new System.Drawing.Point(622, 90);
            this.QualityLabel.Name = "QualityLabel";
            this.QualityLabel.Size = new System.Drawing.Size(94, 40);
            this.QualityLabel.TabIndex = 8;
            this.QualityLabel.Text = "00000";
            this.QualityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QualityTrackBar
            // 
            this.QualityTrackBar.AutoSize = false;
            this.QualityTrackBar.Location = new System.Drawing.Point(152, 90);
            this.QualityTrackBar.Name = "QualityTrackBar";
            this.QualityTrackBar.Size = new System.Drawing.Size(450, 60);
            this.QualityTrackBar.TabIndex = 7;
            this.QualityTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(32, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 40);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quality";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Settings
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(748, 215);
            this.Controls.Add(this.QualityLabel);
            this.Controls.Add(this.QualityTrackBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaxSizeLabel);
            this.Controls.Add(this.MaxSizeTrackBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.MaxSizeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QualityTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar MaxSizeTrackBar;
        private System.Windows.Forms.Label MaxSizeLabel;
        private System.Windows.Forms.Label QualityLabel;
        private System.Windows.Forms.TrackBar QualityTrackBar;
        private System.Windows.Forms.Label label3;
    }
}