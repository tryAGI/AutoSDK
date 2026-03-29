//HintName: G.Models.CloudMilvusVectorStore.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Cloud Milvus Vector Store.
    /// </summary>
    public sealed partial class CloudMilvusVectorStore
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_nested_metadata_filters")]
        public bool? SupportsNestedMetadataFilters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Uri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection_name")]
        public string? CollectionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_dimension")]
        public int? EmbeddingDimension { get; set; }

        /// <summary>
        /// Default Value: CloudMilvusVectorStore
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudMilvusVectorStore" /> class.
        /// </summary>
        /// <param name="uri"></param>
        /// <param name="supportsNestedMetadataFilters">
        /// Default Value: false
        /// </param>
        /// <param name="collectionName"></param>
        /// <param name="token"></param>
        /// <param name="embeddingDimension"></param>
        /// <param name="className">
        /// Default Value: CloudMilvusVectorStore
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CloudMilvusVectorStore(
            string uri,
            bool? supportsNestedMetadataFilters,
            string? collectionName,
            string? token,
            int? embeddingDimension,
            string? className)
        {
            this.SupportsNestedMetadataFilters = supportsNestedMetadataFilters;
            this.Uri = uri ?? throw new global::System.ArgumentNullException(nameof(uri));
            this.CollectionName = collectionName;
            this.Token = token;
            this.EmbeddingDimension = embeddingDimension;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudMilvusVectorStore" /> class.
        /// </summary>
        public CloudMilvusVectorStore()
        {
        }
    }
}