//HintName: G.Models.CreateFineTuningJobRequestHyperparameters.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The hyperparameters used for the fine-tuning job.<br/>
    /// This value is now deprecated in favor of `method`, and should be passed in under the `method` parameter.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class CreateFineTuningJobRequestHyperparameters
    {
        /// <summary>
        /// Number of examples in each batch. A larger batch size means that model parameters<br/>
        /// are updated less frequently, but with lower variance.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_size")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.OneOf<global::G.CreateFineTuningJobRequestHyperparametersBatchSize?, int?>? BatchSize { get; set; }

        /// <summary>
        /// Scaling factor for the learning rate. A smaller learning rate may be useful to avoid<br/>
        /// overfitting.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("learning_rate_multiplier")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.OneOf<global::G.CreateFineTuningJobRequestHyperparametersLearningRateMultiplier?, double?>? LearningRateMultiplier { get; set; }

        /// <summary>
        /// The number of epochs to train the model for. An epoch refers to one full cycle<br/>
        /// through the training dataset.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n_epochs")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.OneOf<global::G.CreateFineTuningJobRequestHyperparametersNEpochs?, int?>? NEpochs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFineTuningJobRequestHyperparameters" /> class.
        /// </summary>
        /// <param name="batchSize">
        /// Number of examples in each batch. A larger batch size means that model parameters<br/>
        /// are updated less frequently, but with lower variance.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="learningRateMultiplier">
        /// Scaling factor for the learning rate. A smaller learning rate may be useful to avoid<br/>
        /// overfitting.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="nEpochs">
        /// The number of epochs to train the model for. An epoch refers to one full cycle<br/>
        /// through the training dataset.<br/>
        /// Default Value: auto
        /// </param>
        public CreateFineTuningJobRequestHyperparameters(
            global::G.OneOf<global::G.CreateFineTuningJobRequestHyperparametersBatchSize?, int?>? batchSize,
            global::G.OneOf<global::G.CreateFineTuningJobRequestHyperparametersLearningRateMultiplier?, double?>? learningRateMultiplier,
            global::G.OneOf<global::G.CreateFineTuningJobRequestHyperparametersNEpochs?, int?>? nEpochs)
        {
            this.BatchSize = batchSize;
            this.LearningRateMultiplier = learningRateMultiplier;
            this.NEpochs = nEpochs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFineTuningJobRequestHyperparameters" /> class.
        /// </summary>
        public CreateFineTuningJobRequestHyperparameters()
        {
        }
    }
}