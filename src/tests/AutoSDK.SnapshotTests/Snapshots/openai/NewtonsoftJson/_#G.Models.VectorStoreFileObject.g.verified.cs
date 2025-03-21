//HintName: G.Models.VectorStoreFileObject.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A list of files attached to a vector store.
    /// </summary>
    public sealed partial class VectorStoreFileObject
    {
        /// <summary>
        /// The identifier, which can be referenced in API endpoints.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The object type, which is always `vector_store.file`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.VectorStoreFileObjectObject Object { get; set; }

        /// <summary>
        /// The total vector store usage in bytes. Note that this may be different from the original file size.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage_bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int UsageBytes { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) for when the vector store file was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// The ID of the [vector store](/docs/api-reference/vector-stores/object) that the [File](/docs/api-reference/files) is attached to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector_store_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VectorStoreId { get; set; } = default!;

        /// <summary>
        /// The status of the vector store file, which can be either `in_progress`, `completed`, `cancelled`, or `failed`. The status `completed` indicates that the vector store file is ready for use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.VectorStoreFileObjectStatus Status { get; set; } = default!;

        /// <summary>
        /// The last error associated with this vector store file. Will be `null` if there are no errors.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_error", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.VectorStoreFileObjectLastError? LastError { get; set; } = default!;

        /// <summary>
        /// The strategy used to chunk the file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunking_strategy")]
        public global::G.OneOf<global::G.StaticChunkingStrategyResponseParam, global::G.OtherChunkingStrategyResponseParam>? ChunkingStrategy { get; set; }

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be <br/>
        /// useful for storing additional information about the object in a structured <br/>
        /// format, and querying for objects via API or the dashboard. Keys are strings <br/>
        /// with a maximum length of 64 characters. Values are strings with a maximum <br/>
        /// length of 512 characters, booleans, or numbers.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("attributes")]
        public object? Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreFileObject" /> class.
        /// </summary>
        /// <param name="id">
        /// The identifier, which can be referenced in API endpoints.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `vector_store.file`.
        /// </param>
        /// <param name="usageBytes">
        /// The total vector store usage in bytes. Note that this may be different from the original file size.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) for when the vector store file was created.
        /// </param>
        /// <param name="vectorStoreId">
        /// The ID of the [vector store](/docs/api-reference/vector-stores/object) that the [File](/docs/api-reference/files) is attached to.
        /// </param>
        /// <param name="status">
        /// The status of the vector store file, which can be either `in_progress`, `completed`, `cancelled`, or `failed`. The status `completed` indicates that the vector store file is ready for use.
        /// </param>
        /// <param name="lastError">
        /// The last error associated with this vector store file. Will be `null` if there are no errors.
        /// </param>
        /// <param name="chunkingStrategy">
        /// The strategy used to chunk the file.
        /// </param>
        /// <param name="attributes">
        /// Set of 16 key-value pairs that can be attached to an object. This can be <br/>
        /// useful for storing additional information about the object in a structured <br/>
        /// format, and querying for objects via API or the dashboard. Keys are strings <br/>
        /// with a maximum length of 64 characters. Values are strings with a maximum <br/>
        /// length of 512 characters, booleans, or numbers.
        /// </param>
        public VectorStoreFileObject(
            string id,
            int usageBytes,
            global::System.DateTimeOffset createdAt,
            string vectorStoreId,
            global::G.VectorStoreFileObjectStatus status,
            global::G.VectorStoreFileObjectLastError? lastError,
            global::G.VectorStoreFileObjectObject @object,
            global::G.OneOf<global::G.StaticChunkingStrategyResponseParam, global::G.OtherChunkingStrategyResponseParam>? chunkingStrategy,
            object? attributes)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.UsageBytes = usageBytes;
            this.CreatedAt = createdAt;
            this.VectorStoreId = vectorStoreId ?? throw new global::System.ArgumentNullException(nameof(vectorStoreId));
            this.Status = status;
            this.LastError = lastError ?? throw new global::System.ArgumentNullException(nameof(lastError));
            this.Object = @object;
            this.ChunkingStrategy = chunkingStrategy;
            this.Attributes = attributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreFileObject" /> class.
        /// </summary>
        public VectorStoreFileObject()
        {
        }
    }
}