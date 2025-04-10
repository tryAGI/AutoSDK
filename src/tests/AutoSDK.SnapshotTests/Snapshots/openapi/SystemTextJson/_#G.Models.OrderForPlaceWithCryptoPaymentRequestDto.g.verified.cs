//HintName: G.Models.OrderForPlaceWithCryptoPaymentRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrderForPlaceWithCryptoPaymentRequestDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cryptoOptionEnumId")]
        public int? CryptoOptionEnumId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shopModeIsInfin8Direct")]
        public bool? ShopModeIsInfin8Direct { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shopModeIsBlackCard")]
        public bool? ShopModeIsBlackCard { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("walletTypeEnumId")]
        public int? WalletTypeEnumId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public long? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lineItems")]
        public global::System.Collections.Generic.IList<global::G.OrderLineItemDto>? LineItems { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appPurchase")]
        public bool? AppPurchase { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderForPlaceWithCryptoPaymentRequestDto" /> class.
        /// </summary>
        /// <param name="cryptoOptionEnumId"></param>
        /// <param name="shopModeIsInfin8Direct"></param>
        /// <param name="shopModeIsBlackCard"></param>
        /// <param name="walletTypeEnumId"></param>
        /// <param name="userId"></param>
        /// <param name="lineItems"></param>
        /// <param name="appPurchase"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrderForPlaceWithCryptoPaymentRequestDto(
            int? cryptoOptionEnumId,
            bool? shopModeIsInfin8Direct,
            bool? shopModeIsBlackCard,
            int? walletTypeEnumId,
            long? userId,
            global::System.Collections.Generic.IList<global::G.OrderLineItemDto>? lineItems,
            bool? appPurchase)
        {
            this.CryptoOptionEnumId = cryptoOptionEnumId;
            this.ShopModeIsInfin8Direct = shopModeIsInfin8Direct;
            this.ShopModeIsBlackCard = shopModeIsBlackCard;
            this.WalletTypeEnumId = walletTypeEnumId;
            this.UserId = userId;
            this.LineItems = lineItems;
            this.AppPurchase = appPurchase;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderForPlaceWithCryptoPaymentRequestDto" /> class.
        /// </summary>
        public OrderForPlaceWithCryptoPaymentRequestDto()
        {
        }
    }
}