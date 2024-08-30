//HintName: G.SearchClient.SearchIssuesAndPullRequests.g.cs

#nullable enable

namespace G
{
    public partial class SearchClient
    {
        partial void PrepareSearchIssuesAndPullRequestsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string q,
            ref global::G.SearchIssuesAndPullRequestsSort? sort,
            ref global::G.SearchIssuesAndPullRequestsOrder? order,
            ref int perPage,
            ref int page);
        partial void PrepareSearchIssuesAndPullRequestsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string q,
            global::G.SearchIssuesAndPullRequestsSort? sort,
            global::G.SearchIssuesAndPullRequestsOrder? order,
            int perPage,
            int page);
        partial void ProcessSearchIssuesAndPullRequestsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSearchIssuesAndPullRequestsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Search issues and pull requests<br/>
        /// Find issues by state and keyword. This method returns up to 100 results [per page](https://docs.github.com/rest/guides/using-pagination-in-the-rest-api).<br/>
        /// When searching for issues, you can get text match metadata for the issue **title**, issue **body**, and issue **comment body** fields when you pass the `text-match` media type. For more details about how to receive highlighted<br/>
        /// search results, see [Text match metadata](https://docs.github.com/rest/search/search#text-match-metadata).<br/>
        /// For example, if you want to find the oldest unresolved Python bugs on Windows. Your query might look something like this.<br/>
        /// `q=windows+label:bug+language:python+state:open&amp;sort=created&amp;order=asc`<br/>
        /// This query searches for the keyword `windows`, within any open issue that is labeled as `bug`. The search runs across repositories whose primary language is Python. The results are sorted by creation date in ascending order, which means the oldest issues appear first in the search results.<br/>
        /// **Note:** For requests made by GitHub Apps with a user access token, you can't retrieve a combination of issues and pull requests in a single query. Requests that don't include the `is:issue` or `is:pull-request` qualifier will receive an HTTP `422 Unprocessable Entity` response. To get results for both issues and pull requests, you must send separate queries for issues and pull requests. For more information about the `is` qualifier, see "[Searching only issues or pull requests](https://docs.github.com/github/searching-for-information-on-github/searching-issues-and-pull-requests#search-only-issues-or-pull-requests)."
        /// </summary>
        /// <param name="q"></param>
        /// <param name="sort"></param>
        /// <param name="order">
        /// Default Value: desc
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.SearchIssuesAndPullRequestsResponse> SearchIssuesAndPullRequestsAsync(
            string q,
            global::G.SearchIssuesAndPullRequestsSort? sort = default,
            global::G.SearchIssuesAndPullRequestsOrder? order = global::G.SearchIssuesAndPullRequestsOrder.Desc,
            int perPage = 30,
            int page = 1,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareSearchIssuesAndPullRequestsArguments(
                httpClient: _httpClient,
                q: ref q,
                sort: ref sort,
                order: ref order,
                perPage: ref perPage,
                page: ref page);

            var sortValue = sort switch
            {
                global::G.SearchIssuesAndPullRequestsSort.Comments => "comments",
                global::G.SearchIssuesAndPullRequestsSort.Reactions => "reactions",
                global::G.SearchIssuesAndPullRequestsSort.ReactionsPlus1 => "reactions-+1",
                global::G.SearchIssuesAndPullRequestsSort.Reactions1 => "reactions--1",
                global::G.SearchIssuesAndPullRequestsSort.ReactionsSmile => "reactions-smile",
                global::G.SearchIssuesAndPullRequestsSort.ReactionsThinkingFace => "reactions-thinking_face",
                global::G.SearchIssuesAndPullRequestsSort.ReactionsHeart => "reactions-heart",
                global::G.SearchIssuesAndPullRequestsSort.ReactionsTada => "reactions-tada",
                global::G.SearchIssuesAndPullRequestsSort.Interactions => "interactions",
                global::G.SearchIssuesAndPullRequestsSort.Created => "created",
                global::G.SearchIssuesAndPullRequestsSort.Updated => "updated",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var orderValue = order switch
            {
                global::G.SearchIssuesAndPullRequestsOrder.Desc => "desc",
                global::G.SearchIssuesAndPullRequestsOrder.Asc => "asc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/search/issues?q={q}&sort={(global::System.Uri.EscapeDataString(sortValue?.ToString() ?? string.Empty))}&order={(global::System.Uri.EscapeDataString(orderValue?.ToString() ?? string.Empty))}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareSearchIssuesAndPullRequestsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                q: q,
                sort: sort,
                order: order,
                perPage: perPage,
                page: page);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessSearchIssuesAndPullRequestsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessSearchIssuesAndPullRequestsResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.SearchIssuesAndPullRequestsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}