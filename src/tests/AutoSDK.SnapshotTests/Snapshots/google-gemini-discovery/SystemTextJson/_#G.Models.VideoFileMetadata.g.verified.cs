//HintName: G.Models.VideoFileMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metadata for a video `File`.
    /// </summary>
    public sealed partial class VideoFileMetadata
    {
        /// <summary>
        /// Duration of the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoDuration")]
        public string? VideoDuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoFileMetadata" /> class.
        /// </summary>
        /// <param name="videoDuration">
        /// Duration of the video.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoFileMetadata(
            string? videoDuration)
        {
            this.VideoDuration = videoDuration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoFileMetadata" /> class.
        /// </summary>
        public VideoFileMetadata()
        {
        }
    }
}