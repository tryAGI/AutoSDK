//HintName: G.IReposClient.ReposRemoveCollaborator.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Remove a repository collaborator<br/>
        /// Removes a collaborator from a repository.<br/>
        /// To use this endpoint, the authenticated user must either be an administrator of the repository or target themselves for removal.<br/>
        /// This endpoint also:<br/>
        /// - Cancels any outstanding invitations<br/>
        /// - Unasigns the user from any issues<br/>
        /// - Removes access to organization projects if the user is not an organization member and is not a collaborator on any other organization repositories.<br/>
        /// - Unstars the repository<br/>
        /// - Updates access permissions to packages<br/>
        /// Removing a user as a collaborator has the following effects on forks:<br/>
        ///  - If the user had access to a fork through their membership to this repository, the user will also be removed from the fork.<br/>
        ///  - If the user had their own fork of the repository, the fork will be deleted.<br/>
        ///  - If the user still has read access to the repository, open pull requests by this user from a fork will be denied.<br/>
        /// **Note**: A user can still have access to the repository through organization permissions like base repository permissions.<br/>
        /// Although the API responds immediately, the additional permission updates might take some extra time to complete in the background.<br/>
        /// For more information on fork permissions, see "[About permissions and visibility of forks](https://docs.github.com/pull-requests/collaborating-with-pull-requests/working-with-forks/about-permissions-and-visibility-of-forks)".
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ValidationError> ReposRemoveCollaboratorAsync(
            string owner,
            string repo,
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}