//HintName: G.IMcpServersClient.McpServersTest.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpServersClient
    {
        /// <summary>
        /// Test MCP Server Connection<br/>
        /// Test connectivity to the MCP server via its integration URL.
        /// </summary>
        /// <param name="mcpServerId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.McpServerTestResponse> McpServersTestAsync(
            string mcpServerId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}