//HintName: G.Models.GetAnalyticsGraphsTokensResponseDataPoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsGraphsTokensResponseDataPoint
    {
        /// <summary>
        /// The timestamp for the data point bucket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Timestamp { get; set; } = default!;

        /// <summary>
        /// Total tokens for this data point bucket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public int Total { get; set; } = default!;

        /// <summary>
        /// Average tokens per request for this data point bucket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avg", Required = global::Newtonsoft.Json.Required.Always)]
        public int Avg { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsTokensResponseDataPoint" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// The timestamp for the data point bucket
        /// </param>
        /// <param name="total">
        /// Total tokens for this data point bucket
        /// </param>
        /// <param name="avg">
        /// Average tokens per request for this data point bucket
        /// </param>
        public GetAnalyticsGraphsTokensResponseDataPoint(
            global::System.DateTime timestamp,
            int total,
            int avg)
        {
            this.Timestamp = timestamp;
            this.Total = total;
            this.Avg = avg;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsTokensResponseDataPoint" /> class.
        /// </summary>
        public GetAnalyticsGraphsTokensResponseDataPoint()
        {
        }
    }
}