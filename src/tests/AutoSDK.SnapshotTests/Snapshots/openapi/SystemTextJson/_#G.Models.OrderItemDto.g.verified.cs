//HintName: G.Models.OrderItemDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrderItemDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AvailableToBuyProductTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AvailableToBuyProductType ProductType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Quantity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customPrice")]
        public double? CustomPrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purchasedForUserId")]
        public long? PurchasedForUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderItemDto" /> class.
        /// </summary>
        /// <param name="productType"></param>
        /// <param name="quantity"></param>
        /// <param name="customPrice"></param>
        /// <param name="purchasedForUserId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrderItemDto(
            global::G.AvailableToBuyProductType productType,
            int quantity,
            double? customPrice,
            long? purchasedForUserId)
        {
            this.ProductType = productType;
            this.Quantity = quantity;
            this.CustomPrice = customPrice;
            this.PurchasedForUserId = purchasedForUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderItemDto" /> class.
        /// </summary>
        public OrderItemDto()
        {
        }
    }
}