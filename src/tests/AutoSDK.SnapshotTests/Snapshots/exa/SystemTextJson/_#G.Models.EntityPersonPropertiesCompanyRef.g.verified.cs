//HintName: G.Models.EntityPersonPropertiesCompanyRef.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Reference to a company in work history.
    /// </summary>
    public sealed partial class EntityPersonPropertiesCompanyRef
    {
        /// <summary>
        /// Exa entity ID for the company.<br/>
        /// Example: https://exa.ai/library/company/exa
        /// </summary>
        /// <example>https://exa.ai/library/company/exa</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Company name.<br/>
        /// Example: Exa
        /// </summary>
        /// <example>Exa</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityPersonPropertiesCompanyRef" /> class.
        /// </summary>
        /// <param name="id">
        /// Exa entity ID for the company.<br/>
        /// Example: https://exa.ai/library/company/exa
        /// </param>
        /// <param name="name">
        /// Company name.<br/>
        /// Example: Exa
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EntityPersonPropertiesCompanyRef(
            string? id,
            string? name)
        {
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityPersonPropertiesCompanyRef" /> class.
        /// </summary>
        public EntityPersonPropertiesCompanyRef()
        {
        }
    }
}