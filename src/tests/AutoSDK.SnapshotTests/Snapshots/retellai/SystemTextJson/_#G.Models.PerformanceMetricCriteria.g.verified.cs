//HintName: G.Models.PerformanceMetricCriteria.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PerformanceMetricCriteria
    {
        /// <summary>
        /// Performance metric type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object MetricType { get; set; }

        /// <summary>
        /// Comparison operator for filtering
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("op")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PerformanceMetricCriteriaOpJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PerformanceMetricCriteriaOp Op { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// Weight for scoring (1-100)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_weight")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ScoreWeight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PerformanceMetricCriteria" /> class.
        /// </summary>
        /// <param name="metricType">
        /// Performance metric type
        /// </param>
        /// <param name="op">
        /// Comparison operator for filtering
        /// </param>
        /// <param name="value"></param>
        /// <param name="scoreWeight">
        /// Weight for scoring (1-100)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PerformanceMetricCriteria(
            object metricType,
            global::G.PerformanceMetricCriteriaOp op,
            double value,
            double scoreWeight)
        {
            this.MetricType = metricType ?? throw new global::System.ArgumentNullException(nameof(metricType));
            this.Op = op;
            this.Value = value;
            this.ScoreWeight = scoreWeight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PerformanceMetricCriteria" /> class.
        /// </summary>
        public PerformanceMetricCriteria()
        {
        }
    }
}