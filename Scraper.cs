using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScrapySharp.Network;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using System.Windows.Forms;

namespace TMF_Simplifier
{
    class Scraper
    {
        private static ScrapingBrowser Browser = new ScrapingBrowser();

        public async static void Scrape(int category, int page)
        {
            try
            {
                Browser.AllowAutoRedirect = true;
                Browser.AllowMetaRedirect = true;
                WebPage PageResult = await Browser.NavigateToPageAsync(new Uri("http://totalminerforums.net/index.php?action=downloads;cat="+category/*+";page="+page*/));
                Console.WriteLine("Scraped");
                HtmlNode Table = PageResult.Html.CssSelect(".table_grid").First();
                foreach (var row in Table.SelectNodes("tr").Where(t => !t.Attributes.Contains("class")))
                {
                    List<string> cells = new List<string>();
                    int celli = 0;
                    foreach (var cell in row.SelectNodes("td"))
                    {
                        if (celli < 5 || celli == 7)
                        {
                            if (celli == 1 && cell.InnerText != "(None)")
                            {
                                cells.Add(cell.SelectNodes("img").Count + "/5");
                            }
                            else
                            {
                                cells.Add(cell.InnerText);
                            }

                            if (celli == 0)
                            {
                                string href = cell.SelectSingleNode("a").Attributes["href"].Value;
                                int index = href.IndexOf("down=") + 5;
                                Console.WriteLine(href);
                                Console.WriteLine(index);
                                Console.WriteLine(href.Substring(index));
                                TMFS.Ids[category].Add(int.Parse(href.Substring(index)));
                            }
                        }
                        celli++;
                    }
                    TMFS.Instance.AddRow(new ListViewItem(cells.ToArray()));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Scraping Failed!");
                Console.WriteLine(e);
            }
        }
    }
}
