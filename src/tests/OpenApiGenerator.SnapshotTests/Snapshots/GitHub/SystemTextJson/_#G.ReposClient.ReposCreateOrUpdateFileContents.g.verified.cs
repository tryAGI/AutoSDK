//HintName: G.ReposClient.ReposCreateOrUpdateFileContents.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        /// <summary>
        /// Create or update file contents
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="path"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<FileCommit> ReposCreateOrUpdateFileContentsAsync(
            string owner,
            string repo,
            string path,
            ReposCreateOrUpdateFileContentsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/contents/{path}", global::System.UriKind.RelativeOrAbsolute));
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
                global::System.Text.Json.JsonSerializer.Deserialize<FileCommit?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create or update file contents
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="path"></param>
        /// <param name="message"></param>
        /// <param name="content"></param>
        /// <param name="sha"></param>
        /// <param name="branch"></param>
        /// <param name="committer"></param>
        /// <param name="author"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<FileCommit> ReposCreateOrUpdateFileContentsAsync(
            string owner,
            string repo,
            string path,
            string message,
            string content,
            string? sha = default,
            string? branch = default,
            ReposCreateOrUpdateFileContentsRequestCommitter? committer = default,
            ReposCreateOrUpdateFileContentsRequestAuthor? author = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ReposCreateOrUpdateFileContentsRequest
            {
                Message = message,
                Content = content,
                Sha = sha,
                Branch = branch,
                Committer = committer,
                Author = author,
            };

            return await ReposCreateOrUpdateFileContentsAsync(
                owner: owner,
                repo: repo,
                path: path,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}