//HintName: G.Models.MetricsData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetricsData
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalRequests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalRequests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestCountPrevious24h")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RequestCountPrevious24h { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestVolumeChange")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RequestVolumeChange { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorRate24h")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ErrorRate24h { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorRatePrevious24h")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ErrorRatePrevious24h { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorRateChange")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ErrorRateChange { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("averageLatency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AverageLatency { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("averageLatencyPerToken")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AverageLatencyPerToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latencyChange")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LatencyChange { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latencyPerTokenChange")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LatencyPerTokenChange { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recentRequestCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RecentRequestCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("recentErrorCount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double RecentErrorCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricsData" /> class.
        /// </summary>
        /// <param name="totalRequests"></param>
        /// <param name="requestCountPrevious24h"></param>
        /// <param name="requestVolumeChange"></param>
        /// <param name="errorRate24h"></param>
        /// <param name="errorRatePrevious24h"></param>
        /// <param name="errorRateChange"></param>
        /// <param name="averageLatency"></param>
        /// <param name="averageLatencyPerToken"></param>
        /// <param name="latencyChange"></param>
        /// <param name="latencyPerTokenChange"></param>
        /// <param name="recentRequestCount"></param>
        /// <param name="recentErrorCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetricsData(
            double totalRequests,
            double requestCountPrevious24h,
            double requestVolumeChange,
            double errorRate24h,
            double errorRatePrevious24h,
            double errorRateChange,
            double averageLatency,
            double averageLatencyPerToken,
            double latencyChange,
            double latencyPerTokenChange,
            double recentRequestCount,
            double recentErrorCount)
        {
            this.TotalRequests = totalRequests;
            this.RequestCountPrevious24h = requestCountPrevious24h;
            this.RequestVolumeChange = requestVolumeChange;
            this.ErrorRate24h = errorRate24h;
            this.ErrorRatePrevious24h = errorRatePrevious24h;
            this.ErrorRateChange = errorRateChange;
            this.AverageLatency = averageLatency;
            this.AverageLatencyPerToken = averageLatencyPerToken;
            this.LatencyChange = latencyChange;
            this.LatencyPerTokenChange = latencyPerTokenChange;
            this.RecentRequestCount = recentRequestCount;
            this.RecentErrorCount = recentErrorCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricsData" /> class.
        /// </summary>
        public MetricsData()
        {
        }
    }
}