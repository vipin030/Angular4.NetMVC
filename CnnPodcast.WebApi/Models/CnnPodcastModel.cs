using System.Collections.Generic;

namespace CnnPodcast.WebApi.Models
{
    public class CnnPodcastModel
    {
        /// <summary>
        /// Podcast title.
        /// </summary>
        public string PodcastTitle { get; set; } = string.Empty;

        /// <summary>
        /// Podcast description.
        /// </summary>
        public string PodcastDescription { get; set; } = string.Empty;

        /// <summary>
        /// Podcast image.
        /// </summary>
        public string PodcastImage { get; set; } = string.Empty;

        /// <summary>
        /// List of RSS items belonging to this particular feed.
        /// </summary>
        public List<CnnPodcastClipItemModel> CnnPodcastClipItemModels { get; set; }
    }
}
