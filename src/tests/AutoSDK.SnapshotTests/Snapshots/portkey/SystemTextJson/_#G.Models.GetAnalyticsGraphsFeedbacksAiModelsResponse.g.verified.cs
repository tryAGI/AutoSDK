//HintName: G.Models.GetAnalyticsGraphsFeedbacksAiModelsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsGraphsFeedbacksAiModelsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Summary { get; set; }

        /// <summary>
        /// An array of data points, each with a timestamp and metrics
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_points")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetAnalyticsGraphsFeedbacksAiModelsResponseDataPoint> DataPoints { get; set; }

        /// <summary>
        /// The type of object being returned
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetAnalyticsGraphsFeedbacksAiModelsResponseObjectJsonConverter))]
        public global::G.GetAnalyticsGraphsFeedbacksAiModelsResponseObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsFeedbacksAiModelsResponse" /> class.
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
        public GetAnalyticsGraphsFeedbacksAiModelsResponse(
            object summary,
            global::System.Collections.Generic.IList<global::G.GetAnalyticsGraphsFeedbacksAiModelsResponseDataPoint> dataPoints,
            global::G.GetAnalyticsGraphsFeedbacksAiModelsResponseObject @object)
        {
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.DataPoints = dataPoints ?? throw new global::System.ArgumentNullException(nameof(dataPoints));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsFeedbacksAiModelsResponse" /> class.
        /// </summary>
        public GetAnalyticsGraphsFeedbacksAiModelsResponse()
        {
        }
    }
}