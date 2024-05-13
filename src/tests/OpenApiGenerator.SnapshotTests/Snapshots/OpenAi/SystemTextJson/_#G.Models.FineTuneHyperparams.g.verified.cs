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
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int BatchSize { get; set; }

        /// <summary>
        /// The number of classes to use for computing classification metrics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classification_n_classes")]
        public int ClassificationNClasses { get; set; }

        /// <summary>
        /// The positive class to use for computing classification metrics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classification_positive_class")]
        public string? ClassificationPositiveClass { get; set; }

        /// <summary>
        /// The classification metrics to compute using the validation dataset at the end of every epoch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compute_classification_metrics")]
        public bool ComputeClassificationMetrics { get; set; }

        /// <summary>
        /// The learning rate multiplier to use for training.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("learning_rate_multiplier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double LearningRateMultiplier { get; set; }

        /// <summary>
        /// The number of epochs to train the model for. An epoch refers to one
        /// full cycle through the training dataset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_epochs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NEpochs { get; set; }

        /// <summary>
        /// The weight to use for loss on the prompt tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_loss_weight")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PromptLossWeight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}