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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The ID of the dataset associated with the experiment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetId { get; set; }

        /// <summary>
        /// The ID of the dataset version associated with the experiment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetVersionId { get; set; }

        /// <summary>
        /// Number of times the experiment is repeated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repetitions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Repetitions { get; set; }

        /// <summary>
        /// Metadata of the experiment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Metadata { get; set; }

        /// <summary>
        /// The name of the project associated with the experiment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        /// The creation timestamp of the experiment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The last update timestamp of the experiment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Number of examples in the experiment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("example_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExampleCount { get; set; }

        /// <summary>
        /// Number of successful runs in the experiment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("successful_run_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SuccessfulRunCount { get; set; }

        /// <summary>
        /// Number of failed runs in the experiment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_run_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FailedRunCount { get; set; }

        /// <summary>
        /// Number of missing (not yet executed) runs in the experiment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("missing_run_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MissingRunCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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