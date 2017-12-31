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
        static readonly string TotalMinerMain = Path.Combine(new[] { Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "My Games", "TotalMiner" });
        new string Location;
        string status;
        string filename;
        bool isLocal;

        Point lastPoint;

        WebClient Client = new WebClient();
        HelpPage Help;
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
                Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),(Environment.Is64BitProcess ? "x64" : "x86")),
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
            ExitBTN.BackColor = Color.DarkOrange;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            ExitBTN.BackColor = Color.Transparent;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isLocal == true && (LocationTextbox.Text == null || !File.Exists(LocationTextbox.Text)))
            {
                status = "File not found.";
                StatusLabel.Text = status;
            }
            else
            {
                string zipPath;
                if (isLocal == true)
                {

                    zipPath = LocationTextbox.Text;
                }
                else
                {
                    zipPath = Path.Combine(Location, "TempDownload");
                    Client.DownloadFile(LocationTextbox.Text, zipPath);
                    Console.WriteLine(LocationTextbox.Text + " -> " + zipPath);
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
                    Console.WriteLine(Location);
                    tmp.ExtractArchive(Location);
                }
                status = "completed";
                StatusLabel.Text = status;

                if(isLocal == false)
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
                LocationTextbox.Text = FilePicker.InitialDirectory + FilePicker.FileName;
                filename = FilePicker.FileName;
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
            LocationTextbox.Text = url;
            SimplifyBTN.PerformClick();
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
                    Location = Path.Combine(TotalMinerMain, "Maps");
                    status = "ismap";
                    StatusLabel.Text = status;
                    break;
                case 1:
                    Category = 2;
                    Location = Path.Combine(TotalMinerMain, "Mods");
                    status = "ismod";
                    StatusLabel.Text = status;
                    break;
                case 2:
                    Category = 5;
                    Location = Path.Combine(TotalMinerMain, "Com");
                    status = "iscom";
                    StatusLabel.Text = status;
                    break;
                default:
                    Console.WriteLine("Something's broke");
                    break;
            }
            LoadContent();
        }

        private void minimize_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Minimize_MouseHover(object sender, EventArgs e)
        {
            Minimize.BackColor = Color.Orange;
        }

        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            Minimize.BackColor = Color.Transparent;

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Help = new HelpPage();
            Help.Show();
        }

        private void label1_MouseHover_1(object sender, EventArgs e)
        {
            label1.BackColor = Color.LightSteelBlue;
        }

        private void label1_MouseLeave_1(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;

        }

        private void Reload_Click(object sender, EventArgs e)
        {
            LoadContent();
        }

        private void FiletextBox_TextChanged(object sender, EventArgs e)
        {
            if (LocationTextbox.Text.StartsWith("http"))
            {
                LocationLabel.Text = "Zip location (Online)";
                isLocal = false;
            }
            else if (File.Exists(LocationTextbox.Text))
            {
                LocationLabel.Text = "Zip location (Local)";
                isLocal = true;

            }
            else if (LocationLabel.Text != "" || LocationLabel.Text != null)
            {
                LocationLabel.Text = "Zip location (Not Found)";

            }
            else
            {
                LocationLabel.Text = "Zip location (none)";
            }
        }
    }
}
