using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Slapshot
{
    public partial class Slapshot : Form
    {
        public Slapshot()
        {
            InitializeComponent();
        }

        private void Slapshot_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                minimizeToTray();
            }
        }

        private void Slapshot_Load(object sender, EventArgs e)
        {
            minimizeToTray();
        }

        private void minimizeToTray()
        {
            ApplicationIcon.Visible = true;
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        private void CaptureMenuItem_Click(object sender, EventArgs e)
        {
            var screenshot = new Screenshot(".", ImageFormat.Png);
            screenshot.CaptureEntireScreen();
        }

        private void CloseMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
