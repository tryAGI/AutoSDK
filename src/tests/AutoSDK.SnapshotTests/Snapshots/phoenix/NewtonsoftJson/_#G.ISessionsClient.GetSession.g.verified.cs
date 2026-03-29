//HintName: G.ISessionsClient.GetSession.g.cs
#nullable enable

namespace G
{
    public partial interface ISessionsClient
    {
        /// <summary>
        /// Get session by ID or session_id
        /// </summary>
        /// <param name="sessionIdentifier">
        /// The session identifier: either a GlobalID or user-provided session_id string.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetSessionResponseBody> GetSessionAsync(
            string sessionIdentifier,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}