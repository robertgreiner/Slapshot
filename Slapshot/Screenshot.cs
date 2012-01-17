using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Slapshot
{
    public class Screenshot
    {
        public string SaveDirectory { get; private set; }
        public ImageFormat SaveFormat { get; private set; }
        public string FileName { get; private set; }

        public Screenshot()
        {
            SaveDirectory = ".";
            SaveFormat = ImageFormat.Png;
            FileName = SaveDirectory + @"\screenshot.png";
        }

        public void CaptureEntireScreen()
        {
            var rectangle = Screen.GetBounds(Point.Empty);
            ProcessBitmap(rectangle);
        }

        public void CaptureActiveScreen(Rectangle rectangle)
        {
            ProcessBitmap(rectangle);
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

        private void SaveImage(Image image)
        {
            image.Save(FileName, SaveFormat);
        }
    }
}
