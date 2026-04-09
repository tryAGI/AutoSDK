//HintName: G.Models.Source2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// (Deprecated: Use Folder) Representation of a source, which is a collection of files and passages.
    /// </summary>
    public sealed partial class Source2
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
        /// The human-friendly ID of the Source
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The embedding configuration used by the source.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EmbeddingConfig EmbeddingConfig { get; set; } = default!;

        /// <summary>
        /// The vector database provider used for this source's passages<br/>
        /// Default Value: native
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector_db_provider")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.VectorDBProviderJsonConverter))]
        public global::G.VectorDBProvider? VectorDbProvider { get; set; }

        /// <summary>
        /// The id of the user that made this Tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by_id")]
        public string? CreatedById { get; set; }

        /// <summary>
        /// The id of the user that made this Tool.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_by_id")]
        public string? LastUpdatedById { get; set; }

        /// <summary>
        /// The timestamp when the source was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The timestamp when the source was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Source2" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the source.
        /// </param>
        /// <param name="embeddingConfig">
        /// The embedding configuration used by the source.
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
        /// <param name="id">
        /// The human-friendly ID of the Source
        /// </param>
        /// <param name="vectorDbProvider">
        /// The vector database provider used for this source's passages<br/>
        /// Default Value: native
        /// </param>
        /// <param name="createdById">
        /// The id of the user that made this Tool.
        /// </param>
        /// <param name="lastUpdatedById">
        /// The id of the user that made this Tool.
        /// </param>
        /// <param name="createdAt">
        /// The timestamp when the source was created.
        /// </param>
        /// <param name="updatedAt">
        /// The timestamp when the source was last updated.
        /// </param>
        public Source2(
            string name,
            global::G.EmbeddingConfig embeddingConfig,
            string? description,
            string? instructions,
            object? metadata,
            string? id,
            global::G.VectorDBProvider? vectorDbProvider,
            string? createdById,
            string? lastUpdatedById,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Instructions = instructions;
            this.Metadata = metadata;
            this.Id = id;
            this.EmbeddingConfig = embeddingConfig ?? throw new global::System.ArgumentNullException(nameof(embeddingConfig));
            this.VectorDbProvider = vectorDbProvider;
            this.CreatedById = createdById;
            this.LastUpdatedById = lastUpdatedById;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Source2" /> class.
        /// </summary>
        public Source2()
        {
        }
    }
}