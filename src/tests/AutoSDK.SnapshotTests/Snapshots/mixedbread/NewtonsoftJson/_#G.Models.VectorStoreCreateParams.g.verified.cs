//HintName: G.Models.VectorStoreCreateParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for creating a new vector store.
    /// </summary>
    public sealed partial class VectorStoreCreateParams
    {
        /// <summary>
        /// Name for the new vector store
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the vector store
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whether the vector store can be accessed by anyone with valid login credentials<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_public")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// Optional expiration policy
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_after")]
        public global::G.ExpiresAfter? ExpiresAfter { get; set; }

        /// <summary>
        /// Optional metadata key-value pairs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Optional list of file IDs
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? FileIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreCreateParams" /> class.
        /// </summary>
        /// <param name="name">
        /// Name for the new vector store
        /// </param>
        /// <param name="description">
        /// Description of the vector store
        /// </param>
        /// <param name="isPublic">
        /// Whether the vector store can be accessed by anyone with valid login credentials<br/>
        /// Default Value: false
        /// </param>
        /// <param name="expiresAfter">
        /// Optional expiration policy
        /// </param>
        /// <param name="metadata">
        /// Optional metadata key-value pairs
        /// </param>
        /// <param name="fileIds">
        /// Optional list of file IDs
        /// </param>
        public VectorStoreCreateParams(
            string? name,
            string? description,
            bool? isPublic,
            global::G.ExpiresAfter? expiresAfter,
            object? metadata,
            global::System.Collections.Generic.IList<global::System.Guid>? fileIds)
        {
            this.Name = name;
            this.Description = description;
            this.IsPublic = isPublic;
            this.ExpiresAfter = expiresAfter;
            this.Metadata = metadata;
            this.FileIds = fileIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreCreateParams" /> class.
        /// </summary>
        public VectorStoreCreateParams()
        {
        }
    }
}