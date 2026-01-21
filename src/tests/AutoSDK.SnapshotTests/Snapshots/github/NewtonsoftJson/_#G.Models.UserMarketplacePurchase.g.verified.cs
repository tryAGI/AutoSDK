//HintName: G.Models.UserMarketplacePurchase.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// User Marketplace Purchase
    /// </summary>
    public sealed partial class UserMarketplacePurchase
    {
        /// <summary>
        /// Example: monthly
        /// </summary>
        /// <example>monthly</example>
        [global::Newtonsoft.Json.JsonProperty("billing_cycle", Required = global::Newtonsoft.Json.Required.Always)]
        public string BillingCycle { get; set; } = default!;

        /// <summary>
        /// Example: 2017-11-11T00:00:00Z
        /// </summary>
        /// <example>2017-11-11T00:00:00Z</example>
        [global::Newtonsoft.Json.JsonProperty("next_billing_date", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? NextBillingDate { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unit_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int? UnitCount { get; set; } = default!;

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("on_free_trial", Required = global::Newtonsoft.Json.Required.Always)]
        public bool OnFreeTrial { get; set; } = default!;

        /// <summary>
        /// Example: 2017-11-11T00:00:00Z
        /// </summary>
        /// <example>2017-11-11T00:00:00Z</example>
        [global::Newtonsoft.Json.JsonProperty("free_trial_ends_on", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? FreeTrialEndsOn { get; set; } = default!;

        /// <summary>
        /// Example: 2017-11-02T01:12:12Z
        /// </summary>
        /// <example>2017-11-02T01:12:12Z</example>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime? UpdatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("account", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MarketplaceAccount Account { get; set; } = default!;

        /// <summary>
        /// Marketplace Listing Plan
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("plan", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MarketplaceListingPlan Plan { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMarketplacePurchase" /> class.
        /// </summary>
        /// <param name="billingCycle">
        /// Example: monthly
        /// </param>
        /// <param name="nextBillingDate">
        /// Example: 2017-11-11T00:00:00Z
        /// </param>
        /// <param name="unitCount"></param>
        /// <param name="onFreeTrial">
        /// Example: true
        /// </param>
        /// <param name="freeTrialEndsOn">
        /// Example: 2017-11-11T00:00:00Z
        /// </param>
        /// <param name="updatedAt">
        /// Example: 2017-11-02T01:12:12Z
        /// </param>
        /// <param name="account"></param>
        /// <param name="plan">
        /// Marketplace Listing Plan
        /// </param>
        public UserMarketplacePurchase(
            string billingCycle,
            global::System.DateTime? nextBillingDate,
            int? unitCount,
            bool onFreeTrial,
            global::System.DateTime? freeTrialEndsOn,
            global::System.DateTime? updatedAt,
            global::G.MarketplaceAccount account,
            global::G.MarketplaceListingPlan plan)
        {
            this.BillingCycle = billingCycle ?? throw new global::System.ArgumentNullException(nameof(billingCycle));
            this.NextBillingDate = nextBillingDate;
            this.UnitCount = unitCount;
            this.OnFreeTrial = onFreeTrial;
            this.FreeTrialEndsOn = freeTrialEndsOn;
            this.UpdatedAt = updatedAt;
            this.Account = account ?? throw new global::System.ArgumentNullException(nameof(account));
            this.Plan = plan ?? throw new global::System.ArgumentNullException(nameof(plan));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMarketplacePurchase" /> class.
        /// </summary>
        public UserMarketplacePurchase()
        {
        }
    }
}