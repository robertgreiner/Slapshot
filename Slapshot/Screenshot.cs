using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Slapshot
{
    public class Screenshot
    {
        public string SaveDirectory { get; private set; }
        public ImageFormat SaveFormat { get; private set; }
        public string FileName { get { return BuildFileName(); } }
        public string FilePath { get { return BuildFilePath(); } }

        public Screenshot(string saveDirectory, ImageFormat imageFormat)
        {
            SaveDirectory = ".";
            if (Directory.Exists(saveDirectory))
            {
                SaveDirectory = saveDirectory;    
            }
            SaveFormat = imageFormat;
        }

        private string BuildFileName()
        {
            var time = DateTime.Now;
            var name = time.ToString("yyyy-mm-dd_hh.mm.ss");
            return String.Format("{0}.{1}", name, SaveFormat.ToString()).ToLower();
        }

        private string BuildFilePath()
        {
            var f = new FileInfo(SaveDirectory + "\\" + FileName);
            return f.FullName;
        
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
            image.Save(FilePath, SaveFormat);
        }
    }
}
