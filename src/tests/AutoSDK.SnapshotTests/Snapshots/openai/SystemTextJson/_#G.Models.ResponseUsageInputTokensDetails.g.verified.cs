//HintName: G.Models.ResponseUsageInputTokensDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A detailed breakdown of the input tokens.
    /// </summary>
    public sealed partial class ResponseUsageInputTokensDetails
    {
        /// <summary>
        /// The number of tokens that were retrieved from the cache. <br/>
        /// [More on prompt caching](/docs/guides/prompt-caching).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CachedTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseUsageInputTokensDetails" /> class.
        /// </summary>
        /// <param name="cachedTokens">
        /// The number of tokens that were retrieved from the cache. <br/>
        /// [More on prompt caching](/docs/guides/prompt-caching).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseUsageInputTokensDetails(
            int cachedTokens)
        {
            this.CachedTokens = cachedTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseUsageInputTokensDetails" /> class.
        /// </summary>
        public ResponseUsageInputTokensDetails()
        {
        }
    }
}