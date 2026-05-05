//HintName: G.UsageClient.Get3.g.cs

#nullable enable

namespace G
{
    public partial class UsageClient
    {
        partial void PrepareGet3Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.DateTimeOffset startUnix,
            ref global::System.DateTimeOffset endUnix,
            ref bool? includeWorkspaceMetrics,
            ref global::G.BreakdownTypes? breakdownType,
            ref global::G.UsageAggregationInterval? aggregationInterval,
            int? aggregationBucketSize,
            ref global::G.MetricType? metric,
            ref string? xiApiKey);
        partial void PrepareGet3Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.DateTimeOffset startUnix,
            global::System.DateTimeOffset endUnix,
            bool? includeWorkspaceMetrics,
            global::G.BreakdownTypes? breakdownType,
            global::G.UsageAggregationInterval? aggregationInterval,
            int? aggregationBucketSize,
            global::G.MetricType? metric,
            string? xiApiKey);
        partial void ProcessGet3Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGet3ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Characters Usage Metrics<br/>
        /// Returns the usage metrics for the current user or the entire workspace they are part of. The response provides a time axis based on the specified aggregation interval (default: day), with usage values for each interval along that axis. Usage is broken down by the selected breakdown type. For example, breakdown type "voice" will return the usage of each voice for each interval along the time axis.
        /// </summary>
        /// <param name="startUnix">
        /// UTC Unix timestamp for the start of the usage window, in milliseconds. To include the first day of the window, the timestamp should be at 00:00:00 of that day.
        /// </param>
        /// <param name="endUnix">
        /// UTC Unix timestamp for the end of the usage window, in milliseconds. To include the last day of the window, the timestamp should be at 23:59:59 of that day.
        /// </param>
        /// <param name="includeWorkspaceMetrics">
        /// Whether or not to include the statistics of the entire workspace.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="breakdownType">
        /// How to break down the information. Cannot be "user" if include_workspace_metrics is False.<br/>
        /// Default Value: none
        /// </param>
        /// <param name="aggregationInterval">
        /// How to aggregate usage data over time. Can be "hour", "day", "week", "month", or "cumulative".<br/>
        /// Default Value: day
        /// </param>
        /// <param name="aggregationBucketSize">
        /// Aggregation bucket size in seconds. Overrides the aggregation interval.
        /// </param>
        /// <param name="metric">
        /// Which metric to aggregate.<br/>
        /// Default Value: credits
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UsageCharactersResponseModel> Get3Async(
            global::System.DateTimeOffset startUnix,
            global::System.DateTimeOffset endUnix,
            bool? includeWorkspaceMetrics = default,
            global::G.BreakdownTypes? breakdownType = default,
            global::G.UsageAggregationInterval? aggregationInterval = default,
            int? aggregationBucketSize = default,
            global::G.MetricType? metric = default,
            string? xiApiKey = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await Get3AsResponseAsync(
                startUnix: startUnix,
                endUnix: endUnix,
                includeWorkspaceMetrics: includeWorkspaceMetrics,
                breakdownType: breakdownType,
                aggregationInterval: aggregationInterval,
                aggregationBucketSize: aggregationBucketSize,
                metric: metric,
                xiApiKey: xiApiKey,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Get Characters Usage Metrics<br/>
        /// Returns the usage metrics for the current user or the entire workspace they are part of. The response provides a time axis based on the specified aggregation interval (default: day), with usage values for each interval along that axis. Usage is broken down by the selected breakdown type. For example, breakdown type "voice" will return the usage of each voice for each interval along the time axis.
        /// </summary>
        /// <param name="startUnix">
        /// UTC Unix timestamp for the start of the usage window, in milliseconds. To include the first day of the window, the timestamp should be at 00:00:00 of that day.
        /// </param>
        /// <param name="endUnix">
        /// UTC Unix timestamp for the end of the usage window, in milliseconds. To include the last day of the window, the timestamp should be at 23:59:59 of that day.
        /// </param>
        /// <param name="includeWorkspaceMetrics">
        /// Whether or not to include the statistics of the entire workspace.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="breakdownType">
        /// How to break down the information. Cannot be "user" if include_workspace_metrics is False.<br/>
        /// Default Value: none
        /// </param>
        /// <param name="aggregationInterval">
        /// How to aggregate usage data over time. Can be "hour", "day", "week", "month", or "cumulative".<br/>
        /// Default Value: day
        /// </param>
        /// <param name="aggregationBucketSize">
        /// Aggregation bucket size in seconds. Overrides the aggregation interval.
        /// </param>
        /// <param name="metric">
        /// Which metric to aggregate.<br/>
        /// Default Value: credits
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.UsageCharactersResponseModel>> Get3AsResponseAsync(
            global::System.DateTimeOffset startUnix,
            global::System.DateTimeOffset endUnix,
            bool? includeWorkspaceMetrics = default,
            global::G.BreakdownTypes? breakdownType = default,
            global::G.UsageAggregationInterval? aggregationInterval = default,
            int? aggregationBucketSize = default,
            global::G.MetricType? metric = default,
            string? xiApiKey = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGet3Arguments(
                httpClient: HttpClient,
                startUnix: ref startUnix,
                endUnix: ref endUnix,
                includeWorkspaceMetrics: ref includeWorkspaceMetrics,
                breakdownType: ref breakdownType,
                aggregationInterval: ref aggregationInterval,
                aggregationBucketSize: aggregationBucketSize,
                metric: ref metric,
                xiApiKey: ref xiApiKey);

            var breakdownTypeValue = breakdownType switch
            {
                global::G.BreakdownTypes.None => "none",
                global::G.BreakdownTypes.Voice => "voice",
                global::G.BreakdownTypes.VoiceMultiplier => "voice_multiplier",
                global::G.BreakdownTypes.User => "user",
                global::G.BreakdownTypes.Groups => "groups",
                global::G.BreakdownTypes.ApiKeys => "api_keys",
                global::G.BreakdownTypes.AllApiKeys => "all_api_keys",
                global::G.BreakdownTypes.ProductType => "product_type",
                global::G.BreakdownTypes.Model => "model",
                global::G.BreakdownTypes.Resource => "resource",
                global::G.BreakdownTypes.RequestQueue => "request_queue",
                global::G.BreakdownTypes.Region => "region",
                global::G.BreakdownTypes.SubresourceId => "subresource_id",
                global::G.BreakdownTypes.ReportingWorkspaceId => "reporting_workspace_id",
                global::G.BreakdownTypes.HasApiKey => "has_api_key",
                global::G.BreakdownTypes.RequestSource => "request_source",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var aggregationIntervalValue = aggregationInterval switch
            {
                global::G.UsageAggregationInterval.Hour => "hour",
                global::G.UsageAggregationInterval.Day => "day",
                global::G.UsageAggregationInterval.Week => "week",
                global::G.UsageAggregationInterval.Month => "month",
                global::G.UsageAggregationInterval.Cumulative => "cumulative",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var metricValue = metric switch
            {
                global::G.MetricType.Credits => "credits",
                global::G.MetricType.TtsCharacters => "tts_characters",
                global::G.MetricType.MinutesUsed => "minutes_used",
                global::G.MetricType.RequestCount => "request_count",
                global::G.MetricType.TtfbAvg => "ttfb_avg",
                global::G.MetricType.TtfbP95 => "ttfb_p95",
                global::G.MetricType.FiatUnitsSpent => "fiat_units_spent",
                global::G.MetricType.Concurrency => "concurrency",
                global::G.MetricType.ConcurrencyAverage => "concurrency_average",
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
                                path: "/v1/usage/character-stats",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddRequiredParameter("start_unix", startUnix.ToString()!)
                                .AddRequiredParameter("end_unix", endUnix.ToString()!)
                                .AddOptionalParameter("include_workspace_metrics", includeWorkspaceMetrics?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("breakdown_type", breakdownType?.ToValueString())
                                .AddOptionalParameter("aggregation_interval", aggregationInterval?.ToValueString())
                                .AddOptionalParameter("aggregation_bucket_size", aggregationBucketSize?.ToString())
                                .AddOptionalParameter("metric", metric?.ToValueString())
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

            if (xiApiKey != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("xi-api-key", xiApiKey.ToString());
            }

                global::G.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareGet3Request(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    startUnix: startUnix!,
                    endUnix: endUnix!,
                    includeWorkspaceMetrics: includeWorkspaceMetrics,
                    breakdownType: breakdownType,
                    aggregationInterval: aggregationInterval,
                    aggregationBucketSize: aggregationBucketSize,
                    metric: metric,
                    xiApiKey: xiApiKey);

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
                                operationId: "Get3",
                                methodName: "Get3Async",
                                pathTemplate: "\"/v1/usage/character-stats\"",
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
                                operationId: "Get3",
                                methodName: "Get3Async",
                                pathTemplate: "\"/v1/usage/character-stats\"",
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
                                operationId: "Get3",
                                methodName: "Get3Async",
                                pathTemplate: "\"/v1/usage/character-stats\"",
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
                ProcessGet3Response(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::G.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "Get3",
                                methodName: "Get3Async",
                                pathTemplate: "\"/v1/usage/character-stats\"",
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
                                operationId: "Get3",
                                methodName: "Get3Async",
                                pathTemplate: "\"/v1/usage/character-stats\"",
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
                                ProcessGet3ResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::G.UsageCharactersResponseModel.FromJson(__content, JsonSerializerOptions) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::G.AutoSDKHttpResponse<global::G.UsageCharactersResponseModel>(
                                        statusCode: __response.StatusCode,
                                        headers: global::G.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
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

                                    var __value = await global::G.UsageCharactersResponseModel.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::G.AutoSDKHttpResponse<global::G.UsageCharactersResponseModel>(
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