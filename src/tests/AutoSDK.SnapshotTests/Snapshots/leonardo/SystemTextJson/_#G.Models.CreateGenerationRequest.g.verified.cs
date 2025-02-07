//HintName: G.Models.CreateGenerationRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateGenerationRequest
    {
        /// <summary>
        /// Enable to use Alchemy. Note: The appropriate Alchemy version is selected for the specified model. For example, XL models will use Alchemy V2.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alchemy")]
        public bool? Alchemy { get; set; }

        /// <summary>
        /// Contrast Ratio to use with Alchemy. Must be a float between 0 and 1 inclusive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("contrastRatio")]
        public double? ContrastRatio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controlnets")]
        public global::System.Collections.Generic.IList<global::G.ControlnetInput>? Controlnets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("elements")]
        public global::System.Collections.Generic.IList<global::G.ElementInput>? Elements { get; set; }

        /// <summary>
        /// Enable to use the Expanded Domain feature of Alchemy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expandedDomain")]
        public bool? ExpandedDomain { get; set; }

        /// <summary>
        /// Enable to use the Fantasy Avatar feature.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fantasyAvatar")]
        public bool? FantasyAvatar { get; set; }

        /// <summary>
        /// How strongly the generation should reflect the prompt. 7 is recommended. Must be between 1 and 20.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidance_scale")]
        public int? GuidanceScale { get; set; }

        /// <summary>
        /// The input height of the images. Must be between 32 and 1024 and be a multiple of 8. Note: Input resolution is not always the same as output resolution due to upscaling from other features.<br/>
        /// Default Value: 768
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Enable to use the High Contrast feature of Prompt Magic. Note: Controls RAW mode. Set to false to enable RAW mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highContrast")]
        public bool? HighContrast { get; set; }

        /// <summary>
        /// Enable to use the High Resolution feature of Prompt Magic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highResolution")]
        public bool? HighResolution { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagePrompts")]
        public global::System.Collections.Generic.IList<string>? ImagePrompts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imagePromptWeight")]
        public double? ImagePromptWeight { get; set; }

        /// <summary>
        /// The ID of an existing image to use in image2image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("init_generation_image_id")]
        public string? InitGenerationImageId { get; set; }

        /// <summary>
        /// The ID of an Init Image to use in image2image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("init_image_id")]
        public string? InitImageId { get; set; }

        /// <summary>
        /// How strongly the generated images should reflect the original image in image2image. Must be a float between 0.1 and 0.9.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("init_strength")]
        public double? InitStrength { get; set; }

        /// <summary>
        /// The model ID used for image generation. If not provided, uses sd_version to determine the version of Stable Diffusion to use. In-app, model IDs are under the Finetune Models menu. Click on the platform model or your custom model, then click View More. For platform models, you can also use the List Platform Models API.<br/>
        /// Default Value: b24e16ff-06e3-43eb-8d33-4416c2d75876
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modelId")]
        public string? ModelId { get; set; }

        /// <summary>
        /// The negative prompt used for the image generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// The number of images to generate. Must be between 1 and 8. If either width or height is over 768, must be between 1 and 4.<br/>
        /// Default Value: 4
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_images")]
        public int? NumImages { get; set; }

        /// <summary>
        /// The Step Count to use for the generation. Must be between 10 and 60. Default is 15.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_inference_steps")]
        public int? NumInferenceSteps { get; set; }

        /// <summary>
        /// Enable the photoReal feature. Requires enabling alchemy and unspecifying modelId (for photoRealVersion V1).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("photoReal")]
        public bool? PhotoReal { get; set; }

        /// <summary>
        /// The version of photoReal to use. Must be v1 or v2.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("photoRealVersion")]
        public string? PhotoRealVersion { get; set; }

        /// <summary>
        /// Depth of field of photoReal. Must be 0.55 for low, 0.5 for medium, or 0.45 for high. Defaults to 0.55 if not specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("photoRealStrength")]
        public double? PhotoRealStrength { get; set; }

        /// <summary>
        /// The style to generate images with. When photoReal is enabled, refer to the Guide section for a full list. When alchemy is disabled, use LEONARDO or NONE. When alchemy is enabled, use ANIME, CREATIVE, DYNAMIC, ENVIRONMENT, GENERAL, ILLUSTRATION, PHOTOGRAPHY, RAYTRACED, RENDER_3D, SKETCH_BW, SKETCH_COLOR, or NONE.<br/>
        /// Default Value: DYNAMIC
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presetStyle")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SdGenerationStyleJsonConverter))]
        public global::G.SdGenerationStyle? PresetStyle { get; set; }

        /// <summary>
        /// The prompt used to generate images<br/>
        /// Default Value: A majestic cat in the snow
        /// </summary>
        /// <default>"A majestic cat in the snow"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; } = "A majestic cat in the snow";

        /// <summary>
        /// Enable to use Prompt Magic.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptMagic")]
        public bool? PromptMagic { get; set; }

        /// <summary>
        /// Strength of prompt magic. Must be a float between 0.1 and 1.0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptMagicStrength")]
        public double? PromptMagicStrength { get; set; }

        /// <summary>
        /// Prompt magic version v2 or v3, for use when promptMagic: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptMagicVersion")]
        public string? PromptMagicVersion { get; set; }

        /// <summary>
        /// Whether the generated images should show in the community feed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public")]
        public bool? Public { get; set; }

        /// <summary>
        /// The scheduler to generate images with. Defaults to EULER_DISCRETE if not specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduler")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SdGenerationSchedulersJsonConverter))]
        public global::G.SdGenerationSchedulers? Scheduler { get; set; }

        /// <summary>
        /// The base version of stable diffusion to use if not using a custom model. v1_5 is 1.5, v2 is 2.1, if not specified it will default to v1_5. Also includes SDXL and SDXL Lightning models
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sd_version")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.SdVersionsJsonConverter))]
        public global::G.SdVersions? SdVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Whether the generated images should tile on all axis.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tiling")]
        public bool? Tiling { get; set; }

        /// <summary>
        /// Which type of transparency this image should use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transparency")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CreateGenerationRequestTransparencyJsonConverter))]
        public global::G.CreateGenerationRequestTransparency? Transparency { get; set; }

        /// <summary>
        /// Whether the generated images should be unzoomed (requires unzoomAmount and init_image_id to be set).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unzoom")]
        public bool? Unzoom { get; set; }

        /// <summary>
        /// How much the image should be unzoomed (requires an init_image_id and unzoom to be set to true).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unzoomAmount")]
        public double? UnzoomAmount { get; set; }

        /// <summary>
        /// How much the image should be upscaled. (Enterprise Only)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upscaleRatio")]
        public double? UpscaleRatio { get; set; }

        /// <summary>
        /// The input width of the images. Must be between 32 and 1024 and be a multiple of 8. Note: Input resolution is not always the same as output resolution due to upscaling from other features.<br/>
        /// Default Value: 1024
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// This parameter will be deprecated in September 2024. Please use the controlnets array instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controlNet")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? ControlNet { get; set; }

        /// <summary>
        /// This parameter will be deprecated in September 2024. Please use the controlnets array instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controlNetType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ControlnetTypeJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.ControlnetType? ControlNetType { get; set; }

        /// <summary>
        /// This parameter will be deprecated in September 2024. Please use the controlnets array instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weighting")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public double? Weighting { get; set; }

        /// <summary>
        /// Whether the generation is for the Canvas Editor feature.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canvasRequest")]
        public bool? CanvasRequest { get; set; }

        /// <summary>
        /// The type of request for the Canvas Editor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canvasRequestType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.CanvasRequestTypeJsonConverter))]
        public global::G.CanvasRequestType? CanvasRequestType { get; set; }

        /// <summary>
        /// The ID of an initial image to use in Canvas Editor request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canvasInitId")]
        public string? CanvasInitId { get; set; }

        /// <summary>
        /// The ID of a mask image to use in Canvas Editor request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("canvasMaskId")]
        public string? CanvasMaskId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerationRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGenerationRequest(
            string prompt,
            bool? alchemy,
            double? contrastRatio,
            global::System.Collections.Generic.IList<global::G.ControlnetInput>? controlnets,
            global::System.Collections.Generic.IList<global::G.ElementInput>? elements,
            bool? expandedDomain,
            bool? fantasyAvatar,
            int? guidanceScale,
            int? height,
            bool? highContrast,
            bool? highResolution,
            global::System.Collections.Generic.IList<string>? imagePrompts,
            double? imagePromptWeight,
            string? initGenerationImageId,
            string? initImageId,
            double? initStrength,
            string? modelId,
            string? negativePrompt,
            int? numImages,
            int? numInferenceSteps,
            bool? photoReal,
            string? photoRealVersion,
            double? photoRealStrength,
            global::G.SdGenerationStyle? presetStyle,
            bool? promptMagic,
            double? promptMagicStrength,
            string? promptMagicVersion,
            bool? @public,
            global::G.SdGenerationSchedulers? scheduler,
            global::G.SdVersions? sdVersion,
            int? seed,
            bool? tiling,
            global::G.CreateGenerationRequestTransparency? transparency,
            bool? unzoom,
            double? unzoomAmount,
            double? upscaleRatio,
            int? width,
            bool? canvasRequest,
            global::G.CanvasRequestType? canvasRequestType,
            string? canvasInitId,
            string? canvasMaskId)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Alchemy = alchemy;
            this.ContrastRatio = contrastRatio;
            this.Controlnets = controlnets;
            this.Elements = elements;
            this.ExpandedDomain = expandedDomain;
            this.FantasyAvatar = fantasyAvatar;
            this.GuidanceScale = guidanceScale;
            this.Height = height;
            this.HighContrast = highContrast;
            this.HighResolution = highResolution;
            this.ImagePrompts = imagePrompts;
            this.ImagePromptWeight = imagePromptWeight;
            this.InitGenerationImageId = initGenerationImageId;
            this.InitImageId = initImageId;
            this.InitStrength = initStrength;
            this.ModelId = modelId;
            this.NegativePrompt = negativePrompt;
            this.NumImages = numImages;
            this.NumInferenceSteps = numInferenceSteps;
            this.PhotoReal = photoReal;
            this.PhotoRealVersion = photoRealVersion;
            this.PhotoRealStrength = photoRealStrength;
            this.PresetStyle = presetStyle;
            this.PromptMagic = promptMagic;
            this.PromptMagicStrength = promptMagicStrength;
            this.PromptMagicVersion = promptMagicVersion;
            this.Public = @public;
            this.Scheduler = scheduler;
            this.SdVersion = sdVersion;
            this.Seed = seed;
            this.Tiling = tiling;
            this.Transparency = transparency;
            this.Unzoom = unzoom;
            this.UnzoomAmount = unzoomAmount;
            this.UpscaleRatio = upscaleRatio;
            this.Width = width;
            this.CanvasRequest = canvasRequest;
            this.CanvasRequestType = canvasRequestType;
            this.CanvasInitId = canvasInitId;
            this.CanvasMaskId = canvasMaskId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGenerationRequest" /> class.
        /// </summary>
        public CreateGenerationRequest()
        {
        }
    }
}