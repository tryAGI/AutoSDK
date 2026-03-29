//HintName: G.Models.ConfigurationCreateRequestParametersDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConfigurationCreateRequestParametersDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("product_type")]
        public global::G.ConfigurationCreateRequestParametersDiscriminatorProductType? ProductType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationCreateRequestParametersDiscriminator" /> class.
        /// </summary>
        /// <param name="productType"></param>
        public ConfigurationCreateRequestParametersDiscriminator(
            global::G.ConfigurationCreateRequestParametersDiscriminatorProductType? productType)
        {
            this.ProductType = productType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationCreateRequestParametersDiscriminator" /> class.
        /// </summary>
        public ConfigurationCreateRequestParametersDiscriminator()
        {
        }
    }
}