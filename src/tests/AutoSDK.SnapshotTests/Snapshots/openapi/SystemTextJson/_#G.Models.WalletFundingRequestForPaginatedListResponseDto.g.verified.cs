//HintName: G.Models.WalletFundingRequestForPaginatedListResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WalletFundingRequestForPaginatedListResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("countryName")]
        public string? CountryName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orderId")]
        public long? OrderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orderStatusEnum")]
        public int? OrderStatusEnum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productTypeEnumId")]
        public int? ProductTypeEnumId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amountUSD")]
        public double? AmountUSD { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversionRate")]
        public double? ConversionRate { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("receivedAmountCrypto")]
        public double? ReceivedAmountCrypto { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("receivedDate")]
        public global::System.DateTime? ReceivedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("submittedDate")]
        public global::System.DateTime? SubmittedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public long? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("walletTypeIdEnum")]
        public long? WalletTypeIdEnum { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletFundingRequestForPaginatedListResponseDto" /> class.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="countryName"></param>
        /// <param name="id"></param>
        /// <param name="orderId"></param>
        /// <param name="orderStatusEnum"></param>
        /// <param name="productTypeEnumId"></param>
        /// <param name="amountUSD"></param>
        /// <param name="conversionRate"></param>
        /// <param name="cryptoCurrencyDepositAddress"></param>
        /// <param name="cryptoCurrencyOptionEnumId"></param>
        /// <param name="receivedAmountCrypto"></param>
        /// <param name="receivedDate"></param>
        /// <param name="submittedDate"></param>
        /// <param name="userId"></param>
        /// <param name="walletTypeIdEnum"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WalletFundingRequestForPaginatedListResponseDto(
            string? username,
            string? countryName,
            long? id,
            long? orderId,
            int? orderStatusEnum,
            int? productTypeEnumId,
            double? amountUSD,
            double? conversionRate,
            string? cryptoCurrencyDepositAddress,
            int? cryptoCurrencyOptionEnumId,
            double? receivedAmountCrypto,
            global::System.DateTime? receivedDate,
            global::System.DateTime? submittedDate,
            long? userId,
            long? walletTypeIdEnum)
        {
            this.Username = username;
            this.CountryName = countryName;
            this.Id = id;
            this.OrderId = orderId;
            this.OrderStatusEnum = orderStatusEnum;
            this.ProductTypeEnumId = productTypeEnumId;
            this.AmountUSD = amountUSD;
            this.ConversionRate = conversionRate;
            this.CryptoCurrencyDepositAddress = cryptoCurrencyDepositAddress;
            this.CryptoCurrencyOptionEnumId = cryptoCurrencyOptionEnumId;
            this.ReceivedAmountCrypto = receivedAmountCrypto;
            this.ReceivedDate = receivedDate;
            this.SubmittedDate = submittedDate;
            this.UserId = userId;
            this.WalletTypeIdEnum = walletTypeIdEnum;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletFundingRequestForPaginatedListResponseDto" /> class.
        /// </summary>
        public WalletFundingRequestForPaginatedListResponseDto()
        {
        }
    }
}