//HintName: G.IPullsClient.PullsRequestReviewers.g.cs
#nullable enable

namespace G
{
    public partial interface IPullsClient
    {
        /// <summary>
        /// Request reviewers for a pull request<br/>
        /// Requests reviews for a pull request from a given set of users and/or teams.<br/>
        /// This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. For more information, see "[Rate limits for the API](https://docs.github.com/rest/using-the-rest-api/rate-limits-for-the-rest-api#about-secondary-rate-limits)" and "[Best practices for using the REST API](https://docs.github.com/rest/guides/best-practices-for-using-the-rest-api)."
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="pullNumber"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PullRequestSimple> PullsRequestReviewersAsync(
            string owner,
            string repo,
            int pullNumber,
            global::G.PullsRequestReviewersRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Request reviewers for a pull request<br/>
        /// Requests reviews for a pull request from a given set of users and/or teams.<br/>
        /// This endpoint triggers [notifications](https://docs.github.com/github/managing-subscriptions-and-notifications-on-github/about-notifications). Creating content too quickly using this endpoint may result in secondary rate limiting. For more information, see "[Rate limits for the API](https://docs.github.com/rest/using-the-rest-api/rate-limits-for-the-rest-api#about-secondary-rate-limits)" and "[Best practices for using the REST API](https://docs.github.com/rest/guides/best-practices-for-using-the-rest-api)."
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="pullNumber"></param>
        /// <param name="reviewers">
        /// An array of user `login`s that will be requested.
        /// </param>
        /// <param name="teamReviewers">
        /// An array of team `slug`s that will be requested.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.PullRequestSimple> PullsRequestReviewersAsync(
            string owner,
            string repo,
            int pullNumber,
            global::System.Collections.Generic.IList<string>? reviewers = default,
            global::System.Collections.Generic.IList<string>? teamReviewers = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}