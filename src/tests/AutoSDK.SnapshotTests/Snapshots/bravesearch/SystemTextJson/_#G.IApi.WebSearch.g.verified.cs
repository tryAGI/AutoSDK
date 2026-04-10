//HintName: G.IApi.WebSearch.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Web Search<br/>
        /// Search the web using Brave Search. Returns web results, videos, news,<br/>
        /// locations, infoboxes, discussions, FAQs, and related content.
        /// </summary>
        /// <param name="q"></param>
        /// <param name="country">
        /// Default Value: us
        /// </param>
        /// <param name="searchLang">
        /// Default Value: en
        /// </param>
        /// <param name="uiLang">
        /// Default Value: en-US
        /// </param>
        /// <param name="count">
        /// Default Value: 20
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="safesearch">
        /// Default Value: moderate
        /// </param>
        /// <param name="freshness"></param>
        /// <param name="textDecorations">
        /// Default Value: true
        /// </param>
        /// <param name="spellcheck">
        /// Default Value: true
        /// </param>
        /// <param name="resultFilter"></param>
        /// <param name="gogglesId"></param>
        /// <param name="units"></param>
        /// <param name="extraSnippets">
        /// Default Value: false
        /// </param>
        /// <param name="summary">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.WebSearchResponse> WebSearchAsync(
            string q,
            string? country = default,
            string? searchLang = default,
            string? uiLang = default,
            int? count = default,
            int? offset = default,
            global::G.WebSearchSafesearch? safesearch = default,
            string? freshness = default,
            bool? textDecorations = default,
            bool? spellcheck = default,
            string? resultFilter = default,
            string? gogglesId = default,
            global::G.WebSearchUnits? units = default,
            bool? extraSnippets = default,
            bool? summary = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}