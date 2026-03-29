//HintName: G.Models.Archive.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Representation of an archive - a collection of archival passages that can be shared between agents.
    /// </summary>
    public sealed partial class Archive
    {
        /// <summary>
        /// The id of the user that made this object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by_id")]
        public string? CreatedById { get; set; }

        /// <summary>
        /// The id of the user that made this object.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_by_id")]
        public string? LastUpdatedById { get; set; }

        /// <summary>
        /// The creation date of the archive
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// The timestamp when the object was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The name of the archive
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// A description of the archive
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The vector database provider used for this archive's passages<br/>
        /// Default Value: native
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("vector_db_provider")]
        public global::G.VectorDBProvider? VectorDbProvider { get; set; }

        /// <summary>
        /// Embedding configuration for passages in this archive
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("embedding_config")]
        public global::G.EmbeddingConfig? EmbeddingConfig { get; set; }

        /// <summary>
        /// Additional metadata
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The human-friendly ID of the Archive
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Archive" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The creation date of the archive
        /// </param>
        /// <param name="name">
        /// The name of the archive
        /// </param>
        /// <param name="createdById">
        /// The id of the user that made this object.
        /// </param>
        /// <param name="lastUpdatedById">
        /// The id of the user that made this object.
        /// </param>
        /// <param name="updatedAt">
        /// The timestamp when the object was last updated.
        /// </param>
        /// <param name="description">
        /// A description of the archive
        /// </param>
        /// <param name="vectorDbProvider">
        /// The vector database provider used for this archive's passages<br/>
        /// Default Value: native
        /// </param>
        /// <param name="embeddingConfig">
        /// Embedding configuration for passages in this archive
        /// </param>
        /// <param name="metadata">
        /// Additional metadata
        /// </param>
        /// <param name="id">
        /// The human-friendly ID of the Archive
        /// </param>
        public Archive(
            global::System.DateTime createdAt,
            string name,
            string? createdById,
            string? lastUpdatedById,
            global::System.DateTime? updatedAt,
            string? description,
            global::G.VectorDBProvider? vectorDbProvider,
            global::G.EmbeddingConfig? embeddingConfig,
            object? metadata,
            string? id)
        {
            this.CreatedById = createdById;
            this.LastUpdatedById = lastUpdatedById;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.VectorDbProvider = vectorDbProvider;
            this.EmbeddingConfig = embeddingConfig;
            this.Metadata = metadata;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Archive" /> class.
        /// </summary>
        public Archive()
        {
        }
    }
}