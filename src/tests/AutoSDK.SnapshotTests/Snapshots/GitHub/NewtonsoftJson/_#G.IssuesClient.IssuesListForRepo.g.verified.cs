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
        /// <exception cref="global::G.ApiException"></exception>
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

            var stateValue = state switch
            {
                global::G.IssuesListForRepoState.Open => "open",
                global::G.IssuesListForRepoState.Closed => "closed",
                global::G.IssuesListForRepoState.All => "all",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var sortValue = sort switch
            {
                global::G.IssuesListForRepoSort.Created => "created",
                global::G.IssuesListForRepoSort.Updated => "updated",
                global::G.IssuesListForRepoSort.Comments => "comments",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var directionValue = direction switch
            {
                global::G.IssuesListForRepoDirection.Asc => "asc",
                global::G.IssuesListForRepoDirection.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new PathBuilder(
                path: $"/repos/{owner}/{repo}/issues",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("milestone", milestone) 
                .AddOptionalParameter("state", stateValue?.ToString()) 
                .AddOptionalParameter("assignee", assignee) 
                .AddOptionalParameter("creator", creator) 
                .AddOptionalParameter("mentioned", mentioned) 
                .AddOptionalParameter("labels", labels) 
                .AddOptionalParameter("sort", sortValue?.ToString()) 
                .AddOptionalParameter("direction", directionValue?.ToString()) 
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
            // Moved permanently
            if ((int)__response.StatusCode == 301)
            {
                string? __content_301 = null;
                global::G.BasicError? __value_301 = null;
                if (ReadResponseAsString)
                {
                    __content_301 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_301 = global::G.BasicError.FromJson(__content_301, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_301 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_301 = await global::G.BasicError.FromJsonStreamAsync(__contentStream_301, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.BasicError>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_301,
                    ResponseObject = __value_301,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Validation failed, or the endpoint has been spammed.
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::G.ValidationError? __value_422 = null;
                if (ReadResponseAsString)
                {
                    __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = global::G.ValidationError.FromJson(__content_422, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = await global::G.ValidationError.FromJsonStreamAsync(__contentStream_422, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.ValidationError>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Resource not found
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::G.BasicError? __value_404 = null;
                if (ReadResponseAsString)
                {
                    __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_404 = global::G.BasicError.FromJson(__content_404, JsonSerializerOptions);
                }
                else
                {
                    var __contentStream_404 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_404 = await global::G.BasicError.FromJsonStreamAsync(__contentStream_404, JsonSerializerOptions).ConfigureAwait(false);
                }

                throw new global::G.ApiException<global::G.BasicError>(
                    message: __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseObject = __value_404,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

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
                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                return
                    global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.Issue>?>(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::G.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                using var __content = await __response.Content.ReadAsStreamAsync().ConfigureAwait(false);

                return
                    global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions).Deserialize<global::System.Collections.Generic.IList<global::G.Issue>?>(new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StreamReader(__content))) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}