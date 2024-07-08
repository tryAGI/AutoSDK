//HintName: G.EmbeddingsClient.CreateEmbedding.g.cs

#nullable enable

namespace G
{
    public partial class EmbeddingsClient
    {
        partial void PrepareCreateEmbeddingArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.CreateEmbeddingRequest request);
        partial void PrepareCreateEmbeddingRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.CreateEmbeddingRequest request);
        partial void ProcessCreateEmbeddingResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateEmbeddingResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Creates an embedding vector representing the input text.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateEmbeddingResponse> CreateEmbeddingAsync(
            global::G.CreateEmbeddingRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateEmbeddingArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/embeddings", global::System.UriKind.RelativeOrAbsolute));
            var __json = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            httpRequest.Content = new global::System.Net.Http.StringContent(
                content: __json,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateEmbeddingRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateEmbeddingResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateEmbeddingResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateEmbeddingResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Creates an embedding vector representing the input text.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="model"></param>
        /// <param name="encodingFormat"></param>
        /// <param name="dimensions"></param>
        /// <param name="user"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateEmbeddingResponse> CreateEmbeddingAsync(
            global::System.OneOf<string, global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.IList<int>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>> input,
            global::System.AnyOf<string, global::G.CreateEmbeddingRequestModel> model,
            global::G.CreateEmbeddingRequestEncodingFormat? encodingFormat = global::G.CreateEmbeddingRequestEncodingFormat.Float,
            int dimensions = default,
            string? user = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.CreateEmbeddingRequest
            {
                Input = input,
                Model = model,
                EncodingFormat = encodingFormat,
                Dimensions = dimensions,
                User = user,
            };

            return await CreateEmbeddingAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}