//HintName: G.Models.FineTuneDPOMethodHyperparameters.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The hyperparameters used for the fine-tuning job.
    /// </summary>
    public sealed partial class FineTuneDPOMethodHyperparameters
    {
        /// <summary>
        /// The beta value for the DPO method. A higher beta value will increase the weight of the penalty between the policy and reference model.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("beta")]
        public global::G.OneOf<global::G.FineTuneDPOMethodHyperparametersBeta?, double?>? Beta { get; set; }

        /// <summary>
        /// Number of examples in each batch. A larger batch size means that model parameters are updated less frequently, but with lower variance.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_size")]
        public global::G.OneOf<global::G.FineTuneDPOMethodHyperparametersBatchSize?, int?>? BatchSize { get; set; }

        /// <summary>
        /// Scaling factor for the learning rate. A smaller learning rate may be useful to avoid overfitting.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("learning_rate_multiplier")]
        public global::G.OneOf<global::G.FineTuneDPOMethodHyperparametersLearningRateMultiplier?, double?>? LearningRateMultiplier { get; set; }

        /// <summary>
        /// The number of epochs to train the model for. An epoch refers to one full cycle through the training dataset.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n_epochs")]
        public global::G.OneOf<global::G.FineTuneDPOMethodHyperparametersNEpochs?, int?>? NEpochs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneDPOMethodHyperparameters" /> class.
        /// </summary>
        /// <param name="beta">
        /// The beta value for the DPO method. A higher beta value will increase the weight of the penalty between the policy and reference model.<br/>
        /// Default Value: auto
        /// </param>
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
        public FineTuneDPOMethodHyperparameters(
            global::G.OneOf<global::G.FineTuneDPOMethodHyperparametersBeta?, double?>? beta,
            global::G.OneOf<global::G.FineTuneDPOMethodHyperparametersBatchSize?, int?>? batchSize,
            global::G.OneOf<global::G.FineTuneDPOMethodHyperparametersLearningRateMultiplier?, double?>? learningRateMultiplier,
            global::G.OneOf<global::G.FineTuneDPOMethodHyperparametersNEpochs?, int?>? nEpochs)
        {
            this.Beta = beta;
            this.BatchSize = batchSize;
            this.LearningRateMultiplier = learningRateMultiplier;
            this.NEpochs = nEpochs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneDPOMethodHyperparameters" /> class.
        /// </summary>
        public FineTuneDPOMethodHyperparameters()
        {
        }
    }
}