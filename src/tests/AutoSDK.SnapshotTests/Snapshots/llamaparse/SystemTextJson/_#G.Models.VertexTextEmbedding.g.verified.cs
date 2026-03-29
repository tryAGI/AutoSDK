//HintName: G.Models.VertexTextEmbedding.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VertexTextEmbedding
    {
        /// <summary>
        /// The modelId of the VertexAI model to use.<br/>
        /// Default Value: textembedding-gecko@003
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        public string? ModelName { get; set; }

        /// <summary>
        /// The batch size for embedding calls.<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embed_batch_size")]
        public int? EmbedBatchSize { get; set; }

        /// <summary>
        /// The number of workers to use for async embedding calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_workers")]
        public int? NumWorkers { get; set; }

        /// <summary>
        /// The default location to use when making API calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Location { get; set; }

        /// <summary>
        /// The default GCP project to use when making Vertex API calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Project { get; set; }

        /// <summary>
        /// The embedding mode to use.<br/>
        /// Default Value: retrieval
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embed_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VertexEmbeddingModeJsonConverter))]
        public global::G.VertexEmbeddingMode? EmbedMode { get; set; }

        /// <summary>
        /// Additional kwargs for the Vertex.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_kwargs")]
        public object? AdditionalKwargs { get; set; }

        /// <summary>
        /// The client email for the VertexAI credentials.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_email")]
        public string? ClientEmail { get; set; }

        /// <summary>
        /// The token URI for the VertexAI credentials.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_uri")]
        public string? TokenUri { get; set; }

        /// <summary>
        /// The private key ID for the VertexAI credentials.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private_key_id")]
        public string? PrivateKeyId { get; set; }

        /// <summary>
        /// The private key for the VertexAI credentials.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private_key")]
        public string? PrivateKey { get; set; }

        /// <summary>
        /// Default Value: VertexTextEmbedding
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VertexTextEmbedding" /> class.
        /// </summary>
        /// <param name="location">
        /// The default location to use when making API calls.
        /// </param>
        /// <param name="project">
        /// The default GCP project to use when making Vertex API calls.
        /// </param>
        /// <param name="modelName">
        /// The modelId of the VertexAI model to use.<br/>
        /// Default Value: textembedding-gecko@003
        /// </param>
        /// <param name="embedBatchSize">
        /// The batch size for embedding calls.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="numWorkers">
        /// The number of workers to use for async embedding calls.
        /// </param>
        /// <param name="embedMode">
        /// The embedding mode to use.<br/>
        /// Default Value: retrieval
        /// </param>
        /// <param name="additionalKwargs">
        /// Additional kwargs for the Vertex.
        /// </param>
        /// <param name="clientEmail">
        /// The client email for the VertexAI credentials.
        /// </param>
        /// <param name="tokenUri">
        /// The token URI for the VertexAI credentials.
        /// </param>
        /// <param name="privateKeyId">
        /// The private key ID for the VertexAI credentials.
        /// </param>
        /// <param name="privateKey">
        /// The private key for the VertexAI credentials.
        /// </param>
        /// <param name="className">
        /// Default Value: VertexTextEmbedding
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VertexTextEmbedding(
            string location,
            string project,
            string? modelName,
            int? embedBatchSize,
            int? numWorkers,
            global::G.VertexEmbeddingMode? embedMode,
            object? additionalKwargs,
            string? clientEmail,
            string? tokenUri,
            string? privateKeyId,
            string? privateKey,
            string? className)
        {
            this.ModelName = modelName;
            this.EmbedBatchSize = embedBatchSize;
            this.NumWorkers = numWorkers;
            this.Location = location ?? throw new global::System.ArgumentNullException(nameof(location));
            this.Project = project ?? throw new global::System.ArgumentNullException(nameof(project));
            this.EmbedMode = embedMode;
            this.AdditionalKwargs = additionalKwargs;
            this.ClientEmail = clientEmail;
            this.TokenUri = tokenUri;
            this.PrivateKeyId = privateKeyId;
            this.PrivateKey = privateKey;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VertexTextEmbedding" /> class.
        /// </summary>
        public VertexTextEmbedding()
        {
        }
    }
}