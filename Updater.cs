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
            string exe_location = Assembly.GetExecutingAssembly().Location;
            string exe_bak_location = exe_location + ".bak";
            string extract_location = Path.GetDirectoryName(exe_location);
            string download_location = Path.Combine(extract_location, "download.zip");
            await _client.DownloadFileTaskAsync(download_uri, download_location);
            if(File.Exists(exe_bak_location))
            {
                File.Delete(exe_bak_location);
            }
            File.Move(exe_location, exe_bak_location);
            File.Copy(exe_bak_location, exe_location);
            using (var tmp = new SevenZipExtractor(download_location))
            {
                tmp.ExtractArchive(extract_location);
            }
            File.Delete(download_location);
        }
    }
}
