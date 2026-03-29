//HintName: G.IToolsClient.ListMcpServers.g.cs
#nullable enable

namespace G
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// List Mcp Servers<br/>
        /// Get a list of all configured MCP servers
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ListMcpServersAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}