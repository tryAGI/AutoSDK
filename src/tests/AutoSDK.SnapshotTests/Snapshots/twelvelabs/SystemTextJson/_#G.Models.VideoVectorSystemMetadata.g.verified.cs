//HintName: G.Models.VideoVectorSystemMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// System-generated metadata about the video.
    /// </summary>
    public sealed partial class VideoVectorSystemMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        public double? Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fps")]
        public double? Fps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public double? Size { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoVectorSystemMetadata" /> class.
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="duration"></param>
        /// <param name="fps"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="size"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VideoVectorSystemMetadata(
            string? filename,
            double? duration,
            double? fps,
            int? width,
            int? height,
            double? size)
        {
            this.Filename = filename;
            this.Duration = duration;
            this.Fps = fps;
            this.Width = width;
            this.Height = height;
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoVectorSystemMetadata" /> class.
        /// </summary>
        public VideoVectorSystemMetadata()
        {
        }
    }
}