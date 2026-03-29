//HintName: G.Models.Folder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Representation of a folder, which is a collection of files and passages.
    /// </summary>
    public sealed partial class Folder
    {
        /// <summary>
        /// The name of the folder.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The description of the folder.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Instructions for how to use the folder.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Metadata associated with the folder.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The human-friendly ID of the Source
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The embedding configuration used by the folder.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EmbeddingConfig EmbeddingConfig { get; set; }

        /// <summary>
        /// The id of the user that made this Tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by_id")]
        public string? CreatedById { get; set; }

        /// <summary>
        /// The id of the user that made this Tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_by_id")]
        public string? LastUpdatedById { get; set; }

        /// <summary>
        /// The timestamp when the folder was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The timestamp when the folder was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Folder" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the folder.
        /// </param>
        /// <param name="embeddingConfig">
        /// The embedding configuration used by the folder.
        /// </param>
        /// <param name="description">
        /// The description of the folder.
        /// </param>
        /// <param name="instructions">
        /// Instructions for how to use the folder.
        /// </param>
        /// <param name="metadata">
        /// Metadata associated with the folder.
        /// </param>
        /// <param name="id">
        /// The human-friendly ID of the Source
        /// </param>
        /// <param name="createdById">
        /// The id of the user that made this Tool.
        /// </param>
        /// <param name="lastUpdatedById">
        /// The id of the user that made this Tool.
        /// </param>
        /// <param name="createdAt">
        /// The timestamp when the folder was created.
        /// </param>
        /// <param name="updatedAt">
        /// The timestamp when the folder was last updated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Folder(
            string name,
            global::G.EmbeddingConfig embeddingConfig,
            string? description,
            string? instructions,
            object? metadata,
            string? id,
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
            this.CreatedById = createdById;
            this.LastUpdatedById = lastUpdatedById;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Folder" /> class.
        /// </summary>
        public Folder()
        {
        }
    }
}