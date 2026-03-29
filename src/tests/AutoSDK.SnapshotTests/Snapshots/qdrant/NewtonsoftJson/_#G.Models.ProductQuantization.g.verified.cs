//HintName: G.Models.ProductQuantization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProductQuantization
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("product", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ProductQuantizationConfig Product { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductQuantization" /> class.
        /// </summary>
        /// <param name="product"></param>
        public ProductQuantization(
            global::G.ProductQuantizationConfig product)
        {
            this.Product = product ?? throw new global::System.ArgumentNullException(nameof(product));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductQuantization" /> class.
        /// </summary>
        public ProductQuantization()
        {
        }
    }
}