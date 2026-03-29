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
        [global::Newtonsoft.Json.JsonProperty("score_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ScoreId { get; set; } = default!;

        /// <summary>
        /// The scorer reference (weave:// URI)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scorer", Required = global::Newtonsoft.Json.Required.Always)]
        public string Scorer { get; set; } = default!;

        /// <summary>
        /// The value of the score
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public double Value { get; set; } = default!;

        /// <summary>
        /// Evaluation run ID if this score is linked to one
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluation_run_id")]
        public string? EvaluationRunId { get; set; }

        /// <summary>
        /// Do not set directly. Server will automatically populate this field.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wb_user_id")]
        public string? WbUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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