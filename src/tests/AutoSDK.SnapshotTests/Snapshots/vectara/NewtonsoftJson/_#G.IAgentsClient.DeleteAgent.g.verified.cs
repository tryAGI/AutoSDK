//HintName: G.IAgentsClient.DeleteAgent.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {

        /// <summary>
        /// Delete agent<br/>
        /// The Delete Agent API enables you to permanently remove an AI agent and its configuration from the Vectara platform, supporting agent lifecycle management and resource cleanup in enterprise environments.<br/>
        /// Use this API for decommissioning outdated agents, cleaning up development and testing environments, removing agents that are no longer needed, and maintaining organized agent inventories as your AI deployments evolve. The permanent nature of deletion makes this API critical for environments where data governance and resource management are essential.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAgentAsync(
            string agentKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}