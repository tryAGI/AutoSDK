//HintName: G.MetricsClient.TopPipelinesUsage.g.cs

#nullable enable

namespace G
{
    public partial class MetricsClient
    {
        partial void PrepareTopPipelinesUsageArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int numPipelines,
            ref string? clusterId,
            ref global::System.DateTime start,
            ref global::System.DateTime end,
            ref global::G.DurationUnit intervalUnit,
            ref int intervalValue);
        partial void PrepareTopPipelinesUsageRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int numPipelines,
            string? clusterId,
            global::System.DateTime start,
            global::System.DateTime end,
            global::G.DurationUnit intervalUnit,
            int intervalValue);
        partial void ProcessTopPipelinesUsageResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessTopPipelinesUsageResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Top Pipelines Usage<br/>
        /// Retrieve usage metrics for top 'num_pipelines' (in terms of number of<br/>
        /// runs) for the provided time period.
        /// </summary>
        /// <param name="numPipelines">
        /// Default Value: 20
        /// </param>
        /// <param name="clusterId"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="intervalUnit">
        /// An enumeration.
        /// </param>
        /// <param name="intervalValue"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TopPipelinesUsageV4MetricsTopPipelinesUsageGetResponse> TopPipelinesUsageAsync(
            global::System.DateTime start,
            global::System.DateTime end,
            global::G.DurationUnit intervalUnit,
            int intervalValue,
            int numPipelines = 20,
            string? clusterId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareTopPipelinesUsageArguments(
                httpClient: _httpClient,
                numPipelines: ref numPipelines,
                clusterId: ref clusterId,
                start: ref start,
                end: ref end,
                intervalUnit: ref intervalUnit,
                intervalValue: ref intervalValue);

            var intervalUnitValue = intervalUnit switch
            {
                global::G.DurationUnit.Seconds => "seconds",
                global::G.DurationUnit.Minutes => "minutes",
                global::G.DurationUnit.Hours => "hours",
                global::G.DurationUnit.Days => "days",
                global::G.DurationUnit.Weeks => "weeks",
                _ => throw new global::System.NotImplementedException("Enum value not implemented."),
            };
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v4/metrics/top-pipelines-usage?num_pipelines={numPipelines}&cluster_id={clusterId}&start={start:yyyy-MM-ddTHH:mm:ssZ}&end={end:yyyy-MM-ddTHH:mm:ssZ}&interval_unit={(global::System.Uri.EscapeDataString(intervalUnitValue.ToString() ?? string.Empty))}&interval_value={intervalValue}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareTopPipelinesUsageRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                numPipelines: numPipelines,
                clusterId: clusterId,
                start: start,
                end: end,
                intervalUnit: intervalUnit,
                intervalValue: intervalValue);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessTopPipelinesUsageResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessTopPipelinesUsageResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.TopPipelinesUsageV4MetricsTopPipelinesUsageGetResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}