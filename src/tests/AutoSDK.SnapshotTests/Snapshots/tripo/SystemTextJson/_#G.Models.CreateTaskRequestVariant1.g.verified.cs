//HintName: G.Models.CreateTaskRequestVariant1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTaskRequestVariant1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateTaskRequestVariant1TypeJsonConverter))]
        public global::G.CreateTaskRequestVariant1Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateTaskRequestVariant1ModelVersionJsonConverter))]
        public global::G.CreateTaskRequestVariant1ModelVersion? ModelVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("face_limit")]
        public int? FaceLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("texture")]
        public bool? Texture { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pbr")]
        public bool? Pbr { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTaskRequestVariant1" /> class.
        /// </summary>
        /// <param name="prompt"></param>
        /// <param name="type"></param>
        /// <param name="negativePrompt"></param>
        /// <param name="modelVersion"></param>
        /// <param name="faceLimit"></param>
        /// <param name="texture"></param>
        /// <param name="pbr"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTaskRequestVariant1(
            string prompt,
            global::G.CreateTaskRequestVariant1Type type,
            string? negativePrompt,
            global::G.CreateTaskRequestVariant1ModelVersion? modelVersion,
            int? faceLimit,
            bool? texture,
            bool? pbr)
        {
            this.Type = type;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.NegativePrompt = negativePrompt;
            this.ModelVersion = modelVersion;
            this.FaceLimit = faceLimit;
            this.Texture = texture;
            this.Pbr = pbr;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTaskRequestVariant1" /> class.
        /// </summary>
        public CreateTaskRequestVariant1()
        {
        }
    }
}