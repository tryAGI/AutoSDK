//HintName: G.Models.KPIProjectInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Serializer for project information (compact format).
    /// </summary>
    public sealed partial class KPIProjectInfo
    {
        /// <summary>
        /// Project ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int ProjectId { get; set; } = default!;

        /// <summary>
        /// Project name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectName { get; set; } = default!;

        /// <summary>
        /// Workspace ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int WorkspaceId { get; set; } = default!;

        /// <summary>
        /// Workspace name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string WorkspaceName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KPIProjectInfo" /> class.
        /// </summary>
        /// <param name="projectId">
        /// Project ID
        /// </param>
        /// <param name="projectName">
        /// Project name
        /// </param>
        /// <param name="workspaceId">
        /// Workspace ID
        /// </param>
        /// <param name="workspaceName">
        /// Workspace name
        /// </param>
        public KPIProjectInfo(
            int projectId,
            string projectName,
            int workspaceId,
            string workspaceName)
        {
            this.ProjectId = projectId;
            this.ProjectName = projectName ?? throw new global::System.ArgumentNullException(nameof(projectName));
            this.WorkspaceId = workspaceId;
            this.WorkspaceName = workspaceName ?? throw new global::System.ArgumentNullException(nameof(workspaceName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KPIProjectInfo" /> class.
        /// </summary>
        public KPIProjectInfo()
        {
        }
    }
}