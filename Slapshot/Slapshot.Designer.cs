namespace Slapshot
{
    partial class Slapshot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Slapshot));
            this.ApplicationIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CaptureMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.LinkLabel = new System.Windows.Forms.LinkLabel();
            this.DirectoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.SaveDirectoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ApplicationIcon
            // 
            this.ApplicationIcon.ContextMenuStrip = this.ContextMenu;
            this.ApplicationIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ApplicationIcon.Icon")));
            this.ApplicationIcon.Text = "Slapshot";
            this.ApplicationIcon.Visible = true;
            // 
            // ContextMenu
            // 
            this.ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CaptureMenuItem,
            this.toolStripSeparator1,
            this.SaveDirectoryMenuItem,
            this.DirectoryMenuItem,
            this.toolStripSeparator2,
            this.CloseMenuItem});
            this.ContextMenu.Name = "ContextMenu";
            this.ContextMenu.Size = new System.Drawing.Size(218, 126);
            // 
            // CaptureMenuItem
            // 
            this.CaptureMenuItem.Name = "CaptureMenuItem";
            this.CaptureMenuItem.Size = new System.Drawing.Size(217, 22);
            this.CaptureMenuItem.Text = "CaptureScreen";
            this.CaptureMenuItem.Click += new System.EventHandler(this.CaptureMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(214, 6);
            // 
            // CloseMenuItem
            // 
            this.CloseMenuItem.Name = "CloseMenuItem";
            this.CloseMenuItem.Size = new System.Drawing.Size(217, 22);
            this.CloseMenuItem.Text = "Exit";
            this.CloseMenuItem.Click += new System.EventHandler(this.CloseMenuItem_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(8, 24);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(200, 13);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Slapshot v.1.0 created by Robert Greiner";
            // 
            // LinkLabel
            // 
            this.LinkLabel.AutoSize = true;
            this.LinkLabel.Location = new System.Drawing.Point(43, 54);
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.Size = new System.Drawing.Size(123, 13);
            this.LinkLabel.TabIndex = 3;
            this.LinkLabel.TabStop = true;
            this.LinkLabel.Text = "http://creatingcode.com";
            // 
            // DirectoryMenuItem
            // 
            this.DirectoryMenuItem.Name = "DirectoryMenuItem";
            this.DirectoryMenuItem.Size = new System.Drawing.Size(217, 22);
            this.DirectoryMenuItem.Text = "Set SaveDirectory";
            this.DirectoryMenuItem.Click += new System.EventHandler(this.DirectoryMenuItem_Click);
            // 
            // SaveDirectoryMenuItem
            // 
            this.SaveDirectoryMenuItem.Name = "SaveDirectoryMenuItem";
            this.SaveDirectoryMenuItem.Size = new System.Drawing.Size(217, 22);
            this.SaveDirectoryMenuItem.Text = "Where are my screenshots?";
            this.SaveDirectoryMenuItem.Click += new System.EventHandler(this.SaveDirectoryMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(214, 6);
            // 
            // Slapshot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 87);
            this.Controls.Add(this.LinkLabel);
            this.Controls.Add(this.TitleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Slapshot";
            this.Text = "Slapshot";
            this.Load += new System.EventHandler(this.Slapshot_Load);
            this.SizeChanged += new System.EventHandler(this.Slapshot_SizeChanged);
            this.ContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon ApplicationIcon;
        private System.Windows.Forms.ContextMenuStrip ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem CaptureMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem CloseMenuItem;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.LinkLabel LinkLabel;
        private System.Windows.Forms.ToolStripMenuItem DirectoryMenuItem;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        private System.Windows.Forms.ToolStripMenuItem SaveDirectoryMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

