//HintName: G.IVideoTranslateApiClient.V2VideoTranslateTargetLanguages.g.cs
#nullable enable

namespace G
{
    public partial interface IVideoTranslateApiClient
    {
        /// <summary>
        /// v2/video_translate/target_languages<br/>
        /// v2/video_translate/target_languages
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task V2VideoTranslateTargetLanguagesAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}