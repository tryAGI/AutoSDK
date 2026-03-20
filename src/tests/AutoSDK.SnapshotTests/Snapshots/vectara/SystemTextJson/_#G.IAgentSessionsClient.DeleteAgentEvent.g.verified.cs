//HintName: G.IAgentSessionsClient.DeleteAgentEvent.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentSessionsClient
    {

        /// <summary>
        /// Delete event<br/>
        /// Permanently delete an event from a session. Removes the event from both the metadata database and the encrypted event store.
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
        /// <param name="eventId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAgentEventAsync(
            string agentKey,
            string sessionKey,
            string eventId,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}