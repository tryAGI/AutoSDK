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
        [global::Newtonsoft.Json.JsonProperty("totalRequests", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalRequests { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requestCountPrevious24h", Required = global::Newtonsoft.Json.Required.Always)]
        public double RequestCountPrevious24h { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("requestVolumeChange", Required = global::Newtonsoft.Json.Required.Always)]
        public double RequestVolumeChange { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errorRate24h", Required = global::Newtonsoft.Json.Required.Always)]
        public double ErrorRate24h { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errorRatePrevious24h", Required = global::Newtonsoft.Json.Required.Always)]
        public double ErrorRatePrevious24h { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("errorRateChange", Required = global::Newtonsoft.Json.Required.Always)]
        public double ErrorRateChange { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("averageLatency", Required = global::Newtonsoft.Json.Required.Always)]
        public double AverageLatency { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("averageLatencyPerToken", Required = global::Newtonsoft.Json.Required.Always)]
        public double AverageLatencyPerToken { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latencyChange", Required = global::Newtonsoft.Json.Required.Always)]
        public double LatencyChange { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latencyPerTokenChange", Required = global::Newtonsoft.Json.Required.Always)]
        public double LatencyPerTokenChange { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recentRequestCount", Required = global::Newtonsoft.Json.Required.Always)]
        public double RecentRequestCount { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("recentErrorCount", Required = global::Newtonsoft.Json.Required.Always)]
        public double RecentErrorCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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