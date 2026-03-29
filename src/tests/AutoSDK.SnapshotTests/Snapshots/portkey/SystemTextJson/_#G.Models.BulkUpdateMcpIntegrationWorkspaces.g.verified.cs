//HintName: G.Models.BulkUpdateMcpIntegrationWorkspaces.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkUpdateMcpIntegrationWorkspaces
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspaces")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.BulkUpdateMcpIntegrationWorkspacesWorkspace> Workspaces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("global_workspace_access")]
        public global::G.BulkUpdateMcpIntegrationWorkspacesGlobalWorkspaceAccess? GlobalWorkspaceAccess { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("override_existing_workspace_access")]
        public bool? OverrideExistingWorkspaceAccess { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateMcpIntegrationWorkspaces" /> class.
        /// </summary>
        /// <param name="workspaces"></param>
        /// <param name="globalWorkspaceAccess"></param>
        /// <param name="overrideExistingWorkspaceAccess">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkUpdateMcpIntegrationWorkspaces(
            global::System.Collections.Generic.IList<global::G.BulkUpdateMcpIntegrationWorkspacesWorkspace> workspaces,
            global::G.BulkUpdateMcpIntegrationWorkspacesGlobalWorkspaceAccess? globalWorkspaceAccess,
            bool? overrideExistingWorkspaceAccess)
        {
            this.Workspaces = workspaces ?? throw new global::System.ArgumentNullException(nameof(workspaces));
            this.GlobalWorkspaceAccess = globalWorkspaceAccess;
            this.OverrideExistingWorkspaceAccess = overrideExistingWorkspaceAccess;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkUpdateMcpIntegrationWorkspaces" /> class.
        /// </summary>
        public BulkUpdateMcpIntegrationWorkspaces()
        {
        }
    }
}