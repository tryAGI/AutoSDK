//HintName: G.ActionsClient.ActionsReviewPendingDeploymentsForRun.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        partial void PrepareActionsReviewPendingDeploymentsForRunArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref int runId,
            global::G.ActionsReviewPendingDeploymentsForRunRequest request);
        partial void PrepareActionsReviewPendingDeploymentsForRunRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            int runId,
            global::G.ActionsReviewPendingDeploymentsForRunRequest request);
        partial void ProcessActionsReviewPendingDeploymentsForRunResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessActionsReviewPendingDeploymentsForRunResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Review pending deployments for a workflow run<br/>
        /// Approve or reject pending deployments that are waiting on approval by a required reviewer.<br/>
        /// Required reviewers with read access to the repository contents and deployments can use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Deployment>> ActionsReviewPendingDeploymentsForRunAsync(
            string owner,
            string repo,
            int runId,
            global::G.ActionsReviewPendingDeploymentsForRunRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareActionsReviewPendingDeploymentsForRunArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                runId: ref runId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/actions/runs/{runId}/pending_deployments", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareActionsReviewPendingDeploymentsForRunRequest(
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
            ProcessActionsReviewPendingDeploymentsForRunResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessActionsReviewPendingDeploymentsForRunResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.Deployment>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Review pending deployments for a workflow run<br/>
        /// Approve or reject pending deployments that are waiting on approval by a required reviewer.<br/>
        /// Required reviewers with read access to the repository contents and deployments can use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runId"></param>
        /// <param name="environmentIds">
        /// The list of environment ids to approve or reject<br/>
        /// Example: [161171787, 161171795]
        /// </param>
        /// <param name="state">
        /// Whether to approve or reject deployment to the specified environments.<br/>
        /// Example: approved
        /// </param>
        /// <param name="comment">
        /// A comment to accompany the deployment review<br/>
        /// Example: Ship it!
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Deployment>> ActionsReviewPendingDeploymentsForRunAsync(
            string owner,
            string repo,
            int runId,
            global::System.Collections.Generic.IList<int> environmentIds,
            global::G.ActionsReviewPendingDeploymentsForRunRequestState state,
            string comment,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ActionsReviewPendingDeploymentsForRunRequest
            {
                EnvironmentIds = environmentIds,
                State = state,
                Comment = comment,
            };

            return await ActionsReviewPendingDeploymentsForRunAsync(
                owner: owner,
                repo: repo,
                runId: runId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}