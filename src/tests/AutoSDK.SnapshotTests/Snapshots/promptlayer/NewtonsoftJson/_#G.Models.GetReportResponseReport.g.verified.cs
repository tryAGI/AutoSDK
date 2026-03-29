//HintName: G.Models.GetReportResponseReport.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The report data with all fields
    /// </summary>
    public sealed partial class GetReportResponseReport
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_blueprint")]
        public bool? IsBlueprint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Deleted { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Report score data
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score")]
        public object? Score { get; set; }

        /// <summary>
        /// Score configuration settings
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score_configuration")]
        public object? ScoreConfiguration { get; set; }

        /// <summary>
        /// Score matrix for custom scoring
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score_matrix")]
        public byte[]? ScoreMatrix { get; set; }

        /// <summary>
        /// Error message if score calculation failed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score_calculation_error")]
        public string? ScoreCalculationError { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_report_id")]
        public int? ParentReportId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_id")]
        public int? DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id")]
        public int? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int WorkspaceId { get; set; } = default!;

        /// <summary>
        /// ID of associated prompt registry
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_registry_id")]
        public int? PromptRegistryId { get; set; }

        /// <summary>
        /// Version number of associated prompt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_version_number")]
        public int? PromptVersionNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReportResponseReport" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="deleted"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="workspaceId"></param>
        /// <param name="comment"></param>
        /// <param name="isBlueprint"></param>
        /// <param name="score">
        /// Report score data
        /// </param>
        /// <param name="scoreConfiguration">
        /// Score configuration settings
        /// </param>
        /// <param name="scoreMatrix">
        /// Score matrix for custom scoring
        /// </param>
        /// <param name="scoreCalculationError">
        /// Error message if score calculation failed
        /// </param>
        /// <param name="parentReportId"></param>
        /// <param name="datasetId"></param>
        /// <param name="userId"></param>
        /// <param name="promptRegistryId">
        /// ID of associated prompt registry
        /// </param>
        /// <param name="promptVersionNumber">
        /// Version number of associated prompt
        /// </param>
        public GetReportResponseReport(
            int id,
            string name,
            bool deleted,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            int workspaceId,
            string? comment,
            bool? isBlueprint,
            object? score,
            object? scoreConfiguration,
            byte[]? scoreMatrix,
            string? scoreCalculationError,
            int? parentReportId,
            int? datasetId,
            int? userId,
            int? promptRegistryId,
            int? promptVersionNumber)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Comment = comment;
            this.IsBlueprint = isBlueprint;
            this.Deleted = deleted;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Score = score;
            this.ScoreConfiguration = scoreConfiguration;
            this.ScoreMatrix = scoreMatrix;
            this.ScoreCalculationError = scoreCalculationError;
            this.ParentReportId = parentReportId;
            this.DatasetId = datasetId;
            this.UserId = userId;
            this.WorkspaceId = workspaceId;
            this.PromptRegistryId = promptRegistryId;
            this.PromptVersionNumber = promptVersionNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetReportResponseReport" /> class.
        /// </summary>
        public GetReportResponseReport()
        {
        }
    }
}