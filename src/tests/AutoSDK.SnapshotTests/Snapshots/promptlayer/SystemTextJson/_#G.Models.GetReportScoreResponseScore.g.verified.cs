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
        [global::System.Text.Json.Serialization.JsonPropertyName("overall_score")]
        public double? OverallScore { get; set; }

        /// <summary>
        /// Type of scoring used for this report
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GetReportScoreResponseScoreScoreTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.GetReportScoreResponseScoreScoreType ScoreType { get; set; }

        /// <summary>
        /// Whether custom scoring logic was used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_custom_scoring")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasCustomScoring { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.GetReportScoreResponseScoreDetailsVariant1, global::G.GetReportScoreResponseScoreDetailsVariant2, global::G.GetReportScoreResponseScoreDetailsVariant3, global::G.GetReportScoreResponseScoreDetailsVariant4>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OneOf<global::G.GetReportScoreResponseScoreDetailsVariant1, global::G.GetReportScoreResponseScoreDetailsVariant2, global::G.GetReportScoreResponseScoreDetailsVariant3, global::G.GetReportScoreResponseScoreDetailsVariant4> Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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