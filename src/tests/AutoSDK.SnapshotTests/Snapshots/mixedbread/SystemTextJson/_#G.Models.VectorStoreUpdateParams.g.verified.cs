//HintName: G.Models.VectorStoreUpdateParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for updating an existing store.
    /// </summary>
    public sealed partial class VectorStoreUpdateParams
    {
        /// <summary>
        /// New name for the store
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// New description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whether the vector store can be accessed by anyone with valid login credentials
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_public")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// Optional expiration policy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_after")]
        public global::G.ExpiresAfter? ExpiresAfter { get; set; }

        /// <summary>
        /// Optional metadata key-value pairs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreUpdateParams" /> class.
        /// </summary>
        /// <param name="name">
        /// New name for the store
        /// </param>
        /// <param name="description">
        /// New description
        /// </param>
        /// <param name="isPublic">
        /// Whether the vector store can be accessed by anyone with valid login credentials
        /// </param>
        /// <param name="expiresAfter">
        /// Optional expiration policy
        /// </param>
        /// <param name="metadata">
        /// Optional metadata key-value pairs
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VectorStoreUpdateParams(
            string? name,
            string? description,
            bool? isPublic,
            global::G.ExpiresAfter? expiresAfter,
            object? metadata)
        {
            this.Name = name;
            this.Description = description;
            this.IsPublic = isPublic;
            this.ExpiresAfter = expiresAfter;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreUpdateParams" /> class.
        /// </summary>
        public VectorStoreUpdateParams()
        {
        }
    }
}