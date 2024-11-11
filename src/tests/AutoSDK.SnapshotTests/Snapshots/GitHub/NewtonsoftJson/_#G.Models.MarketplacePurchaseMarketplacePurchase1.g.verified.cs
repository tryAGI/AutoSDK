//HintName: G.Models.MarketplacePurchaseMarketplacePurchase1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MarketplacePurchaseMarketplacePurchase1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("billing_cycle")]
        public string? BillingCycle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_billing_date")]
        public string? NextBillingDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_installed")]
        public bool? IsInstalled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unit_count")]
        public int? UnitCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("on_free_trial")]
        public bool? OnFreeTrial { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("free_trial_ends_on")]
        public string? FreeTrialEndsOn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Marketplace Listing Plan
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("plan")]
        public global::G.MarketplaceListingPlan? Plan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplacePurchaseMarketplacePurchase1" /> class.
        /// </summary>
        /// <param name="billingCycle"></param>
        /// <param name="nextBillingDate"></param>
        /// <param name="isInstalled"></param>
        /// <param name="unitCount"></param>
        /// <param name="onFreeTrial"></param>
        /// <param name="freeTrialEndsOn"></param>
        /// <param name="updatedAt"></param>
        /// <param name="plan">
        /// Marketplace Listing Plan
        /// </param>
        public MarketplacePurchaseMarketplacePurchase1(
            string? billingCycle,
            string? nextBillingDate,
            bool? isInstalled,
            int? unitCount,
            bool? onFreeTrial,
            string? freeTrialEndsOn,
            string? updatedAt,
            global::G.MarketplaceListingPlan? plan)
        {
            this.BillingCycle = billingCycle;
            this.NextBillingDate = nextBillingDate;
            this.IsInstalled = isInstalled;
            this.UnitCount = unitCount;
            this.OnFreeTrial = onFreeTrial;
            this.FreeTrialEndsOn = freeTrialEndsOn;
            this.UpdatedAt = updatedAt;
            this.Plan = plan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplacePurchaseMarketplacePurchase1" /> class.
        /// </summary>
        public MarketplacePurchaseMarketplacePurchase1()
        {
        }
    }
}