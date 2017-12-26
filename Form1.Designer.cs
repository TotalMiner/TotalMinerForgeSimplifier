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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IsMod = new System.Windows.Forms.RadioButton();
            this.IsMap = new System.Windows.Forms.RadioButton();
            this.IsCom = new System.Windows.Forms.RadioButton();
            this.FiletextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FilePicker = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.WebsitetextBox = new System.Windows.Forms.TextBox();
            this.FileRadioBTN = new System.Windows.Forms.RadioButton();
            this.WebRadioBTN = new System.Windows.Forms.RadioButton();
            this.TypegroupBox = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TypegroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(807, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(2, 0, 0, 5);
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = " × ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 21);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_MoveMouse);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Outlook", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(25, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Miner: Forge Simplifier";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_MoveMouse);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // IsMod
            // 
            this.IsMod.AutoSize = true;
            this.IsMod.Checked = true;
            this.IsMod.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.IsMod.Location = new System.Drawing.Point(6, 18);
            this.IsMod.Name = "IsMod";
            this.IsMod.Size = new System.Drawing.Size(48, 19);
            this.IsMod.TabIndex = 2;
            this.IsMod.TabStop = true;
            this.IsMod.Text = "Mod";
            this.IsMod.UseVisualStyleBackColor = true;
            // 
            // IsMap
            // 
            this.IsMap.AutoSize = true;
            this.IsMap.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.IsMap.Location = new System.Drawing.Point(6, 41);
            this.IsMap.Name = "IsMap";
            this.IsMap.Size = new System.Drawing.Size(48, 19);
            this.IsMap.TabIndex = 3;
            this.IsMap.Text = "Map";
            this.IsMap.UseVisualStyleBackColor = true;
            // 
            // IsCom
            // 
            this.IsCom.AutoSize = true;
            this.IsCom.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.IsCom.Location = new System.Drawing.Point(6, 64);
            this.IsCom.Name = "IsCom";
            this.IsCom.Size = new System.Drawing.Size(91, 19);
            this.IsCom.TabIndex = 4;
            this.IsCom.Text = "Component";
            this.IsCom.UseVisualStyleBackColor = true;
            // 
            // FiletextBox
            // 
            this.FiletextBox.Location = new System.Drawing.Point(63, 211);
            this.FiletextBox.Name = "FiletextBox";
            this.FiletextBox.Size = new System.Drawing.Size(605, 20);
            this.FiletextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Zip location (file)";
            // 
            // FilePicker
            // 
            this.FilePicker.DefaultExt = "C:\\Users\\";
            this.FilePicker.Filter = "\"Zip files (*.zip)|*.zip|(*.rar)|*.rar\"";
            this.FilePicker.SupportMultiDottedExtensions = true;
            this.FilePicker.Title = "Choose zip";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(671, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 20);
            this.button1.TabIndex = 8;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GrayText;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(66, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 22);
            this.button2.TabIndex = 9;
            this.button2.Text = "Simplify";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProgressBar
            // 
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
            this.StatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(773, 498);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(37, 13);
            this.StatusLabel.TabIndex = 11;
            this.StatusLabel.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(63, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Zip location (Website)";
            // 
            // WebsitetextBox
            // 
            this.WebsitetextBox.Location = new System.Drawing.Point(63, 253);
            this.WebsitetextBox.Name = "WebsitetextBox";
            this.WebsitetextBox.ReadOnly = true;
            this.WebsitetextBox.Size = new System.Drawing.Size(605, 20);
            this.WebsitetextBox.TabIndex = 12;
            // 
            // FileRadioBTN
            // 
            this.FileRadioBTN.AutoSize = true;
            this.FileRadioBTN.Checked = true;
            this.FileRadioBTN.Location = new System.Drawing.Point(43, 211);
            this.FileRadioBTN.Name = "FileRadioBTN";
            this.FileRadioBTN.Size = new System.Drawing.Size(14, 13);
            this.FileRadioBTN.TabIndex = 14;
            this.FileRadioBTN.TabStop = true;
            this.FileRadioBTN.UseVisualStyleBackColor = true;
            this.FileRadioBTN.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // WebRadioBTN
            // 
            this.WebRadioBTN.AutoSize = true;
            this.WebRadioBTN.Location = new System.Drawing.Point(43, 256);
            this.WebRadioBTN.Name = "WebRadioBTN";
            this.WebRadioBTN.Size = new System.Drawing.Size(14, 13);
            this.WebRadioBTN.TabIndex = 15;
            this.WebRadioBTN.UseVisualStyleBackColor = true;
            // 
            // TypegroupBox
            // 
            this.TypegroupBox.Controls.Add(this.IsMap);
            this.TypegroupBox.Controls.Add(this.IsMod);
            this.TypegroupBox.Controls.Add(this.IsCom);
            this.TypegroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TypegroupBox.Location = new System.Drawing.Point(63, 57);
            this.TypegroupBox.Name = "TypegroupBox";
            this.TypegroupBox.Size = new System.Drawing.Size(200, 100);
            this.TypegroupBox.TabIndex = 16;
            this.TypegroupBox.TabStop = false;
            this.TypegroupBox.Text = "Type";
            // 
            // TMFS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(838, 518);
            this.Controls.Add(this.TypegroupBox);
            this.Controls.Add(this.WebRadioBTN);
            this.Controls.Add(this.FileRadioBTN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WebsitetextBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FiletextBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TMFS";
            this.Text = "Total Miner: Forge Simplifier";
            this.Load += new System.EventHandler(this.TMFS_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TypegroupBox.ResumeLayout(false);
            this.TypegroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton IsMod;
        private System.Windows.Forms.RadioButton IsMap;
        private System.Windows.Forms.RadioButton IsCom;
        private System.Windows.Forms.TextBox FiletextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog FilePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox WebsitetextBox;
        private System.Windows.Forms.RadioButton FileRadioBTN;
        private System.Windows.Forms.RadioButton WebRadioBTN;
        private System.Windows.Forms.GroupBox TypegroupBox;
    }
}

