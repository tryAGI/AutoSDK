//HintName: G.Models.FundTransferExternalRequestForCreateRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FundTransferExternalRequestForCreateRequestDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public long? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("originWalletTypeEnumId")]
        public int? OriginWalletTypeEnumId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("walletTypeEnumId")]
        public int? WalletTypeEnumId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destinationWalletUserId")]
        public long? DestinationWalletUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public double? Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transferChargePercent")]
        public double? TransferChargePercent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FundTransferExternalRequestForCreateRequestDto" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="originWalletTypeEnumId"></param>
        /// <param name="walletTypeEnumId"></param>
        /// <param name="destinationWalletUserId"></param>
        /// <param name="amount"></param>
        /// <param name="transferChargePercent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FundTransferExternalRequestForCreateRequestDto(
            long? userId,
            int? originWalletTypeEnumId,
            int? walletTypeEnumId,
            long? destinationWalletUserId,
            double? amount,
            double? transferChargePercent)
        {
            this.UserId = userId;
            this.OriginWalletTypeEnumId = originWalletTypeEnumId;
            this.WalletTypeEnumId = walletTypeEnumId;
            this.DestinationWalletUserId = destinationWalletUserId;
            this.Amount = amount;
            this.TransferChargePercent = transferChargePercent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FundTransferExternalRequestForCreateRequestDto" /> class.
        /// </summary>
        public FundTransferExternalRequestForCreateRequestDto()
        {
        }
    }
}