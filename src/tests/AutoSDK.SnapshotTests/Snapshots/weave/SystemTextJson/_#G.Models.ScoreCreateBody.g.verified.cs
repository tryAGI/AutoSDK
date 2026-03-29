//HintName: G.Models.ScoreCreateBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request body for creating a Score via REST API.<br/>
    /// This model excludes project_id since it comes from the URL path in RESTful endpoints.
    /// </summary>
    public sealed partial class ScoreCreateBody
    {
        /// <summary>
        /// The prediction ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prediction_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PredictionId { get; set; }

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
        /// Optional evaluation run ID to link this score as a child call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation_run_id")]
        public string? EvaluationRunId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreCreateBody" /> class.
        /// </summary>
        /// <param name="predictionId">
        /// The prediction ID
        /// </param>
        /// <param name="scorer">
        /// The scorer reference (weave:// URI)
        /// </param>
        /// <param name="value">
        /// The value of the score
        /// </param>
        /// <param name="evaluationRunId">
        /// Optional evaluation run ID to link this score as a child call
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScoreCreateBody(
            string predictionId,
            string scorer,
            double value,
            string? evaluationRunId)
        {
            this.PredictionId = predictionId ?? throw new global::System.ArgumentNullException(nameof(predictionId));
            this.Scorer = scorer ?? throw new global::System.ArgumentNullException(nameof(scorer));
            this.Value = value;
            this.EvaluationRunId = evaluationRunId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoreCreateBody" /> class.
        /// </summary>
        public ScoreCreateBody()
        {
        }
    }
}