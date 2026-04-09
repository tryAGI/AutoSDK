//HintName: G.Models.ExperimentPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentPublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_name")]
        public string? DatasetName { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_id")]
        public global::System.Guid? DatasetId { get; set; }

        /// <summary>
        /// Project ID. Takes precedence over project_name when both are provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// Project name. Creates project if it doesn't exist. Ignored when project_id is provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.JsonListStringPublic? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ExperimentPublicTypeJsonConverter))]
        public global::G.ExperimentPublicType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluation_method")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ExperimentPublicEvaluationMethodJsonConverter))]
        public global::G.ExperimentPublicEvaluationMethod? EvaluationMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("optimization_id")]
        public global::System.Guid? OptimizationId { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("feedback_scores")]
        public global::System.Collections.Generic.IList<global::G.FeedbackScoreAveragePublic>? FeedbackScores { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comments")]
        public global::System.Collections.Generic.IList<global::G.CommentPublic>? Comments { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trace_count")]
        public long? TraceCount { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_item_count")]
        public long? DatasetItemCount { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("duration")]
        public global::G.PercentageValuesPublic? Duration { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_estimated_cost")]
        public double? TotalEstimatedCost { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_estimated_cost_avg")]
        public double? TotalEstimatedCostAvg { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public global::System.Collections.Generic.Dictionary<string, double>? Usage { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_by")]
        public string? LastUpdatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ExperimentPublicStatusJsonConverter))]
        public global::G.ExperimentPublicStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiment_scores")]
        public global::System.Collections.Generic.IList<global::G.ExperimentScorePublic>? ExperimentScores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_version")]
        public global::G.PromptVersionLinkPublic? PromptVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_versions")]
        public global::System.Collections.Generic.IList<global::G.PromptVersionLinkPublic>? PromptVersions { get; set; }

        /// <summary>
        /// ID of the dataset version this experiment is linked to. If not provided at creation, experiment will be automatically linked to the latest version.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_version_id")]
        public global::System.Guid? DatasetVersionId { get; set; }

        /// <summary>
        /// Summary of the latest dataset version<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_version_summary")]
        public global::G.DatasetVersionSummaryPublic? DatasetVersionSummary { get; set; }

        /// <summary>
        /// Pass rate for evaluation suite experiments (0.0-1.0). Null for regular experiments.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pass_rate")]
        public double? PassRate { get; set; }

        /// <summary>
        /// Number of items that passed for evaluation suite experiments. Null for regular experiments.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("passed_count")]
        public long? PassedCount { get; set; }

        /// <summary>
        /// Total number of items for evaluation suite experiments. Null for regular experiments.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count")]
        public long? TotalCount { get; set; }

        /// <summary>
        /// Per-assertion average pass rates for evaluation suite experiments. Null for regular experiments.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assertion_scores")]
        public global::System.Collections.Generic.IList<global::G.AssertionScoreAveragePublic>? AssertionScores { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentPublic" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="datasetName"></param>
        /// <param name="datasetId">
        /// Included only in responses
        /// </param>
        /// <param name="projectId">
        /// Project ID. Takes precedence over project_name when both are provided.
        /// </param>
        /// <param name="projectName">
        /// Project name. Creates project if it doesn't exist. Ignored when project_id is provided.
        /// </param>
        /// <param name="name"></param>
        /// <param name="metadata"></param>
        /// <param name="tags"></param>
        /// <param name="type"></param>
        /// <param name="evaluationMethod"></param>
        /// <param name="optimizationId"></param>
        /// <param name="feedbackScores">
        /// Included only in responses
        /// </param>
        /// <param name="comments">
        /// Included only in responses
        /// </param>
        /// <param name="traceCount">
        /// Included only in responses
        /// </param>
        /// <param name="datasetItemCount">
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="duration"></param>
        /// <param name="totalEstimatedCost">
        /// Included only in responses
        /// </param>
        /// <param name="totalEstimatedCostAvg">
        /// Included only in responses
        /// </param>
        /// <param name="usage">
        /// Included only in responses
        /// </param>
        /// <param name="lastUpdatedAt">
        /// Included only in responses
        /// </param>
        /// <param name="createdBy">
        /// Included only in responses
        /// </param>
        /// <param name="lastUpdatedBy">
        /// Included only in responses
        /// </param>
        /// <param name="status"></param>
        /// <param name="experimentScores"></param>
        /// <param name="promptVersion"></param>
        /// <param name="promptVersions"></param>
        /// <param name="datasetVersionId">
        /// ID of the dataset version this experiment is linked to. If not provided at creation, experiment will be automatically linked to the latest version.
        /// </param>
        /// <param name="datasetVersionSummary">
        /// Summary of the latest dataset version<br/>
        /// Included only in responses
        /// </param>
        /// <param name="passRate">
        /// Pass rate for evaluation suite experiments (0.0-1.0). Null for regular experiments.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="passedCount">
        /// Number of items that passed for evaluation suite experiments. Null for regular experiments.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="totalCount">
        /// Total number of items for evaluation suite experiments. Null for regular experiments.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="assertionScores">
        /// Per-assertion average pass rates for evaluation suite experiments. Null for regular experiments.<br/>
        /// Included only in responses
        /// </param>
        public ExperimentPublic(
            global::System.Guid? id,
            string? datasetName,
            global::System.Guid? datasetId,
            global::System.Guid? projectId,
            string? projectName,
            string? name,
            global::G.JsonListStringPublic? metadata,
            global::System.Collections.Generic.IList<string>? tags,
            global::G.ExperimentPublicType? type,
            global::G.ExperimentPublicEvaluationMethod? evaluationMethod,
            global::System.Guid? optimizationId,
            global::System.Collections.Generic.IList<global::G.FeedbackScoreAveragePublic>? feedbackScores,
            global::System.Collections.Generic.IList<global::G.CommentPublic>? comments,
            long? traceCount,
            long? datasetItemCount,
            global::System.DateTime? createdAt,
            global::G.PercentageValuesPublic? duration,
            double? totalEstimatedCost,
            double? totalEstimatedCostAvg,
            global::System.Collections.Generic.Dictionary<string, double>? usage,
            global::System.DateTime? lastUpdatedAt,
            string? createdBy,
            string? lastUpdatedBy,
            global::G.ExperimentPublicStatus? status,
            global::System.Collections.Generic.IList<global::G.ExperimentScorePublic>? experimentScores,
            global::G.PromptVersionLinkPublic? promptVersion,
            global::System.Collections.Generic.IList<global::G.PromptVersionLinkPublic>? promptVersions,
            global::System.Guid? datasetVersionId,
            global::G.DatasetVersionSummaryPublic? datasetVersionSummary,
            double? passRate,
            long? passedCount,
            long? totalCount,
            global::System.Collections.Generic.IList<global::G.AssertionScoreAveragePublic>? assertionScores)
        {
            this.Id = id;
            this.DatasetName = datasetName;
            this.DatasetId = datasetId;
            this.ProjectId = projectId;
            this.ProjectName = projectName;
            this.Name = name;
            this.Metadata = metadata;
            this.Tags = tags;
            this.Type = type;
            this.EvaluationMethod = evaluationMethod;
            this.OptimizationId = optimizationId;
            this.FeedbackScores = feedbackScores;
            this.Comments = comments;
            this.TraceCount = traceCount;
            this.DatasetItemCount = datasetItemCount;
            this.CreatedAt = createdAt;
            this.Duration = duration;
            this.TotalEstimatedCost = totalEstimatedCost;
            this.TotalEstimatedCostAvg = totalEstimatedCostAvg;
            this.Usage = usage;
            this.LastUpdatedAt = lastUpdatedAt;
            this.CreatedBy = createdBy;
            this.LastUpdatedBy = lastUpdatedBy;
            this.Status = status;
            this.ExperimentScores = experimentScores;
            this.PromptVersion = promptVersion;
            this.PromptVersions = promptVersions;
            this.DatasetVersionId = datasetVersionId;
            this.DatasetVersionSummary = datasetVersionSummary;
            this.PassRate = passRate;
            this.PassedCount = passedCount;
            this.TotalCount = totalCount;
            this.AssertionScores = assertionScores;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentPublic" /> class.
        /// </summary>
        public ExperimentPublic()
        {
        }
    }
}