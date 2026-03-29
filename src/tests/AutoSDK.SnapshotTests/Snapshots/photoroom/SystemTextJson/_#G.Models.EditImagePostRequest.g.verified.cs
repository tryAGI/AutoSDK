//HintName: G.Models.EditImagePostRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditImagePostRequest
    {
        /// <summary>
        /// Type of blur to apply to the background.<br/>
        /// - `gaussian`: Applies a gaussian blur to the background.<br/>
        /// - `bokeh`: Applies a bokeh blur to the background.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background.blur.mode")]
        public string? BackgroundBlurMode { get; set; }

        /// <summary>
        /// Radius of the blur effect. Higher values mean the result will be blurrier.<br/>
        /// Minimum: 0, Maximum: 0.05
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background.blur.radius")]
        public double? BackgroundBlurRadius { get; set; }

        /// <summary>
        /// Color of the background. If omitted, background will be transparent unless `background.imageUrl` or `background.imageFile` is provided. Can be a hex color without the hash sign (example: `FF0000`, `FF0000EE`) or color name (examples: `red`, `blue`)<br/>
        /// When `removeBackground` is set to `false`, the color will be used to fill padding areas created by `outputSize` and any transparent areas in the original image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background.color")]
        public string? BackgroundColor { get; set; }

        /// <summary>
        /// If `ai.auto`, a pre-processing step is applied to expand the prompt into a longer form.<br/>
        /// `auto` and `never` are legacy values that will be removed in the next major version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background.expandPrompt")]
        public object? BackgroundExpandPrompt { get; set; }

        /// <summary>
        /// Bytes of the image to use as a background image guidance. Only available in the POST request<br/>
        /// Can't be provided if `removeBackground` is set to `false`<br/>
        /// The maximum size of the image is 30MB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background.guidance.imageFile")]
        public byte[]? BackgroundGuidanceImageFile { get; set; }

        /// <summary>
        /// Bytes of the image to use as a background image guidance. Only available in the POST request<br/>
        /// Can't be provided if `removeBackground` is set to `false`<br/>
        /// The maximum size of the image is 30MB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background.guidance.imageFilename")]
        public string? BackgroundGuidanceImageFilename { get; set; }

        /// <summary>
        /// How closely the generated background will be matching the guiding image, between 0 and 1.<br/>
        /// A value of 1 means it will match the guiding image as much as possible, a value of 0 means the guiding image will be ignored.<br/>
        /// (Only working when using the [new model](https://docs.photoroom.com/image-editing-api-plus-plan/ai-backgrounds#important-model-selection))
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background.guidance.scale")]
        public double? BackgroundGuidanceScale { get; set; }

        /// <summary>
        /// Bytes of the image to use as a background. Only available in the POST request<br/>
        /// Can't be provided if `removeBackground` is set to `false`<br/>
        /// The maximum size of the image is 30MB.<br/>
        /// If `background.imageFile` is provided, neither `background.imageUrl` nor `background.prompt` can be provided, and vice versa.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background.imageFile")]
        public byte[]? BackgroundImageFile { get; set; }

        /// <summary>
        /// Bytes of the image to use as a background. Only available in the POST request<br/>
        /// Can't be provided if `removeBackground` is set to `false`<br/>
        /// The maximum size of the image is 30MB.<br/>
        /// If `background.imageFile` is provided, neither `background.imageUrl` nor `background.prompt` can be provided, and vice versa.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background.imageFilename")]
        public string? BackgroundImageFilename { get; set; }

        /// <summary>
        /// (LEGACY) This parameter will only have an effect when using the previous AI Backgrounds model, which is used when setting the header: `pr-ai-background-model-version: 2`<br/>
        /// A negative prompt to use for guiding the background generation process; If provided, the generation algorithm will try to avoid properties listed in the negativePrompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background.negativePrompt")]
        public string? BackgroundNegativePrompt { get; set; }

        /// <summary>
        /// Prompt to use for guiding the background generation process.<br/>
        /// Tips for writing high-quality prompts are available [in our documentation](https://docs.photoroom.com/image-editing-api-plus-plan/ai-backgrounds#how-to-write-a-high-quality-prompt).<br/>
        /// If `background.prompt` is provided, neither `background.imageUrl` nor `background.imageFile` can be provided, and vice versa.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background.prompt")]
        public string? BackgroundPrompt { get; set; }

        /// <summary>
        /// Whether the background should fit or fill (default) the output image If set to `fit`, the empty pixels will be transparent<br/>
        /// Can only be provided if `background.imageUrl` or `background.imageFile` is provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background.scaling")]
        public string? BackgroundScaling { get; set; }

        /// <summary>
        /// Seed used to generate the background. Can be used to get similar looking results for the same prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background.seed")]
        public double? BackgroundSeed { get; set; }

        /// <summary>
        /// If enabled, the input image will be beautified (imageFile or imageUrl).<br/>
        /// This is intended to enhance product images by automatically improving the aesthetics of the image, such as the lighting, background, and overall appearance.<br/>
        /// If set to `ai.auto`, the input image will be beautified to match the aesthetic of a packshot product image.<br/>
        /// If set to `ai.food`, the input image will be beautified in a way that's specific to food images, such as placing the subject on a plate.<br/>
        /// If set to `ai.car`, the input image will be beautified in a way that's specific to car images, such as removing reflections.<br/>
        /// Important:<br/>
        /// - the beautifier will not preserve the original background: we recommend using this option along with `removeBackground` set to `true`<br/>
        /// - the beautifier is meant for images of products, food, or cars; we do not recommend using it with subjects such as humans, pets, etc.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("beautify.mode")]
        public string? BeautifyMode { get; set; }

        /// <summary>
        /// Seed used to run the subject beautifier. Can be used to get similar looking results for the same subject.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("beautify.seed")]
        public double? BeautifySeed { get; set; }

        /// <summary>
        /// (DEPRECATED) Use `editWithAI.mode` instead.<br/>
        /// Describe any change mode to use on the main image used by the API.<br/>
        /// Currently, only `ai.auto` is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("describeAnyChange.mode")]
        public string? DescribeAnyChangeMode { get; set; }

        /// <summary>
        /// (DEPRECATED) Use `editWithAI.prompt` instead.<br/>
        /// The natural language prompt describing the change to apply to the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("describeAnyChange.prompt")]
        public string? DescribeAnyChangePrompt { get; set; }

        /// <summary>
        /// (DEPRECATED) Use `editWithAI.seed` instead.<br/>
        /// Seed used for the generation. Can be used to get similar looking results for the same prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("describeAnyChange.seed")]
        public double? DescribeAnyChangeSeed { get; set; }

        /// <summary>
        /// Edit with AI mode to use on the main image used by the API.<br/>
        /// Currently, only `ai.auto` is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("editWithAI.mode")]
        public string? EditWithAIMode { get; set; }

        /// <summary>
        /// The natural language prompt describing the change to apply to the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("editWithAI.prompt")]
        public string? EditWithAIPrompt { get; set; }

        /// <summary>
        /// Seed used for the generation. Can be used to get similar looking results for the same prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("editWithAI.seed")]
        public double? EditWithAISeed { get; set; }

        /// <summary>
        /// Expand mode to use on the main image used by the API.<br/>
        /// If set to `ai.auto`, all transparent pixels will automatically be filled based on the content of the current background (either the original background, if `removeBackground` has been set to `false`, or a static background, if `background.imageUrl` has been provided)<br/>
        /// Expand will rely on output size, subject position, and fitting mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expand.mode")]
        public string? ExpandMode { get; set; }

        /// <summary>
        /// Seed used to generate the background. Can be used to get similar looking results for the same prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expand.seed")]
        public double? ExpandSeed { get; set; }

        /// <summary>
        /// The pixel density of the result image.<br/>
        /// Pixel density can be set to any value between 72 and 1200 dpi.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("export.dpi")]
        public double? ExportDpi { get; set; }

        /// <summary>
        /// The format of the result image.<br/>
        /// Default value is "png".<br/>
        /// Jpeg exports with a quality of 80 and WebP exports with a quality of 90.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("export.format")]
        public string? ExportFormat { get; set; }

        /// <summary>
        /// Must be set to `ai.auto` to enable flat lay generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flatLay.mode")]
        public string? FlatLayMode { get; set; }

        /// <summary>
        /// Optional text prompt to guide the generation style.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flatLay.prompt")]
        public string? FlatLayPrompt { get; set; }

        /// <summary>
        /// The output size of the generated image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("flatLay.size")]
        public string? FlatLaySize { get; set; }

        /// <summary>
        /// Must be set to `ai.auto` to enable ghost mannequin generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ghostMannequin.mode")]
        public string? GhostMannequinMode { get; set; }

        /// <summary>
        /// Optional text prompt to guide the generation style.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ghostMannequin.prompt")]
        public string? GhostMannequinPrompt { get; set; }

        /// <summary>
        /// The output size of the generated image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ghostMannequin.size")]
        public string? GhostMannequinSize { get; set; }

        /// <summary>
        /// [Advanced] Defines the horizontal alignment of the cutout subject within its bounding box.<br/>
        /// Specifying a custom horizontal alignment will implicitly set `ignorePaddingAndSnapOnCroppedSides` to `false` for the horizontal direction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("horizontalAlignment")]
        public string? HorizontalAlignment { get; set; }

        /// <summary>
        /// If set to `true` (default), cropped sides of the subject will snap to the edges For instance, for a portrait image cropped below the elbows, the subject will be aligned at the bottom even if a bottom padding is provided (but it will still respect bottom margin)<br/>
        /// Can't be provided if `removeBackground` is set to `false`<br/>
        /// (See positioning section of the documentation for more information)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignorePaddingAndSnapOnCroppedSides")]
        public bool? IgnorePaddingAndSnapOnCroppedSides { get; set; }

        /// <summary>
        /// Bytes of the main image used by the API. The POST endpoint accepts `imageFile` only.<br/>
        /// The maximum size of the image is 30MB.<br/>
        /// If you want to send the URL of an image, please instead use the GET endpoint with the argument `imageUrl`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageFile")]
        public byte[]? ImageFile { get; set; }

        /// <summary>
        /// Bytes of the main image used by the API. The POST endpoint accepts `imageFile` only.<br/>
        /// The maximum size of the image is 30MB.<br/>
        /// If you want to send the URL of an image, please instead use the GET endpoint with the argument `imageUrl`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageFilename")]
        public string? ImageFilename { get; set; }

        /// <summary>
        /// The prompt to use for generating the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageFromPrompt.prompt")]
        public string? ImageFromPromptPrompt { get; set; }

        /// <summary>
        /// Seed used to run the AI image generator. Can be used to get similar looking results for the same prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageFromPrompt.seed")]
        public double? ImageFromPromptSeed { get; set; }

        /// <summary>
        /// Supported sizes for AI image generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("imageFromPrompt.size")]
        public string? ImageFromPromptSize { get; set; }

        /// <summary>
        /// If set to `auto` and if the image has transparency, the existing transparency will be used to cutout the subject.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keepExistingAlphaChannel")]
        public string? KeepExistingAlphaChannel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layers")]
        public object? Layers { get; set; }

        /// <summary>
        /// Lighting mode to use on the main image used by the API.<br/>
        /// If set to `ai.auto`, the lighting will be automatically adjusted<br/>
        /// If set to `ai.preserve-hue-and-saturation`, the lighting will be adjusted while keeping color hues and saturations as close as possible to the original image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lighting.mode")]
        public string? LightingMode { get; set; }

        /// <summary>
        /// General margin around the subject. Can be expressed as a number between 0 and 0.49, a percentage string between 0% and 49% (e.g., "30%"), or a pixel value string (e.g., "100px"). Unlike `padding`, margin is never ignored even on cropped sides of the subject. Expressed in a ratio of the output image size. See positioning section of the documentation for more information.<br/>
        /// Tips to assist with positioning are available [in our documentation](https://docs.photoroom.com/image-editing-api-plus-plan/positioning).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("margin")]
        public string? Margin { get; set; }

        /// <summary>
        /// Bottom Margin, overrides general margin on the bottom side. Accepts the same formats as `margin`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("marginBottom")]
        public string? MarginBottom { get; set; }

        /// <summary>
        /// Left Margin, overrides general margin on the left side. Accepts the same formats as `margin`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("marginLeft")]
        public string? MarginLeft { get; set; }

        /// <summary>
        /// Right Margin, overrides general margin on the right side. Accepts the same formats as `margin`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("marginRight")]
        public string? MarginRight { get; set; }

        /// <summary>
        /// Top Margin, overrides general margin on the top side. Accepts the same formats as `margin`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("marginTop")]
        public string? MarginTop { get; set; }

        /// <summary>
        /// Maximum output height. Can only be provided if `outputSize` is `originalImage` or `croppedSubject`. Useful for: redimensioning while keeping the aspect ratio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxHeight")]
        public double? MaxHeight { get; set; }

        /// <summary>
        /// Maximum output width. Can only be provided if `outputSize` is `originalImage` or `croppedSubject`. Useful for: resizing an image while keeping the aspect ratio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxWidth")]
        public double? MaxWidth { get; set; }

        /// <summary>
        /// Blur radius for the outline, creating a glow or soft edge effect. Higher values mean the outline will be more blurred, 0 means no blur.<br/>
        /// Minimum: 0, Maximum: 0.025
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outline.blurRadius")]
        public double? OutlineBlurRadius { get; set; }

        /// <summary>
        /// Apply a colored outline around the subject to highlight it. Can be a hex color without the hash sign (example: `FF0000`, `FF0000EE`) or color name (examples: `red`, `blue`)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outline.color")]
        public string? OutlineColor { get; set; }

        /// <summary>
        /// Width of the outline relative to the image size. Suggested values:<br/>
        /// - 0.01-0.02: Subtle/thin outline<br/>
        /// - 0.03-0.05: Standard/medium outline (default: 0.03)<br/>
        /// - 0.06-0.1: Bold/thick outline The value represents a ratio where 0.1 (10%) is the maximum thickness.<br/>
        /// Minimum: 0, Maximum: 0.1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outline.width")]
        public double? OutlineWidth { get; set; }

        /// <summary>
        /// Output size of the image. In the form of either:<br/>
        /// - `auto` to keep the template dimensions when templateId is defined, or behave like `originalImage` when templateId isn't defined (default)<br/>
        /// - `widthxheight` for a custom size (example: `200x400`)<br/>
        /// - `originalImage` to keep the original image dimensions<br/>
        /// - `croppedSubject` to use the size of the foreground dimensions after cropping around it
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputSize")]
        public string? OutputSize { get; set; }

        /// <summary>
        /// General padding around the subject. Can be expressed as a number between 0 and 0.49, a percentage string between 0% and 49% (e.g., "30%"), or a pixel value string (e.g., "100px"). Unlike `margin`, padding will be ignored on cropped sides of the subject if that option is enabled. Expressed in a ratio of the size of the document, minus margins (similar to CSS). See positioning section of the documentation for more information.<br/>
        /// Tips to assist with positioning are available [in our documentation](https://docs.photoroom.com/image-editing-api-plus-plan/positioning).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("padding")]
        public string? Padding { get; set; }

        /// <summary>
        /// Bottom padding, overrides general padding on the bottom side. Accepts the same formats as `padding`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paddingBottom")]
        public string? PaddingBottom { get; set; }

        /// <summary>
        /// Left padding, overrides general padding on the left side. Accepts the same formats as `padding`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paddingLeft")]
        public string? PaddingLeft { get; set; }

        /// <summary>
        /// Right padding, overrides general padding on the right side. Accepts the same formats as `padding`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paddingRight")]
        public string? PaddingRight { get; set; }

        /// <summary>
        /// Top padding, overrides general padding on the top side. Accepts the same formats as `padding`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("paddingTop")]
        public string? PaddingTop { get; set; }

        /// <summary>
        /// Controls which metadata from the original image will be preserved in the output image.<br/>
        /// - `never`: No metadata preservation (default)<br/>
        /// - `xmp`: Preserve XMP metadata including camera settings, copyright information, and other embedded metadata<br/>
        /// - `exifSubset`: Preserve EXIF Copyright (IFD0) and UserComment (ExifIFD) fields only.   **Deprecated** — use `exifSubsetWithXmpCompatibility` instead. Will be removed in a future release.<br/>
        /// - `exifSubsetWithXmpCompatibility`: Same as `exifSubset` but also writes Copyright and   UserComment as XMP fields (dc:rights / exif:UserComment) for applications that read   XMP instead of EXIF (e.g. Adobe products, macOS Preview).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preserveMetadata")]
        public string? PreserveMetadata { get; set; }

        /// <summary>
        /// [Advanced] `subjectBox` by default. When set to `originalImage`, the padding / margin will be around the original image and not the cropped subject.<br/>
        /// It can lead to the subject disappearing when scaling is set to 'fill', for instance if the subject is on the left of a landscape image and outputSize is a square.<br/>
        /// Most use cases don't require this option. It is useful if you'd like to maintain subject positioning in the original image.<br/>
        /// Can't be provided if `removeBackground` is set to `false`<br/>
        /// (See positioning section of the documentation for more information)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("referenceBox")]
        public string? ReferenceBox { get; set; }

        /// <summary>
        /// If enabled (default), the background of the image will be removed using PhotoRoom's award-winning algorithm
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removeBackground")]
        public bool? RemoveBackground { get; set; }

        /// <summary>
        /// Whether the subject should fit (default) or fill the output image If set to `fit`, the empty pixels will be transparent<br/>
        /// Can only be provided if `imageUrl` or `imageFile` is provided
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scaling")]
        public string? Scaling { get; set; }

        /// <summary>
        /// Controls whether or not the salient object should be kept or ignored by the segmentation model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segmentation.mode")]
        public string? SegmentationMode { get; set; }

        /// <summary>
        /// A textual description of what the segmentation should remove.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segmentation.negativePrompt")]
        public string? SegmentationNegativePrompt { get; set; }

        /// <summary>
        /// A textual description of what the segmentation should keep.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segmentation.prompt")]
        public string? SegmentationPrompt { get; set; }

        /// <summary>
        /// Shadow generation mode to use on the main image used by the API. If set to `ai.soft`, a soft shadow will be generated If set to `ai.hard`, a hard shadow will be generated If set to `ai.floating`, a floating shadow will be generated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shadow.mode")]
        public string? ShadowMode { get; set; }

        /// <summary>
        /// The ID of the template to render
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templateId")]
        public global::System.Guid? TemplateId { get; set; }

        /// <summary>
        /// Text removal mode to use on the main image used by the API.<br/>
        /// If set to `ai.artificial`, artificial text will be automatically removed. Artificial text includes all text added on an image through post-precessing, such as company name, watermarks, discount, etc.<br/>
        /// If set to `ai.natural`, natural text will be automatically removed. Natural text includes text that naturally occurs in an image such as writing on buildings or clothings, road signs, etc.<br/>
        /// If set to `ai.all`, all text (natural and artificial) will be automatically removed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("textRemoval.mode")]
        public string? TextRemovalMode { get; set; }

        /// <summary>
        /// Uncrop mode to use on the main image used by the API.<br/>
        /// Currently, only `ai.auto` is supported. With `ai.auto`, the subject will be automatically detected and uncropped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uncrop.mode")]
        public string? UncropMode { get; set; }

        /// <summary>
        /// Seed used to generate the background. Can be used to get similar looking results for the same prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uncrop.seed")]
        public double? UncropSeed { get; set; }

        /// <summary>
        /// (ALPHA) Warning: might get deprecated with a 2 weeks warning<br/>
        /// If enabled, the input image will be upscaled (imageFile or imageUrl)<br/>
        /// The input image (imageFile or imageUrl) must not exceed 1000x1000 pixels in dimensions when using `ai.fast` mode. The input image (imageFile or imageUrl) must not exceed 512x512 pixels in dimensions when using `ai.slow` mode.<br/>
        /// The upscaling process will enlarge the input image up to 4 times its original size. This will significantly increase the resolution and affect both the input processing and the final output dimensions.<br/>
        /// ai.fast: This algorithm is optimized for speed and may not produce the highest quality results. ai.slow: This algorithm is optimized for quality and may take more time to process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("upscale.mode")]
        public string? UpscaleMode { get; set; }

        /// <summary>
        /// [Advanced] Defines the vertical alignment of the cutout subject within its bounding box.<br/>
        /// Specifying a custom vertical alignment will implicitly set `ignorePaddingAndSnapOnCroppedSides` to `false` for the vertical direction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verticalAlignment")]
        public string? VerticalAlignment { get; set; }

        /// <summary>
        /// Additional product images showing different angles or details of the same item. These help the model better understand the product and generate more accurate results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("virtualModel.additionalProductImages")]
        public byte[]? VirtualModelAdditionalProductImages { get; set; }

        /// <summary>
        /// Must be set to `ai.auto` to enable virtual model generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("virtualModel.mode")]
        public string? VirtualModelMode { get; set; }

        /// <summary>
        /// The model (person) to use for the virtual try-on. Either a preset model name or a custom image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("virtualModel.model")]
        public object? VirtualModelModel { get; set; }

        /// <summary>
        /// The pose of the model in the generated image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("virtualModel.pose")]
        public string? VirtualModelPose { get; set; }

        /// <summary>
        /// Optional text prompt to guide the generation style.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("virtualModel.prompt")]
        public string? VirtualModelPrompt { get; set; }

        /// <summary>
        /// The output quality of the generated image. Higher quality produces larger images. `standard` outputs ~1K, `advanced` ~2K, and `premium` ~4K resolution.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("virtualModel.quality")]
        public string? VirtualModelQuality { get; set; }

        /// <summary>
        /// The scene (background/environment) to use. Either a preset scene name or a custom image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("virtualModel.scene")]
        public object? VirtualModelScene { get; set; }

        /// <summary>
        /// The output size of the generated image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("virtualModel.size")]
        public string? VirtualModelSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImagePostRequest" /> class.
        /// </summary>
        /// <param name="backgroundBlurMode">
        /// Type of blur to apply to the background.<br/>
        /// - `gaussian`: Applies a gaussian blur to the background.<br/>
        /// - `bokeh`: Applies a bokeh blur to the background.
        /// </param>
        /// <param name="backgroundBlurRadius">
        /// Radius of the blur effect. Higher values mean the result will be blurrier.<br/>
        /// Minimum: 0, Maximum: 0.05
        /// </param>
        /// <param name="backgroundColor">
        /// Color of the background. If omitted, background will be transparent unless `background.imageUrl` or `background.imageFile` is provided. Can be a hex color without the hash sign (example: `FF0000`, `FF0000EE`) or color name (examples: `red`, `blue`)<br/>
        /// When `removeBackground` is set to `false`, the color will be used to fill padding areas created by `outputSize` and any transparent areas in the original image.
        /// </param>
        /// <param name="backgroundExpandPrompt">
        /// If `ai.auto`, a pre-processing step is applied to expand the prompt into a longer form.<br/>
        /// `auto` and `never` are legacy values that will be removed in the next major version.
        /// </param>
        /// <param name="backgroundGuidanceImageFile">
        /// Bytes of the image to use as a background image guidance. Only available in the POST request<br/>
        /// Can't be provided if `removeBackground` is set to `false`<br/>
        /// The maximum size of the image is 30MB.
        /// </param>
        /// <param name="backgroundGuidanceImageFilename">
        /// Bytes of the image to use as a background image guidance. Only available in the POST request<br/>
        /// Can't be provided if `removeBackground` is set to `false`<br/>
        /// The maximum size of the image is 30MB.
        /// </param>
        /// <param name="backgroundGuidanceScale">
        /// How closely the generated background will be matching the guiding image, between 0 and 1.<br/>
        /// A value of 1 means it will match the guiding image as much as possible, a value of 0 means the guiding image will be ignored.<br/>
        /// (Only working when using the [new model](https://docs.photoroom.com/image-editing-api-plus-plan/ai-backgrounds#important-model-selection))
        /// </param>
        /// <param name="backgroundImageFile">
        /// Bytes of the image to use as a background. Only available in the POST request<br/>
        /// Can't be provided if `removeBackground` is set to `false`<br/>
        /// The maximum size of the image is 30MB.<br/>
        /// If `background.imageFile` is provided, neither `background.imageUrl` nor `background.prompt` can be provided, and vice versa.
        /// </param>
        /// <param name="backgroundImageFilename">
        /// Bytes of the image to use as a background. Only available in the POST request<br/>
        /// Can't be provided if `removeBackground` is set to `false`<br/>
        /// The maximum size of the image is 30MB.<br/>
        /// If `background.imageFile` is provided, neither `background.imageUrl` nor `background.prompt` can be provided, and vice versa.
        /// </param>
        /// <param name="backgroundNegativePrompt">
        /// (LEGACY) This parameter will only have an effect when using the previous AI Backgrounds model, which is used when setting the header: `pr-ai-background-model-version: 2`<br/>
        /// A negative prompt to use for guiding the background generation process; If provided, the generation algorithm will try to avoid properties listed in the negativePrompt.
        /// </param>
        /// <param name="backgroundPrompt">
        /// Prompt to use for guiding the background generation process.<br/>
        /// Tips for writing high-quality prompts are available [in our documentation](https://docs.photoroom.com/image-editing-api-plus-plan/ai-backgrounds#how-to-write-a-high-quality-prompt).<br/>
        /// If `background.prompt` is provided, neither `background.imageUrl` nor `background.imageFile` can be provided, and vice versa.
        /// </param>
        /// <param name="backgroundScaling">
        /// Whether the background should fit or fill (default) the output image If set to `fit`, the empty pixels will be transparent<br/>
        /// Can only be provided if `background.imageUrl` or `background.imageFile` is provided
        /// </param>
        /// <param name="backgroundSeed">
        /// Seed used to generate the background. Can be used to get similar looking results for the same prompt.
        /// </param>
        /// <param name="beautifyMode">
        /// If enabled, the input image will be beautified (imageFile or imageUrl).<br/>
        /// This is intended to enhance product images by automatically improving the aesthetics of the image, such as the lighting, background, and overall appearance.<br/>
        /// If set to `ai.auto`, the input image will be beautified to match the aesthetic of a packshot product image.<br/>
        /// If set to `ai.food`, the input image will be beautified in a way that's specific to food images, such as placing the subject on a plate.<br/>
        /// If set to `ai.car`, the input image will be beautified in a way that's specific to car images, such as removing reflections.<br/>
        /// Important:<br/>
        /// - the beautifier will not preserve the original background: we recommend using this option along with `removeBackground` set to `true`<br/>
        /// - the beautifier is meant for images of products, food, or cars; we do not recommend using it with subjects such as humans, pets, etc.
        /// </param>
        /// <param name="beautifySeed">
        /// Seed used to run the subject beautifier. Can be used to get similar looking results for the same subject.
        /// </param>
        /// <param name="describeAnyChangeMode">
        /// (DEPRECATED) Use `editWithAI.mode` instead.<br/>
        /// Describe any change mode to use on the main image used by the API.<br/>
        /// Currently, only `ai.auto` is supported.
        /// </param>
        /// <param name="describeAnyChangePrompt">
        /// (DEPRECATED) Use `editWithAI.prompt` instead.<br/>
        /// The natural language prompt describing the change to apply to the image.
        /// </param>
        /// <param name="describeAnyChangeSeed">
        /// (DEPRECATED) Use `editWithAI.seed` instead.<br/>
        /// Seed used for the generation. Can be used to get similar looking results for the same prompt.
        /// </param>
        /// <param name="editWithAIMode">
        /// Edit with AI mode to use on the main image used by the API.<br/>
        /// Currently, only `ai.auto` is supported.
        /// </param>
        /// <param name="editWithAIPrompt">
        /// The natural language prompt describing the change to apply to the image.
        /// </param>
        /// <param name="editWithAISeed">
        /// Seed used for the generation. Can be used to get similar looking results for the same prompt.
        /// </param>
        /// <param name="expandMode">
        /// Expand mode to use on the main image used by the API.<br/>
        /// If set to `ai.auto`, all transparent pixels will automatically be filled based on the content of the current background (either the original background, if `removeBackground` has been set to `false`, or a static background, if `background.imageUrl` has been provided)<br/>
        /// Expand will rely on output size, subject position, and fitting mode.
        /// </param>
        /// <param name="expandSeed">
        /// Seed used to generate the background. Can be used to get similar looking results for the same prompt.
        /// </param>
        /// <param name="exportDpi">
        /// The pixel density of the result image.<br/>
        /// Pixel density can be set to any value between 72 and 1200 dpi.
        /// </param>
        /// <param name="exportFormat">
        /// The format of the result image.<br/>
        /// Default value is "png".<br/>
        /// Jpeg exports with a quality of 80 and WebP exports with a quality of 90.
        /// </param>
        /// <param name="flatLayMode">
        /// Must be set to `ai.auto` to enable flat lay generation.
        /// </param>
        /// <param name="flatLayPrompt">
        /// Optional text prompt to guide the generation style.
        /// </param>
        /// <param name="flatLaySize">
        /// The output size of the generated image.
        /// </param>
        /// <param name="ghostMannequinMode">
        /// Must be set to `ai.auto` to enable ghost mannequin generation.
        /// </param>
        /// <param name="ghostMannequinPrompt">
        /// Optional text prompt to guide the generation style.
        /// </param>
        /// <param name="ghostMannequinSize">
        /// The output size of the generated image.
        /// </param>
        /// <param name="horizontalAlignment">
        /// [Advanced] Defines the horizontal alignment of the cutout subject within its bounding box.<br/>
        /// Specifying a custom horizontal alignment will implicitly set `ignorePaddingAndSnapOnCroppedSides` to `false` for the horizontal direction.
        /// </param>
        /// <param name="ignorePaddingAndSnapOnCroppedSides">
        /// If set to `true` (default), cropped sides of the subject will snap to the edges For instance, for a portrait image cropped below the elbows, the subject will be aligned at the bottom even if a bottom padding is provided (but it will still respect bottom margin)<br/>
        /// Can't be provided if `removeBackground` is set to `false`<br/>
        /// (See positioning section of the documentation for more information)
        /// </param>
        /// <param name="imageFile">
        /// Bytes of the main image used by the API. The POST endpoint accepts `imageFile` only.<br/>
        /// The maximum size of the image is 30MB.<br/>
        /// If you want to send the URL of an image, please instead use the GET endpoint with the argument `imageUrl`.
        /// </param>
        /// <param name="imageFilename">
        /// Bytes of the main image used by the API. The POST endpoint accepts `imageFile` only.<br/>
        /// The maximum size of the image is 30MB.<br/>
        /// If you want to send the URL of an image, please instead use the GET endpoint with the argument `imageUrl`.
        /// </param>
        /// <param name="imageFromPromptPrompt">
        /// The prompt to use for generating the image.
        /// </param>
        /// <param name="imageFromPromptSeed">
        /// Seed used to run the AI image generator. Can be used to get similar looking results for the same prompt.
        /// </param>
        /// <param name="imageFromPromptSize">
        /// Supported sizes for AI image generation
        /// </param>
        /// <param name="keepExistingAlphaChannel">
        /// If set to `auto` and if the image has transparency, the existing transparency will be used to cutout the subject.
        /// </param>
        /// <param name="layers"></param>
        /// <param name="lightingMode">
        /// Lighting mode to use on the main image used by the API.<br/>
        /// If set to `ai.auto`, the lighting will be automatically adjusted<br/>
        /// If set to `ai.preserve-hue-and-saturation`, the lighting will be adjusted while keeping color hues and saturations as close as possible to the original image
        /// </param>
        /// <param name="margin">
        /// General margin around the subject. Can be expressed as a number between 0 and 0.49, a percentage string between 0% and 49% (e.g., "30%"), or a pixel value string (e.g., "100px"). Unlike `padding`, margin is never ignored even on cropped sides of the subject. Expressed in a ratio of the output image size. See positioning section of the documentation for more information.<br/>
        /// Tips to assist with positioning are available [in our documentation](https://docs.photoroom.com/image-editing-api-plus-plan/positioning).
        /// </param>
        /// <param name="marginBottom">
        /// Bottom Margin, overrides general margin on the bottom side. Accepts the same formats as `margin`.
        /// </param>
        /// <param name="marginLeft">
        /// Left Margin, overrides general margin on the left side. Accepts the same formats as `margin`.
        /// </param>
        /// <param name="marginRight">
        /// Right Margin, overrides general margin on the right side. Accepts the same formats as `margin`.
        /// </param>
        /// <param name="marginTop">
        /// Top Margin, overrides general margin on the top side. Accepts the same formats as `margin`.
        /// </param>
        /// <param name="maxHeight">
        /// Maximum output height. Can only be provided if `outputSize` is `originalImage` or `croppedSubject`. Useful for: redimensioning while keeping the aspect ratio
        /// </param>
        /// <param name="maxWidth">
        /// Maximum output width. Can only be provided if `outputSize` is `originalImage` or `croppedSubject`. Useful for: resizing an image while keeping the aspect ratio
        /// </param>
        /// <param name="outlineBlurRadius">
        /// Blur radius for the outline, creating a glow or soft edge effect. Higher values mean the outline will be more blurred, 0 means no blur.<br/>
        /// Minimum: 0, Maximum: 0.025
        /// </param>
        /// <param name="outlineColor">
        /// Apply a colored outline around the subject to highlight it. Can be a hex color without the hash sign (example: `FF0000`, `FF0000EE`) or color name (examples: `red`, `blue`)
        /// </param>
        /// <param name="outlineWidth">
        /// Width of the outline relative to the image size. Suggested values:<br/>
        /// - 0.01-0.02: Subtle/thin outline<br/>
        /// - 0.03-0.05: Standard/medium outline (default: 0.03)<br/>
        /// - 0.06-0.1: Bold/thick outline The value represents a ratio where 0.1 (10%) is the maximum thickness.<br/>
        /// Minimum: 0, Maximum: 0.1
        /// </param>
        /// <param name="outputSize">
        /// Output size of the image. In the form of either:<br/>
        /// - `auto` to keep the template dimensions when templateId is defined, or behave like `originalImage` when templateId isn't defined (default)<br/>
        /// - `widthxheight` for a custom size (example: `200x400`)<br/>
        /// - `originalImage` to keep the original image dimensions<br/>
        /// - `croppedSubject` to use the size of the foreground dimensions after cropping around it
        /// </param>
        /// <param name="padding">
        /// General padding around the subject. Can be expressed as a number between 0 and 0.49, a percentage string between 0% and 49% (e.g., "30%"), or a pixel value string (e.g., "100px"). Unlike `margin`, padding will be ignored on cropped sides of the subject if that option is enabled. Expressed in a ratio of the size of the document, minus margins (similar to CSS). See positioning section of the documentation for more information.<br/>
        /// Tips to assist with positioning are available [in our documentation](https://docs.photoroom.com/image-editing-api-plus-plan/positioning).
        /// </param>
        /// <param name="paddingBottom">
        /// Bottom padding, overrides general padding on the bottom side. Accepts the same formats as `padding`.
        /// </param>
        /// <param name="paddingLeft">
        /// Left padding, overrides general padding on the left side. Accepts the same formats as `padding`.
        /// </param>
        /// <param name="paddingRight">
        /// Right padding, overrides general padding on the right side. Accepts the same formats as `padding`.
        /// </param>
        /// <param name="paddingTop">
        /// Top padding, overrides general padding on the top side. Accepts the same formats as `padding`.
        /// </param>
        /// <param name="preserveMetadata">
        /// Controls which metadata from the original image will be preserved in the output image.<br/>
        /// - `never`: No metadata preservation (default)<br/>
        /// - `xmp`: Preserve XMP metadata including camera settings, copyright information, and other embedded metadata<br/>
        /// - `exifSubset`: Preserve EXIF Copyright (IFD0) and UserComment (ExifIFD) fields only.   **Deprecated** — use `exifSubsetWithXmpCompatibility` instead. Will be removed in a future release.<br/>
        /// - `exifSubsetWithXmpCompatibility`: Same as `exifSubset` but also writes Copyright and   UserComment as XMP fields (dc:rights / exif:UserComment) for applications that read   XMP instead of EXIF (e.g. Adobe products, macOS Preview).
        /// </param>
        /// <param name="referenceBox">
        /// [Advanced] `subjectBox` by default. When set to `originalImage`, the padding / margin will be around the original image and not the cropped subject.<br/>
        /// It can lead to the subject disappearing when scaling is set to 'fill', for instance if the subject is on the left of a landscape image and outputSize is a square.<br/>
        /// Most use cases don't require this option. It is useful if you'd like to maintain subject positioning in the original image.<br/>
        /// Can't be provided if `removeBackground` is set to `false`<br/>
        /// (See positioning section of the documentation for more information)
        /// </param>
        /// <param name="removeBackground">
        /// If enabled (default), the background of the image will be removed using PhotoRoom's award-winning algorithm
        /// </param>
        /// <param name="scaling">
        /// Whether the subject should fit (default) or fill the output image If set to `fit`, the empty pixels will be transparent<br/>
        /// Can only be provided if `imageUrl` or `imageFile` is provided
        /// </param>
        /// <param name="segmentationMode">
        /// Controls whether or not the salient object should be kept or ignored by the segmentation model.
        /// </param>
        /// <param name="segmentationNegativePrompt">
        /// A textual description of what the segmentation should remove.
        /// </param>
        /// <param name="segmentationPrompt">
        /// A textual description of what the segmentation should keep.
        /// </param>
        /// <param name="shadowMode">
        /// Shadow generation mode to use on the main image used by the API. If set to `ai.soft`, a soft shadow will be generated If set to `ai.hard`, a hard shadow will be generated If set to `ai.floating`, a floating shadow will be generated
        /// </param>
        /// <param name="templateId">
        /// The ID of the template to render
        /// </param>
        /// <param name="textRemovalMode">
        /// Text removal mode to use on the main image used by the API.<br/>
        /// If set to `ai.artificial`, artificial text will be automatically removed. Artificial text includes all text added on an image through post-precessing, such as company name, watermarks, discount, etc.<br/>
        /// If set to `ai.natural`, natural text will be automatically removed. Natural text includes text that naturally occurs in an image such as writing on buildings or clothings, road signs, etc.<br/>
        /// If set to `ai.all`, all text (natural and artificial) will be automatically removed.
        /// </param>
        /// <param name="uncropMode">
        /// Uncrop mode to use on the main image used by the API.<br/>
        /// Currently, only `ai.auto` is supported. With `ai.auto`, the subject will be automatically detected and uncropped.
        /// </param>
        /// <param name="uncropSeed">
        /// Seed used to generate the background. Can be used to get similar looking results for the same prompt.
        /// </param>
        /// <param name="upscaleMode">
        /// (ALPHA) Warning: might get deprecated with a 2 weeks warning<br/>
        /// If enabled, the input image will be upscaled (imageFile or imageUrl)<br/>
        /// The input image (imageFile or imageUrl) must not exceed 1000x1000 pixels in dimensions when using `ai.fast` mode. The input image (imageFile or imageUrl) must not exceed 512x512 pixels in dimensions when using `ai.slow` mode.<br/>
        /// The upscaling process will enlarge the input image up to 4 times its original size. This will significantly increase the resolution and affect both the input processing and the final output dimensions.<br/>
        /// ai.fast: This algorithm is optimized for speed and may not produce the highest quality results. ai.slow: This algorithm is optimized for quality and may take more time to process.
        /// </param>
        /// <param name="verticalAlignment">
        /// [Advanced] Defines the vertical alignment of the cutout subject within its bounding box.<br/>
        /// Specifying a custom vertical alignment will implicitly set `ignorePaddingAndSnapOnCroppedSides` to `false` for the vertical direction.
        /// </param>
        /// <param name="virtualModelAdditionalProductImages">
        /// Additional product images showing different angles or details of the same item. These help the model better understand the product and generate more accurate results.
        /// </param>
        /// <param name="virtualModelMode">
        /// Must be set to `ai.auto` to enable virtual model generation.
        /// </param>
        /// <param name="virtualModelModel">
        /// The model (person) to use for the virtual try-on. Either a preset model name or a custom image.
        /// </param>
        /// <param name="virtualModelPose">
        /// The pose of the model in the generated image.
        /// </param>
        /// <param name="virtualModelPrompt">
        /// Optional text prompt to guide the generation style.
        /// </param>
        /// <param name="virtualModelQuality">
        /// The output quality of the generated image. Higher quality produces larger images. `standard` outputs ~1K, `advanced` ~2K, and `premium` ~4K resolution.
        /// </param>
        /// <param name="virtualModelScene">
        /// The scene (background/environment) to use. Either a preset scene name or a custom image.
        /// </param>
        /// <param name="virtualModelSize">
        /// The output size of the generated image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditImagePostRequest(
            string? backgroundBlurMode,
            double? backgroundBlurRadius,
            string? backgroundColor,
            object? backgroundExpandPrompt,
            byte[]? backgroundGuidanceImageFile,
            string? backgroundGuidanceImageFilename,
            double? backgroundGuidanceScale,
            byte[]? backgroundImageFile,
            string? backgroundImageFilename,
            string? backgroundNegativePrompt,
            string? backgroundPrompt,
            string? backgroundScaling,
            double? backgroundSeed,
            string? beautifyMode,
            double? beautifySeed,
            string? describeAnyChangeMode,
            string? describeAnyChangePrompt,
            double? describeAnyChangeSeed,
            string? editWithAIMode,
            string? editWithAIPrompt,
            double? editWithAISeed,
            string? expandMode,
            double? expandSeed,
            double? exportDpi,
            string? exportFormat,
            string? flatLayMode,
            string? flatLayPrompt,
            string? flatLaySize,
            string? ghostMannequinMode,
            string? ghostMannequinPrompt,
            string? ghostMannequinSize,
            string? horizontalAlignment,
            bool? ignorePaddingAndSnapOnCroppedSides,
            byte[]? imageFile,
            string? imageFilename,
            string? imageFromPromptPrompt,
            double? imageFromPromptSeed,
            string? imageFromPromptSize,
            string? keepExistingAlphaChannel,
            object? layers,
            string? lightingMode,
            string? margin,
            string? marginBottom,
            string? marginLeft,
            string? marginRight,
            string? marginTop,
            double? maxHeight,
            double? maxWidth,
            double? outlineBlurRadius,
            string? outlineColor,
            double? outlineWidth,
            string? outputSize,
            string? padding,
            string? paddingBottom,
            string? paddingLeft,
            string? paddingRight,
            string? paddingTop,
            string? preserveMetadata,
            string? referenceBox,
            bool? removeBackground,
            string? scaling,
            string? segmentationMode,
            string? segmentationNegativePrompt,
            string? segmentationPrompt,
            string? shadowMode,
            global::System.Guid? templateId,
            string? textRemovalMode,
            string? uncropMode,
            double? uncropSeed,
            string? upscaleMode,
            string? verticalAlignment,
            byte[]? virtualModelAdditionalProductImages,
            string? virtualModelMode,
            object? virtualModelModel,
            string? virtualModelPose,
            string? virtualModelPrompt,
            string? virtualModelQuality,
            object? virtualModelScene,
            string? virtualModelSize)
        {
            this.BackgroundBlurMode = backgroundBlurMode;
            this.BackgroundBlurRadius = backgroundBlurRadius;
            this.BackgroundColor = backgroundColor;
            this.BackgroundExpandPrompt = backgroundExpandPrompt;
            this.BackgroundGuidanceImageFile = backgroundGuidanceImageFile;
            this.BackgroundGuidanceImageFilename = backgroundGuidanceImageFilename;
            this.BackgroundGuidanceScale = backgroundGuidanceScale;
            this.BackgroundImageFile = backgroundImageFile;
            this.BackgroundImageFilename = backgroundImageFilename;
            this.BackgroundNegativePrompt = backgroundNegativePrompt;
            this.BackgroundPrompt = backgroundPrompt;
            this.BackgroundScaling = backgroundScaling;
            this.BackgroundSeed = backgroundSeed;
            this.BeautifyMode = beautifyMode;
            this.BeautifySeed = beautifySeed;
            this.DescribeAnyChangeMode = describeAnyChangeMode;
            this.DescribeAnyChangePrompt = describeAnyChangePrompt;
            this.DescribeAnyChangeSeed = describeAnyChangeSeed;
            this.EditWithAIMode = editWithAIMode;
            this.EditWithAIPrompt = editWithAIPrompt;
            this.EditWithAISeed = editWithAISeed;
            this.ExpandMode = expandMode;
            this.ExpandSeed = expandSeed;
            this.ExportDpi = exportDpi;
            this.ExportFormat = exportFormat;
            this.FlatLayMode = flatLayMode;
            this.FlatLayPrompt = flatLayPrompt;
            this.FlatLaySize = flatLaySize;
            this.GhostMannequinMode = ghostMannequinMode;
            this.GhostMannequinPrompt = ghostMannequinPrompt;
            this.GhostMannequinSize = ghostMannequinSize;
            this.HorizontalAlignment = horizontalAlignment;
            this.IgnorePaddingAndSnapOnCroppedSides = ignorePaddingAndSnapOnCroppedSides;
            this.ImageFile = imageFile;
            this.ImageFilename = imageFilename;
            this.ImageFromPromptPrompt = imageFromPromptPrompt;
            this.ImageFromPromptSeed = imageFromPromptSeed;
            this.ImageFromPromptSize = imageFromPromptSize;
            this.KeepExistingAlphaChannel = keepExistingAlphaChannel;
            this.Layers = layers;
            this.LightingMode = lightingMode;
            this.Margin = margin;
            this.MarginBottom = marginBottom;
            this.MarginLeft = marginLeft;
            this.MarginRight = marginRight;
            this.MarginTop = marginTop;
            this.MaxHeight = maxHeight;
            this.MaxWidth = maxWidth;
            this.OutlineBlurRadius = outlineBlurRadius;
            this.OutlineColor = outlineColor;
            this.OutlineWidth = outlineWidth;
            this.OutputSize = outputSize;
            this.Padding = padding;
            this.PaddingBottom = paddingBottom;
            this.PaddingLeft = paddingLeft;
            this.PaddingRight = paddingRight;
            this.PaddingTop = paddingTop;
            this.PreserveMetadata = preserveMetadata;
            this.ReferenceBox = referenceBox;
            this.RemoveBackground = removeBackground;
            this.Scaling = scaling;
            this.SegmentationMode = segmentationMode;
            this.SegmentationNegativePrompt = segmentationNegativePrompt;
            this.SegmentationPrompt = segmentationPrompt;
            this.ShadowMode = shadowMode;
            this.TemplateId = templateId;
            this.TextRemovalMode = textRemovalMode;
            this.UncropMode = uncropMode;
            this.UncropSeed = uncropSeed;
            this.UpscaleMode = upscaleMode;
            this.VerticalAlignment = verticalAlignment;
            this.VirtualModelAdditionalProductImages = virtualModelAdditionalProductImages;
            this.VirtualModelMode = virtualModelMode;
            this.VirtualModelModel = virtualModelModel;
            this.VirtualModelPose = virtualModelPose;
            this.VirtualModelPrompt = virtualModelPrompt;
            this.VirtualModelQuality = virtualModelQuality;
            this.VirtualModelScene = virtualModelScene;
            this.VirtualModelSize = virtualModelSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditImagePostRequest" /> class.
        /// </summary>
        public EditImagePostRequest()
        {
        }
    }
}