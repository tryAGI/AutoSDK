//HintName: G.MetricsClient.OverallUsageSummary.g.cs

#nullable enable

namespace G
{
    public partial class MetricsClient
    {
        partial void PrepareOverallUsageSummaryArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.DateTime start,
            ref global::System.DateTime end,
            ref string? pipelineId);
        partial void PrepareOverallUsageSummaryRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.DateTime start,
            global::System.DateTime end,
            string? pipelineId);
        partial void ProcessOverallUsageSummaryResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessOverallUsageSummaryResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Overall Usage Summary
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="pipelineId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.OverallUsageSummary> OverallUsageSummaryAsync(
            global::System.DateTime start,
            global::System.DateTime end,
            string? pipelineId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareOverallUsageSummaryArguments(
                httpClient: _httpClient,
                start: ref start,
                end: ref end,
                pipelineId: ref pipelineId);

            var __pathBuilder = new PathBuilder(
                path: "/v4/metrics/overall-usage-summary",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("start", start.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddRequiredParameter("end", end.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("pipeline_id", pipelineId) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareOverallUsageSummaryRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                start: start,
                end: end,
                pipelineId: pipelineId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessOverallUsageSummaryResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessOverallUsageSummaryResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::G.OverallUsageSummary.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}