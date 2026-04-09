//HintName: G.IAgentsClient.AgentsSearchDeployedAgents.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Search Deployed Agents<br/>
        /// Search deployed agents
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentsSearchDeployedAgentsResponse> AgentsSearchDeployedAgentsAsync(

            global::G.AgentsSearchDeployedAgentsRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search Deployed Agents<br/>
        /// Search deployed agents
        /// </summary>
        /// <param name="search"></param>
        /// <param name="projectId"></param>
        /// <param name="combinator"></param>
        /// <param name="limit"></param>
        /// <param name="after"></param>
        /// <param name="sortBy"></param>
        /// <param name="ascending"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentsSearchDeployedAgentsResponse> AgentsSearchDeployedAgentsAsync(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant1, global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant2, global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant3, global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant4, global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant5, global::G.AgentsSearchDeployedAgentsRequestSearchItemVariant6>>? search = default,
            string? projectId = default,
            global::G.AgentsSearchDeployedAgentsRequestCombinator? combinator = default,
            double? limit = default,
            string? after = default,
            global::G.AgentsSearchDeployedAgentsRequestSortBy? sortBy = default,
            bool? ascending = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}