//HintName: G.ActionsClient.ActionsReviewCustomGatesForRun.g.cs

#nullable enable

namespace G
{
    public partial class ActionsClient
    {
        /// <summary>
        /// Review custom deployment protection rules for a workflow run
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
            global::System.AnyOf<ReviewCustomGatesCommentRequired, ReviewCustomGatesStateRequired> request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/actions/runs/{runId}/deployment_protection_rule", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
        }

        /// <summary>
        /// Review custom deployment protection rules for a workflow run
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="runId"></param>
        /// <param name="environmentName"></param>
        /// <param name="comment"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task ActionsReviewCustomGatesForRunAsync(
            string owner,
            string repo,
            int runId,
            string environmentName,
            string comment,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::System.AnyOf<ReviewCustomGatesCommentRequired, ReviewCustomGatesStateRequired>
            {
                EnvironmentName = environmentName,
                Comment = comment,
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