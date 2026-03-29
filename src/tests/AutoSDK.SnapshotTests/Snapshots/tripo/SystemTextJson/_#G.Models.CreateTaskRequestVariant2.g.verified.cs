//HintName: G.Models.CreateTaskRequestVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTaskRequestVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateTaskRequestVariant2TypeJsonConverter))]
        public global::G.CreateTaskRequestVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CreateTaskRequestVariant2File File { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateTaskRequestVariant2ModelVersionJsonConverter))]
        public global::G.CreateTaskRequestVariant2ModelVersion? ModelVersion { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateTaskRequestVariant2" /> class.
        /// </summary>
        /// <param name="file"></param>
        /// <param name="type"></param>
        /// <param name="modelVersion"></param>
        /// <param name="faceLimit"></param>
        /// <param name="texture"></param>
        /// <param name="pbr"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTaskRequestVariant2(
            global::G.CreateTaskRequestVariant2File file,
            global::G.CreateTaskRequestVariant2Type type,
            global::G.CreateTaskRequestVariant2ModelVersion? modelVersion,
            int? faceLimit,
            bool? texture,
            bool? pbr)
        {
            this.Type = type;
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.ModelVersion = modelVersion;
            this.FaceLimit = faceLimit;
            this.Texture = texture;
            this.Pbr = pbr;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTaskRequestVariant2" /> class.
        /// </summary>
        public CreateTaskRequestVariant2()
        {
        }
    }
}