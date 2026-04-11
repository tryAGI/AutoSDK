//HintName: G.IPronunciationDictsClient.PronunciationDictsGet.g.cs
#nullable enable

namespace G
{
    public partial interface IPronunciationDictsClient
    {
        /// <summary>
        /// Retrieve a specific pronunciation dictionary by ID
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PronunciationDict> PronunciationDictsGetAsync(
            global::G.PronunciationDictsGetCartesiaVersion cartesiaVersion,
            string id,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}