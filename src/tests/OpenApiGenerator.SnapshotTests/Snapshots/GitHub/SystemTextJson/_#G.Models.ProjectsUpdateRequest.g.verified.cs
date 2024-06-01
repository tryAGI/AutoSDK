//HintName: G.Models.ProjectsUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectsUpdateRequest
    {
        /// <summary>
        /// Name of the project
        /// <br/>Example: Week One Sprint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Body of the project
        /// <br/>Example: This project represents the sprint of the first week in January
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public string? Body { get; set; }

        /// <summary>
        /// State of the project; either 'open' or 'closed'
        /// <br/>Example: open
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// The baseline permission that all organization members have on this project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_permission")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.ProjectsUpdateRequestOrganizationPermissionJsonConverter))]
        public ProjectsUpdateRequestOrganizationPermission? OrganizationPermission { get; set; }

        /// <summary>
        /// Whether or not this project can be seen by everyone.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private")]
        public bool Private { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}