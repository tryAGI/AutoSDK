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
        public required ActionsBillingUsageMinutesUsedBreakdown MinutesUsedBreakdown { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}