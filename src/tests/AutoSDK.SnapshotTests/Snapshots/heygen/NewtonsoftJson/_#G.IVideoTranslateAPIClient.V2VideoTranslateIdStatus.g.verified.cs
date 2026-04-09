//HintName: G.IVideoTranslateApiClient.V2VideoTranslateIdStatus.g.cs
#nullable enable

namespace G
{
    public partial interface IVideoTranslateApiClient
    {
        /// <summary>
        /// v2/video_translate/&lt;id&gt; (status)<br/>
        /// v2/video_translate/&lt;id&gt; (status)
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task V2VideoTranslateIdStatusAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}