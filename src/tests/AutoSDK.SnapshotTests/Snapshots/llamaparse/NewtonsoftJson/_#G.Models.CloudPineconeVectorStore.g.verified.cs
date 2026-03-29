//HintName: G.Models.CloudPineconeVectorStore.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Cloud Pinecone Vector Store.<br/>
    /// This class is used to store the configuration for a Pinecone vector store, so that it can be<br/>
    /// created and used in LlamaCloud.<br/>
    /// Args:<br/>
    ///     api_key (str): API key for authenticating with Pinecone<br/>
    ///     index_name (str): name of the Pinecone index<br/>
    ///     namespace (optional[str]): namespace to use in the Pinecone index<br/>
    ///     insert_kwargs (optional[dict]): additional kwargs to pass during insertion
    /// </summary>
    public sealed partial class CloudPineconeVectorStore
    {
        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supports_nested_metadata_filters")]
        public bool? SupportsNestedMetadataFilters { get; set; }

        /// <summary>
        /// The API key for authenticating with Pinecone<br/>
        /// Included only in requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string IndexName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("namespace")]
        public string? Namespace { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("insert_kwargs")]
        public object? InsertKwargs { get; set; }

        /// <summary>
        /// Default Value: CloudPineconeVectorStore
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudPineconeVectorStore" /> class.
        /// </summary>
        /// <param name="indexName"></param>
        /// <param name="supportsNestedMetadataFilters">
        /// Default Value: true
        /// </param>
        /// <param name="apiKey">
        /// The API key for authenticating with Pinecone<br/>
        /// Included only in requests
        /// </param>
        /// <param name="namespace"></param>
        /// <param name="insertKwargs"></param>
        /// <param name="className">
        /// Default Value: CloudPineconeVectorStore
        /// </param>
        public CloudPineconeVectorStore(
            string indexName,
            bool? supportsNestedMetadataFilters,
            string? apiKey,
            string? @namespace,
            object? insertKwargs,
            string? className)
        {
            this.SupportsNestedMetadataFilters = supportsNestedMetadataFilters;
            this.ApiKey = apiKey;
            this.IndexName = indexName ?? throw new global::System.ArgumentNullException(nameof(indexName));
            this.Namespace = @namespace;
            this.InsertKwargs = insertKwargs;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudPineconeVectorStore" /> class.
        /// </summary>
        public CloudPineconeVectorStore()
        {
        }
    }
}