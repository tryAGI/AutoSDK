//HintName: G.Models.SearchAndScrapeRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SearchAndScrapeRequest
    {
        /// <summary>
        /// The search query
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Maximum number of results to return<br/>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Time-based search parameter
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tbs")]
        public string? Tbs { get; set; }

        /// <summary>
        /// Location parameter for search results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public string? Location { get; set; }

        /// <summary>
        /// Timeout in milliseconds<br/>
        /// Default Value: 60000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public int? Timeout { get; set; }

        /// <summary>
        /// Excludes URLs from the search results that are invalid for other Firecrawl endpoints. This helps reduce errors if you are piping data from search into other Firecrawl API endpoints.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignoreInvalidURLs")]
        public bool? IgnoreInvalidURLs { get; set; }

        /// <summary>
        /// Options for scraping search results<br/>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scrapeOptions")]
        public global::G.SearchAndScrapeRequestScrapeOptions? ScrapeOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAndScrapeRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchAndScrapeRequest(
            string query,
            int? limit,
            string? tbs,
            string? location,
            int? timeout,
            bool? ignoreInvalidURLs,
            global::G.SearchAndScrapeRequestScrapeOptions? scrapeOptions)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Limit = limit;
            this.Tbs = tbs;
            this.Location = location;
            this.Timeout = timeout;
            this.IgnoreInvalidURLs = ignoreInvalidURLs;
            this.ScrapeOptions = scrapeOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchAndScrapeRequest" /> class.
        /// </summary>
        public SearchAndScrapeRequest()
        {
        }
    }
}