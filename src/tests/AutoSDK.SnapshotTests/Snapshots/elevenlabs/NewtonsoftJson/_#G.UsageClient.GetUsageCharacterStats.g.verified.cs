//HintName: G.UsageClient.GetUsageCharacterStats.g.cs

#nullable enable

namespace G
{
    public partial class UsageClient
    {
        partial void PrepareGetUsageCharacterStatsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.DateTimeOffset startUnix,
            ref global::System.DateTimeOffset endUnix,
            ref bool? includeWorkspaceMetrics,
            ref global::G.BreakdownTypes? breakdownType,
            ref global::G.UsageAggregationInterval? aggregationInterval,
            ref global::G.MetricType? metric,
            ref string? xiApiKey);
        partial void PrepareGetUsageCharacterStatsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.DateTimeOffset startUnix,
            global::System.DateTimeOffset endUnix,
            bool? includeWorkspaceMetrics,
            global::G.BreakdownTypes? breakdownType,
            global::G.UsageAggregationInterval? aggregationInterval,
            global::G.MetricType? metric,
            string? xiApiKey);
        partial void ProcessGetUsageCharacterStatsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetUsageCharacterStatsResponseContent(
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
        /// <param name="metric">
        /// Which metric to aggregate.<br/>
        /// Default Value: credits
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.UsageCharactersResponseModel> GetUsageCharacterStatsAsync(
            global::System.DateTimeOffset startUnix,
            global::System.DateTimeOffset endUnix,
            bool? includeWorkspaceMetrics = default,
            global::G.BreakdownTypes? breakdownType = default,
            global::G.UsageAggregationInterval? aggregationInterval = default,
            global::G.MetricType? metric = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetUsageCharacterStatsArguments(
                httpClient: HttpClient,
                startUnix: ref startUnix,
                endUnix: ref endUnix,
                includeWorkspaceMetrics: ref includeWorkspaceMetrics,
                breakdownType: ref breakdownType,
                aggregationInterval: ref aggregationInterval,
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
                global::G.MetricType.MinutesUsed => "minutes_used",
                global::G.MetricType.RequestCount => "request_count",
                global::G.MetricType.TtfbAvg => "ttfb_avg",
                global::G.MetricType.TtfbP95 => "ttfb_p95",
                global::G.MetricType.FiatUnitsSpent => "fiat_units_spent",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/usage/character-stats",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddRequiredParameter("start_unix", startUnix.ToString())
                .AddRequiredParameter("end_unix", endUnix.ToString())
                .AddOptionalParameter("include_workspace_metrics", includeWorkspaceMetrics?.ToString())
                .AddOptionalParameter("breakdown_type", breakdownType?.ToValueString())
                .AddOptionalParameter("aggregation_interval", aggregationInterval?.ToValueString())
                .AddOptionalParameter("metric", metric?.ToValueString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
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


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetUsageCharacterStatsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                startUnix: startUnix,
                endUnix: endUnix,
                includeWorkspaceMetrics: includeWorkspaceMetrics,
                breakdownType: breakdownType,
                aggregationInterval: aggregationInterval,
                metric: metric,
                xiApiKey: xiApiKey);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetUsageCharacterStatsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::G.HTTPValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                    else
                    {
                        var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = await global::G.HTTPValidationError.FromJsonStreamAsync(__contentStream_422, JsonSerializerOptions).ConfigureAwait(false);
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
                ProcessGetUsageCharacterStatsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.UsageCharactersResponseModel.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.UsageCharactersResponseModel.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::G.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
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