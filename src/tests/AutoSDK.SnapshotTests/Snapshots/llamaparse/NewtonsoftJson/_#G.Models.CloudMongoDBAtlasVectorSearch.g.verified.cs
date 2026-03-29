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
        [global::Newtonsoft.Json.JsonProperty("supports_nested_metadata_filters")]
        public bool? SupportsNestedMetadataFilters { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mongodb_uri")]
        public string? MongodbUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("db_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DbName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collection_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string CollectionName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector_index_name")]
        public string? VectorIndexName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fulltext_index_name")]
        public string? FulltextIndexName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_dimension")]
        public int? EmbeddingDimension { get; set; }

        /// <summary>
        /// Default Value: CloudMongoDBAtlasVectorSearch
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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