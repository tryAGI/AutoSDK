//HintName: G.IPodcastEpisodesClient.GetPodcastEpisodes.g.cs
#nullable enable

namespace G
{
    public partial interface IPodcastEpisodesClient
    {
        /// <summary>
        /// Podcast Episodes<br/>
        /// This endpoint allows the client to retrieve a list of podcast episodes.<br/>
        ///         "Podcast episodes" are episodes belonging to podcasts.<br/>
        ///         It will only return active (reachable) podcast episodes that belong to published podcasts available on the platform, ordered by descending publication date.<br/>
        ///         It supports pagination, each page will contain 30 articles by default.
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.PodcastEpisodeIndex>> GetPodcastEpisodesAsync(
            int? page = default,
            int? perPage = default,
            string? username = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}