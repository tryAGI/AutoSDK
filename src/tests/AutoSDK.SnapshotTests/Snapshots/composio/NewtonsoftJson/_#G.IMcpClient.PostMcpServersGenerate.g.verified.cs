//HintName: G.IMcpClient.PostMcpServersGenerate.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpClient
    {
        /// <summary>
        /// Generate MCP URL with custom parameters<br/>
        /// Generates a Model Control Protocol (MCP) URL for an existing server with custom query parameters. The URL includes user-specific parameters and configuration flags that control the behavior of the MCP connection.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostMcpServersGenerateResponse> PostMcpServersGenerateAsync(

            global::G.PostMcpServersGenerateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate MCP URL with custom parameters<br/>
        /// Generates a Model Control Protocol (MCP) URL for an existing server with custom query parameters. The URL includes user-specific parameters and configuration flags that control the behavior of the MCP connection.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PostMcpServersGenerateResponse> PostMcpServersGenerateAsync(
            string mcpServerId,
            bool? managedAuthByComposio = default,
            global::System.Collections.Generic.IList<string>? userIds = default,
            global::System.Collections.Generic.IList<string>? connectedAccountIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}