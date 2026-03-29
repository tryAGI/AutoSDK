//HintName: G.Models.ManagedOpenAIEmbedding.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ManagedOpenAIEmbedding
    {
        /// <summary>
        /// The name of the OpenAI embedding model.<br/>
        /// Default Value: openai-text-embedding-3-small
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
        /// Default Value: ManagedOpenAIEmbedding
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedOpenAIEmbedding" /> class.
        /// </summary>
        /// <param name="modelName">
        /// The name of the OpenAI embedding model.<br/>
        /// Default Value: openai-text-embedding-3-small
        /// </param>
        /// <param name="embedBatchSize">
        /// The batch size for embedding calls.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="numWorkers">
        /// The number of workers to use for async embedding calls.
        /// </param>
        /// <param name="className">
        /// Default Value: ManagedOpenAIEmbedding
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManagedOpenAIEmbedding(
            string? modelName,
            int? embedBatchSize,
            int? numWorkers,
            string? className)
        {
            this.ModelName = modelName;
            this.EmbedBatchSize = embedBatchSize;
            this.NumWorkers = numWorkers;
            this.ClassName = className;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedOpenAIEmbedding" /> class.
        /// </summary>
        public ManagedOpenAIEmbedding()
        {
        }
    }
}