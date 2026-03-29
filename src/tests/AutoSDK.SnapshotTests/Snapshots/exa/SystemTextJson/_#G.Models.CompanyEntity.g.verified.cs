//HintName: G.Models.CompanyEntity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Structured entity data for a company.
    /// </summary>
    public sealed partial class CompanyEntity
    {
        /// <summary>
        /// Exa entity ID.<br/>
        /// Example: https://exa.ai/library/company/exa
        /// </summary>
        /// <example>https://exa.ai/library/company/exa</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Entity type discriminator.<br/>
        /// Example: company
        /// </summary>
        /// <example>company</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CompanyEntityTypeJsonConverter))]
        public global::G.CompanyEntityType Type { get; set; }

        /// <summary>
        /// Schema version number.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// Structured properties for a company entity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EntityCompanyProperties Properties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyEntity" /> class.
        /// </summary>
        /// <param name="id">
        /// Exa entity ID.<br/>
        /// Example: https://exa.ai/library/company/exa
        /// </param>
        /// <param name="version">
        /// Schema version number.<br/>
        /// Example: 1
        /// </param>
        /// <param name="properties">
        /// Structured properties for a company entity.
        /// </param>
        /// <param name="type">
        /// Entity type discriminator.<br/>
        /// Example: company
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompanyEntity(
            string id,
            int version,
            global::G.EntityCompanyProperties properties,
            global::G.CompanyEntityType type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Version = version;
            this.Properties = properties ?? throw new global::System.ArgumentNullException(nameof(properties));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyEntity" /> class.
        /// </summary>
        public CompanyEntity()
        {
        }
    }
}