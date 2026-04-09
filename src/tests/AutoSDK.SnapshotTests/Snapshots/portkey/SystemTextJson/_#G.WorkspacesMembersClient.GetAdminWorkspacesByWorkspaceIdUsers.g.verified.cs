//HintName: G.WorkspacesMembersClient.GetAdminWorkspacesByWorkspaceIdUsers.g.cs

#nullable enable

namespace G
{
    public partial class WorkspacesMembersClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_GetAdminWorkspacesByWorkspaceIdUsersSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        Location = "Header",
                        Name = "x-portkey-api-key",
                        FriendlyName = "PortkeyKey",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_GetAdminWorkspacesByWorkspaceIdUsersSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_GetAdminWorkspacesByWorkspaceIdUsersSecurityRequirement0,
            };
        partial void PrepareGetAdminWorkspacesByWorkspaceIdUsersArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string workspaceId,
            ref double? currentPage,
            ref double? pageSize,
            ref global::G.GetAdminWorkspacesUsersRole? role,
            ref string? email);
        partial void PrepareGetAdminWorkspacesByWorkspaceIdUsersRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string workspaceId,
            double? currentPage,
            double? pageSize,
            global::G.GetAdminWorkspacesUsersRole? role,
            string? email);
        partial void ProcessGetAdminWorkspacesByWorkspaceIdUsersResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetAdminWorkspacesByWorkspaceIdUsersResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get workspace members
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="currentPage">
        /// Default Value: 50
        /// </param>
        /// <param name="pageSize">
        /// Default Value: 0
        /// </param>
        /// <param name="role"></param>
        /// <param name="email"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.WorkspaceMemberList> GetAdminWorkspacesByWorkspaceIdUsersAsync(
            string workspaceId,
            double? currentPage = default,
            double? pageSize = default,
            global::G.GetAdminWorkspacesUsersRole? role = default,
            string? email = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetAdminWorkspacesByWorkspaceIdUsersArguments(
                httpClient: HttpClient,
                workspaceId: ref workspaceId,
                currentPage: ref currentPage,
                pageSize: ref pageSize,
                role: ref role,
                email: ref email);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetAdminWorkspacesByWorkspaceIdUsersSecurityRequirements,
                operationName: "GetAdminWorkspacesByWorkspaceIdUsersAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/admin/workspaces/{workspaceId}/users",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("current_page", currentPage?.ToString())
                .AddOptionalParameter("page_size", pageSize?.ToString())
                .AddOptionalParameter("role", role?.ToValueString())
                .AddOptionalParameter("email", email) 
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
            PrepareGetAdminWorkspacesByWorkspaceIdUsersRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                workspaceId: workspaceId,
                currentPage: currentPage,
                pageSize: pageSize,
                role: role,
                email: email);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetAdminWorkspacesByWorkspaceIdUsersResponse(
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
                ProcessGetAdminWorkspacesByWorkspaceIdUsersResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.WorkspaceMemberList.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.WorkspaceMemberList.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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