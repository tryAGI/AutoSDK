//HintName: G.Models.EvaluationRunReadRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationRunReadRes
    {
        /// <summary>
        /// The evaluation run ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluation_run_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EvaluationRunId { get; set; } = default!;

        /// <summary>
        /// Reference to the evaluation (weave:// URI)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluation", Required = global::Newtonsoft.Json.Required.Always)]
        public string Evaluation { get; set; } = default!;

        /// <summary>
        /// Reference to the model (weave:// URI)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Status of the evaluation run
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public string? Status { get; set; }

        /// <summary>
        /// When the evaluation run started
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("started_at")]
        public global::System.DateTime? StartedAt { get; set; }

        /// <summary>
        /// When the evaluation run finished
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finished_at")]
        public global::System.DateTime? FinishedAt { get; set; }

        /// <summary>
        /// Summary data for the evaluation run
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary")]
        public object? Summary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationRunReadRes" /> class.
        /// </summary>
        /// <param name="evaluationRunId">
        /// The evaluation run ID
        /// </param>
        /// <param name="evaluation">
        /// Reference to the evaluation (weave:// URI)
        /// </param>
        /// <param name="model">
        /// Reference to the model (weave:// URI)
        /// </param>
        /// <param name="status">
        /// Status of the evaluation run
        /// </param>
        /// <param name="startedAt">
        /// When the evaluation run started
        /// </param>
        /// <param name="finishedAt">
        /// When the evaluation run finished
        /// </param>
        /// <param name="summary">
        /// Summary data for the evaluation run
        /// </param>
        public EvaluationRunReadRes(
            string evaluationRunId,
            string evaluation,
            string model,
            string? status,
            global::System.DateTime? startedAt,
            global::System.DateTime? finishedAt,
            object? summary)
        {
            this.EvaluationRunId = evaluationRunId ?? throw new global::System.ArgumentNullException(nameof(evaluationRunId));
            this.Evaluation = evaluation ?? throw new global::System.ArgumentNullException(nameof(evaluation));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Status = status;
            this.StartedAt = startedAt;
            this.FinishedAt = finishedAt;
            this.Summary = summary;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationRunReadRes" /> class.
        /// </summary>
        public EvaluationRunReadRes()
        {
        }
    }
}