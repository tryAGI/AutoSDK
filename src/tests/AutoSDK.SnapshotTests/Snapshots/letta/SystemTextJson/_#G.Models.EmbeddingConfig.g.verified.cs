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
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_endpoint_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EmbeddingConfigEmbeddingEndpointTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EmbeddingConfigEmbeddingEndpointType EmbeddingEndpointType { get; set; }

        /// <summary>
        /// The endpoint for the model (`None` if local).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_endpoint")]
        public string? EmbeddingEndpoint { get; set; }

        /// <summary>
        /// The model for the embedding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EmbeddingModel { get; set; }

        /// <summary>
        /// The dimension of the embedding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_dim")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EmbeddingDim { get; set; }

        /// <summary>
        /// The chunk size of the embedding.<br/>
        /// Default Value: 300
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_chunk_size")]
        public int? EmbeddingChunkSize { get; set; }

        /// <summary>
        /// The handle for this config, in the format provider/model-name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("handle")]
        public string? Handle { get; set; }

        /// <summary>
        /// The maximum batch size for processing embeddings.<br/>
        /// Default Value: 32
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_size")]
        public int? BatchSize { get; set; }

        /// <summary>
        /// The Azure endpoint for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_endpoint")]
        public string? AzureEndpoint { get; set; }

        /// <summary>
        /// The Azure version for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_version")]
        public string? AzureVersion { get; set; }

        /// <summary>
        /// The Azure deployment for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_deployment")]
        public string? AzureDeployment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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