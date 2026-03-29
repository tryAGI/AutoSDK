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
        [global::Newtonsoft.Json.JsonProperty("videoDuration")]
        public string? VideoDuration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoFileMetadata" /> class.
        /// </summary>
        /// <param name="videoDuration">
        /// Duration of the video.
        /// </param>
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