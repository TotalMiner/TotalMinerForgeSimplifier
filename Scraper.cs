using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScrapySharp.Network;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using System.Windows.Forms;
using System.Web;

namespace TMF_Simplifier
{
    class Scraper
    {
        private static int totalPages = 0;
        private static int itemsScraped = 0;
        private static int pagesScraped = 0;
        private static ScrapingBrowser Browser = new ScrapingBrowser();

        public async static void Scrape(int category, int page)
        {
            try
            {
                Browser.AllowAutoRedirect = true;
                Browser.AllowMetaRedirect = true;
                WebPage PageResult = await Browser.NavigateToPageAsync(new Uri($"http://totalminerforums.net/index.php?action=downloads;cat={category};start={(page-1)*20}"));
                HtmlNode Table = PageResult.Html.CssSelect(".table_grid").First();
                foreach (var row in Table.SelectNodes("tr"))
                {
                    if (!row.Attributes.Contains("class"))
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
                                    cells.Add(HttpUtility.HtmlDecode(cell.InnerText));
                                }

                                if (celli == 0)
                                {
                                    string href = cell.SelectSingleNode("a").Attributes["href"].Value;
                                    int index = href.IndexOf("down=") + 5;
                                    TMFS.Ids[category].Add(int.Parse(href.Substring(index)));
                                }
                            }
                            celli++;
                        }
                        TMFS.Instance.AddRow(new ListViewItem(cells.ToArray()));
                        itemsScraped++;
                    } else if (row.Attributes.Contains("class") && row.Attributes["class"].Value == "titlebg")
                    {
                        var htmlNodes = row.SelectNodes("td");//row.FirstChild.SelectNodes("a").Where(n => n.Attributes["class"].Value == "navPages");
                        
                        foreach(HtmlNode node in htmlNodes)
                        {
                            if(node.SelectNodes("a").Count() > 0)
                            {
                                foreach (HtmlNode aNode in node.SelectNodes("a"))
                                {
                                    if (aNode.Attributes.Contains("class") && aNode.Attributes["class"].Value == "navPages")
                                    {
                                        int maxpage;
                                        if (int.TryParse(aNode.InnerText, out maxpage))
                                        {
                                            if (maxpage > totalPages)
                                            {
                                                totalPages = maxpage;
                                                Console.WriteLine($"New max page: {maxpage}");
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine($"Failed to parse page #{node.InnerText}");
                                        }
                                    }
                                }
                            } 
                        }
                    }
                }
                pagesScraped++;
                Console.WriteLine($"Got page {page}");

                if(pagesScraped < totalPages)
                {
                    Scrape(category, pagesScraped + 1);
                } else
                {
                    Console.WriteLine($"Finished scraping {itemsScraped} items and {pagesScraped} pages");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Scraping Failed!");
                Console.WriteLine(e);
            }
        }
    }
}
