//HintName: G.Models.ClassifierDetailedJobOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClassifierDetailedJobOut
    {
        /// <summary>
        /// 
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ClassifierDetailedJobOutStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ClassifierDetailedJobOutStatus Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ModifiedAt { get; set; }

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
        /// Default Value: job
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ClassifierDetailedJobOutObjectJsonConverter))]
        public global::G.ClassifierDetailedJobOutObject? Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fine_tuned_model")]
        public string? FineTunedModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suffix")]
        public string? Suffix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrations")]
        public global::System.Collections.Generic.IList<global::G.IntegrationsVariant1Item4>? Integrations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trained_tokens")]
        public int? TrainedTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.JobMetadataOut? Metadata { get; set; }

        /// <summary>
        /// Default Value: classifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ClassifierDetailedJobOutJobTypeJsonConverter))]
        public global::G.ClassifierDetailedJobOutJobType? JobType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hyperparameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ClassifierTrainingParameters Hyperparameters { get; set; }

        /// <summary>
        /// Event items are created every time the status of a fine-tuning job changes. The timestamped list of all events is accessible here.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        public global::System.Collections.Generic.IList<global::G.EventOut>? Events { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoints")]
        public global::System.Collections.Generic.IList<global::G.CheckpointOut>? Checkpoints { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_targets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ClassifierTargetOut> ClassifierTargets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifierDetailedJobOut" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="autoStart"></param>
        /// <param name="model">
        /// The name of the model to fine-tune.
        /// </param>
        /// <param name="status"></param>
        /// <param name="createdAt"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="trainingFiles"></param>
        /// <param name="validationFiles">
        /// Default Value: []
        /// </param>
        /// <param name="object">
        /// Default Value: job
        /// </param>
        /// <param name="fineTunedModel"></param>
        /// <param name="suffix"></param>
        /// <param name="integrations"></param>
        /// <param name="trainedTokens"></param>
        /// <param name="metadata"></param>
        /// <param name="jobType">
        /// Default Value: classifier
        /// </param>
        /// <param name="hyperparameters"></param>
        /// <param name="events">
        /// Event items are created every time the status of a fine-tuning job changes. The timestamped list of all events is accessible here.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="checkpoints">
        /// Default Value: []
        /// </param>
        /// <param name="classifierTargets"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClassifierDetailedJobOut(
            global::System.Guid id,
            bool autoStart,
            global::G.FineTuneableModel model,
            global::G.ClassifierDetailedJobOutStatus status,
            int createdAt,
            int modifiedAt,
            global::System.Collections.Generic.IList<global::System.Guid> trainingFiles,
            global::G.ClassifierTrainingParameters hyperparameters,
            global::System.Collections.Generic.IList<global::G.ClassifierTargetOut> classifierTargets,
            global::System.Collections.Generic.IList<global::System.Guid>? validationFiles,
            global::G.ClassifierDetailedJobOutObject? @object,
            string? fineTunedModel,
            string? suffix,
            global::System.Collections.Generic.IList<global::G.IntegrationsVariant1Item4>? integrations,
            int? trainedTokens,
            global::G.JobMetadataOut? metadata,
            global::G.ClassifierDetailedJobOutJobType? jobType,
            global::System.Collections.Generic.IList<global::G.EventOut>? events,
            global::System.Collections.Generic.IList<global::G.CheckpointOut>? checkpoints)
        {
            this.Id = id;
            this.AutoStart = autoStart;
            this.Model = model;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
            this.TrainingFiles = trainingFiles ?? throw new global::System.ArgumentNullException(nameof(trainingFiles));
            this.Hyperparameters = hyperparameters ?? throw new global::System.ArgumentNullException(nameof(hyperparameters));
            this.ClassifierTargets = classifierTargets ?? throw new global::System.ArgumentNullException(nameof(classifierTargets));
            this.ValidationFiles = validationFiles;
            this.Object = @object;
            this.FineTunedModel = fineTunedModel;
            this.Suffix = suffix;
            this.Integrations = integrations;
            this.TrainedTokens = trainedTokens;
            this.Metadata = metadata;
            this.JobType = jobType;
            this.Events = events;
            this.Checkpoints = checkpoints;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClassifierDetailedJobOut" /> class.
        /// </summary>
        public ClassifierDetailedJobOut()
        {
        }
    }
}