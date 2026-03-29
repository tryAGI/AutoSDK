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
        [global::Newtonsoft.Json.JsonProperty("reasoning_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int ReasoningTokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompletionUsageCompletionTokensDetails" /> class.
        /// </summary>
        /// <param name="reasoningTokens">
        /// Number of tokens used for reasoning (for reasoning models).
        /// </param>
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