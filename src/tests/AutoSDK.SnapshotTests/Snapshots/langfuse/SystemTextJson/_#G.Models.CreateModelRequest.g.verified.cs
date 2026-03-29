//HintName: G.Models.CreateModelRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateModelRequest
    {
        /// <summary>
        /// Name of the model definition. If multiple with the same name exist, they are applied in the following order: (1) custom over built-in, (2) newest according to startTime where model.startTime&lt;observation.startTime
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelName")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// Regex pattern which matches this model definition to generation.model. Useful in case of fine-tuned models. If you want to exact match, use `(?i)^modelname$`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matchPattern")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MatchPattern { get; set; }

        /// <summary>
        /// Apply only to generations which are newer than this ISO date.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startDate")]
        public global::System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Unit of usage in Langfuse
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModelUsageUnitJsonConverter))]
        public global::G.ModelUsageUnit? Unit { get; set; }

        /// <summary>
        /// Deprecated. Use 'pricingTiers' instead. Price (USD) per input unit. Creates a default tier if pricingTiers not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputPrice")]
        public double? InputPrice { get; set; }

        /// <summary>
        /// Deprecated. Use 'pricingTiers' instead. Price (USD) per output unit. Creates a default tier if pricingTiers not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputPrice")]
        public double? OutputPrice { get; set; }

        /// <summary>
        /// Deprecated. Use 'pricingTiers' instead. Price (USD) per total units. Cannot be set if input or output price is set. Creates a default tier if pricingTiers not provided.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalPrice")]
        public double? TotalPrice { get; set; }

        /// <summary>
        /// Optional. Array of pricing tiers for this model.<br/>
        /// Use pricing tiers for all models - both those with threshold-based pricing variations and those with simple flat pricing:<br/>
        /// - For models with standard flat pricing: Create a single default tier with your prices<br/>
        ///   (e.g., one tier with isDefault=true, priority=0, conditions=[], and your standard prices)<br/>
        /// - For models with threshold-based pricing: Create a default tier plus additional conditional tiers<br/>
        ///   (e.g., default tier for standard usage + high-volume tier for usage above certain thresholds)<br/>
        /// Requirements:<br/>
        /// - Cannot be provided with flat prices (inputPrice/outputPrice/totalPrice) - use one approach or the other<br/>
        /// - Must include exactly one default tier with isDefault=true, priority=0, and conditions=[]<br/>
        /// - All tier names and priorities must be unique within the model<br/>
        /// - Each tier must define at least one price<br/>
        /// If omitted, you must provide flat prices instead (inputPrice/outputPrice/totalPrice),<br/>
        /// which will automatically create a single default tier named "Standard".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricingTiers")]
        public global::System.Collections.Generic.IList<global::G.PricingTierInput>? PricingTiers { get; set; }

        /// <summary>
        /// Optional. Tokenizer to be applied to observations which match to this model. See docs for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenizerId")]
        public string? TokenizerId { get; set; }

        /// <summary>
        /// Optional. Configuration for the selected tokenizer. Needs to be JSON. See docs for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenizerConfig")]
        public object? TokenizerConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelRequest" /> class.
        /// </summary>
        /// <param name="modelName">
        /// Name of the model definition. If multiple with the same name exist, they are applied in the following order: (1) custom over built-in, (2) newest according to startTime where model.startTime&lt;observation.startTime
        /// </param>
        /// <param name="matchPattern">
        /// Regex pattern which matches this model definition to generation.model. Useful in case of fine-tuned models. If you want to exact match, use `(?i)^modelname$`
        /// </param>
        /// <param name="startDate">
        /// Apply only to generations which are newer than this ISO date.
        /// </param>
        /// <param name="unit">
        /// Unit of usage in Langfuse
        /// </param>
        /// <param name="inputPrice">
        /// Deprecated. Use 'pricingTiers' instead. Price (USD) per input unit. Creates a default tier if pricingTiers not provided.
        /// </param>
        /// <param name="outputPrice">
        /// Deprecated. Use 'pricingTiers' instead. Price (USD) per output unit. Creates a default tier if pricingTiers not provided.
        /// </param>
        /// <param name="totalPrice">
        /// Deprecated. Use 'pricingTiers' instead. Price (USD) per total units. Cannot be set if input or output price is set. Creates a default tier if pricingTiers not provided.
        /// </param>
        /// <param name="pricingTiers">
        /// Optional. Array of pricing tiers for this model.<br/>
        /// Use pricing tiers for all models - both those with threshold-based pricing variations and those with simple flat pricing:<br/>
        /// - For models with standard flat pricing: Create a single default tier with your prices<br/>
        ///   (e.g., one tier with isDefault=true, priority=0, conditions=[], and your standard prices)<br/>
        /// - For models with threshold-based pricing: Create a default tier plus additional conditional tiers<br/>
        ///   (e.g., default tier for standard usage + high-volume tier for usage above certain thresholds)<br/>
        /// Requirements:<br/>
        /// - Cannot be provided with flat prices (inputPrice/outputPrice/totalPrice) - use one approach or the other<br/>
        /// - Must include exactly one default tier with isDefault=true, priority=0, and conditions=[]<br/>
        /// - All tier names and priorities must be unique within the model<br/>
        /// - Each tier must define at least one price<br/>
        /// If omitted, you must provide flat prices instead (inputPrice/outputPrice/totalPrice),<br/>
        /// which will automatically create a single default tier named "Standard".
        /// </param>
        /// <param name="tokenizerId">
        /// Optional. Tokenizer to be applied to observations which match to this model. See docs for more details.
        /// </param>
        /// <param name="tokenizerConfig">
        /// Optional. Configuration for the selected tokenizer. Needs to be JSON. See docs for more details.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateModelRequest(
            string modelName,
            string matchPattern,
            global::System.DateTime? startDate,
            global::G.ModelUsageUnit? unit,
            double? inputPrice,
            double? outputPrice,
            double? totalPrice,
            global::System.Collections.Generic.IList<global::G.PricingTierInput>? pricingTiers,
            string? tokenizerId,
            object? tokenizerConfig)
        {
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.MatchPattern = matchPattern ?? throw new global::System.ArgumentNullException(nameof(matchPattern));
            this.StartDate = startDate;
            this.Unit = unit;
            this.InputPrice = inputPrice;
            this.OutputPrice = outputPrice;
            this.TotalPrice = totalPrice;
            this.PricingTiers = pricingTiers;
            this.TokenizerId = tokenizerId;
            this.TokenizerConfig = tokenizerConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelRequest" /> class.
        /// </summary>
        public CreateModelRequest()
        {
        }
    }
}