//HintName: G.Models.FundWithdrawalRequestForListResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FundWithdrawalRequestForListResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customerBTCWithdrawalAddress")]
        public string? CustomerBTCWithdrawalAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transactionGroupId")]
        public global::System.Guid? TransactionGroupId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("walletTypeEnumId")]
        public int? WalletTypeEnumId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("walletType")]
        public string? WalletType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("withdrawalAddressEnumName")]
        public string? WithdrawalAddressEnumName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public long? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestedAmount")]
        public double? RequestedAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adminCharge")]
        public double? AdminCharge { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestDate")]
        public global::System.DateTime? RequestDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processedDate")]
        public global::System.DateTime? ProcessedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("withdrawalStatusIdEnum")]
        public int? WithdrawalStatusIdEnum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("btcWithdrawalAddress")]
        public string? BtcWithdrawalAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usdtWithdrawalAddress")]
        public string? UsdtWithdrawalAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tusdtWithdrawalAddress")]
        public string? TusdtWithdrawalAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cebotWithdrawalAddress")]
        public string? CebotWithdrawalAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("withdrawalAddressIdEnum")]
        public int? WithdrawalAddressIdEnum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("donationAmount")]
        public double? DonationAmount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FundWithdrawalRequestForListResponseDto" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <param name="customerBTCWithdrawalAddress"></param>
        /// <param name="country"></param>
        /// <param name="transactionGroupId"></param>
        /// <param name="walletTypeEnumId"></param>
        /// <param name="walletType"></param>
        /// <param name="withdrawalAddressEnumName"></param>
        /// <param name="userId"></param>
        /// <param name="requestedAmount"></param>
        /// <param name="adminCharge"></param>
        /// <param name="requestDate"></param>
        /// <param name="processedDate"></param>
        /// <param name="withdrawalStatusIdEnum"></param>
        /// <param name="btcWithdrawalAddress"></param>
        /// <param name="usdtWithdrawalAddress"></param>
        /// <param name="tusdtWithdrawalAddress"></param>
        /// <param name="cebotWithdrawalAddress"></param>
        /// <param name="withdrawalAddressIdEnum"></param>
        /// <param name="donationAmount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FundWithdrawalRequestForListResponseDto(
            long? id,
            string? username,
            string? customerBTCWithdrawalAddress,
            string? country,
            global::System.Guid? transactionGroupId,
            int? walletTypeEnumId,
            string? walletType,
            string? withdrawalAddressEnumName,
            long? userId,
            double? requestedAmount,
            double? adminCharge,
            global::System.DateTime? requestDate,
            global::System.DateTime? processedDate,
            int? withdrawalStatusIdEnum,
            string? btcWithdrawalAddress,
            string? usdtWithdrawalAddress,
            string? tusdtWithdrawalAddress,
            string? cebotWithdrawalAddress,
            int? withdrawalAddressIdEnum,
            double? donationAmount)
        {
            this.Id = id;
            this.Username = username;
            this.CustomerBTCWithdrawalAddress = customerBTCWithdrawalAddress;
            this.Country = country;
            this.TransactionGroupId = transactionGroupId;
            this.WalletTypeEnumId = walletTypeEnumId;
            this.WalletType = walletType;
            this.WithdrawalAddressEnumName = withdrawalAddressEnumName;
            this.UserId = userId;
            this.RequestedAmount = requestedAmount;
            this.AdminCharge = adminCharge;
            this.RequestDate = requestDate;
            this.ProcessedDate = processedDate;
            this.WithdrawalStatusIdEnum = withdrawalStatusIdEnum;
            this.BtcWithdrawalAddress = btcWithdrawalAddress;
            this.UsdtWithdrawalAddress = usdtWithdrawalAddress;
            this.TusdtWithdrawalAddress = tusdtWithdrawalAddress;
            this.CebotWithdrawalAddress = cebotWithdrawalAddress;
            this.WithdrawalAddressIdEnum = withdrawalAddressIdEnum;
            this.DonationAmount = donationAmount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FundWithdrawalRequestForListResponseDto" /> class.
        /// </summary>
        public FundWithdrawalRequestForListResponseDto()
        {
        }
    }
}