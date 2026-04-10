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
        [global::Newtonsoft.Json.JsonProperty("metric", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.UsageMetricSpecMetricJsonConverter))]
        public global::G.UsageMetricSpecMetric Metric { get; set; } = default!;

        /// <summary>
        /// Basic aggregation functions to apply<br/>
        /// Default Value: [sum]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("aggregations")]
        public global::System.Collections.Generic.IList<global::G.AggregationType>? Aggregations { get; set; }

        /// <summary>
        /// Percentile values to compute (0-100). E.g., [50, 95, 99] for p50, p95, p99<br/>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("percentiles")]
        public global::System.Collections.Generic.IList<double>? Percentiles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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