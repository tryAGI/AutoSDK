//HintName: G.ActionsClient.ActionsGenerateRunnerJitconfigForRepo.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        partial void PrepareActionsGenerateRunnerJitconfigForRepoArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            global::G.ActionsGenerateRunnerJitconfigForRepoRequest request);
        partial void PrepareActionsGenerateRunnerJitconfigForRepoRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            global::G.ActionsGenerateRunnerJitconfigForRepoRequest request);
        partial void ProcessActionsGenerateRunnerJitconfigForRepoResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessActionsGenerateRunnerJitconfigForRepoResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create configuration for a just-in-time runner for a repository<br/>
        /// Generates a configuration that can be passed to the runner application at startup.<br/>
        /// The authenticated user must have admin access to the repository.<br/>
        /// OAuth tokens and personal access tokens (classic) need the`repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ActionsGenerateRunnerJitconfigForRepoResponse> ActionsGenerateRunnerJitconfigForRepoAsync(
            string owner,
            string repo,
            global::G.ActionsGenerateRunnerJitconfigForRepoRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareActionsGenerateRunnerJitconfigForRepoArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/actions/runners/generate-jitconfig", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareActionsGenerateRunnerJitconfigForRepoRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessActionsGenerateRunnerJitconfigForRepoResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessActionsGenerateRunnerJitconfigForRepoResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.ActionsGenerateRunnerJitconfigForRepoResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create configuration for a just-in-time runner for a repository<br/>
        /// Generates a configuration that can be passed to the runner application at startup.<br/>
        /// The authenticated user must have admin access to the repository.<br/>
        /// OAuth tokens and personal access tokens (classic) need the`repo` scope to use this endpoint.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="name">
        /// The name of the new runner.
        /// </param>
        /// <param name="runnerGroupId">
        /// The ID of the runner group to register the runner to.
        /// </param>
        /// <param name="labels">
        /// The names of the custom labels to add to the runner. **Minimum items**: 1. **Maximum items**: 100.
        /// </param>
        /// <param name="workFolder">
        /// The working directory to be used for job execution, relative to the runner install directory.<br/>
        /// Default Value: _work
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ActionsGenerateRunnerJitconfigForRepoResponse> ActionsGenerateRunnerJitconfigForRepoAsync(
            string owner,
            string repo,
            string name,
            int runnerGroupId,
            global::System.Collections.Generic.IList<string> labels,
            string? workFolder = "_work",
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ActionsGenerateRunnerJitconfigForRepoRequest
            {
                Name = name,
                RunnerGroupId = runnerGroupId,
                Labels = labels,
                WorkFolder = workFolder,
            };

            return await ActionsGenerateRunnerJitconfigForRepoAsync(
                owner: owner,
                repo: repo,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}