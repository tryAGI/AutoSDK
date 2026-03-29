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
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        public int? Requests { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        public int? PromptTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        public int? CompletionTokens { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens_total_cost")]
        public double? PromptTokensTotalCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens_total_cost")]
        public double? CompletionTokensTotalCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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