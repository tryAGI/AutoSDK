//HintName: G.IAgentSessionsClient.DeleteAgentSession.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentSessionsClient
    {
        /// <summary>
        /// Delete agent session<br/>
        /// Permanently delete an agent session. This action cannot be undone.
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
        global::System.Threading.Tasks.Task DeleteAgentSessionAsync(
            string agentKey,
            string sessionKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}