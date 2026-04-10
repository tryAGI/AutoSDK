//HintName: G.InternalRunsClient.ListInternalRuns.g.cs

#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial class InternalRunsClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_ListInternalRunsSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_ListInternalRunsSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_ListInternalRunsSecurityRequirement0,
            };
        partial void PrepareListInternalRunsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? runId,
            ref string? agentId,
            global::System.Collections.Generic.IList<string>? agentIds,
            global::System.Collections.Generic.IList<string>? statuses,
            bool? background,
            global::G.StopReasonType? stopReason,
            ref string? templateFamily,
            int? stepCount,
            ref global::G.ComparisonOperator? stepCountOperator,
            global::System.Collections.Generic.IList<string>? toolsUsed,
            ref string? before,
            ref string? after,
            int? limit,
            ref global::G.ListInternalRunsOrder? order,
            ref global::G.ListInternalRunsOrderBy? orderBy,
            ref bool? active,
            ref bool? ascending,
            ref string? projectId,
            ref string? conversationId,
            int? durationPercentile,
            int? durationValue,
            global::G.ListInternalRunsDurationOperator2? durationOperator,
            global::System.DateTime? startDate,
            global::System.DateTime? endDate);
        partial void PrepareListInternalRunsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? runId,
            string? agentId,
            global::System.Collections.Generic.IList<string>? agentIds,
            global::System.Collections.Generic.IList<string>? statuses,
            bool? background,
            global::G.StopReasonType? stopReason,
            string? templateFamily,
            int? stepCount,
            global::G.ComparisonOperator? stepCountOperator,
            global::System.Collections.Generic.IList<string>? toolsUsed,
            string? before,
            string? after,
            int? limit,
            global::G.ListInternalRunsOrder? order,
            global::G.ListInternalRunsOrderBy? orderBy,
            bool? active,
            bool? ascending,
            string? projectId,
            string? conversationId,
            int? durationPercentile,
            int? durationValue,
            global::G.ListInternalRunsDurationOperator2? durationOperator,
            global::System.DateTime? startDate,
            global::System.DateTime? endDate);
        partial void ProcessListInternalRunsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListInternalRunsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Runs<br/>
        /// List all runs.
        /// </summary>
        /// <param name="runId">
        /// Filter by a specific run ID.
        /// </param>
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
        /// <param name="templateFamily">
        /// Filter runs by template family (base_template_id).
        /// </param>
        /// <param name="stepCount">
        /// Filter runs by step count. Must be provided with step_count_operator.
        /// </param>
        /// <param name="stepCountOperator">
        /// Operator for step_count filter: 'eq' for equals, 'gte' for greater than or equal, 'lte' for less than or equal.<br/>
        /// Default Value: eq
        /// </param>
        /// <param name="toolsUsed">
        /// Filter runs that used any of the specified tools.
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
        /// <param name="projectId">
        /// Filter runs by project ID.
        /// </param>
        /// <param name="conversationId">
        /// Filter runs by conversation ID.
        /// </param>
        /// <param name="durationPercentile">
        /// Filter runs by duration percentile (1-100). Returns runs slower than this percentile.
        /// </param>
        /// <param name="durationValue">
        /// Duration value in nanoseconds for filtering. Must be used with duration_operator.
        /// </param>
        /// <param name="durationOperator">
        /// Comparison operator for duration filter: 'gt' (greater than), 'lt' (less than), 'eq' (equals).
        /// </param>
        /// <param name="startDate">
        /// Filter runs created on or after this date (ISO 8601 format).
        /// </param>
        /// <param name="endDate">
        /// Filter runs created on or before this date (ISO 8601 format).
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Run>> ListInternalRunsAsync(
            string? runId = default,
            string? agentId = default,
            global::System.Collections.Generic.IList<string>? agentIds = default,
            global::System.Collections.Generic.IList<string>? statuses = default,
            bool? background = default,
            global::G.StopReasonType? stopReason = default,
            string? templateFamily = default,
            int? stepCount = default,
            global::G.ComparisonOperator? stepCountOperator = default,
            global::System.Collections.Generic.IList<string>? toolsUsed = default,
            string? before = default,
            string? after = default,
            int? limit = default,
            global::G.ListInternalRunsOrder? order = default,
            global::G.ListInternalRunsOrderBy? orderBy = default,
            bool? active = default,
            bool? ascending = default,
            string? projectId = default,
            string? conversationId = default,
            int? durationPercentile = default,
            int? durationValue = default,
            global::G.ListInternalRunsDurationOperator2? durationOperator = default,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListInternalRunsArguments(
                httpClient: HttpClient,
                runId: ref runId,
                agentId: ref agentId,
                agentIds: agentIds,
                statuses: statuses,
                background: background,
                stopReason: stopReason,
                templateFamily: ref templateFamily,
                stepCount: stepCount,
                stepCountOperator: ref stepCountOperator,
                toolsUsed: toolsUsed,
                before: ref before,
                after: ref after,
                limit: limit,
                order: ref order,
                orderBy: ref orderBy,
                active: ref active,
                ascending: ref ascending,
                projectId: ref projectId,
                conversationId: ref conversationId,
                durationPercentile: durationPercentile,
                durationValue: durationValue,
                durationOperator: durationOperator,
                startDate: startDate,
                endDate: endDate);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ListInternalRunsSecurityRequirements,
                operationName: "ListInternalRunsAsync");

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
                                path: "/v1/_internal_runs/",
                                baseUri: HttpClient.BaseAddress); 
                            __pathBuilder
                                .AddOptionalParameter("run_id", runId)
                                .AddOptionalParameter("agent_id", agentId)
                                .AddOptionalParameter("agent_ids", agentIds?.ToString())
                                .AddOptionalParameter("statuses", statuses?.ToString())
                                .AddOptionalParameter("background", background?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("stop_reason", stopReason?.ToString())
                                .AddOptionalParameter("template_family", templateFamily)
                                .AddOptionalParameter("step_count", stepCount?.ToString())
                                .AddOptionalParameter("step_count_operator", stepCountOperator?.ToValueString())
                                .AddOptionalParameter("tools_used", toolsUsed?.ToString())
                                .AddOptionalParameter("before", before)
                                .AddOptionalParameter("after", after)
                                .AddOptionalParameter("limit", limit?.ToString())
                                .AddOptionalParameter("order", order?.ToValueString())
                                .AddOptionalParameter("order_by", orderBy?.ToValueString())
                                .AddOptionalParameter("active", active?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("ascending", ascending?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("project_id", projectId)
                                .AddOptionalParameter("conversation_id", conversationId)
                                .AddOptionalParameter("duration_percentile", durationPercentile?.ToString())
                                .AddOptionalParameter("duration_value", durationValue?.ToString())
                                .AddOptionalParameter("duration_operator", durationOperator?.ToString())
                                .AddOptionalParameter("start_date", startDate?.ToString())
                                .AddOptionalParameter("end_date", endDate?.ToString()) 
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
                PrepareListInternalRunsRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    runId: runId,
                    agentId: agentId,
                    agentIds: agentIds,
                    statuses: statuses,
                    background: background,
                    stopReason: stopReason,
                    templateFamily: templateFamily,
                    stepCount: stepCount,
                    stepCountOperator: stepCountOperator,
                    toolsUsed: toolsUsed,
                    before: before,
                    after: after,
                    limit: limit,
                    order: order,
                    orderBy: orderBy,
                    active: active,
                    ascending: ascending,
                    projectId: projectId,
                    conversationId: conversationId,
                    durationPercentile: durationPercentile,
                    durationValue: durationValue,
                    durationOperator: durationOperator,
                    startDate: startDate,
                    endDate: endDate);

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
                                operationId: "ListInternalRuns",
                                methodName: "ListInternalRunsAsync",
                                pathTemplate: "\"/v1/_internal_runs/\"",
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
                                operationId: "ListInternalRuns",
                                methodName: "ListInternalRunsAsync",
                                pathTemplate: "\"/v1/_internal_runs/\"",
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
                                operationId: "ListInternalRuns",
                                methodName: "ListInternalRunsAsync",
                                pathTemplate: "\"/v1/_internal_runs/\"",
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
                ProcessListInternalRunsResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::G.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListInternalRuns",
                                methodName: "ListInternalRunsAsync",
                                pathTemplate: "\"/v1/_internal_runs/\"",
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
                                operationId: "ListInternalRuns",
                                methodName: "ListInternalRunsAsync",
                                pathTemplate: "\"/v1/_internal_runs/\"",
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
                                ProcessListInternalRunsResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::System.Text.Json.JsonSerializer.Deserialize<global::System.Collections.Generic.IList<global::G.Run>?>(__content, JsonSerializerOptions) ??
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
                                        await global::System.Text.Json.JsonSerializer.DeserializeAsync<global::System.Collections.Generic.IList<global::G.Run>?>(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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