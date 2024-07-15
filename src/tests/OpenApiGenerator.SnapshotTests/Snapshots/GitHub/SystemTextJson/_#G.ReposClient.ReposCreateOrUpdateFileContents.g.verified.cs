//HintName: G.ReposClient.ReposCreateOrUpdateFileContents.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        partial void PrepareReposCreateOrUpdateFileContentsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref string path,
            global::G.ReposCreateOrUpdateFileContentsRequest request);
        partial void PrepareReposCreateOrUpdateFileContentsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            string path,
            global::G.ReposCreateOrUpdateFileContentsRequest request);
        partial void ProcessReposCreateOrUpdateFileContentsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposCreateOrUpdateFileContentsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create or update file contents<br/>
        /// Creates a new file or replaces an existing file in a repository.<br/>
        /// **Note:** If you use this endpoint and the "[Delete a file](https://docs.github.com/rest/repos/contents/#delete-a-file)" endpoint in parallel, the concurrent requests will conflict and you will receive errors. You must use these endpoints serially instead.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint. The `workflow` scope is also required in order to modify files in the `.github/workflows` directory.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="path"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.FileCommit> ReposCreateOrUpdateFileContentsAsync(
            string owner,
            string repo,
            string path,
            global::G.ReposCreateOrUpdateFileContentsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareReposCreateOrUpdateFileContentsArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                path: ref path,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/contents/{path}", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReposCreateOrUpdateFileContentsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                path: path,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReposCreateOrUpdateFileContentsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReposCreateOrUpdateFileContentsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.FileCommit?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create or update file contents<br/>
        /// Creates a new file or replaces an existing file in a repository.<br/>
        /// **Note:** If you use this endpoint and the "[Delete a file](https://docs.github.com/rest/repos/contents/#delete-a-file)" endpoint in parallel, the concurrent requests will conflict and you will receive errors. You must use these endpoints serially instead.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `repo` scope to use this endpoint. The `workflow` scope is also required in order to modify files in the `.github/workflows` directory.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="path"></param>
        /// <param name="message">
        /// The commit message.
        /// </param>
        /// <param name="content">
        /// The new file content, using Base64 encoding.
        /// </param>
        /// <param name="sha">
        /// **Required if you are updating a file**. The blob SHA of the file being replaced.
        /// </param>
        /// <param name="branch">
        /// The branch name. Default: the repository’s default branch.
        /// </param>
        /// <param name="committer">
        /// The person that committed the file. Default: the authenticated user.
        /// </param>
        /// <param name="author">
        /// The author of the file. Default: The `committer` or the authenticated user if you omit `committer`.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.FileCommit> ReposCreateOrUpdateFileContentsAsync(
            string owner,
            string repo,
            string path,
            string message,
            string content,
            string? sha = default,
            string? branch = default,
            global::G.ReposCreateOrUpdateFileContentsRequestCommitter? committer = default,
            global::G.ReposCreateOrUpdateFileContentsRequestAuthor? author = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ReposCreateOrUpdateFileContentsRequest
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