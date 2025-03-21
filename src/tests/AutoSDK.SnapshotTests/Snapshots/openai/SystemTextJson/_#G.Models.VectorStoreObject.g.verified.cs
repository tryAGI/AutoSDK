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
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The expiration policy for a vector store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_after")]
        public global::G.VectorStoreExpirationAfter? ExpiresAfter { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the vector store will expire.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_counts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.VectorStoreObjectFileCounts FileCounts { get; set; }

        /// <summary>
        /// The identifier, which can be referenced in API endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the vector store was last active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_active_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset? LastActiveAt { get; set; }

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// The name of the vector store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The object type, which is always `vector_store`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VectorStoreObjectObjectJsonConverter))]
        public global::G.VectorStoreObjectObject Object { get; set; }

        /// <summary>
        /// The status of the vector store, which can be either `expired`, `in_progress`, or `completed`. A status of `completed` indicates that the vector store is ready for use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VectorStoreObjectStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.VectorStoreObjectStatus Status { get; set; }

        /// <summary>
        /// The total number of bytes used by the files in the vector store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UsageBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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