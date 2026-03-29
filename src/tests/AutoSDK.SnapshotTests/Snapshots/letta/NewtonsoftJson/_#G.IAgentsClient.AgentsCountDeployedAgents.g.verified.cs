//HintName: G.IAgentsClient.AgentsCountDeployedAgents.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Count Deployed Agents<br/>
        /// Count deployed agents matching search criteria
        /// </summary>
        /// <param name="search"></param>
        /// <param name="projectId"></param>
        /// <param name="combinator"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentsCountDeployedAgentsResponse> AgentsCountDeployedAgentsAsync(
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.AgentsCountDeployedAgentsSearchItemVariant1, global::G.AgentsCountDeployedAgentsSearchItemVariant2, global::G.AgentsCountDeployedAgentsSearchItemVariant3, global::G.AgentsCountDeployedAgentsSearchItemVariant4, global::G.AgentsCountDeployedAgentsSearchItemVariant5, global::G.AgentsCountDeployedAgentsSearchItemVariant6>>? search = default,
            string? projectId = default,
            global::G.AgentsCountDeployedAgentsCombinator? combinator = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}