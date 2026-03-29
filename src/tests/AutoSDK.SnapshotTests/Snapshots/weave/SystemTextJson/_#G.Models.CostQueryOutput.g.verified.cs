//HintName: G.Models.CostQueryOutput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CostQueryOutput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_id")]
        public string? LlmId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_token_cost")]
        public double? PromptTokenCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_token_cost")]
        public double? CompletionTokenCost { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_token_cost_unit")]
        public string? PromptTokenCostUnit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_token_cost_unit")]
        public string? CompletionTokenCostUnit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_date")]
        public global::System.DateTime? EffectiveDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_id")]
        public string? ProviderId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CostQueryOutput" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="llmId"></param>
        /// <param name="promptTokenCost"></param>
        /// <param name="completionTokenCost"></param>
        /// <param name="promptTokenCostUnit"></param>
        /// <param name="completionTokenCostUnit"></param>
        /// <param name="effectiveDate"></param>
        /// <param name="providerId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CostQueryOutput(
            string? id,
            string? llmId,
            double? promptTokenCost,
            double? completionTokenCost,
            string? promptTokenCostUnit,
            string? completionTokenCostUnit,
            global::System.DateTime? effectiveDate,
            string? providerId)
        {
            this.Id = id;
            this.LlmId = llmId;
            this.PromptTokenCost = promptTokenCost;
            this.CompletionTokenCost = completionTokenCost;
            this.PromptTokenCostUnit = promptTokenCostUnit;
            this.CompletionTokenCostUnit = completionTokenCostUnit;
            this.EffectiveDate = effectiveDate;
            this.ProviderId = providerId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CostQueryOutput" /> class.
        /// </summary>
        public CostQueryOutput()
        {
        }
    }
}