//HintName: G.Models.CreateTaskRequestVariant3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTaskRequestVariant3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.CreateTaskRequestVariant3Type Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("files", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CreateTaskRequestVariant3File> Files { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mode", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CreateTaskRequestVariant3Mode Mode { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_version")]
        public global::G.CreateTaskRequestVariant3ModelVersion? ModelVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("orthographic_projection")]
        public bool? OrthographicProjection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTaskRequestVariant3" /> class.
        /// </summary>
        /// <param name="files"></param>
        /// <param name="mode"></param>
        /// <param name="type"></param>
        /// <param name="modelVersion"></param>
        /// <param name="orthographicProjection"></param>
        public CreateTaskRequestVariant3(
            global::System.Collections.Generic.IList<global::G.CreateTaskRequestVariant3File> files,
            global::G.CreateTaskRequestVariant3Mode mode,
            global::G.CreateTaskRequestVariant3Type type,
            global::G.CreateTaskRequestVariant3ModelVersion? modelVersion,
            bool? orthographicProjection)
        {
            this.Type = type;
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
            this.Mode = mode;
            this.ModelVersion = modelVersion;
            this.OrthographicProjection = orthographicProjection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTaskRequestVariant3" /> class.
        /// </summary>
        public CreateTaskRequestVariant3()
        {
        }
    }
}