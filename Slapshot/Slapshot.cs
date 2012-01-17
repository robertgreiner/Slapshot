using System;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Slapshot.Properties;

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
            if (Directory.Exists(Settings.Default.SaveDirectory))
            {
                SaveDirectory = Settings.Default.SaveDirectory;    
            }
            
            SaveFormat = ImageFormat.Png;
            Screen = new Screenshot(SaveDirectory, SaveFormat);
            ShowBaloonTip("Welcome to Slapshot\n" + 
                "Right click me for more options." + 
                "\nYour screenshots are being saved to: " +
                SaveDirectory);
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
            Settings.Default.SaveDirectory = SaveDirectory;
            Settings.Default.Save();
            Screen = new Screenshot(SaveDirectory, SaveFormat);
        }

        private void SaveDirectoryMenuItem_Click(object sender, EventArgs e)
        {
            var message = "Your screenshots are being saved to: " + Settings.Default.SaveDirectory;
            ShowBaloonTip(message);

        }

        private void ShowBaloonTip(string text, int timeout = 5)
        {
            ApplicationIcon.BalloonTipText = text;
            ApplicationIcon.ShowBalloonTip(1000);
        }
    }
}