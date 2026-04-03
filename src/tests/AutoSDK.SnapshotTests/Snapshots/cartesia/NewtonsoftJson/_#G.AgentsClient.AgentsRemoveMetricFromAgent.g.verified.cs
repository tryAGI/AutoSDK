//HintName: G.AgentsClient.AgentsRemoveMetricFromAgent.g.cs

#nullable enable

namespace G
{
    public partial class AgentsClient
    {
        partial void PrepareAgentsRemoveMetricFromAgentArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.AgentsRemoveMetricFromAgentCartesiaVersion cartesiaVersion,
            ref string agentId,
            ref string metricId);
        partial void PrepareAgentsRemoveMetricFromAgentRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.AgentsRemoveMetricFromAgentCartesiaVersion cartesiaVersion,
            string agentId,
            string metricId);
        partial void ProcessAgentsRemoveMetricFromAgentResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Remove Metric from Agent<br/>
        /// Remove a metric from an agent. Once the metric is removed, it will no longer be run on all calls made to the agent automatically from that point onwards. Existing metric results will remain.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="agentId"></param>
        /// <param name="metricId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task AgentsRemoveMetricFromAgentAsync(
            global::G.AgentsRemoveMetricFromAgentCartesiaVersion cartesiaVersion,
            string agentId,
            string metricId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareAgentsRemoveMetricFromAgentArguments(
                httpClient: HttpClient,
                cartesiaVersion: ref cartesiaVersion,
                agentId: ref agentId,
                metricId: ref metricId);

            var cartesiaVersionValue = cartesiaVersion switch
            {
                global::G.AgentsRemoveMetricFromAgentCartesiaVersion.x20240610 => "2024-06-10",
                global::G.AgentsRemoveMetricFromAgentCartesiaVersion.x20241113 => "2024-11-13",
                global::G.AgentsRemoveMetricFromAgentCartesiaVersion.x20250416 => "2025-04-16",
                global::G.AgentsRemoveMetricFromAgentCartesiaVersion.x20251104 => "2025-11-04",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            var __pathBuilder = new global::G.PathBuilder(
                path: $"/agents/{agentId}/metrics/{metricId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
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
            PrepareAgentsRemoveMetricFromAgentRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                cartesiaVersion: cartesiaVersion,
                agentId: agentId,
                metricId: metricId);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessAgentsRemoveMetricFromAgentResponse(
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

                try
                {
                    __response.EnsureSuccessStatusCode();

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