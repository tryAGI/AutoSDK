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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Name of the entity.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Timestamp of when the entity was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Timestamp of when the entity was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Total number of memories associated with the entity.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_memories", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalMemories { get; set; } = default!;

        /// <summary>
        /// Owner of the entity.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("owner", Required = global::Newtonsoft.Json.Required.Always)]
        public string Owner { get; set; } = default!;

        /// <summary>
        /// Organization the entity belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("organization", Required = global::Newtonsoft.Json.Required.Always)]
        public string Organization { get; set; } = default!;

        /// <summary>
        /// Additional metadata associated with the entity
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EntitiesListResponseItemType Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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