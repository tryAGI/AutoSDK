//HintName: G.VectorStoresClient.GetVectorStoreFileBatch.g.cs

#nullable enable

namespace G
{
    public partial class VectorStoresClient
    {
        partial void PrepareGetVectorStoreFileBatchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string vectorStoreId,
            ref string batchId);
        partial void PrepareGetVectorStoreFileBatchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string vectorStoreId,
            string batchId);
        partial void ProcessGetVectorStoreFileBatchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetVectorStoreFileBatchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Retrieves a vector store file batch.
        /// </summary>
        /// <param name="vectorStoreId"></param>
        /// <param name="batchId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.VectorStoreFileBatchObject> GetVectorStoreFileBatchAsync(
            string vectorStoreId,
            string batchId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetVectorStoreFileBatchArguments(
                httpClient: _httpClient,
                vectorStoreId: ref vectorStoreId,
                batchId: ref batchId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/vector_stores/{vectorStoreId}/file_batches/{batchId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetVectorStoreFileBatchRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                vectorStoreId: vectorStoreId,
                batchId: batchId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetVectorStoreFileBatchResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetVectorStoreFileBatchResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.VectorStoreFileBatchObject?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}