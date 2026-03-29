//HintName: G.Models.PostMcpServersGenerateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request parameters for generating an MCP URL
    /// </summary>
    public sealed partial class PostMcpServersGenerateRequest
    {
        /// <summary>
        /// Unique identifier of the MCP server to generate URL for<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::Newtonsoft.Json.JsonProperty("mcp_server_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string McpServerId { get; set; } = default!;

        /// <summary>
        /// Flag indicating if Composio manages authentication<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("managed_auth_by_composio")]
        public bool? ManagedAuthByComposio { get; set; }

        /// <summary>
        /// List of user identifiers for whom the URL is generated<br/>
        /// Example: [user_123456, user_789012]
        /// </summary>
        /// <example>[user_123456, user_789012]</example>
        [global::Newtonsoft.Json.JsonProperty("user_ids")]
        public global::System.Collections.Generic.IList<string>? UserIds { get; set; }

        /// <summary>
        /// List of connected account identifiers<br/>
        /// Example: [account_1, account_2, account_3]
        /// </summary>
        /// <example>[account_1, account_2, account_3]</example>
        [global::Newtonsoft.Json.JsonProperty("connected_account_ids")]
        public global::System.Collections.Generic.IList<string>? ConnectedAccountIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostMcpServersGenerateRequest" /> class.
        /// </summary>
        /// <param name="mcpServerId">
        /// Unique identifier of the MCP server to generate URL for<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="managedAuthByComposio">
        /// Flag indicating if Composio manages authentication<br/>
        /// Default Value: false<br/>
        /// Example: true
        /// </param>
        /// <param name="userIds">
        /// List of user identifiers for whom the URL is generated<br/>
        /// Example: [user_123456, user_789012]
        /// </param>
        /// <param name="connectedAccountIds">
        /// List of connected account identifiers<br/>
        /// Example: [account_1, account_2, account_3]
        /// </param>
        public PostMcpServersGenerateRequest(
            string mcpServerId,
            bool? managedAuthByComposio,
            global::System.Collections.Generic.IList<string>? userIds,
            global::System.Collections.Generic.IList<string>? connectedAccountIds)
        {
            this.McpServerId = mcpServerId ?? throw new global::System.ArgumentNullException(nameof(mcpServerId));
            this.ManagedAuthByComposio = managedAuthByComposio;
            this.UserIds = userIds;
            this.ConnectedAccountIds = connectedAccountIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostMcpServersGenerateRequest" /> class.
        /// </summary>
        public PostMcpServersGenerateRequest()
        {
        }
    }
}