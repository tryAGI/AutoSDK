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
        [global::Newtonsoft.Json.JsonProperty("ai_model", Required = global::Newtonsoft.Json.Required.Always)]
        public string AiModel { get; set; } = default!;

        /// <summary>
        /// Total feedbacks for this ai_model requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public int Total { get; set; } = default!;

        /// <summary>
        /// Average weighted feedback for this ai_model requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avg_weighted_feedback", Required = global::Newtonsoft.Json.Required.Always)]
        public int AvgWeightedFeedback { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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