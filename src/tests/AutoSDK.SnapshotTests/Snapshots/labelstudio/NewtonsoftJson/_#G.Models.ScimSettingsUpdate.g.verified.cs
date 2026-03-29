//HintName: G.Models.ScimSettingsUpdate.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScimSettingsUpdate
    {
        /// <summary>
        /// Projects to Groups Mapping. List of objects with project_id, group, role.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projects_groups")]
        public global::System.Collections.Generic.IList<global::G.ProjectGroup>? ProjectsGroups { get; set; }

        /// <summary>
        /// Organization Roles to Groups Mapping. List of [role_name, group_name] pairs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("roles_groups")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? RolesGroups { get; set; }

        /// <summary>
        /// Workspaces to Groups Mapping. List of [workspace_title, group_name] pairs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspaces_groups")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? WorkspacesGroups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScimSettingsUpdate" /> class.
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
        public ScimSettingsUpdate(
            global::System.Collections.Generic.IList<global::G.ProjectGroup>? projectsGroups,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? rolesGroups,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>? workspacesGroups)
        {
            this.ProjectsGroups = projectsGroups;
            this.RolesGroups = rolesGroups;
            this.WorkspacesGroups = workspacesGroups;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScimSettingsUpdate" /> class.
        /// </summary>
        public ScimSettingsUpdate()
        {
        }
    }
}