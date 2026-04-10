//HintName: G.IConversationsClient.ListConversationMessages.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationsClient
    {
        /// <summary>
        /// List Conversation Messages<br/>
        /// List all messages in a conversation.<br/>
        /// Returns LettaMessage objects (UserMessage, AssistantMessage, etc.) for all<br/>
        /// messages in the conversation, with support for cursor-based pagination.<br/>
        /// **Agent-direct mode**: Pass conversation_id="default" with agent_id parameter<br/>
        /// to list messages from the agent's default conversation.<br/>
        /// **Deprecated**: Passing an agent ID as conversation_id still works but will be removed.
        /// </summary>
        /// <param name="conversationId">
        /// The conversation identifier. Can be a conversation ID ('conv-&lt;uuid4&gt;'), 'default' for agent-direct mode (with agent_id parameter), or an agent ID ('agent-&lt;uuid4&gt;') for backwards compatibility (deprecated).
        /// </param>
        /// <param name="agentId">
        /// Agent ID for agent-direct mode with 'default' conversation
        /// </param>
        /// <param name="before">
        /// Message ID cursor for pagination. Returns messages that come before this message ID in the specified sort order
        /// </param>
        /// <param name="after">
        /// Message ID cursor for pagination. Returns messages that come after this message ID in the specified sort order
        /// </param>
        /// <param name="limit">
        /// Maximum number of messages to return<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="order">
        /// Sort order for messages by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="orderBy">
        /// Field to sort by<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="groupId">
        /// Group ID to filter messages by.
        /// </param>
        /// <param name="includeErr">
        /// Whether to include error messages and error statuses. For debugging purposes only.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.LettaMessageUnion>> ListConversationMessagesAsync(
            string conversationId,
            string? agentId = default,
            string? before = default,
            string? after = default,
            int? limit = default,
            global::G.ListConversationMessagesOrder? order = default,
            string? orderBy = default,
            string? groupId = default,
            bool? includeErr = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}