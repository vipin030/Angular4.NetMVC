namespace CnnPodcast.WebApi.Models
{
    public class CnnPodcastClipItemModel
    {
        /// <summary>
        /// Clip title.
        /// </summary>
        public string ClipTitle { get; set; } = string.Empty;

        /// <summary>
        /// Date when clip published.
        /// </summary>
        public string ClipDate { get; set; } = string.Empty;

        /// <summary>
        /// Clip description.
        /// </summary>
        public string ClipDescription { get; set; } = string.Empty;

        /// <summary>
        /// Clip Video.
        /// </summary>
        public string ClipLink { get; set; } = string.Empty;

        /// <summary>
        /// Clip GUID.
        /// </summary>
        public string ClipGuid { get; set; } = string.Empty;

        /// <summary>
        /// Clip media content.
        /// </summary>
        public string ClipMedia { get; set; } = string.Empty;
    }
}
