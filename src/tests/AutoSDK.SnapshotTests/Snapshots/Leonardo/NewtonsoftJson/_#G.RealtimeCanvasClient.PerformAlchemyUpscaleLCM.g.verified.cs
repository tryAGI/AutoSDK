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
                client: HttpClient);
            PreparePerformAlchemyUpscaleLCMArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/lcm-upscale",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PreparePerformAlchemyUpscaleLCMRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessPerformAlchemyUpscaleLCMResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync().ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessPerformAlchemyUpscaleLCMResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::G.PerformAlchemyUpscaleLCMResponse.FromJson(__content, JsonSerializerOptions) ??
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
            int? width = default,
            int? height = default,
            int? seed = default,
            bool? refineCreative = default,
            double? refineStrength = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.PerformAlchemyUpscaleLCMRequest
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
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}