//HintName: G.Models.TokenPricing.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TokenPricing
    {
        /// <summary>
        /// Price per token
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("price")]
        public float? Price { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenPricing" /> class.
        /// </summary>
        /// <param name="price">
        /// Price per token
        /// </param>
        public TokenPricing(
            float? price)
        {
            this.Price = price;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenPricing" /> class.
        /// </summary>
        public TokenPricing()
        {
        }
    }
}