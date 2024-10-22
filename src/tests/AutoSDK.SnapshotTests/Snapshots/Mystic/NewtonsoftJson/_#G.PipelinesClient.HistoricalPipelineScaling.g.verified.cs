//HintName: G.PipelinesClient.HistoricalPipelineScaling.g.cs

#nullable enable

namespace G
{
    public partial class PipelinesClient
    {
        partial void PrepareHistoricalPipelineScalingArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string pipelineId,
            ref string? pointer,
            ref string? pipelineIdOrPointer,
            ref global::System.DateTime start,
            ref global::System.DateTime end,
            ref global::G.DurationUnit intervalUnit,
            ref int intervalValue);
        partial void PrepareHistoricalPipelineScalingRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string pipelineId,
            string? pointer,
            string? pipelineIdOrPointer,
            global::System.DateTime start,
            global::System.DateTime end,
            global::G.DurationUnit intervalUnit,
            int intervalValue);
        partial void ProcessHistoricalPipelineScalingResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessHistoricalPipelineScalingResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Historical Pipeline Scaling
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="pointer"></param>
        /// <param name="pipelineIdOrPointer"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="intervalUnit">
        /// An enumeration.
        /// </param>
        /// <param name="intervalValue"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> HistoricalPipelineScalingAsync(
            string pipelineId,
            global::System.DateTime start,
            global::System.DateTime end,
            global::G.DurationUnit intervalUnit,
            int intervalValue,
            string? pointer = default,
            string? pipelineIdOrPointer = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareHistoricalPipelineScalingArguments(
                httpClient: HttpClient,
                pipelineId: ref pipelineId,
                pointer: ref pointer,
                pipelineIdOrPointer: ref pipelineIdOrPointer,
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
            var __pathBuilder = new PathBuilder(
                path: $"/v4/pipelines/{pipelineId}/scaling-history",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("pointer", pointer) 
                .AddOptionalParameter("pipeline_id_or_pointer", pipelineIdOrPointer) 
                .AddRequiredParameter("start", start.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddRequiredParameter("end", end.ToString("yyyy-MM-ddTHH:mm:ssZ")) 
                .AddRequiredParameter("interval_unit", intervalUnitValue.ToString()) 
                .AddRequiredParameter("interval_value", intervalValue.ToString()) 
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
            PrepareHistoricalPipelineScalingRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                pipelineId: pipelineId,
                pointer: pointer,
                pipelineIdOrPointer: pipelineIdOrPointer,
                start: start,
                end: end,
                intervalUnit: intervalUnit,
                intervalValue: intervalValue);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessHistoricalPipelineScalingResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessHistoricalPipelineScalingResponseContent(
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

            return __content;
        }
    }
}