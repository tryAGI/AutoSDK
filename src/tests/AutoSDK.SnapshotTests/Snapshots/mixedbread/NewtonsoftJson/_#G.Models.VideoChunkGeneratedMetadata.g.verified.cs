//HintName: G.Models.VideoChunkGeneratedMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoChunkGeneratedMetadata
    {
        /// <summary>
        /// Default Value: video
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Default Value: video/mp4
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_type")]
        public string? FileType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_size")]
        public int? FileSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_duration_seconds")]
        public double? TotalDurationSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fps")]
        public double? Fps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("width")]
        public int? Width { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("height")]
        public int? Height { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("frame_count")]
        public int? FrameCount { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_audio_stream")]
        public bool? HasAudioStream { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bpm")]
        public int? Bpm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_extension")]
        public string? FileExtension { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoChunkGeneratedMetadata" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: video
        /// </param>
        /// <param name="fileType">
        /// Default Value: video/mp4
        /// </param>
        /// <param name="fileSize"></param>
        /// <param name="totalDurationSeconds"></param>
        /// <param name="fps"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="frameCount"></param>
        /// <param name="hasAudioStream">
        /// Default Value: false
        /// </param>
        /// <param name="bpm"></param>
        /// <param name="fileExtension"></param>
        public VideoChunkGeneratedMetadata(
            string? type,
            string? fileType,
            int? fileSize,
            double? totalDurationSeconds,
            double? fps,
            int? width,
            int? height,
            int? frameCount,
            bool? hasAudioStream,
            int? bpm,
            string? fileExtension)
        {
            this.Type = type;
            this.FileType = fileType;
            this.FileSize = fileSize;
            this.TotalDurationSeconds = totalDurationSeconds;
            this.Fps = fps;
            this.Width = width;
            this.Height = height;
            this.FrameCount = frameCount;
            this.HasAudioStream = hasAudioStream;
            this.Bpm = bpm;
            this.FileExtension = fileExtension;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoChunkGeneratedMetadata" /> class.
        /// </summary>
        public VideoChunkGeneratedMetadata()
        {
        }
    }
}