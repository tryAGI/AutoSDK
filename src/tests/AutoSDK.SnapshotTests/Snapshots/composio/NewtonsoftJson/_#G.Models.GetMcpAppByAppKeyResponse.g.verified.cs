//HintName: G.Models.GetMcpAppByAppKeyResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Paginated response containing MCP servers
    /// </summary>
    public sealed partial class GetMcpAppByAppKeyResponse
    {
        /// <summary>
        /// Array of MCP server configurations<br/>
        /// Example: [{"id":"550e8400-e29b-41d4-a716-446655440000","name":"GitHub Integration Server","auth_config_ids":["auth_cfg_abc123def456","auth_cfg_xyz789"],"allowed_tools":["github-issues","github-repos"],"mcp_url":"https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?user_id=john","commands":{"cursor":"npx @composio/mcp@latest setup \u0022https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?user_id=john\u0022 --client cursor","claude":"npx @composio/mcp@latest setup \u0022https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?user_id=john\u0022 --client claude","windsurf":"npx @composio/mcp@latest setup \u0022https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?user_id=john\u0022 --client windsurf"},"toolkits":["github","jira","slack"],"toolkit_icons":{"github":"https://assets.composio.dev/logos/github.png","jira":"https://assets.composio.dev/logos/jira.png","slack":"https://assets.composio.dev/logos/slack.png"},"updated_at":"2023-06-15T14:30:00.000Z","created_at":"2023-06-10T09:15:00.000Z","server_instance_count":5,"managed_auth_via_composio":true}]
        /// </summary>
        /// <example>[{"id":"550e8400-e29b-41d4-a716-446655440000","name":"GitHub Integration Server","auth_config_ids":["auth_cfg_abc123def456","auth_cfg_xyz789"],"allowed_tools":["github-issues","github-repos"],"mcp_url":"https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?user_id=john","commands":{"cursor":"npx @composio/mcp@latest setup \u0022https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?user_id=john\u0022 --client cursor","claude":"npx @composio/mcp@latest setup \u0022https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?user_id=john\u0022 --client claude","windsurf":"npx @composio/mcp@latest setup \u0022https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?user_id=john\u0022 --client windsurf"},"toolkits":["github","jira","slack"],"toolkit_icons":{"github":"https://assets.composio.dev/logos/github.png","jira":"https://assets.composio.dev/logos/jira.png","slack":"https://assets.composio.dev/logos/slack.png"},"updated_at":"2023-06-15T14:30:00.000Z","created_at":"2023-06-10T09:15:00.000Z","server_instance_count":5,"managed_auth_via_composio":true}]</example>
        [global::Newtonsoft.Json.JsonProperty("items", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetMcpAppByAppKeyResponseItem> Items { get; set; } = default!;

        /// <summary>
        /// Total number of pages in the paginated response<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::Newtonsoft.Json.JsonProperty("total_pages", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalPages { get; set; } = default!;

        /// <summary>
        /// Current page number being returned<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("current_page", Required = global::Newtonsoft.Json.Required.Always)]
        public double CurrentPage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMcpAppByAppKeyResponse" /> class.
        /// </summary>
        /// <param name="items">
        /// Array of MCP server configurations<br/>
        /// Example: [{"id":"550e8400-e29b-41d4-a716-446655440000","name":"GitHub Integration Server","auth_config_ids":["auth_cfg_abc123def456","auth_cfg_xyz789"],"allowed_tools":["github-issues","github-repos"],"mcp_url":"https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?user_id=john","commands":{"cursor":"npx @composio/mcp@latest setup \u0022https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?user_id=john\u0022 --client cursor","claude":"npx @composio/mcp@latest setup \u0022https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?user_id=john\u0022 --client claude","windsurf":"npx @composio/mcp@latest setup \u0022https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?user_id=john\u0022 --client windsurf"},"toolkits":["github","jira","slack"],"toolkit_icons":{"github":"https://assets.composio.dev/logos/github.png","jira":"https://assets.composio.dev/logos/jira.png","slack":"https://assets.composio.dev/logos/slack.png"},"updated_at":"2023-06-15T14:30:00.000Z","created_at":"2023-06-10T09:15:00.000Z","server_instance_count":5,"managed_auth_via_composio":true}]
        /// </param>
        /// <param name="totalPages">
        /// Total number of pages in the paginated response<br/>
        /// Example: 5
        /// </param>
        /// <param name="currentPage">
        /// Current page number being returned<br/>
        /// Example: 1
        /// </param>
        public GetMcpAppByAppKeyResponse(
            global::System.Collections.Generic.IList<global::G.GetMcpAppByAppKeyResponseItem> items,
            double totalPages,
            double currentPage)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.TotalPages = totalPages;
            this.CurrentPage = currentPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMcpAppByAppKeyResponse" /> class.
        /// </summary>
        public GetMcpAppByAppKeyResponse()
        {
        }
    }
}