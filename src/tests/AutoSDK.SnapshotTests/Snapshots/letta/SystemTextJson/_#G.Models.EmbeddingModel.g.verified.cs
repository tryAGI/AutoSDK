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
        [global::System.Text.Json.Serialization.JsonPropertyName("handle")]
        public string? Handle { get; set; }

        /// <summary>
        /// The actual model name used by the provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Display name for the model shown in UI
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// The type of the provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProviderTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ProviderType ProviderType { get; set; }

        /// <summary>
        /// The name of the provider
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProviderName { get; set; }

        /// <summary>
        /// Type of model (llm or embedding)<br/>
        /// Default Value: embedding
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_type")]
        public string? ModelType { get; set; }

        /// <summary>
        /// Deprecated: Use 'provider_type' field instead. The endpoint type for the embedding model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_endpoint_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EmbeddingModelEmbeddingEndpointTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EmbeddingModelEmbeddingEndpointType EmbeddingEndpointType { get; set; }

        /// <summary>
        /// Deprecated: The endpoint for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_endpoint")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? EmbeddingEndpoint { get; set; }

        /// <summary>
        /// Deprecated: Use 'name' field instead. Embedding model name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EmbeddingModel1 { get; set; }

        /// <summary>
        /// The dimension of the embedding
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_dim")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EmbeddingDim { get; set; }

        /// <summary>
        /// Deprecated: The chunk size of the embedding.<br/>
        /// Default Value: 300
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_chunk_size")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? EmbeddingChunkSize { get; set; }

        /// <summary>
        /// Deprecated: The maximum batch size for processing embeddings.<br/>
        /// Default Value: 32
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batch_size")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public int? BatchSize { get; set; }

        /// <summary>
        /// Deprecated: The Azure endpoint for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_endpoint")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? AzureEndpoint { get; set; }

        /// <summary>
        /// Deprecated: The Azure version for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_version")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? AzureVersion { get; set; }

        /// <summary>
        /// Deprecated: The Azure deployment for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_deployment")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? AzureDeployment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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