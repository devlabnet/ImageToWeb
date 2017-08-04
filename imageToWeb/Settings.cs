using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imageToWeb {
    public partial class Settings : Form {
        public Settings() {
            InitializeComponent();
            MaxSizeTrackBar.Minimum = 100;
            MaxSizeTrackBar.Maximum = 1500;
            MaxSizeTrackBar.TickFrequency = 50;
            MaxSizeTrackBar.SmallChange = 50;
            MaxSizeTrackBar.LargeChange = 100;
            MaxSizeTrackBar.Value = Properties.Settings1.Default.maxSize;
            MaxSizeLabel.Text = MaxSizeTrackBar.Value.ToString();
            MaxSizeTrackBar.Scroll += new System.EventHandler(MaxSizeTrackBar_Scroll);
            QualityTrackBar.Scroll += new System.EventHandler(QualityTrackBar_Scroll);
            QualityTrackBar.Minimum = 10;
            QualityTrackBar.Maximum = 90;
            QualityTrackBar.TickFrequency = 10;
            QualityTrackBar.SmallChange = 5;
            QualityTrackBar.SmallChange = 10;
            QualityTrackBar.Value = Properties.Settings1.Default.quality;
            QualityLabel.Text = QualityTrackBar.Value.ToString();

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
