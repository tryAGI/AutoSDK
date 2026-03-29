//HintName: G.Models.PersonEntity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Structured entity data for a person.
    /// </summary>
    public sealed partial class PersonEntity
    {
        /// <summary>
        /// Exa entity ID.<br/>
        /// Example: https://exa.ai/library/person/john-doe
        /// </summary>
        /// <example>https://exa.ai/library/person/john-doe</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Entity type discriminator.<br/>
        /// Example: person
        /// </summary>
        /// <example>person</example>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.PersonEntityType Type { get; set; }

        /// <summary>
        /// Schema version number.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public int Version { get; set; } = default!;

        /// <summary>
        /// Structured properties for a person entity.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("properties", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EntityPersonProperties Properties { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonEntity" /> class.
        /// </summary>
        /// <param name="id">
        /// Exa entity ID.<br/>
        /// Example: https://exa.ai/library/person/john-doe
        /// </param>
        /// <param name="version">
        /// Schema version number.<br/>
        /// Example: 1
        /// </param>
        /// <param name="properties">
        /// Structured properties for a person entity.
        /// </param>
        /// <param name="type">
        /// Entity type discriminator.<br/>
        /// Example: person
        /// </param>
        public PersonEntity(
            string id,
            int version,
            global::G.EntityPersonProperties properties,
            global::G.PersonEntityType type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Version = version;
            this.Properties = properties ?? throw new global::System.ArgumentNullException(nameof(properties));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonEntity" /> class.
        /// </summary>
        public PersonEntity()
        {
        }
    }
}