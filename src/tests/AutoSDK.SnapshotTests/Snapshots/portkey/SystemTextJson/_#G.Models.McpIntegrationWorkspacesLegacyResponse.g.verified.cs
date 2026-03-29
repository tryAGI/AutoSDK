//HintName: G.Models.McpIntegrationWorkspacesLegacyResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpIntegrationWorkspacesLegacyResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspaces")]
        public global::System.Collections.Generic.IList<global::G.McpIntegrationWorkspaceItem>? Workspaces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("global_workspace_access")]
        public object? GlobalWorkspaceAccess { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpIntegrationWorkspacesLegacyResponse" /> class.
        /// </summary>
        /// <param name="workspaces"></param>
        /// <param name="globalWorkspaceAccess"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpIntegrationWorkspacesLegacyResponse(
            global::System.Collections.Generic.IList<global::G.McpIntegrationWorkspaceItem>? workspaces,
            object? globalWorkspaceAccess)
        {
            this.Workspaces = workspaces;
            this.GlobalWorkspaceAccess = globalWorkspaceAccess;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpIntegrationWorkspacesLegacyResponse" /> class.
        /// </summary>
        public McpIntegrationWorkspacesLegacyResponse()
        {
        }
    }
}