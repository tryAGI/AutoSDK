//HintName: G.Models.OpenAIResponsesUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAIResponsesUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double InputTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_tokens_details", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OpenAiResponsesUsageInputTokensDetails InputTokensDetails { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double OutputTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_tokens_details", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OpenAiResponsesUsageOutputTokensDetails OutputTokensDetails { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalTokens { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIResponsesUsage" /> class.
        /// </summary>
        /// <param name="inputTokens"></param>
        /// <param name="inputTokensDetails"></param>
        /// <param name="outputTokens"></param>
        /// <param name="outputTokensDetails"></param>
        /// <param name="totalTokens"></param>
        public OpenAIResponsesUsage(
            double inputTokens,
            global::G.OpenAiResponsesUsageInputTokensDetails inputTokensDetails,
            double outputTokens,
            global::G.OpenAiResponsesUsageOutputTokensDetails outputTokensDetails,
            double totalTokens)
        {
            this.InputTokens = inputTokens;
            this.InputTokensDetails = inputTokensDetails ?? throw new global::System.ArgumentNullException(nameof(inputTokensDetails));
            this.OutputTokens = outputTokens;
            this.OutputTokensDetails = outputTokensDetails ?? throw new global::System.ArgumentNullException(nameof(outputTokensDetails));
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIResponsesUsage" /> class.
        /// </summary>
        public OpenAIResponsesUsage()
        {
        }
    }
}