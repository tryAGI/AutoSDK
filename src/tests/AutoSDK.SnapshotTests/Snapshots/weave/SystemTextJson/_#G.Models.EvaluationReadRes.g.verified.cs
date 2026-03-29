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
        [global::System.Text.Json.Serialization.JsonPropertyName("object_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ObjectId { get; set; }

        /// <summary>
        /// The digest of the evaluation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Digest { get; set; }

        /// <summary>
        /// The version index of the evaluation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int VersionIndex { get; set; }

        /// <summary>
        /// When the evaluation was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The name of the evaluation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of the evaluation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Dataset reference (weave:// URI)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Dataset { get; set; }

        /// <summary>
        /// List of scorer references (weave:// URIs)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scorers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Scorers { get; set; }

        /// <summary>
        /// Number of trials
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trials")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Trials { get; set; }

        /// <summary>
        /// Name for the evaluation run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluation_name")]
        public string? EvaluationName { get; set; }

        /// <summary>
        /// Evaluate op reference (weave:// URI)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluate_op")]
        public string? EvaluateOp { get; set; }

        /// <summary>
        /// Predict and score op reference (weave:// URI)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predict_and_score_op")]
        public string? PredictAndScoreOp { get; set; }

        /// <summary>
        /// Summarize op reference (weave:// URI)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summarize_op")]
        public string? SummarizeOp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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