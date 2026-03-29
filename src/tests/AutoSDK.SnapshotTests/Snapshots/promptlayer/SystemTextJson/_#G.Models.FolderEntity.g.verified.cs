//HintName: G.Models.FolderEntity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FolderEntity
    {
        /// <summary>
        /// Unique identifier for the entity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Name of the entity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The type of entity. SNIPPET is a pseudo-entity type representing completion-type prompts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EntityTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EntityType Type { get; set; }

        /// <summary>
        /// Timestamp when the entity was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the entity was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// ID of the folder containing this entity. Null for root-level entities.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        public int? FolderId { get; set; }

        /// <summary>
        /// Array of folder names representing the entity's location in the folder hierarchy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Path { get; set; }

        /// <summary>
        /// Type-specific metadata. Included only when include_metadata=true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OneOfJsonConverter<global::G.PromptEntityMetadata, global::G.WorkflowEntityMetadata, global::G.DatasetEntityMetadata, object>))]
        public global::G.OneOf<global::G.PromptEntityMetadata, global::G.WorkflowEntityMetadata, global::G.DatasetEntityMetadata, object>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderEntity" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the entity
        /// </param>
        /// <param name="name">
        /// Name of the entity
        /// </param>
        /// <param name="type">
        /// The type of entity. SNIPPET is a pseudo-entity type representing completion-type prompts.
        /// </param>
        /// <param name="path">
        /// Array of folder names representing the entity's location in the folder hierarchy.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the entity was created
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the entity was last updated
        /// </param>
        /// <param name="folderId">
        /// ID of the folder containing this entity. Null for root-level entities.
        /// </param>
        /// <param name="metadata">
        /// Type-specific metadata. Included only when include_metadata=true.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FolderEntity(
            int id,
            string name,
            global::G.EntityType type,
            global::System.Collections.Generic.IList<string> path,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            int? folderId,
            global::G.OneOf<global::G.PromptEntityMetadata, global::G.WorkflowEntityMetadata, global::G.DatasetEntityMetadata, object>? metadata)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.FolderId = folderId;
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderEntity" /> class.
        /// </summary>
        public FolderEntity()
        {
        }
    }
}