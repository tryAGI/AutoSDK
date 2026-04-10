//HintName: G.IMcpClient.PostMcpServersCustom.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpClient
    {
        /// <summary>
        /// Create a new custom MCP server with multiple apps<br/>
        /// Creates a new Model Control Protocol (MCP) server instance that can integrate with multiple applications or toolkits simultaneously. This endpoint allows you to create a server that can access tools from different applications, making it suitable for complex workflows that span multiple services.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostMcpServersCustomResponse> PostMcpServersCustomAsync(

            global::G.PostMcpServersCustomRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new custom MCP server with multiple apps<br/>
        /// Creates a new Model Control Protocol (MCP) server instance that can integrate with multiple applications or toolkits simultaneously. This endpoint allows you to create a server that can access tools from different applications, making it suitable for complex workflows that span multiple services.
        /// </summary>
        /// <param name="name">
        /// Human-readable name to identify this custom MCP server (4-30 characters, alphanumeric, spaces, and hyphens only)<br/>
        /// Example: Multi App Integration Server
        /// </param>
        /// <param name="authConfigIds">
        /// ID references to existing authentication configurations<br/>
        /// Example: [auth_cfg_abc123def456, auth_cfg_xyz789]
        /// </param>
        /// <param name="toolkits">
        /// List of application/toolkit identifiers to enable for this server<br/>
        /// Example: [github, jira, slack]
        /// </param>
        /// <param name="allowedTools">
        /// Tool identifiers to enable that aren't part of standard toolkits<br/>
        /// Example: [custom-api-tool, internal-database-tool]
        /// </param>
        /// <param name="customTools">
        /// DEPRECATED: Use allowed_tools instead. Tool identifiers to enable that aren't part of standard toolkits<br/>
        /// Example: [custom-api-tool, internal-database-tool]
        /// </param>
        /// <param name="managedAuthViaComposio">
        /// Whether to manage authentication via Composio
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostMcpServersCustomResponse> PostMcpServersCustomAsync(
            string name,
            global::System.Collections.Generic.IList<string>? authConfigIds = default,
            global::System.Collections.Generic.IList<string>? toolkits = default,
            global::System.Collections.Generic.IList<string>? allowedTools = default,
            global::System.Collections.Generic.IList<string>? customTools = default,
            bool? managedAuthViaComposio = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}