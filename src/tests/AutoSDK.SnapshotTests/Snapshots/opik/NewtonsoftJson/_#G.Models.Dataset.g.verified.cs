//HintName: G.Models.Dataset.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Dataset
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Project ID. Takes precedence over project_name when both are provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// For project scope, specify either project_id or project_name. If project_name is provided and the project does not exist, it will be created. Ignored when project_id is provided. If neither is provided, the dataset is created at workspace level.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.DatasetTypeJsonConverter))]
        public global::G.DatasetType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("visibility")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.DatasetVisibilityJsonConverter))]
        public global::G.DatasetVisibility? Visibility { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_by")]
        public string? LastUpdatedBy { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("experiment_count")]
        public long? ExperimentCount { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_items_count")]
        public long? DatasetItemsCount { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("optimization_count")]
        public long? OptimizationCount { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("most_recent_experiment_at")]
        public global::System.DateTime? MostRecentExperimentAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_created_experiment_at")]
        public global::System.DateTime? LastCreatedExperimentAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("most_recent_optimization_at")]
        public global::System.DateTime? MostRecentOptimizationAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_created_optimization_at")]
        public global::System.DateTime? LastCreatedOptimizationAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.DatasetStatusJsonConverter))]
        public global::G.DatasetStatus? Status { get; set; }

        /// <summary>
        /// Summary of the latest dataset version<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("latest_version")]
        public global::G.DatasetVersionSummary? LatestVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Dataset" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="projectId">
        /// Project ID. Takes precedence over project_name when both are provided.
        /// </param>
        /// <param name="projectName">
        /// For project scope, specify either project_id or project_name. If project_name is provided and the project does not exist, it will be created. Ignored when project_id is provided. If neither is provided, the dataset is created at workspace level.
        /// </param>
        /// <param name="type"></param>
        /// <param name="visibility"></param>
        /// <param name="tags"></param>
        /// <param name="description"></param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="createdBy">
        /// Included only in responses
        /// </param>
        /// <param name="lastUpdatedAt">
        /// Included only in responses
        /// </param>
        /// <param name="lastUpdatedBy">
        /// Included only in responses
        /// </param>
        /// <param name="experimentCount">
        /// Included only in responses
        /// </param>
        /// <param name="datasetItemsCount">
        /// Included only in responses
        /// </param>
        /// <param name="optimizationCount">
        /// Included only in responses
        /// </param>
        /// <param name="mostRecentExperimentAt">
        /// Included only in responses
        /// </param>
        /// <param name="lastCreatedExperimentAt">
        /// Included only in responses
        /// </param>
        /// <param name="mostRecentOptimizationAt">
        /// Included only in responses
        /// </param>
        /// <param name="lastCreatedOptimizationAt">
        /// Included only in responses
        /// </param>
        /// <param name="status">
        /// Included only in responses
        /// </param>
        /// <param name="latestVersion">
        /// Summary of the latest dataset version<br/>
        /// Included only in responses
        /// </param>
        public Dataset(
            string name,
            global::System.Guid? id,
            global::System.Guid? projectId,
            string? projectName,
            global::G.DatasetType? type,
            global::G.DatasetVisibility? visibility,
            global::System.Collections.Generic.IList<string>? tags,
            string? description,
            global::System.DateTime? createdAt,
            string? createdBy,
            global::System.DateTime? lastUpdatedAt,
            string? lastUpdatedBy,
            long? experimentCount,
            long? datasetItemsCount,
            long? optimizationCount,
            global::System.DateTime? mostRecentExperimentAt,
            global::System.DateTime? lastCreatedExperimentAt,
            global::System.DateTime? mostRecentOptimizationAt,
            global::System.DateTime? lastCreatedOptimizationAt,
            global::G.DatasetStatus? status,
            global::G.DatasetVersionSummary? latestVersion)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ProjectId = projectId;
            this.ProjectName = projectName;
            this.Type = type;
            this.Visibility = visibility;
            this.Tags = tags;
            this.Description = description;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.LastUpdatedAt = lastUpdatedAt;
            this.LastUpdatedBy = lastUpdatedBy;
            this.ExperimentCount = experimentCount;
            this.DatasetItemsCount = datasetItemsCount;
            this.OptimizationCount = optimizationCount;
            this.MostRecentExperimentAt = mostRecentExperimentAt;
            this.LastCreatedExperimentAt = lastCreatedExperimentAt;
            this.MostRecentOptimizationAt = mostRecentOptimizationAt;
            this.LastCreatedOptimizationAt = lastCreatedOptimizationAt;
            this.Status = status;
            this.LatestVersion = latestVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Dataset" /> class.
        /// </summary>
        public Dataset()
        {
        }
    }
}