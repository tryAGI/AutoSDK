//HintName: G.Models.OrderLineItemDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrderLineItemDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        public double? Price { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("salePrice")]
        public double? SalePrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productId")]
        public long? ProductId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productTypeEnumId")]
        public int? ProductTypeEnumId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purchasedForUserId")]
        public long? PurchasedForUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additionalDetails")]
        public string? AdditionalDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderLineItemDto" /> class.
        /// </summary>
        /// <param name="price"></param>
        /// <param name="salePrice"></param>
        /// <param name="quantity"></param>
        /// <param name="productId"></param>
        /// <param name="productTypeEnumId"></param>
        /// <param name="purchasedForUserId"></param>
        /// <param name="additionalDetails"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrderLineItemDto(
            double? price,
            double? salePrice,
            int? quantity,
            long? productId,
            int? productTypeEnumId,
            long? purchasedForUserId,
            string? additionalDetails)
        {
            this.Price = price;
            this.SalePrice = salePrice;
            this.Quantity = quantity;
            this.ProductId = productId;
            this.ProductTypeEnumId = productTypeEnumId;
            this.PurchasedForUserId = purchasedForUserId;
            this.AdditionalDetails = additionalDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderLineItemDto" /> class.
        /// </summary>
        public OrderLineItemDto()
        {
        }
    }
}