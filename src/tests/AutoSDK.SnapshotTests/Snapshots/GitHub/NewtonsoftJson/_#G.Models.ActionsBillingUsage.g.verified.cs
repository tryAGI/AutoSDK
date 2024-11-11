//HintName: G.Models.ActionsBillingUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ActionsBillingUsage
    {
        /// <summary>
        /// The sum of the free and paid GitHub Actions minutes used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_minutes_used", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalMinutesUsed { get; set; } = default!;

        /// <summary>
        /// The total paid GitHub Actions minutes used.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_paid_minutes_used", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalPaidMinutesUsed { get; set; } = default!;

        /// <summary>
        /// The amount of free GitHub Actions minutes available.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("included_minutes", Required = global::Newtonsoft.Json.Required.Always)]
        public int IncludedMinutes { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("minutes_used_breakdown", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ActionsBillingUsageMinutesUsedBreakdown MinutesUsedBreakdown { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsBillingUsage" /> class.
        /// </summary>
        /// <param name="totalMinutesUsed">
        /// The sum of the free and paid GitHub Actions minutes used.
        /// </param>
        /// <param name="totalPaidMinutesUsed">
        /// The total paid GitHub Actions minutes used.
        /// </param>
        /// <param name="includedMinutes">
        /// The amount of free GitHub Actions minutes available.
        /// </param>
        /// <param name="minutesUsedBreakdown"></param>
        public ActionsBillingUsage(
            int totalMinutesUsed,
            int totalPaidMinutesUsed,
            int includedMinutes,
            global::G.ActionsBillingUsageMinutesUsedBreakdown minutesUsedBreakdown)
        {
            this.TotalMinutesUsed = totalMinutesUsed;
            this.TotalPaidMinutesUsed = totalPaidMinutesUsed;
            this.IncludedMinutes = includedMinutes;
            this.MinutesUsedBreakdown = minutesUsedBreakdown ?? throw new global::System.ArgumentNullException(nameof(minutesUsedBreakdown));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsBillingUsage" /> class.
        /// </summary>
        public ActionsBillingUsage()
        {
        }
    }
}