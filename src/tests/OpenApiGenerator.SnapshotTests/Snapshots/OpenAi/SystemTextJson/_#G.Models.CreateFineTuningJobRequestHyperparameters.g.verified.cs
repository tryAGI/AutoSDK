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
        /// Number of examples in each batch. A larger batch size means that model parameters
        /// are updated less frequently, but with lower variance.
        /// <br/>Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.OneOfJsonConverterFactory2))]
        public global::System.OneOf<CreateFineTuningJobRequestHyperparametersBatchSize?, int> BatchSize { get; set; } = CreateFineTuningJobRequestHyperparametersBatchSize.Auto;

        /// <summary>
        /// Scaling factor for the learning rate. A smaller learning rate may be useful to avoid
        /// overfitting.
        /// <br/>Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("learning_rate_multiplier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.OneOfJsonConverterFactory2))]
        public global::System.OneOf<CreateFineTuningJobRequestHyperparametersLearningRateMultiplier?, double> LearningRateMultiplier { get; set; } = CreateFineTuningJobRequestHyperparametersLearningRateMultiplier.Auto;

        /// <summary>
        /// The number of epochs to train the model for. An epoch refers to one full cycle
        /// through the training dataset.
        /// <br/>Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_epochs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.OneOfJsonConverterFactory2))]
        public global::System.OneOf<CreateFineTuningJobRequestHyperparametersNEpochs?, int> NEpochs { get; set; } = CreateFineTuningJobRequestHyperparametersNEpochs.Auto;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}