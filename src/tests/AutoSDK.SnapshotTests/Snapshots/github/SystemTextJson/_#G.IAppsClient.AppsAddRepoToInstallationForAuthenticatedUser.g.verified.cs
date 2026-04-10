//HintName: G.IAppsClient.AppsAddRepoToInstallationForAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// Add a repository to an app installation<br/>
        /// Add a single repository to an installation. The authenticated user must have admin access to the repository.    <br/>
        /// This endpoint only works for PATs (classic) with the `repo` scope.
        /// </summary>
        /// <param name="installationId"></param>
        /// <param name="repositoryId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task AppsAddRepoToInstallationForAuthenticatedUserAsync(
            int installationId,
            int repositoryId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}