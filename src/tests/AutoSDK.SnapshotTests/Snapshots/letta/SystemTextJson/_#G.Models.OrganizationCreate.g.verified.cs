//HintName: G.Models.OrganizationCreate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrganizationCreate
    {
        /// <summary>
        /// The name of the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Whether the organization has access to privileged tools.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privileged_tools")]
        public bool? PrivilegedTools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationCreate" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the organization.
        /// </param>
        /// <param name="privilegedTools">
        /// Whether the organization has access to privileged tools.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationCreate(
            string? name,
            bool? privilegedTools)
        {
            this.Name = name;
            this.PrivilegedTools = privilegedTools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationCreate" /> class.
        /// </summary>
        public OrganizationCreate()
        {
        }
    }
}