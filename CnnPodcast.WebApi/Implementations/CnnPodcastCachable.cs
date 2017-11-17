using CnnPodcast.WebApi.Cache;
using CnnPodcast.WebApi.Interfaces;
using CnnPodcast.WebApi.Models;

namespace CnnPodcast.WebApi.Implementations
{
    /// <summary>
    /// Acting as a cachable repository for CnnPodcast.
    /// </summary>
    public class CnnPodcastCachable : ICnnPodcast
    {
        /// <summary>
        /// CnnPodcast variable.
        /// </summary>
        private readonly CnnPodcast _cnnPodcast;

        /// <summary>
        /// Initializes a new instance of <see cref="CnnPodcastCachable"/> class.
        /// </summary>
        public CnnPodcastCachable()
        {
            _cnnPodcast = new CnnPodcast();
        }
        
        /// <summary>
        /// Returns a RSS feed based on a string.
        /// </summary>
        /// <param name="rssFeed">The RSS feed.</param>
        public CnnPodcastModel GetCnnPodcastModel(string rssFeed)
        {

            var type = typeof(CnnPodcastCachable);
            var method = type.GetMethod("CnnPodcastCachable");
            var genericMethod = method.MakeGenericMethod(typeof(object));
            return CacheHelper<CnnPodcastModel>.Get(rssFeed, () => _cnnPodcast.GetCnnPodcastModel(rssFeed));
        }
    }
}
