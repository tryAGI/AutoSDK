//HintName: G.OrganizationsClient.List3.g.cs

#nullable enable

namespace G
{
    public partial class OrganizationsClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_List3SecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "Token",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_List3SecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_List3SecurityRequirement0,
            };
        partial void PrepareList3Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref bool? contributedToProjects,
            ref int? excludeProjectId,
            ref int? excludeWorkspaceId,
            ref int id,
            ref string? ordering,
            ref int? page,
            ref int? pageSize,
            ref string? role,
            ref string? search,
            ref string? tags);
        partial void PrepareList3Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            bool? contributedToProjects,
            int? excludeProjectId,
            int? excludeWorkspaceId,
            int id,
            string? ordering,
            int? page,
            int? pageSize,
            string? role,
            string? search,
            string? tags);
        partial void ProcessList3Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessList3ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// ✨ Get organization members/roles<br/>
        /// &lt;Card href="https://humansignal.com/goenterprise"&gt;<br/>
        ///         &lt;img style="pointer-events: none; margin-left: 0px; margin-right: 0px;" src="https://docs.humansignal.com/images/badge.svg" alt="Label Studio Enterprise badge"/&gt;<br/>
        ///         &lt;p style="margin-top: 10px; font-size: 14px;"&gt;<br/>
        ///             This endpoint is not available in Label Studio Community Edition. [Learn more about Label Studio Enterprise](https://humansignal.com/goenterprise)<br/>
        ///         &lt;/p&gt;<br/>
        ///     &lt;/Card&gt;<br/>
        /// Retrieve a list of all users and roles in a specific organization.
        /// </summary>
        /// <param name="contributedToProjects"></param>
        /// <param name="excludeProjectId"></param>
        /// <param name="excludeWorkspaceId"></param>
        /// <param name="id"></param>
        /// <param name="ordering"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="role"></param>
        /// <param name="search"></param>
        /// <param name="tags"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PaginatedLseOrganizationMemberListList> List3Async(
            int id,
            bool? contributedToProjects = default,
            int? excludeProjectId = default,
            int? excludeWorkspaceId = default,
            string? ordering = default,
            int? page = default,
            int? pageSize = default,
            string? role = default,
            string? search = default,
            string? tags = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareList3Arguments(
                httpClient: HttpClient,
                contributedToProjects: ref contributedToProjects,
                excludeProjectId: ref excludeProjectId,
                excludeWorkspaceId: ref excludeWorkspaceId,
                id: ref id,
                ordering: ref ordering,
                page: ref page,
                pageSize: ref pageSize,
                role: ref role,
                search: ref search,
                tags: ref tags);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_List3SecurityRequirements,
                operationName: "List3Async");

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/api/organizations/{id}/memberships",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("contributed_to_projects", contributedToProjects?.ToString().ToLowerInvariant())
                .AddOptionalParameter("exclude_project_id", excludeProjectId?.ToString())
                .AddOptionalParameter("exclude_workspace_id", excludeWorkspaceId?.ToString())
                .AddOptionalParameter("ordering", ordering)
                .AddOptionalParameter("page", page?.ToString())
                .AddOptionalParameter("page_size", pageSize?.ToString())
                .AddOptionalParameter("role", role)
                .AddOptionalParameter("search", search)
                .AddOptionalParameter("tags", tags) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            var __cookies = new global::System.Collections.Generic.List<string>();
            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Cookie")
                {
                    var __cookieValue = global::System.Uri.EscapeDataString(__authorization.Value);
                    __cookies.Add($"{__authorization.Name}={__cookieValue}");
                }
            }

            if (__cookies.Count > 0)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Cookie", string.Join("; ", __cookies));
            }

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareList3Request(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                contributedToProjects: contributedToProjects,
                excludeProjectId: excludeProjectId,
                excludeWorkspaceId: excludeWorkspaceId,
                id: id,
                ordering: ordering,
                page: page,
                pageSize: pageSize,
                role: role,
                search: search,
                tags: tags);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessList3Response(
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
                ProcessList3ResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.PaginatedLseOrganizationMemberListList.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.PaginatedLseOrganizationMemberListList.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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