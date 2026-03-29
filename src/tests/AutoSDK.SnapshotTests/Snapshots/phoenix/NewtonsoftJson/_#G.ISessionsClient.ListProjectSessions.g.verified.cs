//HintName: G.ISessionsClient.ListProjectSessions.g.cs
#nullable enable

namespace G
{
    public partial interface ISessionsClient
    {
        /// <summary>
        /// List sessions for a project
        /// </summary>
        /// <param name="projectIdentifier">
        /// The project identifier: either project ID or project name.
        /// </param>
        /// <param name="cursor">
        /// Cursor for pagination (session ID)
        /// </param>
        /// <param name="limit">
        /// The max number of sessions to return at a time.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="order">
        /// Sort order by ID: 'asc' (ascending) or 'desc' (descending).<br/>
        /// Default Value: asc
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetSessionsResponseBody> ListProjectSessionsAsync(
            string projectIdentifier,
            string? cursor = default,
            int? limit = default,
            global::G.ListProjectSessionsOrder? order = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}