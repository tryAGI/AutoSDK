//HintName: G.Models.ModelPricingConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Complete pricing configuration for a model
    /// </summary>
    public sealed partial class ModelPricingConfig
    {
        /// <summary>
        /// Token-based pricing (all prices in USD cents)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pay_as_you_go")]
        public global::G.ModelPayAsYouGo? PayAsYouGo { get; set; }

        /// <summary>
        /// Cost calculation formulas
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calculate")]
        public global::G.ModelCalculateConfig? Calculate { get; set; }

        /// <summary>
        /// Currency code (always USD)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModelPricingConfigCurrencyJsonConverter))]
        public global::G.ModelPricingConfigCurrency? Currency { get; set; }

        /// <summary>
        /// Fine-tuning pricing configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finetune_config")]
        public global::G.ModelFinetuneConfig? FinetuneConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingConfig" /> class.
        /// </summary>
        /// <param name="payAsYouGo">
        /// Token-based pricing (all prices in USD cents)
        /// </param>
        /// <param name="calculate">
        /// Cost calculation formulas
        /// </param>
        /// <param name="currency">
        /// Currency code (always USD)
        /// </param>
        /// <param name="finetuneConfig">
        /// Fine-tuning pricing configuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelPricingConfig(
            global::G.ModelPayAsYouGo? payAsYouGo,
            global::G.ModelCalculateConfig? calculate,
            global::G.ModelPricingConfigCurrency? currency,
            global::G.ModelFinetuneConfig? finetuneConfig)
        {
            this.PayAsYouGo = payAsYouGo;
            this.Calculate = calculate;
            this.Currency = currency;
            this.FinetuneConfig = finetuneConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPricingConfig" /> class.
        /// </summary>
        public ModelPricingConfig()
        {
        }
    }
}