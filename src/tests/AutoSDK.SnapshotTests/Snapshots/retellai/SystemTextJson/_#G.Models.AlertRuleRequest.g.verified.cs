//HintName: G.Models.AlertRuleRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AlertRuleRequest
    {
        /// <summary>
        /// Name of the alert rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The metric type to monitor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AlertMetricTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AlertMetricType MetricType { get; set; }

        /// <summary>
        /// Filter criteria for alert rules
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public global::G.AlertFilter? Filter { get; set; }

        /// <summary>
        /// Whether threshold is absolute or relative to previous period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AlertRuleRequestThresholdTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AlertRuleRequestThresholdType ThresholdType { get; set; }

        /// <summary>
        /// The threshold value to compare against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("threshold_value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ThresholdValue { get; set; }

        /// <summary>
        /// Comparison operator for the threshold.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comparator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AlertRuleRequestComparatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AlertRuleRequestComparator Comparator { get; set; }

        /// <summary>
        /// How often to evaluate the metric.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AlertRuleRequestFrequencyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AlertRuleRequestFrequency Frequency { get; set; }

        /// <summary>
        /// Time window for metric evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AlertRuleRequestWindowJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AlertRuleRequestWindow Window { get; set; }

        /// <summary>
        /// Email addresses to notify when alert triggers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("emails")]
        public global::System.Collections.Generic.IList<string>? Emails { get; set; }

        /// <summary>
        /// Webhook URLs to notify when alert triggers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_urls")]
        public global::System.Collections.Generic.IList<string>? WebhookUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertRuleRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the alert rule.
        /// </param>
        /// <param name="metricType">
        /// The metric type to monitor.
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
        /// How often to evaluate the metric.
        /// </param>
        /// <param name="window">
        /// Time window for metric evaluation.
        /// </param>
        /// <param name="filter">
        /// Filter criteria for alert rules
        /// </param>
        /// <param name="emails">
        /// Email addresses to notify when alert triggers.
        /// </param>
        /// <param name="webhookUrls">
        /// Webhook URLs to notify when alert triggers.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlertRuleRequest(
            string name,
            global::G.AlertMetricType metricType,
            global::G.AlertRuleRequestThresholdType thresholdType,
            double thresholdValue,
            global::G.AlertRuleRequestComparator comparator,
            global::G.AlertRuleRequestFrequency frequency,
            global::G.AlertRuleRequestWindow window,
            global::G.AlertFilter? filter,
            global::System.Collections.Generic.IList<string>? emails,
            global::System.Collections.Generic.IList<string>? webhookUrls)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.MetricType = metricType;
            this.Filter = filter;
            this.ThresholdType = thresholdType;
            this.ThresholdValue = thresholdValue;
            this.Comparator = comparator;
            this.Frequency = frequency;
            this.Window = window;
            this.Emails = emails;
            this.WebhookUrls = webhookUrls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertRuleRequest" /> class.
        /// </summary>
        public AlertRuleRequest()
        {
        }
    }
}