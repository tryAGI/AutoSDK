//HintName: G.IAgentsClient.GetAgent.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentsClient
    {

        /// <summary>
        /// Get agent<br/>
        /// The Get Agent API enables you to retrieve the complete configuration and operational details of a specific AI agent, providing comprehensive visibility into agent capabilities, tool integrations, behavioral instructions, and metadata.<br/>
        /// Use this API to inspect agent configurations before creating sessions, troubleshoot agent behavior issues, clone agent configurations for new deployments, and maintain documentation of agent capabilities across your enterprise AI infrastructure.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Agent> GetAgentAsync(
            string agentKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}