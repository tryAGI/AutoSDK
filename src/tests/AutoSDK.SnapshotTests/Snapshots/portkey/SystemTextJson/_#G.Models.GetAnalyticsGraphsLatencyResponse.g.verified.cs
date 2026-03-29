//HintName: G.Models.GetAnalyticsGraphsLatencyResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsGraphsLatencyResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetAnalyticsGraphsLatencyResponseSummary Summary { get; set; }

        /// <summary>
        /// An array of data points, each with a timestamp and metrics
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_points")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetAnalyticsGraphsLatencyResponseDataPoint> DataPoints { get; set; }

        /// <summary>
        /// The type of object being returned
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetAnalyticsGraphsLatencyResponseObjectJsonConverter))]
        public global::G.GetAnalyticsGraphsLatencyResponseObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsLatencyResponse" /> class.
        /// </summary>
        /// <param name="summary"></param>
        /// <param name="dataPoints">
        /// An array of data points, each with a timestamp and metrics
        /// </param>
        /// <param name="object">
        /// The type of object being returned
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsGraphsLatencyResponse(
            global::G.GetAnalyticsGraphsLatencyResponseSummary summary,
            global::System.Collections.Generic.IList<global::G.GetAnalyticsGraphsLatencyResponseDataPoint> dataPoints,
            global::G.GetAnalyticsGraphsLatencyResponseObject @object)
        {
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.DataPoints = dataPoints ?? throw new global::System.ArgumentNullException(nameof(dataPoints));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsLatencyResponse" /> class.
        /// </summary>
        public GetAnalyticsGraphsLatencyResponse()
        {
        }
    }
}