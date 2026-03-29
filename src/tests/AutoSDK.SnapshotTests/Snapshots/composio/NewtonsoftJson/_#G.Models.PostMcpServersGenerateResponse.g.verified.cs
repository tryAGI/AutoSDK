//HintName: G.Models.PostMcpServersGenerateResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response containing the generated MCP URLs
    /// </summary>
    public sealed partial class PostMcpServersGenerateResponse
    {
        /// <summary>
        /// Base MCP URL without any query parameters<br/>
        /// Example: https://mcp.composio.dev/composio/server/550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>https://mcp.composio.dev/composio/server/550e8400-e29b-41d4-a716-446655440000</example>
        [global::Newtonsoft.Json.JsonProperty("mcp_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string McpUrl { get; set; } = default!;

        /// <summary>
        /// List of URLs generated for each connected account ID<br/>
        /// Example: [https://mcp.composio.dev/composio/server/550e8400-e29b-41d4-a716-446655440000?include_composio_helper_actions=true&amp;connected_account_ids=account_1&amp;user_id=user_123456,user_789012, https://mcp.composio.dev/composio/server/550e8400-e29b-41d4-a716-446655440000?include_composio_helper_actions=true&amp;connected_account_ids=account_2&amp;user_id=user_123456,user_789012]
        /// </summary>
        /// <example>[https://mcp.composio.dev/composio/server/550e8400-e29b-41d4-a716-446655440000?include_composio_helper_actions=true&amp;connected_account_ids=account_1&amp;user_id=user_123456,user_789012, https://mcp.composio.dev/composio/server/550e8400-e29b-41d4-a716-446655440000?include_composio_helper_actions=true&amp;connected_account_ids=account_2&amp;user_id=user_123456,user_789012]</example>
        [global::Newtonsoft.Json.JsonProperty("connected_account_urls", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> ConnectedAccountUrls { get; set; } = default!;

        /// <summary>
        /// List of URLs generated for each user ID<br/>
        /// Example: [https://mcp.composio.dev/composio/server/550e8400-e29b-41d4-a716-446655440000?include_composio_helper_actions=true&amp;connected_account_ids=account_1,account_2&amp;user_id=user_123456, https://mcp.composio.dev/composio/server/550e8400-e29b-41d4-a716-446655440000?include_composio_helper_actions=true&amp;connected_account_ids=account_1,account_2&amp;user_id=user_789012]
        /// </summary>
        /// <example>[https://mcp.composio.dev/composio/server/550e8400-e29b-41d4-a716-446655440000?include_composio_helper_actions=true&amp;connected_account_ids=account_1,account_2&amp;user_id=user_123456, https://mcp.composio.dev/composio/server/550e8400-e29b-41d4-a716-446655440000?include_composio_helper_actions=true&amp;connected_account_ids=account_1,account_2&amp;user_id=user_789012]</example>
        [global::Newtonsoft.Json.JsonProperty("user_ids_url", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> UserIdsUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostMcpServersGenerateResponse" /> class.
        /// </summary>
        /// <param name="mcpUrl">
        /// Base MCP URL without any query parameters<br/>
        /// Example: https://mcp.composio.dev/composio/server/550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="connectedAccountUrls">
        /// List of URLs generated for each connected account ID<br/>
        /// Example: [https://mcp.composio.dev/composio/server/550e8400-e29b-41d4-a716-446655440000?include_composio_helper_actions=true&amp;connected_account_ids=account_1&amp;user_id=user_123456,user_789012, https://mcp.composio.dev/composio/server/550e8400-e29b-41d4-a716-446655440000?include_composio_helper_actions=true&amp;connected_account_ids=account_2&amp;user_id=user_123456,user_789012]
        /// </param>
        /// <param name="userIdsUrl">
        /// List of URLs generated for each user ID<br/>
        /// Example: [https://mcp.composio.dev/composio/server/550e8400-e29b-41d4-a716-446655440000?include_composio_helper_actions=true&amp;connected_account_ids=account_1,account_2&amp;user_id=user_123456, https://mcp.composio.dev/composio/server/550e8400-e29b-41d4-a716-446655440000?include_composio_helper_actions=true&amp;connected_account_ids=account_1,account_2&amp;user_id=user_789012]
        /// </param>
        public PostMcpServersGenerateResponse(
            string mcpUrl,
            global::System.Collections.Generic.IList<string> connectedAccountUrls,
            global::System.Collections.Generic.IList<string> userIdsUrl)
        {
            this.McpUrl = mcpUrl ?? throw new global::System.ArgumentNullException(nameof(mcpUrl));
            this.ConnectedAccountUrls = connectedAccountUrls ?? throw new global::System.ArgumentNullException(nameof(connectedAccountUrls));
            this.UserIdsUrl = userIdsUrl ?? throw new global::System.ArgumentNullException(nameof(userIdsUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostMcpServersGenerateResponse" /> class.
        /// </summary>
        public PostMcpServersGenerateResponse()
        {
        }
    }
}