//HintName: G.Models.CreateVectorStoreRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVectorStoreRequest
    {
        /// <summary>
        /// A list of [File](/docs/api-reference/files) IDs that the vector store should use. Useful for tools like `file_search` that can access files.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_ids")]
        public global::System.Collections.Generic.IList<string>? FileIds { get; set; }

        /// <summary>
        /// The name of the vector store.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The expiration policy for a vector store.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_after")]
        public global::G.VectorStoreExpirationAfter? ExpiresAfter { get; set; }

        /// <summary>
        /// The chunking strategy used to chunk the file(s). If not set, will use the `auto` strategy. Only applicable if `file_ids` is non-empty.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunking_strategy")]
        public global::G.CreateVectorStoreRequestChunkingStrategy? ChunkingStrategy { get; set; }

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maximum of 512 characters long.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectorStoreRequest" /> class.
        /// </summary>
        /// <param name="fileIds">
        /// A list of [File](/docs/api-reference/files) IDs that the vector store should use. Useful for tools like `file_search` that can access files.
        /// </param>
        /// <param name="name">
        /// The name of the vector store.
        /// </param>
        /// <param name="expiresAfter">
        /// The expiration policy for a vector store.
        /// </param>
        /// <param name="chunkingStrategy">
        /// The chunking strategy used to chunk the file(s). If not set, will use the `auto` strategy. Only applicable if `file_ids` is non-empty.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be useful for storing additional information about the object in a structured format. Keys can be a maximum of 64 characters long and values can be a maximum of 512 characters long.
        /// </param>
        public CreateVectorStoreRequest(
            global::System.Collections.Generic.IList<string>? fileIds,
            string? name,
            global::G.VectorStoreExpirationAfter? expiresAfter,
            global::G.CreateVectorStoreRequestChunkingStrategy? chunkingStrategy,
            object? metadata)
        {
            this.FileIds = fileIds;
            this.Name = name;
            this.ExpiresAfter = expiresAfter;
            this.ChunkingStrategy = chunkingStrategy;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectorStoreRequest" /> class.
        /// </summary>
        public CreateVectorStoreRequest()
        {
        }
    }
}