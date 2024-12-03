//HintName: G.Models.MarketplacePurchase.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Marketplace Purchase
    /// </summary>
    public sealed partial class MarketplacePurchase
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Login { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_billing_email")]
        public string? OrganizationBillingEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("marketplace_pending_change")]
        public global::G.MarketplacePurchaseMarketplacePendingChange? MarketplacePendingChange { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("marketplace_purchase")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MarketplacePurchaseMarketplacePurchase1 MarketplacePurchase1 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplacePurchase" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="login"></param>
        /// <param name="organizationBillingEmail"></param>
        /// <param name="email"></param>
        /// <param name="marketplacePendingChange"></param>
        /// <param name="marketplacePurchase1"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public MarketplacePurchase(
            string url,
            string type,
            int id,
            string login,
            global::G.MarketplacePurchaseMarketplacePurchase1 marketplacePurchase1,
            string? organizationBillingEmail,
            string? email,
            global::G.MarketplacePurchaseMarketplacePendingChange? marketplacePendingChange)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Id = id;
            this.Login = login ?? throw new global::System.ArgumentNullException(nameof(login));
            this.MarketplacePurchase1 = marketplacePurchase1 ?? throw new global::System.ArgumentNullException(nameof(marketplacePurchase1));
            this.OrganizationBillingEmail = organizationBillingEmail;
            this.Email = email;
            this.MarketplacePendingChange = marketplacePendingChange;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplacePurchase" /> class.
        /// </summary>
        public MarketplacePurchase()
        {
        }
    }
}