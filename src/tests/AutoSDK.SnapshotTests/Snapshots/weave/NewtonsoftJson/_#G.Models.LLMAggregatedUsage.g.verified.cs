//HintName: G.Models.LLMAggregatedUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Aggregated usage metrics for a specific LLM.
    /// </summary>
    public sealed partial class LLMAggregatedUsage
    {
        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requests")]
        public int? Requests { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens")]
        public int? PromptTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens")]
        public int? CompletionTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_tokens_total_cost")]
        public double? PromptTokensTotalCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_tokens_total_cost")]
        public double? CompletionTokensTotalCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMAggregatedUsage" /> class.
        /// </summary>
        /// <param name="requests">
        /// Default Value: 0
        /// </param>
        /// <param name="promptTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="completionTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="totalTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="promptTokensTotalCost"></param>
        /// <param name="completionTokensTotalCost"></param>
        public LLMAggregatedUsage(
            int? requests,
            int? promptTokens,
            int? completionTokens,
            int? totalTokens,
            double? promptTokensTotalCost,
            double? completionTokensTotalCost)
        {
            this.Requests = requests;
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.TotalTokens = totalTokens;
            this.PromptTokensTotalCost = promptTokensTotalCost;
            this.CompletionTokensTotalCost = completionTokensTotalCost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMAggregatedUsage" /> class.
        /// </summary>
        public LLMAggregatedUsage()
        {
        }
    }
}