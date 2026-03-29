//HintName: G.Models.Organization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Organization
    {
        /// <summary>
        /// The human-friendly ID of the Org
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the organization.<br/>
        /// Default Value: SincereYogurt
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The creation date of the organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Whether the organization has access to privileged tools.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("privileged_tools")]
        public bool? PrivilegedTools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Organization" /> class.
        /// </summary>
        /// <param name="id">
        /// The human-friendly ID of the Org
        /// </param>
        /// <param name="name">
        /// The name of the organization.<br/>
        /// Default Value: SincereYogurt
        /// </param>
        /// <param name="createdAt">
        /// The creation date of the organization.
        /// </param>
        /// <param name="privilegedTools">
        /// Whether the organization has access to privileged tools.<br/>
        /// Default Value: false
        /// </param>
        public Organization(
            string? id,
            string? name,
            global::System.DateTime? createdAt,
            bool? privilegedTools)
        {
            this.Id = id;
            this.Name = name;
            this.CreatedAt = createdAt;
            this.PrivilegedTools = privilegedTools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Organization" /> class.
        /// </summary>
        public Organization()
        {
        }
    }
}