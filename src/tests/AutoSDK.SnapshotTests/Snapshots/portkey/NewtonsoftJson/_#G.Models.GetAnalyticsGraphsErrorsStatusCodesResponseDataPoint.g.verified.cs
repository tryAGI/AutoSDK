//HintName: G.Models.GetAnalyticsGraphsErrorsStatusCodesResponseDataPoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsGraphsErrorsStatusCodesResponseDataPoint
    {
        /// <summary>
        /// Response status code
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status_code", Required = global::Newtonsoft.Json.Required.Always)]
        public int StatusCode { get; set; } = default!;

        /// <summary>
        /// Occurences of this response status code
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("count", Required = global::Newtonsoft.Json.Required.Always)]
        public int Count { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsErrorsStatusCodesResponseDataPoint" /> class.
        /// </summary>
        /// <param name="statusCode">
        /// Response status code
        /// </param>
        /// <param name="count">
        /// Occurences of this response status code
        /// </param>
        public GetAnalyticsGraphsErrorsStatusCodesResponseDataPoint(
            int statusCode,
            int count)
        {
            this.StatusCode = statusCode;
            this.Count = count;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsErrorsStatusCodesResponseDataPoint" /> class.
        /// </summary>
        public GetAnalyticsGraphsErrorsStatusCodesResponseDataPoint()
        {
        }
    }
}