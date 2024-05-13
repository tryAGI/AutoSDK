//HintName: G.Api.EndPoints.CreateVectorStoreFileBatch.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        /// <summary>
        /// Create a vector store file batch.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<VectorStoreFileBatchObject> CreateVectorStoreFileBatchAsync(
            CreateVectorStoreFileBatchRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: "/vector_stores/{vector_store_id}/file_batches");
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<VectorStoreFileBatchObject>(content) ??
                throw new global::System.InvalidOperationException("Response deserialization failed for \"{content}\" ");
        }

        /// <summary>
        /// Create a vector store file batch.
        /// </summary>
        /// <param name="fileIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<VectorStoreFileBatchObject> CreateVectorStoreFileBatchAsync(
            global::System.Collections.Generic.IList<string> fileIds,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new CreateVectorStoreFileBatchRequest
    	    {
                FileIds = fileIds,
            };

            return await CreateVectorStoreFileBatchAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}