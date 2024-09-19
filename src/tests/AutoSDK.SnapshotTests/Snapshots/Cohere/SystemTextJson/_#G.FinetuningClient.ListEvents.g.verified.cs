//HintName: G.FinetuningClient.ListEvents.g.cs

#nullable enable

namespace G
{
    public partial class FinetuningClient
    {
        partial void PrepareListEventsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string finetunedModelId,
            ref string? xClientName,
            ref int? pageSize,
            ref string? pageToken,
            ref string? orderBy);
        partial void PrepareListEventsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string finetunedModelId,
            string? xClientName,
            int? pageSize,
            string? pageToken,
            string? orderBy);
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
        /// <param name="xClientName"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="orderBy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListEventsResponse> ListEventsAsync(
            string finetunedModelId,
            string? xClientName = default,
            int? pageSize = default,
            string? pageToken = default,
            string? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareListEventsArguments(
                httpClient: _httpClient,
                finetunedModelId: ref finetunedModelId,
                xClientName: ref xClientName,
                pageSize: ref pageSize,
                pageToken: ref pageToken,
                orderBy: ref orderBy);

            var __pathBuilder = new PathBuilder(
                path: $"/v1/finetuning/finetuned-models/{finetunedModelId}/events",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("page_size", pageSize?.ToString()) 
                .AddOptionalParameter("page_token", pageToken) 
                .AddOptionalParameter("order_by", orderBy) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareListEventsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                finetunedModelId: finetunedModelId,
                xClientName: xClientName,
                pageSize: pageSize,
                pageToken: pageToken,
                orderBy: orderBy);

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

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.ListEventsResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}