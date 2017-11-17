using System;
using System.Collections.Generic;
using System.Globalization;
using CnnPodcast.WebApi.Models;
using NUnit.Framework;

namespace CnnPodcast.Tests.ApiTests
{
    [TestFixture]
    public class CnnPodcastApiControllerTests
    {
        //mock of models
        //calls to the api controller
        //test of responses

        [Test]
        public void GetDataFromCnnPodcastController()

        {
            var model = new CnnPodcastModel
            {
                PodcastTitle = "CNN Podcast title",
                PodcastDescription = "CNN Podcast Description",
                CnnPodcastClipItemModels = new List<CnnPodcastClipItemModel>
                {
                    new CnnPodcastClipItemModel
                    {
                        ClipTitle = "RSS 1 title",
                        ClipDescription = "RSS 1 description",
                        ClipDate = DateTime.Now.AddHours(-1).ToString(CultureInfo.InvariantCulture),
                    },
                    new CnnPodcastClipItemModel
                    {
                        ClipTitle = "RSS 2 title",
                        ClipDescription = "RSS 2 description",
                        ClipDate = DateTime.Now.AddHours(-2).ToString(CultureInfo.InvariantCulture),
                    },
                    new CnnPodcastClipItemModel
                    {
                        ClipTitle = "RSS 3 title",
                        ClipDescription = "RSS 3 description",
                        ClipDate = DateTime.Now.AddHours(-3).ToString(CultureInfo.InvariantCulture),
                    }
                }
            };
            Console.WriteLine("Test Started...");
            Assert.IsNotNull(model.PodcastDescription);
            Assert.AreEqual("CNN Podcast title", model.PodcastTitle);
            Assert.AreEqual(3, model.CnnPodcastClipItemModels.Count);
            Assert.AreEqual("CNN Podcast Description", model.PodcastDescription);
            Console.WriteLine("Test Finished...");
        }
    }
}
