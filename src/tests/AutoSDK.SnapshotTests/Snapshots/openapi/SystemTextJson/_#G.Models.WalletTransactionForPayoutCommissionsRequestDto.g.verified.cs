//HintName: G.Models.WalletTransactionForPayoutCommissionsRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WalletTransactionForPayoutCommissionsRequestDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payoutPeriodId")]
        public long? PayoutPeriodId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletTransactionForPayoutCommissionsRequestDto" /> class.
        /// </summary>
        /// <param name="payoutPeriodId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WalletTransactionForPayoutCommissionsRequestDto(
            long? payoutPeriodId)
        {
            this.PayoutPeriodId = payoutPeriodId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletTransactionForPayoutCommissionsRequestDto" /> class.
        /// </summary>
        public WalletTransactionForPayoutCommissionsRequestDto()
        {
        }
    }
}