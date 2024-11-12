//HintName: G.Models.LoRATrainingType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LoRATrainingType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_alpha")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LoraAlpha { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_dropout")]
        public float? LoraDropout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_r")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LoraR { get; set; }

        /// <summary>
        /// Default Value: all-linear
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_trainable_modules")]
        public string? LoraTrainableModules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.LoRATrainingTypeTypeJsonConverter))]
        public global::G.LoRATrainingTypeType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoRATrainingType" /> class.
        /// </summary>
        /// <param name="loraAlpha"></param>
        /// <param name="loraDropout">
        /// Default Value: 0F
        /// </param>
        /// <param name="loraR"></param>
        /// <param name="loraTrainableModules">
        /// Default Value: all-linear
        /// </param>
        /// <param name="type"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public LoRATrainingType(
            int loraAlpha,
            int loraR,
            float? loraDropout,
            string? loraTrainableModules,
            global::G.LoRATrainingTypeType type)
        {
            this.LoraAlpha = loraAlpha;
            this.LoraR = loraR;
            this.LoraDropout = loraDropout;
            this.LoraTrainableModules = loraTrainableModules;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoRATrainingType" /> class.
        /// </summary>
        public LoRATrainingType()
        {
        }
    }
}