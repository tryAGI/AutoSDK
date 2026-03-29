//HintName: G.IApi.McpServers.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// MCP Servers<br/>
        /// Return available MCP servers and tools included in those servers along with relevant metadata.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.McpServersResponse200> McpServersAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}