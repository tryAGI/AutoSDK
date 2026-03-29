//HintName: G.Models.CloudAzureAISearchVectorStore.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Cloud Azure AI Search Vector Store.
    /// </summary>
    public sealed partial class CloudAzureAISearchVectorStore
    {
        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("supports_nested_metadata_filters")]
        public bool? SupportsNestedMetadataFilters { get; set; }

        /// <summary>
        /// Included only in requests
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_service_api_key")]
        public string? SearchServiceApiKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_service_endpoint", Required = global::Newtonsoft.Json.Required.Always)]
        public string SearchServiceEndpoint { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("search_service_api_version")]
        public string? SearchServiceApiVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index_name")]
        public string? IndexName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filterable_metadata_field_keys")]
        public object? FilterableMetadataFieldKeys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_dimension")]
        public int? EmbeddingDimension { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_id")]
        public string? ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_secret")]
        public string? ClientSecret { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tenant_id")]
        public string? TenantId { get; set; }

        /// <summary>
        /// Default Value: CloudAzureAISearchVectorStore
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudAzureAISearchVectorStore" /> class.
        /// </summary>
        /// <param name="searchServiceEndpoint"></param>
        /// <param name="supportsNestedMetadataFilters">
        /// Default Value: true
        /// </param>
        /// <param name="searchServiceApiKey">
        /// Included only in requests
        /// </param>
        /// <param name="searchServiceApiVersion"></param>
        /// <param name="indexName"></param>
        /// <param name="filterableMetadataFieldKeys"></param>
        /// <param name="embeddingDimension"></param>
        /// <param name="clientId"></param>
        /// <param name="clientSecret"></param>
        /// <param name="tenantId"></param>
        /// <param name="className">
        /// Default Value: CloudAzureAISearchVectorStore
        /// </param>
        public CloudAzureAISearchVectorStore(
            string searchServiceEndpoint,
            bool? supportsNestedMetadataFilters,
            string? searchServiceApiKey,
            string? searchServiceApiVersion,
            string? indexName,
            object? filterableMetadataFieldKeys,
            int? embeddingDimension,
            string? clientId,
            string? clientSecret,
            string? tenantId,
            string? className)
        {
            this.SupportsNestedMetadataFilters = supportsNestedMetadataFilters;
            this.SearchServiceApiKey = searchServiceApiKey;
            this.SearchServiceEndpoint = searchServiceEndpoint ?? throw new global::System.ArgumentNullException(nameof(searchServiceEndpoint));
            this.SearchServiceApiVersion = searchServiceApiVersion;
            this.IndexName = indexName;
            this.FilterableMetadataFieldKeys = filterableMetadataFieldKeys;
            this.EmbeddingDimension = embeddingDimension;
            this.ClientId = clientId;
            this.ClientSecret = clientSecret;
            this.TenantId = tenantId;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CloudAzureAISearchVectorStore" /> class.
        /// </summary>
        public CloudAzureAISearchVectorStore()
        {
        }
    }
}