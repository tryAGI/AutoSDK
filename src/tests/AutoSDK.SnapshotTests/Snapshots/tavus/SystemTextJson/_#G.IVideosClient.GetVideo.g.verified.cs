//HintName: G.IVideosClient.GetVideo.g.cs
#nullable enable

namespace G
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Get Video<br/>
        /// Returns a single video. If ready, includes download_url, stream_url, and hosted_url.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Video> GetVideoAsync(
            string videoId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}