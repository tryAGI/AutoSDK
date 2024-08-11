//HintName: G.ReposClient.ReposCreateFork.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        partial void PrepareReposCreateForkArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            global::G.ReposCreateForkRequest request);
        partial void PrepareReposCreateForkRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            global::G.ReposCreateForkRequest request);
        partial void ProcessReposCreateForkResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposCreateForkResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a fork<br/>
        /// Create a fork for the authenticated user.<br/>
        /// **Note**: Forking a Repository happens asynchronously. You may have to wait a short period of time before you can access the git objects. If this takes longer than 5 minutes, be sure to contact [GitHub Support](https://support.github.com/contact?tags=dotcom-rest-api).<br/>
        /// **Note**: Although this endpoint works with GitHub Apps, the GitHub App must be installed on the destination account with access to all repositories and on the source account with access to the source repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.FullRepository> ReposCreateForkAsync(
            string owner,
            string repo,
            global::G.ReposCreateForkRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareReposCreateForkArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/forks", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReposCreateForkRequest(
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
            ProcessReposCreateForkResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReposCreateForkResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.FullRepository?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a fork<br/>
        /// Create a fork for the authenticated user.<br/>
        /// **Note**: Forking a Repository happens asynchronously. You may have to wait a short period of time before you can access the git objects. If this takes longer than 5 minutes, be sure to contact [GitHub Support](https://support.github.com/contact?tags=dotcom-rest-api).<br/>
        /// **Note**: Although this endpoint works with GitHub Apps, the GitHub App must be installed on the destination account with access to all repositories and on the source account with access to the source repository.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="organization">
        /// Optional parameter to specify the organization name if forking into an organization.
        /// </param>
        /// <param name="name">
        /// When forking from an existing repository, a new name for the fork.
        /// </param>
        /// <param name="defaultBranchOnly">
        /// When forking from an existing repository, fork with only the default branch.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.FullRepository> ReposCreateForkAsync(
            string owner,
            string repo,
            string? organization = default,
            string? name = default,
            bool defaultBranchOnly = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.ReposCreateForkRequest
            {
                Organization = organization,
                Name = name,
                DefaultBranchOnly = defaultBranchOnly,
            };

            return await ReposCreateForkAsync(
                owner: owner,
                repo: repo,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}