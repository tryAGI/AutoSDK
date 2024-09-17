//HintName: G.IReposClient.ReposCreateFork.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Create a fork<br/>
        /// Create a fork for the authenticated user.<br/>
        /// **Note**: Forking a Repository happens asynchronously. You may have to wait a short period of time before you can access the git objects. If this takes longer than 5 minutes, be sure to contact [GitHub Support](https://support.github.com/contact?tags=dotcom-rest-api).<br/>
        /// **Note**: Although this endpoint works with GitHub Apps, the GitHub App must be installed on the destination account with access to all repositories and on the source account with access to the source repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FullRepository> ReposCreateForkAsync(
            string owner,
            string repo,
            global::G.ReposCreateForkRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a fork<br/>
        /// Create a fork for the authenticated user.<br/>
        /// **Note**: Forking a Repository happens asynchronously. You may have to wait a short period of time before you can access the git objects. If this takes longer than 5 minutes, be sure to contact [GitHub Support](https://support.github.com/contact?tags=dotcom-rest-api).<br/>
        /// **Note**: Although this endpoint works with GitHub Apps, the GitHub App must be installed on the destination account with access to all repositories and on the source account with access to the source repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="organization">
        /// Optional parameter to specify the organization name if forking into an organization.
        /// </param>
        /// <param name="name">
        /// When forking from an existing repository, a new name for the fork.
        /// </param>
        /// <param name="defaultBranchOnly">
        /// When forking from an existing repository, fork with only the default branch.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FullRepository> ReposCreateForkAsync(
            string owner,
            string repo,
            string? organization = default,
            string? name = default,
            bool? defaultBranchOnly = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}