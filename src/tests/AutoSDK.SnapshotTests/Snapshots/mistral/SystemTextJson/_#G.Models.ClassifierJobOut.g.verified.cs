//HintName: G.Models.ClassifierJobOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClassifierJobOut
    {
        /// <summary>
        /// The ID of the job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AutoStart { get; set; }

        /// <summary>
        /// The name of the model to fine-tune.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FineTuneableModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FineTuneableModel Model { get; set; }

        /// <summary>
        /// The current status of the fine-tuning job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ClassifierJobOutStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ClassifierJobOutStatus Status { get; set; }

        /// <summary>
        /// The UNIX timestamp (in seconds) for when the fine-tuning job was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The UNIX timestamp (in seconds) for when the fine-tuning job was last modified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset ModifiedAt { get; set; }

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
        /// The object type of the fine-tuning job.<br/>
        /// Default Value: job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ClassifierJobOutObjectJsonConverter))]
        public global::G.ClassifierJobOutObject? Object { get; set; }

        /// <summary>
        /// The name of the fine-tuned model that is being created. The value will be `null` if the fine-tuning job is still running.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fine_tuned_model")]
        public string? FineTunedModel { get; set; }

        /// <summary>
        /// Optional text/code that adds more context for the model. When given a `prompt` and a `suffix` the model will fill what is between them. When `suffix` is not provided, the model will simply execute completion starting with `prompt`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suffix")]
        public string? Suffix { get; set; }

        /// <summary>
        /// A list of integrations enabled for your fine-tuning job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrations")]
        public global::System.Collections.Generic.IList<global::G.IntegrationsVariant1Item>? Integrations { get; set; }

        /// <summary>
        /// Total number of tokens trained.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trained_tokens")]
        public int? TrainedTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.JobMetadataOut? Metadata { get; set; }

        /// <summary>
        /// The type of job (`FT` for fine-tuning).<br/>
        /// Default Value: classifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ClassifierJobOutJobTypeJsonConverter))]
        public global::G.ClassifierJobOutJobType? JobType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hyperparameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ClassifierTrainingParameters Hyperparameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifierJobOut" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the job.
        /// </param>
        /// <param name="autoStart"></param>
        /// <param name="model">
        /// The name of the model to fine-tune.
        /// </param>
        /// <param name="status">
        /// The current status of the fine-tuning job.
        /// </param>
        /// <param name="createdAt">
        /// The UNIX timestamp (in seconds) for when the fine-tuning job was created.
        /// </param>
        /// <param name="modifiedAt">
        /// The UNIX timestamp (in seconds) for when the fine-tuning job was last modified.
        /// </param>
        /// <param name="trainingFiles">
        /// A list containing the IDs of uploaded files that contain training data.
        /// </param>
        /// <param name="validationFiles">
        /// A list containing the IDs of uploaded files that contain validation data.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="object">
        /// The object type of the fine-tuning job.<br/>
        /// Default Value: job
        /// </param>
        /// <param name="fineTunedModel">
        /// The name of the fine-tuned model that is being created. The value will be `null` if the fine-tuning job is still running.
        /// </param>
        /// <param name="suffix">
        /// Optional text/code that adds more context for the model. When given a `prompt` and a `suffix` the model will fill what is between them. When `suffix` is not provided, the model will simply execute completion starting with `prompt`.
        /// </param>
        /// <param name="integrations">
        /// A list of integrations enabled for your fine-tuning job.
        /// </param>
        /// <param name="trainedTokens">
        /// Total number of tokens trained.
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="jobType">
        /// The type of job (`FT` for fine-tuning).<br/>
        /// Default Value: classifier
        /// </param>
        /// <param name="hyperparameters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassifierJobOut(
            global::System.Guid id,
            bool autoStart,
            global::G.FineTuneableModel model,
            global::G.ClassifierJobOutStatus status,
            global::System.DateTimeOffset createdAt,
            global::System.DateTimeOffset modifiedAt,
            global::System.Collections.Generic.IList<global::System.Guid> trainingFiles,
            global::G.ClassifierTrainingParameters hyperparameters,
            global::System.Collections.Generic.IList<global::System.Guid>? validationFiles,
            global::G.ClassifierJobOutObject? @object,
            string? fineTunedModel,
            string? suffix,
            global::System.Collections.Generic.IList<global::G.IntegrationsVariant1Item>? integrations,
            int? trainedTokens,
            global::G.JobMetadataOut? metadata,
            global::G.ClassifierJobOutJobType? jobType)
        {
            this.Id = id;
            this.AutoStart = autoStart;
            this.Model = model;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
            this.TrainingFiles = trainingFiles ?? throw new global::System.ArgumentNullException(nameof(trainingFiles));
            this.Hyperparameters = hyperparameters ?? throw new global::System.ArgumentNullException(nameof(hyperparameters));
            this.ValidationFiles = validationFiles;
            this.Object = @object;
            this.FineTunedModel = fineTunedModel;
            this.Suffix = suffix;
            this.Integrations = integrations;
            this.TrainedTokens = trainedTokens;
            this.Metadata = metadata;
            this.JobType = jobType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifierJobOut" /> class.
        /// </summary>
        public ClassifierJobOut()
        {
        }
    }
}