//HintName: G.IVideosClient.GetVideos.g.cs
#nullable enable

namespace G
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// List videos<br/>
        /// You can use the List videos endpoint to get an overview of all videos created via the API or STUDIO.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="source">
        /// Default Value: [workspace, shared_with_me, my_videos]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.VideoListResponse> GetVideosAsync(
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<global::G.GetVideosSourceItem>? source = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}