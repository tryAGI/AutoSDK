//HintName: G.Models.EvaluationReadRes.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationReadRes
    {
        /// <summary>
        /// The evaluation ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ObjectId { get; set; } = default!;

        /// <summary>
        /// The digest of the evaluation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("digest", Required = global::Newtonsoft.Json.Required.Always)]
        public string Digest { get; set; } = default!;

        /// <summary>
        /// The version index of the evaluation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int VersionIndex { get; set; } = default!;

        /// <summary>
        /// When the evaluation was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The name of the evaluation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// A description of the evaluation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Dataset reference (weave:// URI)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset", Required = global::Newtonsoft.Json.Required.Always)]
        public string Dataset { get; set; } = default!;

        /// <summary>
        /// List of scorer references (weave:// URIs)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("scorers", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Scorers { get; set; } = default!;

        /// <summary>
        /// Number of trials
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trials", Required = global::Newtonsoft.Json.Required.Always)]
        public int Trials { get; set; } = default!;

        /// <summary>
        /// Name for the evaluation run
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluation_name")]
        public string? EvaluationName { get; set; }

        /// <summary>
        /// Evaluate op reference (weave:// URI)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluate_op")]
        public string? EvaluateOp { get; set; }

        /// <summary>
        /// Predict and score op reference (weave:// URI)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("predict_and_score_op")]
        public string? PredictAndScoreOp { get; set; }

        /// <summary>
        /// Summarize op reference (weave:// URI)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summarize_op")]
        public string? SummarizeOp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationReadRes" /> class.
        /// </summary>
        /// <param name="objectId">
        /// The evaluation ID
        /// </param>
        /// <param name="digest">
        /// The digest of the evaluation
        /// </param>
        /// <param name="versionIndex">
        /// The version index of the evaluation
        /// </param>
        /// <param name="createdAt">
        /// When the evaluation was created
        /// </param>
        /// <param name="name">
        /// The name of the evaluation
        /// </param>
        /// <param name="dataset">
        /// Dataset reference (weave:// URI)
        /// </param>
        /// <param name="scorers">
        /// List of scorer references (weave:// URIs)
        /// </param>
        /// <param name="trials">
        /// Number of trials
        /// </param>
        /// <param name="description">
        /// A description of the evaluation
        /// </param>
        /// <param name="evaluationName">
        /// Name for the evaluation run
        /// </param>
        /// <param name="evaluateOp">
        /// Evaluate op reference (weave:// URI)
        /// </param>
        /// <param name="predictAndScoreOp">
        /// Predict and score op reference (weave:// URI)
        /// </param>
        /// <param name="summarizeOp">
        /// Summarize op reference (weave:// URI)
        /// </param>
        public EvaluationReadRes(
            string objectId,
            string digest,
            int versionIndex,
            global::System.DateTime createdAt,
            string name,
            string dataset,
            global::System.Collections.Generic.IList<string> scorers,
            int trials,
            string? description,
            string? evaluationName,
            string? evaluateOp,
            string? predictAndScoreOp,
            string? summarizeOp)
        {
            this.ObjectId = objectId ?? throw new global::System.ArgumentNullException(nameof(objectId));
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
            this.VersionIndex = versionIndex;
            this.CreatedAt = createdAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Dataset = dataset ?? throw new global::System.ArgumentNullException(nameof(dataset));
            this.Scorers = scorers ?? throw new global::System.ArgumentNullException(nameof(scorers));
            this.Trials = trials;
            this.EvaluationName = evaluationName;
            this.EvaluateOp = evaluateOp;
            this.PredictAndScoreOp = predictAndScoreOp;
            this.SummarizeOp = summarizeOp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationReadRes" /> class.
        /// </summary>
        public EvaluationReadRes()
        {
        }
    }
}