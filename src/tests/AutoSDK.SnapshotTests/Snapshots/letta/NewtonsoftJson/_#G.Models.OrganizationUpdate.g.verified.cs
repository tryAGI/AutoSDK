//HintName: G.Models.OrganizationUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationUpdate
    {
        /// <summary>
        /// The name of the organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

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
        /// Initializes a new instance of the <see cref="OrganizationUpdate" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the organization.
        /// </param>
        /// <param name="privilegedTools">
        /// Whether the organization has access to privileged tools.<br/>
        /// Default Value: false
        /// </param>
        public OrganizationUpdate(
            string? name,
            bool? privilegedTools)
        {
            this.Name = name;
            this.PrivilegedTools = privilegedTools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationUpdate" /> class.
        /// </summary>
        public OrganizationUpdate()
        {
        }
    }
}