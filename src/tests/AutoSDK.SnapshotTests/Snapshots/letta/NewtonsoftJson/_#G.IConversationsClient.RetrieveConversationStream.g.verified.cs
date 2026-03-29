//HintName: G.IConversationsClient.RetrieveConversationStream.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// Retrieve Conversation Stream<br/>
        /// Resume the stream for the most recent active run in a conversation.<br/>
        /// This endpoint allows you to reconnect to an active background stream<br/>
        /// for a conversation, enabling recovery from network interruptions.<br/>
        /// **Agent-direct mode**: Pass conversation_id="default" with agent_id in request body<br/>
        /// to retrieve the stream for the agent's most recent active run.<br/>
        /// **Deprecated**: Passing an agent ID as conversation_id still works but will be removed.
        /// </summary>
        /// <param name="conversationId">
        /// The conversation identifier. Can be a conversation ID ('conv-&lt;uuid4&gt;'), 'default' for agent-direct mode (with agent_id parameter), or an agent ID ('agent-&lt;uuid4&gt;') for backwards compatibility (deprecated).
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RetrieveConversationStreamAsync(
            string conversationId,

            global::G.RetrieveStreamRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve Conversation Stream<br/>
        /// Resume the stream for the most recent active run in a conversation.<br/>
        /// This endpoint allows you to reconnect to an active background stream<br/>
        /// for a conversation, enabling recovery from network interruptions.<br/>
        /// **Agent-direct mode**: Pass conversation_id="default" with agent_id in request body<br/>
        /// to retrieve the stream for the agent's most recent active run.<br/>
        /// **Deprecated**: Passing an agent ID as conversation_id still works but will be removed.
        /// </summary>
        /// <param name="conversationId">
        /// The conversation identifier. Can be a conversation ID ('conv-&lt;uuid4&gt;'), 'default' for agent-direct mode (with agent_id parameter), or an agent ID ('agent-&lt;uuid4&gt;') for backwards compatibility (deprecated).
        /// </param>
        /// <param name="agentId">
        /// Agent ID for agent-direct mode with 'default' conversation. Use with conversation_id='default' in the URL path.
        /// </param>
        /// <param name="startingAfter">
        /// Sequence id to use as a cursor for pagination. Response will start streaming after this chunk sequence id<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="includePings">
        /// Whether to include periodic keepalive ping messages in the stream to prevent connection timeouts.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="pollInterval">
        /// Seconds to wait between polls when no new data.<br/>
        /// Default Value: 0.1F
        /// </param>
        /// <param name="batchSize">
        /// Number of entries to read per batch.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> RetrieveConversationStreamAsync(
            string conversationId,
            string? agentId = default,
            int? startingAfter = default,
            bool? includePings = default,
            double? pollInterval = default,
            int? batchSize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}