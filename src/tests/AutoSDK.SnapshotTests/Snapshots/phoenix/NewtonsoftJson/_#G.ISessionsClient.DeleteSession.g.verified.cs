//HintName: G.ISessionsClient.DeleteSession.g.cs
#nullable enable

namespace G
{
    public partial interface ISessionsClient
    {
        /// <summary>
        /// Delete a session by identifier<br/>
        /// Delete a session by its identifier. The identifier can be either:<br/>
        /// 1. A global ID (base64-encoded)<br/>
        /// 2. A user-provided session_id string<br/>
        /// This will permanently remove the session and all associated traces, spans, and annotations via cascade delete.
        /// </summary>
        /// <param name="sessionIdentifier">
        /// The session identifier: either a GlobalID or user-provided session_id string.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteSessionAsync(
            string sessionIdentifier,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}