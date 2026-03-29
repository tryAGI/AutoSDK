//HintName: G.IVideosClient.GetByVideoIdThumbnailJpg.g.cs
#nullable enable

namespace G
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Retrieve a thumbnail<br/>
        /// Use this endpoint to pull information on a given video thumbnail.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task GetByVideoIdThumbnailJpgAsync(
            string videoId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}