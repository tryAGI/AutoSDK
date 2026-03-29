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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The metric type to monitor.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metric_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AlertMetricType MetricType { get; set; } = default!;

        /// <summary>
        /// Filter criteria for alert rules
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter")]
        public global::G.AlertFilter? Filter { get; set; }

        /// <summary>
        /// Whether threshold is absolute or relative to previous period.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("threshold_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AlertRuleRequestThresholdType ThresholdType { get; set; } = default!;

        /// <summary>
        /// The threshold value to compare against.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("threshold_value", Required = global::Newtonsoft.Json.Required.Always)]
        public double ThresholdValue { get; set; } = default!;

        /// <summary>
        /// Comparison operator for the threshold.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comparator", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AlertRuleRequestComparator Comparator { get; set; } = default!;

        /// <summary>
        /// How often to evaluate the metric.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frequency", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AlertRuleRequestFrequency Frequency { get; set; } = default!;

        /// <summary>
        /// Time window for metric evaluation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("window", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AlertRuleRequestWindow Window { get; set; } = default!;

        /// <summary>
        /// Email addresses to notify when alert triggers.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("emails")]
        public global::System.Collections.Generic.IList<string>? Emails { get; set; }

        /// <summary>
        /// Webhook URLs to notify when alert triggers.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook_urls")]
        public global::System.Collections.Generic.IList<string>? WebhookUrls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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