//HintName: G.Models.LLMUsageCalculatorLLMResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LLMUsageCalculatorLLMResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LLMJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.LLM Llm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price_per_minute")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PricePerMinute { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMUsageCalculatorLLMResponseModel" /> class.
        /// </summary>
        /// <param name="llm"></param>
        /// <param name="pricePerMinute"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LLMUsageCalculatorLLMResponseModel(
            global::G.LLM llm,
            double pricePerMinute)
        {
            this.Llm = llm;
            this.PricePerMinute = pricePerMinute;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMUsageCalculatorLLMResponseModel" /> class.
        /// </summary>
        public LLMUsageCalculatorLLMResponseModel()
        {
        }
    }
}