//HintName: G.Models.DetailedJobOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DetailedJobOut
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AutoStart { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoints")]
        public global::System.Collections.Generic.IList<global::G.CheckpointOut>? Checkpoints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// Event items are created every time the status of a fine-tuning job changes. The timestamped list of all events is accessible here.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<global::G.EventOut>? Events { get; set; }

        /// <summary>
        /// 
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrations")]
        public global::System.Collections.Generic.IList<global::G.IntegrationsItem>? Integrations { get; set; }

        /// <summary>
        /// 
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ModifiedAt { get; set; }

        /// <summary>
        /// Default Value: job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DetailedJobOutObjectJsonConverter))]
        public global::G.DetailedJobOutObject? Object { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories")]
        public global::System.Collections.Generic.IList<global::G.RepositoriesItem>? Repositories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DetailedJobOutStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DetailedJobOutStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suffix")]
        public string? Suffix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trained_tokens")]
        public int? TrainedTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> TrainingFiles { get; set; }

        /// <summary>
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
        /// Initializes a new instance of the <see cref="DetailedJobOut" /> class.
        /// </summary>
        /// <param name="autoStart"></param>
        /// <param name="checkpoints">
        /// Default Value: []
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="events">
        /// Event items are created every time the status of a fine-tuning job changes. The timestamped list of all events is accessible here.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="fineTunedModel"></param>
        /// <param name="hyperparameters"></param>
        /// <param name="id"></param>
        /// <param name="integrations"></param>
        /// <param name="jobType"></param>
        /// <param name="metadata"></param>
        /// <param name="model">
        /// The name of the model to fine-tune.
        /// </param>
        /// <param name="modifiedAt"></param>
        /// <param name="object">
        /// Default Value: job
        /// </param>
        /// <param name="repositories">
        /// Default Value: []
        /// </param>
        /// <param name="status"></param>
        /// <param name="suffix"></param>
        /// <param name="trainedTokens"></param>
        /// <param name="trainingFiles"></param>
        /// <param name="validationFiles">
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DetailedJobOut(
            bool autoStart,
            int createdAt,
            global::G.TrainingParameters hyperparameters,
            global::System.Guid id,
            string jobType,
            global::G.FineTuneableModel model,
            int modifiedAt,
            global::G.DetailedJobOutStatus status,
            global::System.Collections.Generic.IList<global::System.Guid> trainingFiles,
            global::System.Collections.Generic.IList<global::G.CheckpointOut>? checkpoints,
            global::System.Collections.Generic.IList<global::G.EventOut>? events,
            string? fineTunedModel,
            global::System.Collections.Generic.IList<global::G.IntegrationsItem>? integrations,
            object? metadata,
            global::G.DetailedJobOutObject? @object,
            global::System.Collections.Generic.IList<global::G.RepositoriesItem>? repositories,
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
            this.Checkpoints = checkpoints;
            this.Events = events;
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
        /// Initializes a new instance of the <see cref="DetailedJobOut" /> class.
        /// </summary>
        public DetailedJobOut()
        {
        }
    }
}