//HintName: G.IActionsClient.ActionsGetGithubActionsDefaultWorkflowPermissionsRepository.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Get default workflow permissions for a repository<br/>
        /// Gets the default workflow permissions granted to the `GITHUB_TOKEN` when running workflows in a repository,<br/>
        /// as well as if GitHub Actions can submit approving pull request reviews.<br/>
        /// For more information, see "[Setting the permissions of the GITHUB_TOKEN for your repository](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/enabling-features-for-your-repository/managing-github-actions-settings-for-a-repository#setting-the-permissions-of-the-github_token-for-your-repository)."<br/>
        /// OAuth tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ActionsGetDefaultWorkflowPermissions> ActionsGetGithubActionsDefaultWorkflowPermissionsRepositoryAsync(
            string owner,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}