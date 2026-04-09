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
        [global::Newtonsoft.Json.JsonProperty("metric_type", Required = global::Newtonsoft.Json.Required.Always)]
        public object MetricType { get; set; } = default!;

        /// <summary>
        /// Comparison operator for filtering
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("op", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.PerformanceMetricCriteriaOpJsonConverter))]
        public global::G.PerformanceMetricCriteriaOp Op { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public double Value { get; set; } = default!;

        /// <summary>
        /// Weight for scoring (1-100)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score_weight", Required = global::Newtonsoft.Json.Required.Always)]
        public double ScoreWeight { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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