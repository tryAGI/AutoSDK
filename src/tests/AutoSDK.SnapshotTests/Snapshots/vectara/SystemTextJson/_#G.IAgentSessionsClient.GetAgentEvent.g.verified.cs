//HintName: G.IAgentSessionsClient.GetAgentEvent.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentSessionsClient
    {

        /// <summary>
        /// Get event in agent session<br/>
        /// Retrieve the details of a specific event within an agent session.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="sessionKey">
        /// A unique key that identifies an agent session.<br/>
        /// Example: customer_support_chat
        /// </param>
        /// <param name="eventId">
        /// Example: aev_user_001
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentEvent> GetAgentEventAsync(
            string agentKey,
            string sessionKey,
            string eventId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}