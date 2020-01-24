using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using ScrapySharp.Network;
using HtmlAgilityPack;
using ScrapySharp.Extensions;

namespace TMF_Simplifier
{
    public partial class ForumsView : Form
    {
        public ChromiumWebBrowser chromeBrowser;
            CefSettings settings = new CefSettings();

        string doc;

        private static ScrapingBrowser scrapingBrowser = new ScrapingBrowser();

        public ForumsView()
        {
            InitializeComponent();
            InitializeChromium();
        }

        public void InitializeChromium()
        {
            doc = string.Format(@"{0}\html-resources\html\index.html", Application.StartupPath);
            // Initialize cef with the provided settings
            Cef.Initialize(settings);

            // Create a browser component
            chromeBrowser = new ChromiumWebBrowser(doc);
            // Add it to the form and fill it to the form window.

            this.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;


            // Allow the use of local resources in the browser
            BrowserSettings browserSettings = new BrowserSettings();
            browserSettings.FileAccessFromFileUrls = CefState.Enabled;
            browserSettings.UniversalAccessFromFileUrls = CefState.Enabled;
            chromeBrowser.BrowserSettings = browserSettings;

        }

        public void OpenForum(string page)
        { 
            GetDesc(page);
        }

        private void ForumsView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
            Console.WriteLine("forum view closed");
            Dispose();
        }

        public async void GetDesc(string page)
        {
            try
            {
                scrapingBrowser.AllowAutoRedirect = true;
                scrapingBrowser.AllowMetaRedirect = true;
                WebPage PageResult = await scrapingBrowser.NavigateToPageAsync(new Uri(page.Replace("sa=downfile", "sa=view")));
                HtmlNode titleNode = PageResult.Html.CssSelect(".catbg").ToArray()[1];
                HtmlNode descNode = PageResult.Html.CssSelect(".windowbg2").ToArray()[3];
                Console.WriteLine(descNode.InnerHtml);

                // building html

                string html = "<!DOCTYPE html><html><head><link rel=\"stylesheet\" type=\"text/css\" href=\"style.css\"></head><body>";
                html += $"<h1>{titleNode.InnerHtml}</h1></br>{descNode.InnerHtml}</body></html>";

                File.WriteAllText(doc, html);
                this.Show();
                chromeBrowser.Refresh();
            }
            catch (Exception e)
            {
                MessageBox.Show("Can't get desc");
                Console.WriteLine(e);
            }
        }
    }
}
