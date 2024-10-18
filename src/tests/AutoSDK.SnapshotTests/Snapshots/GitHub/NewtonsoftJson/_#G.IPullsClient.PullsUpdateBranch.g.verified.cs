//HintName: G.IPullsClient.PullsUpdateBranch.g.cs
#nullable enable

namespace G
{
    public partial interface IPullsClient
    {
        /// <summary>
        /// Update a pull request branch<br/>
        /// Updates the pull request branch with the latest upstream changes by merging HEAD from the base branch into the pull request branch.<br/>
        /// Note: If making a request on behalf of a GitHub App you must also have permissions to write the contents of the head repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="pullNumber"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PullsUpdateBranchResponse> PullsUpdateBranchAsync(
            string owner,
            string repo,
            int pullNumber,
            global::G.PullsUpdateBranchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a pull request branch<br/>
        /// Updates the pull request branch with the latest upstream changes by merging HEAD from the base branch into the pull request branch.<br/>
        /// Note: If making a request on behalf of a GitHub App you must also have permissions to write the contents of the head repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="pullNumber"></param>
        /// <param name="expectedHeadSha">
        /// The expected SHA of the pull request's HEAD ref. This is the most recent commit on the pull request's branch. If the expected SHA does not match the pull request's HEAD, you will receive a `422 Unprocessable Entity` status. You can use the "[List commits](https://docs.github.com/rest/commits/commits#list-commits)" endpoint to find the most recent commit SHA. Default: SHA of the pull request's current HEAD ref.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PullsUpdateBranchResponse> PullsUpdateBranchAsync(
            string owner,
            string repo,
            int pullNumber,
            string? expectedHeadSha = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}