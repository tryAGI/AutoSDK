//HintName: G.Models.ScoreReadRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScoreReadRes
    {
        /// <summary>
        /// The score ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ScoreId { get; set; }

        /// <summary>
        /// The scorer reference (weave:// URI)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scorer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Scorer { get; set; }

        /// <summary>
        /// The value of the score
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// Evaluation run ID if this score is linked to one
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation_run_id")]
        public string? EvaluationRunId { get; set; }

        /// <summary>
        /// Do not set directly. Server will automatically populate this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wb_user_id")]
        public string? WbUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreReadRes" /> class.
        /// </summary>
        /// <param name="scoreId">
        /// The score ID
        /// </param>
        /// <param name="scorer">
        /// The scorer reference (weave:// URI)
        /// </param>
        /// <param name="value">
        /// The value of the score
        /// </param>
        /// <param name="evaluationRunId">
        /// Evaluation run ID if this score is linked to one
        /// </param>
        /// <param name="wbUserId">
        /// Do not set directly. Server will automatically populate this field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScoreReadRes(
            string scoreId,
            string scorer,
            double value,
            string? evaluationRunId,
            string? wbUserId)
        {
            this.ScoreId = scoreId ?? throw new global::System.ArgumentNullException(nameof(scoreId));
            this.Scorer = scorer ?? throw new global::System.ArgumentNullException(nameof(scorer));
            this.Value = value;
            this.EvaluationRunId = evaluationRunId;
            this.WbUserId = wbUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreReadRes" /> class.
        /// </summary>
        public ScoreReadRes()
        {
        }
    }
}