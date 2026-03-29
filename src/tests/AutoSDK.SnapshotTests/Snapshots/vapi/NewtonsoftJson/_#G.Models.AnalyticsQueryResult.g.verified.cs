//HintName: G.Models.AnalyticsQueryResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnalyticsQueryResult
    {
        /// <summary>
        /// This is the unique key for the query.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// This is the time range for the query.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeRange", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TimeRange TimeRange { get; set; } = default!;

        /// <summary>
        /// This is the result of the query, a list of unique groups with result of their aggregations.<br/>
        /// Example:<br/>
        /// "result": [<br/>
        ///   { "date": "2023-01-01", "assistantId": "123", "endedReason": "customer-ended-call", "sumDuration": 120, "avgCost": 10.5 },<br/>
        ///   { "date": "2023-01-02", "assistantId": "123", "endedReason": "customer-did-not-give-microphone-permission", "sumDuration": 0, "avgCost": 0 },<br/>
        ///   // Additional results<br/>
        /// ]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<object> Result { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryResult" /> class.
        /// </summary>
        /// <param name="name">
        /// This is the unique key for the query.
        /// </param>
        /// <param name="timeRange">
        /// This is the time range for the query.
        /// </param>
        /// <param name="result">
        /// This is the result of the query, a list of unique groups with result of their aggregations.<br/>
        /// Example:<br/>
        /// "result": [<br/>
        ///   { "date": "2023-01-01", "assistantId": "123", "endedReason": "customer-ended-call", "sumDuration": 120, "avgCost": 10.5 },<br/>
        ///   { "date": "2023-01-02", "assistantId": "123", "endedReason": "customer-did-not-give-microphone-permission", "sumDuration": 0, "avgCost": 0 },<br/>
        ///   // Additional results<br/>
        /// ]
        /// </param>
        public AnalyticsQueryResult(
            string name,
            global::G.TimeRange timeRange,
            global::System.Collections.Generic.IList<object> result)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.TimeRange = timeRange ?? throw new global::System.ArgumentNullException(nameof(timeRange));
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsQueryResult" /> class.
        /// </summary>
        public AnalyticsQueryResult()
        {
        }
    }
}