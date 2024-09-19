//HintName: G.FinetuningClient.ListTrainingStepMetrics.g.cs

#nullable enable

namespace G
{
    public partial class FinetuningClient
    {
        partial void PrepareListTrainingStepMetricsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string finetunedModelId,
            ref string? xClientName,
            ref int? pageSize,
            ref string? pageToken);
        partial void PrepareListTrainingStepMetricsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string finetunedModelId,
            string? xClientName,
            int? pageSize,
            string? pageToken);
        partial void ProcessListTrainingStepMetricsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListTrainingStepMetricsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Retrieves metrics measured during the training of a fine-tuned model.
        /// </summary>
        /// <param name="finetunedModelId"></param>
        /// <param name="xClientName"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListTrainingStepMetricsResponse> ListTrainingStepMetricsAsync(
            string finetunedModelId,
            string? xClientName = default,
            int? pageSize = default,
            string? pageToken = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareListTrainingStepMetricsArguments(
                httpClient: _httpClient,
                finetunedModelId: ref finetunedModelId,
                xClientName: ref xClientName,
                pageSize: ref pageSize,
                pageToken: ref pageToken);

            var __pathBuilder = new PathBuilder(
                path: $"/v1/finetuning/finetuned-models/{finetunedModelId}/training-step-metrics",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("page_size", pageSize?.ToString()) 
                .AddOptionalParameter("page_token", pageToken) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareListTrainingStepMetricsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                finetunedModelId: finetunedModelId,
                xClientName: xClientName,
                pageSize: pageSize,
                pageToken: pageToken);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessListTrainingStepMetricsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessListTrainingStepMetricsResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ListTrainingStepMetricsResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}