//HintName: G.Models.FileSchema.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// File with human-readable ID for agent file
    /// </summary>
    public sealed partial class FileSchema
    {
        /// <summary>
        /// Deprecated: Use `folder_id` field instead. The unique identifier of the source associated with the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceId { get; set; }

        /// <summary>
        /// The name of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_name")]
        public string? FileName { get; set; }

        /// <summary>
        /// The original name of the file as uploaded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_file_name")]
        public string? OriginalFileName { get; set; }

        /// <summary>
        /// The path to the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_path")]
        public string? FilePath { get; set; }

        /// <summary>
        /// The type of the file (MIME type).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_type")]
        public string? FileType { get; set; }

        /// <summary>
        /// The size of the file in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_size")]
        public long? FileSize { get; set; }

        /// <summary>
        /// The creation date of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_creation_date")]
        public string? FileCreationDate { get; set; }

        /// <summary>
        /// The last modified date of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_last_modified_date")]
        public string? FileLastModifiedDate { get; set; }

        /// <summary>
        /// The current processing status of the file (e.g. pending, parsing, embedding, completed, error).<br/>
        /// Default Value: pending
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FileProcessingStatusJsonConverter))]
        public global::G.FileProcessingStatus? ProcessingStatus { get; set; }

        /// <summary>
        /// Optional error message if the file failed processing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Total number of chunks for the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_chunks")]
        public int? TotalChunks { get; set; }

        /// <summary>
        /// Number of chunks that have been embedded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunks_embedded")]
        public int? ChunksEmbedded { get; set; }

        /// <summary>
        /// Optional full-text content of the file; only populated on demand due to its size.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Human-readable identifier for this file in the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSchema" /> class.
        /// </summary>
        /// <param name="sourceId">
        /// Deprecated: Use `folder_id` field instead. The unique identifier of the source associated with the document.
        /// </param>
        /// <param name="id">
        /// Human-readable identifier for this file in the file
        /// </param>
        /// <param name="fileName">
        /// The name of the file.
        /// </param>
        /// <param name="originalFileName">
        /// The original name of the file as uploaded.
        /// </param>
        /// <param name="filePath">
        /// The path to the file.
        /// </param>
        /// <param name="fileType">
        /// The type of the file (MIME type).
        /// </param>
        /// <param name="fileSize">
        /// The size of the file in bytes.
        /// </param>
        /// <param name="fileCreationDate">
        /// The creation date of the file.
        /// </param>
        /// <param name="fileLastModifiedDate">
        /// The last modified date of the file.
        /// </param>
        /// <param name="processingStatus">
        /// The current processing status of the file (e.g. pending, parsing, embedding, completed, error).<br/>
        /// Default Value: pending
        /// </param>
        /// <param name="errorMessage">
        /// Optional error message if the file failed processing.
        /// </param>
        /// <param name="totalChunks">
        /// Total number of chunks for the file.
        /// </param>
        /// <param name="chunksEmbedded">
        /// Number of chunks that have been embedded.
        /// </param>
        /// <param name="content">
        /// Optional full-text content of the file; only populated on demand due to its size.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileSchema(
            string sourceId,
            string id,
            string? fileName,
            string? originalFileName,
            string? filePath,
            string? fileType,
            long? fileSize,
            string? fileCreationDate,
            string? fileLastModifiedDate,
            global::G.FileProcessingStatus? processingStatus,
            string? errorMessage,
            int? totalChunks,
            int? chunksEmbedded,
            string? content)
        {
            this.SourceId = sourceId ?? throw new global::System.ArgumentNullException(nameof(sourceId));
            this.FileName = fileName;
            this.OriginalFileName = originalFileName;
            this.FilePath = filePath;
            this.FileType = fileType;
            this.FileSize = fileSize;
            this.FileCreationDate = fileCreationDate;
            this.FileLastModifiedDate = fileLastModifiedDate;
            this.ProcessingStatus = processingStatus;
            this.ErrorMessage = errorMessage;
            this.TotalChunks = totalChunks;
            this.ChunksEmbedded = chunksEmbedded;
            this.Content = content;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSchema" /> class.
        /// </summary>
        public FileSchema()
        {
        }
    }
}