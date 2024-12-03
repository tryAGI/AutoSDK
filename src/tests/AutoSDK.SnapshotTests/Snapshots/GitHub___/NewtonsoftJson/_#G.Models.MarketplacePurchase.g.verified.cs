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
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("login", Required = global::Newtonsoft.Json.Required.Always)]
        public string Login { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_billing_email")]
        public string? OrganizationBillingEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("marketplace_pending_change")]
        public global::G.MarketplacePurchaseMarketplacePendingChange? MarketplacePendingChange { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("marketplace_purchase", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MarketplacePurchaseMarketplacePurchase1 MarketplacePurchase1 { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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