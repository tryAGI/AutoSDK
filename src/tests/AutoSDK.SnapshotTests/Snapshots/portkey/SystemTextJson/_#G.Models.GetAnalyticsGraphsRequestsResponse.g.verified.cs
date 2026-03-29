//HintName: G.Models.GetAnalyticsGraphsRequestsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsGraphsRequestsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetAnalyticsGraphsRequestsResponseSummary Summary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_points")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetAnalyticsGraphsRequestsResponseDataPoint> DataPoints { get; set; }

        /// <summary>
        /// The type of object being returned
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetAnalyticsGraphsRequestsResponseObjectJsonConverter))]
        public global::G.GetAnalyticsGraphsRequestsResponseObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsRequestsResponse" /> class.
        /// </summary>
        /// <param name="summary"></param>
        /// <param name="dataPoints"></param>
        /// <param name="object">
        /// The type of object being returned
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsGraphsRequestsResponse(
            global::G.GetAnalyticsGraphsRequestsResponseSummary summary,
            global::System.Collections.Generic.IList<global::G.GetAnalyticsGraphsRequestsResponseDataPoint> dataPoints,
            global::G.GetAnalyticsGraphsRequestsResponseObject @object)
        {
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.DataPoints = dataPoints ?? throw new global::System.ArgumentNullException(nameof(dataPoints));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsRequestsResponse" /> class.
        /// </summary>
        public GetAnalyticsGraphsRequestsResponse()
        {
        }
    }
}