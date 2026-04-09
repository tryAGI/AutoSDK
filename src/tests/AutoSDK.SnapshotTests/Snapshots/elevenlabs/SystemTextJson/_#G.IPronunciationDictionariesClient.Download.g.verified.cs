//HintName: G.IPronunciationDictionariesClient.Download.g.cs
#nullable enable

namespace G
{
    public partial interface IPronunciationDictionariesClient
    {
        /// <summary>
        /// Get A Pls File With A Pronunciation Dictionary Version Rules<br/>
        /// Get a PLS file with a pronunciation dictionary version rules
        /// </summary>
        /// <param name="dictionaryId">
        /// The id of the pronunciation dictionary
        /// </param>
        /// <param name="versionId">
        /// The id of the pronunciation dictionary version
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> DownloadAsync(
            string dictionaryId,
            string versionId,
            string? xiApiKey = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get A Pls File With A Pronunciation Dictionary Version Rules<br/>
        /// Get a PLS file with a pronunciation dictionary version rules
        /// </summary>
        /// <param name="dictionaryId">
        /// The id of the pronunciation dictionary
        /// </param>
        /// <param name="versionId">
        /// The id of the pronunciation dictionary version
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<byte[]>> DownloadAsResponseAsync(
            string dictionaryId,
            string versionId,
            string? xiApiKey = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}