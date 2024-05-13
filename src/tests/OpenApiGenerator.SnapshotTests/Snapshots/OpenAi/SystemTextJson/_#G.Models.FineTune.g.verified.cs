//HintName: G.Models.FineTune.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The `FineTune` object represents a legacy fine-tune job that has been created through the API.
    /// </summary>
    public sealed partial class FineTune
    {
        /// <summary>
        /// The object identifier, which can be referenced in the API endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the fine-tuning job was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// The list of events that have been observed in the lifecycle of the FineTune job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<FineTuneEvent?>? Events { get; set; }

        /// <summary>
        /// The name of the fine-tuned model that is being created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fine_tuned_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? FineTunedModel { get; set; }

        /// <summary>
        /// The hyperparameters used for the fine-tuning job. See the [fine-tuning guide](/docs/guides/legacy-fine-tuning/hyperparameters) for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hyperparams")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required FineTuneHyperparams Hyperparams { get; set; }

        /// <summary>
        /// The base model that is being fine-tuned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The object type, which is always "fine-tune".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Object { get; set; }

        /// <summary>
        /// The organization that owns the fine-tuning job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// The compiled results files for the fine-tuning job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<OpenAIFile> ResultFiles { get; set; }

        /// <summary>
        /// The current status of the fine-tuning job, which can be either `created`, `running`, `succeeded`, `failed`, or `cancelled`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// The list of files used for training.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<OpenAIFile> TrainingFiles { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the fine-tuning job was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UpdatedAt { get; set; }

        /// <summary>
        /// The list of files used for validation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<OpenAIFile> ValidationFiles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}