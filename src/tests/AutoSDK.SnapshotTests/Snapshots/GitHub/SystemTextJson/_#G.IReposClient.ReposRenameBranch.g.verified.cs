//HintName: G.IReposClient.ReposRenameBranch.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Rename a branch<br/>
        /// Renames a branch in a repository.<br/>
        /// **Note:** Although the API responds immediately, the branch rename process might take some extra time to complete in the background. You won't be able to push to the old branch name while the rename process is in progress. For more information, see "[Renaming a branch](https://docs.github.com/github/administering-a-repository/renaming-a-branch)".<br/>
        /// The authenticated user must have push access to the branch. If the branch is the default branch, the authenticated user must also have admin or owner permissions.<br/>
        /// In order to rename the default branch, fine-grained access tokens also need the `administration:write` repository permission.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="branch"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BranchWithProtection> ReposRenameBranchAsync(
            string owner,
            string repo,
            string branch,
            global::G.ReposRenameBranchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Rename a branch<br/>
        /// Renames a branch in a repository.<br/>
        /// **Note:** Although the API responds immediately, the branch rename process might take some extra time to complete in the background. You won't be able to push to the old branch name while the rename process is in progress. For more information, see "[Renaming a branch](https://docs.github.com/github/administering-a-repository/renaming-a-branch)".<br/>
        /// The authenticated user must have push access to the branch. If the branch is the default branch, the authenticated user must also have admin or owner permissions.<br/>
        /// In order to rename the default branch, fine-grained access tokens also need the `administration:write` repository permission.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="branch"></param>
        /// <param name="newName">
        /// The new name of the branch.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BranchWithProtection> ReposRenameBranchAsync(
            string owner,
            string repo,
            string branch,
            string newName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}