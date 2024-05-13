//HintName: G.Models.FineTuneHyperparams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The hyperparameters used for the fine-tuning job. See the [fine-tuning guide](/docs/guides/legacy-fine-tuning/hyperparameters) for more details.
    /// </summary>
    public sealed partial class FineTuneHyperparams
    {
        /// <summary>
        /// The batch size to use for training. The batch size is the number of
        /// training examples used to train a single forward and backward pass.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_size", Required = global::Newtonsoft.Json.Required.Always)]
        public int BatchSize { get; set; } = default!;

        /// <summary>
        /// The number of classes to use for computing classification metrics.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("classification_n_classes")]
        public int ClassificationNClasses { get; set; }

        /// <summary>
        /// The positive class to use for computing classification metrics.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("classification_positive_class")]
        public string? ClassificationPositiveClass { get; set; }

        /// <summary>
        /// The classification metrics to compute using the validation dataset at the end of every epoch.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("compute_classification_metrics")]
        public bool ComputeClassificationMetrics { get; set; }

        /// <summary>
        /// The learning rate multiplier to use for training.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("learning_rate_multiplier", Required = global::Newtonsoft.Json.Required.Always)]
        public double LearningRateMultiplier { get; set; } = default!;

        /// <summary>
        /// The number of epochs to train the model for. An epoch refers to one
        /// full cycle through the training dataset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n_epochs", Required = global::Newtonsoft.Json.Required.Always)]
        public int NEpochs { get; set; } = default!;

        /// <summary>
        /// The weight to use for loss on the prompt tokens.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_loss_weight", Required = global::Newtonsoft.Json.Required.Always)]
        public double PromptLossWeight { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}