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
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ProjectId { get; set; }

        /// <summary>
        /// Project name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectName { get; set; }

        /// <summary>
        /// Workspace ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WorkspaceId { get; set; }

        /// <summary>
        /// Workspace name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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