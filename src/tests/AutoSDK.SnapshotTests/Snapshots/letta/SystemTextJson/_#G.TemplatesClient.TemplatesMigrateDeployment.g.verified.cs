//HintName: G.TemplatesClient.TemplatesMigrateDeployment.g.cs

#nullable enable

namespace G
{
    public partial class TemplatesClient
    {
        partial void PrepareTemplatesMigrateDeploymentArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string projectId,
            ref string templateName,
            ref string deploymentId,
            global::G.TemplatesMigrateDeploymentRequest request);
        partial void PrepareTemplatesMigrateDeploymentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string projectId,
            string templateName,
            string deploymentId,
            global::G.TemplatesMigrateDeploymentRequest request);
        partial void ProcessTemplatesMigrateDeploymentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTemplatesMigrateDeploymentResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Migrate deployment to template version (Cloud-only)<br/>
        /// Migrates a deployment to a specific template version
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="templateName"></param>
        /// <param name="deploymentId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TemplatesMigrateDeploymentResponse> TemplatesMigrateDeploymentAsync(
            string projectId,
            string templateName,
            string deploymentId,

            global::G.TemplatesMigrateDeploymentRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareTemplatesMigrateDeploymentArguments(
                httpClient: HttpClient,
                projectId: ref projectId,
                templateName: ref templateName,
                deploymentId: ref deploymentId,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/templates/{projectId}/{templateName}/deployments/{deploymentId}/migrate",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            PrepareTemplatesMigrateDeploymentRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                projectId: projectId,
                templateName: templateName,
                deploymentId: deploymentId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessTemplatesMigrateDeploymentResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 400
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.TemplatesMigrateDeploymentResponse2? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.TemplatesMigrateDeploymentResponse2.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.TemplatesMigrateDeploymentResponse2.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.TemplatesMigrateDeploymentResponse2>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 404
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                global::G.TemplatesMigrateDeploymentResponse3? __value_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = global::G.TemplatesMigrateDeploymentResponse3.FromJson(__content_404, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_404 = global::G.TemplatesMigrateDeploymentResponse3.FromJson(__content_404, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::G.ApiException<global::G.TemplatesMigrateDeploymentResponse3>(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_404,
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
            // 500
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::System.Exception? __exception_500 = null;
                global::G.TemplatesMigrateDeploymentResponse4? __value_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_500 = global::G.TemplatesMigrateDeploymentResponse4.FromJson(__content_500, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_500 = global::G.TemplatesMigrateDeploymentResponse4.FromJson(__content_500, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_500 = __ex;
                }

                throw new global::G.ApiException<global::G.TemplatesMigrateDeploymentResponse4>(
                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_500,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
                    ResponseObject = __value_500,
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
                ProcessTemplatesMigrateDeploymentResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.TemplatesMigrateDeploymentResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.TemplatesMigrateDeploymentResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// <summary>
        /// Migrate deployment to template version (Cloud-only)<br/>
        /// Migrates a deployment to a specific template version
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="templateName"></param>
        /// <param name="deploymentId"></param>
        /// <param name="version">
        /// The target template version to migrate to
        /// </param>
        /// <param name="preserveToolVariables">
        /// Whether to preserve existing tool variables during migration
        /// </param>
        /// <param name="preserveCoreMemories">
        /// Whether to preserve existing core memories during migration
        /// </param>
        /// <param name="preserveSources">
        /// If true, existing agent sources will be preserved and merged with template sources during migration. If false, agent sources will be replaced with template sources.
        /// </param>
        /// <param name="memoryVariables">
        /// Additional memory variables to apply during migration
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TemplatesMigrateDeploymentResponse> TemplatesMigrateDeploymentAsync(
            string projectId,
            string templateName,
            string deploymentId,
            string version,
            bool? preserveToolVariables = default,
            bool? preserveCoreMemories = default,
            bool? preserveSources = default,
            global::System.Collections.Generic.Dictionary<string, string>? memoryVariables = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.TemplatesMigrateDeploymentRequest
            {
                Version = version,
                PreserveToolVariables = preserveToolVariables,
                PreserveCoreMemories = preserveCoreMemories,
                PreserveSources = preserveSources,
                MemoryVariables = memoryVariables,
            };

            return await TemplatesMigrateDeploymentAsync(
                projectId: projectId,
                templateName: templateName,
                deploymentId: deploymentId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}