//HintName: G.Models.Recording.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Recording
    {
        /// <summary>
        /// This is the stereo recording url for the call. To enable, set `assistant.artifactPlan.recordingEnabled`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stereoUrl")]
        public string? StereoUrl { get; set; }

        /// <summary>
        /// This is the video recording url for the call. To enable, set `assistant.artifactPlan.videoRecordingEnabled`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoUrl")]
        public string? VideoUrl { get; set; }

        /// <summary>
        /// This is video recording start delay in ms. To enable, set `assistant.artifactPlan.videoRecordingEnabled`. This can be used to align the playback of the recording with artifact.messages timestamps.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoRecordingStartDelaySeconds")]
        public double? VideoRecordingStartDelaySeconds { get; set; }

        /// <summary>
        /// This is the mono recording url for the call. To enable, set `assistant.artifactPlan.recordingEnabled`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mono")]
        public global::G.Mono? Mono { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Recording" /> class.
        /// </summary>
        /// <param name="stereoUrl">
        /// This is the stereo recording url for the call. To enable, set `assistant.artifactPlan.recordingEnabled`.
        /// </param>
        /// <param name="videoUrl">
        /// This is the video recording url for the call. To enable, set `assistant.artifactPlan.videoRecordingEnabled`.
        /// </param>
        /// <param name="videoRecordingStartDelaySeconds">
        /// This is video recording start delay in ms. To enable, set `assistant.artifactPlan.videoRecordingEnabled`. This can be used to align the playback of the recording with artifact.messages timestamps.
        /// </param>
        /// <param name="mono">
        /// This is the mono recording url for the call. To enable, set `assistant.artifactPlan.recordingEnabled`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Recording(
            string? stereoUrl,
            string? videoUrl,
            double? videoRecordingStartDelaySeconds,
            global::G.Mono? mono)
        {
            this.StereoUrl = stereoUrl;
            this.VideoUrl = videoUrl;
            this.VideoRecordingStartDelaySeconds = videoRecordingStartDelaySeconds;
            this.Mono = mono;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Recording" /> class.
        /// </summary>
        public Recording()
        {
        }
    }
}