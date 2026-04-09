//HintName: G.Models.EvaluationRun.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluationRun
    {
        /// <summary>
        /// Unique identifier for the run
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Name of the run
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Optional comment or description
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Timestamp when the run was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the run was last updated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// ID of the workspace
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_id")]
        public int? WorkspaceId { get; set; }

        /// <summary>
        /// ID of the folder
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("folder_id")]
        public int? FolderId { get; set; }

        /// <summary>
        /// ID of the user who created this run
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// ID of the dataset
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_id")]
        public int? DatasetId { get; set; }

        /// <summary>
        /// Whether this is a blueprint
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_blueprint")]
        public bool? IsBlueprint { get; set; }

        /// <summary>
        /// Tags associated with this run
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public object? Tags { get; set; }

        /// <summary>
        /// Whether this run has been deleted
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// ID of the parent blueprint
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_report_id")]
        public int? ParentReportId { get; set; }

        /// <summary>
        /// Custom scoring configuration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score_configuration")]
        public object? ScoreConfiguration { get; set; }

        /// <summary>
        /// Computed score for this run
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score")]
        public object? Score { get; set; }

        /// <summary>
        /// Matrix of scores across evaluation columns
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score_matrix")]
        public byte[]? ScoreMatrix { get; set; }

        /// <summary>
        /// Error message if score calculation failed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score_calculation_error")]
        public string? ScoreCalculationError { get; set; }

        /// <summary>
        /// Current status of the batch run
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.EvaluationRunStatusJsonConverter))]
        public global::G.EvaluationRunStatus? Status { get; set; }

        /// <summary>
        /// Run statistics
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stats")]
        public global::G.EvaluationRunStats? Stats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationRun" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the run
        /// </param>
        /// <param name="name">
        /// Name of the run
        /// </param>
        /// <param name="comment">
        /// Optional comment or description
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the run was created
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the run was last updated
        /// </param>
        /// <param name="workspaceId">
        /// ID of the workspace
        /// </param>
        /// <param name="folderId">
        /// ID of the folder
        /// </param>
        /// <param name="userId">
        /// ID of the user who created this run
        /// </param>
        /// <param name="datasetId">
        /// ID of the dataset
        /// </param>
        /// <param name="isBlueprint">
        /// Whether this is a blueprint
        /// </param>
        /// <param name="tags">
        /// Tags associated with this run
        /// </param>
        /// <param name="deleted">
        /// Whether this run has been deleted
        /// </param>
        /// <param name="parentReportId">
        /// ID of the parent blueprint
        /// </param>
        /// <param name="scoreConfiguration">
        /// Custom scoring configuration
        /// </param>
        /// <param name="score">
        /// Computed score for this run
        /// </param>
        /// <param name="scoreMatrix">
        /// Matrix of scores across evaluation columns
        /// </param>
        /// <param name="scoreCalculationError">
        /// Error message if score calculation failed
        /// </param>
        /// <param name="status">
        /// Current status of the batch run
        /// </param>
        /// <param name="stats">
        /// Run statistics
        /// </param>
        public EvaluationRun(
            int? id,
            string? name,
            string? comment,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            int? workspaceId,
            int? folderId,
            int? userId,
            int? datasetId,
            bool? isBlueprint,
            object? tags,
            bool? deleted,
            int? parentReportId,
            object? scoreConfiguration,
            object? score,
            byte[]? scoreMatrix,
            string? scoreCalculationError,
            global::G.EvaluationRunStatus? status,
            global::G.EvaluationRunStats? stats)
        {
            this.Id = id;
            this.Name = name;
            this.Comment = comment;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.WorkspaceId = workspaceId;
            this.FolderId = folderId;
            this.UserId = userId;
            this.DatasetId = datasetId;
            this.IsBlueprint = isBlueprint;
            this.Tags = tags;
            this.Deleted = deleted;
            this.ParentReportId = parentReportId;
            this.ScoreConfiguration = scoreConfiguration;
            this.Score = score;
            this.ScoreMatrix = scoreMatrix;
            this.ScoreCalculationError = scoreCalculationError;
            this.Status = status;
            this.Stats = stats;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluationRun" /> class.
        /// </summary>
        public EvaluationRun()
        {
        }
    }
}