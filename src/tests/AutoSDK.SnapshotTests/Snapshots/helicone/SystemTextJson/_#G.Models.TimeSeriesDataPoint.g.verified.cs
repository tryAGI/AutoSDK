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
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ErrorCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RequestCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("averageLatency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AverageLatency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("averageLatencyPerCompletionToken")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AverageLatencyPerCompletionToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TimeSeriesDataPoint" /> class.
        /// </summary>
        /// <param name="timestamp"></param>
        /// <param name="errorCount"></param>
        /// <param name="requestCount"></param>
        /// <param name="averageLatency"></param>
        /// <param name="averageLatencyPerCompletionToken"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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