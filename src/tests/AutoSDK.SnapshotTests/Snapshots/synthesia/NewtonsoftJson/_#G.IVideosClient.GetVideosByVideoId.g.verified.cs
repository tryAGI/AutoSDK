//HintName: G.IVideosClient.GetVideosByVideoId.g.cs
#nullable enable

namespace G
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Retrieve a video<br/>
        /// You can use Retrieve a video endpoint to pull for the video status.
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.VideoResponse> GetVideosByVideoIdAsync(
            string videoId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}