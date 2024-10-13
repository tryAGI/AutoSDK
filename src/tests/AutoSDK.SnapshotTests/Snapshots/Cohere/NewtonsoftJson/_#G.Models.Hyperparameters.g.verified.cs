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
        [global::Newtonsoft.Json.JsonProperty("early_stopping_patience")]
        public int? EarlyStoppingPatience { get; set; }

        /// <summary>
        /// How much the loss must improve to prevent early stopping.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("early_stopping_threshold")]
        public double? EarlyStoppingThreshold { get; set; }

        /// <summary>
        /// The batch size is the number of training examples included in a single<br/>
        /// training pass.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("train_batch_size")]
        public int? TrainBatchSize { get; set; }

        /// <summary>
        /// The number of epochs to train for.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("train_epochs")]
        public int? TrainEpochs { get; set; }

        /// <summary>
        /// The learning rate to be used during training.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("learning_rate")]
        public double? LearningRate { get; set; }

        /// <summary>
        /// Controls the scaling factor for LoRA updates. Higher values make the<br/>
        /// updates more impactful.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lora_alpha")]
        public int? LoraAlpha { get; set; }

        /// <summary>
        /// Specifies the rank for low-rank matrices. Lower ranks reduce parameters<br/>
        /// but may limit model flexibility.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lora_rank")]
        public int? LoraRank { get; set; }

        /// <summary>
        /// The possible combinations of LoRA modules to target.<br/>
        ///  - LORA_TARGET_MODULES_UNSPECIFIED: Unspecified LoRA target modules.<br/>
        ///  - LORA_TARGET_MODULES_QV: LoRA adapts the query and value matrices in transformer attention layers.<br/>
        ///  - LORA_TARGET_MODULES_QKVO: LoRA adapts query, key, value, and output matrices in attention layers.<br/>
        ///  - LORA_TARGET_MODULES_QKVO_FFN: LoRA adapts attention projection matrices and feed-forward networks (FFN).<br/>
        /// Default Value: LORA_TARGET_MODULES_UNSPECIFIED
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lora_target_modules")]
        public global::G.LoraTargetModules? LoraTargetModules { get; set; } = global::G.LoraTargetModules.UNSPECIFIED;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.Hyperparameters? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.Hyperparameters>(
                json,
                jsonSerializerOptions);
        }

    }
}