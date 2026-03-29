//HintName: G.Models.TimeSeriesDataPoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TimeSeriesDataPoint
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Timestamp { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errorCount", Required = global::Newtonsoft.Json.Required.Always)]
        public double ErrorCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requestCount", Required = global::Newtonsoft.Json.Required.Always)]
        public double RequestCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("averageLatency", Required = global::Newtonsoft.Json.Required.Always)]
        public double AverageLatency { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("averageLatencyPerCompletionToken", Required = global::Newtonsoft.Json.Required.Always)]
        public double AverageLatencyPerCompletionToken { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeSeriesDataPoint" /> class.
        /// </summary>
        /// <param name="timestamp"></param>
        /// <param name="errorCount"></param>
        /// <param name="requestCount"></param>
        /// <param name="averageLatency"></param>
        /// <param name="averageLatencyPerCompletionToken"></param>
        public TimeSeriesDataPoint(
            global::System.DateTime timestamp,
            double errorCount,
            double requestCount,
            double averageLatency,
            double averageLatencyPerCompletionToken)
        {
            this.Timestamp = timestamp;
            this.ErrorCount = errorCount;
            this.RequestCount = requestCount;
            this.AverageLatency = averageLatency;
            this.AverageLatencyPerCompletionToken = averageLatencyPerCompletionToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeSeriesDataPoint" /> class.
        /// </summary>
        public TimeSeriesDataPoint()
        {
        }
    }
}