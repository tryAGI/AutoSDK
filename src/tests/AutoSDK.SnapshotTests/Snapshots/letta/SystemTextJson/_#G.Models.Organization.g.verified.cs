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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The name of the organization.<br/>
        /// Default Value: SincereYogurt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The creation date of the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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