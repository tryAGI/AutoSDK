//HintName: G.ReposClient.ReposCreateCommitComment.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        /// <summary>
        /// Create a commit comment
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="commitSha"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<CommitComment> ReposCreateCommitCommentAsync(
            string owner,
            string repo,
            string commitSha,
            ReposCreateCommitCommentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/commits/{commitSha}/comments", global::System.UriKind.RelativeOrAbsolute));
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
                global::System.Text.Json.JsonSerializer.Deserialize<CommitComment?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a commit comment
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="commitSha"></param>
        /// <param name="body"></param>
        /// <param name="path"></param>
        /// <param name="position"></param>
        /// <param name="line"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<CommitComment> ReposCreateCommitCommentAsync(
            string owner,
            string repo,
            string commitSha,
            string body,
            string? path = default,
            int position = default,
            int line = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ReposCreateCommitCommentRequest
            {
                Body = body,
                Path = path,
                Position = position,
                Line = line,
            };

            return await ReposCreateCommitCommentAsync(
                owner: owner,
                repo: repo,
                commitSha: commitSha,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}