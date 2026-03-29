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
        [global::Newtonsoft.Json.JsonProperty("score", Required = global::Newtonsoft.Json.Required.Always)]
        public int Score { get; set; } = default!;

        /// <summary>
        /// Total feedbacks for this feedback score
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public int Total { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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