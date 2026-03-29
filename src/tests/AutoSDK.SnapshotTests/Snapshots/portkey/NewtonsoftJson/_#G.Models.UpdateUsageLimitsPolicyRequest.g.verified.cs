//HintName: G.Models.UpdateUsageLimitsPolicyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateUsageLimitsPolicyRequest
    {
        /// <summary>
        /// Policy name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Maximum usage allowed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credit_limit")]
        public double? CreditLimit { get; set; }

        /// <summary>
        /// Threshold at which to send alerts. Must be less than credit_limit.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alert_threshold")]
        public double? AlertThreshold { get; set; }

        /// <summary>
        /// Reset period. Set to null to remove periodic reset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("periodic_reset")]
        public global::G.UpdateUsageLimitsPolicyRequestPeriodicReset? PeriodicReset { get; set; }

        /// <summary>
        /// Reset usage for a specific value key (e.g., API key). This will reset the usage counter for that key to 0.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reset_usage_for_value")]
        public string? ResetUsageForValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUsageLimitsPolicyRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Policy name
        /// </param>
        /// <param name="creditLimit">
        /// Maximum usage allowed
        /// </param>
        /// <param name="alertThreshold">
        /// Threshold at which to send alerts. Must be less than credit_limit.
        /// </param>
        /// <param name="periodicReset">
        /// Reset period. Set to null to remove periodic reset.
        /// </param>
        /// <param name="resetUsageForValue">
        /// Reset usage for a specific value key (e.g., API key). This will reset the usage counter for that key to 0.
        /// </param>
        public UpdateUsageLimitsPolicyRequest(
            string? name,
            double? creditLimit,
            double? alertThreshold,
            global::G.UpdateUsageLimitsPolicyRequestPeriodicReset? periodicReset,
            string? resetUsageForValue)
        {
            this.Name = name;
            this.CreditLimit = creditLimit;
            this.AlertThreshold = alertThreshold;
            this.PeriodicReset = periodicReset;
            this.ResetUsageForValue = resetUsageForValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateUsageLimitsPolicyRequest" /> class.
        /// </summary>
        public UpdateUsageLimitsPolicyRequest()
        {
        }
    }
}