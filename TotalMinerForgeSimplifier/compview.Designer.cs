using System;

namespace TMF_Simplifier
{
    partial class compview
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
            this.listView = new System.Windows.Forms.ListView();
            this.comname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comfile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.renderBox = new System.Windows.Forms.PictureBox();
            this.compName = new System.Windows.Forms.TextBox();
            this.renameBTN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.renderBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.comname,
            this.comfile});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(315, 12);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(473, 426);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            // 
            // comname
            // 
            this.comname.Text = "Name";
            this.comname.Width = 314;
            // 
            // comfile
            // 
            this.comfile.Text = "File";
            this.comfile.Width = 157;
            // 
            // renderBox
            // 
            this.renderBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.renderBox.Location = new System.Drawing.Point(12, 52);
            this.renderBox.Name = "renderBox";
            this.renderBox.Size = new System.Drawing.Size(290, 386);
            this.renderBox.TabIndex = 1;
            this.renderBox.TabStop = false;
            // 
            // compName
            // 
            this.compName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(213)))), ((int)(((byte)(237)))));
            this.compName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.compName.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.compName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.compName.Location = new System.Drawing.Point(12, 12);
            this.compName.Margin = new System.Windows.Forms.Padding(6);
            this.compName.MaximumSize = new System.Drawing.Size(207, 27);
            this.compName.MinimumSize = new System.Drawing.Size(207, 27);
            this.compName.Name = "compName";
            this.compName.Size = new System.Drawing.Size(207, 27);
            this.compName.TabIndex = 2;
            this.compName.Text = "Example";
            // 
            // renameBTN
            // 
            this.renameBTN.AutoSize = true;
            this.renameBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.renameBTN.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renameBTN.ForeColor = System.Drawing.Color.White;
            this.renameBTN.Location = new System.Drawing.Point(225, 12);
            this.renameBTN.Name = "renameBTN";
            this.renameBTN.Padding = new System.Windows.Forms.Padding(4);
            this.renameBTN.Size = new System.Drawing.Size(77, 27);
            this.renameBTN.TabIndex = 3;
            this.renameBTN.Text = "Rename";
            // 
            // compview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.renameBTN);
            this.Controls.Add(this.compName);
            this.Controls.Add(this.renderBox);
            this.Controls.Add(this.listView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "compview";
            this.Text = "Component Viewer";
            this.Load += new System.EventHandler(this.compview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.renderBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader comname;
        private System.Windows.Forms.ColumnHeader comfile;
        private System.Windows.Forms.PictureBox renderBox;

        
        public IntPtr getDrawSurface()
        {
            return renderBox.Handle;
        }

        private System.Windows.Forms.TextBox compName;
        private System.Windows.Forms.Label renameBTN;
    }
}