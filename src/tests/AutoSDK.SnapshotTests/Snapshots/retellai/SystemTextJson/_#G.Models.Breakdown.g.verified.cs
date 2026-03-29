//HintName: G.Models.Breakdown.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Breakdown
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MetricName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric_value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MetricValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Breakdown" /> class.
        /// </summary>
        /// <param name="metricName"></param>
        /// <param name="metricValue"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Breakdown(
            string metricName,
            double metricValue)
        {
            this.MetricName = metricName ?? throw new global::System.ArgumentNullException(nameof(metricName));
            this.MetricValue = metricValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Breakdown" /> class.
        /// </summary>
        public Breakdown()
        {
        }
    }
}