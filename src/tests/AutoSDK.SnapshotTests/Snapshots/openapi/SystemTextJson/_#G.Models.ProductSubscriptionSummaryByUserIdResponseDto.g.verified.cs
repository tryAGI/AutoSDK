//HintName: G.Models.ProductSubscriptionSummaryByUserIdResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProductSubscriptionSummaryByUserIdResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productName")]
        public string? ProductName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public global::System.DateTime? Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

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
        /// Initializes a new instance of the <see cref="ProductSubscriptionSummaryByUserIdResponseDto" /> class.
        /// </summary>
        /// <param name="productName"></param>
        /// <param name="timestamp"></param>
        /// <param name="id"></param>
        /// <param name="productTypeEnumId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProductSubscriptionSummaryByUserIdResponseDto(
            string? productName,
            global::System.DateTime? timestamp,
            long? id,
            int? productTypeEnumId)
        {
            this.ProductName = productName;
            this.Timestamp = timestamp;
            this.Id = id;
            this.ProductTypeEnumId = productTypeEnumId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSubscriptionSummaryByUserIdResponseDto" /> class.
        /// </summary>
        public ProductSubscriptionSummaryByUserIdResponseDto()
        {
        }
    }
}