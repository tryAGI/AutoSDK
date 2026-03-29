//HintName: G.Models.Model.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Model definition used for transforming usage into USD cost and/or tokenization.<br/>
    /// Models can have either simple flat pricing or tiered pricing:<br/>
    /// - Flat pricing: Single price per usage type (legacy, but still supported)<br/>
    /// - Tiered pricing: Multiple pricing tiers with conditional matching based on usage patterns<br/>
    /// The pricing tiers approach is recommended for models with usage-based pricing variations.<br/>
    /// When using tiered pricing, the flat price fields (inputPrice, outputPrice, prices) are populated<br/>
    /// from the default tier for backward compatibility.
    /// </summary>
    public sealed partial class Model
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Name of the model definition. If multiple with the same name exist, they are applied in the following order: (1) custom over built-in, (2) newest according to startTime where model.startTime&lt;observation.startTime
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("modelName", Required = global::Newtonsoft.Json.Required.Always)]
        public string ModelName { get; set; } = default!;

        /// <summary>
        /// Regex pattern which matches this model definition to generation.model. Useful in case of fine-tuned models. If you want to exact match, use `(?i)^modelname$`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("matchPattern", Required = global::Newtonsoft.Json.Required.Always)]
        public string MatchPattern { get; set; } = default!;

        /// <summary>
        /// Apply only to generations which are newer than this ISO date.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("startDate")]
        public global::System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Unit of usage in Langfuse
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unit")]
        public global::G.ModelUsageUnit? Unit { get; set; }

        /// <summary>
        /// Deprecated. See 'prices' instead. Price (USD) per input unit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("inputPrice")]
        public double? InputPrice { get; set; }

        /// <summary>
        /// Deprecated. See 'prices' instead. Price (USD) per output unit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("outputPrice")]
        public double? OutputPrice { get; set; }

        /// <summary>
        /// Deprecated. See 'prices' instead. Price (USD) per total unit. Cannot be set if input or output price is set.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalPrice")]
        public double? TotalPrice { get; set; }

        /// <summary>
        /// Optional. Tokenizer to be applied to observations which match to this model. See docs for more details.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tokenizerId")]
        public string? TokenizerId { get; set; }

        /// <summary>
        /// Optional. Configuration for the selected tokenizer. Needs to be JSON. See docs for more details.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tokenizerConfig", Required = global::Newtonsoft.Json.Required.Always)]
        public object TokenizerConfig { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isLangfuseManaged", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsLangfuseManaged { get; set; } = default!;

        /// <summary>
        /// Timestamp when the model was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Deprecated. Use 'pricingTiers' instead for models with usage-based pricing variations.<br/>
        /// This field shows prices by usage type from the default pricing tier. Maintained for backward compatibility.<br/>
        /// If the model uses tiered pricing, this field will be populated from the default tier's prices.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prices", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.ModelPrice> Prices { get; set; } = default!;

        /// <summary>
        /// Array of pricing tiers with conditional pricing based on usage thresholds.<br/>
        /// Pricing tiers enable accurate cost tracking for models that charge different rates based on usage patterns<br/>
        /// (e.g., different rates for high-volume usage, large context windows, or cached tokens).<br/>
        /// Each model must have exactly one default tier (isDefault=true, priority=0) that serves as a fallback.<br/>
        /// Additional conditional tiers can be defined with specific matching criteria.<br/>
        /// If this array is empty, the model uses legacy flat pricing from the inputPrice/outputPrice/totalPrice fields.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pricingTiers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PricingTier> PricingTiers { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="modelName">
        /// Name of the model definition. If multiple with the same name exist, they are applied in the following order: (1) custom over built-in, (2) newest according to startTime where model.startTime&lt;observation.startTime
        /// </param>
        /// <param name="matchPattern">
        /// Regex pattern which matches this model definition to generation.model. Useful in case of fine-tuned models. If you want to exact match, use `(?i)^modelname$`
        /// </param>
        /// <param name="tokenizerConfig">
        /// Optional. Configuration for the selected tokenizer. Needs to be JSON. See docs for more details.
        /// </param>
        /// <param name="isLangfuseManaged"></param>
        /// <param name="createdAt">
        /// Timestamp when the model was created
        /// </param>
        /// <param name="prices">
        /// Deprecated. Use 'pricingTiers' instead for models with usage-based pricing variations.<br/>
        /// This field shows prices by usage type from the default pricing tier. Maintained for backward compatibility.<br/>
        /// If the model uses tiered pricing, this field will be populated from the default tier's prices.
        /// </param>
        /// <param name="pricingTiers">
        /// Array of pricing tiers with conditional pricing based on usage thresholds.<br/>
        /// Pricing tiers enable accurate cost tracking for models that charge different rates based on usage patterns<br/>
        /// (e.g., different rates for high-volume usage, large context windows, or cached tokens).<br/>
        /// Each model must have exactly one default tier (isDefault=true, priority=0) that serves as a fallback.<br/>
        /// Additional conditional tiers can be defined with specific matching criteria.<br/>
        /// If this array is empty, the model uses legacy flat pricing from the inputPrice/outputPrice/totalPrice fields.
        /// </param>
        /// <param name="startDate">
        /// Apply only to generations which are newer than this ISO date.
        /// </param>
        /// <param name="unit">
        /// Unit of usage in Langfuse
        /// </param>
        /// <param name="inputPrice">
        /// Deprecated. See 'prices' instead. Price (USD) per input unit
        /// </param>
        /// <param name="outputPrice">
        /// Deprecated. See 'prices' instead. Price (USD) per output unit
        /// </param>
        /// <param name="totalPrice">
        /// Deprecated. See 'prices' instead. Price (USD) per total unit. Cannot be set if input or output price is set.
        /// </param>
        /// <param name="tokenizerId">
        /// Optional. Tokenizer to be applied to observations which match to this model. See docs for more details.
        /// </param>
        public Model(
            string id,
            string modelName,
            string matchPattern,
            object tokenizerConfig,
            bool isLangfuseManaged,
            global::System.DateTime createdAt,
            global::System.Collections.Generic.Dictionary<string, global::G.ModelPrice> prices,
            global::System.Collections.Generic.IList<global::G.PricingTier> pricingTiers,
            global::System.DateTime? startDate,
            global::G.ModelUsageUnit? unit,
            double? inputPrice,
            double? outputPrice,
            double? totalPrice,
            string? tokenizerId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.MatchPattern = matchPattern ?? throw new global::System.ArgumentNullException(nameof(matchPattern));
            this.StartDate = startDate;
            this.Unit = unit;
            this.InputPrice = inputPrice;
            this.OutputPrice = outputPrice;
            this.TotalPrice = totalPrice;
            this.TokenizerId = tokenizerId;
            this.TokenizerConfig = tokenizerConfig ?? throw new global::System.ArgumentNullException(nameof(tokenizerConfig));
            this.IsLangfuseManaged = isLangfuseManaged;
            this.CreatedAt = createdAt;
            this.Prices = prices ?? throw new global::System.ArgumentNullException(nameof(prices));
            this.PricingTiers = pricingTiers ?? throw new global::System.ArgumentNullException(nameof(pricingTiers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Model" /> class.
        /// </summary>
        public Model()
        {
        }
    }
}