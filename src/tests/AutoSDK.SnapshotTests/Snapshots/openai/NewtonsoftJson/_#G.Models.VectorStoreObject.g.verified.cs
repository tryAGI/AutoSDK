//HintName: G.Models.VectorStoreObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A vector store is a collection of processed files can be used by the `file_search` tool.
    /// </summary>
    public sealed partial class VectorStoreObject
    {
        /// <summary>
        /// The Unix timestamp (in seconds) for when the vector store was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// The expiration policy for a vector store.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_after")]
        public global::G.VectorStoreExpirationAfter? ExpiresAfter { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the vector store will expire.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at")]
        public global::System.DateTimeOffset? ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_counts", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.VectorStoreObjectFileCounts FileCounts { get; set; } = default!;

        /// <summary>
        /// The identifier, which can be referenced in API endpoints.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) for when the vector store was last active.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_active_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset? LastActiveAt { get; set; } = default!;

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; } = default!;

        /// <summary>
        /// The name of the vector store.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The object type, which is always `vector_store`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.VectorStoreObjectObject Object { get; set; }

        /// <summary>
        /// The status of the vector store, which can be either `expired`, `in_progress`, or `completed`. A status of `completed` indicates that the vector store is ready for use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.VectorStoreObjectStatus Status { get; set; } = default!;

        /// <summary>
        /// The total number of bytes used by the files in the vector store.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage_bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int UsageBytes { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreObject" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) for when the vector store was created.
        /// </param>
        /// <param name="expiresAfter">
        /// The expiration policy for a vector store.
        /// </param>
        /// <param name="expiresAt">
        /// The Unix timestamp (in seconds) for when the vector store will expire.
        /// </param>
        /// <param name="fileCounts"></param>
        /// <param name="id">
        /// The identifier, which can be referenced in API endpoints.
        /// </param>
        /// <param name="lastActiveAt">
        /// The Unix timestamp (in seconds) for when the vector store was last active.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
        /// <param name="name">
        /// The name of the vector store.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `vector_store`.
        /// </param>
        /// <param name="status">
        /// The status of the vector store, which can be either `expired`, `in_progress`, or `completed`. A status of `completed` indicates that the vector store is ready for use.
        /// </param>
        /// <param name="usageBytes">
        /// The total number of bytes used by the files in the vector store.
        /// </param>
        public VectorStoreObject(
            global::System.DateTimeOffset createdAt,
            global::G.VectorStoreObjectFileCounts fileCounts,
            string id,
            global::System.DateTimeOffset? lastActiveAt,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            string name,
            global::G.VectorStoreObjectStatus status,
            int usageBytes,
            global::G.VectorStoreExpirationAfter? expiresAfter,
            global::System.DateTimeOffset? expiresAt,
            global::G.VectorStoreObjectObject @object)
        {
            this.CreatedAt = createdAt;
            this.FileCounts = fileCounts ?? throw new global::System.ArgumentNullException(nameof(fileCounts));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.LastActiveAt = lastActiveAt;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Status = status;
            this.UsageBytes = usageBytes;
            this.ExpiresAfter = expiresAfter;
            this.ExpiresAt = expiresAt;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreObject" /> class.
        /// </summary>
        public VectorStoreObject()
        {
        }
    }
}