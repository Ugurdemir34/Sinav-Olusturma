using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Sinav_Olusturma.Helper
{
    public static class ContentReader
    {
        public static string GetContent(string url)
        {
            var html = new HtmlDocument();
            html.LoadHtml(new WebClient().DownloadString(url));
            var root = html.DocumentNode;
            var p = root.Descendants()
                    .Where(n => n.GetAttributeValue("class", "").Equals("content"))
                    .Single()
                    .Descendants("p")
                    .Single();
                    
            var content = p.InnerText;
            return content;
        }
    }
}
