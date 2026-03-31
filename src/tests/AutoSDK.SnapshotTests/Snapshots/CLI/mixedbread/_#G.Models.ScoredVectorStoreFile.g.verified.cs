//HintName: G.Models.ScoredVectorStoreFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a scored store file.
    /// </summary>
    public sealed partial class ScoredVectorStoreFile
    {
        /// <summary>
        /// Unique identifier for the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Optional file metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Processing status of the file<br/>
        /// Default Value: pending
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StoreFileStatusJsonConverter))]
        public global::G.StoreFileStatus? Status { get; set; }

        /// <summary>
        /// Last error message if processing failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_error")]
        public object? LastError { get; set; }

        /// <summary>
        /// ID of the containing store
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_store_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VectorStoreId { get; set; }

        /// <summary>
        /// Timestamp of store file creation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Version number of the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// Storage usage in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_bytes")]
        public long? UsageBytes { get; set; }

        /// <summary>
        /// Type of the object<br/>
        /// Default Value: vector_store.file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Array of scored file chunks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunks")]
        public global::System.Collections.Generic.IList<global::G.ChunksVariant1Item2>? Chunks { get; set; }

        /// <summary>
        /// score of the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoredVectorStoreFile" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the file
        /// </param>
        /// <param name="vectorStoreId">
        /// ID of the containing store
        /// </param>
        /// <param name="createdAt">
        /// Timestamp of store file creation
        /// </param>
        /// <param name="score">
        /// score of the file
        /// </param>
        /// <param name="filename">
        /// Name of the file
        /// </param>
        /// <param name="metadata">
        /// Optional file metadata
        /// </param>
        /// <param name="status">
        /// Processing status of the file<br/>
        /// Default Value: pending
        /// </param>
        /// <param name="lastError">
        /// Last error message if processing failed
        /// </param>
        /// <param name="version">
        /// Version number of the file
        /// </param>
        /// <param name="usageBytes">
        /// Storage usage in bytes
        /// </param>
        /// <param name="object">
        /// Type of the object<br/>
        /// Default Value: vector_store.file
        /// </param>
        /// <param name="chunks">
        /// Array of scored file chunks
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScoredVectorStoreFile(
            string id,
            string vectorStoreId,
            global::System.DateTime createdAt,
            double score,
            string? filename,
            object? metadata,
            global::G.StoreFileStatus? status,
            object? lastError,
            int? version,
            long? usageBytes,
            string? @object,
            global::System.Collections.Generic.IList<global::G.ChunksVariant1Item2>? chunks)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Filename = filename;
            this.Metadata = metadata;
            this.Status = status;
            this.LastError = lastError;
            this.VectorStoreId = vectorStoreId ?? throw new global::System.ArgumentNullException(nameof(vectorStoreId));
            this.CreatedAt = createdAt;
            this.Version = version;
            this.UsageBytes = usageBytes;
            this.Object = @object;
            this.Chunks = chunks;
            this.Score = score;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoredVectorStoreFile" /> class.
        /// </summary>
        public ScoredVectorStoreFile()
        {
        }
    }
}