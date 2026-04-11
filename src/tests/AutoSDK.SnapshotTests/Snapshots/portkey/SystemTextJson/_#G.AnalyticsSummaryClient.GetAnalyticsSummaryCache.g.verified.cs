//HintName: G.AnalyticsSummaryClient.GetAnalyticsSummaryCache.g.cs

#nullable enable

namespace G
{
    public partial class AnalyticsSummaryClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_GetAnalyticsSummaryCacheSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "PortkeyKey",
                        Location = "Header",
                        Name = "x-portkey-api-key",
                        FriendlyName = "PortkeyKey",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_GetAnalyticsSummaryCacheSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_GetAnalyticsSummaryCacheSecurityRequirement0,
            };
        partial void PrepareGetAnalyticsSummaryCacheArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string workspaceSlug,
            ref global::System.DateTime timeOfGenerationMin,
            ref global::System.DateTime timeOfGenerationMax,
            ref int? totalUnitsMin,
            ref int? totalUnitsMax,
            ref double? costMin,
            ref double? costMax,
            ref int? promptTokenMin,
            ref int? promptTokenMax,
            ref int? completionTokenMin,
            ref int? completionTokenMax,
            ref string? statusCode,
            ref double? weightedFeedbackMin,
            ref double? weightedFeedbackMax,
            ref string? virtualKeys,
            ref string? configs,
            ref string? apiKeyIds,
            ref string? metadata,
            ref string? aiOrgModel,
            ref string? traceId,
            ref string? spanId,
            ref string? promptSlug);
        partial void PrepareGetAnalyticsSummaryCacheRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string workspaceSlug,
            global::System.DateTime timeOfGenerationMin,
            global::System.DateTime timeOfGenerationMax,
            int? totalUnitsMin,
            int? totalUnitsMax,
            double? costMin,
            double? costMax,
            int? promptTokenMin,
            int? promptTokenMax,
            int? completionTokenMin,
            int? completionTokenMax,
            string? statusCode,
            double? weightedFeedbackMin,
            double? weightedFeedbackMax,
            string? virtualKeys,
            string? configs,
            string? apiKeyIds,
            string? metadata,
            string? aiOrgModel,
            string? traceId,
            string? spanId,
            string? promptSlug);
        partial void ProcessGetAnalyticsSummaryCacheResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetAnalyticsSummaryCacheResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get cache summary data for the selected time period
        /// </summary>
        /// <param name="workspaceSlug"></param>
        /// <param name="timeOfGenerationMin">
        /// Example: 2026-02-23T14:20:31+05:30
        /// </param>
        /// <param name="timeOfGenerationMax">
        /// Example: 2026-02-24T14:20:31+05:30
        /// </param>
        /// <param name="totalUnitsMin"></param>
        /// <param name="totalUnitsMax"></param>
        /// <param name="costMin"></param>
        /// <param name="costMax"></param>
        /// <param name="promptTokenMin"></param>
        /// <param name="promptTokenMax"></param>
        /// <param name="completionTokenMin"></param>
        /// <param name="completionTokenMax"></param>
        /// <param name="statusCode"></param>
        /// <param name="weightedFeedbackMin"></param>
        /// <param name="weightedFeedbackMax"></param>
        /// <param name="virtualKeys"></param>
        /// <param name="configs"></param>
        /// <param name="apiKeyIds"></param>
        /// <param name="metadata"></param>
        /// <param name="aiOrgModel"></param>
        /// <param name="traceId"></param>
        /// <param name="spanId"></param>
        /// <param name="promptSlug"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetAnalyticsSummaryCacheResponse> GetAnalyticsSummaryCacheAsync(
            string workspaceSlug,
            global::System.DateTime timeOfGenerationMin,
            global::System.DateTime timeOfGenerationMax,
            int? totalUnitsMin = default,
            int? totalUnitsMax = default,
            double? costMin = default,
            double? costMax = default,
            int? promptTokenMin = default,
            int? promptTokenMax = default,
            int? completionTokenMin = default,
            int? completionTokenMax = default,
            string? statusCode = default,
            double? weightedFeedbackMin = default,
            double? weightedFeedbackMax = default,
            string? virtualKeys = default,
            string? configs = default,
            string? apiKeyIds = default,
            string? metadata = default,
            string? aiOrgModel = default,
            string? traceId = default,
            string? spanId = default,
            string? promptSlug = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GetAnalyticsSummaryCacheAsResponseAsync(
                workspaceSlug: workspaceSlug,
                timeOfGenerationMin: timeOfGenerationMin,
                timeOfGenerationMax: timeOfGenerationMax,
                totalUnitsMin: totalUnitsMin,
                totalUnitsMax: totalUnitsMax,
                costMin: costMin,
                costMax: costMax,
                promptTokenMin: promptTokenMin,
                promptTokenMax: promptTokenMax,
                completionTokenMin: completionTokenMin,
                completionTokenMax: completionTokenMax,
                statusCode: statusCode,
                weightedFeedbackMin: weightedFeedbackMin,
                weightedFeedbackMax: weightedFeedbackMax,
                virtualKeys: virtualKeys,
                configs: configs,
                apiKeyIds: apiKeyIds,
                metadata: metadata,
                aiOrgModel: aiOrgModel,
                traceId: traceId,
                spanId: spanId,
                promptSlug: promptSlug,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Get cache summary data for the selected time period
        /// </summary>
        /// <param name="workspaceSlug"></param>
        /// <param name="timeOfGenerationMin">
        /// Example: 2026-02-23T14:20:31+05:30
        /// </param>
        /// <param name="timeOfGenerationMax">
        /// Example: 2026-02-24T14:20:31+05:30
        /// </param>
        /// <param name="totalUnitsMin"></param>
        /// <param name="totalUnitsMax"></param>
        /// <param name="costMin"></param>
        /// <param name="costMax"></param>
        /// <param name="promptTokenMin"></param>
        /// <param name="promptTokenMax"></param>
        /// <param name="completionTokenMin"></param>
        /// <param name="completionTokenMax"></param>
        /// <param name="statusCode"></param>
        /// <param name="weightedFeedbackMin"></param>
        /// <param name="weightedFeedbackMax"></param>
        /// <param name="virtualKeys"></param>
        /// <param name="configs"></param>
        /// <param name="apiKeyIds"></param>
        /// <param name="metadata"></param>
        /// <param name="aiOrgModel"></param>
        /// <param name="traceId"></param>
        /// <param name="spanId"></param>
        /// <param name="promptSlug"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.GetAnalyticsSummaryCacheResponse>> GetAnalyticsSummaryCacheAsResponseAsync(
            string workspaceSlug,
            global::System.DateTime timeOfGenerationMin,
            global::System.DateTime timeOfGenerationMax,
            int? totalUnitsMin = default,
            int? totalUnitsMax = default,
            double? costMin = default,
            double? costMax = default,
            int? promptTokenMin = default,
            int? promptTokenMax = default,
            int? completionTokenMin = default,
            int? completionTokenMax = default,
            string? statusCode = default,
            double? weightedFeedbackMin = default,
            double? weightedFeedbackMax = default,
            string? virtualKeys = default,
            string? configs = default,
            string? apiKeyIds = default,
            string? metadata = default,
            string? aiOrgModel = default,
            string? traceId = default,
            string? spanId = default,
            string? promptSlug = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetAnalyticsSummaryCacheArguments(
                httpClient: HttpClient,
                workspaceSlug: ref workspaceSlug,
                timeOfGenerationMin: ref timeOfGenerationMin,
                timeOfGenerationMax: ref timeOfGenerationMax,
                totalUnitsMin: ref totalUnitsMin,
                totalUnitsMax: ref totalUnitsMax,
                costMin: ref costMin,
                costMax: ref costMax,
                promptTokenMin: ref promptTokenMin,
                promptTokenMax: ref promptTokenMax,
                completionTokenMin: ref completionTokenMin,
                completionTokenMax: ref completionTokenMax,
                statusCode: ref statusCode,
                weightedFeedbackMin: ref weightedFeedbackMin,
                weightedFeedbackMax: ref weightedFeedbackMax,
                virtualKeys: ref virtualKeys,
                configs: ref configs,
                apiKeyIds: ref apiKeyIds,
                metadata: ref metadata,
                aiOrgModel: ref aiOrgModel,
                traceId: ref traceId,
                spanId: ref spanId,
                promptSlug: ref promptSlug);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetAnalyticsSummaryCacheSecurityRequirements,
                operationName: "GetAnalyticsSummaryCacheAsync");

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
                                path: "/analytics/summary/cache",
                                baseUri: HttpClient.BaseAddress); 
                            __pathBuilder
                                .AddRequiredParameter("workspace_slug", workspaceSlug)
                                .AddRequiredParameter("time_of_generation_min", timeOfGenerationMin.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddRequiredParameter("time_of_generation_max", timeOfGenerationMax.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                                .AddOptionalParameter("total_units_min", totalUnitsMin?.ToString())
                                .AddOptionalParameter("total_units_max", totalUnitsMax?.ToString())
                                .AddOptionalParameter("cost_min", costMin?.ToString())
                                .AddOptionalParameter("cost_max", costMax?.ToString())
                                .AddOptionalParameter("prompt_token_min", promptTokenMin?.ToString())
                                .AddOptionalParameter("prompt_token_max", promptTokenMax?.ToString())
                                .AddOptionalParameter("completion_token_min", completionTokenMin?.ToString())
                                .AddOptionalParameter("completion_token_max", completionTokenMax?.ToString())
                                .AddOptionalParameter("status_code", statusCode)
                                .AddOptionalParameter("weighted_feedback_min", weightedFeedbackMin?.ToString())
                                .AddOptionalParameter("weighted_feedback_max", weightedFeedbackMax?.ToString())
                                .AddOptionalParameter("virtual_keys", virtualKeys)
                                .AddOptionalParameter("configs", configs)
                                .AddOptionalParameter("api_key_ids", apiKeyIds)
                                .AddOptionalParameter("metadata", metadata)
                                .AddOptionalParameter("ai_org_model", aiOrgModel)
                                .AddOptionalParameter("trace_id", traceId)
                                .AddOptionalParameter("span_id", spanId)
                                .AddOptionalParameter("prompt_slug", promptSlug) 
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
                PrepareGetAnalyticsSummaryCacheRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    workspaceSlug: workspaceSlug,
                    timeOfGenerationMin: timeOfGenerationMin,
                    timeOfGenerationMax: timeOfGenerationMax,
                    totalUnitsMin: totalUnitsMin,
                    totalUnitsMax: totalUnitsMax,
                    costMin: costMin,
                    costMax: costMax,
                    promptTokenMin: promptTokenMin,
                    promptTokenMax: promptTokenMax,
                    completionTokenMin: completionTokenMin,
                    completionTokenMax: completionTokenMax,
                    statusCode: statusCode,
                    weightedFeedbackMin: weightedFeedbackMin,
                    weightedFeedbackMax: weightedFeedbackMax,
                    virtualKeys: virtualKeys,
                    configs: configs,
                    apiKeyIds: apiKeyIds,
                    metadata: metadata,
                    aiOrgModel: aiOrgModel,
                    traceId: traceId,
                    spanId: spanId,
                    promptSlug: promptSlug);

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
                                operationId: "getAnalyticsSummaryCache",
                                methodName: "GetAnalyticsSummaryCacheAsync",
                                pathTemplate: "\"/analytics/summary/cache\"",
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
                                operationId: "getAnalyticsSummaryCache",
                                methodName: "GetAnalyticsSummaryCacheAsync",
                                pathTemplate: "\"/analytics/summary/cache\"",
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
                                operationId: "getAnalyticsSummaryCache",
                                methodName: "GetAnalyticsSummaryCacheAsync",
                                pathTemplate: "\"/analytics/summary/cache\"",
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
                ProcessGetAnalyticsSummaryCacheResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::G.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getAnalyticsSummaryCache",
                                methodName: "GetAnalyticsSummaryCacheAsync",
                                pathTemplate: "\"/analytics/summary/cache\"",
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
                                operationId: "getAnalyticsSummaryCache",
                                methodName: "GetAnalyticsSummaryCacheAsync",
                                pathTemplate: "\"/analytics/summary/cache\"",
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
                                ProcessGetAnalyticsSummaryCacheResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::G.GetAnalyticsSummaryCacheResponse.FromJson(__content, JsonSerializerOptions) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::G.AutoSDKHttpResponse<global::G.GetAnalyticsSummaryCacheResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::G.AutoSDKHttpResponse.CreateHeaders(__response),
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

                                    var __value = await global::G.GetAnalyticsSummaryCacheResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::G.AutoSDKHttpResponse<global::G.GetAnalyticsSummaryCacheResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::G.AutoSDKHttpResponse.CreateHeaders(__response),
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