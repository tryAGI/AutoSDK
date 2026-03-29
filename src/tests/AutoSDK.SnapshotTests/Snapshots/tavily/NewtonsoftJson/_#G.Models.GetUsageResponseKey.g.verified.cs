//HintName: G.Models.GetUsageResponseKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetUsageResponseKey
    {
        /// <summary>
        /// Total credits used for this API key during the current billing cycle<br/>
        /// Example: 150
        /// </summary>
        /// <example>150</example>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public int? Usage { get; set; }

        /// <summary>
        /// Usage limit for the API key. Returns null if unlimited<br/>
        /// Example: 1000
        /// </summary>
        /// <example>1000</example>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Search endpoint credits used for this API key during the current billing cycle<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::Newtonsoft.Json.JsonProperty("search_usage")]
        public int? SearchUsage { get; set; }

        /// <summary>
        /// Extract endpoint credits used for this API key during the current billing cycle<br/>
        /// Example: 25
        /// </summary>
        /// <example>25</example>
        [global::Newtonsoft.Json.JsonProperty("extract_usage")]
        public int? ExtractUsage { get; set; }

        /// <summary>
        /// Crawl endpoint credits used for this API key during the current billing cycle<br/>
        /// Example: 15
        /// </summary>
        /// <example>15</example>
        [global::Newtonsoft.Json.JsonProperty("crawl_usage")]
        public int? CrawlUsage { get; set; }

        /// <summary>
        /// Map endpoint credits used for this API key during the current billing cycle<br/>
        /// Example: 7
        /// </summary>
        /// <example>7</example>
        [global::Newtonsoft.Json.JsonProperty("map_usage")]
        public int? MapUsage { get; set; }

        /// <summary>
        /// Research endpoint credits used for this API key during the current billing cycle<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::Newtonsoft.Json.JsonProperty("research_usage")]
        public int? ResearchUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponseKey" /> class.
        /// </summary>
        /// <param name="usage">
        /// Total credits used for this API key during the current billing cycle<br/>
        /// Example: 150
        /// </param>
        /// <param name="limit">
        /// Usage limit for the API key. Returns null if unlimited<br/>
        /// Example: 1000
        /// </param>
        /// <param name="searchUsage">
        /// Search endpoint credits used for this API key during the current billing cycle<br/>
        /// Example: 100
        /// </param>
        /// <param name="extractUsage">
        /// Extract endpoint credits used for this API key during the current billing cycle<br/>
        /// Example: 25
        /// </param>
        /// <param name="crawlUsage">
        /// Crawl endpoint credits used for this API key during the current billing cycle<br/>
        /// Example: 15
        /// </param>
        /// <param name="mapUsage">
        /// Map endpoint credits used for this API key during the current billing cycle<br/>
        /// Example: 7
        /// </param>
        /// <param name="researchUsage">
        /// Research endpoint credits used for this API key during the current billing cycle<br/>
        /// Example: 3
        /// </param>
        public GetUsageResponseKey(
            int? usage,
            int? limit,
            int? searchUsage,
            int? extractUsage,
            int? crawlUsage,
            int? mapUsage,
            int? researchUsage)
        {
            this.Usage = usage;
            this.Limit = limit;
            this.SearchUsage = searchUsage;
            this.ExtractUsage = extractUsage;
            this.CrawlUsage = crawlUsage;
            this.MapUsage = mapUsage;
            this.ResearchUsage = researchUsage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsageResponseKey" /> class.
        /// </summary>
        public GetUsageResponseKey()
        {
        }
    }
}