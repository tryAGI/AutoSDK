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
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by_id")]
        public string? CreatedById { get; set; }

        /// <summary>
        /// The id of the user that made this object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_by_id")]
        public string? LastUpdatedById { get; set; }

        /// <summary>
        /// The creation date of the archive
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// The timestamp when the object was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// The name of the archive
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of the archive
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The vector database provider used for this archive's passages<br/>
        /// Default Value: native
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_db_provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.VectorDBProviderJsonConverter))]
        public global::G.VectorDBProvider? VectorDbProvider { get; set; }

        /// <summary>
        /// Embedding configuration for passages in this archive
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_config")]
        public global::G.EmbeddingConfig? EmbeddingConfig { get; set; }

        /// <summary>
        /// Additional metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The human-friendly ID of the Archive
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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