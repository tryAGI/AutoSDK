//HintName: G.ActionsClient.ActionsReviewCustomGatesForRun.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        partial void PrepareActionsReviewCustomGatesForRunArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int runId,
            global::G.AnyOf<global::G.ReviewCustomGatesCommentRequired, global::G.ReviewCustomGatesStateRequired> request);
        partial void PrepareActionsReviewCustomGatesForRunRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int runId,
            global::G.AnyOf<global::G.ReviewCustomGatesCommentRequired, global::G.ReviewCustomGatesStateRequired> request);
        partial void ProcessActionsReviewCustomGatesForRunResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Review custom deployment protection rules for a workflow run<br/>
        /// Approve or reject custom deployment protection rules provided by a GitHub App for a workflow run. For more information, see "[Using environments for deployment](https://docs.github.com/actions/deployment/targeting-different-environments/using-environments-for-deployment)."<br/>
        /// **Note:** GitHub Apps can only review their own custom deployment protection rules.<br/>
        /// To approve or reject pending deployments that are waiting for review from a specific person or team, see [`POST /repos/{owner}/{repo}/actions/runs/{run_id}/pending_deployments`](/rest/actions/workflow-runs#review-pending-deployments-for-a-workflow-run).<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsReviewCustomGatesForRunAsync(
            string owner,
            string repo,
            int runId,
            global::G.AnyOf<global::G.ReviewCustomGatesCommentRequired, global::G.ReviewCustomGatesStateRequired> request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareActionsReviewCustomGatesForRunArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                runId: ref runId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/actions/runs/{runId}/deployment_protection_rule", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareActionsReviewCustomGatesForRunRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                runId: runId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessActionsReviewCustomGatesForRunResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Review custom deployment protection rules for a workflow run<br/>
        /// Approve or reject custom deployment protection rules provided by a GitHub App for a workflow run. For more information, see "[Using environments for deployment](https://docs.github.com/actions/deployment/targeting-different-environments/using-environments-for-deployment)."<br/>
        /// **Note:** GitHub Apps can only review their own custom deployment protection rules.<br/>
        /// To approve or reject pending deployments that are waiting for review from a specific person or team, see [`POST /repos/{owner}/{repo}/actions/runs/{run_id}/pending_deployments`](/rest/actions/workflow-runs#review-pending-deployments-for-a-workflow-run).<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint with a private repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsReviewCustomGatesForRunAsync(
            string owner,
            string repo,
            int runId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.AnyOf<global::G.ReviewCustomGatesCommentRequired, global::G.ReviewCustomGatesStateRequired>
            {
            };

            await ActionsReviewCustomGatesForRunAsync(
                owner: owner,
                repo: repo,
                runId: runId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}