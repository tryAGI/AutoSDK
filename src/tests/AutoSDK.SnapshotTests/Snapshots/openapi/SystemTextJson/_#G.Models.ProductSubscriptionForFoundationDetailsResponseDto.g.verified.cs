//HintName: G.Models.ProductSubscriptionForFoundationDetailsResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProductSubscriptionForFoundationDetailsResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalFoundationSalePrice")]
        public double? TotalFoundationSalePrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalUserFoundationSalePrice")]
        public double? TotalUserFoundationSalePrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userDonationLevelEnumId")]
        public int? UserDonationLevelEnumId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bronze")]
        public double? Bronze { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("silver")]
        public double? Silver { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gold")]
        public double? Gold { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platinum")]
        public double? Platinum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("onPurchaseDonationAmount")]
        public double? OnPurchaseDonationAmount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSubscriptionForFoundationDetailsResponseDto" /> class.
        /// </summary>
        /// <param name="totalFoundationSalePrice"></param>
        /// <param name="totalUserFoundationSalePrice"></param>
        /// <param name="userDonationLevelEnumId"></param>
        /// <param name="bronze"></param>
        /// <param name="silver"></param>
        /// <param name="gold"></param>
        /// <param name="platinum"></param>
        /// <param name="onPurchaseDonationAmount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProductSubscriptionForFoundationDetailsResponseDto(
            double? totalFoundationSalePrice,
            double? totalUserFoundationSalePrice,
            int? userDonationLevelEnumId,
            double? bronze,
            double? silver,
            double? gold,
            double? platinum,
            double? onPurchaseDonationAmount)
        {
            this.TotalFoundationSalePrice = totalFoundationSalePrice;
            this.TotalUserFoundationSalePrice = totalUserFoundationSalePrice;
            this.UserDonationLevelEnumId = userDonationLevelEnumId;
            this.Bronze = bronze;
            this.Silver = silver;
            this.Gold = gold;
            this.Platinum = platinum;
            this.OnPurchaseDonationAmount = onPurchaseDonationAmount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSubscriptionForFoundationDetailsResponseDto" /> class.
        /// </summary>
        public ProductSubscriptionForFoundationDetailsResponseDto()
        {
        }
    }
}