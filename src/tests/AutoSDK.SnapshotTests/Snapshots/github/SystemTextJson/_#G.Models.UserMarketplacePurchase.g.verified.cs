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
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_cycle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BillingCycle { get; set; }

        /// <summary>
        /// Example: 2017-11-11T00:00:00Z
        /// </summary>
        /// <example>2017-11-11T00:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_billing_date")]
        public global::System.DateTime? NextBillingDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit_count")]
        public int? UnitCount { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_free_trial")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool OnFreeTrial { get; set; }

        /// <summary>
        /// Example: 2017-11-11T00:00:00Z
        /// </summary>
        /// <example>2017-11-11T00:00:00Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("free_trial_ends_on")]
        public global::System.DateTime? FreeTrialEndsOn { get; set; }

        /// <summary>
        /// Example: 2017-11-02T01:12:12Z
        /// </summary>
        /// <example>2017-11-02T01:12:12Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MarketplaceAccount Account { get; set; }

        /// <summary>
        /// Marketplace Listing Plan
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MarketplaceListingPlan Plan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserMarketplacePurchase" /> class.
        /// </summary>
        /// <param name="billingCycle">
        /// Example: monthly
        /// </param>
        /// <param name="onFreeTrial">
        /// Example: true
        /// </param>
        /// <param name="account"></param>
        /// <param name="plan">
        /// Marketplace Listing Plan
        /// </param>
        /// <param name="nextBillingDate">
        /// Example: 2017-11-11T00:00:00Z
        /// </param>
        /// <param name="unitCount"></param>
        /// <param name="freeTrialEndsOn">
        /// Example: 2017-11-11T00:00:00Z
        /// </param>
        /// <param name="updatedAt">
        /// Example: 2017-11-02T01:12:12Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserMarketplacePurchase(
            string billingCycle,
            bool onFreeTrial,
            global::G.MarketplaceAccount account,
            global::G.MarketplaceListingPlan plan,
            global::System.DateTime? nextBillingDate,
            int? unitCount,
            global::System.DateTime? freeTrialEndsOn,
            global::System.DateTime? updatedAt)
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