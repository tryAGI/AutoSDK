//HintName: G.Models.SourceSchema.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Source with human-readable ID for agent file
    /// </summary>
    public sealed partial class SourceSchema
    {
        /// <summary>
        /// The name of the source.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The description of the source.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Instructions for how to use the source.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Metadata associated with the source.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The handle for the embedding config used by the source.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding")]
        public string? Embedding { get; set; }

        /// <summary>
        /// The chunk size of the embedding.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_chunk_size")]
        public int? EmbeddingChunkSize { get; set; }

        /// <summary>
        /// (Legacy) The embedding configuration used by the source.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_config")]
        public global::G.EmbeddingConfig? EmbeddingConfig { get; set; }

        /// <summary>
        /// Human-readable identifier for this source in the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceSchema" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the source.
        /// </param>
        /// <param name="id">
        /// Human-readable identifier for this source in the file
        /// </param>
        /// <param name="description">
        /// The description of the source.
        /// </param>
        /// <param name="instructions">
        /// Instructions for how to use the source.
        /// </param>
        /// <param name="metadata">
        /// Metadata associated with the source.
        /// </param>
        /// <param name="embedding">
        /// The handle for the embedding config used by the source.
        /// </param>
        /// <param name="embeddingChunkSize">
        /// The chunk size of the embedding.
        /// </param>
        /// <param name="embeddingConfig">
        /// (Legacy) The embedding configuration used by the source.
        /// </param>
        public SourceSchema(
            string name,
            string id,
            string? description,
            string? instructions,
            object? metadata,
            string? embedding,
            int? embeddingChunkSize,
            global::G.EmbeddingConfig? embeddingConfig)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Instructions = instructions;
            this.Metadata = metadata;
            this.Embedding = embedding;
            this.EmbeddingChunkSize = embeddingChunkSize;
            this.EmbeddingConfig = embeddingConfig;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceSchema" /> class.
        /// </summary>
        public SourceSchema()
        {
        }
    }
}