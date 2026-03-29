//HintName: G.Models.UntypedParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Catch-all for configurations without a dedicated typed schema.<br/>
    /// Accepts arbitrary JSON fields alongside ``product_type``.
    /// </summary>
    public sealed partial class UntypedParameters
    {
        /// <summary>
        /// Product type.
        /// </summary>
        /// <default>"unknown"</default>
        [global::Newtonsoft.Json.JsonProperty("product_type")]
        public string ProductType { get; set; } = "unknown";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UntypedParameters" /> class.
        /// </summary>
        /// <param name="productType">
        /// Product type.
        /// </param>
        public UntypedParameters(
            string productType = "unknown")
        {
            this.ProductType = productType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UntypedParameters" /> class.
        /// </summary>
        public UntypedParameters()
        {
        }
    }
}