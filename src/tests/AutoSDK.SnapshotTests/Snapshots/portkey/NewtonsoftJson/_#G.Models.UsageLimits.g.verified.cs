//HintName: G.Models.UsageLimits.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"credit_limit":10,"periodic_reset":"monthly","alert_threshold":8}
    /// </summary>
    public sealed partial class UsageLimits
    {
        /// <summary>
        /// Credit Limit. Used for tracking usage<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("credit_limit")]
        public int? CreditLimit { get; set; }

        /// <summary>
        /// Type of credit limit
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.UsageLimitsTypeJsonConverter))]
        public global::G.UsageLimitsType? Type { get; set; }

        /// <summary>
        /// Alert Threshold. Used for alerting when usage reaches more than this<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alert_threshold")]
        public int? AlertThreshold { get; set; }

        /// <summary>
        /// Reset the usage periodically.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("periodic_reset")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.UsageLimitsPeriodicResetJsonConverter))]
        public global::G.UsageLimitsPeriodicReset? PeriodicReset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageLimits" /> class.
        /// </summary>
        /// <param name="creditLimit">
        /// Credit Limit. Used for tracking usage<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="type">
        /// Type of credit limit
        /// </param>
        /// <param name="alertThreshold">
        /// Alert Threshold. Used for alerting when usage reaches more than this<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="periodicReset">
        /// Reset the usage periodically.
        /// </param>
        public UsageLimits(
            int? creditLimit,
            global::G.UsageLimitsType? type,
            int? alertThreshold,
            global::G.UsageLimitsPeriodicReset? periodicReset)
        {
            this.CreditLimit = creditLimit;
            this.Type = type;
            this.AlertThreshold = alertThreshold;
            this.PeriodicReset = periodicReset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageLimits" /> class.
        /// </summary>
        public UsageLimits()
        {
        }
    }
}