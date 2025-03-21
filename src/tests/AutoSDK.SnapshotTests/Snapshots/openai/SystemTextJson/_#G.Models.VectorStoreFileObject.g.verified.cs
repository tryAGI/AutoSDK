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
        /// Set of 16 key-value pairs that can be attached to an object. This can be <br/>
        /// useful for storing additional information about the object in a structured <br/>
        /// format, and querying for objects via API or the dashboard. Keys are strings <br/>
        /// with a maximum length of 64 characters. Values are strings with a maximum <br/>
        /// length of 512 characters, booleans, or numbers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public object? Attributes { get; set; }

        /// <summary>
        /// The strategy used to chunk the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunking_strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.StaticChunkingStrategyResponseParam, global::G.OtherChunkingStrategyResponseParam>))]
        public global::G.OneOf<global::G.StaticChunkingStrategyResponseParam, global::G.OtherChunkingStrategyResponseParam>? ChunkingStrategy { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the vector store file was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The identifier, which can be referenced in API endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The last error associated with this vector store file. Will be `null` if there are no errors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.VectorStoreFileObjectLastError? LastError { get; set; }

        /// <summary>
        /// The object type, which is always `vector_store.file`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VectorStoreFileObjectObjectJsonConverter))]
        public global::G.VectorStoreFileObjectObject Object { get; set; }

        /// <summary>
        /// The status of the vector store file, which can be either `in_progress`, `completed`, `cancelled`, or `failed`. The status `completed` indicates that the vector store file is ready for use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VectorStoreFileObjectStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.VectorStoreFileObjectStatus Status { get; set; }

        /// <summary>
        /// The total vector store usage in bytes. Note that this may be different from the original file size.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UsageBytes { get; set; }

        /// <summary>
        /// The ID of the [vector store](/docs/api-reference/vector-stores/object) that the [File](/docs/api-reference/files) is attached to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_store_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VectorStoreId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreFileObject" /> class.
        /// </summary>
        /// <param name="attributes">
        /// Set of 16 key-value pairs that can be attached to an object. This can be <br/>
        /// useful for storing additional information about the object in a structured <br/>
        /// format, and querying for objects via API or the dashboard. Keys are strings <br/>
        /// with a maximum length of 64 characters. Values are strings with a maximum <br/>
        /// length of 512 characters, booleans, or numbers.
        /// </param>
        /// <param name="chunkingStrategy">
        /// The strategy used to chunk the file.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) for when the vector store file was created.
        /// </param>
        /// <param name="id">
        /// The identifier, which can be referenced in API endpoints.
        /// </param>
        /// <param name="lastError">
        /// The last error associated with this vector store file. Will be `null` if there are no errors.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `vector_store.file`.
        /// </param>
        /// <param name="status">
        /// The status of the vector store file, which can be either `in_progress`, `completed`, `cancelled`, or `failed`. The status `completed` indicates that the vector store file is ready for use.
        /// </param>
        /// <param name="usageBytes">
        /// The total vector store usage in bytes. Note that this may be different from the original file size.
        /// </param>
        /// <param name="vectorStoreId">
        /// The ID of the [vector store](/docs/api-reference/vector-stores/object) that the [File](/docs/api-reference/files) is attached to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VectorStoreFileObject(
            global::System.DateTimeOffset createdAt,
            string id,
            global::G.VectorStoreFileObjectLastError? lastError,
            global::G.VectorStoreFileObjectStatus status,
            int usageBytes,
            string vectorStoreId,
            object? attributes,
            global::G.OneOf<global::G.StaticChunkingStrategyResponseParam, global::G.OtherChunkingStrategyResponseParam>? chunkingStrategy,
            global::G.VectorStoreFileObjectObject @object)
        {
            this.CreatedAt = createdAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.LastError = lastError ?? throw new global::System.ArgumentNullException(nameof(lastError));
            this.Status = status;
            this.UsageBytes = usageBytes;
            this.VectorStoreId = vectorStoreId ?? throw new global::System.ArgumentNullException(nameof(vectorStoreId));
            this.Attributes = attributes;
            this.ChunkingStrategy = chunkingStrategy;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreFileObject" /> class.
        /// </summary>
        public VectorStoreFileObject()
        {
        }
    }
}