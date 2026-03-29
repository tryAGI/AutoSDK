//HintName: G.Models.EmbeddingConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for embedding model connection and processing parameters.
    /// </summary>
    public sealed partial class EmbeddingConfig
    {
        /// <summary>
        /// The endpoint type for the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_endpoint_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EmbeddingConfigEmbeddingEndpointType EmbeddingEndpointType { get; set; } = default!;

        /// <summary>
        /// The endpoint for the model (`None` if local).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_endpoint")]
        public string? EmbeddingEndpoint { get; set; }

        /// <summary>
        /// The model for the embedding.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_model", Required = global::Newtonsoft.Json.Required.Always)]
        public string EmbeddingModel { get; set; } = default!;

        /// <summary>
        /// The dimension of the embedding.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_dim", Required = global::Newtonsoft.Json.Required.Always)]
        public int EmbeddingDim { get; set; } = default!;

        /// <summary>
        /// The chunk size of the embedding.<br/>
        /// Default Value: 300
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_chunk_size")]
        public int? EmbeddingChunkSize { get; set; }

        /// <summary>
        /// The handle for this config, in the format provider/model-name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("handle")]
        public string? Handle { get; set; }

        /// <summary>
        /// The maximum batch size for processing embeddings.<br/>
        /// Default Value: 32
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_size")]
        public int? BatchSize { get; set; }

        /// <summary>
        /// The Azure endpoint for the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("azure_endpoint")]
        public string? AzureEndpoint { get; set; }

        /// <summary>
        /// The Azure version for the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("azure_version")]
        public string? AzureVersion { get; set; }

        /// <summary>
        /// The Azure deployment for the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("azure_deployment")]
        public string? AzureDeployment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingConfig" /> class.
        /// </summary>
        /// <param name="embeddingEndpointType">
        /// The endpoint type for the model.
        /// </param>
        /// <param name="embeddingModel">
        /// The model for the embedding.
        /// </param>
        /// <param name="embeddingDim">
        /// The dimension of the embedding.
        /// </param>
        /// <param name="embeddingEndpoint">
        /// The endpoint for the model (`None` if local).
        /// </param>
        /// <param name="embeddingChunkSize">
        /// The chunk size of the embedding.<br/>
        /// Default Value: 300
        /// </param>
        /// <param name="handle">
        /// The handle for this config, in the format provider/model-name.
        /// </param>
        /// <param name="batchSize">
        /// The maximum batch size for processing embeddings.<br/>
        /// Default Value: 32
        /// </param>
        /// <param name="azureEndpoint">
        /// The Azure endpoint for the model.
        /// </param>
        /// <param name="azureVersion">
        /// The Azure version for the model.
        /// </param>
        /// <param name="azureDeployment">
        /// The Azure deployment for the model.
        /// </param>
        public EmbeddingConfig(
            global::G.EmbeddingConfigEmbeddingEndpointType embeddingEndpointType,
            string embeddingModel,
            int embeddingDim,
            string? embeddingEndpoint,
            int? embeddingChunkSize,
            string? handle,
            int? batchSize,
            string? azureEndpoint,
            string? azureVersion,
            string? azureDeployment)
        {
            this.EmbeddingEndpointType = embeddingEndpointType;
            this.EmbeddingEndpoint = embeddingEndpoint;
            this.EmbeddingModel = embeddingModel ?? throw new global::System.ArgumentNullException(nameof(embeddingModel));
            this.EmbeddingDim = embeddingDim;
            this.EmbeddingChunkSize = embeddingChunkSize;
            this.Handle = handle;
            this.BatchSize = batchSize;
            this.AzureEndpoint = azureEndpoint;
            this.AzureVersion = azureVersion;
            this.AzureDeployment = azureDeployment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingConfig" /> class.
        /// </summary>
        public EmbeddingConfig()
        {
        }
    }
}