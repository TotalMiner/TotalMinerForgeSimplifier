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
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Downloads");
            this.ExitBTN = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.CategoryBox = new System.Windows.Forms.ComboBox();
            this.ReloadBTN = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoIMG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReloadBTN)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitBTN
            // 
            this.ExitBTN.AutoSize = true;
            this.ExitBTN.BackColor = System.Drawing.Color.Transparent;
            this.ExitBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ExitBTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitBTN.Location = new System.Drawing.Point(807, 0);
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(67)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Controls.Add(this.LogoTXT);
            this.panel1.Controls.Add(this.LogoIMG);
            this.panel1.Controls.Add(this.ExitBTN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 21);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_MoveMouse);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(739, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2, 1, 0, 5);
            this.label1.Size = new System.Drawing.Size(41, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = " Help ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave_1);
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover_1);
            // 
            // Minimize
            // 
            this.Minimize.AutoSize = true;
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Minimize.Location = new System.Drawing.Point(780, 0);
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
            this.LogoTXT.Font = new System.Drawing.Font("MS Outlook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.LogoTXT.Location = new System.Drawing.Point(25, 4);
            this.LogoTXT.Name = "LogoTXT";
            this.LogoTXT.Size = new System.Drawing.Size(138, 14);
            this.LogoTXT.TabIndex = 2;
            this.LogoTXT.Text = "Total Miner: Forge Simplifier";
            this.LogoTXT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_MouseDown);
            this.LogoTXT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_MoveMouse);
            // 
            // LogoIMG
            // 
            this.LogoIMG.Image = ((System.Drawing.Image)(resources.GetObject("LogoIMG.Image")));
            this.LogoIMG.Location = new System.Drawing.Point(0, 0);
            this.LogoIMG.Name = "LogoIMG";
            this.LogoIMG.Size = new System.Drawing.Size(22, 22);
            this.LogoIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoIMG.TabIndex = 1;
            this.LogoIMG.TabStop = false;
            // 
            // LocationTextbox
            // 
            this.LocationTextbox.Location = new System.Drawing.Point(28, 130);
            this.LocationTextbox.Name = "LocationTextbox";
            this.LocationTextbox.Size = new System.Drawing.Size(665, 20);
            this.LocationTextbox.TabIndex = 5;
            this.LocationTextbox.TextChanged += new System.EventHandler(this.FiletextBox_TextChanged);
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LocationLabel.Location = new System.Drawing.Point(25, 112);
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
            this.BrowseBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(154)))), ((int)(((byte)(180)))));
            this.BrowseBTN.FlatAppearance.BorderSize = 0;
            this.BrowseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseBTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BrowseBTN.Location = new System.Drawing.Point(692, 130);
            this.BrowseBTN.Name = "BrowseBTN";
            this.BrowseBTN.Size = new System.Drawing.Size(59, 20);
            this.BrowseBTN.TabIndex = 8;
            this.BrowseBTN.Text = "Browse";
            this.BrowseBTN.UseVisualStyleBackColor = false;
            this.BrowseBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // SimplifyBTN
            // 
            this.SimplifyBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(154)))), ((int)(((byte)(180)))));
            this.SimplifyBTN.FlatAppearance.BorderSize = 0;
            this.SimplifyBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SimplifyBTN.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.SimplifyBTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SimplifyBTN.Location = new System.Drawing.Point(28, 159);
            this.SimplifyBTN.Name = "SimplifyBTN";
            this.SimplifyBTN.Size = new System.Drawing.Size(61, 22);
            this.SimplifyBTN.TabIndex = 9;
            this.SimplifyBTN.Text = "Simplify";
            this.SimplifyBTN.UseVisualStyleBackColor = false;
            this.SimplifyBTN.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.ProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProgressBar.Location = new System.Drawing.Point(0, 514);
            this.ProgressBar.Maximum = 5;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(838, 4);
            this.ProgressBar.Step = 0;
            this.ProgressBar.TabIndex = 10;
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.ForeColor = System.Drawing.Color.Coral;
            this.StatusLabel.Location = new System.Drawing.Point(9, 498);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(37, 13);
            this.StatusLabel.TabIndex = 11;
            this.StatusLabel.Text = "Status";
            // 
            // DownloadsView
            // 
            this.DownloadsView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(108)))), ((int)(((byte)(133)))));
            this.DownloadsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Rating,
            this.Views,
            this.Downloads,
            this.Size,
            this.Author});
            this.DownloadsView.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadsView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(253)))));
            this.DownloadsView.HoverSelection = true;
            this.DownloadsView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem8});
            this.DownloadsView.Location = new System.Drawing.Point(12, 203);
            this.DownloadsView.Name = "DownloadsView";
            this.DownloadsView.Size = new System.Drawing.Size(814, 292);
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
            this.Author.Width = 286;
            // 
            // CategoryBox
            // 
            this.CategoryBox.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.CategoryBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(108)))), ((int)(((byte)(133)))));
            this.CategoryBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryBox.Font = new System.Drawing.Font("Segoe UI Symbol", 8.25F);
            this.CategoryBox.ForeColor = System.Drawing.SystemColors.Window;
            this.CategoryBox.FormattingEnabled = true;
            this.CategoryBox.Items.AddRange(new object[] {
            "Worlds",
            "Mods",
            "Components"});
            this.CategoryBox.Location = new System.Drawing.Point(28, 63);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(148, 21);
            this.CategoryBox.TabIndex = 18;
            this.CategoryBox.SelectedIndexChanged += new System.EventHandler(this.CategoryBox_SelectedIndexChanged);
            this.CategoryBox.SelectionChangeCommitted += new System.EventHandler(this.CategoryBox_SelectionChangeCommitted);
            // 
            // ReloadBTN
            // 
            this.ReloadBTN.BackColor = System.Drawing.Color.Transparent;
            this.ReloadBTN.Image = ((System.Drawing.Image)(resources.GetObject("ReloadBTN.Image")));
            this.ReloadBTN.Location = new System.Drawing.Point(182, 59);
            this.ReloadBTN.Name = "ReloadBTN";
            this.ReloadBTN.Padding = new System.Windows.Forms.Padding(3);
            this.ReloadBTN.Size = new System.Drawing.Size(28, 28);
            this.ReloadBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReloadBTN.TabIndex = 20;
            this.ReloadBTN.TabStop = false;
            this.ReloadBTN.Click += new System.EventHandler(this.Reload_Click);
            // 
            // TMFS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(838, 518);
            this.Controls.Add(this.SimplifyBTN);
            this.Controls.Add(this.LocationTextbox);
            this.Controls.Add(this.LocationLabel);
            this.Controls.Add(this.ReloadBTN);
            this.Controls.Add(this.BrowseBTN);
            this.Controls.Add(this.CategoryBox);
            this.Controls.Add(this.DownloadsView);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TMFS";
            this.Text = "Total Miner: Forge Simplifier";
            this.Load += new System.EventHandler(this.TMFS_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoIMG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReloadBTN)).EndInit();
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
        private System.Windows.Forms.ComboBox CategoryBox;
        private System.Windows.Forms.Label Minimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ReloadBTN;
    }
}

