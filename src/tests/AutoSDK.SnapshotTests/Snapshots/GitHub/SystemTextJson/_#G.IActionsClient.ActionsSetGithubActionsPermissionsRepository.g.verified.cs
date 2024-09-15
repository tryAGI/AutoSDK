//HintName: G.IActionsClient.ActionsSetGithubActionsPermissionsRepository.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Set GitHub Actions permissions for a repository<br/>
        /// Sets the GitHub Actions permissions policy for enabling GitHub Actions and allowed actions and reusable workflows in the repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ActionsSetGithubActionsPermissionsRepositoryAsync(
            string owner,
            string repo,
            global::G.ActionsSetGithubActionsPermissionsRepositoryRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set GitHub Actions permissions for a repository<br/>
        /// Sets the GitHub Actions permissions policy for enabling GitHub Actions and allowed actions and reusable workflows in the repository.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="enabled">
        /// Whether GitHub Actions is enabled on the repository.
        /// </param>
        /// <param name="allowedActions">
        /// The permissions policy that controls the actions and reusable workflows that are allowed to run.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ActionsSetGithubActionsPermissionsRepositoryAsync(
            string owner,
            string repo,
            bool enabled,
            global::G.AllowedActions? allowedActions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}