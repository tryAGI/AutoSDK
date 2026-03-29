//HintName: G.Models.AlertIncidentResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AlertIncidentResponse
    {
        /// <summary>
        /// Unique identifier for the alert incident.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alert_incident_id")]
        public string? AlertIncidentId { get; set; }

        /// <summary>
        /// Organization ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("org_id")]
        public string? OrgId { get; set; }

        /// <summary>
        /// The alert rule ID that triggered this incident.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alert_rule_id")]
        public string? AlertRuleId { get; set; }

        /// <summary>
        /// Name of the alert rule at the time of incident.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The metric type being monitored.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metric_type")]
        public global::G.AlertMetricType? MetricType { get; set; }

        /// <summary>
        /// Filter criteria for alert rules
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter")]
        public global::G.AlertFilter? Filter { get; set; }

        /// <summary>
        /// Whether threshold is absolute or relative to previous period.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("threshold_type")]
        public global::G.AlertIncidentResponseThresholdType? ThresholdType { get; set; }

        /// <summary>
        /// The threshold value that was configured.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("threshold_value")]
        public double? ThresholdValue { get; set; }

        /// <summary>
        /// Comparison operator for the threshold.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comparator")]
        public global::G.AlertIncidentResponseComparator? Comparator { get; set; }

        /// <summary>
        /// Evaluation frequency.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frequency")]
        public global::G.AlertIncidentResponseFrequency? Frequency { get; set; }

        /// <summary>
        /// Time window for metric evaluation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("window")]
        public global::G.AlertIncidentResponseWindow? Window { get; set; }

        /// <summary>
        /// Email addresses for notifications.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("emails")]
        public global::System.Collections.Generic.IList<string>? Emails { get; set; }

        /// <summary>
        /// Webhook URLs for notifications.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook_urls")]
        public global::System.Collections.Generic.IList<string>? WebhookUrls { get; set; }

        /// <summary>
        /// The value that triggered the alert.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_value")]
        public double? CurrentValue { get; set; }

        /// <summary>
        /// The previous period value (for relative thresholds).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("previous_value")]
        public double? PreviousValue { get; set; }

        /// <summary>
        /// Unix timestamp when the incident was triggered.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("triggered_timestamp")]
        public double? TriggeredTimestamp { get; set; }

        /// <summary>
        /// Unix timestamp when the incident was resolved.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("resolved_timestamp")]
        public double? ResolvedTimestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertIncidentResponse" /> class.
        /// </summary>
        /// <param name="alertIncidentId">
        /// Unique identifier for the alert incident.
        /// </param>
        /// <param name="orgId">
        /// Organization ID.
        /// </param>
        /// <param name="alertRuleId">
        /// The alert rule ID that triggered this incident.
        /// </param>
        /// <param name="name">
        /// Name of the alert rule at the time of incident.
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
        /// The threshold value that was configured.
        /// </param>
        /// <param name="comparator">
        /// Comparison operator for the threshold.
        /// </param>
        /// <param name="frequency">
        /// Evaluation frequency.
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
        /// <param name="currentValue">
        /// The value that triggered the alert.
        /// </param>
        /// <param name="previousValue">
        /// The previous period value (for relative thresholds).
        /// </param>
        /// <param name="triggeredTimestamp">
        /// Unix timestamp when the incident was triggered.
        /// </param>
        /// <param name="resolvedTimestamp">
        /// Unix timestamp when the incident was resolved.
        /// </param>
        public AlertIncidentResponse(
            string? alertIncidentId,
            string? orgId,
            string? alertRuleId,
            string? name,
            global::G.AlertMetricType? metricType,
            global::G.AlertFilter? filter,
            global::G.AlertIncidentResponseThresholdType? thresholdType,
            double? thresholdValue,
            global::G.AlertIncidentResponseComparator? comparator,
            global::G.AlertIncidentResponseFrequency? frequency,
            global::G.AlertIncidentResponseWindow? window,
            global::System.Collections.Generic.IList<string>? emails,
            global::System.Collections.Generic.IList<string>? webhookUrls,
            double? currentValue,
            double? previousValue,
            double? triggeredTimestamp,
            double? resolvedTimestamp)
        {
            this.AlertIncidentId = alertIncidentId;
            this.OrgId = orgId;
            this.AlertRuleId = alertRuleId;
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
            this.CurrentValue = currentValue;
            this.PreviousValue = previousValue;
            this.TriggeredTimestamp = triggeredTimestamp;
            this.ResolvedTimestamp = resolvedTimestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertIncidentResponse" /> class.
        /// </summary>
        public AlertIncidentResponse()
        {
        }
    }
}