//HintName: G.Models.IntegrationModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IntegrationModel
    {
        /// <summary>
        /// Model slug identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// Human-readable model name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Whether the model is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Whether this is a custom model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_custom")]
        public bool? IsCustom { get; set; }

        /// <summary>
        /// Whether this is a fine-tuned model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_finetune")]
        public bool? IsFinetune { get; set; }

        /// <summary>
        /// Base model slug for fine-tuned models
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_model_slug")]
        public string? BaseModelSlug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing_config")]
        public global::G.PricingConfig? PricingConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationModel" /> class.
        /// </summary>
        /// <param name="slug">
        /// Model slug identifier
        /// </param>
        /// <param name="name">
        /// Human-readable model name
        /// </param>
        /// <param name="enabled">
        /// Whether the model is enabled
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationModel(
            string? slug,
            string? name,
            bool? enabled,
            bool? isCustom,
            bool? isFinetune,
            string? baseModelSlug,
            global::G.PricingConfig? pricingConfig)
        {
            this.Slug = slug;
            this.Name = name;
            this.Enabled = enabled;
            this.IsCustom = isCustom;
            this.IsFinetune = isFinetune;
            this.BaseModelSlug = baseModelSlug;
            this.PricingConfig = pricingConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationModel" /> class.
        /// </summary>
        public IntegrationModel()
        {
        }
    }
}