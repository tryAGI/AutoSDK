//HintName: G.Models.LLMUsageCalculatorResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMUsageCalculatorResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llm_prices", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.LLMUsageCalculatorLLMResponseModel> LlmPrices { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMUsageCalculatorResponseModel" /> class.
        /// </summary>
        /// <param name="llmPrices"></param>
        public LLMUsageCalculatorResponseModel(
            global::System.Collections.Generic.IList<global::G.LLMUsageCalculatorLLMResponseModel> llmPrices)
        {
            this.LlmPrices = llmPrices ?? throw new global::System.ArgumentNullException(nameof(llmPrices));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMUsageCalculatorResponseModel" /> class.
        /// </summary>
        public LLMUsageCalculatorResponseModel()
        {
        }
    }
}