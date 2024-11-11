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
        /// The identifier, which can be referenced in API endpoints.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The object type, which is always `vector_store.file_batch`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.VectorStoreFileBatchObjectObject Object { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the vector store files batch was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// The ID of the [vector store](/docs/api-reference/vector-stores/object) that the [File](/docs/api-reference/files) is attached to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector_store_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string VectorStoreId { get; set; } = default!;

        /// <summary>
        /// The status of the vector store files batch, which can be either `in_progress`, `completed`, `cancelled` or `failed`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.VectorStoreFileBatchObjectStatus Status { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_counts", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.VectorStoreFileBatchObjectFileCounts FileCounts { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreFileBatchObject" /> class.
        /// </summary>
        /// <param name="id">
        /// The identifier, which can be referenced in API endpoints.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `vector_store.file_batch`.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) for when the vector store files batch was created.
        /// </param>
        /// <param name="vectorStoreId">
        /// The ID of the [vector store](/docs/api-reference/vector-stores/object) that the [File](/docs/api-reference/files) is attached to.
        /// </param>
        /// <param name="status">
        /// The status of the vector store files batch, which can be either `in_progress`, `completed`, `cancelled` or `failed`.
        /// </param>
        /// <param name="fileCounts"></param>
        public VectorStoreFileBatchObject(
            string id,
            global::System.DateTimeOffset createdAt,
            string vectorStoreId,
            global::G.VectorStoreFileBatchObjectStatus status,
            global::G.VectorStoreFileBatchObjectFileCounts fileCounts,
            global::G.VectorStoreFileBatchObjectObject @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.VectorStoreId = vectorStoreId ?? throw new global::System.ArgumentNullException(nameof(vectorStoreId));
            this.Status = status;
            this.FileCounts = fileCounts ?? throw new global::System.ArgumentNullException(nameof(fileCounts));
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