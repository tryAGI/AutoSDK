//HintName: G.IUsersClient.GetViewer.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get the authenticated user<br/>
        /// Returns the profile of the currently authenticated user. When authentication is disabled, returns an anonymous user representation.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetViewerResponseBody> GetViewerAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}