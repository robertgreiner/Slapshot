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
            CaptureEntireScreen();    
        }
        
        private void CaptureEntireScreen()
        {
            var bounds = Screen.GetBounds(Point.Empty);
            ProcessBitmap(bounds);
        }

        private void CaptureActiveScreen()
        {
            var bounds = this.Bounds;
            ProcessBitmap(bounds);
        }

        private void ProcessBitmap(Rectangle rectangle)
        {
            using (var image = new Bitmap(rectangle.Width, rectangle.Height))
            {
                using (var g = Graphics.FromImage(image))
                {
                    g.CopyFromScreen(Point.Empty, Point.Empty, rectangle.Size);
                }
                SaveImage(image);
            }
        }

        private static void SaveImage(Bitmap image)
        {
            image.Save("screenshot.png", ImageFormat.Png);
        }
    }
}
