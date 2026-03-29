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
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EntityInputEntityTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EntityInputEntityType EntityType { get; set; }

        /// <summary>
        /// The unique identifier of the entity (memory_id)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid EntityId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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