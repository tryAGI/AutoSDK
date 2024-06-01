//HintName: G.VectorStoresClient.ModifyVectorStore.g.cs

#nullable enable

namespace G
{
    public partial class VectorStoresClient
    {
        /// <summary>
        /// Modifies a vector store.
        /// </summary>
        /// <param name="vectorStoreId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<VectorStoreObject> ModifyVectorStoreAsync(
            string vectorStoreId,
            UpdateVectorStoreRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + $"/vector_stores/{vectorStoreId}", global::System.UriKind.RelativeOrAbsolute));
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: global::System.Text.Json.JsonSerializer.Serialize(request),
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            return
                global::System.Text.Json.JsonSerializer.Deserialize<VectorStoreObject?>(__content) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Modifies a vector store.
        /// </summary>
        /// <param name="vectorStoreId"></param>
        /// <param name="name"></param>
        /// <param name="expiresAfter"></param>
        /// <param name="metadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<VectorStoreObject> ModifyVectorStoreAsync(
            string vectorStoreId,
            string? name = default,
            VectorStoreExpirationAfter? expiresAfter = default,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new UpdateVectorStoreRequest
            {
                Name = name,
                ExpiresAfter = expiresAfter,
                Metadata = metadata,
            };

            return await ModifyVectorStoreAsync(
                vectorStoreId: vectorStoreId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}