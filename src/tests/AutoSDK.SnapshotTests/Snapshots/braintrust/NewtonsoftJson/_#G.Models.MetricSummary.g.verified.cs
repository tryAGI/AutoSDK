//HintName: G.Models.MetricSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Summary of a metric's performance
    /// </summary>
    public sealed partial class MetricSummary
    {
        /// <summary>
        /// Name of the metric
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Average metric across all examples
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metric", Required = global::Newtonsoft.Json.Required.Always)]
        public double Metric { get; set; } = default!;

        /// <summary>
        /// Unit label for the metric
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unit", Required = global::Newtonsoft.Json.Required.Always)]
        public string Unit { get; set; } = default!;

        /// <summary>
        /// Difference in metric between the current and comparison experiment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("diff")]
        public double? Diff { get; set; }

        /// <summary>
        /// Number of improvements in the metric
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("improvements", Required = global::Newtonsoft.Json.Required.Always)]
        public int Improvements { get; set; } = default!;

        /// <summary>
        /// Number of regressions in the metric
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("regressions", Required = global::Newtonsoft.Json.Required.Always)]
        public int Regressions { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricSummary" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the metric
        /// </param>
        /// <param name="metric">
        /// Average metric across all examples
        /// </param>
        /// <param name="unit">
        /// Unit label for the metric
        /// </param>
        /// <param name="improvements">
        /// Number of improvements in the metric
        /// </param>
        /// <param name="regressions">
        /// Number of regressions in the metric
        /// </param>
        /// <param name="diff">
        /// Difference in metric between the current and comparison experiment
        /// </param>
        public MetricSummary(
            string name,
            double metric,
            string unit,
            int improvements,
            int regressions,
            double? diff)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Metric = metric;
            this.Unit = unit ?? throw new global::System.ArgumentNullException(nameof(unit));
            this.Diff = diff;
            this.Improvements = improvements;
            this.Regressions = regressions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricSummary" /> class.
        /// </summary>
        public MetricSummary()
        {
        }
    }
}