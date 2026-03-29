//HintName: G.Models.EntityReference.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EntityReference
    {
        /// <summary>
        /// The ID of the entity.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// The type of entity. SNIPPET is a pseudo-entity type representing completion-type prompts.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EntityType Type { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityReference" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the entity.
        /// </param>
        /// <param name="type">
        /// The type of entity. SNIPPET is a pseudo-entity type representing completion-type prompts.
        /// </param>
        public EntityReference(
            int id,
            global::G.EntityType type)
        {
            this.Id = id;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityReference" /> class.
        /// </summary>
        public EntityReference()
        {
        }
    }
}