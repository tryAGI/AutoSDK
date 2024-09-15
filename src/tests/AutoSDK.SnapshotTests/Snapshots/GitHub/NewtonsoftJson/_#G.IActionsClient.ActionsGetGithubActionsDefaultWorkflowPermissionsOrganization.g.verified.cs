//HintName: G.IActionsClient.ActionsGetGithubActionsDefaultWorkflowPermissionsOrganization.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Get default workflow permissions for an organization<br/>
        /// Gets the default workflow permissions granted to the `GITHUB_TOKEN` when running workflows in an organization,<br/>
        /// as well as whether GitHub Actions can submit approving pull request reviews. For more information, see<br/>
        /// "[Setting the permissions of the GITHUB_TOKEN for your organization](https://docs.github.com/organizations/managing-organization-settings/disabling-or-limiting-github-actions-for-your-organization#setting-the-permissions-of-the-github_token-for-your-organization)."<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ActionsGetDefaultWorkflowPermissions> ActionsGetGithubActionsDefaultWorkflowPermissionsOrganizationAsync(
            string org,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}