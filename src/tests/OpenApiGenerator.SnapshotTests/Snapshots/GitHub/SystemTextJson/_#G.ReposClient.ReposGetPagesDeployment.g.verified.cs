//HintName: G.ReposClient.ReposGetPagesDeployment.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        partial void PrepareReposGetPagesDeploymentArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref global::System.OneOf<int, string?> pagesDeploymentId);
        partial void PrepareReposGetPagesDeploymentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            global::System.OneOf<int, string?> pagesDeploymentId);
        partial void ProcessReposGetPagesDeploymentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposGetPagesDeploymentResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get the status of a GitHub Pages deployment<br/>
        /// Gets the current status of a GitHub Pages deployment.<br/>
        /// The authenticated user must have read permission for the GitHub Pages site.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="pagesDeploymentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PagesDeploymentStatus> ReposGetPagesDeploymentAsync(
            string owner,
            string repo,
            global::System.OneOf<int, string?> pagesDeploymentId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReposGetPagesDeploymentArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                pagesDeploymentId: ref pagesDeploymentId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/pages/deployments/{pagesDeploymentId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReposGetPagesDeploymentRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                pagesDeploymentId: pagesDeploymentId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReposGetPagesDeploymentResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReposGetPagesDeploymentResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.PagesDeploymentStatus?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}