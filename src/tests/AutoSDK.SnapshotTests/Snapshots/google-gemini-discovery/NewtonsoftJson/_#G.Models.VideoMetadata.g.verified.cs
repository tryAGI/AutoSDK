//HintName: G.Models.VideoMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Deprecated: Use `GenerateContentRequest.processing_options` instead. Metadata describes the input video content.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class VideoMetadata
    {
        /// <summary>
        /// Optional. The start offset of the video.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("startOffset")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? StartOffset { get; set; }

        /// <summary>
        /// Optional. The end offset of the video.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endOffset")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? EndOffset { get; set; }

        /// <summary>
        /// Optional. The frame rate of the video sent to the model. If not specified, the default value will be 1.0. The fps range is (0.0, 24.0].
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fps")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public double? Fps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoMetadata" /> class.
        /// </summary>
        /// <param name="startOffset">
        /// Optional. The start offset of the video.
        /// </param>
        /// <param name="endOffset">
        /// Optional. The end offset of the video.
        /// </param>
        /// <param name="fps">
        /// Optional. The frame rate of the video sent to the model. If not specified, the default value will be 1.0. The fps range is (0.0, 24.0].
        /// </param>
        public VideoMetadata(
            string? startOffset,
            string? endOffset,
            double? fps)
        {
            this.StartOffset = startOffset;
            this.EndOffset = endOffset;
            this.Fps = fps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoMetadata" /> class.
        /// </summary>
        public VideoMetadata()
        {
        }
    }
}