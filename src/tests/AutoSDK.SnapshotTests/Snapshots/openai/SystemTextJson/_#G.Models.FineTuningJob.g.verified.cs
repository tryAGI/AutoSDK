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
        /// The object identifier, which can be referenced in the API endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the fine-tuning job was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// For fine-tuning jobs that have `failed`, this will contain more information on the cause of the failure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FineTuningJobError? Error { get; set; }

        /// <summary>
        /// The name of the fine-tuned model that is being created. The value will be null if the fine-tuning job is still running.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fine_tuned_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? FineTunedModel { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the fine-tuning job was finished. The value will be null if the fine-tuning job is still running.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finished_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset? FinishedAt { get; set; }

        /// <summary>
        /// The hyperparameters used for the fine-tuning job. This value will only be returned when running `supervised` jobs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hyperparameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FineTuningJobHyperparameters Hyperparameters { get; set; }

        /// <summary>
        /// The base model that is being fine-tuned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The object type, which is always "fine_tuning.job".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FineTuningJobObjectJsonConverter))]
        public global::G.FineTuningJobObject Object { get; set; }

        /// <summary>
        /// The organization that owns the fine-tuning job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// The compiled results file ID(s) for the fine-tuning job. You can retrieve the results with the [Files API](/docs/api-reference/files/retrieve-contents).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ResultFiles { get; set; }

        /// <summary>
        /// The current status of the fine-tuning job, which can be either `validating_files`, `queued`, `running`, `succeeded`, `failed`, or `cancelled`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FineTuningJobStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FineTuningJobStatus Status { get; set; }

        /// <summary>
        /// The total number of billable tokens processed by this fine-tuning job. The value will be null if the fine-tuning job is still running.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trained_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? TrainedTokens { get; set; }

        /// <summary>
        /// The file ID used for training. You can retrieve the training data with the [Files API](/docs/api-reference/files/retrieve-contents).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TrainingFile { get; set; }

        /// <summary>
        /// The file ID used for validation. You can retrieve the validation results with the [Files API](/docs/api-reference/files/retrieve-contents).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? ValidationFile { get; set; }

        /// <summary>
        /// A list of integrations to enable for this fine-tuning job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrations")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.FineTuningIntegration>>? Integrations { get; set; }

        /// <summary>
        /// The seed used for the fine-tuning job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Seed { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the fine-tuning job is estimated to finish. The value will be null if the fine-tuning job is not running.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimated_finish")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? EstimatedFinish { get; set; }

        /// <summary>
        /// The method used for fine-tuning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public global::G.FineTuneMethod? Method { get; set; }

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningJob" /> class.
        /// </summary>
        /// <param name="id">
        /// The object identifier, which can be referenced in the API endpoints.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) for when the fine-tuning job was created.
        /// </param>
        /// <param name="error">
        /// For fine-tuning jobs that have `failed`, this will contain more information on the cause of the failure.
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
        /// <param name="integrations">
        /// A list of integrations to enable for this fine-tuning job.
        /// </param>
        /// <param name="seed">
        /// The seed used for the fine-tuning job.
        /// </param>
        /// <param name="estimatedFinish">
        /// The Unix timestamp (in seconds) for when the fine-tuning job is estimated to finish. The value will be null if the fine-tuning job is not running.
        /// </param>
        /// <param name="method">
        /// The method used for fine-tuning.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTuningJob(
            string id,
            global::System.DateTimeOffset createdAt,
            global::G.FineTuningJobError? error,
            string? fineTunedModel,
            global::System.DateTimeOffset? finishedAt,
            global::G.FineTuningJobHyperparameters hyperparameters,
            string model,
            string organizationId,
            global::System.Collections.Generic.IList<string> resultFiles,
            global::G.FineTuningJobStatus status,
            int? trainedTokens,
            string trainingFile,
            string? validationFile,
            int seed,
            global::G.FineTuningJobObject @object,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.FineTuningIntegration>>? integrations,
            global::System.DateTimeOffset? estimatedFinish,
            global::G.FineTuneMethod? method,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.FineTunedModel = fineTunedModel ?? throw new global::System.ArgumentNullException(nameof(fineTunedModel));
            this.FinishedAt = finishedAt;
            this.Hyperparameters = hyperparameters ?? throw new global::System.ArgumentNullException(nameof(hyperparameters));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.ResultFiles = resultFiles ?? throw new global::System.ArgumentNullException(nameof(resultFiles));
            this.Status = status;
            this.TrainedTokens = trainedTokens;
            this.TrainingFile = trainingFile ?? throw new global::System.ArgumentNullException(nameof(trainingFile));
            this.ValidationFile = validationFile ?? throw new global::System.ArgumentNullException(nameof(validationFile));
            this.Seed = seed;
            this.Object = @object;
            this.Integrations = integrations;
            this.EstimatedFinish = estimatedFinish;
            this.Method = method;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuningJob" /> class.
        /// </summary>
        public FineTuningJob()
        {
        }
    }
}