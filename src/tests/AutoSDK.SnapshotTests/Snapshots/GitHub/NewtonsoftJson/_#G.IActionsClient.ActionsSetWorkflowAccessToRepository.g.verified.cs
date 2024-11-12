//HintName: G.IActionsClient.ActionsSetWorkflowAccessToRepository.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Set the level of access for workflows outside of the repository<br/>
        /// Sets the level of access that workflows outside of the repository have to actions and reusable workflows in the repository.<br/>
        /// This endpoint only applies to private repositories.<br/>
        /// For more information, see "[Allowing access to components in a private repository](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/enabling-features-for-your-repository/managing-github-actions-settings-for-a-repository#allowing-access-to-components-in-a-private-repository)".<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ActionsSetWorkflowAccessToRepositoryAsync(
            string owner,
            string repo,
            global::G.ActionsWorkflowAccessToRepository request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Set the level of access for workflows outside of the repository<br/>
        /// Sets the level of access that workflows outside of the repository have to actions and reusable workflows in the repository.<br/>
        /// This endpoint only applies to private repositories.<br/>
        /// For more information, see "[Allowing access to components in a private repository](https://docs.github.com/repositories/managing-your-repositorys-settings-and-features/enabling-features-for-your-repository/managing-github-actions-settings-for-a-repository#allowing-access-to-components-in-a-private-repository)".<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="accessLevel">
        /// Defines the level of access that workflows outside of the repository have to actions and reusable workflows within the<br/>
        /// repository.<br/>
        /// `none` means the access is only possible from workflows in this repository. `user` level access allows sharing across user owned private repositories only. `organization` level access allows sharing across the organization.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task ActionsSetWorkflowAccessToRepositoryAsync(
            string owner,
            string repo,
            global::G.ActionsWorkflowAccessToRepositoryAccessLevel accessLevel,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}