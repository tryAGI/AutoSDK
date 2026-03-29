//HintName: G.Models.ConfigurationUpdateRequestParametersVariant1Discriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConfigurationUpdateRequestParametersVariant1Discriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("product_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductTypeJsonConverter))]
        public global::G.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType? ProductType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationUpdateRequestParametersVariant1Discriminator" /> class.
        /// </summary>
        /// <param name="productType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfigurationUpdateRequestParametersVariant1Discriminator(
            global::G.ConfigurationUpdateRequestParametersVariant1DiscriminatorProductType? productType)
        {
            this.ProductType = productType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationUpdateRequestParametersVariant1Discriminator" /> class.
        /// </summary>
        public ConfigurationUpdateRequestParametersVariant1Discriminator()
        {
        }
    }
}