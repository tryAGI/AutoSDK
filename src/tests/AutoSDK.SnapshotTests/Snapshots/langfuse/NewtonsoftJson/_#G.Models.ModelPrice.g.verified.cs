//HintName: G.Models.ModelPrice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelPrice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("price", Required = global::Newtonsoft.Json.Required.Always)]
        public double Price { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPrice" /> class.
        /// </summary>
        /// <param name="price"></param>
        public ModelPrice(
            double price)
        {
            this.Price = price;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelPrice" /> class.
        /// </summary>
        public ModelPrice()
        {
        }
    }
}