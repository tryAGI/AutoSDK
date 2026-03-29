//HintName: G.Models.AudioUploadMetadataDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioUploadMetadataDTO
    {
        /// <summary>
        /// Uploaded audio file ID<br/>
        /// Example: 6c09400e-23d2-4bd2-be55-96a5ececfa3b
        /// </summary>
        /// <example>6c09400e-23d2-4bd2-be55-96a5ececfa3b</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// Uploaded audio filename<br/>
        /// Example: short-audio-en-16000.wav
        /// </summary>
        /// <example>short-audio-en-16000.wav</example>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// Uploaded audio source<br/>
        /// Example: http://files.gladia.io/example/audio-transcription/split_infinity.wav
        /// </summary>
        /// <example>http://files.gladia.io/example/audio-transcription/split_infinity.wav</example>
        [global::Newtonsoft.Json.JsonProperty("source")]
        public string? Source { get; set; }

        /// <summary>
        /// Uploaded audio detected extension<br/>
        /// Example: wav
        /// </summary>
        /// <example>wav</example>
        [global::Newtonsoft.Json.JsonProperty("extension", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Extension { get; set; } = default!;

        /// <summary>
        /// Uploaded audio size<br/>
        /// Example: 365702
        /// </summary>
        /// <example>365702</example>
        [global::Newtonsoft.Json.JsonProperty("size", Required = global::Newtonsoft.Json.Required.Always)]
        public int Size { get; set; } = default!;

        /// <summary>
        /// Uploaded audio duration<br/>
        /// Example: 4.145782F
        /// </summary>
        /// <example>4.145782F</example>
        [global::Newtonsoft.Json.JsonProperty("audio_duration", Required = global::Newtonsoft.Json.Required.Always)]
        public double AudioDuration { get; set; } = default!;

        /// <summary>
        /// Uploaded audio channel numbers<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("number_of_channels", Required = global::Newtonsoft.Json.Required.Always)]
        public int NumberOfChannels { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioUploadMetadataDTO" /> class.
        /// </summary>
        /// <param name="id">
        /// Uploaded audio file ID<br/>
        /// Example: 6c09400e-23d2-4bd2-be55-96a5ececfa3b
        /// </param>
        /// <param name="filename">
        /// Uploaded audio filename<br/>
        /// Example: short-audio-en-16000.wav
        /// </param>
        /// <param name="extension">
        /// Uploaded audio detected extension<br/>
        /// Example: wav
        /// </param>
        /// <param name="size">
        /// Uploaded audio size<br/>
        /// Example: 365702
        /// </param>
        /// <param name="audioDuration">
        /// Uploaded audio duration<br/>
        /// Example: 4.145782F
        /// </param>
        /// <param name="numberOfChannels">
        /// Uploaded audio channel numbers<br/>
        /// Example: 1
        /// </param>
        /// <param name="source">
        /// Uploaded audio source<br/>
        /// Example: http://files.gladia.io/example/audio-transcription/split_infinity.wav
        /// </param>
        public AudioUploadMetadataDTO(
            global::System.Guid id,
            string filename,
            global::System.Guid extension,
            int size,
            double audioDuration,
            int numberOfChannels,
            string? source)
        {
            this.Id = id;
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Source = source;
            this.Extension = extension;
            this.Size = size;
            this.AudioDuration = audioDuration;
            this.NumberOfChannels = numberOfChannels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioUploadMetadataDTO" /> class.
        /// </summary>
        public AudioUploadMetadataDTO()
        {
        }
    }
}