//HintName: G.Models.Entity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object that represents an entity with associated assets.
    /// </summary>
    public sealed partial class Entity
    {
        /// <summary>
        /// The unique identifier of the entity.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the entity.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A description of the entity.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Custom metadata for the entity.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.EntityMetadata? Metadata { get; set; }

        /// <summary>
        /// An array of asset IDs associated with the entity.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("asset_ids")]
        public global::System.Collections.Generic.IList<string>? AssetIds { get; set; }

        /// <summary>
        /// The current status of the entity creation process.<br/>
        /// **Values**:<br/>
        /// - `processing`: The entity is being processed and is not yet ready for use in searches.<br/>
        /// - `ready`: The entity is fully processed and can be used in search queries.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.EntityStatusJsonConverter))]
        public global::G.EntityStatus? Status { get; set; }

        /// <summary>
        /// The date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the entity was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the entity was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Entity" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the entity.
        /// </param>
        /// <param name="name">
        /// The name of the entity.
        /// </param>
        /// <param name="description">
        /// A description of the entity.
        /// </param>
        /// <param name="metadata">
        /// Custom metadata for the entity.
        /// </param>
        /// <param name="assetIds">
        /// An array of asset IDs associated with the entity.
        /// </param>
        /// <param name="status">
        /// The current status of the entity creation process.<br/>
        /// **Values**:<br/>
        /// - `processing`: The entity is being processed and is not yet ready for use in searches.<br/>
        /// - `ready`: The entity is fully processed and can be used in search queries.
        /// </param>
        /// <param name="createdAt">
        /// The date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the entity was created.
        /// </param>
        /// <param name="updatedAt">
        /// The date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the entity was last updated.
        /// </param>
        public Entity(
            string? id,
            string? name,
            string? description,
            global::G.EntityMetadata? metadata,
            global::System.Collections.Generic.IList<string>? assetIds,
            global::G.EntityStatus? status,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Metadata = metadata;
            this.AssetIds = assetIds;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Entity" /> class.
        /// </summary>
        public Entity()
        {
        }
    }
}