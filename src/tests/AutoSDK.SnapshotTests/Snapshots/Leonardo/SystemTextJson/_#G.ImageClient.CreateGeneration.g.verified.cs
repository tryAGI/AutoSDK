//HintName: G.ImageClient.CreateGeneration.g.cs

#nullable enable

namespace G
{
    public partial class ImageClient
    {
        partial void PrepareCreateGenerationArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.CreateGenerationRequest request);
        partial void PrepareCreateGenerationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.CreateGenerationRequest request);
        partial void ProcessCreateGenerationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateGenerationResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a Generation of Images<br/>
        /// This endpoint will generate images
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateGenerationResponse> CreateGenerationAsync(
            global::G.CreateGenerationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateGenerationArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/generations",
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
            PrepareCreateGenerationRequest(
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
            ProcessCreateGenerationResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCreateGenerationResponseContent(
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
                    global::G.CreateGenerationResponse.FromJson(__content, JsonSerializerOptions) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                __response.EnsureSuccessStatusCode();
                using var __responseStream = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                var __responseValue = await global::G.CreateGenerationResponse.FromJsonStreamAsync(__responseStream, JsonSerializerOptions).ConfigureAwait(false);

                return
                    __responseValue ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Create a Generation of Images<br/>
        /// This endpoint will generate images
        /// </summary>
        /// <param name="alchemy">
        /// Enable to use Alchemy. Note: The appropriate Alchemy version is selected for the specified model. For example, XL models will use Alchemy V2.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="contrastRatio">
        /// Contrast Ratio to use with Alchemy. Must be a float between 0 and 1 inclusive.
        /// </param>
        /// <param name="controlnets"></param>
        /// <param name="elements"></param>
        /// <param name="expandedDomain">
        /// Enable to use the Expanded Domain feature of Alchemy.
        /// </param>
        /// <param name="fantasyAvatar">
        /// Enable to use the Fantasy Avatar feature.
        /// </param>
        /// <param name="guidanceScale">
        /// How strongly the generation should reflect the prompt. 7 is recommended. Must be between 1 and 20.
        /// </param>
        /// <param name="height">
        /// The input height of the images. Must be between 32 and 1024 and be a multiple of 8. Note: Input resolution is not always the same as output resolution due to upscaling from other features.<br/>
        /// Default Value: 768
        /// </param>
        /// <param name="highContrast">
        /// Enable to use the High Contrast feature of Prompt Magic. Note: Controls RAW mode. Set to false to enable RAW mode.
        /// </param>
        /// <param name="highResolution">
        /// Enable to use the High Resolution feature of Prompt Magic.
        /// </param>
        /// <param name="imagePrompts"></param>
        /// <param name="imagePromptWeight"></param>
        /// <param name="initGenerationImageId">
        /// The ID of an existing image to use in image2image.
        /// </param>
        /// <param name="initImageId">
        /// The ID of an Init Image to use in image2image.
        /// </param>
        /// <param name="initStrength">
        /// How strongly the generated images should reflect the original image in image2image. Must be a float between 0.1 and 0.9.
        /// </param>
        /// <param name="modelId">
        /// The model ID used for image generation. If not provided, uses sd_version to determine the version of Stable Diffusion to use. In-app, model IDs are under the Finetune Models menu. Click on the platform model or your custom model, then click View More. For platform models, you can also use the List Platform Models API.<br/>
        /// Default Value: b24e16ff-06e3-43eb-8d33-4416c2d75876
        /// </param>
        /// <param name="negativePrompt">
        /// The negative prompt used for the image generation
        /// </param>
        /// <param name="numImages">
        /// The number of images to generate. Must be between 1 and 8. If either width or height is over 768, must be between 1 and 4.<br/>
        /// Default Value: 4
        /// </param>
        /// <param name="numInferenceSteps">
        /// The Step Count to use for the generation. Must be between 10 and 60. Default is 15.
        /// </param>
        /// <param name="photoReal">
        /// Enable the photoReal feature. Requires enabling alchemy and unspecifying modelId (for photoRealVersion V1).
        /// </param>
        /// <param name="photoRealVersion">
        /// The version of photoReal to use. Must be v1 or v2.
        /// </param>
        /// <param name="photoRealStrength">
        /// Depth of field of photoReal. Must be 0.55 for low, 0.5 for medium, or 0.45 for high. Defaults to 0.55 if not specified.
        /// </param>
        /// <param name="presetStyle">
        /// The style to generate images with. When photoReal is enabled, refer to the Guide section for a full list. When alchemy is disabled, use LEONARDO or NONE. When alchemy is enabled, use ANIME, CREATIVE, DYNAMIC, ENVIRONMENT, GENERAL, ILLUSTRATION, PHOTOGRAPHY, RAYTRACED, RENDER_3D, SKETCH_BW, SKETCH_COLOR, or NONE.<br/>
        /// Default Value: DYNAMIC
        /// </param>
        /// <param name="prompt">
        /// The prompt used to generate images<br/>
        /// Default Value: A majestic cat in the snow
        /// </param>
        /// <param name="promptMagic">
        /// Enable to use Prompt Magic.
        /// </param>
        /// <param name="promptMagicStrength">
        /// Strength of prompt magic. Must be a float between 0.1 and 1.0
        /// </param>
        /// <param name="promptMagicVersion">
        /// Prompt magic version v2 or v3, for use when promptMagic: true
        /// </param>
        /// <param name="public">
        /// Whether the generated images should show in the community feed.
        /// </param>
        /// <param name="scheduler">
        /// The scheduler to generate images with. Defaults to EULER_DISCRETE if not specified.
        /// </param>
        /// <param name="sdVersion">
        /// The base version of stable diffusion to use if not using a custom model. v1_5 is 1.5, v2 is 2.1, if not specified it will default to v1_5. Also includes SDXL and SDXL Lightning models
        /// </param>
        /// <param name="seed"></param>
        /// <param name="tiling">
        /// Whether the generated images should tile on all axis.
        /// </param>
        /// <param name="transparency">
        /// Which type of transparency this image should use
        /// </param>
        /// <param name="unzoom">
        /// Whether the generated images should be unzoomed (requires unzoomAmount and init_image_id to be set).
        /// </param>
        /// <param name="unzoomAmount">
        /// How much the image should be unzoomed (requires an init_image_id and unzoom to be set to true).
        /// </param>
        /// <param name="upscaleRatio">
        /// How much the image should be upscaled. (Enterprise Only)
        /// </param>
        /// <param name="width">
        /// The input width of the images. Must be between 32 and 1024 and be a multiple of 8. Note: Input resolution is not always the same as output resolution due to upscaling from other features.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="canvasRequest">
        /// Whether the generation is for the Canvas Editor feature.
        /// </param>
        /// <param name="canvasRequestType">
        /// The type of request for the Canvas Editor.
        /// </param>
        /// <param name="canvasInitId">
        /// The ID of an initial image to use in Canvas Editor request.
        /// </param>
        /// <param name="canvasMaskId">
        /// The ID of a mask image to use in Canvas Editor request.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.CreateGenerationResponse> CreateGenerationAsync(
            string prompt,
            bool? alchemy = default,
            double? contrastRatio = default,
            global::System.Collections.Generic.IList<global::G.ControlnetInput>? controlnets = default,
            global::System.Collections.Generic.IList<global::G.ElementInput>? elements = default,
            bool? expandedDomain = default,
            bool? fantasyAvatar = default,
            int? guidanceScale = default,
            int? height = default,
            bool? highContrast = default,
            bool? highResolution = default,
            global::System.Collections.Generic.IList<string>? imagePrompts = default,
            double? imagePromptWeight = default,
            string? initGenerationImageId = default,
            string? initImageId = default,
            double? initStrength = default,
            string? modelId = default,
            string? negativePrompt = default,
            int? numImages = default,
            int? numInferenceSteps = default,
            bool? photoReal = default,
            string? photoRealVersion = default,
            double? photoRealStrength = default,
            global::G.SdGenerationStyle? presetStyle = default,
            bool? promptMagic = default,
            double? promptMagicStrength = default,
            string? promptMagicVersion = default,
            bool? @public = default,
            global::G.SdGenerationSchedulers? scheduler = default,
            global::G.SdVersions? sdVersion = default,
            int? seed = default,
            bool? tiling = default,
            global::G.CreateGenerationRequestTransparency? transparency = default,
            bool? unzoom = default,
            double? unzoomAmount = default,
            double? upscaleRatio = default,
            int? width = default,
            bool? canvasRequest = default,
            global::G.CanvasRequestType? canvasRequestType = default,
            string? canvasInitId = default,
            string? canvasMaskId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.CreateGenerationRequest
            {
                Alchemy = alchemy,
                ContrastRatio = contrastRatio,
                Controlnets = controlnets,
                Elements = elements,
                ExpandedDomain = expandedDomain,
                FantasyAvatar = fantasyAvatar,
                GuidanceScale = guidanceScale,
                Height = height,
                HighContrast = highContrast,
                HighResolution = highResolution,
                ImagePrompts = imagePrompts,
                ImagePromptWeight = imagePromptWeight,
                InitGenerationImageId = initGenerationImageId,
                InitImageId = initImageId,
                InitStrength = initStrength,
                ModelId = modelId,
                NegativePrompt = negativePrompt,
                NumImages = numImages,
                NumInferenceSteps = numInferenceSteps,
                PhotoReal = photoReal,
                PhotoRealVersion = photoRealVersion,
                PhotoRealStrength = photoRealStrength,
                PresetStyle = presetStyle,
                Prompt = prompt,
                PromptMagic = promptMagic,
                PromptMagicStrength = promptMagicStrength,
                PromptMagicVersion = promptMagicVersion,
                Public = @public,
                Scheduler = scheduler,
                SdVersion = sdVersion,
                Seed = seed,
                Tiling = tiling,
                Transparency = transparency,
                Unzoom = unzoom,
                UnzoomAmount = unzoomAmount,
                UpscaleRatio = upscaleRatio,
                Width = width,
                CanvasRequest = canvasRequest,
                CanvasRequestType = canvasRequestType,
                CanvasInitId = canvasInitId,
                CanvasMaskId = canvasMaskId,
            };

            return await CreateGenerationAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}