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
        [global::System.Text.Json.Serialization.JsonPropertyName("metric_criteria")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.PerformanceMetricCriteria, global::G.CustomMetricCriteria>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.PerformanceMetricCriteria, global::G.CustomMetricCriteria> MetricCriteria { get; set; }

        /// <summary>
        /// The calculated value of the metric. Omittable for custom metric criteria.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<double?, bool?, string>))]
        public global::G.OneOf<double?, bool?, string>? Value { get; set; }

        /// <summary>
        /// An optional vote based on the metric result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vote")]
        public bool? Vote { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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