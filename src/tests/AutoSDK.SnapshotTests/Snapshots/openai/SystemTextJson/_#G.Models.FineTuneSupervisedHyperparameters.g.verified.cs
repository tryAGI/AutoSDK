﻿//HintName: G.Models.FineTuneSupervisedHyperparameters.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The hyperparameters used for the fine-tuning job.
    /// </summary>
    public sealed partial class FineTuneSupervisedHyperparameters
    {
        /// <summary>
        /// Number of examples in each batch. A larger batch size means that model parameters are updated less frequently, but with lower variance.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.FineTuneSupervisedHyperparametersBatchSize?, int?>))]
        public global::G.OneOf<global::G.FineTuneSupervisedHyperparametersBatchSize?, int?>? BatchSize { get; set; }

        /// <summary>
        /// Scaling factor for the learning rate. A smaller learning rate may be useful to avoid overfitting.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("learning_rate_multiplier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.FineTuneSupervisedHyperparametersLearningRateMultiplier?, double?>))]
        public global::G.OneOf<global::G.FineTuneSupervisedHyperparametersLearningRateMultiplier?, double?>? LearningRateMultiplier { get; set; }

        /// <summary>
        /// The number of epochs to train the model for. An epoch refers to one full cycle through the training dataset.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_epochs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.FineTuneSupervisedHyperparametersNEpochs?, int?>))]
        public global::G.OneOf<global::G.FineTuneSupervisedHyperparametersNEpochs?, int?>? NEpochs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneSupervisedHyperparameters" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTuneSupervisedHyperparameters(
            global::G.OneOf<global::G.FineTuneSupervisedHyperparametersBatchSize?, int?>? batchSize,
            global::G.OneOf<global::G.FineTuneSupervisedHyperparametersLearningRateMultiplier?, double?>? learningRateMultiplier,
            global::G.OneOf<global::G.FineTuneSupervisedHyperparametersNEpochs?, int?>? nEpochs)
        {
            this.BatchSize = batchSize;
            this.LearningRateMultiplier = learningRateMultiplier;
            this.NEpochs = nEpochs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneSupervisedHyperparameters" /> class.
        /// </summary>
        public FineTuneSupervisedHyperparameters()
        {
        }
    }
}