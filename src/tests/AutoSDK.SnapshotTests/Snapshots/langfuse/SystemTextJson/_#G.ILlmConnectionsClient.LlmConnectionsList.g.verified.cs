//HintName: G.ILlmConnectionsClient.LlmConnectionsList.g.cs
#nullable enable

namespace G
{
    public partial interface ILlmConnectionsClient
    {
        /// <summary>
        /// Get all LLM connections in a project
        /// </summary>
        /// <param name="page"></param>
        /// <param name="limit"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedLlmConnections> LlmConnectionsListAsync(
            int? page = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}