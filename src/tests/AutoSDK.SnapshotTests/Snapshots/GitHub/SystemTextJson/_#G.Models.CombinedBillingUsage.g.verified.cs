//HintName: G.Models.CombinedBillingUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CombinedBillingUsage
    {
        /// <summary>
        /// Numbers of days left in billing cycle.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("days_left_in_billing_cycle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DaysLeftInBillingCycle { get; set; }

        /// <summary>
        /// Estimated storage space (GB) used in billing cycle.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_paid_storage_for_month")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EstimatedPaidStorageForMonth { get; set; }

        /// <summary>
        /// Estimated sum of free and paid storage space (GB) used in billing cycle.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_storage_for_month")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EstimatedStorageForMonth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}