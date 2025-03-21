//HintName: G.Models.FineTuneSupervisedMethodHyperparameters.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The hyperparameters used for the fine-tuning job.
    /// </summary>
    public sealed partial class FineTuneSupervisedMethodHyperparameters
    {
        /// <summary>
        /// Number of examples in each batch. A larger batch size means that model parameters are updated less frequently, but with lower variance.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_size")]
        public global::G.OneOf<global::G.FineTuneSupervisedMethodHyperparametersBatchSize?, int?>? BatchSize { get; set; }

        /// <summary>
        /// Scaling factor for the learning rate. A smaller learning rate may be useful to avoid overfitting.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("learning_rate_multiplier")]
        public global::G.OneOf<global::G.FineTuneSupervisedMethodHyperparametersLearningRateMultiplier?, double?>? LearningRateMultiplier { get; set; }

        /// <summary>
        /// The number of epochs to train the model for. An epoch refers to one full cycle through the training dataset.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n_epochs")]
        public global::G.OneOf<global::G.FineTuneSupervisedMethodHyperparametersNEpochs?, int?>? NEpochs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneSupervisedMethodHyperparameters" /> class.
        /// </summary>
        /// <param name="batchSize">
        /// Number of examples in each batch. A larger batch size means that model parameters are updated less frequently, but with lower variance.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="learningRateMultiplier">
        /// Scaling factor for the learning rate. A smaller learning rate may be useful to avoid overfitting.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="nEpochs">
        /// The number of epochs to train the model for. An epoch refers to one full cycle through the training dataset.<br/>
        /// Default Value: auto
        /// </param>
        public FineTuneSupervisedMethodHyperparameters(
            global::G.OneOf<global::G.FineTuneSupervisedMethodHyperparametersBatchSize?, int?>? batchSize,
            global::G.OneOf<global::G.FineTuneSupervisedMethodHyperparametersLearningRateMultiplier?, double?>? learningRateMultiplier,
            global::G.OneOf<global::G.FineTuneSupervisedMethodHyperparametersNEpochs?, int?>? nEpochs)
        {
            this.BatchSize = batchSize;
            this.LearningRateMultiplier = learningRateMultiplier;
            this.NEpochs = nEpochs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneSupervisedMethodHyperparameters" /> class.
        /// </summary>
        public FineTuneSupervisedMethodHyperparameters()
        {
        }
    }
}