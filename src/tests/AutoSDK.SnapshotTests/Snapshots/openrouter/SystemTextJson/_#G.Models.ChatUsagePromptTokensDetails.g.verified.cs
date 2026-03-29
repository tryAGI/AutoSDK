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
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_tokens")]
        public double? CachedTokens { get; set; }

        /// <summary>
        /// Tokens written to cache. Only returned for models with explicit caching and cache write pricing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_write_tokens")]
        public double? CacheWriteTokens { get; set; }

        /// <summary>
        /// Audio input tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_tokens")]
        public double? AudioTokens { get; set; }

        /// <summary>
        /// Video input tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_tokens")]
        public double? VideoTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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