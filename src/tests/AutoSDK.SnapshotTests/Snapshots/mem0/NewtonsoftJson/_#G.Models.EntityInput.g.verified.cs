//HintName: G.Models.EntityInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Input for specifying an entity.
    /// </summary>
    public sealed partial class EntityInput
    {
        /// <summary>
        /// The type of the entity
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entity_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EntityInputEntityType EntityType { get; set; } = default!;

        /// <summary>
        /// The unique identifier of the entity (memory_id)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entity_id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid EntityId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityInput" /> class.
        /// </summary>
        /// <param name="entityType">
        /// The type of the entity
        /// </param>
        /// <param name="entityId">
        /// The unique identifier of the entity (memory_id)
        /// </param>
        public EntityInput(
            global::G.EntityInputEntityType entityType,
            global::System.Guid entityId)
        {
            this.EntityType = entityType;
            this.EntityId = entityId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityInput" /> class.
        /// </summary>
        public EntityInput()
        {
        }
    }
}