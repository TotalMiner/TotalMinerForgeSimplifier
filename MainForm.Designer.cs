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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SettingsBTN = new System.Windows.Forms.Label();
            this.HelpBTN = new System.Windows.Forms.Label();
            this.Minimize = new System.Windows.Forms.Label();
            this.LogoTXT = new System.Windows.Forms.Label();
            this.LogoIMG = new System.Windows.Forms.PictureBox();
            this.LocationTextbox = new System.Windows.Forms.TextBox();
            this.LocationLabel = new System.Windows.Forms.Label();
            this.FilePicker = new System.Windows.Forms.OpenFileDialog();
            this.BrowseBTN = new System.Windows.Forms.Button();
            this.SimplifyBTN = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.DownloadsView = new System.Windows.Forms.ListView();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ReleaseLabel = new System.Windows.Forms.Label();
            this.SettingsStrip = new System.Windows.Forms.MenuStrip();
            this.SortSET = new System.Windows.Forms.ToolStripComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReloadBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SettingsStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitBTN
            // 
            this.ExitBTN.AutoSize = true;
            this.ExitBTN.BackColor = System.Drawing.Color.Transparent;
            this.ExitBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ExitBTN.ForeColor = System.Drawing.Color.DimGray;
            this.ExitBTN.Location = new System.Drawing.Point(1074, 0);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Padding = new System.Windows.Forms.Padding(2, 0, 0, 5);
            this.ExitBTN.Size = new System.Drawing.Size(31, 25);
            this.ExitBTN.TabIndex = 0;
            this.ExitBTN.Text = " × ";
            this.ExitBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ExitBTN.Click += new System.EventHandler(this.label1_Click);
            this.ExitBTN.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.ExitBTN.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(62)))), ((int)(((byte)(91)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.ReleaseLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 575);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_MoveMouse);
            // 
            // SettingsBTN
            // 
            this.SettingsBTN.AutoSize = true;
            this.SettingsBTN.BackColor = System.Drawing.Color.Transparent;
            this.SettingsBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.SettingsBTN.ForeColor = System.Drawing.Color.DimGray;
            this.SettingsBTN.Location = new System.Drawing.Point(945, 0);
            this.SettingsBTN.Name = "SettingsBTN";
            this.SettingsBTN.Padding = new System.Windows.Forms.Padding(2, 1, 0, 5);
            this.SettingsBTN.Size = new System.Drawing.Size(59, 21);
            this.SettingsBTN.TabIndex = 25;
            this.SettingsBTN.Text = " Settings ";
            this.SettingsBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SettingsBTN.Click += new System.EventHandler(this.SettingsBTN_Click);
            // 
            // HelpBTN
            // 
            this.HelpBTN.AutoSize = true;
            this.HelpBTN.BackColor = System.Drawing.Color.Transparent;
            this.HelpBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.HelpBTN.ForeColor = System.Drawing.Color.DimGray;
            this.HelpBTN.Location = new System.Drawing.Point(1004, 0);
            this.HelpBTN.Name = "HelpBTN";
            this.HelpBTN.Padding = new System.Windows.Forms.Padding(2, 1, 0, 5);
            this.HelpBTN.Size = new System.Drawing.Size(41, 21);
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
            this.Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.Color.DimGray;
            this.Minimize.Location = new System.Drawing.Point(1047, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Padding = new System.Windows.Forms.Padding(2, 0, 0, 5);
            this.Minimize.Size = new System.Drawing.Size(27, 25);
            this.Minimize.TabIndex = 19;
            this.Minimize.Text = " - ";
            this.Minimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Minimize.Click += new System.EventHandler(this.minimize_Click_1);
            this.Minimize.MouseLeave += new System.EventHandler(this.Minimize_MouseLeave);
            this.Minimize.MouseHover += new System.EventHandler(this.Minimize_MouseHover);
            // 
            // LogoTXT
            // 
            this.LogoTXT.AutoSize = true;
            this.LogoTXT.BackColor = System.Drawing.Color.Transparent;
            this.LogoTXT.Font = new System.Drawing.Font("MS Outlook", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LogoTXT.Location = new System.Drawing.Point(41, 9);
            this.LogoTXT.Name = "LogoTXT";
            this.LogoTXT.Size = new System.Drawing.Size(213, 19);
            this.LogoTXT.TabIndex = 2;
            this.LogoTXT.Text = "Total Miner: Forge Simplifier";
            this.LogoTXT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_MouseDown);
            this.LogoTXT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_MoveMouse);
            // 
            // LogoIMG
            // 
            this.LogoIMG.Image = ((System.Drawing.Image)(resources.GetObject("LogoIMG.Image")));
            this.LogoIMG.Location = new System.Drawing.Point(16, 6);
            this.LogoIMG.Name = "LogoIMG";
            this.LogoIMG.Size = new System.Drawing.Size(25, 25);
            this.LogoIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoIMG.TabIndex = 1;
            this.LogoIMG.TabStop = false;
            // 
            // LocationTextbox
            // 
            this.LocationTextbox.AllowDrop = true;
            this.LocationTextbox.Location = new System.Drawing.Point(296, 18);
            this.LocationTextbox.Name = "LocationTextbox";
            this.LocationTextbox.Size = new System.Drawing.Size(488, 20);
            this.LocationTextbox.TabIndex = 5;
            this.LocationTextbox.TextChanged += new System.EventHandler(this.FiletextBox_TextChanged);
            this.LocationTextbox.DragDrop += new System.Windows.Forms.DragEventHandler(this.LocationTextbox_DragDrop);
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationLabel.ForeColor = System.Drawing.Color.DimGray;
            this.LocationLabel.Location = new System.Drawing.Point(293, 0);
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
            this.BrowseBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(124)))), ((int)(((byte)(150)))));
            this.BrowseBTN.FlatAppearance.BorderSize = 0;
            this.BrowseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseBTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BrowseBTN.Location = new System.Drawing.Point(790, 18);
            this.BrowseBTN.Name = "BrowseBTN";
            this.BrowseBTN.Size = new System.Drawing.Size(59, 20);
            this.BrowseBTN.TabIndex = 8;
            this.BrowseBTN.Text = "Browse";
            this.BrowseBTN.UseVisualStyleBackColor = false;
            this.BrowseBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // SimplifyBTN
            // 
            this.SimplifyBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(124)))), ((int)(((byte)(150)))));
            this.SimplifyBTN.FlatAppearance.BorderSize = 0;
            this.SimplifyBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SimplifyBTN.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.SimplifyBTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SimplifyBTN.Location = new System.Drawing.Point(790, 44);
            this.SimplifyBTN.Name = "SimplifyBTN";
            this.SimplifyBTN.Size = new System.Drawing.Size(61, 28);
            this.SimplifyBTN.TabIndex = 9;
            this.SimplifyBTN.Text = "Simplify";
            this.SimplifyBTN.UseVisualStyleBackColor = false;
            this.SimplifyBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ProgressBar.Location = new System.Drawing.Point(290, 85);
            this.ProgressBar.Maximum = 5;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(815, 4);
            this.ProgressBar.Step = 0;
            this.ProgressBar.TabIndex = 10;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.ForeColor = System.Drawing.Color.Coral;
            this.StatusLabel.Location = new System.Drawing.Point(449, 59);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(37, 13);
            this.StatusLabel.TabIndex = 11;
            this.StatusLabel.Text = "Status";
            // 
            // DownloadsView
            // 
            this.DownloadsView.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.DownloadsView.AllowColumnReorder = true;
            this.DownloadsView.BackColor = System.Drawing.Color.SteelBlue;
            this.DownloadsView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DownloadsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Rating,
            this.Views,
            this.Downloads,
            this.Size,
            this.Author});
            this.DownloadsView.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadsView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(253)))));
            this.DownloadsView.FullRowSelect = true;
            this.DownloadsView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.DownloadsView.HoverSelection = true;
            listViewItem1.StateImageIndex = 0;
            this.DownloadsView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.DownloadsView.Location = new System.Drawing.Point(290, 85);
            this.DownloadsView.Name = "DownloadsView";
            this.DownloadsView.Size = new System.Drawing.Size(815, 490);
            this.DownloadsView.TabIndex = 17;
            this.DownloadsView.UseCompatibleStateImageBehavior = false;
            this.DownloadsView.View = System.Windows.Forms.View.Details;
            this.DownloadsView.SelectedIndexChanged += new System.EventHandler(this.DownloadsView_SelectedIndexChanged);
            this.DownloadsView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DownloadsView_MouseDoubleClick);
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 261;
            // 
            // Rating
            // 
            this.Rating.Text = "Rating";
            this.Rating.Width = 62;
            // 
            // Views
            // 
            this.Views.Text = "Views";
            this.Views.Width = 69;
            // 
            // Downloads
            // 
            this.Downloads.Text = "Downloads";
            this.Downloads.Width = 86;
            // 
            // Size
            // 
            this.Size.Text = "Size";
            this.Size.Width = 40;
            // 
            // Author
            // 
            this.Author.Text = "Author";
            this.Author.Width = 292;
            // 
            // ReloadBTN
            // 
            this.ReloadBTN.BackColor = System.Drawing.Color.Transparent;
            this.ReloadBTN.Image = ((System.Drawing.Image)(resources.GetObject("ReloadBTN.Image")));
            this.ReloadBTN.Location = new System.Drawing.Point(459, 58);
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
            this.ModTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(144)))), ((int)(((byte)(180)))));
            this.ModTab.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ModTab.Location = new System.Drawing.Point(292, 62);
            this.ModTab.Name = "ModTab";
            this.ModTab.Padding = new System.Windows.Forms.Padding(4);
            this.ModTab.Size = new System.Drawing.Size(41, 21);
            this.ModTab.TabIndex = 21;
            this.ModTab.Tag = "2";
            this.ModTab.Text = "Mods";
            this.ModTab.Click += new System.EventHandler(this.ModTab_Click);
            // 
            // MapTab
            // 
            this.MapTab.AutoSize = true;
            this.MapTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(124)))), ((int)(((byte)(150)))));
            this.MapTab.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MapTab.Location = new System.Drawing.Point(334, 62);
            this.MapTab.Name = "MapTab";
            this.MapTab.Padding = new System.Windows.Forms.Padding(4);
            this.MapTab.Size = new System.Drawing.Size(48, 21);
            this.MapTab.TabIndex = 22;
            this.MapTab.Tag = "3";
            this.MapTab.Text = "Worlds";
            this.MapTab.Click += new System.EventHandler(this.MapTab_Click);
            // 
            // ComTab
            // 
            this.ComTab.AutoSize = true;
            this.ComTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(124)))), ((int)(((byte)(150)))));
            this.ComTab.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ComTab.Location = new System.Drawing.Point(383, 62);
            this.ComTab.Name = "ComTab";
            this.ComTab.Padding = new System.Windows.Forms.Padding(4);
            this.ComTab.Size = new System.Drawing.Size(74, 21);
            this.ComTab.TabIndex = 23;
            this.ComTab.Tag = "5";
            this.ComTab.Text = "Components";
            this.ComTab.Click += new System.EventHandler(this.ComTab_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(488, 58);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(3);
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.Install_Click);
            // 
            // ReleaseLabel
            // 
            this.ReleaseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ReleaseLabel.AutoSize = true;
            this.ReleaseLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.ReleaseLabel.Location = new System.Drawing.Point(175, 562);
            this.ReleaseLabel.Name = "ReleaseLabel";
            this.ReleaseLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ReleaseLabel.Size = new System.Drawing.Size(112, 13);
            this.ReleaseLabel.TabIndex = 25;
            this.ReleaseLabel.Text = "Release yyyy.mm.dd.v";
            this.ReleaseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(92)))), ((int)(((byte)(113)))));
            this.panel2.Controls.Add(this.LogoIMG);
            this.panel2.Controls.Add(this.LogoTXT);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(290, 38);
            this.panel2.TabIndex = 3;
            // 
            // SearchBar
            // 
            this.SearchBar.Location = new System.Drawing.Point(518, 65);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(183, 20);
            this.SearchBar.TabIndex = 27;
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
            // 
            // TMFS
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1105, 575);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.SettingsBTN);
            this.Controls.Add(this.SettingsStrip);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.ExitBTN);
            this.Controls.Add(this.HelpBTN);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ComTab);
            this.Controls.Add(this.MapTab);
            this.Controls.Add(this.ModTab);
            this.Controls.Add(this.SimplifyBTN);
            this.Controls.Add(this.LocationTextbox);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.ReloadBTN);
            this.Controls.Add(this.BrowseBTN);
            this.Controls.Add(this.DownloadsView);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.SettingsStrip;
            this.Name = "TMFS";
            this.Text = "Total Miner: Forge Simplifier";
            this.Load += new System.EventHandler(this.TMFS_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReloadBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SettingsStrip.ResumeLayout(false);
            this.SettingsStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExitBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LogoTXT;
        private System.Windows.Forms.PictureBox LogoIMG;
        private System.Windows.Forms.TextBox LocationTextbox;
        private System.Windows.Forms.Label LocationLabel;
        private System.Windows.Forms.OpenFileDialog FilePicker;
        private System.Windows.Forms.Button BrowseBTN;
        private System.Windows.Forms.Button SimplifyBTN;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ListView DownloadsView;
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label SettingsBTN;
        private System.Windows.Forms.Label ReleaseLabel;
        private System.Windows.Forms.MenuStrip SettingsStrip;
        private System.Windows.Forms.ToolStripComboBox SortSET;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox SearchBar;
    }
}

