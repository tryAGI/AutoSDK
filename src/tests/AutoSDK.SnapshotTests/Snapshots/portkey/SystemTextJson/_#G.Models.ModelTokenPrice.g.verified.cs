//HintName: G.Models.ModelTokenPrice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Price object (value is in USD cents)
    /// </summary>
    public sealed partial class ModelTokenPrice
    {
        /// <summary>
        /// Price in USD cents per token/unit.<br/>
        /// Example: `0.003` = 0.003 cents/token = $0.03 per 1K tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        public double? Price { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelTokenPrice" /> class.
        /// </summary>
        /// <param name="price">
        /// Price in USD cents per token/unit.<br/>
        /// Example: `0.003` = 0.003 cents/token = $0.03 per 1K tokens
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelTokenPrice(
            double? price)
        {
            this.Price = price;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelTokenPrice" /> class.
        /// </summary>
        public ModelTokenPrice()
        {
        }
    }
}