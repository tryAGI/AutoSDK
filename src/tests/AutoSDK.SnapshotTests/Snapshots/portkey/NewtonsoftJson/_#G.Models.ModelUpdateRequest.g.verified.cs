//HintName: G.Models.ModelUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelUpdateRequest
    {
        /// <summary>
        /// Model slug identifier
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("slug", Required = global::Newtonsoft.Json.Required.Always)]
        public string Slug { get; set; } = default!;

        /// <summary>
        /// Whether to enable the model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Enabled { get; set; } = default!;

        /// <summary>
        /// Whether this is a custom model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_custom")]
        public bool? IsCustom { get; set; }

        /// <summary>
        /// Whether this is a fine-tuned model
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_finetune")]
        public bool? IsFinetune { get; set; }

        /// <summary>
        /// Base model slug for fine-tuned models
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("base_model_slug")]
        public string? BaseModelSlug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pricing_config")]
        public global::G.PricingConfig? PricingConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelUpdateRequest" /> class.
        /// </summary>
        /// <param name="slug">
        /// Model slug identifier
        /// </param>
        /// <param name="enabled">
        /// Whether to enable the model
        /// </param>
        /// <param name="isCustom">
        /// Whether this is a custom model
        /// </param>
        /// <param name="isFinetune">
        /// Whether this is a fine-tuned model
        /// </param>
        /// <param name="baseModelSlug">
        /// Base model slug for fine-tuned models
        /// </param>
        /// <param name="pricingConfig"></param>
        public ModelUpdateRequest(
            string slug,
            bool enabled,
            bool? isCustom,
            bool? isFinetune,
            string? baseModelSlug,
            global::G.PricingConfig? pricingConfig)
        {
            this.Slug = slug ?? throw new global::System.ArgumentNullException(nameof(slug));
            this.Enabled = enabled;
            this.IsCustom = isCustom;
            this.IsFinetune = isFinetune;
            this.BaseModelSlug = baseModelSlug;
            this.PricingConfig = pricingConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelUpdateRequest" /> class.
        /// </summary>
        public ModelUpdateRequest()
        {
        }
    }
}