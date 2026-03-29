//HintName: G.Models.ModelRun.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelRun
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public int? CreatedBy { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Job ID for inference job for a ModelRun e.g. Adala job ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_id")]
        public string? JobId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        public int? Organization { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_model")]
        public int ParentModel { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predictions_updated_at")]
        public global::System.DateTime? PredictionsUpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Project { get; set; }

        /// <summary>
        /// * `All` - All<br/>
        /// * `HasGT` - HasGT<br/>
        /// * `Sample` - Sample
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_subset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProjectSubsetEnumJsonConverter))]
        public global::G.ProjectSubsetEnum? ProjectSubset { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ModelRunStatusEnumJsonConverter))]
        public global::G.ModelRunStatusEnum Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_correct_predictions")]
        public int? TotalCorrectPredictions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_predictions")]
        public int? TotalPredictions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tasks")]
        public int? TotalTasks { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggered_at")]
        public global::System.DateTime? TriggeredAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelRun" /> class.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="completedAt">
        /// Included only in responses
        /// </param>
        /// <param name="createdBy">
        /// Included only in responses
        /// </param>
        /// <param name="jobId">
        /// Job ID for inference job for a ModelRun e.g. Adala job ID
        /// </param>
        /// <param name="organization"></param>
        /// <param name="predictionsUpdatedAt"></param>
        /// <param name="projectSubset">
        /// * `All` - All<br/>
        /// * `HasGT` - HasGT<br/>
        /// * `Sample` - Sample
        /// </param>
        /// <param name="totalCorrectPredictions"></param>
        /// <param name="totalPredictions"></param>
        /// <param name="totalTasks"></param>
        /// <param name="triggeredAt">
        /// Included only in responses
        /// </param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="id">
        /// Included only in responses
        /// </param>
        /// <param name="parentModel">
        /// Included only in responses
        /// </param>
        /// <param name="status">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelRun(
            int project,
            global::System.DateTime? completedAt,
            int? createdBy,
            string? jobId,
            int? organization,
            global::System.DateTime? predictionsUpdatedAt,
            global::G.ProjectSubsetEnum? projectSubset,
            int? totalCorrectPredictions,
            int? totalPredictions,
            int? totalTasks,
            global::System.DateTime? triggeredAt,
            global::System.DateTime createdAt = default!,
            int id = default!,
            int parentModel = default!,
            global::G.ModelRunStatusEnum status = default!)
        {
            this.CompletedAt = completedAt;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.Id = id;
            this.JobId = jobId;
            this.Organization = organization;
            this.ParentModel = parentModel;
            this.PredictionsUpdatedAt = predictionsUpdatedAt;
            this.Project = project;
            this.ProjectSubset = projectSubset;
            this.Status = status;
            this.TotalCorrectPredictions = totalCorrectPredictions;
            this.TotalPredictions = totalPredictions;
            this.TotalTasks = totalTasks;
            this.TriggeredAt = triggeredAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelRun" /> class.
        /// </summary>
        public ModelRun()
        {
        }
    }
}