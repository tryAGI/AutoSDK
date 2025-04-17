//HintName: G.Models.JobIn.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JobIn
    {
        /// <summary>
        /// This field will be required in a future release.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_start")]
        public bool? AutoStart { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classifier_targets")]
        public global::System.Collections.Generic.IList<global::G.ClassifierTargetIn>? ClassifierTargets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hyperparameters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AnyOfJsonConverter<global::G.CompletionTrainingParametersIn, global::G.ClassifierTrainingParametersIn>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AnyOf<global::G.CompletionTrainingParametersIn, global::G.ClassifierTrainingParametersIn> Hyperparameters { get; set; }

        /// <summary>
        /// A list of integrations to enable for your fine-tuning job.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrations")]
        public global::System.Collections.Generic.IList<global::G.IntegrationsItem5>? Integrations { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invalid_sample_skip_percentage")]
        public double? InvalidSampleSkipPercentage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_type")]
        public object? JobType { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("repositories")]
        public global::System.Collections.Generic.IList<global::G.RepositoriesItem3>? Repositories { get; set; }

        /// <summary>
        /// A string that will be added to your fine-tuning model name. For example, a suffix of "my-great-model" would produce a model name like `ft:open-mistral-7b:my-great-model:xxx...`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suffix")]
        public string? Suffix { get; set; }

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_files")]
        public global::System.Collections.Generic.IList<global::G.TrainingFile>? TrainingFiles { get; set; }

        /// <summary>
        /// A list containing the IDs of uploaded files that contain validation data. If you provide these files, the data is used to generate validation metrics periodically during fine-tuning. These metrics can be viewed in `checkpoints` when getting the status of a running fine-tuning job. The same data should not be present in both train and validation files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("validation_files")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ValidationFiles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobIn" /> class.
        /// </summary>
        /// <param name="autoStart">
        /// This field will be required in a future release.
        /// </param>
        /// <param name="classifierTargets"></param>
        /// <param name="hyperparameters"></param>
        /// <param name="integrations">
        /// A list of integrations to enable for your fine-tuning job.
        /// </param>
        /// <param name="invalidSampleSkipPercentage">
        /// Default Value: 0
        /// </param>
        /// <param name="jobType"></param>
        /// <param name="model">
        /// The name of the model to fine-tune.
        /// </param>
        /// <param name="repositories"></param>
        /// <param name="suffix">
        /// A string that will be added to your fine-tuning model name. For example, a suffix of "my-great-model" would produce a model name like `ft:open-mistral-7b:my-great-model:xxx...`
        /// </param>
        /// <param name="trainingFiles">
        /// Default Value: []
        /// </param>
        /// <param name="validationFiles">
        /// A list containing the IDs of uploaded files that contain validation data. If you provide these files, the data is used to generate validation metrics periodically during fine-tuning. These metrics can be viewed in `checkpoints` when getting the status of a running fine-tuning job. The same data should not be present in both train and validation files.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JobIn(
            global::G.AnyOf<global::G.CompletionTrainingParametersIn, global::G.ClassifierTrainingParametersIn> hyperparameters,
            global::G.FineTuneableModel model,
            bool? autoStart,
            global::System.Collections.Generic.IList<global::G.ClassifierTargetIn>? classifierTargets,
            global::System.Collections.Generic.IList<global::G.IntegrationsItem5>? integrations,
            double? invalidSampleSkipPercentage,
            object? jobType,
            global::System.Collections.Generic.IList<global::G.RepositoriesItem3>? repositories,
            string? suffix,
            global::System.Collections.Generic.IList<global::G.TrainingFile>? trainingFiles,
            global::System.Collections.Generic.IList<global::System.Guid>? validationFiles)
        {
            this.Hyperparameters = hyperparameters;
            this.Model = model;
            this.AutoStart = autoStart;
            this.ClassifierTargets = classifierTargets;
            this.Integrations = integrations;
            this.InvalidSampleSkipPercentage = invalidSampleSkipPercentage;
            this.JobType = jobType;
            this.Repositories = repositories;
            this.Suffix = suffix;
            this.TrainingFiles = trainingFiles;
            this.ValidationFiles = validationFiles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobIn" /> class.
        /// </summary>
        public JobIn()
        {
        }
    }
}