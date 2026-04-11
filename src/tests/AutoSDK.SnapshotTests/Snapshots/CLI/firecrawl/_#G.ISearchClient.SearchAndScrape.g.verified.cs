//HintName: G.ISearchClient.SearchAndScrape.g.cs
#nullable enable

namespace G
{
    public partial interface ISearchClient
    {
        /// <summary>
        /// Search and optionally scrape search results
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SearchAndScrapeResponse> SearchAndScrapeAsync(

            global::G.SearchAndScrapeRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search and optionally scrape search results
        /// </summary>
        /// <param name="query">
        /// The search query
        /// </param>
        /// <param name="limit">
        /// Maximum number of results to return<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="tbs">
        /// Time-based search parameter
        /// </param>
        /// <param name="location">
        /// Location parameter for search results
        /// </param>
        /// <param name="timeout">
        /// Timeout in milliseconds<br/>
        /// Default Value: 60000
        /// </param>
        /// <param name="ignoreInvalidURLs">
        /// Excludes URLs from the search results that are invalid for other Firecrawl endpoints. This helps reduce errors if you are piping data from search into other Firecrawl API endpoints.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="scrapeOptions">
        /// Options for scraping search results<br/>
        /// Default Value: {}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SearchAndScrapeResponse> SearchAndScrapeAsync(
            string query,
            int? limit = default,
            string? tbs = default,
            string? location = default,
            int? timeout = default,
            bool? ignoreInvalidURLs = default,
            global::G.SearchAndScrapeRequestScrapeOptions? scrapeOptions = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}