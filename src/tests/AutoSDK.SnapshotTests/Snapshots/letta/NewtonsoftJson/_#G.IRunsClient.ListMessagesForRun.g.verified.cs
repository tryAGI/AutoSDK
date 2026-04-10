//HintName: G.IRunsClient.ListMessagesForRun.g.cs
#nullable enable

namespace G
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// List Messages For Run<br/>
        /// Get response messages associated with a run.
        /// </summary>
        /// <param name="runId"></param>
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
        /// Default Value: asc
        /// </param>
        /// <param name="orderBy">
        /// Field to sort by<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.LettaMessageUnion>> ListMessagesForRunAsync(
            string runId,
            string? before = default,
            string? after = default,
            int? limit = default,
            global::G.ListMessagesForRunOrder? order = default,
            string? orderBy = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}