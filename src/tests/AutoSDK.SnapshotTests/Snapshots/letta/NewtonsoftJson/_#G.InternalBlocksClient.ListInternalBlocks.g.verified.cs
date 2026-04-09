//HintName: G.InternalBlocksClient.ListInternalBlocks.g.cs

#nullable enable

namespace G
{
    public partial class InternalBlocksClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_ListInternalBlocksSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_ListInternalBlocksSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_ListInternalBlocksSecurityRequirement0,
            };
        partial void PrepareListInternalBlocksArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? label,
            ref bool? templatesOnly,
            ref string? name,
            ref string? identityId,
            global::System.Collections.Generic.IList<string>? identifierKeys,
            ref string? projectId,
            int? limit,
            ref string? before,
            ref string? after,
            ref global::G.ListInternalBlocksOrder? order,
            ref string? orderBy,
            ref string? labelSearch,
            ref string? descriptionSearch,
            ref string? valueSearch,
            int? connectedToAgentsCountGt,
            int? connectedToAgentsCountLt,
            global::System.Collections.Generic.IList<int>? connectedToAgentsCountEq);
        partial void PrepareListInternalBlocksRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? label,
            bool? templatesOnly,
            string? name,
            string? identityId,
            global::System.Collections.Generic.IList<string>? identifierKeys,
            string? projectId,
            int? limit,
            string? before,
            string? after,
            global::G.ListInternalBlocksOrder? order,
            string? orderBy,
            string? labelSearch,
            string? descriptionSearch,
            string? valueSearch,
            int? connectedToAgentsCountGt,
            int? connectedToAgentsCountLt,
            global::System.Collections.Generic.IList<int>? connectedToAgentsCountEq);
        partial void ProcessListInternalBlocksResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListInternalBlocksResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Blocks
        /// </summary>
        /// <param name="label">
        /// Label to include (alphanumeric, hyphens, underscores, forward slashes)
        /// </param>
        /// <param name="templatesOnly">
        /// Whether to include only templates<br/>
        /// Default Value: false
        /// </param>
        /// <param name="name">
        /// Name filter (alphanumeric, spaces, hyphens, underscores)
        /// </param>
        /// <param name="identityId">
        /// The ID of the identity in the format 'identity-&lt;uuid4&gt;'
        /// </param>
        /// <param name="identifierKeys">
        /// Search agents by identifier keys
        /// </param>
        /// <param name="projectId">
        /// Search blocks by project id
        /// </param>
        /// <param name="limit">
        /// Number of blocks to return<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="before">
        /// Block ID cursor for pagination. Returns blocks that come before this block ID in the specified sort order
        /// </param>
        /// <param name="after">
        /// Block ID cursor for pagination. Returns blocks that come after this block ID in the specified sort order
        /// </param>
        /// <param name="order">
        /// Sort order for blocks by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
        /// Default Value: asc
        /// </param>
        /// <param name="orderBy">
        /// Field to sort by<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="labelSearch">
        /// Search blocks by label. If provided, returns blocks whose label matches the search query. This is a full-text search on block labels.
        /// </param>
        /// <param name="descriptionSearch">
        /// Search blocks by description. If provided, returns blocks whose description matches the search query. This is a full-text search on block descriptions.
        /// </param>
        /// <param name="valueSearch">
        /// Search blocks by value. If provided, returns blocks whose value matches the search query. This is a full-text search on block values.
        /// </param>
        /// <param name="connectedToAgentsCountGt">
        /// Filter blocks by the number of connected agents. If provided, returns blocks that have more than this number of connected agents.
        /// </param>
        /// <param name="connectedToAgentsCountLt">
        /// Filter blocks by the number of connected agents. If provided, returns blocks that have less than this number of connected agents.
        /// </param>
        /// <param name="connectedToAgentsCountEq">
        /// Filter blocks by the exact number of connected agents. If provided, returns blocks that have exactly this number of connected agents.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Block>> ListInternalBlocksAsync(
            string? label = default,
            bool? templatesOnly = default,
            string? name = default,
            string? identityId = default,
            global::System.Collections.Generic.IList<string>? identifierKeys = default,
            string? projectId = default,
            int? limit = default,
            string? before = default,
            string? after = default,
            global::G.ListInternalBlocksOrder? order = default,
            string? orderBy = default,
            string? labelSearch = default,
            string? descriptionSearch = default,
            string? valueSearch = default,
            int? connectedToAgentsCountGt = default,
            int? connectedToAgentsCountLt = default,
            global::System.Collections.Generic.IList<int>? connectedToAgentsCountEq = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListInternalBlocksArguments(
                httpClient: HttpClient,
                label: ref label,
                templatesOnly: ref templatesOnly,
                name: ref name,
                identityId: ref identityId,
                identifierKeys: identifierKeys,
                projectId: ref projectId,
                limit: limit,
                before: ref before,
                after: ref after,
                order: ref order,
                orderBy: ref orderBy,
                labelSearch: ref labelSearch,
                descriptionSearch: ref descriptionSearch,
                valueSearch: ref valueSearch,
                connectedToAgentsCountGt: connectedToAgentsCountGt,
                connectedToAgentsCountLt: connectedToAgentsCountLt,
                connectedToAgentsCountEq: connectedToAgentsCountEq);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ListInternalBlocksSecurityRequirements,
                operationName: "ListInternalBlocksAsync");

            var orderValue = order switch
            {
                global::G.ListInternalBlocksOrder.Asc => "asc",
                global::G.ListInternalBlocksOrder.Desc => "desc",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
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
                                path: "/v1/_internal_blocks/",
                                baseUri: HttpClient.BaseAddress); 
                            __pathBuilder
                                .AddOptionalParameter("label", label)
                                .AddOptionalParameter("templates_only", templatesOnly?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("name", name)
                                .AddOptionalParameter("identity_id", identityId)
                                .AddOptionalParameter("identifier_keys", identifierKeys?.ToString())
                                .AddOptionalParameter("project_id", projectId)
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("before", before)
                                .AddOptionalParameter("after", after)
                                .AddOptionalParameter("order", order?.ToValueString())
                                .AddOptionalParameter("order_by", orderBy)
                                .AddOptionalParameter("label_search", labelSearch)
                                .AddOptionalParameter("description_search", descriptionSearch)
                                .AddOptionalParameter("value_search", valueSearch)
                                .AddOptionalParameter("connected_to_agents_count_gt", connectedToAgentsCountGt?.ToString())
                                .AddOptionalParameter("connected_to_agents_count_lt", connectedToAgentsCountLt?.ToString())
                                .AddOptionalParameter("connected_to_agents_count_eq", connectedToAgentsCountEq?.ToString()) 
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
                PrepareListInternalBlocksRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    label: label,
                    templatesOnly: templatesOnly,
                    name: name,
                    identityId: identityId,
                    identifierKeys: identifierKeys,
                    projectId: projectId,
                    limit: limit,
                    before: before,
                    after: after,
                    order: order,
                    orderBy: orderBy,
                    labelSearch: labelSearch,
                    descriptionSearch: descriptionSearch,
                    valueSearch: valueSearch,
                    connectedToAgentsCountGt: connectedToAgentsCountGt,
                    connectedToAgentsCountLt: connectedToAgentsCountLt,
                    connectedToAgentsCountEq: connectedToAgentsCountEq);

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
                                operationId: "ListInternalBlocks",
                                methodName: "ListInternalBlocksAsync",
                                pathTemplate: "\"/v1/_internal_blocks/\"",
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
                                operationId: "ListInternalBlocks",
                                methodName: "ListInternalBlocksAsync",
                                pathTemplate: "\"/v1/_internal_blocks/\"",
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
                                operationId: "ListInternalBlocks",
                                methodName: "ListInternalBlocksAsync",
                                pathTemplate: "\"/v1/_internal_blocks/\"",
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
                ProcessListInternalBlocksResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::G.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListInternalBlocks",
                                methodName: "ListInternalBlocksAsync",
                                pathTemplate: "\"/v1/_internal_blocks/\"",
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
                                operationId: "ListInternalBlocks",
                                methodName: "ListInternalBlocksAsync",
                                pathTemplate: "\"/v1/_internal_blocks/\"",
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
                                ProcessListInternalBlocksResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.Block>?>(__content, JsonSerializerOptions) ??
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
                                        global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions).Deserialize<global::System.Collections.Generic.IList<global::G.Block>?>(new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StreamReader(__content))) ??
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