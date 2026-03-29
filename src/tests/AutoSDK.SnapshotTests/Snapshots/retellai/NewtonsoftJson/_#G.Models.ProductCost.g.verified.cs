//HintName: G.Models.ProductCost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProductCost
    {
        /// <summary>
        /// Product name that has a cost associated with it.<br/>
        /// Example: elevenlabs_tts
        /// </summary>
        /// <example>elevenlabs_tts</example>
        [global::Newtonsoft.Json.JsonProperty("product", Required = global::Newtonsoft.Json.Required.Always)]
        public string Product { get; set; } = default!;

        /// <summary>
        /// Unit price of the product in cents per second.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("unit_price")]
        public double? UnitPrice { get; set; }

        /// <summary>
        /// Cost for the product in cents for the duration of the call.<br/>
        /// Example: 60
        /// </summary>
        /// <example>60</example>
        [global::Newtonsoft.Json.JsonProperty("cost", Required = global::Newtonsoft.Json.Required.Always)]
        public double Cost { get; set; } = default!;

        /// <summary>
        /// True if this cost item is for a transfer segment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_transfer_leg_cost")]
        public bool? IsTransferLegCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductCost" /> class.
        /// </summary>
        /// <param name="product">
        /// Product name that has a cost associated with it.<br/>
        /// Example: elevenlabs_tts
        /// </param>
        /// <param name="cost">
        /// Cost for the product in cents for the duration of the call.<br/>
        /// Example: 60
        /// </param>
        /// <param name="unitPrice">
        /// Unit price of the product in cents per second.<br/>
        /// Example: 1
        /// </param>
        /// <param name="isTransferLegCost">
        /// True if this cost item is for a transfer segment.
        /// </param>
        public ProductCost(
            string product,
            double cost,
            double? unitPrice,
            bool? isTransferLegCost)
        {
            this.Product = product ?? throw new global::System.ArgumentNullException(nameof(product));
            this.UnitPrice = unitPrice;
            this.Cost = cost;
            this.IsTransferLegCost = isTransferLegCost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductCost" /> class.
        /// </summary>
        public ProductCost()
        {
        }
    }
}