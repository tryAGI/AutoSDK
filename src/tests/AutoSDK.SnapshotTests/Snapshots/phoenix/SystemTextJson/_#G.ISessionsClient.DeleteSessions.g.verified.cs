//HintName: G.ISessionsClient.DeleteSessions.g.cs
#nullable enable

namespace G
{
    public partial interface ISessionsClient
    {
        /// <summary>
        /// Bulk delete sessions<br/>
        /// Delete multiple sessions by their identifiers (GlobalIDs or session_id strings). All identifiers in a single request must be the same type. Non-existent IDs are silently skipped. All associated traces, spans, and annotations are cascade deleted.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteSessionsAsync(

            global::G.DeleteSessionsRequestBody request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk delete sessions<br/>
        /// Delete multiple sessions by their identifiers (GlobalIDs or session_id strings). All identifiers in a single request must be the same type. Non-existent IDs are silently skipped. All associated traces, spans, and annotations are cascade deleted.
        /// </summary>
        /// <param name="sessionIdentifiers">
        /// List of session identifiers to delete. All identifiers must be the same type: either all GlobalIDs or all user-provided session_id strings.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task DeleteSessionsAsync(
            global::System.Collections.Generic.IList<string> sessionIdentifiers,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}