//HintName: G.ModelsClient.GetAnalytics.g.cs

#nullable enable

namespace G
{
    public partial class ModelsClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_GetAnalyticsSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "ApiKey",
                        Location = "Header",
                        Name = "Authorization",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_GetAnalyticsSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_GetAnalyticsSecurityRequirement0,
            };
        partial void PrepareGetAnalyticsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? limit,
            ref string? cursor,
            ref global::G.AnyOf<global::System.DateTime?, string>? start,
            ref global::G.AnyOf<global::System.DateTime?, string>? end,
            ref string? timezone,
            ref global::G.GetAnalyticsTimeframe? timeframe,
            ref global::G.GetAnalyticsBoundToTimeframe? boundToTimeframe,
            ref global::G.AnyOf<string, global::System.Collections.Generic.IList<string>> endpointId,
            ref global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? expand);
        partial void PrepareGetAnalyticsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? limit,
            string? cursor,
            global::G.AnyOf<global::System.DateTime?, string>? start,
            global::G.AnyOf<global::System.DateTime?, string>? end,
            string? timezone,
            global::G.GetAnalyticsTimeframe? timeframe,
            global::G.GetAnalyticsBoundToTimeframe? boundToTimeframe,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>> endpointId,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? expand);
        partial void ProcessGetAnalyticsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetAnalyticsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Analytics<br/>
        /// Time-bucketed metrics per model endpoint, including request counts, success/error<br/>
        /// rates, and latency percentiles. `prepare_duration` reflects queue/prepare<br/>
        /// time before execution; `duration` is request execution time. Use with the<br/>
        /// Queue/Webhooks flow to monitor SLAs.<br/>
        /// **Metric Selection:**<br/>
        /// You must specify which metrics to include using the `expand` query<br/>
        /// parameter. Only requested metrics will be populated in the response,<br/>
        /// allowing you to optimize query performance and data transfer.<br/>
        /// **Available Metrics:**<br/>
        /// - `request_count`: Total number of requests in the time bucket<br/>
        /// - `success_count`: Number of successful requests (2xx responses)<br/>
        /// - `user_error_count`: Number of user errors (4xx responses)<br/>
        /// - `error_count`: Number of server errors (5xx responses)<br/>
        /// - `p50_prepare_duration`: 50th percentile queue/prepare time<br/>
        /// - `p75_prepare_duration`: 75th percentile queue/prepare time<br/>
        /// - `p90_prepare_duration`: 90th percentile queue/prepare time<br/>
        /// - `p50_duration`: 50th percentile request execution duration<br/>
        /// - `p75_duration`: 75th percentile request execution duration<br/>
        /// - `p90_duration`: 90th percentile request execution duration<br/>
        /// **Key Features:**<br/>
        /// - Selective metric inclusion via expand parameter<br/>
        /// - Performance metrics (latency percentiles, duration stats)<br/>
        /// - Reliability metrics (success/error rates, request counts)<br/>
        /// - Time-bucketed data for trend analysis<br/>
        /// - Single or multi-model analytics<br/>
        /// - Flexible date range and timeframe options<br/>
        /// **Common Use Cases:**<br/>
        /// - Monitor model performance and reliability<br/>
        /// - Generate performance dashboards<br/>
        /// - Analyze latency trends and patterns<br/>
        /// - Track error rates and success metrics<br/>
        /// See [Queue API docs](https://docs.fal.ai/model-apis/model-endpoints/queue) for more details.<br/>
        ///     
        /// </summary>
        /// <param name="limit">
        /// Maximum number of items to return. Actual maximum depends on query type and expansion parameters.<br/>
        /// Example: 50
        /// </param>
        /// <param name="cursor">
        /// Pagination cursor from previous response. Encodes the page number.<br/>
        /// Example: Mg==
        /// </param>
        /// <param name="start">
        /// Start date in ISO8601 format (e.g., '2025-01-01T00:00:00Z' or '2025-01-01'). Defaults to 24 hours ago.<br/>
        /// Example: 2025-01-01T00:00:00Z
        /// </param>
        /// <param name="end">
        /// End date in ISO8601 format, exclusive (e.g., '2025-02-01T00:00:00Z' or '2025-02-01'). Data up to but not including this timestamp is returned. Defaults to current time.<br/>
        /// Example: 2025-02-01T00:00:00Z
        /// </param>
        /// <param name="timezone">
        /// Timezone for date aggregation and boundaries. All timestamps in responses are in UTC, but this controls how dates are bucketed.<br/>
        /// Default Value: UTC<br/>
        /// Example: UTC
        /// </param>
        /// <param name="timeframe">
        /// Aggregation timeframe for timeseries data (auto-detected from date range if not specified). Auto-detection uses: minute (&lt;2h), hour (&lt;2d), day (&lt;64d), week (&lt;183d), month (&gt;=183d).<br/>
        /// Example: day
        /// </param>
        /// <param name="boundToTimeframe">
        /// Whether to adjust start/end dates to align with timeframe boundaries and use exclusive end. Defaults to true. When true, dates are aligned to the start of the timeframe period (e.g., start of day) and end is made exclusive (e.g., start of next day). When false, uses exact dates provided.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="endpointId">
        /// Filter by specific endpoint ID(s). Accepts 1-50 endpoint IDs. Supports comma-separated values: ?endpoint_id=model1,model2 or array syntax: ?endpoint_id=model1&amp;endpoint_id=model2<br/>
        /// Example: [fal-ai/flux/dev]
        /// </param>
        /// <param name="expand">
        /// Data and metrics to include in the response. Use 'time_series' for time-bucketed data, metric names for specific metrics in time series, and 'summary' for aggregate statistics. At least one of 'time_series' or 'summary' and at least one metric are required.<br/>
        /// Default Value: [time_series, request_count]<br/>
        /// Example: [request_count, success_count]
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetAnalyticsResponse> GetAnalyticsAsync(
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>> endpointId,
            int? limit = default,
            string? cursor = default,
            global::G.AnyOf<global::System.DateTime?, string>? start = default,
            global::G.AnyOf<global::System.DateTime?, string>? end = default,
            string? timezone = default,
            global::G.GetAnalyticsTimeframe? timeframe = default,
            global::G.GetAnalyticsBoundToTimeframe? boundToTimeframe = default,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>>? expand = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetAnalyticsArguments(
                httpClient: HttpClient,
                limit: ref limit,
                cursor: ref cursor,
                start: ref start,
                end: ref end,
                timezone: ref timezone,
                timeframe: ref timeframe,
                boundToTimeframe: ref boundToTimeframe,
                endpointId: ref endpointId,
                expand: ref expand);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetAnalyticsSecurityRequirements,
                operationName: "GetAnalyticsAsync");

            var timeframeValue = timeframe switch
            {
                global::G.GetAnalyticsTimeframe.Minute => "minute",
                global::G.GetAnalyticsTimeframe.Hour => "hour",
                global::G.GetAnalyticsTimeframe.Day => "day",
                global::G.GetAnalyticsTimeframe.Week => "week",
                global::G.GetAnalyticsTimeframe.Month => "month",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var boundToTimeframeValue = boundToTimeframe switch
            {
                global::G.GetAnalyticsBoundToTimeframe.True => "true",
                global::G.GetAnalyticsBoundToTimeframe.False => "false",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/models/analytics",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("limit", limit?.ToString())
                .AddOptionalParameter("cursor", cursor)
                .AddOptionalParameter("start", start?.ToString())
                .AddOptionalParameter("end", end?.ToString())
                .AddOptionalParameter("timezone", timezone)
                .AddOptionalParameter("timeframe", timeframe?.ToValueString())
                .AddOptionalParameter("bound_to_timeframe", boundToTimeframe?.ToValueString())
                .AddRequiredParameter("endpoint_id", endpointId.ToString() ?? string.Empty)
                .AddOptionalParameter("expand", expand?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            var __cookies = new global::System.Collections.Generic.List<string>();
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
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Cookie")
                {
                    var __cookieValue = global::System.Uri.EscapeDataString(__authorization.Value);
                    __cookies.Add($"{__authorization.Name}={__cookieValue}");
                }
            }

            if (__cookies.Count > 0)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Cookie", string.Join("; ", __cookies));
            }

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetAnalyticsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                limit: limit,
                cursor: cursor,
                start: start,
                end: end,
                timezone: timezone,
                timeframe: timeframe,
                boundToTimeframe: boundToTimeframe,
                endpointId: endpointId,
                expand: expand);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetAnalyticsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Invalid request parameters
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.GetAnalyticsResponse2? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.GetAnalyticsResponse2.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.GetAnalyticsResponse2.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.GetAnalyticsResponse2>(
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
            // Authentication required
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                global::G.GetAnalyticsResponse3? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::G.GetAnalyticsResponse3.FromJson(__content_401, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::G.GetAnalyticsResponse3.FromJson(__content_401, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::G.ApiException<global::G.GetAnalyticsResponse3>(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseObject = __value_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Access denied
            if ((int)__response.StatusCode == 403)
            {
                string? __content_403 = null;
                global::System.Exception? __exception_403 = null;
                global::G.GetAnalyticsResponse4? __value_403 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_403 = global::G.GetAnalyticsResponse4.FromJson(__content_403, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_403 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_403 = global::G.GetAnalyticsResponse4.FromJson(__content_403, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_403 = __ex;
                }

                throw new global::G.ApiException<global::G.GetAnalyticsResponse4>(
                    message: __content_403 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_403,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_403,
                    ResponseObject = __value_403,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Resource not found
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                global::G.GetAnalyticsResponse5? __value_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_404 = global::G.GetAnalyticsResponse5.FromJson(__content_404, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_404 = global::G.GetAnalyticsResponse5.FromJson(__content_404, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::G.ApiException<global::G.GetAnalyticsResponse5>(
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
            // Rate limit exceeded
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::System.Exception? __exception_429 = null;
                global::G.GetAnalyticsResponse6? __value_429 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_429 = global::G.GetAnalyticsResponse6.FromJson(__content_429, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_429 = global::G.GetAnalyticsResponse6.FromJson(__content_429, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_429 = __ex;
                }

                throw new global::G.ApiException<global::G.GetAnalyticsResponse6>(
                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_429,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_429,
                    ResponseObject = __value_429,
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
                ProcessGetAnalyticsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.GetAnalyticsResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.GetAnalyticsResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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