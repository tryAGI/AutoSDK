//HintName: G.IApi.ListAgents.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// List all agents
        /// </summary>
        /// <param name="limit">
        /// Example: 50
        /// </param>
        /// <param name="paginationKey">
        /// Example: agent_1ffdb9717444d0e77346838911
        /// </param>
        /// <param name="paginationKeyVersion">
        /// Example: 0
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.AgentResponse>> ListAgentsAsync(
            int? limit = default,
            string? paginationKey = default,
            int? paginationKeyVersion = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}