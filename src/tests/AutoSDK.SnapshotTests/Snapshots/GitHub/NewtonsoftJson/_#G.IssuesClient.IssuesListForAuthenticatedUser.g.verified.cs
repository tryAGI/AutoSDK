//HintName: G.IssuesClient.IssuesListForAuthenticatedUser.g.cs

#nullable enable

namespace G
{
    public partial class IssuesClient
    {
        partial void PrepareIssuesListForAuthenticatedUserArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.IssuesListForAuthenticatedUserFilter? filter,
            ref global::G.IssuesListForAuthenticatedUserState? state,
            ref string? labels,
            ref global::G.IssuesListForAuthenticatedUserSort? sort,
            ref global::G.IssuesListForAuthenticatedUserDirection? direction,
            ref global::System.DateTime? since,
            ref int? perPage,
            ref int? page);
        partial void PrepareIssuesListForAuthenticatedUserRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.IssuesListForAuthenticatedUserFilter? filter,
            global::G.IssuesListForAuthenticatedUserState? state,
            string? labels,
            global::G.IssuesListForAuthenticatedUserSort? sort,
            global::G.IssuesListForAuthenticatedUserDirection? direction,
            global::System.DateTime? since,
            int? perPage,
            int? page);
        partial void ProcessIssuesListForAuthenticatedUserResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessIssuesListForAuthenticatedUserResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List user account issues assigned to the authenticated user<br/>
        /// List issues across owned and member repositories assigned to the authenticated user.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; GitHub's REST API considers every pull request an issue, but not every issue is a pull request. For this reason, "Issues" endpoints may return both issues and pull requests in the response. You can identify pull requests by the `pull_request` key. Be aware that the `id` of a pull request returned from "Issues" endpoints will be an _issue id_. To find out the pull request id, use the "[List pull requests](https://docs.github.com/rest/pulls/pulls#list-pull-requests)" endpoint.<br/>
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
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Issue>> IssuesListForAuthenticatedUserAsync(
            global::G.IssuesListForAuthenticatedUserFilter? filter = global::G.IssuesListForAuthenticatedUserFilter.Assigned,
            global::G.IssuesListForAuthenticatedUserState? state = global::G.IssuesListForAuthenticatedUserState.Open,
            string? labels = default,
            global::G.IssuesListForAuthenticatedUserSort? sort = global::G.IssuesListForAuthenticatedUserSort.Created,
            global::G.IssuesListForAuthenticatedUserDirection? direction = global::G.IssuesListForAuthenticatedUserDirection.Desc,
            global::System.DateTime? since = default,
            int? perPage = 30,
            int? page = 1,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareIssuesListForAuthenticatedUserArguments(
                httpClient: _httpClient,
                filter: ref filter,
                state: ref state,
                labels: ref labels,
                sort: ref sort,
                direction: ref direction,
                since: ref since,
                perPage: ref perPage,
                page: ref page);

            var filterValue = filter switch
            {
                global::G.IssuesListForAuthenticatedUserFilter.Assigned => "assigned",
                global::G.IssuesListForAuthenticatedUserFilter.Created => "created",
                global::G.IssuesListForAuthenticatedUserFilter.Mentioned => "mentioned",
                global::G.IssuesListForAuthenticatedUserFilter.Subscribed => "subscribed",
                global::G.IssuesListForAuthenticatedUserFilter.Repos => "repos",
                global::G.IssuesListForAuthenticatedUserFilter.All => "all",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var stateValue = state switch
            {
                global::G.IssuesListForAuthenticatedUserState.Open => "open",
                global::G.IssuesListForAuthenticatedUserState.Closed => "closed",
                global::G.IssuesListForAuthenticatedUserState.All => "all",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var sortValue = sort switch
            {
                global::G.IssuesListForAuthenticatedUserSort.Created => "created",
                global::G.IssuesListForAuthenticatedUserSort.Updated => "updated",
                global::G.IssuesListForAuthenticatedUserSort.Comments => "comments",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var directionValue = direction switch
            {
                global::G.IssuesListForAuthenticatedUserDirection.Asc => "asc",
                global::G.IssuesListForAuthenticatedUserDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: "/user/issues",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("filter", filterValue?.ToString()) 
                .AddOptionalParameter("state", stateValue?.ToString()) 
                .AddOptionalParameter("labels", labels) 
                .AddOptionalParameter("sort", sortValue?.ToString()) 
                .AddOptionalParameter("direction", directionValue?.ToString()) 
                .AddOptionalParameter("since", since?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("page", page?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareIssuesListForAuthenticatedUserRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                filter: filter,
                state: state,
                labels: labels,
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
            ProcessIssuesListForAuthenticatedUserResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessIssuesListForAuthenticatedUserResponseContent(
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