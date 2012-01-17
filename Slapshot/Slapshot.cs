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

        private void btnCapture_Click(object sender, EventArgs e)
        {
            var screenshot = new Screenshot();
            screenshot.CaptureEntireScreen();    
        }
    }
}
