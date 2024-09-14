//HintName: G.PullsClient.PullsList.g.cs

#nullable enable

namespace G
{
    public partial class PullsClient
    {
        partial void PreparePullsListArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref global::G.PullsListState? state,
            ref string? head,
            ref string? @base,
            ref global::G.PullsListSort? sort,
            ref global::G.PullsListDirection? direction,
            ref int perPage,
            ref int page);
        partial void PreparePullsListRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            global::G.PullsListState? state,
            string? head,
            string? @base,
            global::G.PullsListSort? sort,
            global::G.PullsListDirection? direction,
            int perPage,
            int page);
        partial void ProcessPullsListResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPullsListResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List pull requests<br/>
        /// Lists pull requests in a specified repository.<br/>
        /// Draft pull requests are available in public repositories with GitHub<br/>
        /// Free and GitHub Free for organizations, GitHub Pro, and legacy per-repository billing<br/>
        /// plans, and in public and private repositories with GitHub Team and GitHub Enterprise<br/>
        /// Cloud. For more information, see [GitHub's products](https://docs.github.com/github/getting-started-with-github/githubs-products)<br/>
        /// in the GitHub Help documentation.<br/>
        /// This endpoint supports the following custom media types. For more information, see "[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types)."<br/>
        /// - **`application/vnd.github.raw+json`**: Returns the raw markdown body. Response will include `body`. This is the default if you do not pass any specific media type.<br/>
        /// - **`application/vnd.github.text+json`**: Returns a text only representation of the markdown body. Response will include `body_text`.<br/>
        /// - **`application/vnd.github.html+json`**: Returns HTML rendered from the body's markdown. Response will include `body_html`.<br/>
        /// - **`application/vnd.github.full+json`**: Returns raw, text, and HTML representations. Response will include `body`, `body_text`, and `body_html`.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="state">
        /// Default Value: open
        /// </param>
        /// <param name="head"></param>
        /// <param name="base"></param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.PullRequestSimple>> PullsListAsync(
            string owner,
            string repo,
            global::G.PullsListState? state = global::G.PullsListState.Open,
            string? head = default,
            string? @base = default,
            global::G.PullsListSort? sort = global::G.PullsListSort.Created,
            global::G.PullsListDirection? direction = default,
            int perPage = 30,
            int page = 1,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PreparePullsListArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                state: ref state,
                head: ref head,
                @base: ref @base,
                sort: ref sort,
                direction: ref direction,
                perPage: ref perPage,
                page: ref page);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/pulls?state={(global::System.Uri.EscapeDataString(state?.ToValueString() ?? string.Empty))}&head={head}&base={@base}&sort={(global::System.Uri.EscapeDataString(sort?.ToValueString() ?? string.Empty))}&direction={(global::System.Uri.EscapeDataString(direction?.ToValueString() ?? string.Empty))}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PreparePullsListRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                state: state,
                head: head,
                @base: @base,
                sort: sort,
                direction: direction,
                perPage: perPage,
                page: page);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessPullsListResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessPullsListResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.PullRequestSimple>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}