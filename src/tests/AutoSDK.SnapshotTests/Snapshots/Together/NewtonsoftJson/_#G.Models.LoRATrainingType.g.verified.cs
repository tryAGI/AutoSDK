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
        [global::Newtonsoft.Json.JsonProperty("lora_alpha", Required = global::Newtonsoft.Json.Required.Always)]
        public int LoraAlpha { get; set; } = default!;

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lora_dropout")]
        public float? LoraDropout { get; set; } = 0F;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lora_r", Required = global::Newtonsoft.Json.Required.Always)]
        public int LoraR { get; set; } = default!;

        /// <summary>
        /// Default Value: all-linear
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("lora_trainable_modules")]
        public string? LoraTrainableModules { get; set; } = "all-linear";

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.LoRATrainingTypeType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}