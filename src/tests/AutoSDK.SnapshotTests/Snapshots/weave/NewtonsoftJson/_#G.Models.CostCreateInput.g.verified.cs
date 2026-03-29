//HintName: G.Models.CostCreateInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CostCreateInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_token_cost", Required = global::Newtonsoft.Json.Required.Always)]
        public double PromptTokenCost { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_token_cost", Required = global::Newtonsoft.Json.Required.Always)]
        public double CompletionTokenCost { get; set; } = default!;

        /// <summary>
        /// The unit of the cost for the prompt tokens<br/>
        /// Default Value: USD
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_token_cost_unit")]
        public string? PromptTokenCostUnit { get; set; }

        /// <summary>
        /// The unit of the cost for the completion tokens<br/>
        /// Default Value: USD
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completion_token_cost_unit")]
        public string? CompletionTokenCostUnit { get; set; }

        /// <summary>
        /// The date after which the cost is effective for, will default to the current date if not provided
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("effective_date")]
        public global::System.DateTime? EffectiveDate { get; set; }

        /// <summary>
        /// The provider of the LLM, e.g. 'openai' or 'mistral'. If not provided, the provider_id will be set to 'default'
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_id")]
        public string? ProviderId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CostCreateInput" /> class.
        /// </summary>
        /// <param name="promptTokenCost"></param>
        /// <param name="completionTokenCost"></param>
        /// <param name="promptTokenCostUnit">
        /// The unit of the cost for the prompt tokens<br/>
        /// Default Value: USD
        /// </param>
        /// <param name="completionTokenCostUnit">
        /// The unit of the cost for the completion tokens<br/>
        /// Default Value: USD
        /// </param>
        /// <param name="effectiveDate">
        /// The date after which the cost is effective for, will default to the current date if not provided
        /// </param>
        /// <param name="providerId">
        /// The provider of the LLM, e.g. 'openai' or 'mistral'. If not provided, the provider_id will be set to 'default'
        /// </param>
        public CostCreateInput(
            double promptTokenCost,
            double completionTokenCost,
            string? promptTokenCostUnit,
            string? completionTokenCostUnit,
            global::System.DateTime? effectiveDate,
            string? providerId)
        {
            this.PromptTokenCost = promptTokenCost;
            this.CompletionTokenCost = completionTokenCost;
            this.PromptTokenCostUnit = promptTokenCostUnit;
            this.CompletionTokenCostUnit = completionTokenCostUnit;
            this.EffectiveDate = effectiveDate;
            this.ProviderId = providerId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CostCreateInput" /> class.
        /// </summary>
        public CostCreateInput()
        {
        }
    }
}