//HintName: G.Models.ExperimentWrite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentWrite
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
        public global::G.JsonListStringWrite? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ExperimentWriteTypeJsonConverter))]
        public global::G.ExperimentWriteType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluation_method")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ExperimentWriteEvaluationMethodJsonConverter))]
        public global::G.ExperimentWriteEvaluationMethod? EvaluationMethod { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("optimization_id")]
        public global::System.Guid? OptimizationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ExperimentWriteStatusJsonConverter))]
        public global::G.ExperimentWriteStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiment_scores")]
        public global::System.Collections.Generic.IList<global::G.ExperimentScoreWrite>? ExperimentScores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_version")]
        public global::G.PromptVersionLinkWrite? PromptVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_versions")]
        public global::System.Collections.Generic.IList<global::G.PromptVersionLinkWrite>? PromptVersions { get; set; }

        /// <summary>
        /// ID of the dataset version this experiment is linked to. If not provided at creation, experiment will be automatically linked to the latest version.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_version_id")]
        public global::System.Guid? DatasetVersionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentWrite" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="datasetName"></param>
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
        /// <param name="status"></param>
        /// <param name="experimentScores"></param>
        /// <param name="promptVersion"></param>
        /// <param name="promptVersions"></param>
        /// <param name="datasetVersionId">
        /// ID of the dataset version this experiment is linked to. If not provided at creation, experiment will be automatically linked to the latest version.
        /// </param>
        public ExperimentWrite(
            global::System.Guid? id,
            string? datasetName,
            global::System.Guid? projectId,
            string? projectName,
            string? name,
            global::G.JsonListStringWrite? metadata,
            global::System.Collections.Generic.IList<string>? tags,
            global::G.ExperimentWriteType? type,
            global::G.ExperimentWriteEvaluationMethod? evaluationMethod,
            global::System.Guid? optimizationId,
            global::G.ExperimentWriteStatus? status,
            global::System.Collections.Generic.IList<global::G.ExperimentScoreWrite>? experimentScores,
            global::G.PromptVersionLinkWrite? promptVersion,
            global::System.Collections.Generic.IList<global::G.PromptVersionLinkWrite>? promptVersions,
            global::System.Guid? datasetVersionId)
        {
            this.Id = id;
            this.DatasetName = datasetName;
            this.ProjectId = projectId;
            this.ProjectName = projectName;
            this.Name = name;
            this.Metadata = metadata;
            this.Tags = tags;
            this.Type = type;
            this.EvaluationMethod = evaluationMethod;
            this.OptimizationId = optimizationId;
            this.Status = status;
            this.ExperimentScores = experimentScores;
            this.PromptVersion = promptVersion;
            this.PromptVersions = promptVersions;
            this.DatasetVersionId = datasetVersionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentWrite" /> class.
        /// </summary>
        public ExperimentWrite()
        {
        }
    }
}