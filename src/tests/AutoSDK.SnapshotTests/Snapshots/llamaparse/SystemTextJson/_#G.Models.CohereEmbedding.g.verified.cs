//HintName: G.Models.CohereEmbedding.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CohereEmbedding
    {
        /// <summary>
        /// The modelId of the Cohere model to use.<br/>
        /// Default Value: embed-english-v3.0
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
        /// The Cohere API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// Truncation type - START/ END/ NONE<br/>
        /// Default Value: END
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncate")]
        public string? Truncate { get; set; }

        /// <summary>
        /// Model Input type. If not provided, search_document and search_query are used when needed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_type")]
        public string? InputType { get; set; }

        /// <summary>
        /// Embedding type. If not provided float embedding_type is used when needed.<br/>
        /// Default Value: float
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_type")]
        public string? EmbeddingType { get; set; }

        /// <summary>
        /// Default Value: CohereEmbedding
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CohereEmbedding" /> class.
        /// </summary>
        /// <param name="modelName">
        /// The modelId of the Cohere model to use.<br/>
        /// Default Value: embed-english-v3.0
        /// </param>
        /// <param name="embedBatchSize">
        /// The batch size for embedding calls.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="numWorkers">
        /// The number of workers to use for async embedding calls.
        /// </param>
        /// <param name="apiKey">
        /// The Cohere API key.
        /// </param>
        /// <param name="truncate">
        /// Truncation type - START/ END/ NONE<br/>
        /// Default Value: END
        /// </param>
        /// <param name="inputType">
        /// Model Input type. If not provided, search_document and search_query are used when needed.
        /// </param>
        /// <param name="embeddingType">
        /// Embedding type. If not provided float embedding_type is used when needed.<br/>
        /// Default Value: float
        /// </param>
        /// <param name="className">
        /// Default Value: CohereEmbedding
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CohereEmbedding(
            string? modelName,
            int? embedBatchSize,
            int? numWorkers,
            string? apiKey,
            string? truncate,
            string? inputType,
            string? embeddingType,
            string? className)
        {
            this.ModelName = modelName;
            this.EmbedBatchSize = embedBatchSize;
            this.NumWorkers = numWorkers;
            this.ApiKey = apiKey;
            this.Truncate = truncate;
            this.InputType = inputType;
            this.EmbeddingType = embeddingType;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CohereEmbedding" /> class.
        /// </summary>
        public CohereEmbedding()
        {
        }
    }
}