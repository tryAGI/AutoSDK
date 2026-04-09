//HintName: G.IPronunciationDictsClient.PronunciationDictsCreate.g.cs
#nullable enable

namespace G
{
    public partial interface IPronunciationDictsClient
    {
        /// <summary>
        /// Create a new pronunciation dictionary
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PronunciationDict> PronunciationDictsCreateAsync(
            global::G.PronunciationDictsCreateCartesiaVersion cartesiaVersion,

            global::G.CreatePronunciationDictRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new pronunciation dictionary
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="name">
        /// Name for the new pronunciation dictionary
        /// </param>
        /// <param name="items">
        /// Optional initial list of pronunciation mappings
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PronunciationDict> PronunciationDictsCreateAsync(
            global::G.PronunciationDictsCreateCartesiaVersion cartesiaVersion,
            string name,
            global::System.Collections.Generic.IList<global::G.PronunciationDictItem>? items = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}