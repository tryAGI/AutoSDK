//HintName: G.IToolsApiClient.CreateToolsWebSearch.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsApiClient
    {
        /// <summary>
        /// Web search<br/>
        /// Search the web for information about a given query and return relevant results with source URLs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// curl --location --request POST https://api.writer.com/v1/tools/web-search \<br/>
        ///  --header "Authorization: Bearer &lt;token&gt;" \<br/>
        ///  --header "Content-Type: application/json" \<br/>
        /// --data-raw '{"query":"How do I get an API key for the Writer API?","include_domains":["dev.writer.com"]}'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.WebSearchResponse> CreateToolsWebSearchAsync(

            global::G.WebSearchRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Web search<br/>
        /// Search the web for information about a given query and return relevant results with source URLs.
        /// </summary>
        /// <param name="query">
        /// The search query.
        /// </param>
        /// <param name="topic">
        /// The search topic category. Use `news` for current events and news articles, or `general` for broader web search.<br/>
        /// Default Value: general
        /// </param>
        /// <param name="searchDepth">
        /// Controls search comprehensiveness:<br/>
        /// - `basic`: Returns fewer but highly relevant results<br/>
        /// - `advanced`: Performs a deeper search with more results<br/>
        /// Default Value: basic
        /// </param>
        /// <param name="chunksPerSource">
        /// Only applies when `search_depth` is `advanced`. Specifies how many text segments to extract from each source. Limited to 3 chunks maximum.
        /// </param>
        /// <param name="maxResults">
        /// Limits the number of search results returned. Cannot exceed 20 sources.
        /// </param>
        /// <param name="timeRange">
        /// Filters results to content published within the specified time range back from the current date. For example, `week` or `w` returns results from the past 7 days.
        /// </param>
        /// <param name="days">
        /// For news topic searches, specifies how many days of news coverage to include.
        /// </param>
        /// <param name="includeRawContent">
        /// Controls how raw content is included in search results:<br/>
        /// - `text`: Returns plain text without formatting markup<br/>
        /// - `markdown`: Returns structured content with markdown formatting (headers, links, bold text)<br/>
        /// - `true`: Same as `markdown`<br/>
        /// - `false`: Raw content is not included (default if unset)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeAnswer">
        /// Whether to include a generated answer to the query in the response. If `false`, only search results are returned.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="includeDomains">
        /// Domains to include in the search. If unset, the search includes all domains.
        /// </param>
        /// <param name="excludeDomains">
        /// Domains to exclude from the search. If unset, the search includes all domains.
        /// </param>
        /// <param name="country">
        /// Localizes search results to a specific country. Only applies to general topic searches.
        /// </param>
        /// <param name="stream">
        /// Enables streaming of search results as they become available.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.WebSearchResponse> CreateToolsWebSearchAsync(
            string? query = default,
            global::G.WebSearchRequestTopic? topic = default,
            global::G.WebSearchRequestSearchDepth? searchDepth = default,
            int? chunksPerSource = default,
            int? maxResults = default,
            global::G.WebSearchRequestTimeRange? timeRange = default,
            int? days = default,
            global::G.OneOf<global::G.WebSearchRequestIncludeRawContent?, bool?>? includeRawContent = default,
            bool? includeAnswer = default,
            global::System.Collections.Generic.IList<string>? includeDomains = default,
            global::System.Collections.Generic.IList<string>? excludeDomains = default,
            global::G.WebSearchRequestCountry? country = default,
            bool? stream = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}