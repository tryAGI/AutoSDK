//HintName: G.Models.GetMcpByIdResponse.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// MCP server configuration and connection details
    /// </summary>
    public sealed partial class GetMcpByIdResponse
    {
        /// <summary>
        /// UUID of the MCP server instance<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>550e8400-e29b-41d4-a716-446655440000</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// User-defined descriptive name for this MCP server<br/>
        /// Example: GitHub Integration Server
        /// </summary>
        /// <example>GitHub Integration Server</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// ID references to the auth configurations used by this server<br/>
        /// Example: [auth_cfg_abc123def456, auth_cfg_xyz789]
        /// </summary>
        /// <example>[auth_cfg_abc123def456, auth_cfg_xyz789]</example>
        [global::Newtonsoft.Json.JsonProperty("auth_config_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> AuthConfigIds { get; set; } = default!;

        /// <summary>
        /// Array of tool slugs that this MCP server is allowed to use<br/>
        /// Example: [github-issues, github-repos, github-pull-requests]
        /// </summary>
        /// <example>[github-issues, github-repos, github-pull-requests]</example>
        [global::Newtonsoft.Json.JsonProperty("allowed_tools", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> AllowedTools { get; set; } = default!;

        /// <summary>
        /// [DEPRECATED] Please use the URL with user_id or connected_account_id query param<br/>
        /// Example: https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?user_id=john
        /// </summary>
        /// <example>https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?user_id=john</example>
        [global::Newtonsoft.Json.JsonProperty("mcp_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string McpUrl { get; set; } = default!;

        /// <summary>
        /// Array of toolkit slugs that this MCP server is allowed to use<br/>
        /// Example: [github, jira, slack]
        /// </summary>
        /// <example>[github, jira, slack]</example>
        [global::Newtonsoft.Json.JsonProperty("toolkits", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Toolkits { get; set; } = default!;

        /// <summary>
        /// Object mapping each toolkit slug to its icon/logo URL for display purposes<br/>
        /// Example: {"github":"https://assets.composio.dev/logos/github.png","jira":"https://assets.composio.dev/logos/jira.png","slack":"https://assets.composio.dev/logos/slack.png"}
        /// </summary>
        /// <example>{"github":"https://assets.composio.dev/logos/github.png","jira":"https://assets.composio.dev/logos/jira.png","slack":"https://assets.composio.dev/logos/slack.png"}</example>
        [global::Newtonsoft.Json.JsonProperty("toolkit_icons", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, string> ToolkitIcons { get; set; } = default!;

        /// <summary>
        /// Set of command line instructions for connecting various clients to this MCP server
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("commands", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.GetMcpByIdResponseCommands Commands { get; set; } = default!;

        /// <summary>
        /// Date and time when this server configuration was last modified<br/>
        /// Example: 2023-06-15T14:30:00.000Z
        /// </summary>
        /// <example>2023-06-15T14:30:00.000Z</example>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Date and time when this server was initially created<br/>
        /// Example: 2023-06-10T09:15:00.000Z
        /// </summary>
        /// <example>2023-06-10T09:15:00.000Z</example>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Total count of active user instances connected to this server<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::Newtonsoft.Json.JsonProperty("server_instance_count", Required = global::Newtonsoft.Json.Required.Always)]
        public double ServerInstanceCount { get; set; } = default!;

        /// <summary>
        /// Whether the MCP server is managed by Composio<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("managed_auth_via_composio", Required = global::Newtonsoft.Json.Required.Always)]
        public bool ManagedAuthViaComposio { get; set; } = default!;

        /// <summary>
        /// Whether the MCP server is deleted
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleted", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Deleted { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMcpByIdResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// UUID of the MCP server instance<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="name">
        /// User-defined descriptive name for this MCP server<br/>
        /// Example: GitHub Integration Server
        /// </param>
        /// <param name="authConfigIds">
        /// ID references to the auth configurations used by this server<br/>
        /// Example: [auth_cfg_abc123def456, auth_cfg_xyz789]
        /// </param>
        /// <param name="allowedTools">
        /// Array of tool slugs that this MCP server is allowed to use<br/>
        /// Example: [github-issues, github-repos, github-pull-requests]
        /// </param>
        /// <param name="mcpUrl">
        /// [DEPRECATED] Please use the URL with user_id or connected_account_id query param<br/>
        /// Example: https://backend.composio.dev/v3/mcp/550e8400-e29b-41d4-a716-446655440000?user_id=john
        /// </param>
        /// <param name="toolkits">
        /// Array of toolkit slugs that this MCP server is allowed to use<br/>
        /// Example: [github, jira, slack]
        /// </param>
        /// <param name="toolkitIcons">
        /// Object mapping each toolkit slug to its icon/logo URL for display purposes<br/>
        /// Example: {"github":"https://assets.composio.dev/logos/github.png","jira":"https://assets.composio.dev/logos/jira.png","slack":"https://assets.composio.dev/logos/slack.png"}
        /// </param>
        /// <param name="commands">
        /// Set of command line instructions for connecting various clients to this MCP server
        /// </param>
        /// <param name="updatedAt">
        /// Date and time when this server configuration was last modified<br/>
        /// Example: 2023-06-15T14:30:00.000Z
        /// </param>
        /// <param name="createdAt">
        /// Date and time when this server was initially created<br/>
        /// Example: 2023-06-10T09:15:00.000Z
        /// </param>
        /// <param name="serverInstanceCount">
        /// Total count of active user instances connected to this server<br/>
        /// Example: 5
        /// </param>
        /// <param name="managedAuthViaComposio">
        /// Whether the MCP server is managed by Composio<br/>
        /// Example: true
        /// </param>
        /// <param name="deleted">
        /// Whether the MCP server is deleted
        /// </param>
        public GetMcpByIdResponse(
            string id,
            string name,
            global::System.Collections.Generic.IList<string> authConfigIds,
            global::System.Collections.Generic.IList<string> allowedTools,
            string mcpUrl,
            global::System.Collections.Generic.IList<string> toolkits,
            global::System.Collections.Generic.Dictionary<string, string> toolkitIcons,
            global::G.GetMcpByIdResponseCommands commands,
            string updatedAt,
            string createdAt,
            double serverInstanceCount,
            bool managedAuthViaComposio,
            bool deleted)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AuthConfigIds = authConfigIds ?? throw new global::System.ArgumentNullException(nameof(authConfigIds));
            this.AllowedTools = allowedTools ?? throw new global::System.ArgumentNullException(nameof(allowedTools));
            this.McpUrl = mcpUrl ?? throw new global::System.ArgumentNullException(nameof(mcpUrl));
            this.Toolkits = toolkits ?? throw new global::System.ArgumentNullException(nameof(toolkits));
            this.ToolkitIcons = toolkitIcons ?? throw new global::System.ArgumentNullException(nameof(toolkitIcons));
            this.Commands = commands ?? throw new global::System.ArgumentNullException(nameof(commands));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.ServerInstanceCount = serverInstanceCount;
            this.ManagedAuthViaComposio = managedAuthViaComposio;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetMcpByIdResponse" /> class.
        /// </summary>
        public GetMcpByIdResponse()
        {
        }
    }
}