//HintName: G.Models.GetAnalyticsGraphsFeedbacksAiModelsResponseDataPoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsGraphsFeedbacksAiModelsResponseDataPoint
    {
        /// <summary>
        /// AI model for which feedback data is calculated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AiModel { get; set; }

        /// <summary>
        /// Total feedbacks for this ai_model requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Average weighted feedback for this ai_model requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avg_weighted_feedback")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AvgWeightedFeedback { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsFeedbacksAiModelsResponseDataPoint" /> class.
        /// </summary>
        /// <param name="aiModel">
        /// AI model for which feedback data is calculated
        /// </param>
        /// <param name="total">
        /// Total feedbacks for this ai_model requests
        /// </param>
        /// <param name="avgWeightedFeedback">
        /// Average weighted feedback for this ai_model requests
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsGraphsFeedbacksAiModelsResponseDataPoint(
            string aiModel,
            int total,
            int avgWeightedFeedback)
        {
            this.AiModel = aiModel ?? throw new global::System.ArgumentNullException(nameof(aiModel));
            this.Total = total;
            this.AvgWeightedFeedback = avgWeightedFeedback;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsFeedbacksAiModelsResponseDataPoint" /> class.
        /// </summary>
        public GetAnalyticsGraphsFeedbacksAiModelsResponseDataPoint()
        {
        }
    }
}