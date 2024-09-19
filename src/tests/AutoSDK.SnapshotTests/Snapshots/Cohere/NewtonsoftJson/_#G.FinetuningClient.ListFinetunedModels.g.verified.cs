//HintName: G.FinetuningClient.ListFinetunedModels.g.cs

#nullable enable

namespace G
{
    public partial class FinetuningClient
    {
        partial void PrepareListFinetunedModelsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xClientName,
            ref int? pageSize,
            ref string? pageToken,
            ref string? orderBy);
        partial void PrepareListFinetunedModelsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xClientName,
            int? pageSize,
            string? pageToken,
            string? orderBy);
        partial void ProcessListFinetunedModelsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListFinetunedModelsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Lists fine-tuned models.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageToken"></param>
        /// <param name="orderBy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ListFinetunedModelsResponse> ListFinetunedModelsAsync(
            string? xClientName = default,
            int? pageSize = default,
            string? pageToken = default,
            string? orderBy = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareListFinetunedModelsArguments(
                httpClient: _httpClient,
                xClientName: ref xClientName,
                pageSize: ref pageSize,
                pageToken: ref pageToken,
                orderBy: ref orderBy);

            var __pathBuilder = new PathBuilder(
                path: "/v1/finetuning/finetuned-models",
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
            PrepareListFinetunedModelsRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
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
            ProcessListFinetunedModelsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessListFinetunedModelsResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.ListFinetunedModelsResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}