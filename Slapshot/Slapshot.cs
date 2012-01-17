using System;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Slapshot
{
    public partial class Slapshot : Form
    {
        private string SaveDirectory;
        private ImageFormat SaveFormat;
        private Screenshot Screen;

        public Slapshot()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            SaveDirectory = ".";
            SaveFormat = ImageFormat.Png;
            Screen = new Screenshot(SaveDirectory, SaveFormat);
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
            MessageBox.Show(Screen.FilePath);
            Screen.CaptureEntireScreen();
        }

        private void CloseMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DirectoryMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowser.ShowDialog();
            SaveDirectory = FolderBrowser.SelectedPath;
            Screen = new Screenshot(SaveDirectory, SaveFormat);
        }
    }
}