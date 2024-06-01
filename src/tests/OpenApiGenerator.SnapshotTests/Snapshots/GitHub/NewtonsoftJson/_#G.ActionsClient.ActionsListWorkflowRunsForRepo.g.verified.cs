//HintName: G.ActionsClient.ActionsListWorkflowRunsForRepo.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        /// <summary>
        /// List workflow runs for a repository
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="actor"></param>
        /// <param name="branch"></param>
        /// <param name="@event"></param>
        /// <param name="status"></param>
        /// <param name="perPage"></param>
        /// <param name="page"></param>
        /// <param name="created"></param>
        /// <param name="excludePullRequests"></param>
        /// <param name="checkSuiteId"></param>
        /// <param name="headSha"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ActionsListWorkflowRunsForRepoResponse> ActionsListWorkflowRunsForRepoAsync(
            string owner,
            string repo,
            string actor,
            string branch,
            string @event,
            ActionsListWorkflowRunsForRepoStatus status,
            int perPage,
            int page,
            global::System.DateTime created,
            bool excludePullRequests,
            int checkSuiteId,
            string headSha,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var statusValue = status switch
            {
                ActionsListWorkflowRunsForRepoStatus.Completed => "completed",
                ActionsListWorkflowRunsForRepoStatus.ActionRequired => "action_required",
                ActionsListWorkflowRunsForRepoStatus.Cancelled => "cancelled",
                ActionsListWorkflowRunsForRepoStatus.Failure => "failure",
                ActionsListWorkflowRunsForRepoStatus.Neutral => "neutral",
                ActionsListWorkflowRunsForRepoStatus.Skipped => "skipped",
                ActionsListWorkflowRunsForRepoStatus.Stale => "stale",
                ActionsListWorkflowRunsForRepoStatus.Success => "success",
                ActionsListWorkflowRunsForRepoStatus.TimedOut => "timed_out",
                ActionsListWorkflowRunsForRepoStatus.InProgress => "in_progress",
                ActionsListWorkflowRunsForRepoStatus.Queued => "queued",
                ActionsListWorkflowRunsForRepoStatus.Requested => "requested",
                ActionsListWorkflowRunsForRepoStatus.Waiting => "waiting",
                ActionsListWorkflowRunsForRepoStatus.Pending => "pending",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/actions/runs?actor={actor}&branch={branch}&event={@event}&status={statusValue}&per_page={perPage}&page={page}&created={created}&exclude_pull_requests={excludePullRequests}&check_suite_id={checkSuiteId}&head_sha={headSha}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<ActionsListWorkflowRunsForRepoResponse?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}