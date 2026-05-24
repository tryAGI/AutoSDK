//HintName: G.RunsClient.ListRuns.g.cs

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial class RunsClient
    {

        private static readonly global::G.AutoSDKServer[] s_ListRunsServers = new global::G.AutoSDKServer[]
        {            new global::G.AutoSDKServer(
                id: "https-app-letta-com",
                name: "Letta Cloud",
                url: "https://app.letta.com/",
                description: "Letta Cloud"),
            new global::G.AutoSDKServer(
                id: "http-localhost",
                name: "Self-hosted",
                url: "http://localhost:8283/",
                description: "Self-hosted"),
        };


        private static readonly global::G.EndPointSecurityRequirement s_ListRunsSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_ListRunsSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_ListRunsSecurityRequirement0,
            };
        partial void PrepareListRunsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? agentId,
            global::System.Collections.Generic.IList<string>? agentIds,
            global::System.Collections.Generic.IList<string>? statuses,
            bool? background,
            global::G.StopReasonType? stopReason,
            ref string? conversationId,
            ref string? before,
            ref string? after,
            int? limit,
            ref global::G.ListRunsOrder? order,
            ref string? orderBy,
            ref bool? active,
            ref bool? ascending);
        partial void PrepareListRunsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? agentId,
            global::System.Collections.Generic.IList<string>? agentIds,
            global::System.Collections.Generic.IList<string>? statuses,
            bool? background,
            global::G.StopReasonType? stopReason,
            string? conversationId,
            string? before,
            string? after,
            int? limit,
            global::G.ListRunsOrder? order,
            string? orderBy,
            bool? active,
            bool? ascending);
        partial void ProcessListRunsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListRunsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Runs<br/>
        /// List all runs.
        /// </summary>
        /// <param name="agentId">
        /// The unique identifier of the agent associated with the run.
        /// </param>
        /// <param name="agentIds">
        /// The unique identifiers of the agents associated with the run. Deprecated in favor of agent_id field.
        /// </param>
        /// <param name="statuses">
        /// Filter runs by status. Can specify multiple statuses.
        /// </param>
        /// <param name="background">
        /// If True, filters for runs that were created in background mode.
        /// </param>
        /// <param name="stopReason">
        /// Filter runs by stop reason.
        /// </param>
        /// <param name="conversationId">
        /// Filter runs by conversation ID.
        /// </param>
        /// <param name="before">
        /// Run ID cursor for pagination. Returns runs that come before this run ID in the specified sort order
        /// </param>
        /// <param name="after">
        /// Run ID cursor for pagination. Returns runs that come after this run ID in the specified sort order
        /// </param>
        /// <param name="limit">
        /// Maximum number of runs to return<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="order">
        /// Sort order for runs by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="orderBy">
        /// Field to sort by<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="active">
        /// Filter for active runs.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="ascending">
        /// Whether to sort agents oldest to newest (True) or newest to oldest (False, default). Deprecated in favor of order field.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Run>> ListRunsAsync(
            string? agentId = default,
            global::System.Collections.Generic.IList<string>? agentIds = default,
            global::System.Collections.Generic.IList<string>? statuses = default,
            bool? background = default,
            global::G.StopReasonType? stopReason = default,
            string? conversationId = default,
            string? before = default,
            string? after = default,
            int? limit = default,
            global::G.ListRunsOrder? order = default,
            string? orderBy = default,
            bool? active = default,
            bool? ascending = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ListRunsAsResponseAsync(
                agentId: agentId,
                agentIds: agentIds,
                statuses: statuses,
                background: background,
                stopReason: stopReason,
                conversationId: conversationId,
                before: before,
                after: after,
                limit: limit,
                order: order,
                orderBy: orderBy,
                active: active,
                ascending: ascending,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// List Runs<br/>
        /// List all runs.
        /// </summary>
        /// <param name="agentId">
        /// The unique identifier of the agent associated with the run.
        /// </param>
        /// <param name="agentIds">
        /// The unique identifiers of the agents associated with the run. Deprecated in favor of agent_id field.
        /// </param>
        /// <param name="statuses">
        /// Filter runs by status. Can specify multiple statuses.
        /// </param>
        /// <param name="background">
        /// If True, filters for runs that were created in background mode.
        /// </param>
        /// <param name="stopReason">
        /// Filter runs by stop reason.
        /// </param>
        /// <param name="conversationId">
        /// Filter runs by conversation ID.
        /// </param>
        /// <param name="before">
        /// Run ID cursor for pagination. Returns runs that come before this run ID in the specified sort order
        /// </param>
        /// <param name="after">
        /// Run ID cursor for pagination. Returns runs that come after this run ID in the specified sort order
        /// </param>
        /// <param name="limit">
        /// Maximum number of runs to return<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="order">
        /// Sort order for runs by creation time. 'asc' for oldest first, 'desc' for newest first<br/>
        /// Default Value: desc
        /// </param>
        /// <param name="orderBy">
        /// Field to sort by<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="active">
        /// Filter for active runs.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="ascending">
        /// Whether to sort agents oldest to newest (True) or newest to oldest (False, default). Deprecated in favor of order field.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::G.Run>>> ListRunsAsResponseAsync(
            string? agentId = default,
            global::System.Collections.Generic.IList<string>? agentIds = default,
            global::System.Collections.Generic.IList<string>? statuses = default,
            bool? background = default,
            global::G.StopReasonType? stopReason = default,
            string? conversationId = default,
            string? before = default,
            string? after = default,
            int? limit = default,
            global::G.ListRunsOrder? order = default,
            string? orderBy = default,
            bool? active = default,
            bool? ascending = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListRunsArguments(
                httpClient: HttpClient,
                agentId: ref agentId,
                agentIds: agentIds,
                statuses: statuses,
                background: background,
                stopReason: stopReason,
                conversationId: ref conversationId,
                before: ref before,
                after: ref after,
                limit: limit,
                order: ref order,
                orderBy: ref orderBy,
                active: ref active,
                ascending: ref ascending);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ListRunsSecurityRequirements,
                operationName: "ListRunsAsync");

            var orderValue = order switch
            {
                global::G.ListRunsOrder.Asc => "asc",
                global::G.ListRunsOrder.Desc => "desc",
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
                                path: "/v1/runs/",
                                baseUri: ResolveBaseUri(
                                servers: s_ListRunsServers,
                                defaultBaseUrl: "https://app.letta.com/"));
                            __pathBuilder
                                .AddOptionalParameter("agent_id", agentId)
                                .AddOptionalParameter("agent_ids", agentIds?.ToString())
                                .AddOptionalParameter("statuses", statuses?.ToString())
                                .AddOptionalParameter("background", background?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("stop_reason", stopReason?.ToString())
                                .AddOptionalParameter("conversation_id", conversationId)
                                .AddOptionalParameter("before", before)
                                .AddOptionalParameter("after", after)
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("order", order?.ToValueString())
                                .AddOptionalParameter("order_by", orderBy)
                                .AddOptionalParameter("active", active?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("ascending", ascending?.ToString().ToLowerInvariant())
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
                PrepareListRunsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    agentId: agentId,
                    agentIds: agentIds,
                    statuses: statuses,
                    background: background,
                    stopReason: stopReason,
                    conversationId: conversationId,
                    before: before,
                    after: after,
                    limit: limit,
                    order: order,
                    orderBy: orderBy,
                    active: active,
                    ascending: ascending);

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
                                operationId: "ListRuns",
                                methodName: "ListRunsAsync",
                                pathTemplate: "\"/v1/runs/\"",
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
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
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
                        var __retryDelay = global::G.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListRuns",
                                methodName: "ListRunsAsync",
                                pathTemplate: "\"/v1/runs/\"",
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
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::G.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::G.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::G.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListRuns",
                                methodName: "ListRunsAsync",
                                pathTemplate: "\"/v1/runs/\"",
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
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::G.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
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
                ProcessListRunsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::G.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListRuns",
                                methodName: "ListRunsAsync",
                                pathTemplate: "\"/v1/runs/\"",
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
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListRuns",
                                methodName: "ListRunsAsync",
                                pathTemplate: "\"/v1/runs/\"",
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
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
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


                                throw global::G.ApiException<global::G.HTTPValidationError>.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    responseBody: __content_422,
                                    responseObject: __value_422,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
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
                                ProcessListRunsResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::System.Collections.Generic.IList<global::G.Run>?>(__content, JsonSerializerOptions) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::G.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::G.Run>>(
                                        statusCode: __response.StatusCode,
                                        headers: global::G.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::G.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
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

                                    var __value = global::Newtonsoft.Json.JsonSerializer.Create(JsonSerializerOptions).Deserialize<global::System.Collections.Generic.IList<global::G.Run>?>(new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StreamReader(__content))) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::G.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::G.Run>>(
                                        statusCode: __response.StatusCode,
                                        headers: global::G.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
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

                                    throw global::G.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
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