//HintName: G.IAgentSessionsClient.CreateAgentSession.g.cs
#nullable enable

namespace G
{
    public partial interface IAgentSessionsClient
    {
        /// <summary>
        /// Create agent session<br/>
        /// Create a new session for interacting with an agent. A session is the conversation container that maintains state across all messages, events, tool use, and agent responses.<br/>
        /// This endpoint initializes the session and enables you to configure its initial properties, including optional metadata. Metadata can influence agent behavior, personalize responses, or apply access controls. Instructions and tools can also reference metadata using `${\session.metadata.field}` or `$\ref` syntax.<br/>
        /// A session also serves as the workspace for artifacts, enabling file uploads and multi-step workflows. For more information, see [Working with artifacts in sessions](https://docs.vectara.com/docs/agent-os/sessions#working-with-artifacts-in-sessions).<br/>
        /// ## Example request<br/>
        /// ```json<br/>
        /// \$ curl -X POST https://api.vectara.io/v2/agents/support-agent/sessions \<br/>
        /// -H "Authorization: Bearer YOUR_API_KEY" \<br/>
        /// -H "Content-Type: application/json" \<br/>
        /// -d '{<br/>
        ///   "key": "user_12345_session",<br/>
        ///   "name": "Customer Support Session",<br/>
        ///   "metadata": {<br/>
        ///     "user_role": "premium",<br/>
        ///     "language": "en"<br/>
        ///   }<br/>
        /// }'<br/>
        /// ```<br/>
        /// A successful response includes the unique session key, configuration metadata, and timestamps for creation and last update.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentSession> CreateAgentSessionAsync(
            string agentKey,

            global::G.CreateAgentSessionRequest request,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create agent session<br/>
        /// Create a new session for interacting with an agent. A session is the conversation container that maintains state across all messages, events, tool use, and agent responses.<br/>
        /// This endpoint initializes the session and enables you to configure its initial properties, including optional metadata. Metadata can influence agent behavior, personalize responses, or apply access controls. Instructions and tools can also reference metadata using `${\session.metadata.field}` or `$\ref` syntax.<br/>
        /// A session also serves as the workspace for artifacts, enabling file uploads and multi-step workflows. For more information, see [Working with artifacts in sessions](https://docs.vectara.com/docs/agent-os/sessions#working-with-artifacts-in-sessions).<br/>
        /// ## Example request<br/>
        /// ```json<br/>
        /// \$ curl -X POST https://api.vectara.io/v2/agents/support-agent/sessions \<br/>
        /// -H "Authorization: Bearer YOUR_API_KEY" \<br/>
        /// -H "Content-Type: application/json" \<br/>
        /// -d '{<br/>
        ///   "key": "user_12345_session",<br/>
        ///   "name": "Customer Support Session",<br/>
        ///   "metadata": {<br/>
        ///     "user_role": "premium",<br/>
        ///     "language": "en"<br/>
        ///   }<br/>
        /// }'<br/>
        /// ```<br/>
        /// A successful response includes the unique session key, configuration metadata, and timestamps for creation and last update.
        /// </summary>
        /// <param name="requestTimeout"></param>
        /// <param name="requestTimeoutMillis"></param>
        /// <param name="agentKey">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="key">
        /// A unique key that identifies an agent session.<br/>
        /// Example: customer_support_chat
        /// </param>
        /// <param name="name">
        /// Human-readable name for the session.<br/>
        /// Example: Customer Support Session
        /// </param>
        /// <param name="description">
        /// Optional description of the session purpose or context.<br/>
        /// Example: Helping customer troubleshoot issues
        /// </param>
        /// <param name="metadata">
        /// Arbitrary metadata associated with the session.<br/>
        /// Default Value: {}<br/>
        /// Example: {"customer_id":"12345","priority":"medium","channel":"web_chat"}
        /// </param>
        /// <param name="enabled">
        /// Whether the session should be enabled upon creation.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="ttiMinutes">
        /// Time-to-idle in minutes for the session. If no events occur in the session for this duration, the session will be automatically deleted. If set to 0, the session will not expire.<br/>
        /// Default Value: 0<br/>
        /// Example: 60
        /// </param>
        /// <param name="fromSession">
        /// Create a new session by forking an existing one. Compacts the source history into a summary and copies artifacts.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AgentSession> CreateAgentSessionAsync(
            string agentKey,
            int? requestTimeout = default,
            int? requestTimeoutMillis = default,
            string? key = default,
            string? name = default,
            string? description = default,
            object? metadata = default,
            bool? enabled = default,
            long? ttiMinutes = default,
            global::G.CreateAgentSessionRequestFromSession? fromSession = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}