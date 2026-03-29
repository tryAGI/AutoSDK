//HintName: G.Models.CloudAstraDBVectorStore.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Cloud AstraDB Vector Store.<br/>
    /// This class is used to store the configuration for an AstraDB vector store, so that it can be<br/>
    /// created and used in LlamaCloud.<br/>
    /// Args:<br/>
    ///     token (str): The Astra DB Application Token to use.<br/>
    ///     api_endpoint (str): The Astra DB JSON API endpoint for your database.<br/>
    ///     collection_name (str): Collection name to use. If not existing, it will be created.<br/>
    ///     embedding_dimension (int): Length of the embedding vectors in use.<br/>
    ///     keyspace (optional[str]): The keyspace to use. If not provided, 'default_keyspace'
    /// </summary>
    public sealed partial class CloudAstraDBVectorStore
    {
        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_nested_metadata_filters")]
        public bool? SupportsNestedMetadataFilters { get; set; }

        /// <summary>
        /// The Astra DB Application Token to use<br/>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// The Astra DB JSON API endpoint for your database
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_endpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiEndpoint { get; set; }

        /// <summary>
        /// Collection name to use. If not existing, it will be created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CollectionName { get; set; }

        /// <summary>
        /// Length of the embedding vectors in use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_dimension")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EmbeddingDimension { get; set; }

        /// <summary>
        /// The keyspace to use. If not provided, 'default_keyspace'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyspace")]
        public string? Keyspace { get; set; }

        /// <summary>
        /// Default Value: CloudAstraDBVectorStore
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudAstraDBVectorStore" /> class.
        /// </summary>
        /// <param name="apiEndpoint">
        /// The Astra DB JSON API endpoint for your database
        /// </param>
        /// <param name="collectionName">
        /// Collection name to use. If not existing, it will be created
        /// </param>
        /// <param name="embeddingDimension">
        /// Length of the embedding vectors in use
        /// </param>
        /// <param name="supportsNestedMetadataFilters">
        /// Default Value: true
        /// </param>
        /// <param name="token">
        /// The Astra DB Application Token to use<br/>
        /// Included only in requests
        /// </param>
        /// <param name="keyspace">
        /// The keyspace to use. If not provided, 'default_keyspace'
        /// </param>
        /// <param name="className">
        /// Default Value: CloudAstraDBVectorStore
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CloudAstraDBVectorStore(
            string apiEndpoint,
            string collectionName,
            int embeddingDimension,
            bool? supportsNestedMetadataFilters,
            string? token,
            string? keyspace,
            string? className)
        {
            this.SupportsNestedMetadataFilters = supportsNestedMetadataFilters;
            this.Token = token;
            this.ApiEndpoint = apiEndpoint ?? throw new global::System.ArgumentNullException(nameof(apiEndpoint));
            this.CollectionName = collectionName ?? throw new global::System.ArgumentNullException(nameof(collectionName));
            this.EmbeddingDimension = embeddingDimension;
            this.Keyspace = keyspace;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudAstraDBVectorStore" /> class.
        /// </summary>
        public CloudAstraDBVectorStore()
        {
        }
    }
}