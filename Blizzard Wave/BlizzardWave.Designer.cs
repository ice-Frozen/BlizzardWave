namespace Blizzard_Wave
{
    partial class BlizzardWave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlizzardWave));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PlayListTab = new System.Windows.Forms.TabPage();
            this.playControl1 = new Blizzard_Wave.PlayControl();
            this.MixerTab = new System.Windows.Forms.TabPage();
            this.Mixer = new Blizzard_Wave.Mixer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayListMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AddFolderMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.PlayListTab.SuspendLayout();
            this.MixerTab.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PlayListTab);
            this.tabControl1.Controls.Add(this.MixerTab);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 100);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // PlayListTab
            // 
            this.PlayListTab.AccessibleName = "Play List";
            this.PlayListTab.Controls.Add(this.playControl1);
            this.PlayListTab.Location = new System.Drawing.Point(4, 22);
            this.PlayListTab.Name = "PlayListTab";
            this.PlayListTab.Padding = new System.Windows.Forms.Padding(3);
            this.PlayListTab.Size = new System.Drawing.Size(192, 74);
            this.PlayListTab.TabIndex = 0;
            this.PlayListTab.Text = "Play List";
            this.PlayListTab.UseVisualStyleBackColor = true;
            this.PlayListTab.Click += new System.EventHandler(this.PlayListTab_Click);
            // 
            // playControl1
            // 
            this.playControl1.Location = new System.Drawing.Point(0, 0);
            this.playControl1.Name = "playControl1";
            this.playControl1.Size = new System.Drawing.Size(150, 150);
            this.playControl1.TabIndex = 0;
            this.playControl1.playButton += new System.EventHandler(this.playControl1_playButton);
            this.playControl1.playListView_SelectedIndexChanged += new System.EventHandler(this.playControl1_playListView_SelectedIndexChanged);
            this.playControl1.playListView_ItemActivate += new System.EventHandler(this.playControl1_playListView_ItemActivate);
            this.playControl1.Load += new System.EventHandler(this.playControl1_Load);
            // 
            // MixerTab
            // 
            this.MixerTab.AccessibleName = "Mixer";
            this.MixerTab.BackColor = System.Drawing.Color.Violet;
            this.MixerTab.Controls.Add(this.Mixer);
            this.MixerTab.Location = new System.Drawing.Point(4, 22);
            this.MixerTab.Name = "MixerTab";
            this.MixerTab.Padding = new System.Windows.Forms.Padding(3);
            this.MixerTab.Size = new System.Drawing.Size(192, 74);
            this.MixerTab.TabIndex = 1;
            this.MixerTab.Text = "Mixer";
            this.MixerTab.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // Mixer
            // 
            this.Mixer.Location = new System.Drawing.Point(0, 0);
            this.Mixer.Name = "Mixer";
            this.Mixer.Size = new System.Drawing.Size(150, 150);
            this.Mixer.TabIndex = 0;
            this.Mixer.volumeBar_Scroll += new System.EventHandler(this.mixer1_volumeBar_Scroll);
            this.Mixer.panBar_Scroll += new System.EventHandler(this.Mixer_panBar_Scroll);
            this.Mixer.Load += new System.EventHandler(this.Mixer_Load);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.PlayListMenu,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // PlayListMenu
            // 
            this.PlayListMenu.AccessibleName = "Playlist";
            this.PlayListMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddFileMenu,
            this.AddFolderMenu});
            this.PlayListMenu.Name = "PlayListMenu";
            this.PlayListMenu.Size = new System.Drawing.Size(56, 20);
            this.PlayListMenu.Text = "&Playlist";
            // 
            // AddFileMenu
            // 
            this.AddFileMenu.AccessibleName = "Add File";
            this.AddFileMenu.Name = "AddFileMenu";
            this.AddFileMenu.Size = new System.Drawing.Size(132, 22);
            this.AddFileMenu.Text = "&Add File";
            // 
            // AddFolderMenu
            // 
            this.AddFolderMenu.AccessibleName = "Add Folder";
            this.AddFolderMenu.Name = "AddFolderMenu";
            this.AddFolderMenu.Size = new System.Drawing.Size(132, 22);
            this.AddFolderMenu.Text = "&Add Folder";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "mp3 Files(*.mp3)|*.mp3|Wav Files(*.wav)|*.wav|All Files(*.*)|*.*";
            this.openFileDialog.FilterIndex = 0;
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.RestoreDirectory = true;
            this.openFileDialog.Title = "Select Media File";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // BlizzardWave
            // 
            this.AccessibleName = "BlizzardWave";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BlizzardWave";
            this.Text = "Blizzard Wave";
            this.Load += new System.EventHandler(this.BlizzardWave_Load);
            this.tabControl1.ResumeLayout(false);
            this.PlayListTab.ResumeLayout(false);
            this.MixerTab.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PlayListTab;
        private System.Windows.Forms.TabPage MixerTab;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PlayListMenu;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        public PlayControl playControl1;
        private Mixer Mixer;
        private System.Windows.Forms.ToolStripMenuItem AddFileMenu;
        private System.Windows.Forms.ToolStripMenuItem AddFolderMenu;
    }
}