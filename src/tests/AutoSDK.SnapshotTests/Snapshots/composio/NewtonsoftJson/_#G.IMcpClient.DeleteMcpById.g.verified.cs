//HintName: G.IMcpClient.DeleteMcpById.g.cs
#nullable enable

namespace G
{
    public partial interface IMcpClient
    {
        /// <summary>
        /// Delete an MCP server<br/>
        /// Performs a soft delete on a Model Control Protocol (MCP) server, making it unavailable for future use. This operation is reversible in the database but cannot be undone through the API. Any applications or services connected to this server will lose access after deletion.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the MCP server to retrieve, update, or delete<br/>
        /// Example: 550e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteMcpByIdResponse> DeleteMcpByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}