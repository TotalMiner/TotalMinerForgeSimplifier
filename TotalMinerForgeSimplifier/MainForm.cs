#region Namespaces
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
using CefSharp;
using StudioForge.TotalMiner.API;
using StudioForge.TotalMiner;
#endregion

namespace TMF_Simplifier
{
    public partial class TMFS : Form
    {
        public static TMFS Instance;

        public enum Categories
        {
            mod = 2,
            map = 3,
            com = 5

        }
        public static Categories Category = Categories.mod;

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

        Label openPage;
        Label openTab;

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


            openPage = InstallPage;
            openTab = ModTab;
            Category = Categories.mod;
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

        private async void TMFS_LoadAsync(object sender, EventArgs e)
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
                Task.Factory.StartNew(() => Scraper.Scrape((int)Category, 1));
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
                string url = "http://totalminerforums.net/index.php?action=downloads;sa=downfile&id=" + Ids[(int)Category][ItemView.SelectedItems[0].Index];
                LocationTextbox.Text = url;
            }
            else if (FunctionTab == 1)
            {
                if (Category == Categories.mod)
                {
                    string ItemSelected = Path.Combine(ExtractLocation, ItemView.SelectedItems[0].SubItems[0].Text.Replace("\n", ""));
                    LocationTextbox.Text = ItemSelected;
                    LocationLabel.Text = "Intalled item:";
                }
                else if (Category == Categories.com)
                {
                    compview comv = new compview();
                    comv.Show();
                    comv.LoadComps($"{ExtractLocation}\\{ItemView.SelectedItems[0].Text.Substring(ItemView.SelectedItems[0].Text.Length - 7).Replace(")", "")}");
                }
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
            Category = Categories.mod;
                ExtractLocation = Path.Combine(TotalMinerMain, "Mods");
            StatusLabel.ForeColor = Color.LightSeaGreen;
            
            Style.LabelButtonUnselected(openTab);
            Style.LabelButtonSelected(ModTab);
            openTab = ModTab;

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

        private void ComTab_Click(object sender, EventArgs e)
        {
            Category = Categories.com;
            ExtractLocation = Path.Combine(TotalMinerMain, "Com");
            StatusLabel.ForeColor = Color.LightSeaGreen;
            
            Style.LabelButtonUnselected(openTab);
            Style.LabelButtonSelected(ComTab);
            openTab = ComTab;

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

                    ItemView.Items.Add($"\n {Globals2.StripBadChars(File.ReadAllText(item + "\\header.dat"))} | ({item.Replace($"{ExtractLocation}\\", "")})");
                }
            }
        }

        private void MapTab_Click(object sender, EventArgs e)
        {
            Category = Categories.map;
            ExtractLocation = Path.Combine(TotalMinerMain, "Maps");
            StatusLabel.ForeColor = Color.LightSeaGreen;

            Style.LabelButtonUnselected(openTab);
            Style.LabelButtonSelected(MapTab);
            openTab = MapTab;

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
                    
                    SaveGameFileInfo saveGame = new SaveGameFileInfo(MapType.Map);
                    try
                    {
                        saveGame.Header = LoadMapHeader(item+"\\header.dat");
                    }
                    catch (Exception err)
                    {
                        saveGame.Header.MapName = "err";
                    }

                    string[] row = { $" {saveGame.Header.MapName} | ({item.Replace($"{ ExtractLocation }\\", "")})", $"{string.Format("{0:N1}", saveGame.Header.RatingStars)}/5 of {saveGame.Header.RatingCount}", "N\\A", "N\\A",(Globals2.DirSize(new DirectoryInfo(item)) / 1000).ToString() + "KB", saveGame.Header.OwnerGamerTag };
                    var listViewItem = new ListViewItem(row);
                    ItemView.Items.Add(listViewItem);
                    
                }
            }
        }
        public static SaveMapHead LoadMapHeader(string filename)
        {
            Console.WriteLine(filename);
            byte[] array = ReadFileIntoBuffer(filename);
            SaveMapHead saveMapHead = LoadMapHeader(array);
            return saveMapHead;
        }

        public static SaveMapHead LoadMapHeader(Stream stream)
        {
            using (BinaryReader reader = new BinaryReader(stream))
            {
                return ReadMapHeader(reader);
            }
        }

        public static SaveMapHead LoadMapHeader(byte[] data)
        {
            using (MemoryStream stream = new MemoryStream(data))
            {
                return LoadMapHeader(stream);
            }
        }

        private static SaveMapHead ReadMapHeader(BinaryReader reader)
        {
            SaveMapHead saveMapHead = new SaveMapHead();
            int num = saveMapHead.SaveVersion = reader.ReadInt32();
            saveMapHead.ExeVersion = reader.ReadInt32();
            if (num > 35)
            {
                saveMapHead.CreatedVersion = reader.ReadInt32();
            }
            saveMapHead.MapName = Globals2.StripBadChars(reader.ReadString());
            saveMapHead.OwnerGamerTag = Globals2.StripBadChars(reader.ReadString());
            saveMapHead.DateCreated = reader.ReadInt64();
            if (num > 134 && num < 211)
            {
                reader.ReadByte();
            }
            if (num > 208)
            {
            }
            else
            {
                saveMapHead.DateSaved = saveMapHead.DateCreated;
                if (num > 39)
                {
                    reader.ReadInt32();
                }
            }
            if (num > 31)
            {
                saveMapHead.IsAutoSave = reader.ReadBoolean();
            }
            if (num > 54)
            {
                if (num > 216)
                {
                }
                else
                {
                }
            }
            else
            {
            }
            saveMapHead.MapSeed = reader.ReadInt32();
            saveMapHead.GameType = reader.ReadInt32();
            saveMapHead.HoursSlept = reader.ReadInt32();
            if (num > 21)
            {
                saveMapHead.RatingCount = reader.ReadInt32() / 144;
            }
            saveMapHead.UnusedInt1 = reader.ReadInt32();
            saveMapHead.DepthReached = reader.ReadInt32();
            if (num > 21)
            {
            }
            if (num > 21)
            {
                saveMapHead.RatingStars = reader.ReadSingle() / 4498.25f;
            }
            if (num > 20)
            {
            }
            if (num > 23)
            {
                saveMapHead.PvPCombat = reader.ReadBoolean();
            }
            else
            {
                saveMapHead.PvPCombat = true;
            }
            if (num > 24)
            {
                saveMapHead.CombatEnabled = reader.ReadBoolean();
            }
            else
            {
            }
            if (num > 24)
            {
                saveMapHead.FiniteMode = reader.ReadBoolean();
            }
            else
            {
            }
            if (num > 118)
            {
                saveMapHead.PassiveMobs = reader.ReadBoolean();
            }
            else
            {
                saveMapHead.PassiveMobs = true;
            }
            if (num > 148)
            {
                saveMapHead.EnemyMobs = reader.ReadBoolean();
            }
            else
            {
            }
            if (num > 128)
            {
                saveMapHead.KeepItemsOnDeath = reader.ReadBoolean();
            }
            else
            {
                saveMapHead.KeepItemsOnDeath = false;
            }
            if (num > 107)
            {
                saveMapHead.SkillsEnabled = reader.ReadBoolean();
            }
            else
            {
                saveMapHead.SkillsEnabled = false;
            }
            if (num > 192)
            {
                saveMapHead.SkillsLocal = reader.ReadBoolean();
            }
            else
            {
                saveMapHead.SkillsLocal = false;
            }
            if (num > 192)
            {
                saveMapHead.XPMultiplier = reader.ReadSingle();
            }
            else
            {
                saveMapHead.XPMultiplier = 1f;
            }
            if (num > 24)
            {
                saveMapHead.DayNightActive = reader.ReadBoolean();
            }
            else
            {
                saveMapHead.DayNightActive = true;
            }
            if (num < 54)
            {
                saveMapHead.DayNightActive = true;
            }
            if (num > 213)
            {
                saveMapHead.WeatherActive = reader.ReadBoolean();
            }
            else
            {
                saveMapHead.WeatherActive = true;
            }
            if (num > 232)
            {
                saveMapHead.WindFactor = reader.ReadSingle();
            }
            else
            {
                saveMapHead.WindFactor = 1f;
            }
            if (num > 75)
            {
                saveMapHead.UnusedByte1 = reader.ReadByte();
            }
            else
            {
                saveMapHead.UnusedByte1 = 0;
            }
            if (num > 76)
            {
                saveMapHead.DaysIntoGame = reader.ReadInt32();
            }
            else
            {
                saveMapHead.DaysIntoGame = 0;
            }
            if (num > 34)
            {
            }
            else
            {
            }
            if (num < 231)
            {
            }
            if (num > 121)
            {
                saveMapHead.MaxPlayers = reader.ReadInt32();
            }
            else
            {
                saveMapHead.MaxPlayers = 16;
            }
            if (num > 121)
            {
                saveMapHead.PrivateSlots = reader.ReadInt32();
            }
            else
            {
                saveMapHead.PrivateSlots = 0;
            }
            if (num > 184)
            {
                saveMapHead.CombatLevelDifference = reader.ReadInt16();
            }
            else
            {
                saveMapHead.CombatLevelDifference = 7;
            }
            if (num > 244)
            {
                saveMapHead.ClanProtection = reader.ReadBoolean();
            }
            else
            {
                saveMapHead.ClanProtection = true;
            }
            if (num > 22)
            {
                saveMapHead.TexturePack = Globals2.StripBadChars(reader.ReadString(), true);
            }
            if (num > 182)
            {
            }
            if (num > 275)
            {
            }
            return saveMapHead;
        }
        private static byte[] ReadFileIntoBuffer(string filename)
        {
            if (FileSystem.IsFileExist(filename))
            {
                using (Stream stream = FileSystem.OpenRead(filename))
                {
                    byte[] array = new byte[stream.Length];
                    stream.Read(array, 0, array.Length);
                    return array;
                }
            }
            return null;
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

            Style.LabelButtonUnselected(openPage);
            Style.LabelButtonSelected(InstalledPage);
            openPage = InstalledPage;

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
            Style.LabelButtonUnselected(openPage);
            Style.LabelButtonSelected(InstallPage);
            openPage = InstallPage;
            
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

        private void ConsoleText_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void TestLabel_Click(object sender, EventArgs e)
        {
            StreamWriter sr = new StreamWriter("output/BlockTextures64.xml");
            sr.Write("<?xml version=\"1.0\"?>\n< ArrayOfItemXML xmlns: xsi = \"http://www.w3.org/2001/XMLSchema-instance\" xmlns: xsd = \"http://www.w3.org/2001/XMLSchema\"> \n");
            foreach (Item blockItem in Enum.GetValues(typeof(Item)))
            {
                if (blockItem == Item.zLastBlockID)
                    break;
               sr.WriteLine($"  <ItemXML>\n     <ItemID>{blockItem}</ItemID>\n  </ItemXML> ");
            }
            sr.WriteLine("</ArrayOfItemXML>");
            sr.Close();
        }
    }
}
