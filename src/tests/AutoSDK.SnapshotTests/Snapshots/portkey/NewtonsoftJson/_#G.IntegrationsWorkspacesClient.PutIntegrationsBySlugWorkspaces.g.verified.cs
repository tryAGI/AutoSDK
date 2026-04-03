//HintName: G.IntegrationsWorkspacesClient.PutIntegrationsBySlugWorkspaces.g.cs

#nullable enable

namespace G
{
    public partial class IntegrationsWorkspacesClient
    {
        partial void PreparePutIntegrationsBySlugWorkspacesArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string slug,
            global::G.BulkUpdateWorkspacesRequest request);
        partial void PreparePutIntegrationsBySlugWorkspacesRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string slug,
            global::G.BulkUpdateWorkspacesRequest request);
        partial void ProcessPutIntegrationsBySlugWorkspacesResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPutIntegrationsBySlugWorkspacesResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Bulk update workspace access<br/>
        /// Updates workspace access permissions, usage limits, and rate limits for an integration.<br/>
        /// Can configure global workspace access or per-workspace settings.
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<string> PutIntegrationsBySlugWorkspacesAsync(
            string slug,

            global::G.BulkUpdateWorkspacesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePutIntegrationsBySlugWorkspacesArguments(
                httpClient: HttpClient,
                slug: ref slug,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/integrations/{slug}/workspaces",
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
            PreparePutIntegrationsBySlugWorkspacesRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                slug: slug,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessPutIntegrationsBySlugWorkspacesResponse(
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
                ProcessPutIntegrationsBySlugWorkspacesResponseContent(
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
        /// Bulk update workspace access<br/>
        /// Updates workspace access permissions, usage limits, and rate limits for an integration.<br/>
        /// Can configure global workspace access or per-workspace settings.
        /// </summary>
        /// <param name="slug"></param>
        /// <param name="workspaces"></param>
        /// <param name="globalWorkspaceAccess"></param>
        /// <param name="overrideExistingWorkspaceAccess">
        /// Whether to override existing workspace access settings
        /// </param>
        /// <param name="createDefaultProvider">
        /// Whether to automatically create a default provider when granting workspace access. Defaults to true. Can be overridden per workspace.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="defaultProviderSlug">
        /// Custom slug for the auto-created default provider. Applies to all workspaces unless overridden per workspace. If the slug already exists, the request will fail with a validation error.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> PutIntegrationsBySlugWorkspacesAsync(
            string slug,
            global::System.Collections.Generic.IList<global::G.WorkspaceUpdateRequest>? workspaces = default,
            global::G.GlobalWorkspaceAccess? globalWorkspaceAccess = default,
            bool? overrideExistingWorkspaceAccess = default,
            bool? createDefaultProvider = default,
            string? defaultProviderSlug = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.BulkUpdateWorkspacesRequest
            {
                Workspaces = workspaces,
                GlobalWorkspaceAccess = globalWorkspaceAccess,
                OverrideExistingWorkspaceAccess = overrideExistingWorkspaceAccess,
                CreateDefaultProvider = createDefaultProvider,
                DefaultProviderSlug = defaultProviderSlug,
            };

            return await PutIntegrationsBySlugWorkspacesAsync(
                slug: slug,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}