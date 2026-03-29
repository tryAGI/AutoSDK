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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CreateTaskRequestVariant2Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateTaskRequestVariant2File File { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_version")]
        public global::G.CreateTaskRequestVariant2ModelVersion? ModelVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("face_limit")]
        public int? FaceLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("texture")]
        public bool? Texture { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pbr")]
        public bool? Pbr { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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