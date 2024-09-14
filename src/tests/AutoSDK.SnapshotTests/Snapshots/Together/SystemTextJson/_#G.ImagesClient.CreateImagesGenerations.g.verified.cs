//HintName: G.ImagesClient.CreateImagesGenerations.g.cs

#nullable enable

namespace G
{
    public partial class ImagesClient
    {
        partial void PrepareCreateImagesGenerationsArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.Request request);
        partial void PrepareCreateImagesGenerationsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.Request request);
        partial void ProcessCreateImagesGenerationsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateImagesGenerationsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create image<br/>
        /// Use an image model to generate an image for a given prompt.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ImageResponse> CreateImagesGenerationsAsync(
            global::G.Request request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateImagesGenerationsArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/images/generations", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateImagesGenerationsRequest(
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
            ProcessCreateImagesGenerationsResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateImagesGenerationsResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize<global::G.ImageResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create image<br/>
        /// Use an image model to generate an image for a given prompt.
        /// </summary>
        /// <param name="prompt">
        /// A description of the desired images. Maximum length varies by model.<br/>
        /// Example: cat floating in space, cinematic
        /// </param>
        /// <param name="model">
        /// The model to use for image generation.<br/>
        /// Example: stabilityai/stable-diffusion-xl-base-1.0
        /// </param>
        /// <param name="steps">
        /// Number of generation steps.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="seed">
        /// Seed used for generation. Can be used to reproduce image generations.
        /// </param>
        /// <param name="n">
        /// Number of image results to generate.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="height">
        /// Height of the image to generate in number of pixels.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="width">
        /// Width of the image to generate in number of pixels.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="negativePrompt">
        /// The prompt or prompts not to guide the image generation.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ImageResponse> CreateImagesGenerationsAsync(
            string prompt,
            string model,
            int steps = 20,
            int seed = default,
            int n = 1,
            int height = 1024,
            int width = 1024,
            string? negativePrompt = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.Request
            {
                Prompt = prompt,
                Model = model,
                Steps = steps,
                Seed = seed,
                N = n,
                Height = height,
                Width = width,
                NegativePrompt = negativePrompt,
            };

            return await CreateImagesGenerationsAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}