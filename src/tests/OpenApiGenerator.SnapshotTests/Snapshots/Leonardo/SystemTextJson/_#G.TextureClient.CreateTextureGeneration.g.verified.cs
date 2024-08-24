//HintName: G.TextureClient.CreateTextureGeneration.g.cs

#nullable enable

namespace G
{
    public partial class TextureClient
    {
        partial void PrepareCreateTextureGenerationArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.CreateTextureGenerationRequest request);
        partial void PrepareCreateTextureGenerationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.CreateTextureGenerationRequest request);
        partial void ProcessCreateTextureGenerationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateTextureGenerationResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Texture Generation<br/>
        /// This endpoint will generate a texture generation.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateTextureGenerationResponse> CreateTextureGenerationAsync(
            global::G.CreateTextureGenerationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateTextureGenerationArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/generations-texture", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, _jsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateTextureGenerationRequest(
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
            ProcessCreateTextureGenerationResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateTextureGenerationResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.CreateTextureGenerationResponse?>(__content, _jsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create Texture Generation<br/>
        /// This endpoint will generate a texture generation.
        /// </summary>
        /// <param name="frontRotationOffset"></param>
        /// <param name="modelAssetId"></param>
        /// <param name="negativePrompt"></param>
        /// <param name="preview"></param>
        /// <param name="previewDirection"></param>
        /// <param name="prompt"></param>
        /// <param name="sdVersion"></param>
        /// <param name="seed"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateTextureGenerationResponse> CreateTextureGenerationAsync(
            int? frontRotationOffset = default,
            string? modelAssetId = default,
            string? negativePrompt = default,
            bool? preview = default,
            string? previewDirection = default,
            string? prompt = default,
            string? sdVersion = default,
            int? seed = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.CreateTextureGenerationRequest
            {
                FrontRotationOffset = frontRotationOffset,
                ModelAssetId = modelAssetId,
                NegativePrompt = negativePrompt,
                Preview = preview,
                PreviewDirection = previewDirection,
                Prompt = prompt,
                SdVersion = sdVersion,
                Seed = seed,
            };

            return await CreateTextureGenerationAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}