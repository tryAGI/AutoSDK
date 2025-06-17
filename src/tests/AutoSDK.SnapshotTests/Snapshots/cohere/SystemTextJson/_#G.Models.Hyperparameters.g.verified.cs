//HintName: G.Models.Hyperparameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The fine-tuning hyperparameters.
    /// </summary>
    public sealed partial class Hyperparameters
    {
        /// <summary>
        /// Stops training if the loss metric does not improve beyond the value of<br/>
        /// `early_stopping_threshold` after this many times of evaluation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("early_stopping_patience")]
        public int? EarlyStoppingPatience { get; set; }

        /// <summary>
        /// How much the loss must improve to prevent early stopping.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("early_stopping_threshold")]
        public double? EarlyStoppingThreshold { get; set; }

        /// <summary>
        /// The learning rate to be used during training.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("learning_rate")]
        public double? LearningRate { get; set; }

        /// <summary>
        /// Controls the scaling factor for LoRA updates. Higher values make the<br/>
        /// updates more impactful.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_alpha")]
        public int? LoraAlpha { get; set; }

        /// <summary>
        /// Specifies the rank for low-rank matrices. Lower ranks reduce parameters<br/>
        /// but may limit model flexibility.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_rank")]
        public int? LoraRank { get; set; }

        /// <summary>
        /// The possible combinations of LoRA modules to target.<br/>
        ///  - LORA_TARGET_MODULES_UNSPECIFIED: Unspecified LoRA target modules.<br/>
        ///  - LORA_TARGET_MODULES_QV: LoRA adapts the query and value matrices in transformer attention layers.<br/>
        ///  - LORA_TARGET_MODULES_QKVO: LoRA adapts query, key, value, and output matrices in attention layers.<br/>
        ///  - LORA_TARGET_MODULES_QKVO_FFN: LoRA adapts attention projection matrices and feed-forward networks (FFN).<br/>
        /// Default Value: LORA_TARGET_MODULES_UNSPECIFIED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_target_modules")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LoraTargetModulesJsonConverter))]
        public global::G.LoraTargetModules? LoraTargetModules { get; set; }

        /// <summary>
        /// The batch size is the number of training examples included in a single<br/>
        /// training pass.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("train_batch_size")]
        public int? TrainBatchSize { get; set; }

        /// <summary>
        /// The number of epochs to train for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("train_epochs")]
        public int? TrainEpochs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Hyperparameters" /> class.
        /// </summary>
        /// <param name="earlyStoppingPatience">
        /// Stops training if the loss metric does not improve beyond the value of<br/>
        /// `early_stopping_threshold` after this many times of evaluation.
        /// </param>
        /// <param name="earlyStoppingThreshold">
        /// How much the loss must improve to prevent early stopping.
        /// </param>
        /// <param name="learningRate">
        /// The learning rate to be used during training.
        /// </param>
        /// <param name="loraAlpha">
        /// Controls the scaling factor for LoRA updates. Higher values make the<br/>
        /// updates more impactful.
        /// </param>
        /// <param name="loraRank">
        /// Specifies the rank for low-rank matrices. Lower ranks reduce parameters<br/>
        /// but may limit model flexibility.
        /// </param>
        /// <param name="loraTargetModules">
        /// The possible combinations of LoRA modules to target.<br/>
        ///  - LORA_TARGET_MODULES_UNSPECIFIED: Unspecified LoRA target modules.<br/>
        ///  - LORA_TARGET_MODULES_QV: LoRA adapts the query and value matrices in transformer attention layers.<br/>
        ///  - LORA_TARGET_MODULES_QKVO: LoRA adapts query, key, value, and output matrices in attention layers.<br/>
        ///  - LORA_TARGET_MODULES_QKVO_FFN: LoRA adapts attention projection matrices and feed-forward networks (FFN).<br/>
        /// Default Value: LORA_TARGET_MODULES_UNSPECIFIED
        /// </param>
        /// <param name="trainBatchSize">
        /// The batch size is the number of training examples included in a single<br/>
        /// training pass.
        /// </param>
        /// <param name="trainEpochs">
        /// The number of epochs to train for.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Hyperparameters(
            int? earlyStoppingPatience,
            double? earlyStoppingThreshold,
            double? learningRate,
            int? loraAlpha,
            int? loraRank,
            global::G.LoraTargetModules? loraTargetModules,
            int? trainBatchSize,
            int? trainEpochs)
        {
            this.EarlyStoppingPatience = earlyStoppingPatience;
            this.EarlyStoppingThreshold = earlyStoppingThreshold;
            this.LearningRate = learningRate;
            this.LoraAlpha = loraAlpha;
            this.LoraRank = loraRank;
            this.LoraTargetModules = loraTargetModules;
            this.TrainBatchSize = trainBatchSize;
            this.TrainEpochs = trainEpochs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Hyperparameters" /> class.
        /// </summary>
        public Hyperparameters()
        {
        }
    }
}