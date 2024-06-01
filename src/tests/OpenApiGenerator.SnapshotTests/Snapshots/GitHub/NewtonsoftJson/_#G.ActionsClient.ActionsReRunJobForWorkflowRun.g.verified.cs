//HintName: G.ActionsClient.ActionsReRunJobForWorkflowRun.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        /// <summary>
        /// Re-run a job from a workflow run
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="jobId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<EmptyObject> ActionsReRunJobForWorkflowRunAsync(
            string owner,
            string repo,
            int jobId,
            ActionsReRunJobForWorkflowRunRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/actions/jobs/{jobId}/rerun", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<EmptyObject?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Re-run a job from a workflow run
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="jobId"></param>
        /// <param name="enableDebugLogging"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<EmptyObject> ActionsReRunJobForWorkflowRunAsync(
            string owner,
            string repo,
            int jobId,
            bool enableDebugLogging = false,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ActionsReRunJobForWorkflowRunRequest
            {
                EnableDebugLogging = enableDebugLogging,
            };

            return await ActionsReRunJobForWorkflowRunAsync(
                owner: owner,
                repo: repo,
                jobId: jobId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}