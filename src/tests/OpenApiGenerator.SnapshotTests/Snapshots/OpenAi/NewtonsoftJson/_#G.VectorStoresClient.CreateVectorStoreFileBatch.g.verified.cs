//HintName: G.VectorStoresClient.CreateVectorStoreFileBatch.g.cs

#nullable enable

namespace G
{
    public partial class VectorStoresClient
    {
        /// <summary>
        /// Create a vector store file batch.
        /// </summary>
        /// <param name="vectorStoreId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<VectorStoreFileBatchObject> CreateVectorStoreFileBatchAsync(
            string vectorStoreId,
            CreateVectorStoreFileBatchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/vector_stores/{vectorStoreId}/file_batches", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::Newtonsoft.Json.JsonConvert.SerializeObject(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<VectorStoreFileBatchObject?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create a vector store file batch.
        /// </summary>
        /// <param name="vectorStoreId"></param>
        /// <param name="fileIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<VectorStoreFileBatchObject> CreateVectorStoreFileBatchAsync(
            string vectorStoreId,
            global::System.Collections.Generic.IList<string> fileIds,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new CreateVectorStoreFileBatchRequest
            {
                FileIds = fileIds,
            };

            return await CreateVectorStoreFileBatchAsync(
                vectorStoreId: vectorStoreId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}