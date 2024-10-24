//HintName: G.IssuesClient.IssuesListForRepo.g.cs

#nullable enable

namespace G
{
    public partial class IssuesClient
    {
        partial void PrepareIssuesListForRepoArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string owner,
            ref string repo,
            ref string? milestone,
            ref global::G.IssuesListForRepoState? state,
            ref string? assignee,
            ref string? creator,
            ref string? mentioned,
            ref string? labels,
            ref global::G.IssuesListForRepoSort? sort,
            ref global::G.IssuesListForRepoDirection? direction,
            ref global::System.DateTime? since,
            ref int? perPage,
            ref int? page);
        partial void PrepareIssuesListForRepoRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string owner,
            string repo,
            string? milestone,
            global::G.IssuesListForRepoState? state,
            string? assignee,
            string? creator,
            string? mentioned,
            string? labels,
            global::G.IssuesListForRepoSort? sort,
            global::G.IssuesListForRepoDirection? direction,
            global::System.DateTime? since,
            int? perPage,
            int? page);
        partial void ProcessIssuesListForRepoResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessIssuesListForRepoResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List repository issues<br/>
        /// List issues in a repository. Only open issues will be listed.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; GitHub's REST API considers every pull request an issue, but not every issue is a pull request. For this reason, "Issues" endpoints may return both issues and pull requests in the response. You can identify pull requests by the `pull_request` key. Be aware that the `id` of a pull request returned from "Issues" endpoints will be an _issue id_. To find out the pull request id, use the "[List pull requests](https://docs.github.com/rest/pulls/pulls#list-pull-requests)" endpoint.<br/>
        /// This endpoint supports the following custom media types. For more information, see "[Media types](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types)."<br/>
        /// - **`application/vnd.github.raw+json`**: Returns the raw markdown body. Response will include `body`. This is the default if you do not pass any specific media type.<br/>
        /// - **`application/vnd.github.text+json`**: Returns a text only representation of the markdown body. Response will include `body_text`.<br/>
        /// - **`application/vnd.github.html+json`**: Returns HTML rendered from the body's markdown. Response will include `body_html`.<br/>
        /// - **`application/vnd.github.full+json`**: Returns raw, text, and HTML representations. Response will include `body`, `body_text`, and `body_html`.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="milestone"></param>
        /// <param name="state">
        /// Default Value: open
        /// </param>
        /// <param name="assignee"></param>
        /// <param name="creator"></param>
        /// <param name="mentioned"></param>
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
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Issue>> IssuesListForRepoAsync(
            string owner,
            string repo,
            string? milestone = default,
            global::G.IssuesListForRepoState? state = default,
            string? assignee = default,
            string? creator = default,
            string? mentioned = default,
            string? labels = default,
            global::G.IssuesListForRepoSort? sort = default,
            global::G.IssuesListForRepoDirection? direction = default,
            global::System.DateTime? since = default,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareIssuesListForRepoArguments(
                httpClient: HttpClient,
                owner: ref owner,
                repo: ref repo,
                milestone: ref milestone,
                state: ref state,
                assignee: ref assignee,
                creator: ref creator,
                mentioned: ref mentioned,
                labels: ref labels,
                sort: ref sort,
                direction: ref direction,
                since: ref since,
                perPage: ref perPage,
                page: ref page);

            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/issues",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("milestone", milestone) 
                .AddOptionalParameter("state", state?.ToValueString()) 
                .AddOptionalParameter("assignee", assignee) 
                .AddOptionalParameter("creator", creator) 
                .AddOptionalParameter("mentioned", mentioned) 
                .AddOptionalParameter("labels", labels) 
                .AddOptionalParameter("sort", sort?.ToValueString()) 
                .AddOptionalParameter("direction", direction?.ToValueString()) 
                .AddOptionalParameter("since", since?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("page", page?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareIssuesListForRepoRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                owner: owner,
                repo: repo,
                milestone: milestone,
                state: state,
                assignee: assignee,
                creator: creator,
                mentioned: mentioned,
                labels: labels,
                sort: sort,
                direction: direction,
                since: since,
                perPage: perPage,
                page: page);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessIssuesListForRepoResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessIssuesListForRepoResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.Issue>?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}