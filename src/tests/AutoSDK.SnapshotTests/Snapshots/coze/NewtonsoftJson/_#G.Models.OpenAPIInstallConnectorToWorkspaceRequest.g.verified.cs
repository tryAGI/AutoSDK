//HintName: G.Models.OpenAPIInstallConnectorToWorkspaceRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OpenAPIInstallConnectorToWorkspaceRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string WorkspaceId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIInstallConnectorToWorkspaceRequest" /> class.
        /// </summary>
        /// <param name="workspaceId"></param>
        public OpenAPIInstallConnectorToWorkspaceRequest(
            string workspaceId)
        {
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIInstallConnectorToWorkspaceRequest" /> class.
        /// </summary>
        public OpenAPIInstallConnectorToWorkspaceRequest()
        {
        }
    }
}