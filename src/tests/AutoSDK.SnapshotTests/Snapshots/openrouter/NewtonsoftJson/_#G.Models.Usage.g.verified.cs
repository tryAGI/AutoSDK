//HintName: G.Models.Usage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Token usage information for the response
    /// </summary>
    public sealed partial class Usage
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
        /// Cost of the completion
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost")]
        public double? Cost { get; set; }

        /// <summary>
        /// Whether a request was made using a Bring Your Own Key configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_byok")]
        public bool? IsByok { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost_details")]
        public global::G.UsageCostDetails? CostDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage" /> class.
        /// </summary>
        /// <param name="inputTokens"></param>
        /// <param name="inputTokensDetails"></param>
        /// <param name="outputTokens"></param>
        /// <param name="outputTokensDetails"></param>
        /// <param name="totalTokens"></param>
        /// <param name="cost">
        /// Cost of the completion
        /// </param>
        /// <param name="isByok">
        /// Whether a request was made using a Bring Your Own Key configuration
        /// </param>
        /// <param name="costDetails"></param>
        public Usage(
            double inputTokens,
            global::G.OpenAiResponsesUsageInputTokensDetails inputTokensDetails,
            double outputTokens,
            global::G.OpenAiResponsesUsageOutputTokensDetails outputTokensDetails,
            double totalTokens,
            double? cost,
            bool? isByok,
            global::G.UsageCostDetails? costDetails)
        {
            this.InputTokens = inputTokens;
            this.InputTokensDetails = inputTokensDetails ?? throw new global::System.ArgumentNullException(nameof(inputTokensDetails));
            this.OutputTokens = outputTokens;
            this.OutputTokensDetails = outputTokensDetails ?? throw new global::System.ArgumentNullException(nameof(outputTokensDetails));
            this.TotalTokens = totalTokens;
            this.Cost = cost;
            this.IsByok = isByok;
            this.CostDetails = costDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage" /> class.
        /// </summary>
        public Usage()
        {
        }
    }
}