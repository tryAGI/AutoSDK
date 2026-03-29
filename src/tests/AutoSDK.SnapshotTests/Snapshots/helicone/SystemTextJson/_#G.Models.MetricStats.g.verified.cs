//HintName: G.Models.MetricStats.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetricStats
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p99")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double P99 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p95")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double P95 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p90")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double P90 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Max { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Min { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("median")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Median { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("average")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Average { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricStats" /> class.
        /// </summary>
        /// <param name="p99"></param>
        /// <param name="p95"></param>
        /// <param name="p90"></param>
        /// <param name="max"></param>
        /// <param name="min"></param>
        /// <param name="median"></param>
        /// <param name="average"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetricStats(
            double p99,
            double p95,
            double p90,
            double max,
            double min,
            double median,
            double average)
        {
            this.P99 = p99;
            this.P95 = p95;
            this.P90 = p90;
            this.Max = max;
            this.Min = min;
            this.Median = median;
            this.Average = average;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricStats" /> class.
        /// </summary>
        public MetricStats()
        {
        }
    }
}