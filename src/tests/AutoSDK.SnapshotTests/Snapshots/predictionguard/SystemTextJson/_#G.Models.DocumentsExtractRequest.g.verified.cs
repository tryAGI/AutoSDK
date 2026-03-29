//HintName: G.Models.DocumentsExtractRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentsExtractRequest
    {
        /// <summary>
        /// The document file to upload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// The document file to upload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Whether to embed images from the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedImages")]
        public bool? EmbedImages { get; set; }

        /// <summary>
        /// The output format for the content of the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputFormat")]
        public string? OutputFormat { get; set; }

        /// <summary>
        /// Whether to separate the document into chunks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunkDocument")]
        public bool? ChunkDocument { get; set; }

        /// <summary>
        /// The size of chunks for the documents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunkSize")]
        public int? ChunkSize { get; set; }

        /// <summary>
        /// Whether to enable OCR for document parsing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enableOCR")]
        public bool? EnableOCR { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentsExtractRequest" /> class.
        /// </summary>
        /// <param name="file">
        /// The document file to upload.
        /// </param>
        /// <param name="filename">
        /// The document file to upload.
        /// </param>
        /// <param name="embedImages">
        /// Whether to embed images from the document.
        /// </param>
        /// <param name="outputFormat">
        /// The output format for the content of the document.
        /// </param>
        /// <param name="chunkDocument">
        /// Whether to separate the document into chunks.
        /// </param>
        /// <param name="chunkSize">
        /// The size of chunks for the documents.
        /// </param>
        /// <param name="enableOCR">
        /// Whether to enable OCR for document parsing.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentsExtractRequest(
            byte[] file,
            string filename,
            bool? embedImages,
            string? outputFormat,
            bool? chunkDocument,
            int? chunkSize,
            bool? enableOCR)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.EmbedImages = embedImages;
            this.OutputFormat = outputFormat;
            this.ChunkDocument = chunkDocument;
            this.ChunkSize = chunkSize;
            this.EnableOCR = enableOCR;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentsExtractRequest" /> class.
        /// </summary>
        public DocumentsExtractRequest()
        {
        }
    }
}