//HintName: G.Models.ChatUsagePromptTokensDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Detailed prompt token usage
    /// </summary>
    public sealed partial class ChatUsagePromptTokensDetails
    {
        /// <summary>
        /// Cached prompt tokens
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cached_tokens")]
        public double? CachedTokens { get; set; }

        /// <summary>
        /// Tokens written to cache. Only returned for models with explicit caching and cache write pricing.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cache_write_tokens")]
        public double? CacheWriteTokens { get; set; }

        /// <summary>
        /// Audio input tokens
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_tokens")]
        public double? AudioTokens { get; set; }

        /// <summary>
        /// Video input tokens
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_tokens")]
        public double? VideoTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatUsagePromptTokensDetails" /> class.
        /// </summary>
        /// <param name="cachedTokens">
        /// Cached prompt tokens
        /// </param>
        /// <param name="cacheWriteTokens">
        /// Tokens written to cache. Only returned for models with explicit caching and cache write pricing.
        /// </param>
        /// <param name="audioTokens">
        /// Audio input tokens
        /// </param>
        /// <param name="videoTokens">
        /// Video input tokens
        /// </param>
        public ChatUsagePromptTokensDetails(
            double? cachedTokens,
            double? cacheWriteTokens,
            double? audioTokens,
            double? videoTokens)
        {
            this.CachedTokens = cachedTokens;
            this.CacheWriteTokens = cacheWriteTokens;
            this.AudioTokens = audioTokens;
            this.VideoTokens = videoTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatUsagePromptTokensDetails" /> class.
        /// </summary>
        public ChatUsagePromptTokensDetails()
        {
        }
    }
}