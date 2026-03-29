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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Entity type discriminator.<br/>
        /// Example: person
        /// </summary>
        /// <example>person</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PersonEntityTypeJsonConverter))]
        public global::G.PersonEntityType Type { get; set; }

        /// <summary>
        /// Schema version number.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// Structured properties for a person entity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EntityPersonProperties Properties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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