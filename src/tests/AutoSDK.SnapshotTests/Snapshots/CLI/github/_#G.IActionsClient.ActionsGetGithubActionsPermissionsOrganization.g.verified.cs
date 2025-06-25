//HintName: G.IActionsClient.ActionsGetGithubActionsPermissionsOrganization.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Get GitHub Actions permissions for an organization<br/>
        /// Gets the GitHub Actions permissions policy for repositories and allowed actions and reusable workflows in an organization.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `admin:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ActionsOrganizationPermissions> ActionsGetGithubActionsPermissionsOrganizationAsync(
            string org,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}