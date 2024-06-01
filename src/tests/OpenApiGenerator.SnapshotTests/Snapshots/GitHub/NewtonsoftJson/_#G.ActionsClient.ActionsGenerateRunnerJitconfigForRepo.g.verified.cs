//HintName: G.ActionsClient.ActionsGenerateRunnerJitconfigForRepo.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        /// <summary>
        /// Create configuration for a just-in-time runner for a repository
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ActionsGenerateRunnerJitconfigForRepoResponse> ActionsGenerateRunnerJitconfigForRepoAsync(
            string owner,
            string repo,
            ActionsGenerateRunnerJitconfigForRepoRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/actions/runners/generate-jitconfig", global::System.UriKind.RelativeOrAbsolute));
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<ActionsGenerateRunnerJitconfigForRepoResponse?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create configuration for a just-in-time runner for a repository
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="name"></param>
        /// <param name="runnerGroupId"></param>
        /// <param name="labels"></param>
        /// <param name="workFolder"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ActionsGenerateRunnerJitconfigForRepoResponse> ActionsGenerateRunnerJitconfigForRepoAsync(
            string owner,
            string repo,
            string name,
            int runnerGroupId,
            global::System.Collections.Generic.IList<string> labels,
            string? workFolder = "_work",
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ActionsGenerateRunnerJitconfigForRepoRequest
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