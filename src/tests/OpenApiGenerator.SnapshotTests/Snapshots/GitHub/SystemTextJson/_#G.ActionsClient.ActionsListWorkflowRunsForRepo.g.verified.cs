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
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/actions/runs?actor={actor}&branch={branch}&event={@event}&status={status}&per_page={perPage}&page={page}&created={created}&exclude_pull_requests={excludePullRequests}&check_suite_id={checkSuiteId}&head_sha={headSha}", global::System.UriKind.RelativeOrAbsolute));

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<ActionsListWorkflowRunsForRepoResponse?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}