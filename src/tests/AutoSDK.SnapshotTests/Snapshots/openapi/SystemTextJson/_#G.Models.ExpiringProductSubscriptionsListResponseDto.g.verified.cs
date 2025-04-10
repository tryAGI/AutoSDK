//HintName: G.Models.ExpiringProductSubscriptionsListResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExpiringProductSubscriptionsListResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productName")]
        public string? ProductName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purchaseTimestamp")]
        public global::System.DateTime? PurchaseTimestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiryDate")]
        public global::System.DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("daysToExpiry")]
        public int? DaysToExpiry { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validityMonths")]
        public int? ValidityMonths { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productTypeEnumId")]
        public int? ProductTypeEnumId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpiringProductSubscriptionsListResponseDto" /> class.
        /// </summary>
        /// <param name="productName"></param>
        /// <param name="purchaseTimestamp"></param>
        /// <param name="expiryDate"></param>
        /// <param name="daysToExpiry"></param>
        /// <param name="validityMonths"></param>
        /// <param name="productTypeEnumId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExpiringProductSubscriptionsListResponseDto(
            string? productName,
            global::System.DateTime? purchaseTimestamp,
            global::System.DateTime? expiryDate,
            int? daysToExpiry,
            int? validityMonths,
            int? productTypeEnumId)
        {
            this.ProductName = productName;
            this.PurchaseTimestamp = purchaseTimestamp;
            this.ExpiryDate = expiryDate;
            this.DaysToExpiry = daysToExpiry;
            this.ValidityMonths = validityMonths;
            this.ProductTypeEnumId = productTypeEnumId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpiringProductSubscriptionsListResponseDto" /> class.
        /// </summary>
        public ExpiringProductSubscriptionsListResponseDto()
        {
        }
    }
}