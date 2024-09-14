//HintName: G.TextureClient.GetTextureGenerationById.g.cs

#nullable enable

namespace G
{
    public partial class TextureClient
    {
        partial void PrepareGetTextureGenerationByIdArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int offset,
            ref int limit,
            ref string id,
            global::G.GetTextureGenerationByIdRequest request);
        partial void PrepareGetTextureGenerationByIdRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int offset,
            int limit,
            string id,
            global::G.GetTextureGenerationByIdRequest request);
        partial void ProcessGetTextureGenerationByIdResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetTextureGenerationByIdResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Texture Generation by ID<br/>
        /// This endpoint gets the specific texture generation.
        /// </summary>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetTextureGenerationByIdResponse> GetTextureGenerationByIdAsync(
            string id,
            global::G.GetTextureGenerationByIdRequest request,
            int offset = 0,
            int limit = 10,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareGetTextureGenerationByIdArguments(
                httpClient: _httpClient,
                offset: ref offset,
                limit: ref limit,
                id: ref id,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/generations-texture/{id}?offset={offset}&limit={limit}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetTextureGenerationByIdRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                offset: offset,
                limit: limit,
                id: id,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetTextureGenerationByIdResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetTextureGenerationByIdResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.GetTextureGenerationByIdResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Get Texture Generation by ID<br/>
        /// This endpoint gets the specific texture generation.
        /// </summary>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="id"></param>
        /// <param name="requestId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.GetTextureGenerationByIdResponse> GetTextureGenerationByIdAsync(
            string id,
            int offset = 0,
            int limit = 10,
            string? requestId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.GetTextureGenerationByIdRequest
            {
                Id = requestId,
            };

            return await GetTextureGenerationByIdAsync(
                offset: offset,
                limit: limit,
                id: id,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}