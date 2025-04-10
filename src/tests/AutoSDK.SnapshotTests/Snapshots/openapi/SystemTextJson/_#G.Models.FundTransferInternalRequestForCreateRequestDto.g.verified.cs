//HintName: G.Models.FundTransferInternalRequestForCreateRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FundTransferInternalRequestForCreateRequestDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public long? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("walletTypeId")]
        public int? WalletTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recipientWalletTypeId")]
        public int? RecipientWalletTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productSubscriptionId")]
        public long? ProductSubscriptionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FundTransferInternalRequestForCreateRequestDto" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="walletTypeId"></param>
        /// <param name="recipientWalletTypeId"></param>
        /// <param name="amount"></param>
        /// <param name="productSubscriptionId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FundTransferInternalRequestForCreateRequestDto(
            long? userId,
            int? walletTypeId,
            int? recipientWalletTypeId,
            double? amount,
            long? productSubscriptionId)
        {
            this.UserId = userId;
            this.WalletTypeId = walletTypeId;
            this.RecipientWalletTypeId = recipientWalletTypeId;
            this.Amount = amount;
            this.ProductSubscriptionId = productSubscriptionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FundTransferInternalRequestForCreateRequestDto" /> class.
        /// </summary>
        public FundTransferInternalRequestForCreateRequestDto()
        {
        }
    }
}