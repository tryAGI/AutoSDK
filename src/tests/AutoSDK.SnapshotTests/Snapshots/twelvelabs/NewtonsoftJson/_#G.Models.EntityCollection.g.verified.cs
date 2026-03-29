//HintName: G.Models.EntityCollection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object that represents a collection of related entities.
    /// </summary>
    public sealed partial class EntityCollection
    {
        /// <summary>
        /// The unique identifier of the entity collection.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("_id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the entity collection.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The description of the entity collection.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the entity collection was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the entity collection was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityCollection" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the entity collection.
        /// </param>
        /// <param name="name">
        /// The name of the entity collection.
        /// </param>
        /// <param name="description">
        /// The description of the entity collection.
        /// </param>
        /// <param name="createdAt">
        /// The date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the entity collection was created.
        /// </param>
        /// <param name="updatedAt">
        /// The date and time, in RFC 3339 format (“YYYY-MM-DDTHH:mm:ssZ”), when the entity collection was last updated.
        /// </param>
        public EntityCollection(
            string? id,
            string? name,
            string? description,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityCollection" /> class.
        /// </summary>
        public EntityCollection()
        {
        }
    }
}