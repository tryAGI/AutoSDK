//HintName: G.IAgentsPlatformClient.CreateConvaiAgentsByAgentIdDeployments.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsPlatformClient
    {
        /// <summary>
        /// Create Or Update Deployments<br/>
        /// Create a new deployment for an agent
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentDeploymentResponse> CreateConvaiAgentsByAgentIdDeploymentsAsync(
            string agentId,

            global::G.BodyCreateOrUpdateDeploymentsV1ConvaiAgentsAgentIdDeploymentsPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Or Update Deployments<br/>
        /// Create a new deployment for an agent
        /// </summary>
        /// <param name="agentId">
        /// The id of an agent. This is returned on agent creation.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="deploymentRequest">
        /// Request to create a new deployment
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentDeploymentResponse> CreateConvaiAgentsByAgentIdDeploymentsAsync(
            string agentId,
            global::G.AgentDeploymentRequest deploymentRequest,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}