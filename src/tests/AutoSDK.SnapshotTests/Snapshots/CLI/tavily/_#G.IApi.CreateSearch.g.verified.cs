//HintName: G.IApi.CreateSearch.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Search for data based on a query<br/>
        /// Execute a search query using Tavily Search.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        /// <remarks>
        /// from tavily import TavilyClient<br/>
        /// tavily_client = TavilyClient(api_key="tvly-YOUR_API_KEY")<br/>
        /// response = tavily_client.search("Who is Leo Messi?")<br/>
        /// print(response)
        /// </remarks>
        global::System.Threading.Tasks.Task<global::G.CreateSearchResponse> CreateSearchAsync(

            global::G.CreateSearchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search for data based on a query<br/>
        /// Execute a search query using Tavily Search.
        /// </summary>
        /// <param name="query">
        /// The search query to execute with Tavily.<br/>
        /// Example: who is Leo Messi?
        /// </param>
        /// <param name="searchDepth">
        /// Controls the latency vs. relevance tradeoff and how `results[].content` is generated:<br/>
        /// - `advanced`: Highest relevance with increased latency. Best for detailed, high-precision queries. Returns multiple semantically relevant snippets per URL (configurable via `chunks_per_source`).<br/>
        /// - `basic`: A balanced option for relevance and latency. Ideal for general-purpose searches. Returns one NLP summary per URL.<br/>
        /// - `fast`: Prioritizes lower latency while maintaining good relevance. Returns multiple semantically relevant snippets per URL (configurable via `chunks_per_source`).<br/>
        /// - `ultra-fast`: Minimizes latency above all else. Best for time-critical use cases. Returns one NLP summary per URL.<br/>
        /// **Cost**:<br/>
        /// - `basic`, `fast`, `ultra-fast`: 1 API Credit<br/>
        /// - `advanced`: 2 API Credits<br/>
        /// See [Search Best Practices](/documentation/best-practices/best-practices-search#search-depth) for guidance on choosing the right search depth.<br/>
        /// Default Value: basic
        /// </param>
        /// <param name="chunksPerSource">
        /// Chunks are short content snippets (maximum 500 characters each) pulled directly from the source. Use `chunks_per_source` to define the maximum number of relevant chunks returned per source and to control the `content` length. Chunks will appear in the `content` field as: `&lt;chunk 1&gt; [...] &lt;chunk 2&gt; [...] &lt;chunk 3&gt;`. Available only when `search_depth` is `advanced`.<br/>
        /// Default Value: 3
        /// </param>
        /// <param name="maxResults">
        /// The maximum number of search results to return.<br/>
        /// Default Value: 5<br/>
        /// Example: 1
        /// </param>
        /// <param name="topic">
        /// The category of the search.`news` is useful for retrieving real-time updates, particularly about politics, sports, and major current events covered by mainstream media sources. `general` is for broader, more general-purpose searches that may include a wide range of sources.<br/>
        /// Default Value: general
        /// </param>
        /// <param name="timeRange">
        /// The time range back from the current date to filter results based on publish date or last updated date. Useful when looking for sources that have published or updated data.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="startDate">
        /// Will return all results after the specified start date based on publish date or last updated date. Required to be written in the format YYYY-MM-DD<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464<br/>
        /// Example: 2025-02-09
        /// </param>
        /// <param name="endDate">
        /// Will return all results before the specified end date based on publish date or last updated date. Required to be written in the format YYYY-MM-DD<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464<br/>
        /// Example: 2025-12-29
        /// </param>
        /// <param name="includeAnswer">
        /// Include an LLM-generated answer to the provided query. `basic` or `true` returns a quick answer. `advanced` returns a more detailed answer.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeRawContent">
        /// Include the cleaned and parsed HTML content of each search result. `markdown` or `true` returns search result content in markdown format. `text` returns the plain text from the results and may increase latency.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeImages">
        /// Include images in the response. Returns both a top-level `images` list of query-related images and an `images` array inside each result object with images extracted from that specific source.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeImageDescriptions">
        /// When `include_images` is `true`, also add a descriptive text for each image.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeFavicon">
        /// Whether to include the favicon URL for each result.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeDomains">
        /// A list of domains to specifically include in the search results. Maximum 300 domains.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="excludeDomains">
        /// A list of domains to specifically exclude from the search results. Maximum 150 domains.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="country">
        /// Boost search results from a specific country. This will prioritize content from the selected country in the search results. Available only if topic is `general`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="autoParameters">
        /// When `auto_parameters` is enabled, Tavily automatically configures search parameters based on your query's content and intent. You can still set other parameters manually, and your explicit values will override the automatic ones. The parameters `include_answer`, `include_raw_content`, and `max_results` must always be set manually, as they directly affect response size. Note: `search_depth` may be automatically set to advanced when it's likely to improve results. This uses 2 API credits per request. To avoid the extra cost, you can explicitly set `search_depth` to `basic`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="exactMatch">
        /// Ensure that only search results containing the exact quoted phrase(s) in the query are returned, bypassing synonyms or semantic variations. Wrap target phrases in quotes within your query (e.g. `"John Smith" CEO Acme Corp`). Punctuation is typically ignored inside quotes.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeUsage">
        /// Whether to include credit usage information in the response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="safeSearch">
        /// 🔒 Enterprise only. <br/>
        ///  whether to filter out adult or unsafe content from results. Not supported for `fast` or `ultra-fast` search depths.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateSearchResponse> CreateSearchAsync(
            string query,
            global::G.CreateSearchRequestSearchDepth? searchDepth = default,
            int? chunksPerSource = default,
            int? maxResults = default,
            global::G.CreateSearchRequestTopic? topic = default,
            global::G.CreateSearchRequestTimeRange? timeRange = default,
            string? startDate = default,
            string? endDate = default,
            global::G.OneOf<bool?, global::G.CreateSearchRequestIncludeAnswer?>? includeAnswer = default,
            global::G.OneOf<bool?, global::G.CreateSearchRequestIncludeRawContent?>? includeRawContent = default,
            bool? includeImages = default,
            bool? includeImageDescriptions = default,
            bool? includeFavicon = default,
            global::System.Collections.Generic.IList<string>? includeDomains = default,
            global::System.Collections.Generic.IList<string>? excludeDomains = default,
            global::G.CreateSearchRequestCountry? country = default,
            bool? autoParameters = default,
            bool? exactMatch = default,
            bool? includeUsage = default,
            bool? safeSearch = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}