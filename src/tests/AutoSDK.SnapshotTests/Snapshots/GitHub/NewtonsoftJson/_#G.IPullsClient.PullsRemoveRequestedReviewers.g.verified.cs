//HintName: G.IPullsClient.PullsRemoveRequestedReviewers.g.cs
#nullable enable

namespace G
{
    public partial interface IPullsClient
    {
        /// <summary>
        /// Remove requested reviewers from a pull request<br/>
        /// Removes review requests from a pull request for a given set of users and/or teams.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="pullNumber"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PullRequestSimple> PullsRemoveRequestedReviewersAsync(
            string owner,
            string repo,
            int pullNumber,
            global::G.PullsRemoveRequestedReviewersRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Remove requested reviewers from a pull request<br/>
        /// Removes review requests from a pull request for a given set of users and/or teams.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="pullNumber"></param>
        /// <param name="reviewers">
        /// An array of user `login`s that will be removed.
        /// </param>
        /// <param name="teamReviewers">
        /// An array of team `slug`s that will be removed.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PullRequestSimple> PullsRemoveRequestedReviewersAsync(
            string owner,
            string repo,
            int pullNumber,
            global::System.Collections.Generic.IList<string> reviewers,
            global::System.Collections.Generic.IList<string>? teamReviewers = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}