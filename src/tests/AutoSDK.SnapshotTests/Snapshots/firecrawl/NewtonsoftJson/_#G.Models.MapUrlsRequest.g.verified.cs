//HintName: G.Models.MapUrlsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MapUrlsRequest
    {
        /// <summary>
        /// The base URL to start crawling from
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Search query to use for mapping. During the Alpha phase, the 'smart' part of the search functionality is limited to 1000 search results. However, if map finds more results, there is no limit applied.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search")]
        public string? Search { get; set; }

        /// <summary>
        /// Ignore the website sitemap when crawling.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ignoreSitemap")]
        public bool? IgnoreSitemap { get; set; }

        /// <summary>
        /// Only return links found in the website sitemap<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sitemapOnly")]
        public bool? SitemapOnly { get; set; }

        /// <summary>
        /// Include subdomains of the website<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("includeSubdomains")]
        public bool? IncludeSubdomains { get; set; }

        /// <summary>
        /// Maximum number of links to return<br/>
        /// Default Value: 5000
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Timeout in milliseconds. There is no timeout by default.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeout")]
        public int? Timeout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MapUrlsRequest" /> class.
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
        public MapUrlsRequest(
            string url,
            string? search,
            bool? ignoreSitemap,
            bool? sitemapOnly,
            bool? includeSubdomains,
            int? limit,
            int? timeout)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Search = search;
            this.IgnoreSitemap = ignoreSitemap;
            this.SitemapOnly = sitemapOnly;
            this.IncludeSubdomains = includeSubdomains;
            this.Limit = limit;
            this.Timeout = timeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MapUrlsRequest" /> class.
        /// </summary>
        public MapUrlsRequest()
        {
        }
    }
}