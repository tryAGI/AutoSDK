//HintName: G.Models.EmbeddingModel.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingModel
    {
        /// <summary>
        /// The handle for this config, in the format provider/model-name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("handle")]
        public string? Handle { get; set; }

        /// <summary>
        /// The actual model name used by the provider
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Display name for the model shown in UI
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("display_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DisplayName { get; set; } = default!;

        /// <summary>
        /// The type of the provider
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ProviderTypeJsonConverter))]
        public global::G.ProviderType ProviderType { get; set; } = default!;

        /// <summary>
        /// The name of the provider
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProviderName { get; set; } = default!;

        /// <summary>
        /// Type of model (llm or embedding)<br/>
        /// Default Value: embedding
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model_type")]
        public string? ModelType { get; set; }

        /// <summary>
        /// Deprecated: Use 'provider_type' field instead. The endpoint type for the embedding model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_endpoint_type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.EmbeddingModelEmbeddingEndpointTypeJsonConverter))]
        public global::G.EmbeddingModelEmbeddingEndpointType EmbeddingEndpointType { get; set; } = default!;

        /// <summary>
        /// Deprecated: The endpoint for the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_endpoint")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? EmbeddingEndpoint { get; set; }

        /// <summary>
        /// Deprecated: Use 'name' field instead. Embedding model name.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_model", Required = global::Newtonsoft.Json.Required.Always)]
        public string EmbeddingModel1 { get; set; } = default!;

        /// <summary>
        /// The dimension of the embedding
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_dim", Required = global::Newtonsoft.Json.Required.Always)]
        public int EmbeddingDim { get; set; } = default!;

        /// <summary>
        /// Deprecated: The chunk size of the embedding.<br/>
        /// Default Value: 300
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_chunk_size")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? EmbeddingChunkSize { get; set; }

        /// <summary>
        /// Deprecated: The maximum batch size for processing embeddings.<br/>
        /// Default Value: 32
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("batch_size")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? BatchSize { get; set; }

        /// <summary>
        /// Deprecated: The Azure endpoint for the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("azure_endpoint")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? AzureEndpoint { get; set; }

        /// <summary>
        /// Deprecated: The Azure version for the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("azure_version")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? AzureVersion { get; set; }

        /// <summary>
        /// Deprecated: The Azure deployment for the model.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("azure_deployment")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? AzureDeployment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingModel" /> class.
        /// </summary>
        /// <param name="name">
        /// The actual model name used by the provider
        /// </param>
        /// <param name="displayName">
        /// Display name for the model shown in UI
        /// </param>
        /// <param name="providerType">
        /// The type of the provider
        /// </param>
        /// <param name="providerName">
        /// The name of the provider
        /// </param>
        /// <param name="embeddingEndpointType">
        /// Deprecated: Use 'provider_type' field instead. The endpoint type for the embedding model.
        /// </param>
        /// <param name="embeddingModel1">
        /// Deprecated: Use 'name' field instead. Embedding model name.
        /// </param>
        /// <param name="embeddingDim">
        /// The dimension of the embedding
        /// </param>
        /// <param name="handle">
        /// The handle for this config, in the format provider/model-name.
        /// </param>
        /// <param name="modelType">
        /// Type of model (llm or embedding)<br/>
        /// Default Value: embedding
        /// </param>
        public EmbeddingModel(
            string name,
            string displayName,
            global::G.ProviderType providerType,
            string providerName,
            global::G.EmbeddingModelEmbeddingEndpointType embeddingEndpointType,
            string embeddingModel1,
            int embeddingDim,
            string? handle,
            string? modelType)
        {
            this.Handle = handle;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.ProviderType = providerType;
            this.ProviderName = providerName ?? throw new global::System.ArgumentNullException(nameof(providerName));
            this.ModelType = modelType;
            this.EmbeddingEndpointType = embeddingEndpointType;
            this.EmbeddingModel1 = embeddingModel1 ?? throw new global::System.ArgumentNullException(nameof(embeddingModel1));
            this.EmbeddingDim = embeddingDim;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingModel" /> class.
        /// </summary>
        public EmbeddingModel()
        {
        }
    }
}