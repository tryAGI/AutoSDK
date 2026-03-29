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
        /// <param name="reasoningTokens">
        /// The number of reasoning tokens.
        /// </param>
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