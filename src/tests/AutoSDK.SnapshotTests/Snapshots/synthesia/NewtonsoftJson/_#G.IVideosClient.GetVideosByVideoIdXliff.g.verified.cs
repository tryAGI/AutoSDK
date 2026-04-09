//HintName: G.IVideosClient.GetVideosByVideoIdXliff.g.cs
#nullable enable

namespace G
{
    public partial interface IVideosClient
    {
        /// <summary>
        /// Retrieve XLIFF content for a video<br/>
        /// You can use Retrieve XLIFF content endpoint to pull the XLIFF specification for a given video containing all the text content (script, chapters, text elements).
        /// </summary>
        /// <param name="videoId"></param>
        /// <param name="videoVersion"></param>
        /// <param name="xliffVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.VideoXliffResponse> GetVideosByVideoIdXliffAsync(
            global::System.Guid videoId,
            int? videoVersion = default,
            global::G.GetVideosXliffXliffVersion? xliffVersion = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}