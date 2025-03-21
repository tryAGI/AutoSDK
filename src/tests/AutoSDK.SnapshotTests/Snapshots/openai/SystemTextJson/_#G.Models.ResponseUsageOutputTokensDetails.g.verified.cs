//HintName: G.Models.ResponseUsageOutputTokensDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A detailed breakdown of the output tokens.
    /// </summary>
    public sealed partial class ResponseUsageOutputTokensDetails
    {
        /// <summary>
        /// The number of reasoning tokens.
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
        /// <param name="reasoningTokens">
        /// The number of reasoning tokens.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseUsageOutputTokensDetails(
            int reasoningTokens)
        {
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