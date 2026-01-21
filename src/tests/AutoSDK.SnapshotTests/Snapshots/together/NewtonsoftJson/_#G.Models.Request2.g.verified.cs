//HintName: G.Models.Request2.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request2
    {
        /// <summary>
        /// File-ID of a training file uploaded to the Together API
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("training_file", Required = global::Newtonsoft.Json.Required.Always)]
        public string TrainingFile { get; set; } = default!;

        /// <summary>
        /// File-ID of a validation file uploaded to the Together API
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("validation_file")]
        public string? ValidationFile { get; set; }

        /// <summary>
        /// Name of the base model to run fine-tune job on
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Number of epochs for fine-tuning<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n_epochs")]
        public int? NEpochs { get; set; }

        /// <summary>
        /// Number of checkpoints to save during fine-tuning<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n_checkpoints")]
        public int? NCheckpoints { get; set; }

        /// <summary>
        /// Number of evaluations to be run on a given validation set during training<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n_evals")]
        public int? NEvals { get; set; }

        /// <summary>
        /// Batch size for fine-tuning<br/>
        /// Default Value: 32
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_size")]
        public int? BatchSize { get; set; }

        /// <summary>
        /// Learning rate multiplier to use for training<br/>
        /// Default Value: 0.00001
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("learning_rate")]
        public float? LearningRate { get; set; }

        /// <summary>
        /// Suffix that will be added to your fine-tuned model name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("suffix")]
        public string? Suffix { get; set; }

        /// <summary>
        /// API key for Weights &amp; Biases integration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wandb_api_key")]
        public string? WandbApiKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("training_type")]
        public global::G.OneOf<global::G.FullTrainingType, global::G.LoRATrainingType>? TrainingType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Request2" /> class.
        /// </summary>
        /// <param name="trainingFile">
        /// File-ID of a training file uploaded to the Together API
        /// </param>
        /// <param name="validationFile">
        /// File-ID of a validation file uploaded to the Together API
        /// </param>
        /// <param name="model">
        /// Name of the base model to run fine-tune job on
        /// </param>
        /// <param name="nEpochs">
        /// Number of epochs for fine-tuning<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="nCheckpoints">
        /// Number of checkpoints to save during fine-tuning<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="nEvals">
        /// Number of evaluations to be run on a given validation set during training<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="batchSize">
        /// Batch size for fine-tuning<br/>
        /// Default Value: 32
        /// </param>
        /// <param name="learningRate">
        /// Learning rate multiplier to use for training<br/>
        /// Default Value: 0.00001
        /// </param>
        /// <param name="suffix">
        /// Suffix that will be added to your fine-tuned model name
        /// </param>
        /// <param name="wandbApiKey">
        /// API key for Weights &amp; Biases integration
        /// </param>
        /// <param name="trainingType"></param>
        public Request2(
            string trainingFile,
            string model,
            string? validationFile,
            int? nEpochs,
            int? nCheckpoints,
            int? nEvals,
            int? batchSize,
            float? learningRate,
            string? suffix,
            string? wandbApiKey,
            global::G.OneOf<global::G.FullTrainingType, global::G.LoRATrainingType>? trainingType)
        {
            this.TrainingFile = trainingFile ?? throw new global::System.ArgumentNullException(nameof(trainingFile));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.ValidationFile = validationFile;
            this.NEpochs = nEpochs;
            this.NCheckpoints = nCheckpoints;
            this.NEvals = nEvals;
            this.BatchSize = batchSize;
            this.LearningRate = learningRate;
            this.Suffix = suffix;
            this.WandbApiKey = wandbApiKey;
            this.TrainingType = trainingType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Request2" /> class.
        /// </summary>
        public Request2()
        {
        }
    }
}