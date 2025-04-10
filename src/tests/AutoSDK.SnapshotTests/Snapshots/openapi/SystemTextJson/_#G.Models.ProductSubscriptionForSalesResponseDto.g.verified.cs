//HintName: G.Models.ProductSubscriptionForSalesResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProductSubscriptionForSalesResponseDto
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("salesCount")]
        public int? SalesCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSubscriptionForSalesResponseDto" /> class.
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="productTypeEnumId"></param>
        /// <param name="salesCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProductSubscriptionForSalesResponseDto(
            long? productId,
            int? productTypeEnumId,
            int? salesCount)
        {
            this.ProductId = productId;
            this.ProductTypeEnumId = productTypeEnumId;
            this.SalesCount = salesCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSubscriptionForSalesResponseDto" /> class.
        /// </summary>
        public ProductSubscriptionForSalesResponseDto()
        {
        }
    }
}