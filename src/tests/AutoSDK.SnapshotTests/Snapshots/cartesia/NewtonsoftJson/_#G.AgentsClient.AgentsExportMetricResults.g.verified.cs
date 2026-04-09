//HintName: G.AgentsClient.AgentsExportMetricResults.g.cs

#nullable enable

namespace G
{
    public partial class AgentsClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_AgentsExportMetricResultsSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_AgentsExportMetricResultsSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_AgentsExportMetricResultsSecurityRequirement0,
            };
        partial void PrepareAgentsExportMetricResultsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.AgentsExportMetricResultsCartesiaVersion cartesiaVersion,
            ref string? agentId,
            ref string? deploymentId,
            ref string? metricId,
            ref string? callId,
            ref global::System.DateTime? startDate,
            ref global::System.DateTime? endDate);
        partial void PrepareAgentsExportMetricResultsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.AgentsExportMetricResultsCartesiaVersion cartesiaVersion,
            string? agentId,
            string? deploymentId,
            string? metricId,
            string? callId,
            global::System.DateTime? startDate,
            global::System.DateTime? endDate);
        partial void ProcessAgentsExportMetricResultsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAgentsExportMetricResultsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref byte[] content);

        /// <summary>
        /// Export Metric Results<br/>
        /// Export metric results to a CSV file. This endpoint streams at most 100k results as the CSV file directly to the client. Use the optional filters to narrow down the results to export.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="metricId"></param>
        /// <param name="callId"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<byte[]> AgentsExportMetricResultsAsync(
            global::G.AgentsExportMetricResultsCartesiaVersion cartesiaVersion,
            string? agentId = default,
            string? deploymentId = default,
            string? metricId = default,
            string? callId = default,
            global::System.DateTime? startDate = default,
            global::System.DateTime? endDate = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareAgentsExportMetricResultsArguments(
                httpClient: HttpClient,
                cartesiaVersion: ref cartesiaVersion,
                agentId: ref agentId,
                deploymentId: ref deploymentId,
                metricId: ref metricId,
                callId: ref callId,
                startDate: ref startDate,
                endDate: ref endDate);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_AgentsExportMetricResultsSecurityRequirements,
                operationName: "AgentsExportMetricResultsAsync");

            var cartesiaVersionValue = cartesiaVersion switch
            {
                global::G.AgentsExportMetricResultsCartesiaVersion.x20240610 => "2024-06-10",
                global::G.AgentsExportMetricResultsCartesiaVersion.x20241113 => "2024-11-13",
                global::G.AgentsExportMetricResultsCartesiaVersion.x20250416 => "2025-04-16",
                global::G.AgentsExportMetricResultsCartesiaVersion.x20251104 => "2025-11-04",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: "/agents/metrics/results/export",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("agent_id", agentId)
                .AddOptionalParameter("deployment_id", deploymentId)
                .AddOptionalParameter("metric_id", metricId)
                .AddOptionalParameter("call_id", callId)
                .AddOptionalParameter("start_date", startDate?.ToString("yyyy-MM-ddTHH:mm:ssZ"))
                .AddOptionalParameter("end_date", endDate?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                ;
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
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

            __httpRequest.Headers.TryAddWithoutValidation("Cartesia-Version", cartesiaVersion.ToValueString());


            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareAgentsExportMetricResultsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                cartesiaVersion: cartesiaVersion,
                agentId: agentId,
                deploymentId: deploymentId,
                metricId: metricId,
                callId: callId,
                startDate: startDate,
                endDate: endDate);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAgentsExportMetricResultsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // 
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // 
            if ((int)__response.StatusCode == 404)
            {
                string? __content_404 = null;
                global::System.Exception? __exception_404 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                    else
                    {
                        __content_404 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_404 = __ex;
                }

                throw new global::G.ApiException(
                    message: __content_404 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_404,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_404,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsByteArrayAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessAgentsExportMetricResultsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return __content;
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
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    var __content = await __response.Content.ReadAsByteArrayAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return __content;
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