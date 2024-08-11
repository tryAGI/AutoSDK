//HintName: G.PullsClient.PullsListReviewCommentsForRepo.g.cs

#nullable enable

namespace G
{
    public partial class PullsClient
    {
        partial void PreparePullsListReviewCommentsForRepoArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref global::G.PullsListReviewCommentsForRepoSort? sort,
            ref global::G.PullsListReviewCommentsForRepoDirection? direction,
            global::System.DateTime since,
            ref int perPage,
            ref int page);
        partial void PreparePullsListReviewCommentsForRepoRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            global::G.PullsListReviewCommentsForRepoSort? sort,
            global::G.PullsListReviewCommentsForRepoDirection? direction,
            global::System.DateTime since,
            int perPage,
            int page);
        partial void ProcessPullsListReviewCommentsForRepoResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPullsListReviewCommentsForRepoResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List review comments in a repository<br/>
        /// Lists review comments for all pull requests in a repository. By default,<br/>
        /// review comments are in ascending order by ID.<br/>
        /// This endpoint supports the following custom media types. For more information, see "[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types)."<br/>
        /// - **`application/vnd.github-commitcomment.raw+json`**: Returns the raw markdown body. Response will include `body`. This is the default if you do not pass any specific media type.<br/>
        /// - **`application/vnd.github-commitcomment.text+json`**: Returns a text only representation of the markdown body. Response will include `body_text`.<br/>
        /// - **`application/vnd.github-commitcomment.html+json`**: Returns HTML rendered from the body's markdown. Response will include `body_html`.<br/>
        /// - **`application/vnd.github-commitcomment.full+json`**: Returns raw, text, and HTML representations. Response will include `body`, `body_text`, and `body_html`.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="sort"></param>
        /// <param name="direction"></param>
        /// <param name="since"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.PullRequestReviewComment>> PullsListReviewCommentsForRepoAsync(
            string owner,
            string repo,
            global::G.PullsListReviewCommentsForRepoSort? sort,
            global::G.PullsListReviewCommentsForRepoDirection? direction,
            global::System.DateTime since,
            int perPage,
            int page,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PreparePullsListReviewCommentsForRepoArguments(
                httpClient: _httpClient,
                owner: ref owner,
                repo: ref repo,
                sort: ref sort,
                direction: ref direction,
                since: since,
                perPage: ref perPage,
                page: ref page);

            var sortValue = sort switch
            {
                global::G.PullsListReviewCommentsForRepoSort.Created => "created",
                global::G.PullsListReviewCommentsForRepoSort.Updated => "updated",
                global::G.PullsListReviewCommentsForRepoSort.CreatedAt => "created_at",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var directionValue = direction switch
            {
                global::G.PullsListReviewCommentsForRepoDirection.Asc => "asc",
                global::G.PullsListReviewCommentsForRepoDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/repos/{owner}/{repo}/pulls/comments?sort={sortValue}&direction={directionValue}&since={since:yyyy-MM-ddTHH:mm:ssZ}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PreparePullsListReviewCommentsForRepoRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                owner: owner,
                repo: repo,
                sort: sort,
                direction: direction,
                since: since,
                perPage: perPage,
                page: page);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessPullsListReviewCommentsForRepoResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessPullsListReviewCommentsForRepoResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.PullRequestReviewComment>?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}