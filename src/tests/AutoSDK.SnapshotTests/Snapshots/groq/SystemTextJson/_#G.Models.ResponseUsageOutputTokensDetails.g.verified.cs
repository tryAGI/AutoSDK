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
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CachedTokens { get; set; }

        /// <summary>
        /// Number of reasoning tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReasoningTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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