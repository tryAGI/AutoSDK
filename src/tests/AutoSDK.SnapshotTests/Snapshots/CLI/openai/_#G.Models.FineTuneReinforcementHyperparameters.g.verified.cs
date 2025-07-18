﻿//HintName: G.Models.FineTuneReinforcementHyperparameters.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// The hyperparameters used for the reinforcement fine-tuning job.
    /// </summary>
    public sealed partial class FineTuneReinforcementHyperparameters
    {
        /// <summary>
        /// Number of examples in each batch. A larger batch size means that model parameters are updated less frequently, but with lower variance.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_size")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.FineTuneReinforcementHyperparametersBatchSize?, int?>))]
        public global::G.OneOf<global::G.FineTuneReinforcementHyperparametersBatchSize?, int?>? BatchSize { get; set; }

        /// <summary>
        /// Scaling factor for the learning rate. A smaller learning rate may be useful to avoid overfitting.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("learning_rate_multiplier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.FineTuneReinforcementHyperparametersLearningRateMultiplier?, double?>))]
        public global::G.OneOf<global::G.FineTuneReinforcementHyperparametersLearningRateMultiplier?, double?>? LearningRateMultiplier { get; set; }

        /// <summary>
        /// The number of epochs to train the model for. An epoch refers to one full cycle through the training dataset.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("n_epochs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.FineTuneReinforcementHyperparametersNEpochs?, int?>))]
        public global::G.OneOf<global::G.FineTuneReinforcementHyperparametersNEpochs?, int?>? NEpochs { get; set; }

        /// <summary>
        /// Level of reasoning effort.<br/>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FineTuneReinforcementHyperparametersReasoningEffortJsonConverter))]
        public global::G.FineTuneReinforcementHyperparametersReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// Multiplier on amount of compute used for exploring search space during training.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compute_multiplier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.FineTuneReinforcementHyperparametersComputeMultiplier?, double?>))]
        public global::G.OneOf<global::G.FineTuneReinforcementHyperparametersComputeMultiplier?, double?>? ComputeMultiplier { get; set; }

        /// <summary>
        /// The number of training steps between evaluation runs.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eval_interval")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.FineTuneReinforcementHyperparametersEvalInterval?, int?>))]
        public global::G.OneOf<global::G.FineTuneReinforcementHyperparametersEvalInterval?, int?>? EvalInterval { get; set; }

        /// <summary>
        /// Number of evaluation samples to generate per training step.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("eval_samples")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.FineTuneReinforcementHyperparametersEvalSamples?, int?>))]
        public global::G.OneOf<global::G.FineTuneReinforcementHyperparametersEvalSamples?, int?>? EvalSamples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneReinforcementHyperparameters" /> class.
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
        /// <param name="reasoningEffort">
        /// Level of reasoning effort.<br/>
        /// Default Value: default
        /// </param>
        /// <param name="computeMultiplier">
        /// Multiplier on amount of compute used for exploring search space during training.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="evalInterval">
        /// The number of training steps between evaluation runs.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="evalSamples">
        /// Number of evaluation samples to generate per training step.<br/>
        /// Default Value: auto
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FineTuneReinforcementHyperparameters(
            global::G.OneOf<global::G.FineTuneReinforcementHyperparametersBatchSize?, int?>? batchSize,
            global::G.OneOf<global::G.FineTuneReinforcementHyperparametersLearningRateMultiplier?, double?>? learningRateMultiplier,
            global::G.OneOf<global::G.FineTuneReinforcementHyperparametersNEpochs?, int?>? nEpochs,
            global::G.FineTuneReinforcementHyperparametersReasoningEffort? reasoningEffort,
            global::G.OneOf<global::G.FineTuneReinforcementHyperparametersComputeMultiplier?, double?>? computeMultiplier,
            global::G.OneOf<global::G.FineTuneReinforcementHyperparametersEvalInterval?, int?>? evalInterval,
            global::G.OneOf<global::G.FineTuneReinforcementHyperparametersEvalSamples?, int?>? evalSamples)
        {
            this.BatchSize = batchSize;
            this.LearningRateMultiplier = learningRateMultiplier;
            this.NEpochs = nEpochs;
            this.ReasoningEffort = reasoningEffort;
            this.ComputeMultiplier = computeMultiplier;
            this.EvalInterval = evalInterval;
            this.EvalSamples = evalSamples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FineTuneReinforcementHyperparameters" /> class.
        /// </summary>
        public FineTuneReinforcementHyperparameters()
        {
        }
    }
}