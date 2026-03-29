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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Uploaded audio filename<br/>
        /// Example: short-audio-en-16000.wav
        /// </summary>
        /// <example>short-audio-en-16000.wav</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Uploaded audio source<br/>
        /// Example: http://files.gladia.io/example/audio-transcription/split_infinity.wav
        /// </summary>
        /// <example>http://files.gladia.io/example/audio-transcription/split_infinity.wav</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// Uploaded audio detected extension<br/>
        /// Example: wav
        /// </summary>
        /// <example>wav</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("extension")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Extension { get; set; }

        /// <summary>
        /// Uploaded audio size<br/>
        /// Example: 365702
        /// </summary>
        /// <example>365702</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Size { get; set; }

        /// <summary>
        /// Uploaded audio duration<br/>
        /// Example: 4.145782F
        /// </summary>
        /// <example>4.145782F</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AudioDuration { get; set; }

        /// <summary>
        /// Uploaded audio channel numbers<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("number_of_channels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumberOfChannels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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