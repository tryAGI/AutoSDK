//HintName: G.Models.ProductSubscriptionForListResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProductSubscriptionForListResponseDto
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
        [global::System.Text.Json.Serialization.JsonPropertyName("purchasedByUsername")]
        public string? PurchasedByUsername { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("networkVolume")]
        public double? NetworkVolume { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productTypeEnumId")]
        public int? ProductTypeEnumId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rewardCommissionEarnt")]
        public double? RewardCommissionEarnt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public long? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public global::System.DateTime? Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price")]
        public double? Price { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("salePrice")]
        public double? SalePrice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productId")]
        public long? ProductId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("productName")]
        public string? ProductName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compoundingStatusEnumId")]
        public int? CompoundingStatusEnumId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purchasedByUserId")]
        public long? PurchasedByUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appPurchase")]
        public bool? AppPurchase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoRenew")]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSubscriptionForListResponseDto" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="username"></param>
        /// <param name="purchasedByUsername"></param>
        /// <param name="country"></param>
        /// <param name="networkVolume"></param>
        /// <param name="productTypeEnumId"></param>
        /// <param name="rewardCommissionEarnt"></param>
        /// <param name="userId"></param>
        /// <param name="timestamp"></param>
        /// <param name="price"></param>
        /// <param name="salePrice"></param>
        /// <param name="productId"></param>
        /// <param name="productName"></param>
        /// <param name="compoundingStatusEnumId"></param>
        /// <param name="purchasedByUserId"></param>
        /// <param name="appPurchase"></param>
        /// <param name="autoRenew"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProductSubscriptionForListResponseDto(
            long? id,
            string? username,
            string? purchasedByUsername,
            string? country,
            double? networkVolume,
            int? productTypeEnumId,
            double? rewardCommissionEarnt,
            long? userId,
            global::System.DateTime? timestamp,
            double? price,
            double? salePrice,
            long? productId,
            string? productName,
            int? compoundingStatusEnumId,
            long? purchasedByUserId,
            bool? appPurchase,
            bool? autoRenew)
        {
            this.Id = id;
            this.Username = username;
            this.PurchasedByUsername = purchasedByUsername;
            this.Country = country;
            this.NetworkVolume = networkVolume;
            this.ProductTypeEnumId = productTypeEnumId;
            this.RewardCommissionEarnt = rewardCommissionEarnt;
            this.UserId = userId;
            this.Timestamp = timestamp;
            this.Price = price;
            this.SalePrice = salePrice;
            this.ProductId = productId;
            this.ProductName = productName;
            this.CompoundingStatusEnumId = compoundingStatusEnumId;
            this.PurchasedByUserId = purchasedByUserId;
            this.AppPurchase = appPurchase;
            this.AutoRenew = autoRenew;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductSubscriptionForListResponseDto" /> class.
        /// </summary>
        public ProductSubscriptionForListResponseDto()
        {
        }
    }
}