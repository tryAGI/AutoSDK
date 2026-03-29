//HintName: G.Models.CrawlUrlsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CrawlUrlsRequest
    {
        /// <summary>
        /// The base URL to start crawling from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// URL pathname regex patterns that exclude matching URLs from the crawl. For example, if you set "excludePaths": ["blog/.*"] for the base URL firecrawl.dev, any results matching that pattern will be excluded, such as https://www.firecrawl.dev/blog/firecrawl-launch-week-1-recap.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excludePaths")]
        public global::System.Collections.Generic.IList<string>? ExcludePaths { get; set; }

        /// <summary>
        /// URL pathname regex patterns that include matching URLs in the crawl. Only the paths that match the specified patterns will be included in the response. For example, if you set "includePaths": ["blog/.*"] for the base URL firecrawl.dev, only results matching that pattern will be included, such as https://www.firecrawl.dev/blog/firecrawl-launch-week-1-recap.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includePaths")]
        public global::System.Collections.Generic.IList<string>? IncludePaths { get; set; }

        /// <summary>
        /// Maximum depth to crawl relative to the base URL. Basically, the max number of slashes the pathname of a scraped URL may contain.<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxDepth")]
        public int? MaxDepth { get; set; }

        /// <summary>
        /// Maximum depth to crawl based on discovery order. The root site and sitemapped pages has a discovery depth of 0. For example, if you set it to 1, and you set ignoreSitemap, you will only crawl the entered URL and all URLs that are linked on that page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxDiscoveryDepth")]
        public int? MaxDiscoveryDepth { get; set; }

        /// <summary>
        /// Ignore the website sitemap when crawling<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignoreSitemap")]
        public bool? IgnoreSitemap { get; set; }

        /// <summary>
        /// Do not re-scrape the same path with different (or none) query parameters<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignoreQueryParameters")]
        public bool? IgnoreQueryParameters { get; set; }

        /// <summary>
        /// Maximum number of pages to crawl. Default limit is 10000.<br/>
        /// Default Value: 10000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Allows the crawler to follow internal links to sibling or parent URLs, not just child paths.<br/>
        /// false: Only crawls deeper (child) URLs.<br/>
        /// → e.g. /features/feature-1 → /features/feature-1/tips ✅<br/>
        /// → Won't follow /pricing or / ❌<br/>
        /// true: Crawls any internal links, including siblings and parents.<br/>
        /// → e.g. /features/feature-1 → /pricing, /, etc. ✅<br/>
        /// Use true for broader internal coverage beyond nested paths.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowBackwardLinks")]
        public bool? AllowBackwardLinks { get; set; }

        /// <summary>
        /// Allows the crawler to follow links to external websites.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowExternalLinks")]
        public bool? AllowExternalLinks { get; set; }

        /// <summary>
        /// Delay in seconds between scrapes. This helps respect website rate limits.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delay")]
        public double? Delay { get; set; }

        /// <summary>
        /// A webhook specification object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        public global::G.CrawlUrlsRequestWebhook? Webhook { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scrapeOptions")]
        public global::G.ScrapeOptions? ScrapeOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CrawlUrlsRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CrawlUrlsRequest(
            string url,
            global::System.Collections.Generic.IList<string>? excludePaths,
            global::System.Collections.Generic.IList<string>? includePaths,
            int? maxDepth,
            int? maxDiscoveryDepth,
            bool? ignoreSitemap,
            bool? ignoreQueryParameters,
            int? limit,
            bool? allowBackwardLinks,
            bool? allowExternalLinks,
            double? delay,
            global::G.CrawlUrlsRequestWebhook? webhook,
            global::G.ScrapeOptions? scrapeOptions)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ExcludePaths = excludePaths;
            this.IncludePaths = includePaths;
            this.MaxDepth = maxDepth;
            this.MaxDiscoveryDepth = maxDiscoveryDepth;
            this.IgnoreSitemap = ignoreSitemap;
            this.IgnoreQueryParameters = ignoreQueryParameters;
            this.Limit = limit;
            this.AllowBackwardLinks = allowBackwardLinks;
            this.AllowExternalLinks = allowExternalLinks;
            this.Delay = delay;
            this.Webhook = webhook;
            this.ScrapeOptions = scrapeOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CrawlUrlsRequest" /> class.
        /// </summary>
        public CrawlUrlsRequest()
        {
        }
    }
}