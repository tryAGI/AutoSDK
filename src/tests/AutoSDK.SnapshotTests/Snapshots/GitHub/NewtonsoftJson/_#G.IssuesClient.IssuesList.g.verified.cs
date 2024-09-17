//HintName: G.IssuesClient.IssuesList.g.cs

#nullable enable

namespace G
{
    public partial class IssuesClient
    {
        partial void PrepareIssuesListArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.IssuesListFilter? filter,
            ref global::G.IssuesListState? state,
            ref string? labels,
            ref global::G.IssuesListSort? sort,
            ref global::G.IssuesListDirection? direction,
            ref global::System.DateTime? since,
            ref bool? collab,
            ref bool? orgs,
            ref bool? owned,
            ref bool? pulls,
            ref int? perPage,
            ref int? page);
        partial void PrepareIssuesListRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.IssuesListFilter? filter,
            global::G.IssuesListState? state,
            string? labels,
            global::G.IssuesListSort? sort,
            global::G.IssuesListDirection? direction,
            global::System.DateTime? since,
            bool? collab,
            bool? orgs,
            bool? owned,
            bool? pulls,
            int? perPage,
            int? page);
        partial void ProcessIssuesListResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessIssuesListResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List issues assigned to the authenticated user<br/>
        /// List issues assigned to the authenticated user across all visible repositories including owned repositories, member<br/>
        /// repositories, and organization repositories. You can use the `filter` query parameter to fetch issues that are not<br/>
        /// necessarily assigned to you.<br/>
        /// **Note**: GitHub's REST API considers every pull request an issue, but not every issue is a pull request. For this<br/>
        /// reason, "Issues" endpoints may return both issues and pull requests in the response. You can identify pull requests by<br/>
        /// the `pull_request` key. Be aware that the `id` of a pull request returned from "Issues" endpoints will be an _issue id_. To find out the pull<br/>
        /// request id, use the "[List pull requests](https://docs.github.com/rest/pulls/pulls#list-pull-requests)" endpoint.<br/>
        /// This endpoint supports the following custom media types. For more information, see "[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types)."<br/>
        /// - **`application/vnd.github.raw+json`**: Returns the raw markdown body. Response will include `body`. This is the default if you do not pass any specific media type.<br/>
        /// - **`application/vnd.github.text+json`**: Returns a text only representation of the markdown body. Response will include `body_text`.<br/>
        /// - **`application/vnd.github.html+json`**: Returns HTML rendered from the body's markdown. Response will include `body_html`.<br/>
        /// - **`application/vnd.github.full+json`**: Returns raw, text, and HTML representations. Response will include `body`, `body_text`, and `body_html`.
        /// </summary>
        /// <param name="filter">
        /// Default Value: assigned
        /// </param>
        /// <param name="state">
        /// Default Value: open
        /// </param>
        /// <param name="labels"></param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="since"></param>
        /// <param name="collab"></param>
        /// <param name="orgs"></param>
        /// <param name="owned"></param>
        /// <param name="pulls"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Issue>> IssuesListAsync(
            global::G.IssuesListFilter? filter = global::G.IssuesListFilter.Assigned,
            global::G.IssuesListState? state = global::G.IssuesListState.Open,
            string? labels = default,
            global::G.IssuesListSort? sort = global::G.IssuesListSort.Created,
            global::G.IssuesListDirection? direction = global::G.IssuesListDirection.Desc,
            global::System.DateTime? since = default,
            bool? collab = default,
            bool? orgs = default,
            bool? owned = default,
            bool? pulls = default,
            int? perPage = 30,
            int? page = 1,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareIssuesListArguments(
                httpClient: _httpClient,
                filter: ref filter,
                state: ref state,
                labels: ref labels,
                sort: ref sort,
                direction: ref direction,
                since: ref since,
                collab: ref collab,
                orgs: ref orgs,
                owned: ref owned,
                pulls: ref pulls,
                perPage: ref perPage,
                page: ref page);

            var filterValue = filter switch
            {
                global::G.IssuesListFilter.Assigned => "assigned",
                global::G.IssuesListFilter.Created => "created",
                global::G.IssuesListFilter.Mentioned => "mentioned",
                global::G.IssuesListFilter.Subscribed => "subscribed",
                global::G.IssuesListFilter.Repos => "repos",
                global::G.IssuesListFilter.All => "all",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var stateValue = state switch
            {
                global::G.IssuesListState.Open => "open",
                global::G.IssuesListState.Closed => "closed",
                global::G.IssuesListState.All => "all",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var sortValue = sort switch
            {
                global::G.IssuesListSort.Created => "created",
                global::G.IssuesListSort.Updated => "updated",
                global::G.IssuesListSort.Comments => "comments",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var directionValue = direction switch
            {
                global::G.IssuesListDirection.Asc => "asc",
                global::G.IssuesListDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/issues?filter={(global::System.Uri.EscapeDataString(filterValue?.ToString() ?? string.Empty))}&state={(global::System.Uri.EscapeDataString(stateValue?.ToString() ?? string.Empty))}&labels={labels}&sort={(global::System.Uri.EscapeDataString(sortValue?.ToString() ?? string.Empty))}&direction={(global::System.Uri.EscapeDataString(directionValue?.ToString() ?? string.Empty))}&since={since:yyyy-MM-ddTHH:mm:ssZ}&collab={collab}&orgs={orgs}&owned={owned}&pulls={pulls}&per_page={perPage}&page={page}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareIssuesListRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                filter: filter,
                state: state,
                labels: labels,
                sort: sort,
                direction: direction,
                since: since,
                collab: collab,
                orgs: orgs,
                owned: owned,
                pulls: pulls,
                perPage: perPage,
                page: page);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessIssuesListResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessIssuesListResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.Issue>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}