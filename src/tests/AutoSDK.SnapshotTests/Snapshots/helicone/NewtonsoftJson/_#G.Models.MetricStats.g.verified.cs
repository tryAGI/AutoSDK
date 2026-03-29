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
        [global::Newtonsoft.Json.JsonProperty("p99", Required = global::Newtonsoft.Json.Required.Always)]
        public double P99 { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("p95", Required = global::Newtonsoft.Json.Required.Always)]
        public double P95 { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("p90", Required = global::Newtonsoft.Json.Required.Always)]
        public double P90 { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max", Required = global::Newtonsoft.Json.Required.Always)]
        public double Max { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("min", Required = global::Newtonsoft.Json.Required.Always)]
        public double Min { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("median", Required = global::Newtonsoft.Json.Required.Always)]
        public double Median { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("average", Required = global::Newtonsoft.Json.Required.Always)]
        public double Average { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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