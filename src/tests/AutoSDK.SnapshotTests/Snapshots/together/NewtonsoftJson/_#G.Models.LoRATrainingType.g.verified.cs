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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.LoRATrainingTypeType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lora_r", Required = global::Newtonsoft.Json.Required.Always)]
        public int LoraR { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lora_alpha", Required = global::Newtonsoft.Json.Required.Always)]
        public int LoraAlpha { get; set; } = default!;

        /// <summary>
        /// Default Value: 0.0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lora_dropout")]
        public float? LoraDropout { get; set; }

        /// <summary>
        /// Default Value: all-linear
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lora_trainable_modules")]
        public string? LoraTrainableModules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoRATrainingType" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="loraR"></param>
        /// <param name="loraAlpha"></param>
        /// <param name="loraDropout">
        /// Default Value: 0.0
        /// </param>
        /// <param name="loraTrainableModules">
        /// Default Value: all-linear
        /// </param>
        public LoRATrainingType(
            int loraR,
            int loraAlpha,
            global::G.LoRATrainingTypeType type,
            float? loraDropout,
            string? loraTrainableModules)
        {
            this.LoraR = loraR;
            this.LoraAlpha = loraAlpha;
            this.Type = type;
            this.LoraDropout = loraDropout;
            this.LoraTrainableModules = loraTrainableModules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoRATrainingType" /> class.
        /// </summary>
        public LoRATrainingType()
        {
        }
    }
}