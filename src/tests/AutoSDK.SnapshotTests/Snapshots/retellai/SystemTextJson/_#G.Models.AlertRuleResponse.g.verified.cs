//HintName: G.Models.AlertRuleResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AlertRuleResponse
    {
        /// <summary>
        /// Unique identifier for the alert rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alert_rule_id")]
        public string? AlertRuleId { get; set; }

        /// <summary>
        /// Organization ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        public string? OrgId { get; set; }

        /// <summary>
        /// Name of the alert rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The metric type being monitored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AlertMetricTypeJsonConverter))]
        public global::G.AlertMetricType? MetricType { get; set; }

        /// <summary>
        /// Filter criteria for alert rules
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public global::G.AlertFilter? Filter { get; set; }

        /// <summary>
        /// Whether threshold is absolute or relative to previous period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AlertRuleResponseThresholdTypeJsonConverter))]
        public global::G.AlertRuleResponseThresholdType? ThresholdType { get; set; }

        /// <summary>
        /// The threshold value to compare against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold_value")]
        public double? ThresholdValue { get; set; }

        /// <summary>
        /// Comparison operator for the threshold.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comparator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AlertRuleResponseComparatorJsonConverter))]
        public global::G.AlertRuleResponseComparator? Comparator { get; set; }

        /// <summary>
        /// How often the metric is evaluated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AlertRuleResponseFrequencyJsonConverter))]
        public global::G.AlertRuleResponseFrequency? Frequency { get; set; }

        /// <summary>
        /// Time window for metric evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AlertRuleResponseWindowJsonConverter))]
        public global::G.AlertRuleResponseWindow? Window { get; set; }

        /// <summary>
        /// Email addresses for notifications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        public global::System.Collections.Generic.IList<string>? Emails { get; set; }

        /// <summary>
        /// Webhook URLs for notifications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_urls")]
        public global::System.Collections.Generic.IList<string>? WebhookUrls { get; set; }

        /// <summary>
        /// Whether the alert rule is active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Unix timestamp of last modification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_modified_timestamp")]
        public double? UserModifiedTimestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertRuleResponse" /> class.
        /// </summary>
        /// <param name="alertRuleId">
        /// Unique identifier for the alert rule.
        /// </param>
        /// <param name="orgId">
        /// Organization ID.
        /// </param>
        /// <param name="name">
        /// Name of the alert rule.
        /// </param>
        /// <param name="metricType">
        /// The metric type being monitored.
        /// </param>
        /// <param name="filter">
        /// Filter criteria for alert rules
        /// </param>
        /// <param name="thresholdType">
        /// Whether threshold is absolute or relative to previous period.
        /// </param>
        /// <param name="thresholdValue">
        /// The threshold value to compare against.
        /// </param>
        /// <param name="comparator">
        /// Comparison operator for the threshold.
        /// </param>
        /// <param name="frequency">
        /// How often the metric is evaluated.
        /// </param>
        /// <param name="window">
        /// Time window for metric evaluation.
        /// </param>
        /// <param name="emails">
        /// Email addresses for notifications.
        /// </param>
        /// <param name="webhookUrls">
        /// Webhook URLs for notifications.
        /// </param>
        /// <param name="active">
        /// Whether the alert rule is active.
        /// </param>
        /// <param name="userModifiedTimestamp">
        /// Unix timestamp of last modification.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlertRuleResponse(
            string? alertRuleId,
            string? orgId,
            string? name,
            global::G.AlertMetricType? metricType,
            global::G.AlertFilter? filter,
            global::G.AlertRuleResponseThresholdType? thresholdType,
            double? thresholdValue,
            global::G.AlertRuleResponseComparator? comparator,
            global::G.AlertRuleResponseFrequency? frequency,
            global::G.AlertRuleResponseWindow? window,
            global::System.Collections.Generic.IList<string>? emails,
            global::System.Collections.Generic.IList<string>? webhookUrls,
            bool? active,
            double? userModifiedTimestamp)
        {
            this.AlertRuleId = alertRuleId;
            this.OrgId = orgId;
            this.Name = name;
            this.MetricType = metricType;
            this.Filter = filter;
            this.ThresholdType = thresholdType;
            this.ThresholdValue = thresholdValue;
            this.Comparator = comparator;
            this.Frequency = frequency;
            this.Window = window;
            this.Emails = emails;
            this.WebhookUrls = webhookUrls;
            this.Active = active;
            this.UserModifiedTimestamp = userModifiedTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertRuleResponse" /> class.
        /// </summary>
        public AlertRuleResponse()
        {
        }
    }
}