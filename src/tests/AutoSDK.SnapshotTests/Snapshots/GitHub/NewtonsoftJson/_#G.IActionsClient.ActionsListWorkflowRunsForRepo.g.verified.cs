//HintName: G.IActionsClient.ActionsListWorkflowRunsForRepo.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// List workflow runs for a repository<br/>
        /// Lists all workflow runs for a repository. You can use parameters to narrow the list of results. For more information about using parameters, see [Parameters](https://docs.github.com/rest/guides/getting-started-with-the-rest-api#parameters).<br/>
        /// Anyone with read access to the repository can use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.<br/>
        /// This API will return up to 1,000 results for each search when using the following parameters: `actor`, `branch`, `check_suite_id`, `created`, `event`, `head_sha`, `status`.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="actor"></param>
        /// <param name="branch"></param>
        /// <param name="event"></param>
        /// <param name="status"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="created"></param>
        /// <param name="excludePullRequests">
        /// Default Value: false
        /// </param>
        /// <param name="checkSuiteId"></param>
        /// <param name="headSha"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ActionsListWorkflowRunsForRepoResponse> ActionsListWorkflowRunsForRepoAsync(
            string owner,
            string repo,
            string? actor = default,
            string? branch = default,
            string? @event = default,
            global::G.ActionsListWorkflowRunsForRepoStatus? status = default,
            int? perPage = default,
            int? page = default,
            global::System.DateTime? created = default,
            bool? excludePullRequests = default,
            int? checkSuiteId = default,
            string? headSha = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}