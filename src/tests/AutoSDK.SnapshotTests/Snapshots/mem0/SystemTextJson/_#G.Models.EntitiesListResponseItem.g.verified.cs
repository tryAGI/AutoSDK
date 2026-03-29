//HintName: G.Models.EntitiesListResponseItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EntitiesListResponseItem
    {
        /// <summary>
        /// Unique identifier for the entity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the entity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Timestamp of when the entity was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Timestamp of when the entity was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Total number of memories associated with the entity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_memories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalMemories { get; set; }

        /// <summary>
        /// Owner of the entity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Owner { get; set; }

        /// <summary>
        /// Organization the entity belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Organization { get; set; }

        /// <summary>
        /// Additional metadata associated with the entity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EntitiesListResponseItemTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EntitiesListResponseItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EntitiesListResponseItem" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the entity.
        /// </param>
        /// <param name="name">
        /// Name of the entity.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp of when the entity was created.
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp of when the entity was last updated.
        /// </param>
        /// <param name="totalMemories">
        /// Total number of memories associated with the entity.
        /// </param>
        /// <param name="owner">
        /// Owner of the entity.
        /// </param>
        /// <param name="organization">
        /// Organization the entity belongs to.
        /// </param>
        /// <param name="type"></param>
        /// <param name="metadata">
        /// Additional metadata associated with the entity
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EntitiesListResponseItem(
            string id,
            string name,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            int totalMemories,
            string owner,
            string organization,
            global::G.EntitiesListResponseItemType type,
            object? metadata)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.TotalMemories = totalMemories;
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.Organization = organization ?? throw new global::System.ArgumentNullException(nameof(organization));
            this.Metadata = metadata;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntitiesListResponseItem" /> class.
        /// </summary>
        public EntitiesListResponseItem()
        {
        }
    }
}