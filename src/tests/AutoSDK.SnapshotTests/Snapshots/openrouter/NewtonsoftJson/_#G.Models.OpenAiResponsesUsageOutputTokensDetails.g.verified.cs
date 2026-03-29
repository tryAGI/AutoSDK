//HintName: G.Models.OpenAiResponsesUsageOutputTokensDetails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAiResponsesUsageOutputTokensDetails
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reasoning_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double ReasoningTokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAiResponsesUsageOutputTokensDetails" /> class.
        /// </summary>
        /// <param name="reasoningTokens"></param>
        public OpenAiResponsesUsageOutputTokensDetails(
            double reasoningTokens)
        {
            this.ReasoningTokens = reasoningTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAiResponsesUsageOutputTokensDetails" /> class.
        /// </summary>
        public OpenAiResponsesUsageOutputTokensDetails()
        {
        }
    }
}