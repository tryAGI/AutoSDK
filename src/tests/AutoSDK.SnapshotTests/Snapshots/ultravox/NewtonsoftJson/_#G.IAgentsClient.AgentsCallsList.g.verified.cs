//HintName: G.IAgentsClient.AgentsCallsList.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="cursor"></param>
        /// <param name="pageSize"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedCallList> AgentsCallsListAsync(
            global::System.Guid agentId,
            string? cursor = default,
            int? pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}