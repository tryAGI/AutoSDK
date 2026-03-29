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
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StatusCode { get; set; }

        /// <summary>
        /// Occurences of this response status code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Count { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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