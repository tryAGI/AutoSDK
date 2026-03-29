//HintName: G.Models.GetAnalyticsGraphsRequestsResponseDataPoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An array of data points, each with a timestamp and metrics
    /// </summary>
    public sealed partial class GetAnalyticsGraphsRequestsResponseDataPoint
    {
        /// <summary>
        /// The timestamp for the data point bucket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Timestamp { get; set; } = default!;

        /// <summary>
        /// Total requests for this data point bucket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public int Total { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsRequestsResponseDataPoint" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// The timestamp for the data point bucket
        /// </param>
        /// <param name="total">
        /// Total requests for this data point bucket
        /// </param>
        public GetAnalyticsGraphsRequestsResponseDataPoint(
            global::System.DateTime timestamp,
            int total)
        {
            this.Timestamp = timestamp;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsRequestsResponseDataPoint" /> class.
        /// </summary>
        public GetAnalyticsGraphsRequestsResponseDataPoint()
        {
        }
    }
}