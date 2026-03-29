//HintName: G.Models.ConfigurationResponseParametersDiscriminator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConfigurationResponseParametersDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("product_type")]
        public global::G.ConfigurationResponseParametersDiscriminatorProductType? ProductType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationResponseParametersDiscriminator" /> class.
        /// </summary>
        /// <param name="productType"></param>
        public ConfigurationResponseParametersDiscriminator(
            global::G.ConfigurationResponseParametersDiscriminatorProductType? productType)
        {
            this.ProductType = productType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationResponseParametersDiscriminator" /> class.
        /// </summary>
        public ConfigurationResponseParametersDiscriminator()
        {
        }
    }
}