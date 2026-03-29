//HintName: G.IConversationsClient.CompactConversation.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Compact Conversation<br/>
        /// Compact (summarize) a conversation's message history.<br/>
        /// This endpoint summarizes the in-context messages for a specific conversation,<br/>
        /// reducing the message count while preserving important context.<br/>
        /// **Agent-direct mode**: Pass conversation_id="default" with agent_id in request body<br/>
        /// to compact the agent's default conversation messages.<br/>
        /// **Deprecated**: Passing an agent ID as conversation_id still works but will be removed.
        /// </summary>
        /// <param name="conversationId">
        /// The conversation identifier. Can be a conversation ID ('conv-&lt;uuid4&gt;'), 'default' for agent-direct mode (with agent_id parameter), or an agent ID ('agent-&lt;uuid4&gt;') for backwards compatibility (deprecated).
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CompactionResponse> CompactConversationAsync(
            string conversationId,

            global::G.LettaServerRestApiRoutersV1ConversationsCompactionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Compact Conversation<br/>
        /// Compact (summarize) a conversation's message history.<br/>
        /// This endpoint summarizes the in-context messages for a specific conversation,<br/>
        /// reducing the message count while preserving important context.<br/>
        /// **Agent-direct mode**: Pass conversation_id="default" with agent_id in request body<br/>
        /// to compact the agent's default conversation messages.<br/>
        /// **Deprecated**: Passing an agent ID as conversation_id still works but will be removed.
        /// </summary>
        /// <param name="conversationId">
        /// The conversation identifier. Can be a conversation ID ('conv-&lt;uuid4&gt;'), 'default' for agent-direct mode (with agent_id parameter), or an agent ID ('agent-&lt;uuid4&gt;') for backwards compatibility (deprecated).
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CompactionResponse> CompactConversationAsync(
            string conversationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}