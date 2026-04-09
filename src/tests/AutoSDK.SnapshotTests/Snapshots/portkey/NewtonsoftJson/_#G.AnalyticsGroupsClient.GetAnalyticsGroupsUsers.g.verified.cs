//HintName: G.AnalyticsGroupsClient.GetAnalyticsGroupsUsers.g.cs

#nullable enable

namespace G
{
    public partial class AnalyticsGroupsClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_GetAnalyticsGroupsUsersSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_GetAnalyticsGroupsUsersSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_GetAnalyticsGroupsUsersSecurityRequirement0,
            };
        partial void PrepareGetAnalyticsGroupsUsersArguments(
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
            ref int? currentPage,
            ref int? pageSize,
            ref string? metadata,
            ref string? aiOrgModel,
            ref string? traceId,
            ref string? spanId,
            ref string? promptSlug);
        partial void PrepareGetAnalyticsGroupsUsersRequest(
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
            int? currentPage,
            int? pageSize,
            string? metadata,
            string? aiOrgModel,
            string? traceId,
            string? spanId,
            string? promptSlug);
        partial void ProcessGetAnalyticsGroupsUsersResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetAnalyticsGroupsUsersResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get metadata users grouped data.
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
        /// <param name="currentPage"></param>
        /// <param name="pageSize"></param>
        /// <param name="metadata"></param>
        /// <param name="aiOrgModel"></param>
        /// <param name="traceId"></param>
        /// <param name="spanId"></param>
        /// <param name="promptSlug"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetAnalyticsGroupsUsersResponse> GetAnalyticsGroupsUsersAsync(
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
            int? currentPage = default,
            int? pageSize = default,
            string? metadata = default,
            string? aiOrgModel = default,
            string? traceId = default,
            string? spanId = default,
            string? promptSlug = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GetAnalyticsGroupsUsersAsResponseAsync(
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
                currentPage: currentPage,
                pageSize: pageSize,
                metadata: metadata,
                aiOrgModel: aiOrgModel,
                traceId: traceId,
                spanId: spanId,
                promptSlug: promptSlug,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Get metadata users grouped data.
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
        /// <param name="currentPage"></param>
        /// <param name="pageSize"></param>
        /// <param name="metadata"></param>
        /// <param name="aiOrgModel"></param>
        /// <param name="traceId"></param>
        /// <param name="spanId"></param>
        /// <param name="promptSlug"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.GetAnalyticsGroupsUsersResponse>> GetAnalyticsGroupsUsersAsResponseAsync(
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
            int? currentPage = default,
            int? pageSize = default,
            string? metadata = default,
            string? aiOrgModel = default,
            string? traceId = default,
            string? spanId = default,
            string? promptSlug = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetAnalyticsGroupsUsersArguments(
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
                currentPage: ref currentPage,
                pageSize: ref pageSize,
                metadata: ref metadata,
                aiOrgModel: ref aiOrgModel,
                traceId: ref traceId,
                spanId: ref spanId,
                promptSlug: ref promptSlug);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetAnalyticsGroupsUsersSecurityRequirements,
                operationName: "GetAnalyticsGroupsUsersAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/analytics/groups/users",
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
                .AddOptionalParameter("current_page", currentPage?.ToString())
                .AddOptionalParameter("page_size", pageSize?.ToString())
                .AddOptionalParameter("metadata", metadata)
                .AddOptionalParameter("ai_org_model", aiOrgModel)
                .AddOptionalParameter("trace_id", traceId)
                .AddOptionalParameter("span_id", spanId)
                .AddOptionalParameter("prompt_slug", promptSlug) 
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
            PrepareGetAnalyticsGroupsUsersRequest(
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
                currentPage: currentPage,
                pageSize: pageSize,
                metadata: metadata,
                aiOrgModel: aiOrgModel,
                traceId: traceId,
                spanId: spanId,
                promptSlug: promptSlug);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetAnalyticsGroupsUsersResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

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
                ProcessGetAnalyticsGroupsUsersResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    var __value = global::G.GetAnalyticsGroupsUsersResponse.FromJson(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                    return new global::G.AutoSDKHttpResponse<global::G.GetAnalyticsGroupsUsersResponse>(
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
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    var __value = await global::G.GetAnalyticsGroupsUsersResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                    return new global::G.AutoSDKHttpResponse<global::G.GetAnalyticsGroupsUsersResponse>(
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