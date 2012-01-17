using System;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Slapshot
{
    public partial class Slapshot : Form
    {
        private string SaveDirectory;
        private ImageFormat SaveFormat;

        public Slapshot()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            SaveDirectory = ".";
            SaveFormat = ImageFormat.Png;
        }

        private void Slapshot_SizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
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
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
        }

        private void CaptureMenuItem_Click(object sender, EventArgs e)
        {
            var screenshot = new Screenshot(SaveDirectory, SaveFormat);
            screenshot.CaptureEntireScreen();
        }

        private void CloseMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DirectoryMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}