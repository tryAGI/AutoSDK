//HintName: G.IAppsClient.AppsListInstallationReposForAuthenticatedUser.g.cs
#nullable enable

namespace G
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// List repositories accessible to the user access token<br/>
        /// List repositories that the authenticated user has explicit permission (`:read`, `:write`, or `:admin`) to access for an installation.<br/>
        /// The authenticated user has explicit permission to access repositories they own, repositories where they are a collaborator, and repositories that they can access through an organization membership.<br/>
        /// The access the user has to each repository is included in the hash under the `permissions` key.
        /// </summary>
        /// <param name="installationId"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AppsListInstallationReposForAuthenticatedUserResponse> AppsListInstallationReposForAuthenticatedUserAsync(
            int installationId,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}