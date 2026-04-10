//HintName: G.IVideosClient.GetByVideoIdThumbnail.g.cs
#nullable enable

namespace G
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Retrieve a GIF/JPG thumbnail<br/>
        /// Use this endpoint to pull information on a given video. It will return a GIF thumbnail if it exists, otherwise a JPG.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task GetByVideoIdThumbnailAsync(
            string videoId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}