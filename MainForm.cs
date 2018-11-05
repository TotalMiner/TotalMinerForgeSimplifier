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
using TMF_Simplifier.Github;
using System.Diagnostics;

namespace TMF_Simplifier
{
    public partial class TMFS : Form
    {
        public static TMFS Instance;
        public static int Category;
        public static List<int>[] Ids;
        static readonly string TotalMinerMain = Path.Combine(new[] { Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "My Games", "TotalMiner" });
        private string ExtractLocation;
        string Status
        {
            get
            {
                return StatusLabel.Text;
            }
            set
            {
                StatusLabel.Text = value;
            }
        }
        string filename;
        bool isLocal;

        public static int FunctionTab = 0;

        public readonly Color ButtonActiveTheme = ColorTranslator.FromHtml("#4489FE");
        public readonly Color ButtonHighlightTheme = ColorTranslator.FromHtml("#7A718B");
        public readonly Color ButtonTheme = ColorTranslator.FromHtml("#C0C0FF");
        public readonly Color DarkText = ColorTranslator.FromHtml("#404040");
        public readonly Color PageSelection = ColorTranslator.FromHtml("#8080FF");
        public readonly Color PageSelectionText = ColorTranslator.FromHtml("#404040");
        public readonly Color HeadTab = ColorTranslator.FromHtml("#303F9E");

        Point lastPoint;

        string NewSearch;
        int PrevSearch;

        WebClient Client = new WebClient();
        HelpPage Help;
        public TMFS()
        {
            CleanDir(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            InitializeComponent();
            if (!Directory.Exists(TotalMinerMain))
            {
                MessageBox.Show
                    ("Alert, Total Miner has not been found,\nplease make sure the game is installed\nand you have ran it at least once.",
                    "Total Miner: Forge Simplifier",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                Status = "Not ready, check that Total Miner has been installed properly";
            }
            else
            {
                Status = "Ready";
            }
            Instance = this;

            ItemView.Items.Clear();
            Ids = new List<int>[6];
            for(int i = 0; i < 6; i++)
            {
                Ids[i] = new List<int>();
            }
            SevenZip.SevenZipExtractor.SetLibraryPath(
                Path.Combine(
                Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),(Environment.Is64BitProcess ? "x64" : "x86")),
                "7z.dll"));


            Category = 2;
            ExtractLocation = Path.Combine(TotalMinerMain, "Mods");
            Status = "Mod";
            LoadContent();

            ModTab.BackColor = ButtonActiveTheme;
            MapTab.BackColor = ButtonTheme;
            ComTab.BackColor = ButtonTheme;
            

            ReleaseLabel.Text = $"Release {Constants.Version}";
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
            
        }

        private void TMFS_Load(object sender, EventArgs e)
        {
#if DEBUG
            Console.WriteLine("In debug, not checking for updates.");
#else
            Console.WriteLine("Checking for updates...");
            Release latestRelease = await Updater.GetLatestRelease();
            if (latestRelease != null)
            {
                Console.WriteLine("Got latest release");
                if (!await Updater.IsUpToDate())
                {
                    DialogResult dialogResult = MessageBox.Show($"It appears there is a TMFS update available, would you like to update? ({Constants.Version} != {latestRelease.tag_name})", "TMFS Update", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        await Updater.Update();
                        Process thisprocess = Process.GetCurrentProcess();
                        string me = thisprocess.MainModule.FileName;
                        Process.Start(me);
                        thisprocess.CloseMainWindow();
                        thisprocess.Close();
                        thisprocess.Dispose();
                    }
                }
            } else
            {
                Console.WriteLine("Failed to get latest release");
            }
#endif
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FunctionTab == 0)
            {
                if (FilePicker.ShowDialog(this) == DialogResult.OK)
                {
                    LocationTextbox.Text = FilePicker.InitialDirectory + FilePicker.FileName;
                    filename = FilePicker.FileName;
                }
            }
            else if(FunctionTab == 1)
            {
                if (!string.IsNullOrEmpty(LocationTextbox.Text))
                {
                    string DelObj = LocationTextbox.Text;
                    ConsoleText.Text += "Deleting " + DelObj + Environment.NewLine;
                    Directory.Delete(DelObj, true);
                    ConsoleText.Text += "Deleted";
                    DownloadPage();
                    LocationTextbox.Text = "";
                }
                else
                {
                    ConsoleText.Text += "[Prevented bad deletion]";
                }
            }
        }

        private void LoadContent()
        {
                ItemView.Items.Clear();
                Task.Factory.StartNew(() => Scraper.Scrape(Category, 1));
        }

        delegate void AddRowCallback(ListViewItem row);

        public void AddRow(ListViewItem row)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.ItemView.InvokeRequired)
            {
                AddRowCallback d = new AddRowCallback(AddRow);
                this.Invoke(d, new object[] { row });
            }
            else
            {
                this.ItemView.Items.Add(row);
                foreach(ColumnHeader header in ItemView.Columns)
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
            if (FunctionTab == 0)
            {
                string url = "http://totalminerforums.net/index.php?action=downloads;sa=downfile&id=" + Ids[Category][ItemView.SelectedItems[0].Index];
                LocationTextbox.Text = url;
            }
            else if (FunctionTab == 1)
            {
                string ItemSelected = Path.Combine(ExtractLocation , ItemView.SelectedItems[0].SubItems[0].Text.Replace("\n",""));
                LocationTextbox.Text = ItemSelected;
                LocationLabel.Text = "Intalled item:";
            }
        }

        private void CategoryBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
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
            HelpBTN.BackColor = Color.LightSteelBlue;
        }

        private void label1_MouseLeave_1(object sender, EventArgs e)
        {
            HelpBTN.BackColor = Color.Transparent;

        }

        private void Reload_Click(object sender, EventArgs e)
        {
            if (FunctionTab == 0)
            {
                LoadContent();
            }
            else if (FunctionTab == 1)
            {
                DownloadPage();

            }
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

        private void Install_Click(object sender, EventArgs e)
        {
            
            Console.WriteLine("Intalling " + Location);

            if (isLocal == true && (LocationTextbox.Text == null || !File.Exists(LocationTextbox.Text)))
            {
                Status = "File not found.";
            }
            else
            {
                string zipPath = "";
                if (isLocal == true)
                {

                    zipPath = LocationTextbox.Text;
                }
                else
                {
                    if (!string.IsNullOrEmpty(LocationTextbox.Text))
                    {
                        zipPath = Path.Combine(ExtractLocation, "TempDownload");
                        Client.DownloadFile(LocationTextbox.Text, zipPath);
                        Console.WriteLine(LocationTextbox.Text + " -> " + zipPath);
                    }
                    else
                    {
                        StatusLabel.ForeColor = Color.Red;
                        Status = "Error, check console";
                        ConsoleText.Text += "[Cannot leave location blank]";
                    }
                }
                Status = "Starting";
                StatusLabel.ForeColor = Color.Gold;
                ProgressBar.Value = 1;
                Status = "Checking if directory exists";
                ProgressBar.Value = 2;

                if (!Directory.Exists(ExtractLocation))
                {
                    Status = "Creating directory";
                    ProgressBar.Value = 3;

                    Directory.CreateDirectory(ExtractLocation);
                    ProgressBar.Value = 4;

                }

                Status = "Unzipping";
                
                try
                {
                    using (var tmp = new SevenZipExtractor(zipPath))
                    {
                        tmp.ExtractArchive(ExtractLocation);
                    }
                    StatusLabel.ForeColor = Color.Lime;
                    Status = "Completed";
                    ProgressBar.Value = 5;
                }
                catch (Exception error)
                {
                    Status = "Error, can't unzip file.";
                    StatusLabel.ForeColor = Color.Red;
                    ProgressBar.Value = 0;
                    ConsoleText.Text += error.ToString();

                }
                if (isLocal == false)
                {
                    try
                    { 
                    File.Delete(zipPath);
                }
                    catch(Exception error)
                    {
                        ConsoleText.Text += error.ToString();
                    }
                }
            }
        }

        private void LocationTextbox_DragDrop(object sender, DragEventArgs e)
        {
            LocationTextbox.Text = e.Data.GetData(DataFormats.FileDrop).ToString();
        }

        private void ModTab_Click(object sender, EventArgs e)
        {

            Category = 2;
                ExtractLocation = Path.Combine(TotalMinerMain, "Mods");
            StatusLabel.ForeColor = Color.LightSeaGreen;

            ModTab.BackColor = ButtonActiveTheme;
                MapTab.BackColor = ButtonTheme;
                ComTab.BackColor = ButtonTheme;
                ModTab.ForeColor = Color.White;
                MapTab.ForeColor = DarkText;
                ComTab.ForeColor = DarkText;
            if (FunctionTab == 0)
            {
                Status = "Mod";
                LoadContent();
            }
            else if (FunctionTab == 1)
            {
                string[] Downloads = Directory.GetDirectories(ExtractLocation);
                ItemView.Items.Clear();
                foreach (string item in Downloads)
                {
                    ItemView.Items.Add($"\n{item.Replace($"{ExtractLocation}\\", "")}");
                }
            }

        }

        private void MapTab_Click(object sender, EventArgs e)
        {
            Category = 3;
            ExtractLocation = Path.Combine(TotalMinerMain, "Maps");
            StatusLabel.ForeColor = Color.LightSeaGreen;

            ModTab.BackColor = ButtonTheme;
                MapTab.BackColor = ButtonActiveTheme;
                ComTab.BackColor = ButtonTheme;
                ModTab.ForeColor = DarkText;
                MapTab.ForeColor = Color.White;
                ComTab.ForeColor = DarkText;
            if (FunctionTab == 0)
            {
                
                Status = "Map";
                LoadContent();
            }
            else if (FunctionTab == 1)
            {
                string[] Downloads = Directory.GetDirectories(ExtractLocation);
                ItemView.Items.Clear();
                foreach (string item in Downloads)
                {
                    ItemView.Items.Add($"\n{item.Replace($"{ExtractLocation}\\", "")}");
                }
            }
        }

        private void ComTab_Click(object sender, EventArgs e)
        {
                Category = 5;
                ExtractLocation = Path.Combine(TotalMinerMain, "Com");
            StatusLabel.ForeColor = Color.LightSeaGreen;
                ModTab.BackColor = ButtonTheme;
                MapTab.BackColor = ButtonTheme;
                ComTab.BackColor = ButtonActiveTheme;
                ModTab.ForeColor = DarkText;
                MapTab.ForeColor = DarkText;
                ComTab.ForeColor = Color.White;
            if (FunctionTab == 0)
            {
                Status = "Component";
                LoadContent();
            }
            else if (FunctionTab == 1)
            {
                string[] Downloads = Directory.GetDirectories(ExtractLocation);
                ItemView.Items.Clear();
                foreach (string item in Downloads)
                {
                    ItemView.Items.Add($"\n{item.Replace($"{ExtractLocation}\\", "")}");
                }
            }
        }

        private void SortSET_IndexChanged(object sender, EventArgs e)
        {
            switch (SortSET.SelectedIndex)
            {
                case 0:
                    ItemView.Sorting = SortOrder.None;
                    LoadContent();
                    break;
                case 1:
                    ItemView.Sorting = SortOrder.Ascending;
                    break;
                case 2:
                    ItemView.Sorting = SortOrder.Descending;
                    break;

                default:
                    ItemView.Sorting = SortOrder.None;

                    break;

            }
        }

        private void SettingsBTN_Click(object sender, EventArgs e)
        {
            SettingsStrip.Visible = !SettingsStrip.Visible;
        }

        static void CleanDir(string sDir)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    CleanDir(d);
                }

                foreach (string f in Directory.GetFiles(sDir))
                {
                    if (f.EndsWith(".bak"))
                    {
                        File.Delete(f);
                    }
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            NewSearch = SearchBar.Text;

            if (NewSearch.Length < PrevSearch)
            {
                if (FunctionTab == 0)
                {
                    LoadContent();
                }
                else if (FunctionTab == 1)
                {
                    DownloadPage();

                }
                SearchBar.Text = "";
                PrevSearch = 0;
            }
            else
            {
                PrevSearch = NewSearch.Length;
            }

            foreach (ListViewItem item in ItemView.Items)
            {
                if (!item.ToString().Contains(SearchBar.Text))
                {
                    item.Remove();
                }
            }
        }

        private void SearchBar_Click(object sender, EventArgs e)
        {
            SearchBar.Text = "";
            PrevSearch = 0;
        }

        public void Label2_Click(object sender, EventArgs e)
        {
            InstalledPage.BackColor = PageSelection;
            InstallPage.BackColor = ButtonTheme;

            InstallPage.ForeColor = PageSelectionText;
            InstalledPage.ForeColor = Color.White;
            FunctionTab = 1;
            DownloadPage();
            DownloadBTN.Visible = false;
            BrowseBTN.Text = "Delete";
            LocationTextbox.ReadOnly = true;
        }

        public void DownloadPage()
        {
            string[] Downloads = Directory.GetDirectories(ExtractLocation);
            ItemView.Items.Clear();
            foreach (string item in Downloads)
            {
                ItemView.Items.Add($"\n{item.Replace($"{ExtractLocation}\\", "")}");
            }
        }


        private void ViewChangelog(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            InstalledPage.BackColor = ButtonTheme;
            InstallPage.BackColor = PageSelection;

            InstallPage.ForeColor = Color.White;
            InstalledPage.ForeColor = PageSelectionText;
            FunctionTab = 0;
            ItemView.Items.Clear();
            LoadContent();
            DownloadBTN.Visible = true;
            BrowseBTN.Text = "Browse";
            LocationTextbox.ReadOnly = false;

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void changelog_Click(object sender, EventArgs e)
        {
            ConsoleText.Text = "";
            foreach(string Change in Constants.ChangeLog)
            {
                ConsoleText.Text += Change + Environment.NewLine;
            }
        }
    }
}
