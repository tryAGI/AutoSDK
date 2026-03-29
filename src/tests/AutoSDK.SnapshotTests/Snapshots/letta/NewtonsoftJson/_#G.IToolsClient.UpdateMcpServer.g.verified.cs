//HintName: G.IToolsClient.UpdateMcpServer.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Update Mcp Server<br/>
        /// Update an existing MCP server configuration
        /// </summary>
        /// <param name="mcpServerName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.StdioServerConfig, global::G.SSEServerConfig, global::G.StreamableHTTPServerConfig>> UpdateMcpServerAsync(
            string mcpServerName,

            global::G.AnyOf<global::G.LettaSchemasMcpUpdateStdioMCPServer, global::G.LettaSchemasMcpUpdateSSEMCPServer, global::G.LettaSchemasMcpUpdateStreamableHTTPMCPServer> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Mcp Server<br/>
        /// Update an existing MCP server configuration
        /// </summary>
        /// <param name="mcpServerName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.StdioServerConfig, global::G.SSEServerConfig, global::G.StreamableHTTPServerConfig>> UpdateMcpServerAsync(
            string mcpServerName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}