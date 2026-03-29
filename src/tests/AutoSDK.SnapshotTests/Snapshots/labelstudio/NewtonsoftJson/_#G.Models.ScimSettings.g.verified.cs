//HintName: G.Models.ScimSettings.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScimSettings
    {
        /// <summary>
        /// Projects to groups mapping
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("projects_groups")]
        public object? ProjectsGroups { get; set; }

        /// <summary>
        /// Roles to groups mapping
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("roles_groups")]
        public object? RolesGroups { get; set; }

        /// <summary>
        /// Workspaces to groups mapping
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspaces_groups")]
        public object? WorkspacesGroups { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScimSettings" /> class.
        /// </summary>
        /// <param name="projectsGroups">
        /// Projects to groups mapping
        /// </param>
        /// <param name="rolesGroups">
        /// Roles to groups mapping
        /// </param>
        /// <param name="workspacesGroups">
        /// Workspaces to groups mapping
        /// </param>
        public ScimSettings(
            object? projectsGroups,
            object? rolesGroups,
            object? workspacesGroups)
        {
            this.ProjectsGroups = projectsGroups;
            this.RolesGroups = rolesGroups;
            this.WorkspacesGroups = workspacesGroups;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScimSettings" /> class.
        /// </summary>
        public ScimSettings()
        {
        }
    }
}