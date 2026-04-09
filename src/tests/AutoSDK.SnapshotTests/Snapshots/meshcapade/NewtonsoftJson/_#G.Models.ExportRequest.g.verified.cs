//HintName: G.Models.ExportRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExportRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ExportFormatJsonConverter))]
        public global::G.ExportFormat Format { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pose")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ExportPoseJsonConverter))]
        public global::G.ExportPose? Pose { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("compatibilityMode")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.CompatibilityModeJsonConverter))]
        public global::G.CompatibilityMode? CompatibilityMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("animation")]
        public string? Animation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatarSceneIndex")]
        public int? AvatarSceneIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportRequest" /> class.
        /// </summary>
        /// <param name="format"></param>
        /// <param name="pose"></param>
        /// <param name="compatibilityMode"></param>
        /// <param name="animation"></param>
        /// <param name="filename"></param>
        /// <param name="avatarSceneIndex"></param>
        public ExportRequest(
            global::G.ExportFormat format,
            global::G.ExportPose? pose,
            global::G.CompatibilityMode? compatibilityMode,
            string? animation,
            string? filename,
            int? avatarSceneIndex)
        {
            this.Format = format;
            this.Pose = pose;
            this.CompatibilityMode = compatibilityMode;
            this.Animation = animation;
            this.Filename = filename;
            this.AvatarSceneIndex = avatarSceneIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportRequest" /> class.
        /// </summary>
        public ExportRequest()
        {
        }
    }
}