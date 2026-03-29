//HintName: G.Models.WebsiteCrawlRequestWebsite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebsiteCrawlRequestWebsite
    {
        /// <summary>
        /// the bucketId of the bucket which this website will be ingested to.<br/>
        /// Example: 123
        /// </summary>
        /// <example>123</example>
        [global::Newtonsoft.Json.JsonProperty("bucketId", Required = global::Newtonsoft.Json.Required.Always)]
        public int BucketId { get; set; } = default!;

        /// <summary>
        /// The maximum number of pages to crawl<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::Newtonsoft.Json.JsonProperty("cap")]
        public int? Cap { get; set; }

        /// <summary>
        /// The maximum depth of linked pages to follow from the sourceUrl<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::Newtonsoft.Json.JsonProperty("depth")]
        public int? Depth { get; set; }

        /// <summary>
        /// Custom metadata which can be used to influence GroundX's search functionality. This data can be used to further hone GroundX search.<br/>
        /// Example: {"key":"value"}
        /// </summary>
        /// <example>{"key":"value"}</example>
        [global::Newtonsoft.Json.JsonProperty("searchData")]
        public object? SearchData { get; set; }

        /// <summary>
        /// The URL from which the crawl is initiated.<br/>
        /// Example: https://my.website.com
        /// </summary>
        /// <example>https://my.website.com</example>
        [global::Newtonsoft.Json.JsonProperty("sourceUrl", Required = global::Newtonsoft.Json.Required.Always)]
        public string SourceUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsiteCrawlRequestWebsite" /> class.
        /// </summary>
        /// <param name="bucketId">
        /// the bucketId of the bucket which this website will be ingested to.<br/>
        /// Example: 123
        /// </param>
        /// <param name="sourceUrl">
        /// The URL from which the crawl is initiated.<br/>
        /// Example: https://my.website.com
        /// </param>
        /// <param name="cap">
        /// The maximum number of pages to crawl<br/>
        /// Example: 100
        /// </param>
        /// <param name="depth">
        /// The maximum depth of linked pages to follow from the sourceUrl<br/>
        /// Example: 3
        /// </param>
        /// <param name="searchData">
        /// Custom metadata which can be used to influence GroundX's search functionality. This data can be used to further hone GroundX search.<br/>
        /// Example: {"key":"value"}
        /// </param>
        public WebsiteCrawlRequestWebsite(
            int bucketId,
            string sourceUrl,
            int? cap,
            int? depth,
            object? searchData)
        {
            this.BucketId = bucketId;
            this.Cap = cap;
            this.Depth = depth;
            this.SearchData = searchData;
            this.SourceUrl = sourceUrl ?? throw new global::System.ArgumentNullException(nameof(sourceUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebsiteCrawlRequestWebsite" /> class.
        /// </summary>
        public WebsiteCrawlRequestWebsite()
        {
        }
    }
}