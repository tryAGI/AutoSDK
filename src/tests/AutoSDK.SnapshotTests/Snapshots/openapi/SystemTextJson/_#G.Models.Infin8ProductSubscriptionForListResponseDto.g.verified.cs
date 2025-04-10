//HintName: G.Models.Infin8ProductSubscriptionForListResponseDto.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Infin8ProductSubscriptionForListResponseDto
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("infin8InvitationCode")]
        public string? Infin8InvitationCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("firstName")]
        public string? FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastName")]
        public string? LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("countryId")]
        public long? CountryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiryDate")]
        public global::System.DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purchasedByUsername")]
        public string? PurchasedByUsername { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promotionCode")]
        public string? PromotionCode { get; set; }

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
        /// Initializes a new instance of the <see cref="Infin8ProductSubscriptionForListResponseDto" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="infin8InvitationCode"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="countryId"></param>
        /// <param name="expiryDate"></param>
        /// <param name="purchasedByUsername"></param>
        /// <param name="promotionCode"></param>
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
        public Infin8ProductSubscriptionForListResponseDto(
            long? id,
            string? infin8InvitationCode,
            string? firstName,
            string? lastName,
            string? username,
            string? email,
            long? countryId,
            global::System.DateTime? expiryDate,
            string? purchasedByUsername,
            string? promotionCode,
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
            this.Infin8InvitationCode = infin8InvitationCode;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Username = username;
            this.Email = email;
            this.CountryId = countryId;
            this.ExpiryDate = expiryDate;
            this.PurchasedByUsername = purchasedByUsername;
            this.PromotionCode = promotionCode;
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
        /// Initializes a new instance of the <see cref="Infin8ProductSubscriptionForListResponseDto" /> class.
        /// </summary>
        public Infin8ProductSubscriptionForListResponseDto()
        {
        }
    }
}