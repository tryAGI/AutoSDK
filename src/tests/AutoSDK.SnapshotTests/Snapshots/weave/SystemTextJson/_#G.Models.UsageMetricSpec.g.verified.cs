//HintName: G.Models.UsageMetricSpec.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specification for a usage metric to aggregate (grouped by model).
    /// </summary>
    public sealed partial class UsageMetricSpec
    {
        /// <summary>
        /// Metric to aggregate. Token metrics are normalized across providers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UsageMetricSpecMetricJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.UsageMetricSpecMetric Metric { get; set; }

        /// <summary>
        /// Basic aggregation functions to apply<br/>
        /// Default Value: [sum]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggregations")]
        public global::System.Collections.Generic.IList<global::G.AggregationType>? Aggregations { get; set; }

        /// <summary>
        /// Percentile values to compute (0-100). E.g., [50, 95, 99] for p50, p95, p99<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("percentiles")]
        public global::System.Collections.Generic.IList<double>? Percentiles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageMetricSpec" /> class.
        /// </summary>
        /// <param name="metric">
        /// Metric to aggregate. Token metrics are normalized across providers.
        /// </param>
        /// <param name="aggregations">
        /// Basic aggregation functions to apply<br/>
        /// Default Value: [sum]
        /// </param>
        /// <param name="percentiles">
        /// Percentile values to compute (0-100). E.g., [50, 95, 99] for p50, p95, p99<br/>
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsageMetricSpec(
            global::G.UsageMetricSpecMetric metric,
            global::System.Collections.Generic.IList<global::G.AggregationType>? aggregations,
            global::System.Collections.Generic.IList<double>? percentiles)
        {
            this.Metric = metric;
            this.Aggregations = aggregations;
            this.Percentiles = percentiles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsageMetricSpec" /> class.
        /// </summary>
        public UsageMetricSpec()
        {
        }
    }
}