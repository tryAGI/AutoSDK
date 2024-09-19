//HintName: G.RealtimeCanvasClient.PerformAlchemyUpscaleLCM.g.cs

#nullable enable

namespace G
{
    public partial class RealtimeCanvasClient
    {
        partial void PreparePerformAlchemyUpscaleLCMArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.PerformAlchemyUpscaleLCMRequest request);
        partial void PreparePerformAlchemyUpscaleLCMRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.PerformAlchemyUpscaleLCMRequest request);
        partial void ProcessPerformAlchemyUpscaleLCMResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPerformAlchemyUpscaleLCMResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Perform Alchemy Upscale on a LCM image<br/>
        /// This endpoint will perform Alchemy Upscale on a LCM image
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PerformAlchemyUpscaleLCMResponse> PerformAlchemyUpscaleLCMAsync(
            global::G.PerformAlchemyUpscaleLCMRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PreparePerformAlchemyUpscaleLCMArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/lcm-upscale",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::Newtonsoft.Json.JsonConvert.SerializeObject(request, JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PreparePerformAlchemyUpscaleLCMRequest(
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
            ProcessPerformAlchemyUpscaleLCMResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessPerformAlchemyUpscaleLCMResponseContent(
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
                global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.PerformAlchemyUpscaleLCMResponse?>(__content, JsonSerializerOptions) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Perform Alchemy Upscale on a LCM image<br/>
        /// This endpoint will perform Alchemy Upscale on a LCM image
        /// </summary>
        /// <param name="imageDataUrl">
        /// Image data used to generate image. In base64 format. Prefix: `data:image/jpeg;base64,`
        /// </param>
        /// <param name="prompt">
        /// The prompt used to generate images
        /// </param>
        /// <param name="guidance">
        /// How strongly the generation should reflect the prompt. Must be a float between 0.5 and 20.
        /// </param>
        /// <param name="strength">
        /// Creativity strength of generation. Higher strength will deviate more from the original image supplied in imageDataUrl. Must be a float between 0.1 and 1.
        /// </param>
        /// <param name="requestTimestamp"></param>
        /// <param name="style">
        /// The style to generate LCM images with.
        /// </param>
        /// <param name="steps">
        /// The number of steps to use for the generation. Must be between 4 and 16.
        /// </param>
        /// <param name="width">
        /// The output width of the image. Must be 512, 640 or 1024.<br/>
        /// Default Value: 512
        /// </param>
        /// <param name="height">
        /// The output width of the image. Must be 512, 640 or 1024.<br/>
        /// Default Value: 512
        /// </param>
        /// <param name="seed"></param>
        /// <param name="refineCreative">
        /// Refine creative
        /// </param>
        /// <param name="refineStrength">
        /// Must be a float between 0.5 and 0.9.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.PerformAlchemyUpscaleLCMResponse> PerformAlchemyUpscaleLCMAsync(
            string imageDataUrl,
            string prompt,
            double? guidance = default,
            double? strength = default,
            string? requestTimestamp = default,
            global::G.LcmGenerationStyle? style = default,
            int? steps = default,
            int? width = 512,
            int? height = 512,
            int? seed = default,
            bool? refineCreative = default,
            double? refineStrength = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::G.PerformAlchemyUpscaleLCMRequest
            {
                ImageDataUrl = imageDataUrl,
                Prompt = prompt,
                Guidance = guidance,
                Strength = strength,
                RequestTimestamp = requestTimestamp,
                Style = style,
                Steps = steps,
                Width = width,
                Height = height,
                Seed = seed,
                RefineCreative = refineCreative,
                RefineStrength = refineStrength,
            };

            return await PerformAlchemyUpscaleLCMAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}