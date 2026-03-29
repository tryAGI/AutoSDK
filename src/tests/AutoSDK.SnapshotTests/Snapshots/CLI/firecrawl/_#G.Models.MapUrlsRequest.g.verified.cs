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
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Search query to use for mapping. During the Alpha phase, the 'smart' part of the search functionality is limited to 1000 search results. However, if map finds more results, there is no limit applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search")]
        public string? Search { get; set; }

        /// <summary>
        /// Ignore the website sitemap when crawling.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignoreSitemap")]
        public bool? IgnoreSitemap { get; set; }

        /// <summary>
        /// Only return links found in the website sitemap<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sitemapOnly")]
        public bool? SitemapOnly { get; set; }

        /// <summary>
        /// Include subdomains of the website<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("includeSubdomains")]
        public bool? IncludeSubdomains { get; set; }

        /// <summary>
        /// Maximum number of links to return<br/>
        /// Default Value: 5000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Timeout in milliseconds. There is no timeout by default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public int? Timeout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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