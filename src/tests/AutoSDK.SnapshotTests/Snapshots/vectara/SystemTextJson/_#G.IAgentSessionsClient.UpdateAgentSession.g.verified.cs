//HintName: G.IAgentSessionsClient.UpdateAgentSession.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentSessionsClient
    {
        /// <summary>
        /// Update agent session<br/>
        /// Update the configuration of an existing agent session. This endpoint enables you to modify fields such as the name, description, or metadata.<br/>
        /// Updated metadata immediately influences agent behavior and becomes available to instructions and tools for the remainder of the session. For more details about configuring the agent session, see [Create agent session](https://docs.vectara.com/docs/rest-api/create-agent-session).
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
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentSession> UpdateAgentSessionAsync(
            string agentKey,
            string sessionKey,

            global::G.UpdateAgentSessionRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update agent session<br/>
        /// Update the configuration of an existing agent session. This endpoint enables you to modify fields such as the name, description, or metadata.<br/>
        /// Updated metadata immediately influences agent behavior and becomes available to instructions and tools for the remainder of the session. For more details about configuring the agent session, see [Create agent session](https://docs.vectara.com/docs/rest-api/create-agent-session).
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
        /// <param name="name">
        /// Human-readable name for the session.<br/>
        /// Example: Updated Session Name
        /// </param>
        /// <param name="description">
        /// Optional description of the session purpose or context.<br/>
        /// Example: Updated session description
        /// </param>
        /// <param name="metadata">
        /// Arbitrary metadata associated with the session.<br/>
        /// Example: {"customer_id":"12345","priority":"high","status":"escalated"}
        /// </param>
        /// <param name="enabled">
        /// Whether the session is enabled.<br/>
        /// Example: false
        /// </param>
        /// <param name="ttiMinutes">
        /// Time-to-idle in minutes for the session. If no events occur in the session for this duration, the session will be automatically deleted. If set to 0, the session will not expire.<br/>
        /// Example: 60
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentSession> UpdateAgentSessionAsync(
            string agentKey,
            string sessionKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? name = default,
            string? description = default,
            object? metadata = default,
            bool? enabled = default,
            long? ttiMinutes = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}