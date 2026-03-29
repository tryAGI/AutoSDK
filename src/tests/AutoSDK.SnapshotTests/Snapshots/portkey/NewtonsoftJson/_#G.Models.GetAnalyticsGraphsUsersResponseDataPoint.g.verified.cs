//HintName: G.Models.GetAnalyticsGraphsUsersResponseDataPoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsGraphsUsersResponseDataPoint
    {
        /// <summary>
        /// The timestamp for the data point bucket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timestamp", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime Timestamp { get; set; } = default!;

        /// <summary>
        /// Total unique users for this data point bucket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public int Total { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsUsersResponseDataPoint" /> class.
        /// </summary>
        /// <param name="timestamp">
        /// The timestamp for the data point bucket
        /// </param>
        /// <param name="total">
        /// Total unique users for this data point bucket
        /// </param>
        public GetAnalyticsGraphsUsersResponseDataPoint(
            global::System.DateTime timestamp,
            int total)
        {
            this.Timestamp = timestamp;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsUsersResponseDataPoint" /> class.
        /// </summary>
        public GetAnalyticsGraphsUsersResponseDataPoint()
        {
        }
    }
}