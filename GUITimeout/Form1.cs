using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUITimeout {
    public partial class Form1 : Form {
        public TimeSpan timeLeft;

        public Form1 () {
            InitializeComponent ();
            timer.Enabled = true;
        }

        public void SetInfo (string text) {
            this.info.Text = text;
        }

        public void SetOKBtn (string text) {
            this.btnOK.Text = text;
        }

        public void SetCancelBtn (string text) {
            this.btnCancel.Text = text;
        }

        private void timer_Tick (object sender, EventArgs e) {
            timeLeft = timeLeft.Subtract (TimeSpan.FromMilliseconds (timer.Interval));
            timerText.Text = timeLeft.ToString (@"hh\:mm\:ss");
            if (timeLeft <= TimeSpan.FromMilliseconds (0)) {
                Close ();
            }
        }

        private void btnCancel_Click (object sender, EventArgs e) {
            Program.exitCode = 1;
            Close ();
        }

        private void btnOK_Click (object sender, EventArgs e) {
            Close ();
        }
    }
}
