//HintName: G.IAgentsClient.SetAgentDeployment.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// Set Agent Deployment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="environmentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentResponse> SetAgentDeploymentAsync(
            string id,
            string environmentId,

            global::G.SetDeploymentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set Agent Deployment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="environmentId"></param>
        /// <param name="versionId">
        /// Version ID to deploy.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentResponse> SetAgentDeploymentAsync(
            string id,
            string environmentId,
            string versionId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}