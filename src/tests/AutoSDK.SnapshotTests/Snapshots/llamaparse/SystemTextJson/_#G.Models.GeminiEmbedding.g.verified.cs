//HintName: G.Models.GeminiEmbedding.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GeminiEmbedding
    {
        /// <summary>
        /// The modelId of the Gemini model to use.<br/>
        /// Default Value: models/embedding-001
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
        /// Title is only applicable for retrieval_document tasks, and is used to represent a document title. For other tasks, title is invalid.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// The task for embedding model.<br/>
        /// Default Value: retrieval_document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_type")]
        public string? TaskType { get; set; }

        /// <summary>
        /// API key to access the model. Defaults to None.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// API base to access the model. Defaults to None.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_base")]
        public string? ApiBase { get; set; }

        /// <summary>
        /// Transport to access the model. Defaults to None.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        public string? Transport { get; set; }

        /// <summary>
        /// Optional reduced dimension for output embeddings. Supported by models/text-embedding-004 and newer (e.g. gemini-embedding-001). Not supported by models/embedding-001.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_dimensionality")]
        public int? OutputDimensionality { get; set; }

        /// <summary>
        /// Default Value: GeminiEmbedding
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeminiEmbedding" /> class.
        /// </summary>
        /// <param name="modelName">
        /// The modelId of the Gemini model to use.<br/>
        /// Default Value: models/embedding-001
        /// </param>
        /// <param name="embedBatchSize">
        /// The batch size for embedding calls.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="numWorkers">
        /// The number of workers to use for async embedding calls.
        /// </param>
        /// <param name="title">
        /// Title is only applicable for retrieval_document tasks, and is used to represent a document title. For other tasks, title is invalid.
        /// </param>
        /// <param name="taskType">
        /// The task for embedding model.<br/>
        /// Default Value: retrieval_document
        /// </param>
        /// <param name="apiKey">
        /// API key to access the model. Defaults to None.
        /// </param>
        /// <param name="apiBase">
        /// API base to access the model. Defaults to None.
        /// </param>
        /// <param name="transport">
        /// Transport to access the model. Defaults to None.
        /// </param>
        /// <param name="outputDimensionality">
        /// Optional reduced dimension for output embeddings. Supported by models/text-embedding-004 and newer (e.g. gemini-embedding-001). Not supported by models/embedding-001.
        /// </param>
        /// <param name="className">
        /// Default Value: GeminiEmbedding
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GeminiEmbedding(
            string? modelName,
            int? embedBatchSize,
            int? numWorkers,
            string? title,
            string? taskType,
            string? apiKey,
            string? apiBase,
            string? transport,
            int? outputDimensionality,
            string? className)
        {
            this.ModelName = modelName;
            this.EmbedBatchSize = embedBatchSize;
            this.NumWorkers = numWorkers;
            this.Title = title;
            this.TaskType = taskType;
            this.ApiKey = apiKey;
            this.ApiBase = apiBase;
            this.Transport = transport;
            this.OutputDimensionality = outputDimensionality;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeminiEmbedding" /> class.
        /// </summary>
        public GeminiEmbedding()
        {
        }
    }
}