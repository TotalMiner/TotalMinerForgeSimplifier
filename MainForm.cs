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
using ScrapySharp.Network;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using static System.Windows.Forms.ListViewItem;
using SevenZip;
using System.Reflection;

namespace TMF_Simplifier
{
    public partial class TMFS : Form
    {
        public static TMFS Instance;
        public static int Category;
        public static List<int>[] Ids;
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
            Instance = this;

            DownloadsView.Items.Clear();
            Ids = new List<int>[6];
            for(int i = 0; i < 6; i++)
            {
                Ids[i] = new List<int>();
            }
            CategoryBox.SelectedIndex = CategoryBox.Items.IndexOf("Mods");
            Category = 2;
            SevenZip.SevenZipExtractor.SetLibraryPath(
                Path.Combine(
                Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),"x86"),
                "7z.dll"));
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
            if (FileRadioBTN.Checked && (FiletextBox.Text == null || !File.Exists(FiletextBox.Text)))
            {
                status = "File not found.";
                StatusLabel.Text = status;
            }
            else
            {
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
                string zipPath;
                if (FileRadioBTN.Checked == true)
                {

                    zipPath = FiletextBox.Text;
                }
                else
                {
                    zipPath = Path.Combine(Location, "TempDownload");
                    Client.DownloadFile(WebsitetextBox.Text, zipPath);
                    Console.WriteLine(WebsitetextBox.Text + " -> " + zipPath);
                }
                status = "Starting";
                StatusLabel.Text = status;
                ProgressBar.Value = 1;
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
                ProgressBar.Value = 5;
                StatusLabel.Text = status;
                using (var tmp = new SevenZipExtractor(zipPath))
                {
                    ProgressBar.Value = 0;
                    ProgressBar.Maximum = tmp.ArchiveFileData.Count;
                    for (int i = 0; i < tmp.ArchiveFileData.Count; i++)
                    {
                        tmp.ExtractFiles(Location, tmp.ArchiveFileData[i].Index);
                        ProgressBar.Value = i;
                    }
                }
                status = "completed";
                StatusLabel.Text = status;

                if(WebRadioBTN.Checked)
                {
                    File.Delete(zipPath);
                }
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

        private void LoadContent()
        {
            DownloadsView.Items.Clear();
            Task.Factory.StartNew(() => Scraper.Scrape(Category,0));
        }

        delegate void AddRowCallback(ListViewItem row);

        public void AddRow(ListViewItem row)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.DownloadsView.InvokeRequired)
            {
                AddRowCallback d = new AddRowCallback(AddRow);
                this.Invoke(d, new object[] { row });
            }
            else
            {
                this.DownloadsView.Items.Add(row);
                foreach(ColumnHeader header in DownloadsView.Columns)
                {
                    header.Width = -2;
                }
            }
        }

        private void DownloadsView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DownloadsView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string url = "http://totalminerforums.net/index.php?action=downloads;sa=downfile&id=" + Ids[Category][DownloadsView.SelectedItems[0].Index];
            Console.WriteLine("Downloading " + url);
            FileRadioBTN.Checked = false;
            WebRadioBTN.Checked = true;
            WebsitetextBox.Text = url;
            button2.PerformClick();
        }

        private void CategoryBox_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void CategoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(CategoryBox.SelectedIndex);
            switch (CategoryBox.SelectedIndex)
            {
                case 0:
                    Category = 3;
                    break;
                case 1:
                    Category = 2;
                    break;
                case 2:
                    Category = 5;
                    break;
                default:
                    Console.WriteLine("Something's broke");
                    break;
            }
            LoadContent();
        }
    }
}
