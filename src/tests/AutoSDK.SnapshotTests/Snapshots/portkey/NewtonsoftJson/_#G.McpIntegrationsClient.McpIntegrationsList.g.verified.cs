//HintName: G.McpIntegrationsClient.McpIntegrationsList.g.cs

#nullable enable

namespace G
{
    public partial class McpIntegrationsClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_McpIntegrationsListSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_McpIntegrationsListSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_McpIntegrationsListSecurityRequirement0,
            };
        partial void PrepareMcpIntegrationsListArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid? organisationId,
            ref global::G.McpIntegrationsListType? type,
            ref string? workspaceId,
            ref int? pageSize,
            ref int? currentPage,
            ref string? search);
        partial void PrepareMcpIntegrationsListRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid? organisationId,
            global::G.McpIntegrationsListType? type,
            string? workspaceId,
            int? pageSize,
            int? currentPage,
            string? search);
        partial void ProcessMcpIntegrationsListResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessMcpIntegrationsListResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List MCP Integrations<br/>
        /// List MCP Integrations for the organisation or workspace. Requires organisation_id (when using org admin API key) or x-portkey-api-key header.
        /// </summary>
        /// <param name="organisationId"></param>
        /// <param name="type"></param>
        /// <param name="workspaceId"></param>
        /// <param name="pageSize">
        /// Default Value: 100
        /// </param>
        /// <param name="currentPage">
        /// Default Value: 0
        /// </param>
        /// <param name="search"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.McpIntegrationListResponse> McpIntegrationsListAsync(
            global::System.Guid? organisationId = default,
            global::G.McpIntegrationsListType? type = default,
            string? workspaceId = default,
            int? pageSize = default,
            int? currentPage = default,
            string? search = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareMcpIntegrationsListArguments(
                httpClient: HttpClient,
                organisationId: ref organisationId,
                type: ref type,
                workspaceId: ref workspaceId,
                pageSize: ref pageSize,
                currentPage: ref currentPage,
                search: ref search);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_McpIntegrationsListSecurityRequirements,
                operationName: "McpIntegrationsListAsync");

            var typeValue = type switch
            {
                global::G.McpIntegrationsListType.Workspace => "workspace",
                global::G.McpIntegrationsListType.Organisation => "organisation",
                global::G.McpIntegrationsListType.All => "all",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/mcp-integrations",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("organisation_id", organisationId?.ToString())
                .AddOptionalParameter("type", type?.ToValueString())
                .AddOptionalParameter("workspace_id", workspaceId)
                .AddOptionalParameter("page_size", pageSize?.ToString())
                .AddOptionalParameter("current_page", currentPage?.ToString())
                .AddOptionalParameter("search", search) 
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
            PrepareMcpIntegrationsListRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                organisationId: organisationId,
                type: type,
                workspaceId: workspaceId,
                pageSize: pageSize,
                currentPage: currentPage,
                search: search);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessMcpIntegrationsListResponse(
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
                ProcessMcpIntegrationsListResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.McpIntegrationListResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.McpIntegrationListResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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