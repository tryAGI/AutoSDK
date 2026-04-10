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
        [global::Newtonsoft.Json.JsonProperty("llm", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.LlmJsonConverter))]
        public global::G.Llm Llm { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("price_per_minute", Required = global::Newtonsoft.Json.Required.Always)]
        public double PricePerMinute { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMUsageCalculatorLLMResponseModel" /> class.
        /// </summary>
        /// <param name="llm"></param>
        /// <param name="pricePerMinute"></param>
        public LLMUsageCalculatorLLMResponseModel(
            global::G.Llm llm,
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