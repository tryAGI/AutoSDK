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
        /// The name of the model to fine-tune.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FineTuneableModel Model { get; set; } = default!;

        /// <summary>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("training_files")]
        public global::System.Collections.Generic.IList<global::G.TrainingFile>? TrainingFiles { get; set; }

        /// <summary>
        /// A list containing the IDs of uploaded files that contain validation data. If you provide these files, the data is used to generate validation metrics periodically during fine-tuning. These metrics can be viewed in `checkpoints` when getting the status of a running fine-tuning job. The same data should not be present in both train and validation files.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("validation_files")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ValidationFiles { get; set; }

        /// <summary>
        /// A string that will be added to your fine-tuning model name. For example, a suffix of "my-great-model" would produce a model name like `ft:open-mistral-7b:my-great-model:xxx...`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("suffix")]
        public string? Suffix { get; set; }

        /// <summary>
        /// A list of integrations to enable for your fine-tuning job.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("integrations")]
        public global::System.Collections.Generic.IList<global::G.IntegrationsVariant1Item3>? Integrations { get; set; }

        /// <summary>
        /// This field will be required in a future release.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auto_start")]
        public bool? AutoStart { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("invalid_sample_skip_percentage")]
        public double? InvalidSampleSkipPercentage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("job_type")]
        public global::G.FineTuneableModelType? JobType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hyperparameters", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.CompletionTrainingParametersIn, global::G.ClassifierTrainingParametersIn> Hyperparameters { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repositories")]
        public global::System.Collections.Generic.IList<global::G.RepositoriesVariant1Item>? Repositories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("classifier_targets")]
        public global::System.Collections.Generic.IList<global::G.ClassifierTargetIn>? ClassifierTargets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JobIn" /> class.
        /// </summary>
        /// <param name="model">
        /// The name of the model to fine-tune.
        /// </param>
        /// <param name="trainingFiles">
        /// Default Value: []
        /// </param>
        /// <param name="validationFiles">
        /// A list containing the IDs of uploaded files that contain validation data. If you provide these files, the data is used to generate validation metrics periodically during fine-tuning. These metrics can be viewed in `checkpoints` when getting the status of a running fine-tuning job. The same data should not be present in both train and validation files.
        /// </param>
        /// <param name="suffix">
        /// A string that will be added to your fine-tuning model name. For example, a suffix of "my-great-model" would produce a model name like `ft:open-mistral-7b:my-great-model:xxx...`
        /// </param>
        /// <param name="integrations">
        /// A list of integrations to enable for your fine-tuning job.
        /// </param>
        /// <param name="autoStart">
        /// This field will be required in a future release.
        /// </param>
        /// <param name="invalidSampleSkipPercentage">
        /// Default Value: 0
        /// </param>
        /// <param name="jobType"></param>
        /// <param name="hyperparameters"></param>
        /// <param name="repositories"></param>
        /// <param name="classifierTargets"></param>
        public JobIn(
            global::G.FineTuneableModel model,
            global::G.AnyOf<global::G.CompletionTrainingParametersIn, global::G.ClassifierTrainingParametersIn> hyperparameters,
            global::System.Collections.Generic.IList<global::G.TrainingFile>? trainingFiles,
            global::System.Collections.Generic.IList<global::System.Guid>? validationFiles,
            string? suffix,
            global::System.Collections.Generic.IList<global::G.IntegrationsVariant1Item3>? integrations,
            bool? autoStart,
            double? invalidSampleSkipPercentage,
            global::G.FineTuneableModelType? jobType,
            global::System.Collections.Generic.IList<global::G.RepositoriesVariant1Item>? repositories,
            global::System.Collections.Generic.IList<global::G.ClassifierTargetIn>? classifierTargets)
        {
            this.Model = model;
            this.Hyperparameters = hyperparameters;
            this.TrainingFiles = trainingFiles;
            this.ValidationFiles = validationFiles;
            this.Suffix = suffix;
            this.Integrations = integrations;
            this.AutoStart = autoStart;
            this.InvalidSampleSkipPercentage = invalidSampleSkipPercentage;
            this.JobType = jobType;
            this.Repositories = repositories;
            this.ClassifierTargets = classifierTargets;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JobIn" /> class.
        /// </summary>
        public JobIn()
        {
        }
    }
}