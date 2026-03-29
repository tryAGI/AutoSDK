//HintName: G.Models.CallLatency.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CallLatency
    {
        /// <summary>
        /// 50 percentile of latency, measured in milliseconds.<br/>
        /// Example: 800
        /// </summary>
        /// <example>800</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("p50")]
        public double? P50 { get; set; }

        /// <summary>
        /// 90 percentile of latency, measured in milliseconds.<br/>
        /// Example: 1200
        /// </summary>
        /// <example>1200</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("p90")]
        public double? P90 { get; set; }

        /// <summary>
        /// 95 percentile of latency, measured in milliseconds.<br/>
        /// Example: 1500
        /// </summary>
        /// <example>1500</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("p95")]
        public double? P95 { get; set; }

        /// <summary>
        /// 99 percentile of latency, measured in milliseconds.<br/>
        /// Example: 2500
        /// </summary>
        /// <example>2500</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("p99")]
        public double? P99 { get; set; }

        /// <summary>
        /// Maximum latency in the call, measured in milliseconds.<br/>
        /// Example: 2700
        /// </summary>
        /// <example>2700</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max")]
        public double? Max { get; set; }

        /// <summary>
        /// Minimum latency in the call, measured in milliseconds.<br/>
        /// Example: 500
        /// </summary>
        /// <example>500</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("min")]
        public double? Min { get; set; }

        /// <summary>
        /// Number of data points (number of times latency is tracked).<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("num")]
        public double? Num { get; set; }

        /// <summary>
        /// All the latency data points in the call, measured in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        public global::System.Collections.Generic.IList<double>? Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallLatency" /> class.
        /// </summary>
        /// <param name="p50">
        /// 50 percentile of latency, measured in milliseconds.<br/>
        /// Example: 800
        /// </param>
        /// <param name="p90">
        /// 90 percentile of latency, measured in milliseconds.<br/>
        /// Example: 1200
        /// </param>
        /// <param name="p95">
        /// 95 percentile of latency, measured in milliseconds.<br/>
        /// Example: 1500
        /// </param>
        /// <param name="p99">
        /// 99 percentile of latency, measured in milliseconds.<br/>
        /// Example: 2500
        /// </param>
        /// <param name="max">
        /// Maximum latency in the call, measured in milliseconds.<br/>
        /// Example: 2700
        /// </param>
        /// <param name="min">
        /// Minimum latency in the call, measured in milliseconds.<br/>
        /// Example: 500
        /// </param>
        /// <param name="num">
        /// Number of data points (number of times latency is tracked).<br/>
        /// Example: 10
        /// </param>
        /// <param name="values">
        /// All the latency data points in the call, measured in milliseconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallLatency(
            double? p50,
            double? p90,
            double? p95,
            double? p99,
            double? max,
            double? min,
            double? num,
            global::System.Collections.Generic.IList<double>? values)
        {
            this.P50 = p50;
            this.P90 = p90;
            this.P95 = p95;
            this.P99 = p99;
            this.Max = max;
            this.Min = min;
            this.Num = num;
            this.Values = values;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallLatency" /> class.
        /// </summary>
        public CallLatency()
        {
        }
    }
}