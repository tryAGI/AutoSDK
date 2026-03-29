//HintName: G.Models.Evaluation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Evaluation
    {
        /// <summary>
        /// Unique identifier for the evaluation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Name of the evaluation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional comment or description for the evaluation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// Timestamp when the evaluation was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the evaluation was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// ID of the workspace this evaluation belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WorkspaceId { get; set; }

        /// <summary>
        /// ID of the folder containing this evaluation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        public int? FolderId { get; set; }

        /// <summary>
        /// ID of the user who created this evaluation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// ID of the dataset associated with this evaluation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        public int? DatasetId { get; set; }

        /// <summary>
        /// Whether this is a blueprint (pipeline definition) or a batch run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_blueprint")]
        public bool? IsBlueprint { get; set; }

        /// <summary>
        /// Tags associated with this evaluation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public object? Tags { get; set; }

        /// <summary>
        /// Whether this evaluation has been deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        public bool? Deleted { get; set; }

        /// <summary>
        /// ID of the parent blueprint (set for batch runs)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_report_id")]
        public int? ParentReportId { get; set; }

        /// <summary>
        /// Custom scoring configuration for this evaluation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score_configuration")]
        public object? ScoreConfiguration { get; set; }

        /// <summary>
        /// Batch runs for this evaluation. Only present when include_runs=true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("runs")]
        public global::System.Collections.Generic.IList<global::G.EvaluationRun>? Runs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Evaluation" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the evaluation
        /// </param>
        /// <param name="name">
        /// Name of the evaluation
        /// </param>
        /// <param name="workspaceId">
        /// ID of the workspace this evaluation belongs to
        /// </param>
        /// <param name="comment">
        /// Optional comment or description for the evaluation
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the evaluation was created
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the evaluation was last updated
        /// </param>
        /// <param name="folderId">
        /// ID of the folder containing this evaluation
        /// </param>
        /// <param name="userId">
        /// ID of the user who created this evaluation
        /// </param>
        /// <param name="datasetId">
        /// ID of the dataset associated with this evaluation
        /// </param>
        /// <param name="isBlueprint">
        /// Whether this is a blueprint (pipeline definition) or a batch run
        /// </param>
        /// <param name="tags">
        /// Tags associated with this evaluation
        /// </param>
        /// <param name="deleted">
        /// Whether this evaluation has been deleted
        /// </param>
        /// <param name="parentReportId">
        /// ID of the parent blueprint (set for batch runs)
        /// </param>
        /// <param name="scoreConfiguration">
        /// Custom scoring configuration for this evaluation
        /// </param>
        /// <param name="runs">
        /// Batch runs for this evaluation. Only present when include_runs=true.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Evaluation(
            int id,
            string name,
            int workspaceId,
            string? comment,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            int? folderId,
            int? userId,
            int? datasetId,
            bool? isBlueprint,
            object? tags,
            bool? deleted,
            int? parentReportId,
            object? scoreConfiguration,
            global::System.Collections.Generic.IList<global::G.EvaluationRun>? runs)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
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
            this.Runs = runs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Evaluation" /> class.
        /// </summary>
        public Evaluation()
        {
        }
    }
}