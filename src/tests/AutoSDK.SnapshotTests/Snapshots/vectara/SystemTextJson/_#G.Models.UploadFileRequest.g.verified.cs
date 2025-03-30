//HintName: G.Models.UploadFileRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to upload and index a file into a corpus within a customer account.
    /// </summary>
    public sealed partial class UploadFileRequest
    {
        /// <summary>
        /// Arbitrary object that will be attached as document metadata to the extracted document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Choose how to split documents into chunks during indexing. This is optional - if you do not set a chunking strategy,<br/>
        /// the platform uses the default strategy which creates one chunk (docpart) per sentence.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunking_strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChunkingStrategyJsonConverter))]
        public global::G.ChunkingStrategy? ChunkingStrategy { get; set; }

        /// <summary>
        /// Configuration for table extraction from the document. This is optional and if not provided, default table extraction behavior will be used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table_extraction_config")]
        public global::G.TableExtractionConfig? TableExtractionConfig { get; set; }

        /// <summary>
        /// Optional multipart section to override the filename.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Binary file contents. The file name of the file will be used as the document ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] File { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadFileRequest" /> class.
        /// </summary>
        /// <param name="metadata">
        /// Arbitrary object that will be attached as document metadata to the extracted document.
        /// </param>
        /// <param name="chunkingStrategy">
        /// Choose how to split documents into chunks during indexing. This is optional - if you do not set a chunking strategy,<br/>
        /// the platform uses the default strategy which creates one chunk (docpart) per sentence.
        /// </param>
        /// <param name="tableExtractionConfig">
        /// Configuration for table extraction from the document. This is optional and if not provided, default table extraction behavior will be used.
        /// </param>
        /// <param name="filename">
        /// Optional multipart section to override the filename.
        /// </param>
        /// <param name="file">
        /// Binary file contents. The file name of the file will be used as the document ID.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadFileRequest(
            byte[] file,
            object? metadata,
            global::G.ChunkingStrategy? chunkingStrategy,
            global::G.TableExtractionConfig? tableExtractionConfig,
            string? filename)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Metadata = metadata;
            this.ChunkingStrategy = chunkingStrategy;
            this.TableExtractionConfig = tableExtractionConfig;
            this.Filename = filename;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadFileRequest" /> class.
        /// </summary>
        public UploadFileRequest()
        {
        }
    }
}