//HintName: G.Models.VideoUrlInputChunk.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VideoUrlInputChunk
    {
        /// <summary>
        /// position of the chunk in a file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunk_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int ChunkIndex { get; set; } = default!;

        /// <summary>
        /// mime type of the chunk<br/>
        /// Default Value: video/mp4
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mime_type")]
        public string? MimeType { get; set; }

        /// <summary>
        /// metadata of the chunk
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generated_metadata")]
        public global::G.GeneratedMetadataVariant14? GeneratedMetadata { get; set; }

        /// <summary>
        /// model used for this chunk
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Input type identifier<br/>
        /// Default Value: video_url
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// speech recognition (sr) text of the video
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("transcription")]
        public string? Transcription { get; set; }

        /// <summary>
        /// summary of the video
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Video URL
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("video_url")]
        public global::G.VideoUrl? VideoUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoUrlInputChunk" /> class.
        /// </summary>
        /// <param name="chunkIndex">
        /// position of the chunk in a file
        /// </param>
        /// <param name="mimeType">
        /// mime type of the chunk<br/>
        /// Default Value: video/mp4
        /// </param>
        /// <param name="generatedMetadata">
        /// metadata of the chunk
        /// </param>
        /// <param name="model">
        /// model used for this chunk
        /// </param>
        /// <param name="type">
        /// Input type identifier<br/>
        /// Default Value: video_url
        /// </param>
        /// <param name="transcription">
        /// speech recognition (sr) text of the video
        /// </param>
        /// <param name="summary">
        /// summary of the video
        /// </param>
        /// <param name="videoUrl">
        /// Video URL
        /// </param>
        public VideoUrlInputChunk(
            int chunkIndex,
            string? mimeType,
            global::G.GeneratedMetadataVariant14? generatedMetadata,
            string? model,
            string? type,
            string? transcription,
            string? summary,
            global::G.VideoUrl? videoUrl)
        {
            this.ChunkIndex = chunkIndex;
            this.MimeType = mimeType;
            this.GeneratedMetadata = generatedMetadata;
            this.Model = model;
            this.Type = type;
            this.Transcription = transcription;
            this.Summary = summary;
            this.VideoUrl = videoUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VideoUrlInputChunk" /> class.
        /// </summary>
        public VideoUrlInputChunk()
        {
        }
    }
}