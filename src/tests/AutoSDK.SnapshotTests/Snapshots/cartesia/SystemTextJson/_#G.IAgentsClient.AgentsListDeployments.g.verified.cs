//HintName: G.IAgentsClient.AgentsListDeployments.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List Deployments<br/>
        /// List of all deployments associated with an agent.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Deployment>> AgentsListDeploymentsAsync(
            global::G.AgentsListDeploymentsCartesiaVersion cartesiaVersion,
            string agentId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}