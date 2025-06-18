//HintName: G.Models.FineTuneDPOHyperparameters.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The hyperparameters used for the DPO fine-tuning job.
    /// </summary>
    public sealed partial class FineTuneDPOHyperparameters
    {
        /// <summary>
        /// The beta value for the DPO method. A higher beta value will increase the weight of the penalty between the policy and reference model.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("beta")]
        public global::G.OneOf<global::G.FineTuneDPOHyperparametersBeta?, double?>? Beta { get; set; }

        /// <summary>
        /// Number of examples in each batch. A larger batch size means that model parameters are updated less frequently, but with lower variance.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_size")]
        public global::G.OneOf<global::G.FineTuneDPOHyperparametersBatchSize?, int?>? BatchSize { get; set; }

        /// <summary>
        /// Scaling factor for the learning rate. A smaller learning rate may be useful to avoid overfitting.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("learning_rate_multiplier")]
        public global::G.OneOf<global::G.FineTuneDPOHyperparametersLearningRateMultiplier?, double?>? LearningRateMultiplier { get; set; }

        /// <summary>
        /// The number of epochs to train the model for. An epoch refers to one full cycle through the training dataset.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n_epochs")]
        public global::G.OneOf<global::G.FineTuneDPOHyperparametersNEpochs?, int?>? NEpochs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneDPOHyperparameters" /> class.
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
        public FineTuneDPOHyperparameters(
            global::G.OneOf<global::G.FineTuneDPOHyperparametersBeta?, double?>? beta,
            global::G.OneOf<global::G.FineTuneDPOHyperparametersBatchSize?, int?>? batchSize,
            global::G.OneOf<global::G.FineTuneDPOHyperparametersLearningRateMultiplier?, double?>? learningRateMultiplier,
            global::G.OneOf<global::G.FineTuneDPOHyperparametersNEpochs?, int?>? nEpochs)
        {
            this.Beta = beta;
            this.BatchSize = batchSize;
            this.LearningRateMultiplier = learningRateMultiplier;
            this.NEpochs = nEpochs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneDPOHyperparameters" /> class.
        /// </summary>
        public FineTuneDPOHyperparameters()
        {
        }
    }
}