//HintName: G.Models.OptimizationWrite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OptimizationWrite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DatasetName { get; set; } = default!;

        /// <summary>
        /// Project name. Creates project if it doesn't exist. Ignored when project_id is provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// Project ID. Takes precedence over project_name when both are provided.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("objective_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ObjectiveName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OptimizationWriteStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.JsonListStringWrite? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("studio_config")]
        public global::G.OptimizationStudioConfigWrite? StudioConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizationWrite" /> class.
        /// </summary>
        /// <param name="datasetName"></param>
        /// <param name="objectiveName"></param>
        /// <param name="status"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="projectName">
        /// Project name. Creates project if it doesn't exist. Ignored when project_id is provided.
        /// </param>
        /// <param name="projectId">
        /// Project ID. Takes precedence over project_name when both are provided.
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="studioConfig"></param>
        /// <param name="lastUpdatedAt"></param>
        public OptimizationWrite(
            string datasetName,
            string objectiveName,
            global::G.OptimizationWriteStatus status,
            global::System.Guid? id,
            string? name,
            string? projectName,
            global::System.Guid? projectId,
            global::G.JsonListStringWrite? metadata,
            global::G.OptimizationStudioConfigWrite? studioConfig,
            global::System.DateTime? lastUpdatedAt)
        {
            this.Id = id;
            this.Name = name;
            this.DatasetName = datasetName ?? throw new global::System.ArgumentNullException(nameof(datasetName));
            this.ProjectName = projectName;
            this.ProjectId = projectId;
            this.ObjectiveName = objectiveName ?? throw new global::System.ArgumentNullException(nameof(objectiveName));
            this.Status = status;
            this.Metadata = metadata;
            this.StudioConfig = studioConfig;
            this.LastUpdatedAt = lastUpdatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OptimizationWrite" /> class.
        /// </summary>
        public OptimizationWrite()
        {
        }
    }
}