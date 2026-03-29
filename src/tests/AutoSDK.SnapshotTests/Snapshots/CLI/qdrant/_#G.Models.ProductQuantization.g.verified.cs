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
        [global::System.Text.Json.Serialization.JsonPropertyName("product")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ProductQuantizationConfig Product { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductQuantization" /> class.
        /// </summary>
        /// <param name="product"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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