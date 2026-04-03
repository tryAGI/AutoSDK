//HintName: G.McpIntegrationsWorkspacesClient.McpIntegrationWorkspacesBulkUpdate.g.cs

#nullable enable

namespace G
{
    public partial class McpIntegrationsWorkspacesClient
    {
        partial void PrepareMcpIntegrationWorkspacesBulkUpdateArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string mcpIntegrationId,
            global::G.BulkUpdateMcpIntegrationWorkspaces request);
        partial void PrepareMcpIntegrationWorkspacesBulkUpdateRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string mcpIntegrationId,
            global::G.BulkUpdateMcpIntegrationWorkspaces request);
        partial void ProcessMcpIntegrationWorkspacesBulkUpdateResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessMcpIntegrationWorkspacesBulkUpdateResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Bulk Update MCP Integration Workspaces
        /// </summary>
        /// <param name="mcpIntegrationId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<string> McpIntegrationWorkspacesBulkUpdateAsync(
            string mcpIntegrationId,

            global::G.BulkUpdateMcpIntegrationWorkspaces request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareMcpIntegrationWorkspacesBulkUpdateArguments(
                httpClient: HttpClient,
                mcpIntegrationId: ref mcpIntegrationId,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/mcp-integrations/{mcpIntegrationId}/workspaces",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareMcpIntegrationWorkspacesBulkUpdateRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                mcpIntegrationId: mcpIntegrationId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessMcpIntegrationWorkspacesBulkUpdateResponse(
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
                ProcessMcpIntegrationWorkspacesBulkUpdateResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return __content;
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
                    var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return __content;
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
        /// <summary>
        /// Bulk Update MCP Integration Workspaces
        /// </summary>
        /// <param name="mcpIntegrationId"></param>
        /// <param name="workspaces"></param>
        /// <param name="globalWorkspaceAccess"></param>
        /// <param name="overrideExistingWorkspaceAccess">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> McpIntegrationWorkspacesBulkUpdateAsync(
            string mcpIntegrationId,
            global::System.Collections.Generic.IList<global::G.BulkUpdateMcpIntegrationWorkspacesWorkspace> workspaces,
            global::G.BulkUpdateMcpIntegrationWorkspacesGlobalWorkspaceAccess? globalWorkspaceAccess = default,
            bool? overrideExistingWorkspaceAccess = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.BulkUpdateMcpIntegrationWorkspaces
            {
                Workspaces = workspaces,
                GlobalWorkspaceAccess = globalWorkspaceAccess,
                OverrideExistingWorkspaceAccess = overrideExistingWorkspaceAccess,
            };

            return await McpIntegrationWorkspacesBulkUpdateAsync(
                mcpIntegrationId: mcpIntegrationId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}