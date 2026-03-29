//HintName: G.Models.ScimSettingsUpdateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScimSettingsUpdateRequest
    {
        /// <summary>
        /// Projects to Groups Mapping. List of objects with project_id, group, role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects_groups")]
        public global::System.Collections.Generic.IList<global::G.ProjectGroupRequest>? ProjectsGroups { get; set; }

        /// <summary>
        /// Organization Roles to Groups Mapping. List of [role_name, group_name] pairs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roles_groups")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? RolesGroups { get; set; }

        /// <summary>
        /// Workspaces to Groups Mapping. List of [workspace_title, group_name] pairs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspaces_groups")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? WorkspacesGroups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScimSettingsUpdateRequest" /> class.
        /// </summary>
        /// <param name="projectsGroups">
        /// Projects to Groups Mapping. List of objects with project_id, group, role.
        /// </param>
        /// <param name="rolesGroups">
        /// Organization Roles to Groups Mapping. List of [role_name, group_name] pairs.
        /// </param>
        /// <param name="workspacesGroups">
        /// Workspaces to Groups Mapping. List of [workspace_title, group_name] pairs.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScimSettingsUpdateRequest(
            global::System.Collections.Generic.IList<global::G.ProjectGroupRequest>? projectsGroups,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? rolesGroups,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? workspacesGroups)
        {
            this.ProjectsGroups = projectsGroups;
            this.RolesGroups = rolesGroups;
            this.WorkspacesGroups = workspacesGroups;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScimSettingsUpdateRequest" /> class.
        /// </summary>
        public ScimSettingsUpdateRequest()
        {
        }
    }
}