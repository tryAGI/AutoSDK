//HintName: G.Models.OrderForInvoiceItemDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrderForInvoiceItemDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        public int? Number { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productDescription")]
        public string? ProductDescription { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("salePrice")]
        public int? SalePrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantity")]
        public int? Quantity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("goCredits")]
        public int? GoCredits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderForInvoiceItemDto" /> class.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="productDescription"></param>
        /// <param name="salePrice"></param>
        /// <param name="quantity"></param>
        /// <param name="total"></param>
        /// <param name="goCredits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrderForInvoiceItemDto(
            int? number,
            string? productDescription,
            int? salePrice,
            int? quantity,
            int? total,
            int? goCredits)
        {
            this.Number = number;
            this.ProductDescription = productDescription;
            this.SalePrice = salePrice;
            this.Quantity = quantity;
            this.Total = total;
            this.GoCredits = goCredits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderForInvoiceItemDto" /> class.
        /// </summary>
        public OrderForInvoiceItemDto()
        {
        }
    }
}