//HintName: G.Models.LLMDeprecationInfoModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"fallback_percentage":0,"is_deprecated":true,"is_in_fallback_period":false,"is_in_warning_period":true,"llm":"gpt-4o-mini","provider_deprecation_date":"2025-06-01T00:00:00Z","replacement_model":"gpt-4o"}
    /// </summary>
    public sealed partial class LLMDeprecationInfoModel
    {
        /// <summary>
        /// The identifier of the deprecated LLM model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("llm", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.LlmJsonConverter))]
        public global::G.Llm Llm { get; set; } = default!;

        /// <summary>
        /// Whether this model is currently deprecated. True if the model is immediately deprecated or within the warning period.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_deprecated", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsDeprecated { get; set; } = default!;

        /// <summary>
        /// Whether this model is currently in the warning period before deprecation.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_in_warning_period")]
        public bool? IsInWarningPeriod { get; set; }

        /// <summary>
        /// Whether traffic is currently being progressively routed to the replacement model.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_in_fallback_period")]
        public bool? IsInFallbackPeriod { get; set; }

        /// <summary>
        /// Current percentage of traffic being routed to the replacement model (0-100).<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fallback_percentage")]
        public int? FallbackPercentage { get; set; }

        /// <summary>
        /// The date when the model provider will deprecate this model. Null for immediately deprecated models.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_deprecation_date")]
        public global::System.DateTime? ProviderDeprecationDate { get; set; }

        /// <summary>
        /// The model that replaces this deprecated model. Traffic will be automatically routed to this model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("replacement_model")]
        public global::G.Llm? ReplacementModel { get; set; }

        /// <summary>
        /// Custom deprecation timing configuration for this model. Null if using the default configuration.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deprecation_config")]
        public global::G.LLMDeprecationConfigModel? DeprecationConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMDeprecationInfoModel" /> class.
        /// </summary>
        /// <param name="llm">
        /// The identifier of the deprecated LLM model.
        /// </param>
        /// <param name="isDeprecated">
        /// Whether this model is currently deprecated. True if the model is immediately deprecated or within the warning period.
        /// </param>
        /// <param name="isInWarningPeriod">
        /// Whether this model is currently in the warning period before deprecation.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="isInFallbackPeriod">
        /// Whether traffic is currently being progressively routed to the replacement model.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="fallbackPercentage">
        /// Current percentage of traffic being routed to the replacement model (0-100).<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="providerDeprecationDate">
        /// The date when the model provider will deprecate this model. Null for immediately deprecated models.
        /// </param>
        /// <param name="replacementModel">
        /// The model that replaces this deprecated model. Traffic will be automatically routed to this model.
        /// </param>
        /// <param name="deprecationConfig">
        /// Custom deprecation timing configuration for this model. Null if using the default configuration.
        /// </param>
        public LLMDeprecationInfoModel(
            global::G.Llm llm,
            bool isDeprecated,
            bool? isInWarningPeriod,
            bool? isInFallbackPeriod,
            int? fallbackPercentage,
            global::System.DateTime? providerDeprecationDate,
            global::G.Llm? replacementModel,
            global::G.LLMDeprecationConfigModel? deprecationConfig)
        {
            this.Llm = llm;
            this.IsDeprecated = isDeprecated;
            this.IsInWarningPeriod = isInWarningPeriod;
            this.IsInFallbackPeriod = isInFallbackPeriod;
            this.FallbackPercentage = fallbackPercentage;
            this.ProviderDeprecationDate = providerDeprecationDate;
            this.ReplacementModel = replacementModel;
            this.DeprecationConfig = deprecationConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LLMDeprecationInfoModel" /> class.
        /// </summary>
        public LLMDeprecationInfoModel()
        {
        }
    }
}