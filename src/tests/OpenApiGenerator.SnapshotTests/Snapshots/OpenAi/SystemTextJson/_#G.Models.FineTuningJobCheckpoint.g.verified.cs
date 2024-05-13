//HintName: G.Models.FineTuningJobCheckpoint.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The `fine_tuning.job.checkpoint` object represents a model checkpoint for a fine-tuning job that is ready to use.
    /// </summary>
    public sealed partial class FineTuningJobCheckpoint
    {
        /// <summary>
        /// The checkpoint identifier, which can be referenced in the API endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the checkpoint was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// The name of the fine-tuned checkpoint model that is created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fine_tuned_model_checkpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FineTunedModelCheckpoint { get; set; }

        /// <summary>
        /// The step number that the checkpoint was created at.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("step_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StepNumber { get; set; }

        /// <summary>
        /// Metrics at the step number during the fine-tuning job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required FineTuningJobCheckpointMetrics Metrics { get; set; }

        /// <summary>
        /// The name of the fine-tuning job that this checkpoint was created from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fine_tuning_job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FineTuningJobId { get; set; }

        /// <summary>
        /// The object type, which is always "fine_tuning.job.checkpoint".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}