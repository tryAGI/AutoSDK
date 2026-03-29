//HintName: G.Models.GetActiveCrawlsResponseCrawlOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The crawler options used for this crawl
    /// </summary>
    public sealed partial class GetActiveCrawlsResponseCrawlOptions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scrapeOptions")]
        public global::G.ScrapeOptions? ScrapeOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetActiveCrawlsResponseCrawlOptions" /> class.
        /// </summary>
        /// <param name="scrapeOptions"></param>
        public GetActiveCrawlsResponseCrawlOptions(
            global::G.ScrapeOptions? scrapeOptions)
        {
            this.ScrapeOptions = scrapeOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetActiveCrawlsResponseCrawlOptions" /> class.
        /// </summary>
        public GetActiveCrawlsResponseCrawlOptions()
        {
        }
    }
}