//HintName: G.IMappingClient.MapUrls.g.cs
#nullable enable

namespace G
{
    public partial interface IMappingClient
    {
        /// <summary>
        /// Map multiple URLs based on options
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MapResponse> MapUrlsAsync(

            global::G.MapUrlsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Map multiple URLs based on options
        /// </summary>
        /// <param name="url">
        /// The base URL to start crawling from
        /// </param>
        /// <param name="search">
        /// Search query to use for mapping. During the Alpha phase, the 'smart' part of the search functionality is limited to 1000 search results. However, if map finds more results, there is no limit applied.
        /// </param>
        /// <param name="ignoreSitemap">
        /// Ignore the website sitemap when crawling.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="sitemapOnly">
        /// Only return links found in the website sitemap<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeSubdomains">
        /// Include subdomains of the website<br/>
        /// Default Value: true
        /// </param>
        /// <param name="limit">
        /// Maximum number of links to return<br/>
        /// Default Value: 5000
        /// </param>
        /// <param name="timeout">
        /// Timeout in milliseconds. There is no timeout by default.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MapResponse> MapUrlsAsync(
            string url,
            string? search = default,
            bool? ignoreSitemap = default,
            bool? sitemapOnly = default,
            bool? includeSubdomains = default,
            int? limit = default,
            int? timeout = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}