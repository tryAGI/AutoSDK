//HintName: G.Models.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Scored video chunk for deprecated API.
    /// </summary>
    public sealed partial class MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk
    {
        /// <summary>
        /// position of the chunk in a file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ChunkIndex { get; set; }

        /// <summary>
        /// mime type of the chunk<br/>
        /// Default Value: video/mp4
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        public string? MimeType { get; set; }

        /// <summary>
        /// metadata of the chunk
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_metadata")]
        public global::G.GeneratedMetadataVariant18? GeneratedMetadata { get; set; }

        /// <summary>
        /// model used for this chunk
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// score of the chunk
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// file id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// filename
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// store id
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_store_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VectorStoreId { get; set; }

        /// <summary>
        /// file metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Input type identifier<br/>
        /// Default Value: video_url
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// speech recognition (sr) text of the video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transcription")]
        public string? Transcription { get; set; }

        /// <summary>
        /// summary of the video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Video URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video_url")]
        public global::G.VideoUrl? VideoUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk" /> class.
        /// </summary>
        /// <param name="chunkIndex">
        /// position of the chunk in a file
        /// </param>
        /// <param name="score">
        /// score of the chunk
        /// </param>
        /// <param name="fileId">
        /// file id
        /// </param>
        /// <param name="filename">
        /// filename
        /// </param>
        /// <param name="vectorStoreId">
        /// store id
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
        /// <param name="metadata">
        /// file metadata
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk(
            int chunkIndex,
            double score,
            string fileId,
            string filename,
            string vectorStoreId,
            string? mimeType,
            global::G.GeneratedMetadataVariant18? generatedMetadata,
            string? model,
            object? metadata,
            string? type,
            string? transcription,
            string? summary,
            global::G.VideoUrl? videoUrl)
        {
            this.ChunkIndex = chunkIndex;
            this.MimeType = mimeType;
            this.GeneratedMetadata = generatedMetadata;
            this.Model = model;
            this.Score = score;
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.VectorStoreId = vectorStoreId ?? throw new global::System.ArgumentNullException(nameof(vectorStoreId));
            this.Metadata = metadata;
            this.Type = type;
            this.Transcription = transcription;
            this.Summary = summary;
            this.VideoUrl = videoUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk" /> class.
        /// </summary>
        public MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk()
        {
        }
    }
}