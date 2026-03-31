//HintName: G.IAgentsClient.ListMyAgents.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List Agents<br/>
        /// Returns a list of all Agents.
        /// </summary>
        /// <param name="sortBy"></param>
        /// <param name="order"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="token"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListMyAgentsResponse> ListMyAgentsAsync(
            global::G.ListMyAgentsSortBy? sortBy = default,
            global::G.ListMyAgentsOrder? order = default,
            double? limit = default,
            string? token = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}