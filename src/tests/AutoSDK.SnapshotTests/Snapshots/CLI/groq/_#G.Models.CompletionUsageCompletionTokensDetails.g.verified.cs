//HintName: G.Models.CompletionUsageCompletionTokensDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Breakdown of tokens in the completion.
    /// </summary>
    public sealed partial class CompletionUsageCompletionTokensDetails
    {
        /// <summary>
        /// Number of tokens used for reasoning (for reasoning models).
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
        /// Initializes a new instance of the <see cref="CompletionUsageCompletionTokensDetails" /> class.
        /// </summary>
        /// <param name="reasoningTokens">
        /// Number of tokens used for reasoning (for reasoning models).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompletionUsageCompletionTokensDetails(
            int reasoningTokens)
        {
            this.ReasoningTokens = reasoningTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionUsageCompletionTokensDetails" /> class.
        /// </summary>
        public CompletionUsageCompletionTokensDetails()
        {
        }
    }
}