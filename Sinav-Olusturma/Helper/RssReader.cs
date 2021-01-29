using Sinav_Olusturma.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ServiceModel.Syndication;
using System.Xml;
using System.Xml.Linq;

namespace Sinav_Olusturma.Helper
{
    public static class RssReader
    {
        public static List<Story> GetStories(string url = "https://www.wired.com/feed/rss", int quantity=5)
        {
            var temp = new List<Story>();
            var reader = XmlReader.Create(url);
            var feed = SyndicationFeed.Load(reader);

            //feed.ElementExtensions.Add(new XElement("enclosure", new XAttribute("type", "image/jpeg"), new XAttribute("url", stories[i].ImageUrl).CreateReader());

            reader.Close();
            var stories = feed.Items.Take(5).ToList();
           
            for (int i = 0; i < stories.Count; i++)
            {
                temp.Add(new Story()
                {
                    Id = stories[i].Id,
                  //  Content = stories[i].Content.ToString(),
                    Title = stories[i].Title.Text,
                    Thumbnail = stories[i].ElementExtensions.Where(p => p.OuterName == "thumbnail").First().GetObject<XElement>().Attribute("url").Value,                  
                    Link =  stories[i].Links.FirstOrDefault().Uri.ToString()
                });
            }
            return temp;
        }
      
    }
}
