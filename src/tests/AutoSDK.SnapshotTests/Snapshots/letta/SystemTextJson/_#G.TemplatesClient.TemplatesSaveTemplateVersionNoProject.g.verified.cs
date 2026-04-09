//HintName: G.TemplatesClient.TemplatesSaveTemplateVersionNoProject.g.cs

#nullable enable

namespace G
{
    public partial class TemplatesClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_TemplatesSaveTemplateVersionNoProjectSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_TemplatesSaveTemplateVersionNoProjectSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_TemplatesSaveTemplateVersionNoProjectSecurityRequirement0,
            };
        partial void PrepareTemplatesSaveTemplateVersionNoProjectArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string templateName,
            global::G.TemplatesSaveTemplateVersionNoProjectRequest request);
        partial void PrepareTemplatesSaveTemplateVersionNoProjectRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string templateName,
            global::G.TemplatesSaveTemplateVersionNoProjectRequest request);
        partial void ProcessTemplatesSaveTemplateVersionNoProjectResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTemplatesSaveTemplateVersionNoProjectResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Save template version (Cloud-only)<br/>
        /// Saves the current version of the template as a new version
        /// </summary>
        /// <param name="templateName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TemplatesSaveTemplateVersionNoProjectResponse> TemplatesSaveTemplateVersionNoProjectAsync(
            string templateName,

            global::G.TemplatesSaveTemplateVersionNoProjectRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareTemplatesSaveTemplateVersionNoProjectArguments(
                httpClient: HttpClient,
                templateName: ref templateName,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_TemplatesSaveTemplateVersionNoProjectSecurityRequirements,
                operationName: "TemplatesSaveTemplateVersionNoProjectAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: $"/v1/templates/{templateName}/save",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareTemplatesSaveTemplateVersionNoProjectRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                templateName: templateName,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessTemplatesSaveTemplateVersionNoProjectResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 400
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.TemplatesSaveTemplateVersionNoProjectResponse2? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.TemplatesSaveTemplateVersionNoProjectResponse2.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.TemplatesSaveTemplateVersionNoProjectResponse2.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.TemplatesSaveTemplateVersionNoProjectResponse2>(
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
                ProcessTemplatesSaveTemplateVersionNoProjectResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.TemplatesSaveTemplateVersionNoProjectResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.TemplatesSaveTemplateVersionNoProjectResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Save template version (Cloud-only)<br/>
        /// Saves the current version of the template as a new version
        /// </summary>
        /// <param name="templateName"></param>
        /// <param name="preserveEnvironmentVariablesOnMigration">
        /// If true, the environment variables will be preserved in the template version when migrating agents
        /// </param>
        /// <param name="preserveCoreMemoriesOnMigration">
        /// If true, the core memories will be preserved in the template version when migrating agents
        /// </param>
        /// <param name="preserveSourcesOnMigration">
        /// If true, existing agent folders/sources will be preserved and merged with template sources during migration. If false, agent sources will be replaced with template sources.
        /// </param>
        /// <param name="blockReconciliationStrategy">
        /// Strategy for reconciling memory blocks during migration: "reconcile-all" deletes blocks not in the template, "preserve-deleted" keeps them. Defaults to "preserve-deleted".
        /// </param>
        /// <param name="migrateAgents">
        /// If true, existing agents attached to this template will be migrated to the new template version
        /// </param>
        /// <param name="message">
        /// A message to describe the changes made in this template version
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TemplatesSaveTemplateVersionNoProjectResponse> TemplatesSaveTemplateVersionNoProjectAsync(
            string templateName,
            bool? preserveEnvironmentVariablesOnMigration = default,
            bool? preserveCoreMemoriesOnMigration = default,
            bool? preserveSourcesOnMigration = default,
            global::G.TemplatesSaveTemplateVersionNoProjectRequestBlockReconciliationStrategy? blockReconciliationStrategy = default,
            bool? migrateAgents = default,
            string? message = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.TemplatesSaveTemplateVersionNoProjectRequest
            {
                PreserveEnvironmentVariablesOnMigration = preserveEnvironmentVariablesOnMigration,
                PreserveCoreMemoriesOnMigration = preserveCoreMemoriesOnMigration,
                PreserveSourcesOnMigration = preserveSourcesOnMigration,
                BlockReconciliationStrategy = blockReconciliationStrategy,
                MigrateAgents = migrateAgents,
                Message = message,
            };

            return await TemplatesSaveTemplateVersionNoProjectAsync(
                templateName: templateName,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}