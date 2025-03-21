//HintName: G.Models.CompletionUsagePromptTokensDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Breakdown of tokens used in the prompt.
    /// </summary>
    public sealed partial class CompletionUsagePromptTokensDetails
    {
        /// <summary>
        /// Audio input tokens present in the prompt.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_tokens")]
        public int? AudioTokens { get; set; }

        /// <summary>
        /// Cached tokens present in the prompt.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_tokens")]
        public int? CachedTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionUsagePromptTokensDetails" /> class.
        /// </summary>
        /// <param name="audioTokens">
        /// Audio input tokens present in the prompt.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="cachedTokens">
        /// Cached tokens present in the prompt.<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompletionUsagePromptTokensDetails(
            int? audioTokens,
            int? cachedTokens)
        {
            this.AudioTokens = audioTokens;
            this.CachedTokens = cachedTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionUsagePromptTokensDetails" /> class.
        /// </summary>
        public CompletionUsagePromptTokensDetails()
        {
        }
    }
}