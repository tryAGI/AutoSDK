//HintName: G.Models.AudioChunkGeneratedMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioChunkGeneratedMetadata
    {
        /// <summary>
        /// Default Value: audio
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Default Value: audio/mpeg
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
        [global::Newtonsoft.Json.JsonProperty("sample_rate")]
        public int? SampleRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("channels")]
        public int? Channels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_format")]
        public int? AudioFormat { get; set; }

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
        /// Initializes a new instance of the <see cref="AudioChunkGeneratedMetadata" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: audio
        /// </param>
        /// <param name="fileType">
        /// Default Value: audio/mpeg
        /// </param>
        /// <param name="fileSize"></param>
        /// <param name="totalDurationSeconds"></param>
        /// <param name="sampleRate"></param>
        /// <param name="channels"></param>
        /// <param name="audioFormat"></param>
        /// <param name="bpm"></param>
        /// <param name="fileExtension"></param>
        public AudioChunkGeneratedMetadata(
            string? type,
            string? fileType,
            int? fileSize,
            double? totalDurationSeconds,
            int? sampleRate,
            int? channels,
            int? audioFormat,
            int? bpm,
            string? fileExtension)
        {
            this.Type = type;
            this.FileType = fileType;
            this.FileSize = fileSize;
            this.TotalDurationSeconds = totalDurationSeconds;
            this.SampleRate = sampleRate;
            this.Channels = channels;
            this.AudioFormat = audioFormat;
            this.Bpm = bpm;
            this.FileExtension = fileExtension;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioChunkGeneratedMetadata" /> class.
        /// </summary>
        public AudioChunkGeneratedMetadata()
        {
        }
    }
}