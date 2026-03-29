//HintName: G.IMessagesClient.ListAllMessages.g.cs
#nullable enable

namespace G
{
    public partial interface IMessagesClient
    {
        /// <summary>
        /// List All Messages<br/>
        /// List messages across all agents for the current user.
        /// </summary>
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
        /// <param name="conversationId">
        /// Conversation ID to filter messages by
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.LettaMessageUnion>> ListAllMessagesAsync(
            string? before = default,
            string? after = default,
            int? limit = default,
            global::G.ListAllMessagesOrder? order = default,
            string? conversationId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}