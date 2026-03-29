//HintName: G.Models.VectorStoreFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a file stored in a store.
    /// </summary>
    public sealed partial class VectorStoreFile
    {
        /// <summary>
        /// Unique identifier for the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Name of the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Optional file metadata
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Processing status of the file<br/>
        /// Default Value: pending
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.StoreFileStatus? Status { get; set; }

        /// <summary>
        /// Last error message if processing failed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_error")]
        public object? LastError { get; set; }

        /// <summary>
        /// ID of the containing store
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector_store_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VectorStoreId { get; set; } = default!;

        /// <summary>
        /// Timestamp of store file creation
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Version number of the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version")]
        public int? Version { get; set; }

        /// <summary>
        /// Storage usage in bytes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage_bytes")]
        public long? UsageBytes { get; set; }

        /// <summary>
        /// Type of the object<br/>
        /// Default Value: vector_store.file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public string? Object { get; set; }

        /// <summary>
        /// chunks
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunks")]
        public global::System.Collections.Generic.IList<global::G.ChunksVariant1Item4>? Chunks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreFile" /> class.
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
        /// chunks
        /// </param>
        public VectorStoreFile(
            string id,
            string vectorStoreId,
            global::System.DateTime createdAt,
            string? filename,
            object? metadata,
            global::G.StoreFileStatus? status,
            object? lastError,
            int? version,
            long? usageBytes,
            string? @object,
            global::System.Collections.Generic.IList<global::G.ChunksVariant1Item4>? chunks)
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
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreFile" /> class.
        /// </summary>
        public VectorStoreFile()
        {
        }
    }
}