//HintName: G.IMcpClient.PostMcpServers.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpClient
    {
        /// <summary>
        /// Create a new MCP server<br/>
        /// Creates a new Model Control Protocol (MCP) server instance for the authenticated project. An MCP server provides a connection point for AI assistants to access your applications and services. The server is configured with specific authentication and tool permissions that determine what actions the connected assistants can perform.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostMcpServersResponse> PostMcpServersAsync(

            global::G.PostMcpServersRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new MCP server<br/>
        /// Creates a new Model Control Protocol (MCP) server instance for the authenticated project. An MCP server provides a connection point for AI assistants to access your applications and services. The server is configured with specific authentication and tool permissions that determine what actions the connected assistants can perform.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostMcpServersResponse> PostMcpServersAsync(
            string name,
            global::System.Collections.Generic.IList<string> authConfigIds,
            global::System.Collections.Generic.IList<string>? noAuthApps = default,
            global::System.Collections.Generic.IList<string>? allowedTools = default,
            bool? managedAuthViaComposio = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}