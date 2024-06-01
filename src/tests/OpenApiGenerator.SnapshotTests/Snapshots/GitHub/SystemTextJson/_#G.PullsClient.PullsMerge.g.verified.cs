//HintName: G.PullsClient.PullsMerge.g.cs

#nullable enable

namespace G
{
    public partial class PullsClient
    {
        /// <summary>
        /// Merge a pull request
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="pullNumber"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<PullRequestMergeResult> PullsMergeAsync(
            string owner,
            string repo,
            int pullNumber,
            PullsMergeRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/pulls/{pullNumber}/merge", global::System.UriKind.RelativeOrAbsolute));
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
                global::System.Text.Json.JsonSerializer.Deserialize<PullRequestMergeResult?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Merge a pull request
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="pullNumber"></param>
        /// <param name="commitTitle"></param>
        /// <param name="commitMessage"></param>
        /// <param name="sha"></param>
        /// <param name="mergeMethod"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<PullRequestMergeResult> PullsMergeAsync(
            string owner,
            string repo,
            int pullNumber,
            string? commitTitle = default,
            string? commitMessage = default,
            string? sha = default,
            PullsMergeRequestMergeMethod? mergeMethod = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new PullsMergeRequest
            {
                CommitTitle = commitTitle,
                CommitMessage = commitMessage,
                Sha = sha,
                MergeMethod = mergeMethod,
            };

            return await PullsMergeAsync(
                owner: owner,
                repo: repo,
                pullNumber: pullNumber,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}