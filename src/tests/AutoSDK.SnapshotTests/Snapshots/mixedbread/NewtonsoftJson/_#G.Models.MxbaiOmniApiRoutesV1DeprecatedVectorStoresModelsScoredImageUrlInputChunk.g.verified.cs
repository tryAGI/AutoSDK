//HintName: G.Models.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Scored image chunk for deprecated API.
    /// </summary>
    public sealed partial class MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk
    {
        /// <summary>
        /// position of the chunk in a file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunk_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int ChunkIndex { get; set; } = default!;

        /// <summary>
        /// mime type of the chunk<br/>
        /// Default Value: image/jpeg
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mime_type")]
        public string? MimeType { get; set; }

        /// <summary>
        /// metadata of the chunk
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generated_metadata")]
        public global::G.GeneratedMetadataVariant16? GeneratedMetadata { get; set; }

        /// <summary>
        /// model used for this chunk
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model")]
        public string? Model { get; set; }

        /// <summary>
        /// score of the chunk
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score", Required = global::Newtonsoft.Json.Required.Always)]
        public double Score { get; set; } = default!;

        /// <summary>
        /// file id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileId { get; set; } = default!;

        /// <summary>
        /// filename
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// store id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector_store_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VectorStoreId { get; set; } = default!;

        /// <summary>
        /// file metadata
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Input type identifier<br/>
        /// Default Value: image_url
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; }

        /// <summary>
        /// ocr text of the image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ocr_text")]
        public string? OcrText { get; set; }

        /// <summary>
        /// summary of the image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("summary")]
        public string? Summary { get; set; }

        /// <summary>
        /// Image URL
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_url")]
        public global::G.ImageUrlOutput? ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk" /> class.
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
        /// Default Value: image/jpeg
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
        /// Default Value: image_url
        /// </param>
        /// <param name="ocrText">
        /// ocr text of the image
        /// </param>
        /// <param name="summary">
        /// summary of the image
        /// </param>
        /// <param name="imageUrl">
        /// Image URL
        /// </param>
        public MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk(
            int chunkIndex,
            double score,
            string fileId,
            string filename,
            string vectorStoreId,
            string? mimeType,
            global::G.GeneratedMetadataVariant16? generatedMetadata,
            string? model,
            object? metadata,
            string? type,
            string? ocrText,
            string? summary,
            global::G.ImageUrlOutput? imageUrl)
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
            this.OcrText = ocrText;
            this.Summary = summary;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk" /> class.
        /// </summary>
        public MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk()
        {
        }
    }
}