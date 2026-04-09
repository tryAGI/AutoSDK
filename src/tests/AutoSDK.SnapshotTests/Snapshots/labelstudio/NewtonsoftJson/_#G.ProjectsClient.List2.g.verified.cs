//HintName: G.ProjectsClient.List2.g.cs

#nullable enable

namespace G
{
    public partial class ProjectsClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_List2SecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_List2SecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_List2SecurityRequirement0,
            };
        partial void PrepareList2Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int id,
            ref string? ids,
            ref bool? @implicit,
            ref global::System.DateTime? lastActivityGte,
            ref global::System.DateTime? lastActivityLte,
            ref bool? noAnnotators,
            ref string? ordering,
            ref int? page,
            ref int? pageSize,
            ref string? role,
            ref string? search,
            ref string? tags,
            ref bool? withDeleted);
        partial void PrepareList2Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int id,
            string? ids,
            bool? @implicit,
            global::System.DateTime? lastActivityGte,
            global::System.DateTime? lastActivityLte,
            bool? noAnnotators,
            string? ordering,
            int? page,
            int? pageSize,
            string? role,
            string? search,
            string? tags,
            bool? withDeleted);
        partial void ProcessList2Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessList2ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// ✨ Get project members paginated<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Retrieve the members for a specific project.<br/>
        /// **Response Fields:**<br/>
        /// - `implicit_member` (boolean): Indicates if the user is an implicit member.<br/>
        ///   - `true`: User has access via workspace membership or organization role (Administrator/Owner)<br/>
        ///   - `false`: User is an explicit project member (added directly to the project)<br/>
        /// - `project_role` (string|null): Project-specific role override if assigned, null otherwise<br/>
        /// **Note:** Users can have both explicit membership AND implicit access. The `implicit_member` field is `false` if the user has an explicit ProjectMember entry, regardless of whether they also have implicit access via workspace or org role.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ids"></param>
        /// <param name="implicit"></param>
        /// <param name="lastActivityGte"></param>
        /// <param name="lastActivityLte"></param>
        /// <param name="noAnnotators"></param>
        /// <param name="ordering"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="role"></param>
        /// <param name="search"></param>
        /// <param name="tags"></param>
        /// <param name="withDeleted"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PaginatedPaginatedProjectMemberList> List2Async(
            int id,
            string? ids = default,
            bool? @implicit = default,
            global::System.DateTime? lastActivityGte = default,
            global::System.DateTime? lastActivityLte = default,
            bool? noAnnotators = default,
            string? ordering = default,
            int? page = default,
            int? pageSize = default,
            string? role = default,
            string? search = default,
            string? tags = default,
            bool? withDeleted = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareList2Arguments(
                httpClient: HttpClient,
                id: ref id,
                ids: ref ids,
                @implicit: ref @implicit,
                lastActivityGte: ref lastActivityGte,
                lastActivityLte: ref lastActivityLte,
                noAnnotators: ref noAnnotators,
                ordering: ref ordering,
                page: ref page,
                pageSize: ref pageSize,
                role: ref role,
                search: ref search,
                tags: ref tags,
                withDeleted: ref withDeleted);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_List2SecurityRequirements,
                operationName: "List2Async");

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/api/projects/{id}/members/paginated/",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("ids", ids)
                .AddOptionalParameter("implicit", @implicit?.ToString().ToLowerInvariant())
                .AddOptionalParameter("last_activity__gte", lastActivityGte?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddOptionalParameter("last_activity__lte", lastActivityLte?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddOptionalParameter("no_annotators", noAnnotators?.ToString().ToLowerInvariant())
                .AddOptionalParameter("ordering", ordering)
                .AddOptionalParameter("page", page?.ToString())
                .AddOptionalParameter("page_size", pageSize?.ToString())
                .AddOptionalParameter("role", role)
                .AddOptionalParameter("search", search)
                .AddOptionalParameter("tags", tags)
                .AddOptionalParameter("with_deleted", withDeleted?.ToString().ToLowerInvariant()) 
                ;
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
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
            PrepareList2Request(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                id: id,
                ids: ids,
                @implicit: @implicit,
                lastActivityGte: lastActivityGte,
                lastActivityLte: lastActivityLte,
                noAnnotators: noAnnotators,
                ordering: ordering,
                page: page,
                pageSize: pageSize,
                role: role,
                search: search,
                tags: tags,
                withDeleted: withDeleted);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessList2Response(
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
                ProcessList2ResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.PaginatedPaginatedProjectMemberList.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.PaginatedPaginatedProjectMemberList.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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