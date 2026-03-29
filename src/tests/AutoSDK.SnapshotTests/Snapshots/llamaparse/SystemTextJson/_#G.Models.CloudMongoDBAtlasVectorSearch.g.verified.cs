//HintName: G.Models.CloudMongoDBAtlasVectorSearch.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Cloud MongoDB Atlas Vector Store.<br/>
    /// This class is used to store the configuration for a MongoDB Atlas vector store,<br/>
    /// so that it can be created and used in LlamaCloud.<br/>
    /// Args:<br/>
    ///     mongodb_uri (str): URI for connecting to MongoDB Atlas<br/>
    ///     db_name (str): name of the MongoDB database<br/>
    ///     collection_name (str): name of the MongoDB collection<br/>
    ///     vector_index_name (str): name of the MongoDB Atlas vector index<br/>
    ///     fulltext_index_name (str): name of the MongoDB Atlas full-text index
    /// </summary>
    public sealed partial class CloudMongoDBAtlasVectorSearch
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supports_nested_metadata_filters")]
        public bool? SupportsNestedMetadataFilters { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mongodb_uri")]
        public string? MongodbUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("db_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DbName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CollectionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_index_name")]
        public string? VectorIndexName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fulltext_index_name")]
        public string? FulltextIndexName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_dimension")]
        public int? EmbeddingDimension { get; set; }

        /// <summary>
        /// Default Value: CloudMongoDBAtlasVectorSearch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudMongoDBAtlasVectorSearch" /> class.
        /// </summary>
        /// <param name="dbName"></param>
        /// <param name="collectionName"></param>
        /// <param name="supportsNestedMetadataFilters">
        /// Default Value: false
        /// </param>
        /// <param name="mongodbUri">
        /// Included only in requests
        /// </param>
        /// <param name="vectorIndexName"></param>
        /// <param name="fulltextIndexName"></param>
        /// <param name="embeddingDimension"></param>
        /// <param name="className">
        /// Default Value: CloudMongoDBAtlasVectorSearch
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CloudMongoDBAtlasVectorSearch(
            string dbName,
            string collectionName,
            bool? supportsNestedMetadataFilters,
            string? mongodbUri,
            string? vectorIndexName,
            string? fulltextIndexName,
            int? embeddingDimension,
            string? className)
        {
            this.SupportsNestedMetadataFilters = supportsNestedMetadataFilters;
            this.MongodbUri = mongodbUri;
            this.DbName = dbName ?? throw new global::System.ArgumentNullException(nameof(dbName));
            this.CollectionName = collectionName ?? throw new global::System.ArgumentNullException(nameof(collectionName));
            this.VectorIndexName = vectorIndexName;
            this.FulltextIndexName = fulltextIndexName;
            this.EmbeddingDimension = embeddingDimension;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudMongoDBAtlasVectorSearch" /> class.
        /// </summary>
        public CloudMongoDBAtlasVectorSearch()
        {
        }
    }
}