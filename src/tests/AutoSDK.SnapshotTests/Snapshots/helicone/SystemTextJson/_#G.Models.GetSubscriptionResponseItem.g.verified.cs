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
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetSubscriptionResponseItemPrice Price { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public double? Quantity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSubscriptionResponseItem" /> class.
        /// </summary>
        /// <param name="price"></param>
        /// <param name="quantity"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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