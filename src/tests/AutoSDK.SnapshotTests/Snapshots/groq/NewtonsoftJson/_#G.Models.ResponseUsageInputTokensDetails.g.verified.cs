//HintName: G.Models.ResponseUsageInputTokensDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Breakdown of input tokens.
    /// </summary>
    public sealed partial class ResponseUsageInputTokensDetails
    {
        /// <summary>
        /// Number of cached tokens.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cached_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int CachedTokens { get; set; } = default!;

        /// <summary>
        /// Number of reasoning tokens.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning_tokens")]
        public int? ReasoningTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseUsageInputTokensDetails" /> class.
        /// </summary>
        /// <param name="cachedTokens">
        /// Number of cached tokens.
        /// </param>
        /// <param name="reasoningTokens">
        /// Number of reasoning tokens.
        /// </param>
        public ResponseUsageInputTokensDetails(
            int cachedTokens,
            int? reasoningTokens)
        {
            this.CachedTokens = cachedTokens;
            this.ReasoningTokens = reasoningTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseUsageInputTokensDetails" /> class.
        /// </summary>
        public ResponseUsageInputTokensDetails()
        {
        }
    }
}