//HintName: G.Projects2Client.ListCounts.g.cs

#nullable enable

namespace G
{
    public partial class Projects2Client
    {
        partial void PrepareListCountsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref bool? archived,
            ref string? filter,
            ref string? ids,
            ref string? include,
            ref string? ordering,
            ref int? page,
            ref int? pageSize,
            ref string? search,
            ref string? state,
            ref string? title,
            ref double? workspaces);
        partial void PrepareListCountsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            bool? archived,
            string? filter,
            string? ids,
            string? include,
            string? ordering,
            int? page,
            int? pageSize,
            string? search,
            string? state,
            string? title,
            double? workspaces);
        partial void ProcessListCountsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListCountsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List projects' counts<br/>
        /// Returns a list of projects with their counts. For example, task_number which is the total task number in project
        /// </summary>
        /// <param name="archived"></param>
        /// <param name="filter">
        /// Default Value: all
        /// </param>
        /// <param name="ids"></param>
        /// <param name="include"></param>
        /// <param name="ordering"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="search"></param>
        /// <param name="state"></param>
        /// <param name="title"></param>
        /// <param name="workspaces"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PaginatedLseProjectCountsList> ListCountsAsync(
            bool? archived = default,
            string? filter = default,
            string? ids = default,
            string? include = default,
            string? ordering = default,
            int? page = default,
            int? pageSize = default,
            string? search = default,
            string? state = default,
            string? title = default,
            double? workspaces = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListCountsArguments(
                httpClient: HttpClient,
                archived: ref archived,
                filter: ref filter,
                ids: ref ids,
                include: ref include,
                ordering: ref ordering,
                page: ref page,
                pageSize: ref pageSize,
                search: ref search,
                state: ref state,
                title: ref title,
                workspaces: ref workspaces);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/api/projects/counts/",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("archived", archived?.ToString().ToLowerInvariant())
                .AddOptionalParameter("filter", filter)
                .AddOptionalParameter("ids", ids)
                .AddOptionalParameter("include", include)
                .AddOptionalParameter("ordering", ordering)
                .AddOptionalParameter("page", page?.ToString())
                .AddOptionalParameter("page_size", pageSize?.ToString())
                .AddOptionalParameter("search", search)
                .AddOptionalParameter("state", state)
                .AddOptionalParameter("title", title)
                .AddOptionalParameter("workspaces", workspaces?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareListCountsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                archived: archived,
                filter: filter,
                ids: ids,
                include: include,
                ordering: ordering,
                page: page,
                pageSize: pageSize,
                search: search,
                state: state,
                title: title,
                workspaces: workspaces);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListCountsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

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
                ProcessListCountsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.PaginatedLseProjectCountsList.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.PaginatedLseProjectCountsList.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

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
        }
    }
}