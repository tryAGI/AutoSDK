//HintName: G.Models.VectorStoreFileBatchObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A batch of files attached to a vector store.
    /// </summary>
    public sealed partial class VectorStoreFileBatchObject
    {
        /// <summary>
        /// The Unix timestamp (in seconds) for when the vector store files batch was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_counts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.VectorStoreFileBatchObjectFileCounts FileCounts { get; set; }

        /// <summary>
        /// The identifier, which can be referenced in API endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type, which is always `vector_store.file_batch`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VectorStoreFileBatchObjectObjectJsonConverter))]
        public global::G.VectorStoreFileBatchObjectObject Object { get; set; }

        /// <summary>
        /// The status of the vector store files batch, which can be either `in_progress`, `completed`, `cancelled` or `failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VectorStoreFileBatchObjectStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.VectorStoreFileBatchObjectStatus Status { get; set; }

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
        /// Initializes a new instance of the <see cref="VectorStoreFileBatchObject" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) for when the vector store files batch was created.
        /// </param>
        /// <param name="fileCounts"></param>
        /// <param name="id">
        /// The identifier, which can be referenced in API endpoints.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `vector_store.file_batch`.
        /// </param>
        /// <param name="status">
        /// The status of the vector store files batch, which can be either `in_progress`, `completed`, `cancelled` or `failed`.
        /// </param>
        /// <param name="vectorStoreId">
        /// The ID of the [vector store](/docs/api-reference/vector-stores/object) that the [File](/docs/api-reference/files) is attached to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VectorStoreFileBatchObject(
            global::System.DateTimeOffset createdAt,
            global::G.VectorStoreFileBatchObjectFileCounts fileCounts,
            string id,
            global::G.VectorStoreFileBatchObjectStatus status,
            string vectorStoreId,
            global::G.VectorStoreFileBatchObjectObject @object)
        {
            this.CreatedAt = createdAt;
            this.FileCounts = fileCounts ?? throw new global::System.ArgumentNullException(nameof(fileCounts));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Status = status;
            this.VectorStoreId = vectorStoreId ?? throw new global::System.ArgumentNullException(nameof(vectorStoreId));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreFileBatchObject" /> class.
        /// </summary>
        public VectorStoreFileBatchObject()
        {
        }
    }
}