﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imageToWeb {
    public partial class SettingForm : Form {
        public SettingForm() {
            InitializeComponent();
            //Form.ActiveForm.Text = "xxxx";
            this.Text = imageToWeb.Program.rm.GetString("settings", Program.cul); ;
            buttonCancel.Text = imageToWeb.Program.rm.GetString("cancel", Program.cul);
            buttonOK.Text = imageToWeb.Program.rm.GetString("save", Program.cul);
            MaxSizeTrackBar.Minimum = 100;
            MaxSizeTrackBar.Maximum = 1500;
            MaxSizeTrackBar.TickFrequency = 50;
            MaxSizeTrackBar.SmallChange = 50;
            MaxSizeTrackBar.LargeChange = 100;
            MaxSizeTrackBar.Value = Properties.Settings1.Default.maxSize;
            MaxSizeLabel.Text = MaxSizeTrackBar.Value.ToString();
            lblMaxSize.Text = imageToWeb.Program.rm.GetString("lblMaxSize", Program.cul);
            MaxSizeTrackBar.Scroll += new System.EventHandler(MaxSizeTrackBar_Scroll);
            QualityTrackBar.Minimum = 10;
            QualityTrackBar.Maximum = 90;
            QualityTrackBar.TickFrequency = 10;
            QualityTrackBar.SmallChange = 10;
            QualityTrackBar.LargeChange = 20;
            QualityTrackBar.Value = Properties.Settings1.Default.quality;
            QualityLabel.Text = QualityTrackBar.Value.ToString();
            lblQuality.Text = imageToWeb.Program.rm.GetString("lblQuality", Program.cul);
            QualityTrackBar.Scroll += new System.EventHandler(QualityTrackBar_Scroll);


        }

        private void MaxSizeTrackBar_Scroll(object sender, EventArgs e) {
            MaxSizeLabel.Text = "" + MaxSizeTrackBar.Value;
        }

        private void QualityTrackBar_Scroll(object sender, EventArgs e) {
            QualityLabel.Text = "" + QualityTrackBar.Value;
        }

        private void MaxSizeTrackBar_MouseCaptureChanged(object sender, EventArgs e) {
            
        }

        private void buttonOK_Click(object sender, EventArgs e) {
            Properties.Settings1.Default.maxSize = MaxSizeTrackBar.Value;
            Properties.Settings1.Default.quality = QualityTrackBar.Value;
            Properties.Settings1.Default.Save();
            this.Close();
        }
    }
}
