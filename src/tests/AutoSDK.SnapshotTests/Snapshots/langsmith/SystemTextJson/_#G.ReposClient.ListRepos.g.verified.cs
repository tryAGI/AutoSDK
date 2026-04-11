//HintName: G.ReposClient.ListRepos.g.cs

#nullable enable

namespace G
{
    public partial class ReposClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_ListReposSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "ApiKey",
                        Location = "Header",
                        Name = "X-API-Key",
                        FriendlyName = "ApiKey",
                    },
                },
            };

        private static readonly global::G.EndPointSecurityRequirement s_ListReposSecurityRequirement1 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "TenantId",
                        Location = "Header",
                        Name = "X-Tenant-Id",
                        FriendlyName = "TenantId",
                    },
                },
            };

        private static readonly global::G.EndPointSecurityRequirement s_ListReposSecurityRequirement2 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "BearerAuth",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_ListReposSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_ListReposSecurityRequirement0,
                s_ListReposSecurityRequirement1,
                s_ListReposSecurityRequirement2,
            };
        partial void PrepareListReposArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref bool? withLatestManifest,
            ref int? limit,
            ref int? offset,
            ref string? tenantHandle,
            global::System.Guid? tenantId,
            ref string? query,
            bool? hasCommits,
            global::System.Collections.Generic.IList<string>? tags,
            global::G.ListReposApiV1ReposGetIsArchived2? isArchived,
            global::G.ListReposApiV1ReposGetIsPublic2? isPublic,
            ref string? upstreamRepoOwner,
            ref string? upstreamRepoHandle,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId,
            ref string? sortField,
            ref global::G.AnyOf<string, string, object>? sortDirection);
        partial void PrepareListReposRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            bool? withLatestManifest,
            int? limit,
            int? offset,
            string? tenantHandle,
            global::System.Guid? tenantId,
            string? query,
            bool? hasCommits,
            global::System.Collections.Generic.IList<string>? tags,
            global::G.ListReposApiV1ReposGetIsArchived2? isArchived,
            global::G.ListReposApiV1ReposGetIsPublic2? isPublic,
            string? upstreamRepoOwner,
            string? upstreamRepoHandle,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId,
            string? sortField,
            global::G.AnyOf<string, string, object>? sortDirection);
        partial void ProcessListReposResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListReposResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Repos<br/>
        /// Get all repos.
        /// </summary>
        /// <param name="withLatestManifest">
        /// Default Value: false
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="tenantHandle"></param>
        /// <param name="tenantId"></param>
        /// <param name="query"></param>
        /// <param name="hasCommits"></param>
        /// <param name="tags"></param>
        /// <param name="isArchived"></param>
        /// <param name="isPublic"></param>
        /// <param name="upstreamRepoOwner"></param>
        /// <param name="upstreamRepoHandle"></param>
        /// <param name="tagValueId"></param>
        /// <param name="sortField"></param>
        /// <param name="sortDirection"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListReposResponse> ListReposAsync(
            bool? withLatestManifest = default,
            int? limit = default,
            int? offset = default,
            string? tenantHandle = default,
            global::System.Guid? tenantId = default,
            string? query = default,
            bool? hasCommits = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::G.ListReposApiV1ReposGetIsArchived2? isArchived = default,
            global::G.ListReposApiV1ReposGetIsPublic2? isPublic = default,
            string? upstreamRepoOwner = default,
            string? upstreamRepoHandle = default,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId = default,
            string? sortField = default,
            global::G.AnyOf<string, string, object>? sortDirection = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListReposArguments(
                httpClient: HttpClient,
                withLatestManifest: ref withLatestManifest,
                limit: ref limit,
                offset: ref offset,
                tenantHandle: ref tenantHandle,
                tenantId: tenantId,
                query: ref query,
                hasCommits: hasCommits,
                tags: tags,
                isArchived: isArchived,
                isPublic: isPublic,
                upstreamRepoOwner: ref upstreamRepoOwner,
                upstreamRepoHandle: ref upstreamRepoHandle,
                tagValueId: tagValueId,
                sortField: ref sortField,
                sortDirection: ref sortDirection);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ListReposSecurityRequirements,
                operationName: "ListReposAsync");

            using var __timeoutCancellationTokenSource = global::G.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::G.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::G.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::G.PathBuilder(
                                path: "/api/v1/repos",
                                baseUri: HttpClient.BaseAddress); 
                            __pathBuilder
                                .AddOptionalParameter("with_latest_manifest", withLatestManifest?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("offset", offset?.ToString())
                                .AddOptionalParameter("tenant_handle", tenantHandle)
                                .AddOptionalParameter("tenant_id", tenantId?.ToString())
                                .AddOptionalParameter("query", query)
                                .AddOptionalParameter("has_commits", hasCommits?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("tags", tags?.ToString())
                                .AddOptionalParameter("is_archived", isArchived?.ToString())
                                .AddOptionalParameter("is_public", isPublic?.ToString())
                                .AddOptionalParameter("upstream_repo_owner", upstreamRepoOwner)
                                .AddOptionalParameter("upstream_repo_handle", upstreamRepoHandle)
                                .AddOptionalParameter("tag_value_id", tagValueId?.ToString())
                                .AddOptionalParameter("sort_field", sortField)
                                .AddOptionalParameter("sort_direction", sortDirection?.ToString()) 
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::G.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

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
            }
                global::G.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareListReposRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    withLatestManifest: withLatestManifest,
                    limit: limit,
                    offset: offset,
                    tenantHandle: tenantHandle,
                    tenantId: tenantId,
                    query: query,
                    hasCommits: hasCommits,
                    tags: tags,
                    isArchived: isArchived,
                    isPublic: isPublic,
                    upstreamRepoOwner: upstreamRepoOwner,
                    upstreamRepoHandle: upstreamRepoHandle,
                    tagValueId: tagValueId,
                    sortField: sortField,
                    sortDirection: sortDirection);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::G.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListRepos",
                                methodName: "ListReposAsync",
                                pathTemplate: "\"/api/v1/repos\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListRepos",
                                methodName: "ListReposAsync",
                                pathTemplate: "\"/api/v1/repos\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::G.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::G.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListRepos",
                                methodName: "ListReposAsync",
                                pathTemplate: "\"/api/v1/repos\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::G.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessListReposResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::G.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListRepos",
                                methodName: "ListReposAsync",
                                pathTemplate: "\"/api/v1/repos\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListRepos",
                                methodName: "ListReposAsync",
                                pathTemplate: "\"/api/v1/repos\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Validation Error
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::G.HTTPValidationError? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }

                                throw new global::G.ApiException<global::G.HTTPValidationError>(
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_422,
                                    ResponseObject = __value_422,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessListReposResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::G.ListReposResponse.FromJson(__content, JsonSerializerOptions) ??
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::G.ListReposResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
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
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}