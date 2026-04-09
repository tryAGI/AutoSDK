//HintName: G.IActivityClient.ActivityUnstarRepoForAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface IActivityClient
    {
        /// <summary>
        /// Unstar a repository for the authenticated user<br/>
        /// Unstar a repository that the authenticated user has previously starred.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ActivityUnstarRepoForAuthenticatedUserAsync(
            string owner,
            string repo,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}