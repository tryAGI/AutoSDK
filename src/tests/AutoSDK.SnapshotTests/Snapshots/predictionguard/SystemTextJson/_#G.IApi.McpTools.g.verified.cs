//HintName: G.IApi.McpTools.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// MCP Tools<br/>
        /// Return available MCP tools by server with parameters and any relevant metadata.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.McpToolsResponse200> McpToolsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}