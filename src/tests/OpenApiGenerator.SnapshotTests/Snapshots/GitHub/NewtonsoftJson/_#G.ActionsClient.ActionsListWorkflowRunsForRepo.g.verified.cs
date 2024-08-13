//HintName: G.ActionsClient.ActionsListWorkflowRunsForRepo.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        partial void PrepareActionsListWorkflowRunsForRepoArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref string? actor,
            ref string? branch,
            ref string? @event,
            ref global::G.ActionsListWorkflowRunsForRepoStatus? status,
            ref int perPage,
            ref int page,
            global::System.DateTime created,
            ref bool excludePullRequests,
            ref int checkSuiteId,
            ref string? headSha);
        partial void PrepareActionsListWorkflowRunsForRepoRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            string? actor,
            string? branch,
            string? @event,
            global::G.ActionsListWorkflowRunsForRepoStatus? status,
            int perPage,
            int page,
            global::System.DateTime created,
            bool excludePullRequests,
            int checkSuiteId,
            string? headSha);
        partial void ProcessActionsListWorkflowRunsForRepoResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessActionsListWorkflowRunsForRepoResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::G.ActionsListWorkflowRunsForRepoResponse> ActionsListWorkflowRunsForRepoAsync(
            string owner,
            string repo,
            string? actor,
            string? branch,
            string? @event,
            global::G.ActionsListWorkflowRunsForRepoStatus? status,
            int perPage,
            int page,
            global::System.DateTime created,
            bool excludePullRequests,
            int checkSuiteId,
            string? headSha,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareActionsListWorkflowRunsForRepoArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                actor: ref actor,
                branch: ref branch,
                @event: ref @event,
                status: ref status,
                perPage: ref perPage,
                page: ref page,
                created: created,
                excludePullRequests: ref excludePullRequests,
                checkSuiteId: ref checkSuiteId,
                headSha: ref headSha);

            var statusValue = status switch
            {
                global::G.ActionsListWorkflowRunsForRepoStatus.Completed => "completed",
                global::G.ActionsListWorkflowRunsForRepoStatus.ActionRequired => "action_required",
                global::G.ActionsListWorkflowRunsForRepoStatus.Cancelled => "cancelled",
                global::G.ActionsListWorkflowRunsForRepoStatus.Failure => "failure",
                global::G.ActionsListWorkflowRunsForRepoStatus.Neutral => "neutral",
                global::G.ActionsListWorkflowRunsForRepoStatus.Skipped => "skipped",
                global::G.ActionsListWorkflowRunsForRepoStatus.Stale => "stale",
                global::G.ActionsListWorkflowRunsForRepoStatus.Success => "success",
                global::G.ActionsListWorkflowRunsForRepoStatus.TimedOut => "timed_out",
                global::G.ActionsListWorkflowRunsForRepoStatus.InProgress => "in_progress",
                global::G.ActionsListWorkflowRunsForRepoStatus.Queued => "queued",
                global::G.ActionsListWorkflowRunsForRepoStatus.Requested => "requested",
                global::G.ActionsListWorkflowRunsForRepoStatus.Waiting => "waiting",
                global::G.ActionsListWorkflowRunsForRepoStatus.Pending => "pending",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/actions/runs?actor={actor}&branch={branch}&event={@event}&status={statusValue}&per_page={perPage}&page={page}&created={created:yyyy-MM-ddTHH:mm:ssZ}&exclude_pull_requests={excludePullRequests}&check_suite_id={checkSuiteId}&head_sha={headSha}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareActionsListWorkflowRunsForRepoRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                actor: actor,
                branch: branch,
                @event: @event,
                status: status,
                perPage: perPage,
                page: page,
                created: created,
                excludePullRequests: excludePullRequests,
                checkSuiteId: checkSuiteId,
                headSha: headSha);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessActionsListWorkflowRunsForRepoResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessActionsListWorkflowRunsForRepoResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ActionsListWorkflowRunsForRepoResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}