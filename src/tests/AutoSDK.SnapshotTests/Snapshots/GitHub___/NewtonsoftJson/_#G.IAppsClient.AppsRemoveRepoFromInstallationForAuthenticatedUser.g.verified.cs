//HintName: G.IAppsClient.AppsRemoveRepoFromInstallationForAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// Remove a repository from an app installation<br/>
        /// Remove a single repository from an installation. The authenticated user must have admin access to the repository. The installation must have the `repository_selection` of `selected`. <br/>
        /// This endpoint only works for PATs (classic) with the `repo` scope.
        /// </summary>
        /// <param name="installationId"></param>
        /// <param name="repositoryId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task AppsRemoveRepoFromInstallationForAuthenticatedUserAsync(
            int installationId,
            int repositoryId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}