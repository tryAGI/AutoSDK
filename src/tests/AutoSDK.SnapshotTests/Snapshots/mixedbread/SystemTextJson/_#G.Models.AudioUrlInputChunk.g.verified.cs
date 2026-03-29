//HintName: G.Models.AudioUrlInputChunk.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AudioUrlInputChunk
    {
        /// <summary>
        /// position of the chunk in a file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ChunkIndex { get; set; }

        /// <summary>
        /// mime type of the chunk<br/>
        /// Default Value: audio/mpeg
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        public string? MimeType { get; set; }

        /// <summary>
        /// metadata of the chunk
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_metadata")]
        public global::G.GeneratedMetadataVariant1? GeneratedMetadata { get; set; }

        /// <summary>
        /// model used for this chunk
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Input type identifier<br/>
        /// Default Value: audio_url
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// speech recognition (sr) text of the audio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription")]
        public string? Transcription { get; set; }

        /// <summary>
        /// summary of the audio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Audio URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio_url")]
        public global::G.AudioUrl? AudioUrl { get; set; }

        /// <summary>
        /// The sampling rate of the audio.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SamplingRate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioUrlInputChunk" /> class.
        /// </summary>
        /// <param name="chunkIndex">
        /// position of the chunk in a file
        /// </param>
        /// <param name="samplingRate">
        /// The sampling rate of the audio.
        /// </param>
        /// <param name="mimeType">
        /// mime type of the chunk<br/>
        /// Default Value: audio/mpeg
        /// </param>
        /// <param name="generatedMetadata">
        /// metadata of the chunk
        /// </param>
        /// <param name="model">
        /// model used for this chunk
        /// </param>
        /// <param name="type">
        /// Input type identifier<br/>
        /// Default Value: audio_url
        /// </param>
        /// <param name="transcription">
        /// speech recognition (sr) text of the audio
        /// </param>
        /// <param name="summary">
        /// summary of the audio
        /// </param>
        /// <param name="audioUrl">
        /// Audio URL
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AudioUrlInputChunk(
            int chunkIndex,
            int samplingRate,
            string? mimeType,
            global::G.GeneratedMetadataVariant1? generatedMetadata,
            string? model,
            string? type,
            string? transcription,
            string? summary,
            global::G.AudioUrl? audioUrl)
        {
            this.ChunkIndex = chunkIndex;
            this.MimeType = mimeType;
            this.GeneratedMetadata = generatedMetadata;
            this.Model = model;
            this.Type = type;
            this.Transcription = transcription;
            this.Summary = summary;
            this.AudioUrl = audioUrl;
            this.SamplingRate = samplingRate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AudioUrlInputChunk" /> class.
        /// </summary>
        public AudioUrlInputChunk()
        {
        }
    }
}