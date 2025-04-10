//HintName: G.Models.WalletFundingRequestForCreateResponseDto2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WalletFundingRequestForCreateResponseDto2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cryptoCurrencyAmount")]
        public double? CryptoCurrencyAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cryptoCurrencyDepositAddress")]
        public string? CryptoCurrencyDepositAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cryptoCurrencyOptionEnumId")]
        public int? CryptoCurrencyOptionEnumId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("walletFundingRequestId")]
        public long? WalletFundingRequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletFundingRequestForCreateResponseDto2" /> class.
        /// </summary>
        /// <param name="cryptoCurrencyAmount"></param>
        /// <param name="cryptoCurrencyDepositAddress"></param>
        /// <param name="cryptoCurrencyOptionEnumId"></param>
        /// <param name="walletFundingRequestId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WalletFundingRequestForCreateResponseDto2(
            double? cryptoCurrencyAmount,
            string? cryptoCurrencyDepositAddress,
            int? cryptoCurrencyOptionEnumId,
            long? walletFundingRequestId)
        {
            this.CryptoCurrencyAmount = cryptoCurrencyAmount;
            this.CryptoCurrencyDepositAddress = cryptoCurrencyDepositAddress;
            this.CryptoCurrencyOptionEnumId = cryptoCurrencyOptionEnumId;
            this.WalletFundingRequestId = walletFundingRequestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletFundingRequestForCreateResponseDto2" /> class.
        /// </summary>
        public WalletFundingRequestForCreateResponseDto2()
        {
        }
    }
}