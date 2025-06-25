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
        [global::System.Text.Json.Serialization.JsonPropertyName("total_minutes_used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalMinutesUsed { get; set; }

        /// <summary>
        /// The total paid GitHub Actions minutes used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_paid_minutes_used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalPaidMinutesUsed { get; set; }

        /// <summary>
        /// The amount of free GitHub Actions minutes available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("included_minutes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int IncludedMinutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minutes_used_breakdown")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ActionsBillingUsageMinutesUsedBreakdown MinutesUsedBreakdown { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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