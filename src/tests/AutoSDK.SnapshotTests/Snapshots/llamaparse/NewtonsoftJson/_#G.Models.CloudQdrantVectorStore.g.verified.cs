//HintName: G.Models.CloudQdrantVectorStore.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Cloud Qdrant Vector Store.<br/>
    /// This class is used to store the configuration for a Qdrant vector store, so that it can be<br/>
    /// created and used in LlamaCloud.<br/>
    /// Args:<br/>
    ///     collection_name (str): name of the Qdrant collection<br/>
    ///     url (str): url of the Qdrant instance<br/>
    ///     api_key (str): API key for authenticating with Qdrant<br/>
    ///     max_retries (int): maximum number of retries in case of a failure. Defaults to 3<br/>
    ///     client_kwargs (dict): additional kwargs to pass to the Qdrant client
    /// </summary>
    public sealed partial class CloudQdrantVectorStore
    {
        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supports_nested_metadata_filters")]
        public bool? SupportsNestedMetadataFilters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collection_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string CollectionName { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// Default Value: 3
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_retries")]
        public int? MaxRetries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_kwargs")]
        public object? ClientKwargs { get; set; }

        /// <summary>
        /// Default Value: CloudQdrantVectorStore
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudQdrantVectorStore" /> class.
        /// </summary>
        /// <param name="collectionName"></param>
        /// <param name="url"></param>
        /// <param name="supportsNestedMetadataFilters">
        /// Default Value: true
        /// </param>
        /// <param name="apiKey">
        /// Included only in requests
        /// </param>
        /// <param name="maxRetries">
        /// Default Value: 3
        /// </param>
        /// <param name="clientKwargs"></param>
        /// <param name="className">
        /// Default Value: CloudQdrantVectorStore
        /// </param>
        public CloudQdrantVectorStore(
            string collectionName,
            string url,
            bool? supportsNestedMetadataFilters,
            string? apiKey,
            int? maxRetries,
            object? clientKwargs,
            string? className)
        {
            this.SupportsNestedMetadataFilters = supportsNestedMetadataFilters;
            this.CollectionName = collectionName ?? throw new global::System.ArgumentNullException(nameof(collectionName));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ApiKey = apiKey;
            this.MaxRetries = maxRetries;
            this.ClientKwargs = clientKwargs;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudQdrantVectorStore" /> class.
        /// </summary>
        public CloudQdrantVectorStore()
        {
        }
    }
}