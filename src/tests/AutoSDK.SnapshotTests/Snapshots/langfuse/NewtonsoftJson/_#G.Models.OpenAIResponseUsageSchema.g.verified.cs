//HintName: G.Models.OpenAIResponseUsageSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// OpenAI Usage schema from Response API
    /// </summary>
    public sealed partial class OpenAIResponseUsageSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int InputTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_tokens_details")]
        public global::System.Collections.Generic.Dictionary<string, int?>? InputTokensDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_tokens_details")]
        public global::System.Collections.Generic.Dictionary<string, int?>? OutputTokensDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIResponseUsageSchema" /> class.
        /// </summary>
        /// <param name="inputTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="totalTokens"></param>
        /// <param name="inputTokensDetails"></param>
        /// <param name="outputTokensDetails"></param>
        public OpenAIResponseUsageSchema(
            int inputTokens,
            int outputTokens,
            int totalTokens,
            global::System.Collections.Generic.Dictionary<string, int?>? inputTokensDetails,
            global::System.Collections.Generic.Dictionary<string, int?>? outputTokensDetails)
        {
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.TotalTokens = totalTokens;
            this.InputTokensDetails = inputTokensDetails;
            this.OutputTokensDetails = outputTokensDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIResponseUsageSchema" /> class.
        /// </summary>
        public OpenAIResponseUsageSchema()
        {
        }
    }
}