//HintName: G.AgentsClient.AgentsListMetricResults.g.cs

#nullable enable

namespace G
{
    public partial class AgentsClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_AgentsListMetricResultsSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "TokenAuth",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_AgentsListMetricResultsSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_AgentsListMetricResultsSecurityRequirement0,
            };
        partial void PrepareAgentsListMetricResultsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.AgentsListMetricResultsCartesiaVersion cartesiaVersion,
            ref string? agentId,
            ref string? deploymentId,
            ref string? metricId,
            ref global::System.DateTime? startDate,
            ref global::System.DateTime? endDate,
            ref string? callId,
            ref string? startingAfter,
            ref string? endingBefore,
            ref int? limit);
        partial void PrepareAgentsListMetricResultsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.AgentsListMetricResultsCartesiaVersion cartesiaVersion,
            string? agentId,
            string? deploymentId,
            string? metricId,
            global::System.DateTime? startDate,
            global::System.DateTime? endDate,
            string? callId,
            string? startingAfter,
            string? endingBefore,
            int? limit);
        partial void ProcessAgentsListMetricResultsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAgentsListMetricResultsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Metric Results<br/>
        /// Paginated list of metric results. Filter results using the query parameters,
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="metricId"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="callId"></param>
        /// <param name="startingAfter"></param>
        /// <param name="endingBefore"></param>
        /// <param name="limit"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListMetricResultsResponse> AgentsListMetricResultsAsync(
            global::G.AgentsListMetricResultsCartesiaVersion cartesiaVersion,
            string? agentId = default,
            string? deploymentId = default,
            string? metricId = default,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            string? callId = default,
            string? startingAfter = default,
            string? endingBefore = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareAgentsListMetricResultsArguments(
                httpClient: HttpClient,
                cartesiaVersion: ref cartesiaVersion,
                agentId: ref agentId,
                deploymentId: ref deploymentId,
                metricId: ref metricId,
                startDate: ref startDate,
                endDate: ref endDate,
                callId: ref callId,
                startingAfter: ref startingAfter,
                endingBefore: ref endingBefore,
                limit: ref limit);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_AgentsListMetricResultsSecurityRequirements,
                operationName: "AgentsListMetricResultsAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/agents/metrics/results",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("agent_id", agentId)
                .AddOptionalParameter("deployment_id", deploymentId)
                .AddOptionalParameter("metric_id", metricId)
                .AddOptionalParameter("start_date", startDate?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddOptionalParameter("end_date", endDate?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddOptionalParameter("call_id", callId)
                .AddOptionalParameter("starting_after", startingAfter)
                .AddOptionalParameter("ending_before", endingBefore)
                .AddOptionalParameter("limit", limit?.ToString()) 
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

            __httpRequest.Headers.TryAddWithoutValidation("Cartesia-Version", cartesiaVersion.ToValueString());


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareAgentsListMetricResultsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                cartesiaVersion: cartesiaVersion,
                agentId: agentId,
                deploymentId: deploymentId,
                metricId: metricId,
                startDate: startDate,
                endDate: endDate,
                callId: callId,
                startingAfter: startingAfter,
                endingBefore: endingBefore,
                limit: limit);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAgentsListMetricResultsResponse(
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
                ProcessAgentsListMetricResultsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.ListMetricResultsResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.ListMetricResultsResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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