//HintName: G.Models.ModelRunRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelRunRequest
    {
        /// <summary>
        /// Job ID for inference job for a ModelRun e.g. Adala job ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_id")]
        public string? JobId { get; set; }

        /// <summary>
        /// When true, only tasks without successful predictions for this prompt version are submitted for inference.<br/>
        /// Default Value: false<br/>
        /// Included only in requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("only_missing_predictions")]
        public bool? OnlyMissingPredictions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization")]
        public int? Organization { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("predictions_updated_at")]
        public global::System.DateTime? PredictionsUpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project", Required = global::Newtonsoft.Json.Required.Always)]
        public int Project { get; set; } = default!;

        /// <summary>
        /// * `All` - All<br/>
        /// * `HasGT` - HasGT<br/>
        /// * `Sample` - Sample
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_subset")]
        public global::G.ProjectSubsetEnum? ProjectSubset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_correct_predictions")]
        public int? TotalCorrectPredictions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_predictions")]
        public int? TotalPredictions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_tasks")]
        public int? TotalTasks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelRunRequest" /> class.
        /// </summary>
        /// <param name="project"></param>
        /// <param name="jobId">
        /// Job ID for inference job for a ModelRun e.g. Adala job ID
        /// </param>
        /// <param name="onlyMissingPredictions">
        /// When true, only tasks without successful predictions for this prompt version are submitted for inference.<br/>
        /// Default Value: false<br/>
        /// Included only in requests
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
        public ModelRunRequest(
            int project,
            string? jobId,
            bool? onlyMissingPredictions,
            int? organization,
            global::System.DateTime? predictionsUpdatedAt,
            global::G.ProjectSubsetEnum? projectSubset,
            int? totalCorrectPredictions,
            int? totalPredictions,
            int? totalTasks)
        {
            this.JobId = jobId;
            this.OnlyMissingPredictions = onlyMissingPredictions;
            this.Organization = organization;
            this.PredictionsUpdatedAt = predictionsUpdatedAt;
            this.Project = project;
            this.ProjectSubset = projectSubset;
            this.TotalCorrectPredictions = totalCorrectPredictions;
            this.TotalPredictions = totalPredictions;
            this.TotalTasks = totalTasks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelRunRequest" /> class.
        /// </summary>
        public ModelRunRequest()
        {
        }
    }
}