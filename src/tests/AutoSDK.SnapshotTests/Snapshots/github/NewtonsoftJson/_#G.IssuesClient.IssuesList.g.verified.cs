﻿//HintName: G.IssuesClient.IssuesList.g.cs

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
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Issue>> IssuesListAsync(
            global::G.IssuesListFilter? filter = default,
            global::G.IssuesListState? state = default,
            string? labels = default,
            global::G.IssuesListSort? sort = default,
            global::G.IssuesListDirection? direction = default,
            global::System.DateTime? since = default,
            bool? collab = default,
            bool? orgs = default,
            bool? owned = default,
            bool? pulls = default,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareIssuesListArguments(
                httpClient: HttpClient,
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
            var __pathBuilder = new global::G.PathBuilder(
                path: "/issues",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("filter", filter?.ToValueString()) 
                .AddOptionalParameter("state", state?.ToValueString()) 
                .AddOptionalParameter("labels", labels) 
                .AddOptionalParameter("sort", sort?.ToValueString()) 
                .AddOptionalParameter("direction", direction?.ToValueString()) 
                .AddOptionalParameter("since", since?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("collab", collab?.ToString()) 
                .AddOptionalParameter("orgs", orgs?.ToString()) 
                .AddOptionalParameter("owned", owned?.ToString()) 
                .AddOptionalParameter("pulls", pulls?.ToString()) 
                .AddOptionalParameter("per_page", perPage?.ToString()) 
                .AddOptionalParameter("page", page?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareIssuesListRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
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

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessIssuesListResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
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
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
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
            // 
            if ((int)__response.StatusCode == 304)
            {
                string? __content_304 = null;
                if (ReadResponseAsString)
                {
                    __content_304 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                }
                else
                {
                    var __contentStream_304 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                }

                throw new global::G.ApiException(
                    message: __content_304 ?? __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_304,
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
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
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
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessIssuesListResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.Issue>?>(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
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
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions).Deserialize<global::System.Collections.Generic.IList<global::G.Issue>?>(new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StreamReader(__content))) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
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
            }
        }
    }
}