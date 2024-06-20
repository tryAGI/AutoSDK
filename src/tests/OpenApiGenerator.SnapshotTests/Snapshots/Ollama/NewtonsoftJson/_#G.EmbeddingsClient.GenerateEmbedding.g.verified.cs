//HintName: G.EmbeddingsClient.GenerateEmbedding.g.cs

#nullable enable

namespace G
{
    public partial class EmbeddingsClient
    {
        /// <summary>
        /// Generate embeddings from a model.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GenerateEmbeddingResponse> GenerateEmbeddingAsync(
            global::G.GenerateEmbeddingRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri + "/embeddings", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.GenerateEmbeddingResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Generate embeddings from a model.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="prompt"></param>
        /// <param name="options"></param>
        /// <param name="keepAlive"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GenerateEmbeddingResponse> GenerateEmbeddingAsync(
            string model,
            string prompt,
            global::G.RequestOptions? options = default,
            int? keepAlive = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.GenerateEmbeddingRequest
            {
                Model = model,
                Prompt = prompt,
                Options = options,
                KeepAlive = keepAlive,
            };

            return await GenerateEmbeddingAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}