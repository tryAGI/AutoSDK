//HintName: G.Models.GetAnalyticsGraphsFeedbacksScoresResponseDataPoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAnalyticsGraphsFeedbacksScoresResponseDataPoint
    {
        /// <summary>
        /// Feedback value for which total is calculated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Score { get; set; }

        /// <summary>
        /// Total feedbacks for this feedback score
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsFeedbacksScoresResponseDataPoint" /> class.
        /// </summary>
        /// <param name="score">
        /// Feedback value for which total is calculated
        /// </param>
        /// <param name="total">
        /// Total feedbacks for this feedback score
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAnalyticsGraphsFeedbacksScoresResponseDataPoint(
            int score,
            int total)
        {
            this.Score = score;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAnalyticsGraphsFeedbacksScoresResponseDataPoint" /> class.
        /// </summary>
        public GetAnalyticsGraphsFeedbacksScoresResponseDataPoint()
        {
        }
    }
}