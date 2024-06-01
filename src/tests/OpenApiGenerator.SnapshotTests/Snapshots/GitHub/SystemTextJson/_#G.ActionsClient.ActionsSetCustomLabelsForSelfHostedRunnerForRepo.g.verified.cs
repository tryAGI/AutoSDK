//HintName: G.ActionsClient.ActionsSetCustomLabelsForSelfHostedRunnerForRepo.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        /// <summary>
        /// Set custom labels for a self-hosted runner for a repository
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runnerId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ActionsSetCustomLabelsForSelfHostedRunnerForRepoResponse> ActionsSetCustomLabelsForSelfHostedRunnerForRepoAsync(
            string owner,
            string repo,
            int runnerId,
            ActionsSetCustomLabelsForSelfHostedRunnerForRepoRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/actions/runners/{runnerId}/labels", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<ActionsSetCustomLabelsForSelfHostedRunnerForRepoResponse?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Set custom labels for a self-hosted runner for a repository
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runnerId"></param>
        /// <param name="labels"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<ActionsSetCustomLabelsForSelfHostedRunnerForRepoResponse> ActionsSetCustomLabelsForSelfHostedRunnerForRepoAsync(
            string owner,
            string repo,
            int runnerId,
            global::System.Collections.Generic.IList<string> labels,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ActionsSetCustomLabelsForSelfHostedRunnerForRepoRequest
            {
                Labels = labels,
            };

            return await ActionsSetCustomLabelsForSelfHostedRunnerForRepoAsync(
                owner: owner,
                repo: repo,
                runnerId: runnerId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}