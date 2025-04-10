//HintName: G.Models.WalletFundingRequestForCreateRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WalletFundingRequestForCreateRequestDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public long? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amountInFiatCurrency")]
        public double? AmountInFiatCurrency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fiatCurrencyCode")]
        public string? FiatCurrencyCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cryptoCurrencyOptionEnumId")]
        public int? CryptoCurrencyOptionEnumId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orderId")]
        public long? OrderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transactionGroupId")]
        public global::System.Guid? TransactionGroupId { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isXTera")]
        public bool? IsXTera { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletFundingRequestForCreateRequestDto" /> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="amountInFiatCurrency"></param>
        /// <param name="fiatCurrencyCode"></param>
        /// <param name="cryptoCurrencyOptionEnumId"></param>
        /// <param name="orderId"></param>
        /// <param name="transactionGroupId"></param>
        /// <param name="isXTera">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WalletFundingRequestForCreateRequestDto(
            long? userId,
            double? amountInFiatCurrency,
            string? fiatCurrencyCode,
            int? cryptoCurrencyOptionEnumId,
            long? orderId,
            global::System.Guid? transactionGroupId,
            bool? isXTera)
        {
            this.UserId = userId;
            this.AmountInFiatCurrency = amountInFiatCurrency;
            this.FiatCurrencyCode = fiatCurrencyCode;
            this.CryptoCurrencyOptionEnumId = cryptoCurrencyOptionEnumId;
            this.OrderId = orderId;
            this.TransactionGroupId = transactionGroupId;
            this.IsXTera = isXTera;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletFundingRequestForCreateRequestDto" /> class.
        /// </summary>
        public WalletFundingRequestForCreateRequestDto()
        {
        }
    }
}