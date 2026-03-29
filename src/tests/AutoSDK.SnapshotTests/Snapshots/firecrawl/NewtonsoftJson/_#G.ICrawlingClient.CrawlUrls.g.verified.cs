//HintName: G.ICrawlingClient.CrawlUrls.g.cs
#nullable enable

namespace G
{
    public partial interface ICrawlingClient
    {
        /// <summary>
        /// Crawl multiple URLs based on options
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CrawlResponse> CrawlUrlsAsync(

            global::G.CrawlUrlsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Crawl multiple URLs based on options
        /// </summary>
        /// <param name="url">
        /// The base URL to start crawling from
        /// </param>
        /// <param name="excludePaths">
        /// URL pathname regex patterns that exclude matching URLs from the crawl. For example, if you set "excludePaths": ["blog/.*"] for the base URL firecrawl.dev, any results matching that pattern will be excluded, such as https://www.firecrawl.dev/blog/firecrawl-launch-week-1-recap.
        /// </param>
        /// <param name="includePaths">
        /// URL pathname regex patterns that include matching URLs in the crawl. Only the paths that match the specified patterns will be included in the response. For example, if you set "includePaths": ["blog/.*"] for the base URL firecrawl.dev, only results matching that pattern will be included, such as https://www.firecrawl.dev/blog/firecrawl-launch-week-1-recap.
        /// </param>
        /// <param name="maxDepth">
        /// Maximum depth to crawl relative to the base URL. Basically, the max number of slashes the pathname of a scraped URL may contain.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="maxDiscoveryDepth">
        /// Maximum depth to crawl based on discovery order. The root site and sitemapped pages has a discovery depth of 0. For example, if you set it to 1, and you set ignoreSitemap, you will only crawl the entered URL and all URLs that are linked on that page.
        /// </param>
        /// <param name="ignoreSitemap">
        /// Ignore the website sitemap when crawling<br/>
        /// Default Value: false
        /// </param>
        /// <param name="ignoreQueryParameters">
        /// Do not re-scrape the same path with different (or none) query parameters<br/>
        /// Default Value: false
        /// </param>
        /// <param name="limit">
        /// Maximum number of pages to crawl. Default limit is 10000.<br/>
        /// Default Value: 10000
        /// </param>
        /// <param name="allowBackwardLinks">
        /// Allows the crawler to follow internal links to sibling or parent URLs, not just child paths.<br/>
        /// false: Only crawls deeper (child) URLs.<br/>
        /// → e.g. /features/feature-1 → /features/feature-1/tips ✅<br/>
        /// → Won't follow /pricing or / ❌<br/>
        /// true: Crawls any internal links, including siblings and parents.<br/>
        /// → e.g. /features/feature-1 → /pricing, /, etc. ✅<br/>
        /// Use true for broader internal coverage beyond nested paths.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="allowExternalLinks">
        /// Allows the crawler to follow links to external websites.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="delay">
        /// Delay in seconds between scrapes. This helps respect website rate limits.
        /// </param>
        /// <param name="webhook">
        /// A webhook specification object.
        /// </param>
        /// <param name="scrapeOptions"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CrawlResponse> CrawlUrlsAsync(
            string url,
            global::System.Collections.Generic.IList<string>? excludePaths = default,
            global::System.Collections.Generic.IList<string>? includePaths = default,
            int? maxDepth = default,
            int? maxDiscoveryDepth = default,
            bool? ignoreSitemap = default,
            bool? ignoreQueryParameters = default,
            int? limit = default,
            bool? allowBackwardLinks = default,
            bool? allowExternalLinks = default,
            double? delay = default,
            global::G.CrawlUrlsRequestWebhook? webhook = default,
            global::G.ScrapeOptions? scrapeOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}