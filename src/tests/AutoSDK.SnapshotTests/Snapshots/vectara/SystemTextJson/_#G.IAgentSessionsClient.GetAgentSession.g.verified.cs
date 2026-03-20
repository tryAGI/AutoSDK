//HintName: G.IAgentSessionsClient.GetAgentSession.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentSessionsClient
    {

        /// <summary>
        /// Get agent session<br/>
        /// Retrieve the full details of a specific agent session using its unique session key. The response includes the session's configuration, metadata, timestamps, and other stored properties. Use this endpoint to inspect the current state of a session or verify its configuration.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentSession> GetAgentSessionAsync(
            string agentKey,
            string sessionKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}