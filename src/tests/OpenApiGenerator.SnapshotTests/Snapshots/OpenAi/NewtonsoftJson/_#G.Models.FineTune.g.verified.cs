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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) for when the fine-tuning job was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreatedAt { get; set; } = default!;

        /// <summary>
        /// The list of events that have been observed in the lifecycle of the FineTune job.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("events")]
        public global::System.Collections.Generic.IList<FineTuneEvent?>? Events { get; set; }

        /// <summary>
        /// The name of the fine-tuned model that is being created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fine_tuned_model", Required = global::Newtonsoft.Json.Required.Always)]
        public string? FineTunedModel { get; set; } = default!;

        /// <summary>
        /// The hyperparameters used for the fine-tuning job. See the [fine-tuning guide](/docs/guides/legacy-fine-tuning/hyperparameters) for more details.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hyperparams", Required = global::Newtonsoft.Json.Required.Always)]
        public FineTuneHyperparams Hyperparams { get; set; } = default!;

        /// <summary>
        /// The base model that is being fine-tuned.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// The object type, which is always "fine-tune".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object", Required = global::Newtonsoft.Json.Required.Always)]
        public FineTuneObject Object { get; set; } = default!;

        /// <summary>
        /// The organization that owns the fine-tuning job.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrganizationId { get; set; } = default!;

        /// <summary>
        /// The compiled results files for the fine-tuning job.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result_files", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<OpenAIFile> ResultFiles { get; set; } = default!;

        /// <summary>
        /// The current status of the fine-tuning job, which can be either `created`, `running`, `succeeded`, `failed`, or `cancelled`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public string Status { get; set; } = default!;

        /// <summary>
        /// The list of files used for training.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("training_files", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<OpenAIFile> TrainingFiles { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) for when the fine-tuning job was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public int UpdatedAt { get; set; } = default!;

        /// <summary>
        /// The list of files used for validation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("validation_files", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<OpenAIFile> ValidationFiles { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}