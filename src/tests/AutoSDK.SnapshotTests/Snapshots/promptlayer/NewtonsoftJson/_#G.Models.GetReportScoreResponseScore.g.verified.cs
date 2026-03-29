//HintName: G.Models.GetReportScoreResponseScore.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetReportScoreResponseScore
    {
        /// <summary>
        /// The overall score of the report
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("overall_score")]
        public double? OverallScore { get; set; }

        /// <summary>
        /// Type of scoring used for this report
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetReportScoreResponseScoreScoreType ScoreType { get; set; } = default!;

        /// <summary>
        /// Whether custom scoring logic was used
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_custom_scoring", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasCustomScoring { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("details", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OneOf<global::G.GetReportScoreResponseScoreDetailsVariant1, global::G.GetReportScoreResponseScoreDetailsVariant2, global::G.GetReportScoreResponseScoreDetailsVariant3, global::G.GetReportScoreResponseScoreDetailsVariant4> Details { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReportScoreResponseScore" /> class.
        /// </summary>
        /// <param name="scoreType">
        /// Type of scoring used for this report
        /// </param>
        /// <param name="hasCustomScoring">
        /// Whether custom scoring logic was used
        /// </param>
        /// <param name="details"></param>
        /// <param name="overallScore">
        /// The overall score of the report
        /// </param>
        public GetReportScoreResponseScore(
            global::G.GetReportScoreResponseScoreScoreType scoreType,
            bool hasCustomScoring,
            global::G.OneOf<global::G.GetReportScoreResponseScoreDetailsVariant1, global::G.GetReportScoreResponseScoreDetailsVariant2, global::G.GetReportScoreResponseScoreDetailsVariant3, global::G.GetReportScoreResponseScoreDetailsVariant4> details,
            double? overallScore)
        {
            this.OverallScore = overallScore;
            this.ScoreType = scoreType;
            this.HasCustomScoring = hasCustomScoring;
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReportScoreResponseScore" /> class.
        /// </summary>
        public GetReportScoreResponseScore()
        {
        }
    }
}