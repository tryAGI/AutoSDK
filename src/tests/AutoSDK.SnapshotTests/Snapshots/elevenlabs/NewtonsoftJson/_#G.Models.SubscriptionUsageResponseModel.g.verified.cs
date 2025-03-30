//HintName: G.Models.SubscriptionUsageResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriptionUsageResponseModel
    {
        /// <summary>
        /// The rollover credits quota.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rollover_credits_quota", Required = global::Newtonsoft.Json.Required.Always)]
        public int RolloverCreditsQuota { get; set; } = default!;

        /// <summary>
        /// The subscription cycle credits quota.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subscription_cycle_credits_quota", Required = global::Newtonsoft.Json.Required.Always)]
        public int SubscriptionCycleCreditsQuota { get; set; } = default!;

        /// <summary>
        /// The manually gifted credits quota.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manually_gifted_credits_quota", Required = global::Newtonsoft.Json.Required.Always)]
        public int ManuallyGiftedCreditsQuota { get; set; } = default!;

        /// <summary>
        /// The rollover credits used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rollover_credits_used", Required = global::Newtonsoft.Json.Required.Always)]
        public int RolloverCreditsUsed { get; set; } = default!;

        /// <summary>
        /// The subscription cycle credits used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subscription_cycle_credits_used", Required = global::Newtonsoft.Json.Required.Always)]
        public int SubscriptionCycleCreditsUsed { get; set; } = default!;

        /// <summary>
        /// The manually gifted credits used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("manually_gifted_credits_used", Required = global::Newtonsoft.Json.Required.Always)]
        public int ManuallyGiftedCreditsUsed { get; set; } = default!;

        /// <summary>
        /// The paid usage based credits used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("paid_usage_based_credits_used", Required = global::Newtonsoft.Json.Required.Always)]
        public int PaidUsageBasedCreditsUsed { get; set; } = default!;

        /// <summary>
        /// The actual reported credits.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("actual_reported_credits", Required = global::Newtonsoft.Json.Required.Always)]
        public int ActualReportedCredits { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionUsageResponseModel" /> class.
        /// </summary>
        /// <param name="rolloverCreditsQuota">
        /// The rollover credits quota.
        /// </param>
        /// <param name="subscriptionCycleCreditsQuota">
        /// The subscription cycle credits quota.
        /// </param>
        /// <param name="manuallyGiftedCreditsQuota">
        /// The manually gifted credits quota.
        /// </param>
        /// <param name="rolloverCreditsUsed">
        /// The rollover credits used.
        /// </param>
        /// <param name="subscriptionCycleCreditsUsed">
        /// The subscription cycle credits used.
        /// </param>
        /// <param name="manuallyGiftedCreditsUsed">
        /// The manually gifted credits used.
        /// </param>
        /// <param name="paidUsageBasedCreditsUsed">
        /// The paid usage based credits used.
        /// </param>
        /// <param name="actualReportedCredits">
        /// The actual reported credits.
        /// </param>
        public SubscriptionUsageResponseModel(
            int rolloverCreditsQuota,
            int subscriptionCycleCreditsQuota,
            int manuallyGiftedCreditsQuota,
            int rolloverCreditsUsed,
            int subscriptionCycleCreditsUsed,
            int manuallyGiftedCreditsUsed,
            int paidUsageBasedCreditsUsed,
            int actualReportedCredits)
        {
            this.RolloverCreditsQuota = rolloverCreditsQuota;
            this.SubscriptionCycleCreditsQuota = subscriptionCycleCreditsQuota;
            this.ManuallyGiftedCreditsQuota = manuallyGiftedCreditsQuota;
            this.RolloverCreditsUsed = rolloverCreditsUsed;
            this.SubscriptionCycleCreditsUsed = subscriptionCycleCreditsUsed;
            this.ManuallyGiftedCreditsUsed = manuallyGiftedCreditsUsed;
            this.PaidUsageBasedCreditsUsed = paidUsageBasedCreditsUsed;
            this.ActualReportedCredits = actualReportedCredits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionUsageResponseModel" /> class.
        /// </summary>
        public SubscriptionUsageResponseModel()
        {
        }
    }
}