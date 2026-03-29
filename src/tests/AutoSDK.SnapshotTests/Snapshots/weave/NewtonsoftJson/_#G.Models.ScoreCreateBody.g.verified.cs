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
        [global::Newtonsoft.Json.JsonProperty("prediction_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string PredictionId { get; set; } = default!;

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
        /// Optional evaluation run ID to link this score as a child call
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluation_run_id")]
        public string? EvaluationRunId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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