//HintName: G.IReposClient.ReposListPullRequestsAssociatedWithCommit.g.cs
#nullable enable

namespace G
{
    public partial interface IReposClient
    {
        /// <summary>
        /// List pull requests associated with a commit<br/>
        /// Lists the merged pull request that introduced the commit to the repository. If the commit is not present in the default branch, will only return open pull requests associated with the commit.<br/>
        /// To list the open or merged pull requests associated with a branch, you can set the `commit_sha` parameter to the branch name.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="commitSha"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.PullRequestSimple>> ReposListPullRequestsAssociatedWithCommitAsync(
            string owner,
            string repo,
            string commitSha,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}