//HintName: G.IAgentsClient.ListMessages.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface IAgentsClient
    {
        /// <summary>
        /// List Messages<br/>
        /// Retrieve message history for an agent.
        /// </summary>
        /// <param name="agentId">
        /// The ID of the agent in the format 'agent-&lt;uuid4&gt;'
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
        /// <param name="conversationId">
        /// Conversation ID to filter messages by.
        /// </param>
        /// <param name="useAssistantMessage">
        /// Whether to use assistant messages<br/>
        /// Default Value: true
        /// </param>
        /// <param name="assistantMessageToolName">
        /// The name of the designated message tool.<br/>
        /// Default Value: send_message
        /// </param>
        /// <param name="assistantMessageToolKwarg">
        /// The name of the message argument.<br/>
        /// Default Value: message
        /// </param>
        /// <param name="includeErr">
        /// Whether to include error messages and error statuses. For debugging purposes only.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.LettaMessageUnion>> ListMessagesAsync(
            string agentId,
            string? before = default,
            string? after = default,
            int? limit = default,
            global::G.ListMessagesOrder? order = default,
            string? orderBy = default,
            string? groupId = default,
            string? conversationId = default,
            bool? useAssistantMessage = default,
            string? assistantMessageToolName = default,
            string? assistantMessageToolKwarg = default,
            bool? includeErr = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}