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
        [global::Newtonsoft.Json.JsonProperty("days_left_in_billing_cycle", Required = global::Newtonsoft.Json.Required.Always)]
        public int DaysLeftInBillingCycle { get; set; } = default!;

        /// <summary>
        /// Estimated storage space (GB) used in billing cycle.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("estimated_paid_storage_for_month", Required = global::Newtonsoft.Json.Required.Always)]
        public int EstimatedPaidStorageForMonth { get; set; } = default!;

        /// <summary>
        /// Estimated sum of free and paid storage space (GB) used in billing cycle.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("estimated_storage_for_month", Required = global::Newtonsoft.Json.Required.Always)]
        public int EstimatedStorageForMonth { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}