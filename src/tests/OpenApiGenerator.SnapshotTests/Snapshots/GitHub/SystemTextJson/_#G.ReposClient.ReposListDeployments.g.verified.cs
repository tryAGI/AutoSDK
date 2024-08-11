//HintName: G.ReposClient.ReposListDeployments.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {
        partial void PrepareReposListDeploymentsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref string? sha,
            ref string? @ref,
            ref string? task,
            ref string? environment,
            ref int perPage,
            ref int page);
        partial void PrepareReposListDeploymentsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            string? sha,
            string? @ref,
            string? task,
            string? environment,
            int perPage,
            int page);
        partial void ProcessReposListDeploymentsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReposListDeploymentsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List deployments<br/>
        /// Simple filtering of deployments is available via query parameters:
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="sha">
        /// Default Value: none
        /// </param>
        /// <param name="@ref">
        /// Default Value: none
        /// </param>
        /// <param name="task">
        /// Default Value: none
        /// </param>
        /// <param name="environment">
        /// Default Value: none
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Deployment>> ReposListDeploymentsAsync(
            string owner,
            string repo,
            string? sha,
            string? @ref,
            string? task,
            string? environment,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReposListDeploymentsArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                sha: ref sha,
                @ref: ref @ref,
                task: ref task,
                environment: ref environment,
                perPage: ref perPage,
                page: ref page);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/deployments?sha={sha}&ref={@ref}&task={task}&environment={environment}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReposListDeploymentsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                sha: sha,
                @ref: @ref,
                task: task,
                environment: environment,
                perPage: perPage,
                page: page);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReposListDeploymentsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReposListDeploymentsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.Deployment>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}