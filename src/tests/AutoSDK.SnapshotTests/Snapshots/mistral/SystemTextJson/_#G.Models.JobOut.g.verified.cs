//HintName: G.Models.JobOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JobOut
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AutoStart { get; set; }

        /// <summary>
        /// The UNIX timestamp (in seconds) for when the fine-tuning job was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The name of the fine-tuned model that is being created. The value will be `null` if the fine-tuning job is still running.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fine_tuned_model")]
        public string? FineTunedModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hyperparameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TrainingParameters Hyperparameters { get; set; }

        /// <summary>
        /// The ID of the job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// A list of integrations enabled for your fine-tuning job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrations")]
        public global::System.Collections.Generic.IList<global::G.IntegrationsItem3>? Integrations { get; set; }

        /// <summary>
        /// The type of job (`FT` for fine-tuning).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string JobType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The name of the model to fine-tune.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FineTuneableModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FineTuneableModel Model { get; set; }

        /// <summary>
        /// The UNIX timestamp (in seconds) for when the fine-tuning job was last modified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset ModifiedAt { get; set; }

        /// <summary>
        /// The object type of the fine-tuning job.<br/>
        /// Default Value: job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.JobOutObjectJsonConverter))]
        public global::G.JobOutObject? Object { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories")]
        public global::System.Collections.Generic.IList<global::G.RepositoriesItem3>? Repositories { get; set; }

        /// <summary>
        /// The current status of the fine-tuning job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.JobOutStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.JobOutStatus Status { get; set; }

        /// <summary>
        /// Optional text/code that adds more context for the model. When given a `prompt` and a `suffix` the model will fill what is between them. When `suffix` is not provided, the model will simply execute completion starting with `prompt`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suffix")]
        public string? Suffix { get; set; }

        /// <summary>
        /// Total number of tokens trained.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trained_tokens")]
        public int? TrainedTokens { get; set; }

        /// <summary>
        /// A list containing the IDs of uploaded files that contain training data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> TrainingFiles { get; set; }

        /// <summary>
        /// A list containing the IDs of uploaded files that contain validation data.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_files")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ValidationFiles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobOut" /> class.
        /// </summary>
        /// <param name="autoStart"></param>
        /// <param name="createdAt">
        /// The UNIX timestamp (in seconds) for when the fine-tuning job was created.
        /// </param>
        /// <param name="fineTunedModel">
        /// The name of the fine-tuned model that is being created. The value will be `null` if the fine-tuning job is still running.
        /// </param>
        /// <param name="hyperparameters"></param>
        /// <param name="id">
        /// The ID of the job.
        /// </param>
        /// <param name="integrations">
        /// A list of integrations enabled for your fine-tuning job.
        /// </param>
        /// <param name="jobType">
        /// The type of job (`FT` for fine-tuning).
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="model">
        /// The name of the model to fine-tune.
        /// </param>
        /// <param name="modifiedAt">
        /// The UNIX timestamp (in seconds) for when the fine-tuning job was last modified.
        /// </param>
        /// <param name="object">
        /// The object type of the fine-tuning job.<br/>
        /// Default Value: job
        /// </param>
        /// <param name="repositories">
        /// Default Value: []
        /// </param>
        /// <param name="status">
        /// The current status of the fine-tuning job.
        /// </param>
        /// <param name="suffix">
        /// Optional text/code that adds more context for the model. When given a `prompt` and a `suffix` the model will fill what is between them. When `suffix` is not provided, the model will simply execute completion starting with `prompt`.
        /// </param>
        /// <param name="trainedTokens">
        /// Total number of tokens trained.
        /// </param>
        /// <param name="trainingFiles">
        /// A list containing the IDs of uploaded files that contain training data.
        /// </param>
        /// <param name="validationFiles">
        /// A list containing the IDs of uploaded files that contain validation data.<br/>
        /// Default Value: []
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public JobOut(
            bool autoStart,
            global::System.DateTimeOffset createdAt,
            global::G.TrainingParameters hyperparameters,
            global::System.Guid id,
            string jobType,
            global::G.FineTuneableModel model,
            global::System.DateTimeOffset modifiedAt,
            global::G.JobOutStatus status,
            global::System.Collections.Generic.IList<global::System.Guid> trainingFiles,
            string? fineTunedModel,
            global::System.Collections.Generic.IList<global::G.IntegrationsItem3>? integrations,
            object? metadata,
            global::G.JobOutObject? @object,
            global::System.Collections.Generic.IList<global::G.RepositoriesItem3>? repositories,
            string? suffix,
            int? trainedTokens,
            global::System.Collections.Generic.IList<global::System.Guid>? validationFiles)
        {
            this.AutoStart = autoStart;
            this.CreatedAt = createdAt;
            this.Hyperparameters = hyperparameters ?? throw new global::System.ArgumentNullException(nameof(hyperparameters));
            this.Id = id;
            this.JobType = jobType ?? throw new global::System.ArgumentNullException(nameof(jobType));
            this.Model = model;
            this.ModifiedAt = modifiedAt;
            this.Status = status;
            this.TrainingFiles = trainingFiles ?? throw new global::System.ArgumentNullException(nameof(trainingFiles));
            this.FineTunedModel = fineTunedModel;
            this.Integrations = integrations;
            this.Metadata = metadata;
            this.Object = @object;
            this.Repositories = repositories;
            this.Suffix = suffix;
            this.TrainedTokens = trainedTokens;
            this.ValidationFiles = validationFiles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobOut" /> class.
        /// </summary>
        public JobOut()
        {
        }
    }
}