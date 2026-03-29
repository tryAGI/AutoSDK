//HintName: G.Models.GetSubscriptionResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSubscriptionResponseItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("price", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetSubscriptionResponseItemPrice Price { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("quantity")]
        public double? Quantity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSubscriptionResponseItem" /> class.
        /// </summary>
        /// <param name="price"></param>
        /// <param name="quantity"></param>
        public GetSubscriptionResponseItem(
            global::G.GetSubscriptionResponseItemPrice price,
            double? quantity)
        {
            this.Price = price ?? throw new global::System.ArgumentNullException(nameof(price));
            this.Quantity = quantity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSubscriptionResponseItem" /> class.
        /// </summary>
        public GetSubscriptionResponseItem()
        {
        }
    }
}