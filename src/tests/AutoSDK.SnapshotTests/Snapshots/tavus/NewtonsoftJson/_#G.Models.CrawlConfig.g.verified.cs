//HintName: G.Models.CrawlConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CrawlConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("depth")]
        public int? Depth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_pages")]
        public int? MaxPages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CrawlConfig" /> class.
        /// </summary>
        /// <param name="depth"></param>
        /// <param name="maxPages"></param>
        public CrawlConfig(
            int? depth,
            int? maxPages)
        {
            this.Depth = depth;
            this.MaxPages = maxPages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CrawlConfig" /> class.
        /// </summary>
        public CrawlConfig()
        {
        }
    }
}