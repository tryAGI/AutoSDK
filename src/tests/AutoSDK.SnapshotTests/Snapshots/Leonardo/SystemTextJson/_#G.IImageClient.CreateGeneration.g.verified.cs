//HintName: G.IImageClient.CreateGeneration.g.cs
#nullable enable

namespace G
{
    public partial interface IImageClient
    {
        /// <summary>
        /// Create a Generation of Images<br/>
        /// This endpoint will generate images
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateGenerationResponse> CreateGenerationAsync(
            global::G.CreateGenerationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

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
        global::System.Threading.Tasks.Task<global::G.CreateGenerationResponse> CreateGenerationAsync(
            string prompt,
            bool? alchemy = true,
            double? contrastRatio = default,
            global::System.Collections.Generic.IList<global::G.ControlnetInput>? controlnets = default,
            global::System.Collections.Generic.IList<global::G.ElementInput>? elements = default,
            bool? expandedDomain = default,
            bool? fantasyAvatar = default,
            int? guidanceScale = default,
            int? height = 768,
            bool? highContrast = default,
            bool? highResolution = default,
            global::System.Collections.Generic.IList<string>? imagePrompts = default,
            double? imagePromptWeight = default,
            string? initGenerationImageId = default,
            string? initImageId = default,
            double? initStrength = default,
            string? modelId = "b24e16ff-06e3-43eb-8d33-4416c2d75876",
            string? negativePrompt = default,
            int? numImages = 4,
            int? numInferenceSteps = default,
            bool? photoReal = default,
            string? photoRealVersion = default,
            double? photoRealStrength = default,
            global::G.SdGenerationStyle? presetStyle = global::G.SdGenerationStyle.DYNAMIC,
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
            int? width = 1024,
            bool? canvasRequest = default,
            global::G.CanvasRequestType? canvasRequestType = default,
            string? canvasInitId = default,
            string? canvasMaskId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}