//HintName: G.Models.CreateFineTuneRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateFineTuneRequest
    {
        /// <summary>
        /// The ID of an uploaded file that contains training data.
        /// See [upload file](/docs/api-reference/files/upload) for how to upload a file.
        /// Your dataset must be formatted as a JSONL file, where each training
        /// example is a JSON object with the keys "prompt" and "completion".
        /// Additionally, you must upload your file with the purpose `fine-tune`.
        /// See the [fine-tuning guide](/docs/guides/legacy-fine-tuning/creating-training-data) for more details.
        /// <br/>Example: file-abc123
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("training_file", Required = global::Newtonsoft.Json.Required.Always)]
        public string TrainingFile { get; set; } = default!;

        /// <summary>
        /// The batch size to use for training. The batch size is the number of
        /// training examples used to train a single forward and backward pass.
        /// By default, the batch size will be dynamically configured to be
        /// ~0.2% of the number of examples in the training set, capped at 256 -
        /// in general, we've found that larger batch sizes tend to work better
        /// for larger datasets.
        /// <br/>Default Value: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_size")]
        public int? BatchSize { get; set; }

        /// <summary>
        /// If this is provided, we calculate F-beta scores at the specified
        /// beta values. The F-beta score is a generalization of F-1 score.
        /// This is only used for binary classification.
        /// With a beta of 1 (i.e. the F-1 score), precision and recall are
        /// given the same weight. A larger beta score puts more weight on
        /// recall and less on precision. A smaller beta score puts more weight
        /// on precision and less on recall.
        /// <br/>Default Value: 
        /// <br/>Example: [0.6, 1, 1.5, 2]
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("classification_betas")]
        public global::System.Collections.Generic.IList<double>? ClassificationBetas { get; set; }

        /// <summary>
        /// The number of classes in a classification task.
        /// This parameter is required for multiclass classification.
        /// <br/>Default Value: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("classification_n_classes")]
        public int? ClassificationNClasses { get; set; }

        /// <summary>
        /// The positive class in binary classification.
        /// This parameter is needed to generate precision, recall, and F1
        /// metrics when doing binary classification.
        /// <br/>Default Value: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("classification_positive_class")]
        public string? ClassificationPositiveClass { get; set; }

        /// <summary>
        /// If set, we calculate classification-specific metrics such as accuracy
        /// and F-1 score using the validation set at the end of every epoch.
        /// These metrics can be viewed in the [results file](/docs/guides/legacy-fine-tuning/analyzing-your-fine-tuned-model).
        /// In order to compute classification metrics, you must provide a
        /// `validation_file`. Additionally, you must
        /// specify `classification_n_classes` for multiclass classification or
        /// `classification_positive_class` for binary classification.
        /// <br/>Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("compute_classification_metrics")]
        public bool? ComputeClassificationMetrics { get; set; } = false;

        /// <summary>
        /// The hyperparameters used for the fine-tuning job.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hyperparameters")]
        public CreateFineTuneRequestHyperparameters? Hyperparameters { get; set; }

        /// <summary>
        /// The learning rate multiplier to use for training.
        /// The fine-tuning learning rate is the original learning rate used for
        /// pretraining multiplied by this value.
        /// By default, the learning rate multiplier is the 0.05, 0.1, or 0.2
        /// depending on final `batch_size` (larger learning rates tend to
        /// perform better with larger batch sizes). We recommend experimenting
        /// with values in the range 0.02 to 0.2 to see what produces the best
        /// results.
        /// <br/>Default Value: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("learning_rate_multiplier")]
        public double? LearningRateMultiplier { get; set; }

        /// <summary>
        /// The name of the base model to fine-tune. You can select one of "ada",
        /// "babbage", "curie", "davinci", or a fine-tuned model created after 2022-04-21 and before 2023-08-22.
        /// To learn more about these models, see the
        /// [Models](/docs/models) documentation.
        /// <br/>Default Value: curie
        /// <br/>Example: curie
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public object? Model { get; set; }

        /// <summary>
        /// The weight to use for loss on the prompt tokens. This controls how
        /// much the model tries to learn to generate the prompt (as compared
        /// to the completion which always has a weight of 1.0), and can add
        /// a stabilizing effect to training when completions are short.
        /// If prompts are extremely long (relative to completions), it may make
        /// sense to reduce this weight so as to avoid over-prioritizing
        /// learning the prompt.
        /// <br/>Default Value: 0.01
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_loss_weight")]
        public double? PromptLossWeight { get; set; } = 0.01;

        /// <summary>
        /// A string of up to 40 characters that will be added to your fine-tuned model name.
        /// For example, a `suffix` of "custom-model-name" would produce a model name like `ada:ft-your-org:custom-model-name-2022-02-15-04-21-04`.
        /// <br/>Default Value: 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("suffix")]
        public string? Suffix { get; set; }

        /// <summary>
        /// The ID of an uploaded file that contains validation data.
        /// If you provide this file, the data is used to generate validation
        /// metrics periodically during fine-tuning. These metrics can be viewed in
        /// the [fine-tuning results file](/docs/guides/legacy-fine-tuning/analyzing-your-fine-tuned-model).
        /// Your train and validation data should be mutually exclusive.
        /// Your dataset must be formatted as a JSONL file, where each validation
        /// example is a JSON object with the keys "prompt" and "completion".
        /// Additionally, you must upload your file with the purpose `fine-tune`.
        /// See the [fine-tuning guide](/docs/guides/legacy-fine-tuning/creating-training-data) for more details.
        /// <br/>Example: file-abc123
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("validation_file")]
        public string? ValidationFile { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}