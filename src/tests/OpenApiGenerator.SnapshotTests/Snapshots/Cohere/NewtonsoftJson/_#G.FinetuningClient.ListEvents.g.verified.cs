//HintName: G.FinetuningClient.ListEvents.g.cs

#nullable enable

namespace G
{
    public partial class FinetuningClient
    {
        partial void PrepareListEventsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string finetunedModelId,
            ref int pageSize,
            ref string? pageToken,
            ref string? orderBy,
            ref string? xClientName);
        partial void PrepareListEventsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string finetunedModelId,
            int pageSize,
            string? pageToken,
            string? orderBy,
            string? xClientName);
        partial void ProcessListEventsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListEventsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Retrieves the chronology of statuses the fine-tuned model has been through.
        /// </summary>
        /// <param name="finetunedModelId"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="orderBy"></param>
        /// <param name="xClientName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListEventsResponse> ListEventsAsync(
            string finetunedModelId,
            int pageSize,
            string? pageToken,
            string? orderBy,
            string? xClientName,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareListEventsArguments(
                httpClient: _httpClient,
                finetunedModelId: ref finetunedModelId,
                pageSize: ref pageSize,
                pageToken: ref pageToken,
                orderBy: ref orderBy,
                xClientName: ref xClientName);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/v1/finetuning/finetuned-models/{finetunedModelId}/events?page_size={pageSize}&page_token={pageToken}&order_by={orderBy}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareListEventsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                finetunedModelId: finetunedModelId,
                pageSize: pageSize,
                pageToken: pageToken,
                orderBy: orderBy,
                xClientName: xClientName);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessListEventsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessListEventsResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ListEventsResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}