//HintName: G.IChecksClient.ChecksListForRef.g.cs
#nullable enable

namespace G
{
    public partial interface IChecksClient
    {
        /// <summary>
        /// List check runs for a Git reference<br/>
        /// Lists check runs for a commit ref. The `ref` can be a SHA, branch name, or a tag name.<br/>
        /// **Note:** The endpoints to manage checks only look for pushes in the repository where the check suite or check run were created. Pushes to a branch in a forked repository are not detected and return an empty `pull_requests` array.<br/>
        /// If there are more than 1000 check suites on a single git reference, this endpoint will limit check runs to the 1000 most recent check suites. To iterate over all possible check runs, use the [List check suites for a Git reference](https://docs.github.com/rest/reference/checks#list-check-suites-for-a-git-reference) endpoint and provide the `check_suite_id` parameter to the [List check runs in a check suite](https://docs.github.com/rest/reference/checks#list-check-runs-in-a-check-suite) endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint on a private repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="ref"></param>
        /// <param name="checkName"></param>
        /// <param name="status"></param>
        /// <param name="filter">
        /// Default Value: latest
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="appId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChecksListForRefResponse> ChecksListForRefAsync(
            string owner,
            string repo,
            string @ref,
            string? checkName = default,
            global::G.ChecksListForRefStatus? status = default,
            global::G.ChecksListForRefFilter? filter = global::G.ChecksListForRefFilter.Latest,
            int perPage = 30,
            int page = 1,
            int appId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}