//HintName: G.IConversationsClient.CancelConversation.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Cancel Conversation<br/>
        /// Cancel runs associated with a conversation.<br/>
        /// Note: To cancel active runs, Redis is required.<br/>
        /// **Agent-direct mode**: Pass conversation_id="default" with agent_id query parameter<br/>
        /// to cancel runs for the agent's default conversation.<br/>
        /// **Deprecated**: Passing an agent ID as conversation_id still works but will be removed.
        /// </summary>
        /// <param name="conversationId">
        /// The conversation identifier. Can be a conversation ID ('conv-&lt;uuid4&gt;'), 'default' for agent-direct mode (with agent_id parameter), or an agent ID ('agent-&lt;uuid4&gt;') for backwards compatibility (deprecated).
        /// </param>
        /// <param name="agentId">
        /// Agent ID for agent-direct mode with 'default' conversation
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CancelConversationAsync(
            string conversationId,
            string? agentId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}