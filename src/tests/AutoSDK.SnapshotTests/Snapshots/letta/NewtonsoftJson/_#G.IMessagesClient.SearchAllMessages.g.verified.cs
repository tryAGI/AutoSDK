//HintName: G.IMessagesClient.SearchAllMessages.g.cs
#nullable enable

namespace G
{
    public partial interface IMessagesClient
    {
        /// <summary>
        /// Search All Messages<br/>
        /// Search messages across the organization with optional agent filtering.<br/>
        /// Returns messages with FTS/vector ranks and total RRF score.<br/>
        /// This is a cloud-only feature.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.SearchAllMessagesResponseItem>> SearchAllMessagesAsync(

            global::G.SearchAllMessagesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Search All Messages<br/>
        /// Search messages across the organization with optional agent filtering.<br/>
        /// Returns messages with FTS/vector ranks and total RRF score.<br/>
        /// This is a cloud-only feature.
        /// </summary>
        /// <param name="query">
        /// Text query for full-text search
        /// </param>
        /// <param name="searchMode">
        /// Search mode to use<br/>
        /// Default Value: hybrid
        /// </param>
        /// <param name="agentId">
        /// Filter messages by agent ID
        /// </param>
        /// <param name="conversationId">
        /// Filter messages by conversation ID
        /// </param>
        /// <param name="limit">
        /// Maximum number of results to return<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="startDate">
        /// Filter messages created after this date
        /// </param>
        /// <param name="endDate">
        /// Filter messages created on or before this date
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.SearchAllMessagesResponseItem>> SearchAllMessagesAsync(
            string query,
            global::G.SearchAllMessagesRequestSearchMode? searchMode = default,
            string? agentId = default,
            string? conversationId = default,
            int? limit = default,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}