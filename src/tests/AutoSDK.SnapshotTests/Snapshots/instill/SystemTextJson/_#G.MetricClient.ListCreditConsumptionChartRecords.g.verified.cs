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
            ref global::System.DateTime? start,
            ref global::System.DateTime? stop);
        partial void PrepareListCreditConsumptionChartRecordsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string namespaceId,
            string? aggregationWindow,
            global::System.DateTime? start,
            global::System.DateTime? stop);
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
            global::System.DateTime? start = default,
            global::System.DateTime? stop = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareListCreditConsumptionChartRecordsArguments(
                httpClient: HttpClient,
                namespaceId: ref namespaceId,
                aggregationWindow: ref aggregationWindow,
                start: ref start,
                stop: ref stop);

            var __pathBuilder = new PathBuilder(
                path: "/v1beta/metrics/credit/charts",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddRequiredParameter("namespaceId", namespaceId) 
                .AddOptionalParameter("aggregationWindow", aggregationWindow) 
                .AddOptionalParameter("start", start?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddOptionalParameter("stop", stop?.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareListCreditConsumptionChartRecordsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                namespaceId: namespaceId,
                aggregationWindow: aggregationWindow,
                start: start,
                stop: stop);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessListCreditConsumptionChartRecordsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessListCreditConsumptionChartRecordsResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::G.ListCreditConsumptionChartRecordsResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}