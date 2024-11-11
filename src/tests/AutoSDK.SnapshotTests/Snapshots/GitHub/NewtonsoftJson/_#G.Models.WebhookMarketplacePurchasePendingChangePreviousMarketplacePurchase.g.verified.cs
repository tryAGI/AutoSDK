//HintName: G.Models.WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchase.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchase
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("account", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchaseAccount Account { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("billing_cycle", Required = global::Newtonsoft.Json.Required.Always)]
        public string BillingCycle { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("free_trial_ends_on", Required = global::Newtonsoft.Json.Required.Always)]
        public string? FreeTrialEndsOn { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_billing_date")]
        public string? NextBillingDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("on_free_trial", Required = global::Newtonsoft.Json.Required.Always)]
        public bool OnFreeTrial { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("plan", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchasePlan Plan { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unit_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int UnitCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchase" /> class.
        /// </summary>
        /// <param name="account"></param>
        /// <param name="billingCycle"></param>
        /// <param name="freeTrialEndsOn"></param>
        /// <param name="nextBillingDate"></param>
        /// <param name="onFreeTrial"></param>
        /// <param name="plan"></param>
        /// <param name="unitCount"></param>
        public WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchase(
            global::G.WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchaseAccount account,
            string billingCycle,
            string? freeTrialEndsOn,
            bool onFreeTrial,
            global::G.WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchasePlan plan,
            int unitCount,
            string? nextBillingDate)
        {
            this.Account = account ?? throw new global::System.ArgumentNullException(nameof(account));
            this.BillingCycle = billingCycle ?? throw new global::System.ArgumentNullException(nameof(billingCycle));
            this.FreeTrialEndsOn = freeTrialEndsOn ?? throw new global::System.ArgumentNullException(nameof(freeTrialEndsOn));
            this.OnFreeTrial = onFreeTrial;
            this.Plan = plan ?? throw new global::System.ArgumentNullException(nameof(plan));
            this.UnitCount = unitCount;
            this.NextBillingDate = nextBillingDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchase" /> class.
        /// </summary>
        public WebhookMarketplacePurchasePendingChangePreviousMarketplacePurchase()
        {
        }
    }
}