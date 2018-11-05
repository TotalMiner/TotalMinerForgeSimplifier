namespace TMF_Simplifier
{
    partial class TMFS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TMFS));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Downloads");
            this.ExitBTN = new System.Windows.Forms.Label();
            this.Pages = new System.Windows.Forms.Panel();
            this.ConsolePanel = new System.Windows.Forms.Panel();
            this.ConsoleText = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.ReleaseLabel = new System.Windows.Forms.Label();
            this.changelog = new System.Windows.Forms.Button();
            this.InstalledPage = new System.Windows.Forms.Label();
            this.InstallPage = new System.Windows.Forms.Label();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.LogoIMG = new System.Windows.Forms.PictureBox();
            this.LogoTXT = new System.Windows.Forms.Label();
            this.SettingsBTN = new System.Windows.Forms.Label();
            this.HelpBTN = new System.Windows.Forms.Label();
            this.Minimize = new System.Windows.Forms.Label();
            this.LocationTextbox = new System.Windows.Forms.TextBox();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.FilePicker = new System.Windows.Forms.OpenFileDialog();
            this.BrowseBTN = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.ItemView = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Views = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Downloads = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReloadBTN = new System.Windows.Forms.PictureBox();
            this.ModTab = new System.Windows.Forms.Label();
            this.MapTab = new System.Windows.Forms.Label();
            this.ComTab = new System.Windows.Forms.Label();
            this.DownloadBTN = new System.Windows.Forms.PictureBox();
            this.SettingsStrip = new System.Windows.Forms.MenuStrip();
            this.SortSET = new System.Windows.Forms.ToolStripComboBox();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LocationPanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.LineSperator = new System.Windows.Forms.Panel();
            this.Pages.SuspendLayout();
            this.ConsolePanel.SuspendLayout();
            this.panel8.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReloadBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownloadBTN)).BeginInit();
            this.SettingsStrip.SuspendLayout();
            this.LocationPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitBTN
            // 
            this.ExitBTN.AutoSize = true;
            this.ExitBTN.BackColor = System.Drawing.Color.Transparent;
            this.ExitBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ExitBTN.ForeColor = System.Drawing.Color.White;
            this.ExitBTN.Location = new System.Drawing.Point(139, 1);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Padding = new System.Windows.Forms.Padding(2, 0, 0, 5);
            this.ExitBTN.Size = new System.Drawing.Size(38, 30);
            this.ExitBTN.TabIndex = 0;
            this.ExitBTN.Text = " × ";
            this.ExitBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ExitBTN.Click += new System.EventHandler(this.label1_Click);
            this.ExitBTN.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.ExitBTN.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // Pages
            // 
            this.Pages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(180)))));
            this.Pages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pages.Controls.Add(this.ConsolePanel);
            this.Pages.Controls.Add(this.panel8);
            this.Pages.Controls.Add(this.InstalledPage);
            this.Pages.Controls.Add(this.InstallPage);
            this.Pages.Controls.Add(this.TitlePanel);
            this.Pages.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pages.Location = new System.Drawing.Point(0, 0);
            this.Pages.Name = "Pages";
            this.Pages.Size = new System.Drawing.Size(290, 588);
            this.Pages.TabIndex = 1;
            this.Pages.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_MouseDown);
            this.Pages.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_MoveMouse);
            // 
            // ConsolePanel
            // 
            this.ConsolePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(108)))), ((int)(((byte)(183)))));
            this.ConsolePanel.Controls.Add(this.ConsoleText);
            this.ConsolePanel.Location = new System.Drawing.Point(0, 158);
            this.ConsolePanel.Name = "ConsolePanel";
            this.ConsolePanel.Size = new System.Drawing.Size(292, 392);
            this.ConsolePanel.TabIndex = 28;
            // 
            // ConsoleText
            // 
            this.ConsoleText.AcceptsReturn = true;
            this.ConsoleText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(108)))), ((int)(((byte)(183)))));
            this.ConsoleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConsoleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleText.ForeColor = System.Drawing.SystemColors.Info;
            this.ConsoleText.Location = new System.Drawing.Point(0, 1);
            this.ConsoleText.Multiline = true;
            this.ConsoleText.Name = "ConsoleText";
            this.ConsoleText.ReadOnly = true;
            this.ConsoleText.Size = new System.Drawing.Size(289, 391);
            this.ConsoleText.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(158)))));
            this.panel8.Controls.Add(this.ReleaseLabel);
            this.panel8.Controls.Add(this.changelog);
            this.panel8.Location = new System.Drawing.Point(0, 550);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(290, 38);
            this.panel8.TabIndex = 4;
            // 
            // ReleaseLabel
            // 
            this.ReleaseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ReleaseLabel.AutoSize = true;
            this.ReleaseLabel.BackColor = System.Drawing.Color.Transparent;
            this.ReleaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReleaseLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.ReleaseLabel.Location = new System.Drawing.Point(1, 11);
            this.ReleaseLabel.Name = "ReleaseLabel";
            this.ReleaseLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ReleaseLabel.Size = new System.Drawing.Size(149, 17);
            this.ReleaseLabel.TabIndex = 25;
            this.ReleaseLabel.Text = "Release yyyy.mm.dd.v";
            this.ReleaseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReleaseLabel.Click += new System.EventHandler(this.ViewChangelog);
            // 
            // changelog
            // 
            this.changelog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.changelog.FlatAppearance.BorderSize = 0;
            this.changelog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changelog.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changelog.ForeColor = System.Drawing.Color.Cornsilk;
            this.changelog.Location = new System.Drawing.Point(158, 6);
            this.changelog.Name = "changelog";
            this.changelog.Size = new System.Drawing.Size(129, 26);
            this.changelog.TabIndex = 28;
            this.changelog.Text = "What\'s New?";
            this.changelog.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.changelog.UseVisualStyleBackColor = false;
            this.changelog.Click += new System.EventHandler(this.changelog_Click);
            // 
            // InstalledPage
            // 
            this.InstalledPage.AutoSize = true;
            this.InstalledPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.InstalledPage.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstalledPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InstalledPage.Location = new System.Drawing.Point(0, 101);
            this.InstalledPage.Name = "InstalledPage";
            this.InstalledPage.Padding = new System.Windows.Forms.Padding(108, 15, 108, 15);
            this.InstalledPage.Size = new System.Drawing.Size(299, 54);
            this.InstalledPage.TabIndex = 27;
            this.InstalledPage.Tag = "2";
            this.InstalledPage.Text = "Installed";
            this.InstalledPage.Click += new System.EventHandler(this.Label2_Click);
            // 
            // InstallPage
            // 
            this.InstallPage.AutoSize = true;
            this.InstallPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.InstallPage.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstallPage.ForeColor = System.Drawing.Color.White;
            this.InstallPage.Location = new System.Drawing.Point(1, 45);
            this.InstallPage.Name = "InstallPage";
            this.InstallPage.Padding = new System.Windows.Forms.Padding(108, 15, 108, 15);
            this.InstallPage.Size = new System.Drawing.Size(294, 54);
            this.InstallPage.TabIndex = 26;
            this.InstallPage.Tag = "2";
            this.InstallPage.Text = "Installer";
            this.InstallPage.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(158)))));
            this.TitlePanel.Controls.Add(this.LogoIMG);
            this.TitlePanel.Controls.Add(this.LogoTXT);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(290, 38);
            this.TitlePanel.TabIndex = 3;
            this.TitlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_MouseDown);
            this.TitlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_MoveMouse);
            // 
            // LogoIMG
            // 
            this.LogoIMG.Image = ((System.Drawing.Image)(resources.GetObject("LogoIMG.Image")));
            this.LogoIMG.Location = new System.Drawing.Point(20, 7);
            this.LogoIMG.Name = "LogoIMG";
            this.LogoIMG.Size = new System.Drawing.Size(23, 23);
            this.LogoIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoIMG.TabIndex = 1;
            this.LogoIMG.TabStop = false;
            // 
            // LogoTXT
            // 
            this.LogoTXT.AutoSize = true;
            this.LogoTXT.BackColor = System.Drawing.Color.Transparent;
            this.LogoTXT.Font = new System.Drawing.Font("MS Outlook", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoTXT.ForeColor = System.Drawing.Color.White;
            this.LogoTXT.Location = new System.Drawing.Point(41, 9);
            this.LogoTXT.Name = "LogoTXT";
            this.LogoTXT.Size = new System.Drawing.Size(229, 19);
            this.LogoTXT.TabIndex = 2;
            this.LogoTXT.Text = "Total Miner: Forge Simplifier";
            this.LogoTXT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_MouseDown);
            this.LogoTXT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_MoveMouse);
            // 
            // SettingsBTN
            // 
            this.SettingsBTN.AutoSize = true;
            this.SettingsBTN.BackColor = System.Drawing.Color.Transparent;
            this.SettingsBTN.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SettingsBTN.ForeColor = System.Drawing.Color.White;
            this.SettingsBTN.Location = new System.Drawing.Point(3, 4);
            this.SettingsBTN.Name = "SettingsBTN";
            this.SettingsBTN.Padding = new System.Windows.Forms.Padding(2, 1, 0, 5);
            this.SettingsBTN.Size = new System.Drawing.Size(70, 22);
            this.SettingsBTN.TabIndex = 25;
            this.SettingsBTN.Text = " Settings ";
            this.SettingsBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SettingsBTN.Click += new System.EventHandler(this.SettingsBTN_Click);
            // 
            // HelpBTN
            // 
            this.HelpBTN.AutoSize = true;
            this.HelpBTN.BackColor = System.Drawing.Color.Transparent;
            this.HelpBTN.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.HelpBTN.ForeColor = System.Drawing.Color.White;
            this.HelpBTN.Location = new System.Drawing.Point(68, 4);
            this.HelpBTN.Name = "HelpBTN";
            this.HelpBTN.Padding = new System.Windows.Forms.Padding(2, 1, 0, 9);
            this.HelpBTN.Size = new System.Drawing.Size(46, 26);
            this.HelpBTN.TabIndex = 20;
            this.HelpBTN.Text = " Help ";
            this.HelpBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HelpBTN.Click += new System.EventHandler(this.label1_Click_1);
            this.HelpBTN.MouseLeave += new System.EventHandler(this.label1_MouseLeave_1);
            this.HelpBTN.MouseHover += new System.EventHandler(this.label1_MouseHover_1);
            // 
            // Minimize
            // 
            this.Minimize.AutoSize = true;
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.Location = new System.Drawing.Point(109, 1);
            this.Minimize.Name = "Minimize";
            this.Minimize.Padding = new System.Windows.Forms.Padding(2, 0, 0, 5);
            this.Minimize.Size = new System.Drawing.Size(33, 25);
            this.Minimize.TabIndex = 19;
            this.Minimize.Text = " _ ";
            this.Minimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Minimize.Click += new System.EventHandler(this.minimize_Click_1);
            this.Minimize.MouseLeave += new System.EventHandler(this.Minimize_MouseLeave);
            this.Minimize.MouseHover += new System.EventHandler(this.Minimize_MouseHover);
            // 
            // LocationTextbox
            // 
            this.LocationTextbox.AllowDrop = true;
            this.LocationTextbox.BackColor = System.Drawing.Color.White;
            this.LocationTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocationTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationTextbox.Location = new System.Drawing.Point(1, 19);
            this.LocationTextbox.Name = "LocationTextbox";
            this.LocationTextbox.Size = new System.Drawing.Size(574, 22);
            this.LocationTextbox.TabIndex = 5;
            this.LocationTextbox.TextChanged += new System.EventHandler(this.FiletextBox_TextChanged);
            this.LocationTextbox.DragDrop += new System.Windows.Forms.DragEventHandler(this.LocationTextbox_DragDrop);
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationLabel.ForeColor = System.Drawing.Color.White;
            this.LocationLabel.Location = new System.Drawing.Point(2, 1);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(96, 15);
            this.LocationLabel.TabIndex = 6;
            this.LocationLabel.Text = "Location (none)";
            // 
            // FilePicker
            // 
            this.FilePicker.DefaultExt = "C:\\Users\\";
            this.FilePicker.Filter = "Zip files (*.zip;*.rar;*.7z)|*.zip;*.rar;*.7z";
            this.FilePicker.SupportMultiDottedExtensions = true;
            this.FilePicker.Title = "Choose zip";
            // 
            // BrowseBTN
            // 
            this.BrowseBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(137)))), ((int)(((byte)(254)))));
            this.BrowseBTN.FlatAppearance.BorderSize = 0;
            this.BrowseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseBTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BrowseBTN.Location = new System.Drawing.Point(578, 19);
            this.BrowseBTN.Name = "BrowseBTN";
            this.BrowseBTN.Size = new System.Drawing.Size(59, 22);
            this.BrowseBTN.TabIndex = 8;
            this.BrowseBTN.Text = "Browse";
            this.BrowseBTN.UseVisualStyleBackColor = false;
            this.BrowseBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ProgressBar.Location = new System.Drawing.Point(290, 575);
            this.ProgressBar.Maximum = 5;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(837, 10);
            this.ProgressBar.Step = 0;
            this.ProgressBar.TabIndex = 10;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.StatusLabel.Location = new System.Drawing.Point(830, 57);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(37, 13);
            this.StatusLabel.TabIndex = 11;
            this.StatusLabel.Text = "Status";
            // 
            // ItemView
            // 
            this.ItemView.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.ItemView.AllowColumnReorder = true;
            this.ItemView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.ItemView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Rating,
            this.Views,
            this.Downloads,
            this.Size,
            this.Author});
            this.ItemView.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ItemView.FullRowSelect = true;
            this.ItemView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ItemView.HoverSelection = true;
            listViewItem1.StateImageIndex = 0;
            this.ItemView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ItemView.Location = new System.Drawing.Point(293, 77);
            this.ItemView.MultiSelect = false;
            this.ItemView.Name = "ItemView";
            this.ItemView.Size = new System.Drawing.Size(837, 501);
            this.ItemView.TabIndex = 17;
            this.ItemView.UseCompatibleStateImageBehavior = false;
            this.ItemView.View = System.Windows.Forms.View.Details;
            this.ItemView.SelectedIndexChanged += new System.EventHandler(this.DownloadsView_SelectedIndexChanged);
            this.ItemView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DownloadsView_MouseDoubleClick);
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 280;
            // 
            // Rating
            // 
            this.Rating.Text = "Rating";
            this.Rating.Width = 70;
            // 
            // Views
            // 
            this.Views.Text = "Views";
            this.Views.Width = 84;
            // 
            // Downloads
            // 
            this.Downloads.Text = "Downloads";
            this.Downloads.Width = 80;
            // 
            // Size
            // 
            this.Size.Text = "Size";
            this.Size.Width = 79;
            // 
            // Author
            // 
            this.Author.Text = "Author";
            this.Author.Width = 239;
            // 
            // ReloadBTN
            // 
            this.ReloadBTN.BackColor = System.Drawing.Color.Transparent;
            this.ReloadBTN.Image = ((System.Drawing.Image)(resources.GetObject("ReloadBTN.Image")));
            this.ReloadBTN.Location = new System.Drawing.Point(459, 46);
            this.ReloadBTN.Margin = new System.Windows.Forms.Padding(6);
            this.ReloadBTN.Name = "ReloadBTN";
            this.ReloadBTN.Padding = new System.Windows.Forms.Padding(3);
            this.ReloadBTN.Size = new System.Drawing.Size(27, 27);
            this.ReloadBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReloadBTN.TabIndex = 20;
            this.ReloadBTN.TabStop = false;
            this.ReloadBTN.Click += new System.EventHandler(this.Reload_Click);
            // 
            // ModTab
            // 
            this.ModTab.AutoSize = true;
            this.ModTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ModTab.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModTab.ForeColor = System.Drawing.Color.White;
            this.ModTab.Location = new System.Drawing.Point(293, 51);
            this.ModTab.Name = "ModTab";
            this.ModTab.Padding = new System.Windows.Forms.Padding(4);
            this.ModTab.Size = new System.Drawing.Size(44, 22);
            this.ModTab.TabIndex = 21;
            this.ModTab.Tag = "2";
            this.ModTab.Text = "Mods";
            this.ModTab.Click += new System.EventHandler(this.ModTab_Click);
            // 
            // MapTab
            // 
            this.MapTab.AutoSize = true;
            this.MapTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MapTab.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MapTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MapTab.Location = new System.Drawing.Point(335, 51);
            this.MapTab.Name = "MapTab";
            this.MapTab.Padding = new System.Windows.Forms.Padding(4);
            this.MapTab.Size = new System.Drawing.Size(52, 22);
            this.MapTab.TabIndex = 22;
            this.MapTab.Tag = "3";
            this.MapTab.Text = "Worlds";
            this.MapTab.Click += new System.EventHandler(this.MapTab_Click);
            // 
            // ComTab
            // 
            this.ComTab.AutoSize = true;
            this.ComTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ComTab.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComTab.Location = new System.Drawing.Point(384, 51);
            this.ComTab.Name = "ComTab";
            this.ComTab.Padding = new System.Windows.Forms.Padding(4);
            this.ComTab.Size = new System.Drawing.Size(81, 22);
            this.ComTab.TabIndex = 23;
            this.ComTab.Tag = "5";
            this.ComTab.Text = "Components";
            this.ComTab.Click += new System.EventHandler(this.ComTab_Click);
            // 
            // DownloadBTN
            // 
            this.DownloadBTN.BackColor = System.Drawing.Color.Transparent;
            this.DownloadBTN.Image = ((System.Drawing.Image)(resources.GetObject("DownloadBTN.Image")));
            this.DownloadBTN.Location = new System.Drawing.Point(488, 47);
            this.DownloadBTN.Margin = new System.Windows.Forms.Padding(0);
            this.DownloadBTN.Name = "DownloadBTN";
            this.DownloadBTN.Padding = new System.Windows.Forms.Padding(3);
            this.DownloadBTN.Size = new System.Drawing.Size(27, 27);
            this.DownloadBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DownloadBTN.TabIndex = 24;
            this.DownloadBTN.TabStop = false;
            this.DownloadBTN.Click += new System.EventHandler(this.Install_Click);
            // 
            // SettingsStrip
            // 
            this.SettingsStrip.AutoSize = false;
            this.SettingsStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.SettingsStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SortSET});
            this.SettingsStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.SettingsStrip.Location = new System.Drawing.Point(949, 21);
            this.SettingsStrip.Name = "SettingsStrip";
            this.SettingsStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.SettingsStrip.Size = new System.Drawing.Size(156, 46);
            this.SettingsStrip.TabIndex = 26;
            this.SettingsStrip.Text = "menuStrip1";
            this.SettingsStrip.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.SettingsStrip.Visible = false;
            // 
            // SortSET
            // 
            this.SortSET.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SortSET.Items.AddRange(new object[] {
            "Sort by: Newest First",
            "Sort by: A-Z",
            "Sort by: Z-A"});
            this.SortSET.Name = "SortSET";
            this.SortSET.Size = new System.Drawing.Size(147, 23);
            this.SortSET.Text = "Sort by: Newest First";
            this.SortSET.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.SortSET.SelectedIndexChanged += new System.EventHandler(this.SortSET_IndexChanged);
            // 
            // SearchBar
            // 
            this.SearchBar.Location = new System.Drawing.Point(518, 51);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(306, 20);
            this.SearchBar.TabIndex = 27;
            this.SearchBar.Text = "Search";
            this.SearchBar.Click += new System.EventHandler(this.SearchBar_Click);
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.panel3.Location = new System.Drawing.Point(290, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 575);
            this.panel3.TabIndex = 28;
            // 
            // LocationPanel
            // 
            this.LocationPanel.Controls.Add(this.LocationTextbox);
            this.LocationPanel.Controls.Add(this.BrowseBTN);
            this.LocationPanel.Controls.Add(this.LocationLabel);
            this.LocationPanel.Location = new System.Drawing.Point(292, 2);
            this.LocationPanel.Name = "LocationPanel";
            this.LocationPanel.Size = new System.Drawing.Size(637, 47);
            this.LocationPanel.TabIndex = 28;
            this.LocationPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_MouseDown);
            this.LocationPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_MoveMouse);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(158)))));
            this.panel6.Controls.Add(this.ExitBTN);
            this.panel6.Controls.Add(this.SettingsBTN);
            this.panel6.Controls.Add(this.Minimize);
            this.panel6.Controls.Add(this.HelpBTN);
            this.panel6.Location = new System.Drawing.Point(957, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(170, 26);
            this.panel6.TabIndex = 28;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // LineSperator
            // 
            this.LineSperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.LineSperator.Location = new System.Drawing.Point(957, 0);
            this.LineSperator.Name = "LineSperator";
            this.LineSperator.Size = new System.Drawing.Size(2, 28);
            this.LineSperator.TabIndex = 28;
            // 
            // TMFS
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1127, 588);
            this.Controls.Add(this.LineSperator);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.LocationPanel);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.SettingsStrip);
            this.Controls.Add(this.ReloadBTN);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.DownloadBTN);
            this.Controls.Add(this.MapTab);
            this.Controls.Add(this.ItemView);
            this.Controls.Add(this.ComTab);
            this.Controls.Add(this.ModTab);
            this.Controls.Add(this.Pages);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.SettingsStrip;
            this.Name = "TMFS";
            this.Text = "Total Miner: Forge Simplifier";
            this.Load += new System.EventHandler(this.TMFS_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_MoveMouse);
            this.Pages.ResumeLayout(false);
            this.Pages.PerformLayout();
            this.ConsolePanel.ResumeLayout(false);
            this.ConsolePanel.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReloadBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownloadBTN)).EndInit();
            this.SettingsStrip.ResumeLayout(false);
            this.SettingsStrip.PerformLayout();
            this.LocationPanel.ResumeLayout(false);
            this.LocationPanel.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExitBTN;
        private System.Windows.Forms.Panel Pages;
        private System.Windows.Forms.Label LogoTXT;
        private System.Windows.Forms.PictureBox LogoIMG;
        private System.Windows.Forms.TextBox LocationTextbox;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.OpenFileDialog FilePicker;
        private System.Windows.Forms.Button BrowseBTN;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ListView ItemView;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Rating;
        private System.Windows.Forms.ColumnHeader Views;
        private System.Windows.Forms.ColumnHeader Downloads;
        private new System.Windows.Forms.ColumnHeader Size;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.Label Minimize;
        private System.Windows.Forms.Label HelpBTN;
        private System.Windows.Forms.PictureBox ReloadBTN;
        private System.Windows.Forms.Label ModTab;
        private System.Windows.Forms.Label MapTab;
        private System.Windows.Forms.Label ComTab;
        private System.Windows.Forms.PictureBox DownloadBTN;
        private System.Windows.Forms.Label SettingsBTN;
        private System.Windows.Forms.Label ReleaseLabel;
        private System.Windows.Forms.MenuStrip SettingsStrip;
        private System.Windows.Forms.ToolStripComboBox SortSET;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label InstalledPage;
        private System.Windows.Forms.Label InstallPage;
        private System.Windows.Forms.Panel LocationPanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel LineSperator;
        private System.Windows.Forms.Button changelog;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel ConsolePanel;
        private System.Windows.Forms.TextBox ConsoleText;
    }
}

