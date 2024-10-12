//HintName: G.Models.Request.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Request
    {
        /// <summary>
        /// Batch size for fine-tuning<br/>
        /// Default Value: 32
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_size")]
        public int? BatchSize { get; set; } = 32;

        /// <summary>
        /// Learning rate multiplier to use for training<br/>
        /// Default Value: 1E-05F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("learning_rate")]
        public float? LearningRate { get; set; } = 1E-05F;

        /// <summary>
        /// Name of the base model to run fine-tune job on
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// Number of checkpoints to save during fine-tuning<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n_checkpoints")]
        public int? NCheckpoints { get; set; } = 1;

        /// <summary>
        /// Number of epochs for fine-tuning<br/>
        /// Default Value: 1
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n_epochs")]
        public int? NEpochs { get; set; } = 1;

        /// <summary>
        /// Number of evaluations to be run on a given validation set during training<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n_evals")]
        public int? NEvals { get; set; } = 0;

        /// <summary>
        /// Suffix that will be added to your fine-tuned model name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("suffix")]
        public string? Suffix { get; set; }

        /// <summary>
        /// File-ID of a training file uploaded to the Together API
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("training_file", Required = global::Newtonsoft.Json.Required.Always)]
        public string TrainingFile { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("training_type")]
        public global::G.OneOf<global::G.FullTrainingType, global::G.LoRATrainingType>? TrainingType { get; set; }

        /// <summary>
        /// File-ID of a validation file uploaded to the Together API
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("validation_file")]
        public string? ValidationFile { get; set; }

        /// <summary>
        /// API key for Weights &amp; Biases integration
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wandb_api_key")]
        public string? WandbApiKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}