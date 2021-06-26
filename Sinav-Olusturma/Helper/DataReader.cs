using Sinav_Olusturma.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Sinav_Olusturma.Helper
{
    public class DataReader
    {
        private static string URL = "https://www.wired.com";
        public static List<Story> GetData()
        {
            var temp = new List<Story>();
            WebClient wc = new WebClient();
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            wc.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; WOW64; Trident/7.0; rv:11.0) like Gecko");
            var data = wc.DownloadString(URL);
            doc.LoadHtml(data);
            var searching = doc.DocumentNode.SelectNodes("//li[@class='post-listing-list-item__post']");


            for (int i = 0; i < 5; i++)
            {
                var title = searching[i].SelectSingleNode("//li[" + (i + 1) + "]/a/div/h5").InnerText;
                var link = searching[i].SelectSingleNode("//li[" + (i + 1) + "]/a[@class='post-listing-list-item__link']").Attributes["href"].Value;
                temp.Add(new Story
                {
                    Title = title,
                    Link = link
                });
               
               
            }
            return temp;
        }
    }
}
