//HintName: G.Api.CreateVideoFromImage.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareCreateVideoFromImageArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.CreateVideoFromImageXRunwayVersion xRunwayVersion,
            global::G.CreateVideoFromImageRequest request);
        partial void PrepareCreateVideoFromImageRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.CreateVideoFromImageXRunwayVersion xRunwayVersion,
            global::G.CreateVideoFromImageRequest request);
        partial void ProcessCreateVideoFromImageResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateVideoFromImageResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Generate a video from an image.<br/>
        /// Start a new task to generate a video from an image prompt.
        /// </summary>
        /// <param name="xRunwayVersion"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateVideoFromImageResponse> CreateVideoFromImageAsync(
            global::G.CreateVideoFromImageXRunwayVersion xRunwayVersion,
            global::G.CreateVideoFromImageRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateVideoFromImageArguments(
                httpClient: _httpClient,
                xRunwayVersion: ref xRunwayVersion,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v1/image_to_video",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }

            httpRequest.Headers.TryAddWithoutValidation("X-Runway-Version", xRunwayVersion.ToValueString());

            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateVideoFromImageRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                xRunwayVersion: xRunwayVersion,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateVideoFromImageResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateVideoFromImageResponseContent(
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
                global::G.CreateVideoFromImageResponse.FromJson(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Generate a video from an image.<br/>
        /// Start a new task to generate a video from an image prompt.
        /// </summary>
        /// <param name="xRunwayVersion"></param>
        /// <param name="promptImage">
        /// HTTPS URL of an image (JPEG, PNG, WebP, max 16MB).
        /// </param>
        /// <param name="model">
        /// The model variant to use.
        /// </param>
        /// <param name="seed">
        /// Seed value for generating consistent results.
        /// </param>
        /// <param name="promptText">
        /// A detailed description of the output.
        /// </param>
        /// <param name="watermark">
        /// Add a Runway watermark to the output.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="duration">
        /// Duration of the video in seconds.<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="ratio">
        /// Aspect ratio of the video.<br/>
        /// Default Value: 16:9
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateVideoFromImageResponse> CreateVideoFromImageAsync(
            global::G.CreateVideoFromImageXRunwayVersion xRunwayVersion,
            string promptImage,
            global::G.CreateVideoFromImageRequestModel model = default,
            int? seed = default,
            string? promptText = default,
            bool? watermark = false,
            int? duration = 10,
            global::G.CreateVideoFromImageRequestRatio? ratio = global::G.CreateVideoFromImageRequestRatio.x16_9,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.CreateVideoFromImageRequest
            {
                PromptImage = promptImage,
                Model = model,
                Seed = seed,
                PromptText = promptText,
                Watermark = watermark,
                Duration = duration,
                Ratio = ratio,
            };

            return await CreateVideoFromImageAsync(
                xRunwayVersion: xRunwayVersion,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}