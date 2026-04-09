//HintName: G.MemoriesClient.MemoriesList.g.cs

#nullable enable

namespace G
{
    public partial class MemoriesClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_MemoriesListSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        Location = "Header",
                        Name = "Authorization",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_MemoriesListSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_MemoriesListSecurityRequirement0,
            };
        partial void PrepareMemoriesListArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? userId,
            ref string? agentId,
            ref string? appId,
            ref string? runId,
            object? metadata,
            global::System.Collections.Generic.IList<string>? categories,
            ref string? orgId,
            ref string? projectId,
            global::System.Collections.Generic.IList<string>? fields,
            ref string? keywords,
            ref int? page,
            ref int? pageSize,
            ref string? startDate,
            ref string? endDate);
        partial void PrepareMemoriesListRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? userId,
            string? agentId,
            string? appId,
            string? runId,
            object? metadata,
            global::System.Collections.Generic.IList<string>? categories,
            string? orgId,
            string? projectId,
            global::System.Collections.Generic.IList<string>? fields,
            string? keywords,
            int? page,
            int? pageSize,
            string? startDate,
            string? endDate);
        partial void ProcessMemoriesListResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessMemoriesListResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get all memories.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="agentId"></param>
        /// <param name="appId"></param>
        /// <param name="runId"></param>
        /// <param name="metadata"></param>
        /// <param name="categories"></param>
        /// <param name="orgId"></param>
        /// <param name="projectId"></param>
        /// <param name="fields"></param>
        /// <param name="keywords"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.MemoriesListResponseItem>> MemoriesListAsync(
            string? userId = default,
            string? agentId = default,
            string? appId = default,
            string? runId = default,
            object? metadata = default,
            global::System.Collections.Generic.IList<string>? categories = default,
            string? orgId = default,
            string? projectId = default,
            global::System.Collections.Generic.IList<string>? fields = default,
            string? keywords = default,
            int? page = default,
            int? pageSize = default,
            string? startDate = default,
            string? endDate = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareMemoriesListArguments(
                httpClient: HttpClient,
                userId: ref userId,
                agentId: ref agentId,
                appId: ref appId,
                runId: ref runId,
                metadata: metadata,
                categories: categories,
                orgId: ref orgId,
                projectId: ref projectId,
                fields: fields,
                keywords: ref keywords,
                page: ref page,
                pageSize: ref pageSize,
                startDate: ref startDate,
                endDate: ref endDate);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_MemoriesListSecurityRequirements,
                operationName: "MemoriesListAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/memories/",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("user_id", userId)
                .AddOptionalParameter("agent_id", agentId)
                .AddOptionalParameter("app_id", appId)
                .AddOptionalParameter("run_id", runId)
                .AddOptionalParameter("metadata", metadata?.ToString())
                .AddOptionalParameter("categories", categories, delimiter: ",", explode: true)
                .AddOptionalParameter("org_id", orgId)
                .AddOptionalParameter("project_id", projectId)
                .AddOptionalParameter("fields", fields, delimiter: ",", explode: true)
                .AddOptionalParameter("keywords", keywords)
                .AddOptionalParameter("page", page?.ToString())
                .AddOptionalParameter("page_size", pageSize?.ToString())
                .AddOptionalParameter("start_date", startDate)
                .AddOptionalParameter("end_date", endDate) 
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
            PrepareMemoriesListRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                userId: userId,
                agentId: agentId,
                appId: appId,
                runId: runId,
                metadata: metadata,
                categories: categories,
                orgId: orgId,
                projectId: projectId,
                fields: fields,
                keywords: keywords,
                page: page,
                pageSize: pageSize,
                startDate: startDate,
                endDate: endDate);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessMemoriesListResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Bad Request.
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.MemoriesListResponse? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.MemoriesListResponse.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.MemoriesListResponse.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.MemoriesListResponse>(
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
                ProcessMemoriesListResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.MemoriesListResponseItem>?>(__content, JsonSerializerOptions) ??
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
                        await global::System.Text.Json.JsonSerializer.DeserializeAsync<global::System.Collections.Generic.IList<global::G.MemoriesListResponseItem>?>(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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