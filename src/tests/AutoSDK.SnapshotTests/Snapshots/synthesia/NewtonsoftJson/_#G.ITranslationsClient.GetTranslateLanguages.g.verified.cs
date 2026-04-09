//HintName: G.ITranslationsClient.GetTranslateLanguages.g.cs
#nullable enable

namespace G
{
    public partial interface ITranslationsClient
    {
        /// <summary>
        /// Get supported languages for translations<br/>
        /// Get a list of supported languages for translations.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.VideoResponse> GetTranslateLanguagesAsync(
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}