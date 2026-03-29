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
        [global::Newtonsoft.Json.JsonProperty("query", Required = global::Newtonsoft.Json.Required.Always)]
        public string Query { get; set; } = default!;

        /// <summary>
        /// Maximum number of results to return<br/>
        /// Default Value: 5
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Time-based search parameter
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tbs")]
        public string? Tbs { get; set; }

        /// <summary>
        /// Location parameter for search results
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("location")]
        public string? Location { get; set; }

        /// <summary>
        /// Timeout in milliseconds<br/>
        /// Default Value: 60000
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeout")]
        public int? Timeout { get; set; }

        /// <summary>
        /// Excludes URLs from the search results that are invalid for other Firecrawl endpoints. This helps reduce errors if you are piping data from search into other Firecrawl API endpoints.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ignoreInvalidURLs")]
        public bool? IgnoreInvalidURLs { get; set; }

        /// <summary>
        /// Options for scraping search results<br/>
        /// Default Value: {}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scrapeOptions")]
        public global::G.SearchAndScrapeRequestScrapeOptions? ScrapeOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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