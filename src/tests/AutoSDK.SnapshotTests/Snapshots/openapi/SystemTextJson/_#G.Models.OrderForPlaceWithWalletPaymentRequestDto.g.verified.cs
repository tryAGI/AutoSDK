//HintName: G.Models.OrderForPlaceWithWalletPaymentRequestDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrderForPlaceWithWalletPaymentRequestDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("walletTypeEnumId")]
        public int? WalletTypeEnumId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shopModeIsInfin8Direct")]
        public bool? ShopModeIsInfin8Direct { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secondWalletTypeEnumId")]
        public int? SecondWalletTypeEnumId { get; set; }

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
        /// Initializes a new instance of the <see cref="OrderForPlaceWithWalletPaymentRequestDto" /> class.
        /// </summary>
        /// <param name="walletTypeEnumId"></param>
        /// <param name="shopModeIsInfin8Direct"></param>
        /// <param name="secondWalletTypeEnumId"></param>
        /// <param name="userId"></param>
        /// <param name="lineItems"></param>
        /// <param name="appPurchase"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrderForPlaceWithWalletPaymentRequestDto(
            int? walletTypeEnumId,
            bool? shopModeIsInfin8Direct,
            int? secondWalletTypeEnumId,
            long? userId,
            global::System.Collections.Generic.IList<global::G.OrderLineItemDto>? lineItems,
            bool? appPurchase)
        {
            this.WalletTypeEnumId = walletTypeEnumId;
            this.ShopModeIsInfin8Direct = shopModeIsInfin8Direct;
            this.SecondWalletTypeEnumId = secondWalletTypeEnumId;
            this.UserId = userId;
            this.LineItems = lineItems;
            this.AppPurchase = appPurchase;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderForPlaceWithWalletPaymentRequestDto" /> class.
        /// </summary>
        public OrderForPlaceWithWalletPaymentRequestDto()
        {
        }
    }
}