//HintName: G.ReposClient.ReposDeleteFile.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        /// <summary>
        /// Delete a file
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="path"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<FileCommit> ReposDeleteFileAsync(
            string owner,
            string repo,
            string path,
            ReposDeleteFileRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/repos/{owner}/{repo}/contents/{path}", global::System.UriKind.RelativeOrAbsolute));
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<FileCommit?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Delete a file
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="path"></param>
        /// <param name="message"></param>
        /// <param name="sha"></param>
        /// <param name="branch"></param>
        /// <param name="committer"></param>
        /// <param name="author"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<FileCommit> ReposDeleteFileAsync(
            string owner,
            string repo,
            string path,
            string message,
            string sha,
            string? branch = default,
            ReposDeleteFileRequestCommitter? committer = default,
            ReposDeleteFileRequestAuthor? author = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new ReposDeleteFileRequest
            {
                Message = message,
                Sha = sha,
                Branch = branch,
                Committer = committer,
                Author = author,
            };

            return await ReposDeleteFileAsync(
                owner: owner,
                repo: repo,
                path: path,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}