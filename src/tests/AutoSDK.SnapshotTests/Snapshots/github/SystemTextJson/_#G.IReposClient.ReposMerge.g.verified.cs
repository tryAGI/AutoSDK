//HintName: G.IReposClient.ReposMerge.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Merge a branch
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Commit> ReposMergeAsync(
            string owner,
            string repo,
            global::G.ReposMergeRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Merge a branch
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="base">
        /// The name of the base branch that the head will be merged into.
        /// </param>
        /// <param name="head">
        /// The head to merge. This can be a branch name or a commit SHA1.
        /// </param>
        /// <param name="commitMessage">
        /// Commit message to use for the merge commit. If omitted, a default message will be used.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Commit> ReposMergeAsync(
            string owner,
            string repo,
            string @base,
            string head,
            string? commitMessage = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}