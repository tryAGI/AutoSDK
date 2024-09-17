//HintName: G.MetricClient.ListCreditConsumptionChartRecords.g.cs

#nullable enable

namespace G
{
    public partial class MetricClient
    {
        partial void PrepareListCreditConsumptionChartRecordsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string namespaceId,
            ref string? aggregationWindow,
            ref global::System.DateTime start,
            ref global::System.DateTime stop);
        partial void PrepareListCreditConsumptionChartRecordsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string namespaceId,
            string? aggregationWindow,
            global::System.DateTime start,
            global::System.DateTime stop);
        partial void ProcessListCreditConsumptionChartRecordsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListCreditConsumptionChartRecordsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Instill Credit consumption time charts<br/>
        /// Returns a timeline of Instill Credit consumption for a given owner. The<br/>
        /// response will contain one set of records (datapoints) per consumption<br/>
        /// source (e.g. "pipeline", "model"). Each datapoint represents the amount<br/>
        /// consumed in a time bucket.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="aggregationWindow"></param>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListCreditConsumptionChartRecordsResponse> ListCreditConsumptionChartRecordsAsync(
            string namespaceId,
            string? aggregationWindow = default,
            global::System.DateTime start = default,
            global::System.DateTime stop = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareListCreditConsumptionChartRecordsArguments(
                httpClient: _httpClient,
                namespaceId: ref namespaceId,
                aggregationWindow: ref aggregationWindow,
                start: ref start,
                stop: ref stop);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v1beta/metrics/credit/charts?namespaceId={namespaceId}&aggregationWindow={aggregationWindow}&start={start:yyyy-MM-ddTHH:mm:ssZ}&stop={stop:yyyy-MM-ddTHH:mm:ssZ}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareListCreditConsumptionChartRecordsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                namespaceId: namespaceId,
                aggregationWindow: aggregationWindow,
                start: start,
                stop: stop);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessListCreditConsumptionChartRecordsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessListCreditConsumptionChartRecordsResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ListCreditConsumptionChartRecordsResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}