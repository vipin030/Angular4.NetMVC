export interface Rss{
    id: Number;
    cnnPodcast:{
        id: Number;
        PodcastTitle: string;
        PodcastDescription: string;
        PodcastImage: string;
        cnnPodcastClipItemModels?: {
            id: Number;
            ClipTitle: string;
            ClipDate: string;
            ClipDescription: string;
            ClipGuid: string;
            ClipLink: string;
            ClipMedia: string
        }
    }

}