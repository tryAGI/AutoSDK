//HintName: G.Models.VideoIndexingTaskSystemMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// System-generated metadata about the video.
    /// </summary>
    public sealed partial class VideoIndexingTaskSystemMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoIndexingTaskSystemMetadata" /> class.
        /// </summary>
        /// <param name="duration"></param>
        /// <param name="filename"></param>
        /// <param name="height"></param>
        /// <param name="width"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoIndexingTaskSystemMetadata(
            double? duration,
            string? filename,
            int? height,
            int? width)
        {
            this.Duration = duration;
            this.Filename = filename;
            this.Height = height;
            this.Width = width;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoIndexingTaskSystemMetadata" /> class.
        /// </summary>
        public VideoIndexingTaskSystemMetadata()
        {
        }
    }
}