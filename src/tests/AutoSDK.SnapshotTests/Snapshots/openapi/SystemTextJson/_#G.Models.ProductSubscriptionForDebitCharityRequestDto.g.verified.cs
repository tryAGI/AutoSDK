//HintName: G.Models.ProductSubscriptionForDebitCharityRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProductSubscriptionForDebitCharityRequestDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adminId")]
        public long? AdminId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("debitAmount")]
        public double? DebitAmount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSubscriptionForDebitCharityRequestDto" /> class.
        /// </summary>
        /// <param name="adminId"></param>
        /// <param name="debitAmount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProductSubscriptionForDebitCharityRequestDto(
            long? adminId,
            double? debitAmount)
        {
            this.AdminId = adminId;
            this.DebitAmount = debitAmount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSubscriptionForDebitCharityRequestDto" /> class.
        /// </summary>
        public ProductSubscriptionForDebitCharityRequestDto()
        {
        }
    }
}