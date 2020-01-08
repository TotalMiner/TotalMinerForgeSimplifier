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
            this.renderBox.Location = new System.Drawing.Point(12, 12);
            this.renderBox.Name = "renderBox";
            this.renderBox.Size = new System.Drawing.Size(290, 426);
            this.renderBox.TabIndex = 1;
            this.renderBox.TabStop = false;
            // 
            // compview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.renderBox);
            this.Controls.Add(this.listView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "compview";
            this.Text = "Component Viewer";
            this.Load += new System.EventHandler(this.compview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.renderBox)).EndInit();
            this.ResumeLayout(false);

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
    }
}