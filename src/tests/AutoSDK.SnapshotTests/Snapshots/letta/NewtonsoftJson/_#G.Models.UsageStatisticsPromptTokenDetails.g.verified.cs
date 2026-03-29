//HintName: G.Models.UsageStatisticsPromptTokenDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsageStatisticsPromptTokenDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cached_tokens")]
        public int? CachedTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache_read_tokens")]
        public int? CacheReadTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache_creation_tokens")]
        public int? CacheCreationTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageStatisticsPromptTokenDetails" /> class.
        /// </summary>
        /// <param name="cachedTokens"></param>
        /// <param name="cacheReadTokens"></param>
        /// <param name="cacheCreationTokens"></param>
        public UsageStatisticsPromptTokenDetails(
            int? cachedTokens,
            int? cacheReadTokens,
            int? cacheCreationTokens)
        {
            this.CachedTokens = cachedTokens;
            this.CacheReadTokens = cacheReadTokens;
            this.CacheCreationTokens = cacheCreationTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageStatisticsPromptTokenDetails" /> class.
        /// </summary>
        public UsageStatisticsPromptTokenDetails()
        {
        }
    }
}