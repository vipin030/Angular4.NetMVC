using System.Collections.Generic;
using System.Web.Http;
using CnnPodcast.WebApi.Interfaces;

namespace CnnPodcast.WebApi
{
    public class CnnPodcastWebApiController : ApiController
    {
        /// <summary>
        /// Repository variable initialized through DI.
        /// </summary>
        private readonly ICnnPodcast _cnnPodcast;

        /// <summary>
        /// Initializes a new instance of <see cref="CnnPodcastWebApiController"/> class.
        /// </summary>
        /// <param name="cnnPodcast">The <see cref="ICnnPodcast"/> interface which contains underlying implementation.</param>
        public CnnPodcastWebApiController(ICnnPodcast cnnPodcast)
        {
            _cnnPodcast = cnnPodcast;
        }

        /// <summary>
        /// Gets a RSS feed from CNN services.
        /// </summary>
        /// <param name="rssFeed">The RSS feed.</param>
        public IHttpActionResult GetCnnPodcast(string rssFeed)
        {
            var model = _cnnPodcast.GetCnnPodcastModel(rssFeed);
            var dict = new Dictionary<string, object>
            {
                {"CnnPodcast", model}
            };

            return Ok(dict);
        }
    }
}
