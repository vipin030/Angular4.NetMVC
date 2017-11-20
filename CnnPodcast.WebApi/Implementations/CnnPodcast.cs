using System.Linq;
using System.Xml.Linq;
using CnnPodcast.WebApi.Interfaces;
using CnnPodcast.WebApi.Models;

namespace CnnPodcast.WebApi.Implementations
{
    public class CnnPodcast : ICnnPodcast
    {
        public CnnPodcastModel GetCnnPodcastModel(string rssFeed)
        {
            // uri to a particular feed
            var rssUri = $"http://rss.cnn.com/rss/{rssFeed}.rss";

            // load xml from site
            XDocument doc = XDocument.Load(rssUri);
            // set the right namepace for getting attributes
            XNamespace ns = XNamespace.Get("http://search.yahoo.com/mrss/");
            System.Console.Write(doc.Element("rss")?.Element("channel")?.Elements("item"));
            return new CnnPodcastModel
            {
                // title of the podcast
                PodcastTitle = doc.Element("rss")?.Element("channel")?.Element("title")?.Value,
                // description of the podcast
                PodcastDescription = doc.Element("rss")?.Element("channel")?.Element("description")?.Value,
                // image of the podcast
                PodcastImage = doc.Element("rss")?.Element("channel")?.Element(ns+"image")?.Value,
                
                // list containing all the items belonging to the podcast
                CnnPodcastClipItemModels = doc.Element("rss")?.Element("channel")?.Elements("item").Select(el => new CnnPodcastClipItemModel
                {
                    ClipTitle = el.Element("title")?.Value,
                    ClipDate = el.Element("pubDate")?.Value,
                    ClipDescription = el.Element("description")?.Value,
                    ClipGuid = el.Element("guid")?.Value,
                    ClipLink = el.Element("link")?.Value,
                    ClipMedia = el.Element("media")?.Value
                }).ToList()                
            };
        }
    }
}