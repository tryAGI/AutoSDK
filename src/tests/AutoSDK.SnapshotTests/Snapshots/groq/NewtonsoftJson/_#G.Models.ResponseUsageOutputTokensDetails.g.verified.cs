//HintName: G.Models.ResponseUsageOutputTokensDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Breakdown of output tokens.
    /// </summary>
    public sealed partial class ResponseUsageOutputTokensDetails
    {
        /// <summary>
        /// Number of cached tokens.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cached_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int CachedTokens { get; set; } = default!;

        /// <summary>
        /// Number of reasoning tokens.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int ReasoningTokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseUsageOutputTokensDetails" /> class.
        /// </summary>
        /// <param name="cachedTokens">
        /// Number of cached tokens.
        /// </param>
        /// <param name="reasoningTokens">
        /// Number of reasoning tokens.
        /// </param>
        public ResponseUsageOutputTokensDetails(
            int cachedTokens,
            int reasoningTokens)
        {
            this.CachedTokens = cachedTokens;
            this.ReasoningTokens = reasoningTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseUsageOutputTokensDetails" /> class.
        /// </summary>
        public ResponseUsageOutputTokensDetails()
        {
        }
    }
}