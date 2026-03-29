//HintName: G.Models.AzureOpenAIEmbedding.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AzureOpenAIEmbedding
    {
        /// <summary>
        /// The name of the OpenAI embedding model.<br/>
        /// Default Value: text-embedding-ada-002
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_name")]
        public string? ModelName { get; set; }

        /// <summary>
        /// The batch size for embedding calls.<br/>
        /// Default Value: 10
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embed_batch_size")]
        public int? EmbedBatchSize { get; set; }

        /// <summary>
        /// The number of workers to use for async embedding calls.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_workers")]
        public int? NumWorkers { get; set; }

        /// <summary>
        /// Additional kwargs for the OpenAI API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("additional_kwargs")]
        public object? AdditionalKwargs { get; set; }

        /// <summary>
        /// The OpenAI API key.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// The base URL for Azure deployment.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_base")]
        public string? ApiBase { get; set; }

        /// <summary>
        /// The version for Azure OpenAI API.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_version")]
        public string? ApiVersion { get; set; }

        /// <summary>
        /// Maximum number of retries.<br/>
        /// Default Value: 10
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_retries")]
        public int? MaxRetries { get; set; }

        /// <summary>
        /// Timeout for each request.<br/>
        /// Default Value: 60F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timeout")]
        public double? Timeout { get; set; }

        /// <summary>
        /// The default headers for API requests.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? DefaultHeaders { get; set; }

        /// <summary>
        /// Reuse the OpenAI client between requests. When doing anything with large volumes of async API calls, setting this to false can improve stability.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reuse_client")]
        public bool? ReuseClient { get; set; }

        /// <summary>
        /// The number of dimensions on the output embedding vectors. Works only with v3 embedding models.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dimensions")]
        public int? Dimensions { get; set; }

        /// <summary>
        /// The Azure endpoint to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("azure_endpoint")]
        public string? AzureEndpoint { get; set; }

        /// <summary>
        /// The Azure deployment to use.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("azure_deployment")]
        public string? AzureDeployment { get; set; }

        /// <summary>
        /// Default Value: AzureOpenAIEmbedding
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureOpenAIEmbedding" /> class.
        /// </summary>
        /// <param name="modelName">
        /// The name of the OpenAI embedding model.<br/>
        /// Default Value: text-embedding-ada-002
        /// </param>
        /// <param name="embedBatchSize">
        /// The batch size for embedding calls.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="numWorkers">
        /// The number of workers to use for async embedding calls.
        /// </param>
        /// <param name="additionalKwargs">
        /// Additional kwargs for the OpenAI API.
        /// </param>
        /// <param name="apiKey">
        /// The OpenAI API key.
        /// </param>
        /// <param name="apiBase">
        /// The base URL for Azure deployment.
        /// </param>
        /// <param name="apiVersion">
        /// The version for Azure OpenAI API.
        /// </param>
        /// <param name="maxRetries">
        /// Maximum number of retries.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="timeout">
        /// Timeout for each request.<br/>
        /// Default Value: 60F
        /// </param>
        /// <param name="defaultHeaders">
        /// The default headers for API requests.
        /// </param>
        /// <param name="reuseClient">
        /// Reuse the OpenAI client between requests. When doing anything with large volumes of async API calls, setting this to false can improve stability.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="dimensions">
        /// The number of dimensions on the output embedding vectors. Works only with v3 embedding models.
        /// </param>
        /// <param name="azureEndpoint">
        /// The Azure endpoint to use.
        /// </param>
        /// <param name="azureDeployment">
        /// The Azure deployment to use.
        /// </param>
        /// <param name="className">
        /// Default Value: AzureOpenAIEmbedding
        /// </param>
        public AzureOpenAIEmbedding(
            string? modelName,
            int? embedBatchSize,
            int? numWorkers,
            object? additionalKwargs,
            string? apiKey,
            string? apiBase,
            string? apiVersion,
            int? maxRetries,
            double? timeout,
            global::System.Collections.Generic.Dictionary<string, string>? defaultHeaders,
            bool? reuseClient,
            int? dimensions,
            string? azureEndpoint,
            string? azureDeployment,
            string? className)
        {
            this.ModelName = modelName;
            this.EmbedBatchSize = embedBatchSize;
            this.NumWorkers = numWorkers;
            this.AdditionalKwargs = additionalKwargs;
            this.ApiKey = apiKey;
            this.ApiBase = apiBase;
            this.ApiVersion = apiVersion;
            this.MaxRetries = maxRetries;
            this.Timeout = timeout;
            this.DefaultHeaders = defaultHeaders;
            this.ReuseClient = reuseClient;
            this.Dimensions = dimensions;
            this.AzureEndpoint = azureEndpoint;
            this.AzureDeployment = azureDeployment;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AzureOpenAIEmbedding" /> class.
        /// </summary>
        public AzureOpenAIEmbedding()
        {
        }
    }
}