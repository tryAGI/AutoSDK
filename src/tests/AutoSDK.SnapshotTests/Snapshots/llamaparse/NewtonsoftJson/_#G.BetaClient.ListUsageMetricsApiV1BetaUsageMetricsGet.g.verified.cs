//HintName: G.BetaClient.ListUsageMetricsApiV1BetaUsageMetricsGet.g.cs

#nullable enable

namespace G
{
    public partial class BetaClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_ListUsageMetricsApiV1BetaUsageMetricsGetSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_ListUsageMetricsApiV1BetaUsageMetricsGetSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_ListUsageMetricsApiV1BetaUsageMetricsGetSecurityRequirement0,
            };
        partial void PrepareListUsageMetricsApiV1BetaUsageMetricsGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            int? pageSize,
            ref string? pageToken,
            ref bool? includeTotal,
            global::System.Guid? projectId,
            ref string? userId,
            global::System.Collections.Generic.IList<string>? eventTypes,
            global::System.Collections.Generic.IList<string>? days,
            ref string? dayOnOrBefore,
            ref string? dayOnOrAfter,
            ref string? eventAggregationType,
            ref string? eventAggregationKey,
            ref global::System.Guid organizationId,
            ref string? session);
        partial void PrepareListUsageMetricsApiV1BetaUsageMetricsGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? pageSize,
            string? pageToken,
            bool? includeTotal,
            global::System.Guid? projectId,
            string? userId,
            global::System.Collections.Generic.IList<string>? eventTypes,
            global::System.Collections.Generic.IList<string>? days,
            string? dayOnOrBefore,
            string? dayOnOrAfter,
            string? eventAggregationType,
            string? eventAggregationKey,
            global::System.Guid organizationId,
            string? session);
        partial void ProcessListUsageMetricsApiV1BetaUsageMetricsGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListUsageMetricsApiV1BetaUsageMetricsGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Usage Metrics<br/>
        /// List usage metrics with filtering and pagination.
        /// </summary>
        /// <param name="pageSize">
        /// Number of items per page
        /// </param>
        /// <param name="pageToken">
        /// Token for pagination
        /// </param>
        /// <param name="includeTotal">
        /// Include total count in response<br/>
        /// Default Value: false
        /// </param>
        /// <param name="projectId">
        /// Filter by project ID
        /// </param>
        /// <param name="userId">
        /// Filter by user ID
        /// </param>
        /// <param name="eventTypes">
        /// Filter by event types
        /// </param>
        /// <param name="days">
        /// Filter by specific days (YYYY-MM-DD)
        /// </param>
        /// <param name="dayOnOrBefore">
        /// Filter by days on or before this date (YYYY-MM-DD)
        /// </param>
        /// <param name="dayOnOrAfter">
        /// Filter by days on or after this date (YYYY-MM-DD)
        /// </param>
        /// <param name="eventAggregationType">
        /// Filter by event aggregation type
        /// </param>
        /// <param name="eventAggregationKey">
        /// Filter by event aggregation key
        /// </param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UsageMetricQueryResponse> ListUsageMetricsApiV1BetaUsageMetricsGetAsync(
            global::System.Guid organizationId,
            int? pageSize = default,
            string? pageToken = default,
            bool? includeTotal = default,
            global::System.Guid? projectId = default,
            string? userId = default,
            global::System.Collections.Generic.IList<string>? eventTypes = default,
            global::System.Collections.Generic.IList<string>? days = default,
            string? dayOnOrBefore = default,
            string? dayOnOrAfter = default,
            string? eventAggregationType = default,
            string? eventAggregationKey = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListUsageMetricsApiV1BetaUsageMetricsGetArguments(
                httpClient: HttpClient,
                pageSize: pageSize,
                pageToken: ref pageToken,
                includeTotal: ref includeTotal,
                projectId: projectId,
                userId: ref userId,
                eventTypes: eventTypes,
                days: days,
                dayOnOrBefore: ref dayOnOrBefore,
                dayOnOrAfter: ref dayOnOrAfter,
                eventAggregationType: ref eventAggregationType,
                eventAggregationKey: ref eventAggregationKey,
                organizationId: ref organizationId,
                session: ref session);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ListUsageMetricsApiV1BetaUsageMetricsGetSecurityRequirements,
                operationName: "ListUsageMetricsApiV1BetaUsageMetricsGetAsync");

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
                                path: "/api/v1/beta/usage-metrics",
                                baseUri: HttpClient.BaseAddress); 
                            __pathBuilder
                                .AddOptionalParameter("page_size", pageSize?.ToString())
                                .AddOptionalParameter("page_token", pageToken)
                                .AddOptionalParameter("include_total", includeTotal?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("project_id", projectId?.ToString())
                                .AddOptionalParameter("user_id", userId)
                                .AddOptionalParameter("event_types", eventTypes?.ToString())
                                .AddOptionalParameter("days", days?.ToString())
                                .AddOptionalParameter("day_on_or_before", dayOnOrBefore)
                                .AddOptionalParameter("day_on_or_after", dayOnOrAfter)
                                .AddOptionalParameter("event_aggregation_type", eventAggregationType)
                                .AddOptionalParameter("event_aggregation_key", eventAggregationKey)
                                .AddRequiredParameter("organization_id", organizationId.ToString()!) 
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
                            var __cookies = new global::System.Collections.Generic.List<string>();
                            var __session = session;
                            if (__session is not null)
                            {
                                __cookies.Add($"session={__session.ToString() ?? string.Empty}");
                            }
                            if (__cookies.Count > 0)
                            {
                                __httpRequest.Headers.TryAddWithoutValidation("Cookie", string.Join("; ", __cookies));
                            }

                global::G.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareListUsageMetricsApiV1BetaUsageMetricsGetRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    pageSize: pageSize,
                    pageToken: pageToken,
                    includeTotal: includeTotal,
                    projectId: projectId,
                    userId: userId,
                    eventTypes: eventTypes,
                    days: days,
                    dayOnOrBefore: dayOnOrBefore,
                    dayOnOrAfter: dayOnOrAfter,
                    eventAggregationType: eventAggregationType,
                    eventAggregationKey: eventAggregationKey,
                    organizationId: organizationId,
                    session: session);

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
                                operationId: "ListUsageMetricsApiV1BetaUsageMetricsGet",
                                methodName: "ListUsageMetricsApiV1BetaUsageMetricsGetAsync",
                                pathTemplate: "\"/api/v1/beta/usage-metrics\"",
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
                                operationId: "ListUsageMetricsApiV1BetaUsageMetricsGet",
                                methodName: "ListUsageMetricsApiV1BetaUsageMetricsGetAsync",
                                pathTemplate: "\"/api/v1/beta/usage-metrics\"",
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
                                operationId: "ListUsageMetricsApiV1BetaUsageMetricsGet",
                                methodName: "ListUsageMetricsApiV1BetaUsageMetricsGetAsync",
                                pathTemplate: "\"/api/v1/beta/usage-metrics\"",
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
                ProcessListUsageMetricsApiV1BetaUsageMetricsGetResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::G.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ListUsageMetricsApiV1BetaUsageMetricsGet",
                                methodName: "ListUsageMetricsApiV1BetaUsageMetricsGetAsync",
                                pathTemplate: "\"/api/v1/beta/usage-metrics\"",
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
                                operationId: "ListUsageMetricsApiV1BetaUsageMetricsGet",
                                methodName: "ListUsageMetricsApiV1BetaUsageMetricsGetAsync",
                                pathTemplate: "\"/api/v1/beta/usage-metrics\"",
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
                                ProcessListUsageMetricsApiV1BetaUsageMetricsGetResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::G.UsageMetricQueryResponse.FromJson(__content, JsonSerializerOptions) ??
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
                                        await global::G.UsageMetricQueryResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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