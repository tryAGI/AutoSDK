//HintName: G.Models.McpIntegrationWorkspacesListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpIntegrationWorkspacesListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::G.McpIntegrationWorkspaceItem>? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("global_workspace_access")]
        public object? GlobalWorkspaceAccess { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpIntegrationWorkspacesListResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="globalWorkspaceAccess"></param>
        /// <param name="total"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpIntegrationWorkspacesListResponse(
            global::System.Collections.Generic.IList<global::G.McpIntegrationWorkspaceItem>? data,
            object? globalWorkspaceAccess,
            int? total)
        {
            this.Data = data;
            this.GlobalWorkspaceAccess = globalWorkspaceAccess;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpIntegrationWorkspacesListResponse" /> class.
        /// </summary>
        public McpIntegrationWorkspacesListResponse()
        {
        }
    }
}