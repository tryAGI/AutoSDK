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
        [global::Newtonsoft.Json.JsonProperty("workspaces")]
        public global::System.Collections.Generic.IList<global::G.McpIntegrationWorkspaceItem>? Workspaces { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("global_workspace_access")]
        public object? GlobalWorkspaceAccess { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpIntegrationWorkspacesLegacyResponse" /> class.
        /// </summary>
        /// <param name="workspaces"></param>
        /// <param name="globalWorkspaceAccess"></param>
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