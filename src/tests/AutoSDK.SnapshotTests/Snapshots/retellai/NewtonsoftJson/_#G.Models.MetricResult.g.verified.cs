//HintName: G.Models.MetricResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetricResult
    {
        /// <summary>
        /// Can be either a PerformanceMetricCriteria or CustomMetricCriteria object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metric_criteria", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.PerformanceMetricCriteria, global::G.CustomMetricCriteria> MetricCriteria { get; set; } = default!;

        /// <summary>
        /// The calculated value of the metric. Omittable for custom metric criteria.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public global::G.OneOf<double?, bool?, string>? Value { get; set; }

        /// <summary>
        /// An optional vote based on the metric result.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vote")]
        public bool? Vote { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricResult" /> class.
        /// </summary>
        /// <param name="metricCriteria">
        /// Can be either a PerformanceMetricCriteria or CustomMetricCriteria object.
        /// </param>
        /// <param name="value">
        /// The calculated value of the metric. Omittable for custom metric criteria.
        /// </param>
        /// <param name="vote">
        /// An optional vote based on the metric result.
        /// </param>
        public MetricResult(
            global::G.OneOf<global::G.PerformanceMetricCriteria, global::G.CustomMetricCriteria> metricCriteria,
            global::G.OneOf<double?, bool?, string>? value,
            bool? vote)
        {
            this.MetricCriteria = metricCriteria;
            this.Value = value;
            this.Vote = vote;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricResult" /> class.
        /// </summary>
        public MetricResult()
        {
        }
    }
}