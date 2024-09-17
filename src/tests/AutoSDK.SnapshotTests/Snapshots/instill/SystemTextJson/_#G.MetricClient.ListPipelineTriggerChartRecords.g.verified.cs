//HintName: G.MetricClient.ListPipelineTriggerChartRecords.g.cs

#nullable enable

namespace G
{
    public partial class MetricClient
    {
        partial void PrepareListPipelineTriggerChartRecordsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? aggregationWindow,
            ref string? filter);
        partial void PrepareListPipelineTriggerChartRecordsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? aggregationWindow,
            string? filter);
        partial void ProcessListPipelineTriggerChartRecordsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListPipelineTriggerChartRecordsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List pipeline trigger time charts<br/>
        /// Returns a timeline of pipline trigger counts for the pipelines of a given<br/>
        /// owner.<br/>
        /// NOTE: This method will soon return the trigger counts of a given requester.
        /// </summary>
        /// <param name="aggregationWindow"></param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListPipelineTriggerChartRecordsResponse> ListPipelineTriggerChartRecordsAsync(
            int? aggregationWindow = default,
            string? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareListPipelineTriggerChartRecordsArguments(
                httpClient: _httpClient,
                aggregationWindow: ref aggregationWindow,
                filter: ref filter);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v1beta/metrics/vdp/pipeline/charts?aggregationWindow={aggregationWindow}&filter={filter}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareListPipelineTriggerChartRecordsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                aggregationWindow: aggregationWindow,
                filter: filter);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessListPipelineTriggerChartRecordsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessListPipelineTriggerChartRecordsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.ListPipelineTriggerChartRecordsResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}