//HintName: G.Models.CreateFineTuningJobRequestHyperparameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The hyperparameters used for the fine-tuning job.
    /// </summary>
    public sealed partial class CreateFineTuningJobRequestHyperparameters
    {
        /// <summary>
        /// Number of examples in each batch. A larger batch size means that model parameters<br/>
        /// are updated less frequently, but with lower variance.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_size")]
        public global::System.OneOf<global::G.CreateFineTuningJobRequestHyperparametersBatchSize?, int> BatchSize { get; set; } = global::G.CreateFineTuningJobRequestHyperparametersBatchSize.Auto;

        /// <summary>
        /// Scaling factor for the learning rate. A smaller learning rate may be useful to avoid<br/>
        /// overfitting.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("learning_rate_multiplier")]
        public global::System.OneOf<global::G.CreateFineTuningJobRequestHyperparametersLearningRateMultiplier?, double> LearningRateMultiplier { get; set; } = global::G.CreateFineTuningJobRequestHyperparametersLearningRateMultiplier.Auto;

        /// <summary>
        /// The number of epochs to train the model for. An epoch refers to one full cycle<br/>
        /// through the training dataset.<br/>
        /// Default Value: auto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("n_epochs")]
        public global::System.OneOf<global::G.CreateFineTuningJobRequestHyperparametersNEpochs?, int> NEpochs { get; set; } = global::G.CreateFineTuningJobRequestHyperparametersNEpochs.Auto;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}