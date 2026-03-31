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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Average metric across all examples
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Metric { get; set; }

        /// <summary>
        /// Unit label for the metric
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Unit { get; set; }

        /// <summary>
        /// Difference in metric between the current and comparison experiment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diff")]
        public double? Diff { get; set; }

        /// <summary>
        /// Number of improvements in the metric
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("improvements")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Improvements { get; set; }

        /// <summary>
        /// Number of regressions in the metric
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regressions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Regressions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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