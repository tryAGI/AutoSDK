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
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Company name.<br/>
        /// Example: Exa
        /// </summary>
        /// <example>Exa</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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