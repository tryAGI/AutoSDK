//HintName: G.Models.GetAnalyticsGraphsErrorsStacksResponseDataPointStat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsGraphsErrorsStacksResponseDataPointStat
    {
        /// <summary>
        /// Response status code
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("response_status_code")]
        public int? ResponseStatusCode { get; set; }

        /// <summary>
        /// Total occurences of this response status code
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsErrorsStacksResponseDataPointStat" /> class.
        /// </summary>
        /// <param name="responseStatusCode">
        /// Response status code
        /// </param>
        /// <param name="count">
        /// Total occurences of this response status code
        /// </param>
        public GetAnalyticsGraphsErrorsStacksResponseDataPointStat(
            int? responseStatusCode,
            int? count)
        {
            this.ResponseStatusCode = responseStatusCode;
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsErrorsStacksResponseDataPointStat" /> class.
        /// </summary>
        public GetAnalyticsGraphsErrorsStacksResponseDataPointStat()
        {
        }
    }
}