//HintName: G.Models.CameraControlConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CameraControlConfig
    {
        /// <summary>
        /// Horizontal movement. Range [-10, 10].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("horizontal")]
        public int? Horizontal { get; set; }

        /// <summary>
        /// Vertical movement. Range [-10, 10].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vertical")]
        public int? Vertical { get; set; }

        /// <summary>
        /// Pan movement. Range [-10, 10].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pan")]
        public int? Pan { get; set; }

        /// <summary>
        /// Tilt movement. Range [-10, 10].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tilt")]
        public int? Tilt { get; set; }

        /// <summary>
        /// Roll movement. Range [-10, 10].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roll")]
        public int? Roll { get; set; }

        /// <summary>
        /// Zoom movement. Range [-10, 10].
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("zoom")]
        public int? Zoom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CameraControlConfig" /> class.
        /// </summary>
        /// <param name="horizontal">
        /// Horizontal movement. Range [-10, 10].
        /// </param>
        /// <param name="vertical">
        /// Vertical movement. Range [-10, 10].
        /// </param>
        /// <param name="pan">
        /// Pan movement. Range [-10, 10].
        /// </param>
        /// <param name="tilt">
        /// Tilt movement. Range [-10, 10].
        /// </param>
        /// <param name="roll">
        /// Roll movement. Range [-10, 10].
        /// </param>
        /// <param name="zoom">
        /// Zoom movement. Range [-10, 10].
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CameraControlConfig(
            int? horizontal,
            int? vertical,
            int? pan,
            int? tilt,
            int? roll,
            int? zoom)
        {
            this.Horizontal = horizontal;
            this.Vertical = vertical;
            this.Pan = pan;
            this.Tilt = tilt;
            this.Roll = roll;
            this.Zoom = zoom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CameraControlConfig" /> class.
        /// </summary>
        public CameraControlConfig()
        {
        }
    }
}