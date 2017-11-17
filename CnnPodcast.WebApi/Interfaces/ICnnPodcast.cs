using CnnPodcast.WebApi.Models;

namespace CnnPodcast.WebApi.Interfaces
{
    public interface ICnnPodcast
    {
        CnnPodcastModel GetCnnPodcastModel(string rssFeed);
    }
}
