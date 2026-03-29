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
        [global::Newtonsoft.Json.JsonProperty("chunk_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int ChunkIndex { get; set; } = default!;

        /// <summary>
        /// mime type of the chunk<br/>
        /// Default Value: audio/mpeg
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mime_type")]
        public string? MimeType { get; set; }

        /// <summary>
        /// metadata of the chunk
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generated_metadata")]
        public global::G.GeneratedMetadataVariant1? GeneratedMetadata { get; set; }

        /// <summary>
        /// model used for this chunk
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Input type identifier<br/>
        /// Default Value: audio_url
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// speech recognition (sr) text of the audio
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcription")]
        public string? Transcription { get; set; }

        /// <summary>
        /// summary of the audio
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Audio URL
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("audio_url")]
        public global::G.AudioUrl? AudioUrl { get; set; }

        /// <summary>
        /// The sampling rate of the audio.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sampling_rate", Required = global::Newtonsoft.Json.Required.Always)]
        public int SamplingRate { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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