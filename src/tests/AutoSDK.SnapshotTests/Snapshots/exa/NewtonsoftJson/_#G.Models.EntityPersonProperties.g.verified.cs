//HintName: G.Models.EntityPersonProperties.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Structured properties for a person entity.
    /// </summary>
    public sealed partial class EntityPersonProperties
    {
        /// <summary>
        /// Person's full name.<br/>
        /// Example: John Doe
        /// </summary>
        /// <example>John Doe</example>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Person's location.<br/>
        /// Example: San Francisco, CA
        /// </summary>
        /// <example>San Francisco, CA</example>
        [global::Newtonsoft.Json.JsonProperty("location")]
        public string? Location { get; set; }

        /// <summary>
        /// List of work history entries.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workHistory")]
        public global::System.Collections.Generic.IList<global::G.EntityPersonPropertiesWorkHistoryEntry>? WorkHistory { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityPersonProperties" /> class.
        /// </summary>
        /// <param name="name">
        /// Person's full name.<br/>
        /// Example: John Doe
        /// </param>
        /// <param name="location">
        /// Person's location.<br/>
        /// Example: San Francisco, CA
        /// </param>
        /// <param name="workHistory">
        /// List of work history entries.
        /// </param>
        public EntityPersonProperties(
            string? name,
            string? location,
            global::System.Collections.Generic.IList<global::G.EntityPersonPropertiesWorkHistoryEntry>? workHistory)
        {
            this.Name = name;
            this.Location = location;
            this.WorkHistory = workHistory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityPersonProperties" /> class.
        /// </summary>
        public EntityPersonProperties()
        {
        }
    }
}