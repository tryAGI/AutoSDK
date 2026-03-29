//HintName: G.Models.Experiment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Experiment
    {
        /// <summary>
        /// The ID of the experiment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The ID of the dataset associated with the experiment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DatasetId { get; set; } = default!;

        /// <summary>
        /// The ID of the dataset version associated with the experiment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_version_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DatasetVersionId { get; set; } = default!;

        /// <summary>
        /// Number of times the experiment is repeated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repetitions", Required = global::Newtonsoft.Json.Required.Always)]
        public int Repetitions { get; set; } = default!;

        /// <summary>
        /// Metadata of the experiment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public object Metadata { get; set; } = default!;

        /// <summary>
        /// The name of the project associated with the experiment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// The creation timestamp of the experiment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The last update timestamp of the experiment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Number of examples in the experiment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("example_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int ExampleCount { get; set; } = default!;

        /// <summary>
        /// Number of successful runs in the experiment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("successful_run_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int SuccessfulRunCount { get; set; } = default!;

        /// <summary>
        /// Number of failed runs in the experiment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("failed_run_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int FailedRunCount { get; set; } = default!;

        /// <summary>
        /// Number of missing (not yet executed) runs in the experiment
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("missing_run_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int MissingRunCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Experiment" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the experiment
        /// </param>
        /// <param name="datasetId">
        /// The ID of the dataset associated with the experiment
        /// </param>
        /// <param name="datasetVersionId">
        /// The ID of the dataset version associated with the experiment
        /// </param>
        /// <param name="repetitions">
        /// Number of times the experiment is repeated
        /// </param>
        /// <param name="metadata">
        /// Metadata of the experiment
        /// </param>
        /// <param name="createdAt">
        /// The creation timestamp of the experiment
        /// </param>
        /// <param name="updatedAt">
        /// The last update timestamp of the experiment
        /// </param>
        /// <param name="exampleCount">
        /// Number of examples in the experiment
        /// </param>
        /// <param name="successfulRunCount">
        /// Number of successful runs in the experiment
        /// </param>
        /// <param name="failedRunCount">
        /// Number of failed runs in the experiment
        /// </param>
        /// <param name="missingRunCount">
        /// Number of missing (not yet executed) runs in the experiment
        /// </param>
        /// <param name="projectName">
        /// The name of the project associated with the experiment
        /// </param>
        public Experiment(
            string id,
            string datasetId,
            string datasetVersionId,
            int repetitions,
            object metadata,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            int exampleCount,
            int successfulRunCount,
            int failedRunCount,
            int missingRunCount,
            string? projectName)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.DatasetVersionId = datasetVersionId ?? throw new global::System.ArgumentNullException(nameof(datasetVersionId));
            this.Repetitions = repetitions;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.ProjectName = projectName;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ExampleCount = exampleCount;
            this.SuccessfulRunCount = successfulRunCount;
            this.FailedRunCount = failedRunCount;
            this.MissingRunCount = missingRunCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Experiment" /> class.
        /// </summary>
        public Experiment()
        {
        }
    }
}