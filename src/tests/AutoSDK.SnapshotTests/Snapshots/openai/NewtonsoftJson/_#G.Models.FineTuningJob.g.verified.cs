//HintName: G.Models.FineTuningJob.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The `fine_tuning.job` object represents a fine-tuning job that has been created through the API.
    /// </summary>
    public sealed partial class FineTuningJob
    {
        /// <summary>
        /// The Unix timestamp (in seconds) for when the fine-tuning job was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// For fine-tuning jobs that have `failed`, this will contain more information on the cause of the failure.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FineTuningJobError? Error { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) for when the fine-tuning job is estimated to finish. The value will be null if the fine-tuning job is not running.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("estimated_finish")]
        public global::System.DateTimeOffset? EstimatedFinish { get; set; }

        /// <summary>
        /// The name of the fine-tuned model that is being created. The value will be null if the fine-tuning job is still running.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fine_tuned_model", Required = global::Newtonsoft.Json.Required.Always)]
        public string? FineTunedModel { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) for when the fine-tuning job was finished. The value will be null if the fine-tuning job is still running.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("finished_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset? FinishedAt { get; set; } = default!;

        /// <summary>
        /// The hyperparameters used for the fine-tuning job. This value will only be returned when running `supervised` jobs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hyperparameters", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FineTuningJobHyperparameters Hyperparameters { get; set; } = default!;

        /// <summary>
        /// The object identifier, which can be referenced in the API endpoints.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// A list of integrations to enable for this fine-tuning job.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("integrations")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.FineTuningIntegration>>? Integrations { get; set; }

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// The method used for fine-tuning.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("method")]
        public global::G.FineTuneMethod? Method { get; set; }

        /// <summary>
        /// The base model that is being fine-tuned.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// The object type, which is always "fine_tuning.job".
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.FineTuningJobObject Object { get; set; }

        /// <summary>
        /// The organization that owns the fine-tuning job.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string OrganizationId { get; set; } = default!;

        /// <summary>
        /// The compiled results file ID(s) for the fine-tuning job. You can retrieve the results with the [Files API](/docs/api-reference/files/retrieve-contents).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("result_files", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> ResultFiles { get; set; } = default!;

        /// <summary>
        /// The seed used for the fine-tuning job.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("seed", Required = global::Newtonsoft.Json.Required.Always)]
        public int Seed { get; set; } = default!;

        /// <summary>
        /// The current status of the fine-tuning job, which can be either `validating_files`, `queued`, `running`, `succeeded`, `failed`, or `cancelled`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FineTuningJobStatus Status { get; set; } = default!;

        /// <summary>
        /// The total number of billable tokens processed by this fine-tuning job. The value will be null if the fine-tuning job is still running.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trained_tokens", Required = global::Newtonsoft.Json.Required.Always)]
        public int? TrainedTokens { get; set; } = default!;

        /// <summary>
        /// The file ID used for training. You can retrieve the training data with the [Files API](/docs/api-reference/files/retrieve-contents).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("training_file", Required = global::Newtonsoft.Json.Required.Always)]
        public string TrainingFile { get; set; } = default!;

        /// <summary>
        /// The file ID used for validation. You can retrieve the validation results with the [Files API](/docs/api-reference/files/retrieve-contents).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("validation_file", Required = global::Newtonsoft.Json.Required.Always)]
        public string? ValidationFile { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningJob" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) for when the fine-tuning job was created.
        /// </param>
        /// <param name="error">
        /// For fine-tuning jobs that have `failed`, this will contain more information on the cause of the failure.
        /// </param>
        /// <param name="estimatedFinish">
        /// The Unix timestamp (in seconds) for when the fine-tuning job is estimated to finish. The value will be null if the fine-tuning job is not running.
        /// </param>
        /// <param name="fineTunedModel">
        /// The name of the fine-tuned model that is being created. The value will be null if the fine-tuning job is still running.
        /// </param>
        /// <param name="finishedAt">
        /// The Unix timestamp (in seconds) for when the fine-tuning job was finished. The value will be null if the fine-tuning job is still running.
        /// </param>
        /// <param name="hyperparameters">
        /// The hyperparameters used for the fine-tuning job. This value will only be returned when running `supervised` jobs.
        /// </param>
        /// <param name="id">
        /// The object identifier, which can be referenced in the API endpoints.
        /// </param>
        /// <param name="integrations">
        /// A list of integrations to enable for this fine-tuning job.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
        /// <param name="method">
        /// The method used for fine-tuning.
        /// </param>
        /// <param name="model">
        /// The base model that is being fine-tuned.
        /// </param>
        /// <param name="object">
        /// The object type, which is always "fine_tuning.job".
        /// </param>
        /// <param name="organizationId">
        /// The organization that owns the fine-tuning job.
        /// </param>
        /// <param name="resultFiles">
        /// The compiled results file ID(s) for the fine-tuning job. You can retrieve the results with the [Files API](/docs/api-reference/files/retrieve-contents).
        /// </param>
        /// <param name="seed">
        /// The seed used for the fine-tuning job.
        /// </param>
        /// <param name="status">
        /// The current status of the fine-tuning job, which can be either `validating_files`, `queued`, `running`, `succeeded`, `failed`, or `cancelled`.
        /// </param>
        /// <param name="trainedTokens">
        /// The total number of billable tokens processed by this fine-tuning job. The value will be null if the fine-tuning job is still running.
        /// </param>
        /// <param name="trainingFile">
        /// The file ID used for training. You can retrieve the training data with the [Files API](/docs/api-reference/files/retrieve-contents).
        /// </param>
        /// <param name="validationFile">
        /// The file ID used for validation. You can retrieve the validation results with the [Files API](/docs/api-reference/files/retrieve-contents).
        /// </param>
        public FineTuningJob(
            global::System.DateTimeOffset createdAt,
            global::G.FineTuningJobError? error,
            string? fineTunedModel,
            global::System.DateTimeOffset? finishedAt,
            global::G.FineTuningJobHyperparameters hyperparameters,
            string id,
            string model,
            string organizationId,
            global::System.Collections.Generic.IList<string> resultFiles,
            int seed,
            global::G.FineTuningJobStatus status,
            int? trainedTokens,
            string trainingFile,
            string? validationFile,
            global::System.DateTimeOffset? estimatedFinish,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.FineTuningIntegration>>? integrations,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::G.FineTuneMethod? method,
            global::G.FineTuningJobObject @object)
        {
            this.CreatedAt = createdAt;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.FineTunedModel = fineTunedModel ?? throw new global::System.ArgumentNullException(nameof(fineTunedModel));
            this.FinishedAt = finishedAt;
            this.Hyperparameters = hyperparameters ?? throw new global::System.ArgumentNullException(nameof(hyperparameters));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.ResultFiles = resultFiles ?? throw new global::System.ArgumentNullException(nameof(resultFiles));
            this.Seed = seed;
            this.Status = status;
            this.TrainedTokens = trainedTokens;
            this.TrainingFile = trainingFile ?? throw new global::System.ArgumentNullException(nameof(trainingFile));
            this.ValidationFile = validationFile ?? throw new global::System.ArgumentNullException(nameof(validationFile));
            this.EstimatedFinish = estimatedFinish;
            this.Integrations = integrations;
            this.Metadata = metadata;
            this.Method = method;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningJob" /> class.
        /// </summary>
        public FineTuningJob()
        {
        }
    }
}