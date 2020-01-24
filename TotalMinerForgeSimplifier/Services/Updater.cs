using Newtonsoft.Json;
using SevenZip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TMF_Simplifier.Github;

namespace TMF_Simplifier
{
    public static class Updater
    {
        private static WebClient _client = new WebClient
        {
            Headers = new WebHeaderCollection()
            {
                {"User-Agent", "TMFS"}
            }
        };
        private static Release _latestRelease;

        public static async Task<bool> IsUpToDate()
        {
            Release release = await GetLatestRelease();
            if (release != null)
            {
                return release.tag_name == Constants.Version;
            } else
            {
                return true;
            }
        }

        public static async Task<Release> GetLatestRelease()
        {
            if(_latestRelease == null)
            {
                try
                {
                    string json = await _client.DownloadStringTaskAsync(new Uri(@"https://api.github.com/repos/HaydenSynthetic/TotalMinerForgeSimplifier/releases/latest"));
                    Release release = JsonConvert.DeserializeObject<Release>(json);
                    _latestRelease = release;
                    return release;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return null;
                }
            } else
            {
                return _latestRelease;
            }
        }

        public static async Task Update()
        {
            Release release = await GetLatestRelease();
            Asset asset = release.assets.First();
            Uri download_uri = new Uri(asset.browser_download_url);
            string extract_location = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string download_location = Path.Combine(extract_location, "download.zip");
            await _client.DownloadFileTaskAsync(download_uri, download_location);
            using (var tmp = new SevenZipExtractor(download_location))
            {
                tmp.FileExists += (object sender, FileOverwriteEventArgs e) =>
                {
                    string loc = Path.Combine(extract_location, e.FileName);
                    if (IsInUse(loc))
                    {
                        string bak = loc + ".bak";
                        File.Move(loc, bak);
                        File.Copy(bak, loc);
                    }
                };
                tmp.ExtractArchive(extract_location);
            }
            File.Delete(download_location);
        }

        private static bool IsInUse(string file)
        {
            try
            {
                FileStream fs = File.OpenWrite(file);
                fs.Close();
                return false;
            }
            catch (Exception)
            {
                return true;
            }
        }
    }
}
