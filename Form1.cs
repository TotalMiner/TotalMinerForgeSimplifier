using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Net;

namespace TMF_Simplifier
{
    public partial class TMFS : Form
    {
        static readonly string TotalMinerMain = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/My Games/TotalMiner";
        string Location;
        string status;
        string filename;

        Point lastPoint;

        WebClient Client = new WebClient();

        public TMFS()
        {
            InitializeComponent();
            if (!Directory.Exists(TotalMinerMain))
            {
                MessageBox.Show
                    ("Alert, Total Miner has not been found,\nplease make sure the game is installed\nand you have ran it at least once.",
                    "Total Miner: Forge Simplifier",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                status = "Not ready, check that Total Miner has been installed properly";
            }
            else
            {
                status = "Ready";
                StatusLabel.Text = status;
            }
            
        }

        #region lastpoint
        private void top_MoveMouse (object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void top_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        #endregion

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.IndianRed;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (FiletextBox.Text == null || !File.Exists(FiletextBox.Text))
            {
                status = "File not found.";
                StatusLabel.Text = status;
            }
            else
            {
                string zipPath;
                if (FileRadioBTN.Checked == true)
                {

                    zipPath = FiletextBox.Text;
                }
                else
                {
                    zipPath = $"";
                    Client.DownloadFile(WebsitetextBox.Text, Location);
                }
                status = "Starting";
                StatusLabel.Text = status;
                ProgressBar.Value = 1;

                if (IsMod.Checked == true)
                {
                    Location = TotalMinerMain + "/Mods";
                    status = "ismod";
                    StatusLabel.Text = status;

                }
                else if (IsMap.Checked == true)
                {
                    Location = TotalMinerMain + "/Maps";
                    status = "ismap";
                    StatusLabel.Text = status;

                }
                else if (IsCom.Checked == true)
                {
                    Location = TotalMinerMain + "/Com";
                    status = "iscom";
                    StatusLabel.Text = status;

                }
                ProgressBar.Value = 2;
                status = "Checking if directory exists";

                if (!Directory.Exists(Location))
                {
                    status = "creating directory";
                StatusLabel.Text = status;
                    ProgressBar.Value = 3;

                    Directory.CreateDirectory(Location);
                    ProgressBar.Value = 4;

                }

                status = "unzipping";
                StatusLabel.Text = status;
                ZipFile.ExtractToDirectory(zipPath, Location);
                ProgressBar.Value = 5;
                status = "completed";
                StatusLabel.Text = status;
            }
        }

        private void TMFS_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FilePicker.ShowDialog(this) == DialogResult.OK)
            {
                FiletextBox.Text = FilePicker.InitialDirectory + FilePicker.FileName;
                filename = FilePicker.FileName;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (FileRadioBTN.Checked == true)
            {
                FiletextBox.ReadOnly = false;
                WebsitetextBox.ReadOnly = true;

            }
            else
            {
                FiletextBox.ReadOnly = true;
                WebsitetextBox.ReadOnly = false;
            }
        }
    }
}
