//HintName: G.Models.PostMcpServersRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request parameters for creating a new MCP server with specific authentication configuration
    /// </summary>
    public sealed partial class PostMcpServersRequest
    {
        /// <summary>
        /// Human-readable name to identify this MCP server instance (4-30 characters, alphanumeric, spaces, and hyphens only)<br/>
        /// Example: Production GitHub Integration
        /// </summary>
        /// <example>Production GitHub Integration</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// ID references to existing authentication configurations<br/>
        /// Example: [auth_cfg_abc123def456, auth_cfg_xyz789]
        /// </summary>
        /// <example>[auth_cfg_abc123def456, auth_cfg_xyz789]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_config_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AuthConfigIds { get; set; }

        /// <summary>
        /// List of NO_AUTH apps to enable for this MCP server<br/>
        /// Example: [exa, codeinterpreter, composio, composio_search]
        /// </summary>
        /// <example>[exa, codeinterpreter, composio, composio_search]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("no_auth_apps")]
        public global::System.Collections.Generic.IList<string>? NoAuthApps { get; set; }

        /// <summary>
        /// List of tool slugs that should be allowed for this server. If not provided, all available tools for the authentication configuration will be enabled.<br/>
        /// Default Value: []<br/>
        /// Example: [github-issues, github-repos, github-pull-requests]
        /// </summary>
        /// <example>[github-issues, github-repos, github-pull-requests]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_tools")]
        public global::System.Collections.Generic.IList<string>? AllowedTools { get; set; }

        /// <summary>
        /// Whether the MCP server is managed by Composio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("managed_auth_via_composio")]
        public bool? ManagedAuthViaComposio { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostMcpServersRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable name to identify this MCP server instance (4-30 characters, alphanumeric, spaces, and hyphens only)<br/>
        /// Example: Production GitHub Integration
        /// </param>
        /// <param name="authConfigIds">
        /// ID references to existing authentication configurations<br/>
        /// Example: [auth_cfg_abc123def456, auth_cfg_xyz789]
        /// </param>
        /// <param name="noAuthApps">
        /// List of NO_AUTH apps to enable for this MCP server<br/>
        /// Example: [exa, codeinterpreter, composio, composio_search]
        /// </param>
        /// <param name="allowedTools">
        /// List of tool slugs that should be allowed for this server. If not provided, all available tools for the authentication configuration will be enabled.<br/>
        /// Default Value: []<br/>
        /// Example: [github-issues, github-repos, github-pull-requests]
        /// </param>
        /// <param name="managedAuthViaComposio">
        /// Whether the MCP server is managed by Composio
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PostMcpServersRequest(
            string name,
            global::System.Collections.Generic.IList<string> authConfigIds,
            global::System.Collections.Generic.IList<string>? noAuthApps,
            global::System.Collections.Generic.IList<string>? allowedTools,
            bool? managedAuthViaComposio)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AuthConfigIds = authConfigIds ?? throw new global::System.ArgumentNullException(nameof(authConfigIds));
            this.NoAuthApps = noAuthApps;
            this.AllowedTools = allowedTools;
            this.ManagedAuthViaComposio = managedAuthViaComposio;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostMcpServersRequest" /> class.
        /// </summary>
        public PostMcpServersRequest()
        {
        }
    }
}