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
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_prices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.LLMUsageCalculatorLLMResponseModel> LlmPrices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMUsageCalculatorResponseModel" /> class.
        /// </summary>
        /// <param name="llmPrices"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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