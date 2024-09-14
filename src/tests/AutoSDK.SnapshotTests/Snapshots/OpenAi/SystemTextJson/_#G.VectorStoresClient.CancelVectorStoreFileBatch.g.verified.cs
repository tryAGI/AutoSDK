//HintName: G.VectorStoresClient.CancelVectorStoreFileBatch.g.cs

#nullable enable

namespace G
{
    public partial class VectorStoresClient
    {
        partial void PrepareCancelVectorStoreFileBatchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string vectorStoreId,
            ref string batchId);
        partial void PrepareCancelVectorStoreFileBatchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string vectorStoreId,
            string batchId);
        partial void ProcessCancelVectorStoreFileBatchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCancelVectorStoreFileBatchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Cancel a vector store file batch. This attempts to cancel the processing of files in this batch as soon as possible.
        /// </summary>
        /// <param name="vectorStoreId"></param>
        /// <param name="batchId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.VectorStoreFileBatchObject> CancelVectorStoreFileBatchAsync(
            string vectorStoreId,
            string batchId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareCancelVectorStoreFileBatchArguments(
                httpClient: _httpClient,
                vectorStoreId: ref vectorStoreId,
                batchId: ref batchId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/vector_stores/{vectorStoreId}/file_batches/{batchId}/cancel", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCancelVectorStoreFileBatchRequest(
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
            ProcessCancelVectorStoreFileBatchResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCancelVectorStoreFileBatchResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::G.VectorStoreFileBatchObject), JsonSerializerContext) as global::G.VectorStoreFileBatchObject ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}