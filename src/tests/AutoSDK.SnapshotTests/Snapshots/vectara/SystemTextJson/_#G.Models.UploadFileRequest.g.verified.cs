//HintName: G.Models.UploadFileRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request to upload and index a file into a corpus within a customer account.<br/>
    /// Example: {"metadata":{"department\u0022":"engineering","doc_type\u0022":"architecture_diagram"},"chunking_strategy":{"type":"sentence_chunking_strategy"},"table_extraction_config":{"extract_tables":true},"filename":"system_design_v1.pdf","file":"system_design_v1.pdf"}
    /// </summary>
    public sealed partial class UploadFileRequest
    {
        /// <summary>
        /// Arbitrary object that will be attached as document metadata to the extracted document.<br/>
        /// Example: {"department":"engineering","doc_type\u0022":"architecture_diagram"}
        /// </summary>
        /// <example>{"department":"engineering","doc_type\u0022":"architecture_diagram"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Choose how to split documents into chunks during indexing. This is optional - if you do not set a chunking strategy, the platform uses the default strategy which creates one chunk (docpart) per sentence.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunking_strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChunkingStrategyJsonConverter))]
        public global::G.ChunkingStrategy? ChunkingStrategy { get; set; }

        /// <summary>
        /// Configuration for table extraction from the document. This is optional and if not provided, the platform does not extract tables from PDF files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table_extraction_config")]
        public global::G.TableExtractionConfig? TableExtractionConfig { get; set; }

        /// <summary>
        /// Optional multipart section to override the filename.<br/>
        /// Example: system_design_v1.pdf
        /// </summary>
        /// <example>system_design_v1.pdf</example>
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
        /// <param name="file">
        /// Binary file contents. The file name of the file will be used as the document ID.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary object that will be attached as document metadata to the extracted document.<br/>
        /// Example: {"department":"engineering","doc_type\u0022":"architecture_diagram"}
        /// </param>
        /// <param name="chunkingStrategy">
        /// Choose how to split documents into chunks during indexing. This is optional - if you do not set a chunking strategy, the platform uses the default strategy which creates one chunk (docpart) per sentence.
        /// </param>
        /// <param name="tableExtractionConfig">
        /// Configuration for table extraction from the document. This is optional and if not provided, the platform does not extract tables from PDF files.
        /// </param>
        /// <param name="filename">
        /// Optional multipart section to override the filename.<br/>
        /// Example: system_design_v1.pdf
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
            this.Metadata = metadata;
            this.ChunkingStrategy = chunkingStrategy;
            this.TableExtractionConfig = tableExtractionConfig;
            this.Filename = filename;
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadFileRequest" /> class.
        /// </summary>
        public UploadFileRequest()
        {
        }
    }
}