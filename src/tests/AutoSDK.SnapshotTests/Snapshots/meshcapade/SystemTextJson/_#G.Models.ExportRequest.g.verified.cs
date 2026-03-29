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
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ExportFormatJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ExportFormat Format { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pose")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ExportPoseJsonConverter))]
        public global::G.ExportPose? Pose { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compatibilityMode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CompatibilityModeJsonConverter))]
        public global::G.CompatibilityMode? CompatibilityMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("animation")]
        public string? Animation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatarSceneIndex")]
        public int? AvatarSceneIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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