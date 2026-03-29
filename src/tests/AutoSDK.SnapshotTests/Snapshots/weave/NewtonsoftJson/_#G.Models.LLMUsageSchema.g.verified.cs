//HintName: G.Models.LLMUsageSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMUsageSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens")]
        public int? PromptTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_tokens")]
        public int? InputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens")]
        public int? CompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_tokens")]
        public int? OutputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requests")]
        public int? Requests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMUsageSchema" /> class.
        /// </summary>
        /// <param name="promptTokens"></param>
        /// <param name="inputTokens"></param>
        /// <param name="completionTokens"></param>
        /// <param name="outputTokens"></param>
        /// <param name="requests"></param>
        /// <param name="totalTokens"></param>
        public LLMUsageSchema(
            int? promptTokens,
            int? inputTokens,
            int? completionTokens,
            int? outputTokens,
            int? requests,
            int? totalTokens)
        {
            this.PromptTokens = promptTokens;
            this.InputTokens = inputTokens;
            this.CompletionTokens = completionTokens;
            this.OutputTokens = outputTokens;
            this.Requests = requests;
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMUsageSchema" /> class.
        /// </summary>
        public LLMUsageSchema()
        {
        }
    }
}