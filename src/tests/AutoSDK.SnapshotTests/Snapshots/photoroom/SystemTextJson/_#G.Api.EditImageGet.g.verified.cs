//HintName: G.Api.EditImageGet.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareEditImageGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::G.EditImageGetBackgroundBlurMode? backgroundBlurMode,
            ref double? backgroundBlurRadius,
            ref string? backgroundColor,
            ref global::G.AnyOf<string, string, global::G.EditImageGetBackgroundExpandPrompt2>? backgroundExpandPrompt,
            byte[]? backgroundGuidanceImageFile,
            ref string? backgroundGuidanceImageUrl,
            ref double? backgroundGuidanceScale,
            ref string? backgroundImageUrl,
            ref string? backgroundNegativePrompt,
            ref string? backgroundPrompt,
            ref global::G.EditImageGetBackgroundScaling? backgroundScaling,
            ref double? backgroundSeed,
            ref global::G.EditImageGetBeautifyMode? beautifyMode,
            ref double? beautifySeed,
            ref string? describeAnyChangeMode,
            ref string? describeAnyChangePrompt,
            ref double? describeAnyChangeSeed,
            ref string? editWithAIMode,
            ref string? editWithAIPrompt,
            ref double? editWithAISeed,
            ref string? expandMode,
            ref double? expandSeed,
            ref double? exportDpi,
            ref global::G.EditImageGetExportFormat? exportFormat,
            ref string? flatLayMode,
            ref string? flatLayPrompt,
            ref global::G.EditImageGetFlatLaySize? flatLaySize,
            ref string? ghostMannequinMode,
            ref string? ghostMannequinPrompt,
            ref global::G.EditImageGetGhostMannequinSize? ghostMannequinSize,
            ref global::G.EditImageGetHorizontalAlignment? horizontalAlignment,
            ref bool? ignorePaddingAndSnapOnCroppedSides,
            ref string? imageFromPromptPrompt,
            ref double? imageFromPromptSeed,
            ref global::G.EditImageGetImageFromPromptSize? imageFromPromptSize,
            ref string? imageUrl,
            ref global::G.EditImageGetKeepExistingAlphaChannel? keepExistingAlphaChannel,
            object? layers,
            ref global::G.EditImageGetLightingMode? lightingMode,
            ref string? margin,
            ref string? marginBottom,
            ref string? marginLeft,
            ref string? marginRight,
            ref string? marginTop,
            ref double? maxHeight,
            ref double? maxWidth,
            ref double? outlineBlurRadius,
            ref string? outlineColor,
            ref double? outlineWidth,
            ref string? outputSize,
            ref string? padding,
            ref string? paddingBottom,
            ref string? paddingLeft,
            ref string? paddingRight,
            ref string? paddingTop,
            ref global::G.EditImageGetPreserveMetadata? preserveMetadata,
            ref global::G.EditImageGetReferenceBox? referenceBox,
            ref bool? removeBackground,
            ref global::G.EditImageGetScaling? scaling,
            ref global::G.EditImageGetSegmentationMode? segmentationMode,
            ref string? segmentationNegativePrompt,
            ref string? segmentationPrompt,
            ref global::G.EditImageGetShadowMode? shadowMode,
            ref global::System.Guid? templateId,
            ref global::G.EditImageGetTextRemovalMode? textRemovalMode,
            ref string? uncropMode,
            ref double? uncropSeed,
            ref global::G.EditImageGetUpscaleMode? upscaleMode,
            ref global::G.EditImageGetVerticalAlignment? verticalAlignment,
            global::System.Collections.Generic.IList<string>? virtualModelAdditionalProductImages,
            ref string? virtualModelMode,
            ref global::G.AnyOf<global::G.EditImageGetVirtualModelModelVariant1, global::G.EditImageGetVirtualModelModelVariant2>? virtualModelModel,
            ref global::G.EditImageGetVirtualModelPose? virtualModelPose,
            ref string? virtualModelPrompt,
            ref global::G.EditImageGetVirtualModelQuality? virtualModelQuality,
            ref global::G.AnyOf<global::G.EditImageGetVirtualModelSceneVariant1, global::G.EditImageGetVirtualModelSceneVariant2>? virtualModelScene,
            ref global::G.EditImageGetVirtualModelSize? virtualModelSize);
        partial void PrepareEditImageGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.EditImageGetBackgroundBlurMode? backgroundBlurMode,
            double? backgroundBlurRadius,
            string? backgroundColor,
            global::G.AnyOf<string, string, global::G.EditImageGetBackgroundExpandPrompt2>? backgroundExpandPrompt,
            byte[]? backgroundGuidanceImageFile,
            string? backgroundGuidanceImageUrl,
            double? backgroundGuidanceScale,
            string? backgroundImageUrl,
            string? backgroundNegativePrompt,
            string? backgroundPrompt,
            global::G.EditImageGetBackgroundScaling? backgroundScaling,
            double? backgroundSeed,
            global::G.EditImageGetBeautifyMode? beautifyMode,
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
            global::G.EditImageGetExportFormat? exportFormat,
            string? flatLayMode,
            string? flatLayPrompt,
            global::G.EditImageGetFlatLaySize? flatLaySize,
            string? ghostMannequinMode,
            string? ghostMannequinPrompt,
            global::G.EditImageGetGhostMannequinSize? ghostMannequinSize,
            global::G.EditImageGetHorizontalAlignment? horizontalAlignment,
            bool? ignorePaddingAndSnapOnCroppedSides,
            string? imageFromPromptPrompt,
            double? imageFromPromptSeed,
            global::G.EditImageGetImageFromPromptSize? imageFromPromptSize,
            string? imageUrl,
            global::G.EditImageGetKeepExistingAlphaChannel? keepExistingAlphaChannel,
            object? layers,
            global::G.EditImageGetLightingMode? lightingMode,
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
            global::G.EditImageGetPreserveMetadata? preserveMetadata,
            global::G.EditImageGetReferenceBox? referenceBox,
            bool? removeBackground,
            global::G.EditImageGetScaling? scaling,
            global::G.EditImageGetSegmentationMode? segmentationMode,
            string? segmentationNegativePrompt,
            string? segmentationPrompt,
            global::G.EditImageGetShadowMode? shadowMode,
            global::System.Guid? templateId,
            global::G.EditImageGetTextRemovalMode? textRemovalMode,
            string? uncropMode,
            double? uncropSeed,
            global::G.EditImageGetUpscaleMode? upscaleMode,
            global::G.EditImageGetVerticalAlignment? verticalAlignment,
            global::System.Collections.Generic.IList<string>? virtualModelAdditionalProductImages,
            string? virtualModelMode,
            global::G.AnyOf<global::G.EditImageGetVirtualModelModelVariant1, global::G.EditImageGetVirtualModelModelVariant2>? virtualModelModel,
            global::G.EditImageGetVirtualModelPose? virtualModelPose,
            string? virtualModelPrompt,
            global::G.EditImageGetVirtualModelQuality? virtualModelQuality,
            global::G.AnyOf<global::G.EditImageGetVirtualModelSceneVariant1, global::G.EditImageGetVirtualModelSceneVariant2>? virtualModelScene,
            global::G.EditImageGetVirtualModelSize? virtualModelSize);
        partial void ProcessEditImageGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessEditImageGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref byte[] content);

        /// <summary>
        /// Image Editing v2 (Plus plan)<br/>
        /// This endpoint processes an image and applies one or more edits: background removal, AI-generated backgrounds (background.prompt), realistic shadows (shadow.mode), relighting (lighting.mode), text removal (textRemoval.mode), background blur (background.blur.*), subject outline (outline.*), AI beautification (beautify.mode), Flat Lay (flatLay.*), Ghost Mannequin (ghostMannequin.*), Virtual Model (virtualModel.*), AI expand (expand.mode), AI uncrop (uncrop.mode), AI upscale (upscale.mode), and positioning/resizing (padding, margin, outputSize).<br/>
        /// Parameters are grouped by feature using dot notation: background.* for backgrounds, shadow.* for shadows, lighting.* for relighting, outline.* for subject outlines, beautify.* for AI beautification, flatLay.* for flat lay generation, ghostMannequin.* for ghost mannequin generation, virtualModel.* for virtual model generation, expand.* for AI expand, uncrop.* for AI uncrop, upscale.* for AI upscale, export.* for output format, and segmentation.* for text-guided segmentation.<br/>
        /// Edits can be combined in a single call.<br/>
        /// It accepts a URL input for the image. If you want to directly upload an image file, please use the POST endpoint. For more details on the difference between the GET and POST endpoints, please have a look at our documentation: https://docs.photoroom.com/image-editing-api/which-endpoints-are-available.<br/>
        /// For the simplest integration (recommended for no-code tools like Lovable), use this GET endpoint with imageUrl — no file upload handling required. <br/>
        /// Example of a request: GET https://image-api.photoroom.com/v2/edit?imageUrl=https://example.com/photo.jpg&amp;removeBackground=true&amp;background.color=FFFFFF&amp;outputSize=1000x1000&amp;padding=0.1 with header x-api-key: YOUR_API_KEY<br/>
        /// The response is the edited image as binary data (image/png by default). To change format, set export.format to jpeg or webp.<br/>
        /// Full documentation: https://docs.photoroom.com/image-editing-api-plus-plan/quickstart-guide<br/>
        /// Feature documentation:<br/>
        /// - [HD Background Removal](https://docs.photoroom.com/image-editing-api-plus-plan/hd-background-removal)<br/>
        /// - [Positioning (padding, margin, scaling)](https://docs.photoroom.com/image-editing-api-plus-plan/positioning)<br/>
        /// - [Output Size](https://docs.photoroom.com/image-editing-api-plus-plan/output-size)<br/>
        /// - [Static Background](https://docs.photoroom.com/image-editing-api-plus-plan/static-background)<br/>
        /// - [Background Blur](https://docs.photoroom.com/image-editing-api-plus-plan/background-blur)<br/>
        /// - [Subject Outline](https://docs.photoroom.com/image-editing-api-plus-plan/subject-outline)<br/>
        /// - [AI Shadows](https://docs.photoroom.com/image-editing-api-plus-plan/ai-shadows)<br/>
        /// - [AI Backgrounds](https://docs.photoroom.com/image-editing-api-plus-plan/ai-backgrounds)<br/>
        /// - [AI Relight](https://docs.photoroom.com/image-editing-api-plus-plan/ai-relight)<br/>
        /// - [AI Text Removal](https://docs.photoroom.com/image-editing-api-plus-plan/ai-text-removal)<br/>
        /// - [AI Expand](https://docs.photoroom.com/image-editing-api-plus-plan/ai-expand)<br/>
        /// - [AI Uncrop](https://docs.photoroom.com/image-editing-api-plus-plan/ai-uncrop)<br/>
        /// - [AI Beautifier](https://docs.photoroom.com/image-editing-api-plus-plan/ai-beautifier)<br/>
        /// - [Flat Lay](https://docs.photoroom.com/image-editing-api-plus-plan/flat-lay)<br/>
        /// - [Ghost Mannequin](https://docs.photoroom.com/image-editing-api-plus-plan/ghost-mannequin)<br/>
        /// - [Virtual Model](https://docs.photoroom.com/image-editing-api-plus-plan/virtual-model)<br/>
        /// - [AI Upscale](https://docs.photoroom.com/image-editing-api-plus-plan/alpha-ai-upscale)<br/>
        /// - [Describe Any Change](https://docs.photoroom.com/image-editing-api-plus-plan/edit-with-ai)<br/>
        /// - [Create Any Image](https://docs.photoroom.com/image-editing-api-plus-plan/alpha-create-any-image)<br/>
        /// - [Text-Guided Segmentation](https://docs.photoroom.com/image-editing-api-plus-plan/alpha-text-guided-segmentation)<br/>
        /// - [Sandbox Mode (free testing)](https://docs.photoroom.com/image-editing-api-plus-plan/sandbox-mode)
        /// </summary>
        /// <param name="backgroundBlurMode"></param>
        /// <param name="backgroundBlurRadius">
        /// Default Value: 0.01F
        /// </param>
        /// <param name="backgroundColor">
        /// Default Value: transparent
        /// </param>
        /// <param name="backgroundExpandPrompt"></param>
        /// <param name="backgroundGuidanceImageFile"></param>
        /// <param name="backgroundGuidanceImageUrl"></param>
        /// <param name="backgroundGuidanceScale">
        /// Default Value: 0.6F
        /// </param>
        /// <param name="backgroundImageUrl"></param>
        /// <param name="backgroundNegativePrompt"></param>
        /// <param name="backgroundPrompt"></param>
        /// <param name="backgroundScaling">
        /// Default Value: fill
        /// </param>
        /// <param name="backgroundSeed"></param>
        /// <param name="beautifyMode"></param>
        /// <param name="beautifySeed"></param>
        /// <param name="describeAnyChangeMode"></param>
        /// <param name="describeAnyChangePrompt"></param>
        /// <param name="describeAnyChangeSeed"></param>
        /// <param name="editWithAIMode"></param>
        /// <param name="editWithAIPrompt"></param>
        /// <param name="editWithAISeed"></param>
        /// <param name="expandMode"></param>
        /// <param name="expandSeed"></param>
        /// <param name="exportDpi"></param>
        /// <param name="exportFormat">
        /// Default Value: png
        /// </param>
        /// <param name="flatLayMode"></param>
        /// <param name="flatLayPrompt"></param>
        /// <param name="flatLaySize">
        /// Default Value: SQUARE_HD
        /// </param>
        /// <param name="ghostMannequinMode"></param>
        /// <param name="ghostMannequinPrompt"></param>
        /// <param name="ghostMannequinSize">
        /// Default Value: SQUARE_HD
        /// </param>
        /// <param name="horizontalAlignment"></param>
        /// <param name="ignorePaddingAndSnapOnCroppedSides">
        /// Default Value: true
        /// </param>
        /// <param name="imageFromPromptPrompt"></param>
        /// <param name="imageFromPromptSeed"></param>
        /// <param name="imageFromPromptSize"></param>
        /// <param name="imageUrl"></param>
        /// <param name="keepExistingAlphaChannel">
        /// Default Value: never
        /// </param>
        /// <param name="layers"></param>
        /// <param name="lightingMode"></param>
        /// <param name="margin">
        /// Default Value: 0
        /// </param>
        /// <param name="marginBottom"></param>
        /// <param name="marginLeft"></param>
        /// <param name="marginRight"></param>
        /// <param name="marginTop"></param>
        /// <param name="maxHeight"></param>
        /// <param name="maxWidth"></param>
        /// <param name="outlineBlurRadius">
        /// Default Value: 0
        /// </param>
        /// <param name="outlineColor"></param>
        /// <param name="outlineWidth">
        /// Default Value: 0.03F
        /// </param>
        /// <param name="outputSize">
        /// Default Value: auto
        /// </param>
        /// <param name="padding">
        /// Default Value: 0
        /// </param>
        /// <param name="paddingBottom"></param>
        /// <param name="paddingLeft"></param>
        /// <param name="paddingRight"></param>
        /// <param name="paddingTop"></param>
        /// <param name="preserveMetadata">
        /// Default Value: never
        /// </param>
        /// <param name="referenceBox">
        /// Default Value: subjectBox
        /// </param>
        /// <param name="removeBackground">
        /// Default Value: true
        /// </param>
        /// <param name="scaling">
        /// Default Value: fit
        /// </param>
        /// <param name="segmentationMode"></param>
        /// <param name="segmentationNegativePrompt"></param>
        /// <param name="segmentationPrompt"></param>
        /// <param name="shadowMode"></param>
        /// <param name="templateId"></param>
        /// <param name="textRemovalMode"></param>
        /// <param name="uncropMode"></param>
        /// <param name="uncropSeed"></param>
        /// <param name="upscaleMode"></param>
        /// <param name="verticalAlignment"></param>
        /// <param name="virtualModelAdditionalProductImages">
        /// URLs of additional product images showing different angles or details.
        /// </param>
        /// <param name="virtualModelMode"></param>
        /// <param name="virtualModelModel">
        /// Default Value: {"preset":{"name":"avery"}}
        /// </param>
        /// <param name="virtualModelPose">
        /// Default Value: random
        /// </param>
        /// <param name="virtualModelPrompt"></param>
        /// <param name="virtualModelQuality">
        /// Default Value: standard
        /// </param>
        /// <param name="virtualModelScene">
        /// Default Value: {"preset":{"name":"random"}}
        /// </param>
        /// <param name="virtualModelSize">
        /// Default Value: PORTRAIT_HD_3_2
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<byte[]> EditImageGetAsync(
            global::G.EditImageGetBackgroundBlurMode? backgroundBlurMode = default,
            double? backgroundBlurRadius = default,
            string? backgroundColor = default,
            global::G.AnyOf<string, string, global::G.EditImageGetBackgroundExpandPrompt2>? backgroundExpandPrompt = default,
            byte[]? backgroundGuidanceImageFile = default,
            string? backgroundGuidanceImageUrl = default,
            double? backgroundGuidanceScale = default,
            string? backgroundImageUrl = default,
            string? backgroundNegativePrompt = default,
            string? backgroundPrompt = default,
            global::G.EditImageGetBackgroundScaling? backgroundScaling = default,
            double? backgroundSeed = default,
            global::G.EditImageGetBeautifyMode? beautifyMode = default,
            double? beautifySeed = default,
            string? describeAnyChangeMode = default,
            string? describeAnyChangePrompt = default,
            double? describeAnyChangeSeed = default,
            string? editWithAIMode = default,
            string? editWithAIPrompt = default,
            double? editWithAISeed = default,
            string? expandMode = default,
            double? expandSeed = default,
            double? exportDpi = default,
            global::G.EditImageGetExportFormat? exportFormat = default,
            string? flatLayMode = default,
            string? flatLayPrompt = default,
            global::G.EditImageGetFlatLaySize? flatLaySize = default,
            string? ghostMannequinMode = default,
            string? ghostMannequinPrompt = default,
            global::G.EditImageGetGhostMannequinSize? ghostMannequinSize = default,
            global::G.EditImageGetHorizontalAlignment? horizontalAlignment = default,
            bool? ignorePaddingAndSnapOnCroppedSides = default,
            string? imageFromPromptPrompt = default,
            double? imageFromPromptSeed = default,
            global::G.EditImageGetImageFromPromptSize? imageFromPromptSize = default,
            string? imageUrl = default,
            global::G.EditImageGetKeepExistingAlphaChannel? keepExistingAlphaChannel = default,
            object? layers = default,
            global::G.EditImageGetLightingMode? lightingMode = default,
            string? margin = default,
            string? marginBottom = default,
            string? marginLeft = default,
            string? marginRight = default,
            string? marginTop = default,
            double? maxHeight = default,
            double? maxWidth = default,
            double? outlineBlurRadius = default,
            string? outlineColor = default,
            double? outlineWidth = default,
            string? outputSize = default,
            string? padding = default,
            string? paddingBottom = default,
            string? paddingLeft = default,
            string? paddingRight = default,
            string? paddingTop = default,
            global::G.EditImageGetPreserveMetadata? preserveMetadata = default,
            global::G.EditImageGetReferenceBox? referenceBox = default,
            bool? removeBackground = default,
            global::G.EditImageGetScaling? scaling = default,
            global::G.EditImageGetSegmentationMode? segmentationMode = default,
            string? segmentationNegativePrompt = default,
            string? segmentationPrompt = default,
            global::G.EditImageGetShadowMode? shadowMode = default,
            global::System.Guid? templateId = default,
            global::G.EditImageGetTextRemovalMode? textRemovalMode = default,
            string? uncropMode = default,
            double? uncropSeed = default,
            global::G.EditImageGetUpscaleMode? upscaleMode = default,
            global::G.EditImageGetVerticalAlignment? verticalAlignment = default,
            global::System.Collections.Generic.IList<string>? virtualModelAdditionalProductImages = default,
            string? virtualModelMode = default,
            global::G.AnyOf<global::G.EditImageGetVirtualModelModelVariant1, global::G.EditImageGetVirtualModelModelVariant2>? virtualModelModel = default,
            global::G.EditImageGetVirtualModelPose? virtualModelPose = default,
            string? virtualModelPrompt = default,
            global::G.EditImageGetVirtualModelQuality? virtualModelQuality = default,
            global::G.AnyOf<global::G.EditImageGetVirtualModelSceneVariant1, global::G.EditImageGetVirtualModelSceneVariant2>? virtualModelScene = default,
            global::G.EditImageGetVirtualModelSize? virtualModelSize = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareEditImageGetArguments(
                httpClient: HttpClient,
                backgroundBlurMode: ref backgroundBlurMode,
                backgroundBlurRadius: ref backgroundBlurRadius,
                backgroundColor: ref backgroundColor,
                backgroundExpandPrompt: ref backgroundExpandPrompt,
                backgroundGuidanceImageFile: backgroundGuidanceImageFile,
                backgroundGuidanceImageUrl: ref backgroundGuidanceImageUrl,
                backgroundGuidanceScale: ref backgroundGuidanceScale,
                backgroundImageUrl: ref backgroundImageUrl,
                backgroundNegativePrompt: ref backgroundNegativePrompt,
                backgroundPrompt: ref backgroundPrompt,
                backgroundScaling: ref backgroundScaling,
                backgroundSeed: ref backgroundSeed,
                beautifyMode: ref beautifyMode,
                beautifySeed: ref beautifySeed,
                describeAnyChangeMode: ref describeAnyChangeMode,
                describeAnyChangePrompt: ref describeAnyChangePrompt,
                describeAnyChangeSeed: ref describeAnyChangeSeed,
                editWithAIMode: ref editWithAIMode,
                editWithAIPrompt: ref editWithAIPrompt,
                editWithAISeed: ref editWithAISeed,
                expandMode: ref expandMode,
                expandSeed: ref expandSeed,
                exportDpi: ref exportDpi,
                exportFormat: ref exportFormat,
                flatLayMode: ref flatLayMode,
                flatLayPrompt: ref flatLayPrompt,
                flatLaySize: ref flatLaySize,
                ghostMannequinMode: ref ghostMannequinMode,
                ghostMannequinPrompt: ref ghostMannequinPrompt,
                ghostMannequinSize: ref ghostMannequinSize,
                horizontalAlignment: ref horizontalAlignment,
                ignorePaddingAndSnapOnCroppedSides: ref ignorePaddingAndSnapOnCroppedSides,
                imageFromPromptPrompt: ref imageFromPromptPrompt,
                imageFromPromptSeed: ref imageFromPromptSeed,
                imageFromPromptSize: ref imageFromPromptSize,
                imageUrl: ref imageUrl,
                keepExistingAlphaChannel: ref keepExistingAlphaChannel,
                layers: layers,
                lightingMode: ref lightingMode,
                margin: ref margin,
                marginBottom: ref marginBottom,
                marginLeft: ref marginLeft,
                marginRight: ref marginRight,
                marginTop: ref marginTop,
                maxHeight: ref maxHeight,
                maxWidth: ref maxWidth,
                outlineBlurRadius: ref outlineBlurRadius,
                outlineColor: ref outlineColor,
                outlineWidth: ref outlineWidth,
                outputSize: ref outputSize,
                padding: ref padding,
                paddingBottom: ref paddingBottom,
                paddingLeft: ref paddingLeft,
                paddingRight: ref paddingRight,
                paddingTop: ref paddingTop,
                preserveMetadata: ref preserveMetadata,
                referenceBox: ref referenceBox,
                removeBackground: ref removeBackground,
                scaling: ref scaling,
                segmentationMode: ref segmentationMode,
                segmentationNegativePrompt: ref segmentationNegativePrompt,
                segmentationPrompt: ref segmentationPrompt,
                shadowMode: ref shadowMode,
                templateId: ref templateId,
                textRemovalMode: ref textRemovalMode,
                uncropMode: ref uncropMode,
                uncropSeed: ref uncropSeed,
                upscaleMode: ref upscaleMode,
                verticalAlignment: ref verticalAlignment,
                virtualModelAdditionalProductImages: virtualModelAdditionalProductImages,
                virtualModelMode: ref virtualModelMode,
                virtualModelModel: ref virtualModelModel,
                virtualModelPose: ref virtualModelPose,
                virtualModelPrompt: ref virtualModelPrompt,
                virtualModelQuality: ref virtualModelQuality,
                virtualModelScene: ref virtualModelScene,
                virtualModelSize: ref virtualModelSize);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v2/edit",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("background.blur.mode", backgroundBlurMode?.ToValueString())
                .AddOptionalParameter("background.blur.radius", backgroundBlurRadius?.ToString())
                .AddOptionalParameter("background.color", backgroundColor)
                .AddOptionalParameter("background.expandPrompt", backgroundExpandPrompt?.ToString())
                .AddOptionalParameter("background.guidance.imageFile", backgroundGuidanceImageFile?.ToString())
                .AddOptionalParameter("background.guidance.imageUrl", backgroundGuidanceImageUrl)
                .AddOptionalParameter("background.guidance.scale", backgroundGuidanceScale?.ToString())
                .AddOptionalParameter("background.imageUrl", backgroundImageUrl)
                .AddOptionalParameter("background.negativePrompt", backgroundNegativePrompt)
                .AddOptionalParameter("background.prompt", backgroundPrompt)
                .AddOptionalParameter("background.scaling", backgroundScaling?.ToValueString())
                .AddOptionalParameter("background.seed", backgroundSeed?.ToString())
                .AddOptionalParameter("beautify.mode", beautifyMode?.ToValueString())
                .AddOptionalParameter("beautify.seed", beautifySeed?.ToString())
                .AddOptionalParameter("describeAnyChange.mode", describeAnyChangeMode)
                .AddOptionalParameter("describeAnyChange.prompt", describeAnyChangePrompt)
                .AddOptionalParameter("describeAnyChange.seed", describeAnyChangeSeed?.ToString())
                .AddOptionalParameter("editWithAI.mode", editWithAIMode)
                .AddOptionalParameter("editWithAI.prompt", editWithAIPrompt)
                .AddOptionalParameter("editWithAI.seed", editWithAISeed?.ToString())
                .AddOptionalParameter("expand.mode", expandMode)
                .AddOptionalParameter("expand.seed", expandSeed?.ToString())
                .AddOptionalParameter("export.dpi", exportDpi?.ToString())
                .AddOptionalParameter("export.format", exportFormat?.ToValueString())
                .AddOptionalParameter("flatLay.mode", flatLayMode)
                .AddOptionalParameter("flatLay.prompt", flatLayPrompt)
                .AddOptionalParameter("flatLay.size", flatLaySize?.ToValueString())
                .AddOptionalParameter("ghostMannequin.mode", ghostMannequinMode)
                .AddOptionalParameter("ghostMannequin.prompt", ghostMannequinPrompt)
                .AddOptionalParameter("ghostMannequin.size", ghostMannequinSize?.ToValueString())
                .AddOptionalParameter("horizontalAlignment", horizontalAlignment?.ToValueString())
                .AddOptionalParameter("ignorePaddingAndSnapOnCroppedSides", ignorePaddingAndSnapOnCroppedSides?.ToString().ToLowerInvariant())
                .AddOptionalParameter("imageFromPrompt.prompt", imageFromPromptPrompt)
                .AddOptionalParameter("imageFromPrompt.seed", imageFromPromptSeed?.ToString())
                .AddOptionalParameter("imageFromPrompt.size", imageFromPromptSize?.ToValueString())
                .AddOptionalParameter("imageUrl", imageUrl)
                .AddOptionalParameter("keepExistingAlphaChannel", keepExistingAlphaChannel?.ToValueString())
                .AddOptionalParameter("layers", layers?.ToString())
                .AddOptionalParameter("lighting.mode", lightingMode?.ToValueString())
                .AddOptionalParameter("margin", margin)
                .AddOptionalParameter("marginBottom", marginBottom)
                .AddOptionalParameter("marginLeft", marginLeft)
                .AddOptionalParameter("marginRight", marginRight)
                .AddOptionalParameter("marginTop", marginTop)
                .AddOptionalParameter("maxHeight", maxHeight?.ToString())
                .AddOptionalParameter("maxWidth", maxWidth?.ToString())
                .AddOptionalParameter("outline.blurRadius", outlineBlurRadius?.ToString())
                .AddOptionalParameter("outline.color", outlineColor)
                .AddOptionalParameter("outline.width", outlineWidth?.ToString())
                .AddOptionalParameter("outputSize", outputSize)
                .AddOptionalParameter("padding", padding)
                .AddOptionalParameter("paddingBottom", paddingBottom)
                .AddOptionalParameter("paddingLeft", paddingLeft)
                .AddOptionalParameter("paddingRight", paddingRight)
                .AddOptionalParameter("paddingTop", paddingTop)
                .AddOptionalParameter("preserveMetadata", preserveMetadata?.ToValueString())
                .AddOptionalParameter("referenceBox", referenceBox?.ToValueString())
                .AddOptionalParameter("removeBackground", removeBackground?.ToString().ToLowerInvariant())
                .AddOptionalParameter("scaling", scaling?.ToValueString())
                .AddOptionalParameter("segmentation.mode", segmentationMode?.ToValueString())
                .AddOptionalParameter("segmentation.negativePrompt", segmentationNegativePrompt)
                .AddOptionalParameter("segmentation.prompt", segmentationPrompt)
                .AddOptionalParameter("shadow.mode", shadowMode?.ToValueString())
                .AddOptionalParameter("templateId", templateId?.ToString())
                .AddOptionalParameter("textRemoval.mode", textRemovalMode?.ToValueString())
                .AddOptionalParameter("uncrop.mode", uncropMode)
                .AddOptionalParameter("uncrop.seed", uncropSeed?.ToString())
                .AddOptionalParameter("upscale.mode", upscaleMode?.ToValueString())
                .AddOptionalParameter("verticalAlignment", verticalAlignment?.ToValueString())
                .AddOptionalParameter("virtualModel.additionalProductImages", virtualModelAdditionalProductImages, delimiter: ",", explode: true)
                .AddOptionalParameter("virtualModel.mode", virtualModelMode)
                .AddOptionalParameter("virtualModel.model", virtualModelModel?.ToString())
                .AddOptionalParameter("virtualModel.pose", virtualModelPose?.ToValueString())
                .AddOptionalParameter("virtualModel.prompt", virtualModelPrompt)
                .AddOptionalParameter("virtualModel.quality", virtualModelQuality?.ToValueString())
                .AddOptionalParameter("virtualModel.scene", virtualModelScene?.ToString())
                .AddOptionalParameter("virtualModel.size", virtualModelSize?.ToValueString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareEditImageGetRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                backgroundBlurMode: backgroundBlurMode,
                backgroundBlurRadius: backgroundBlurRadius,
                backgroundColor: backgroundColor,
                backgroundExpandPrompt: backgroundExpandPrompt,
                backgroundGuidanceImageFile: backgroundGuidanceImageFile,
                backgroundGuidanceImageUrl: backgroundGuidanceImageUrl,
                backgroundGuidanceScale: backgroundGuidanceScale,
                backgroundImageUrl: backgroundImageUrl,
                backgroundNegativePrompt: backgroundNegativePrompt,
                backgroundPrompt: backgroundPrompt,
                backgroundScaling: backgroundScaling,
                backgroundSeed: backgroundSeed,
                beautifyMode: beautifyMode,
                beautifySeed: beautifySeed,
                describeAnyChangeMode: describeAnyChangeMode,
                describeAnyChangePrompt: describeAnyChangePrompt,
                describeAnyChangeSeed: describeAnyChangeSeed,
                editWithAIMode: editWithAIMode,
                editWithAIPrompt: editWithAIPrompt,
                editWithAISeed: editWithAISeed,
                expandMode: expandMode,
                expandSeed: expandSeed,
                exportDpi: exportDpi,
                exportFormat: exportFormat,
                flatLayMode: flatLayMode,
                flatLayPrompt: flatLayPrompt,
                flatLaySize: flatLaySize,
                ghostMannequinMode: ghostMannequinMode,
                ghostMannequinPrompt: ghostMannequinPrompt,
                ghostMannequinSize: ghostMannequinSize,
                horizontalAlignment: horizontalAlignment,
                ignorePaddingAndSnapOnCroppedSides: ignorePaddingAndSnapOnCroppedSides,
                imageFromPromptPrompt: imageFromPromptPrompt,
                imageFromPromptSeed: imageFromPromptSeed,
                imageFromPromptSize: imageFromPromptSize,
                imageUrl: imageUrl,
                keepExistingAlphaChannel: keepExistingAlphaChannel,
                layers: layers,
                lightingMode: lightingMode,
                margin: margin,
                marginBottom: marginBottom,
                marginLeft: marginLeft,
                marginRight: marginRight,
                marginTop: marginTop,
                maxHeight: maxHeight,
                maxWidth: maxWidth,
                outlineBlurRadius: outlineBlurRadius,
                outlineColor: outlineColor,
                outlineWidth: outlineWidth,
                outputSize: outputSize,
                padding: padding,
                paddingBottom: paddingBottom,
                paddingLeft: paddingLeft,
                paddingRight: paddingRight,
                paddingTop: paddingTop,
                preserveMetadata: preserveMetadata,
                referenceBox: referenceBox,
                removeBackground: removeBackground,
                scaling: scaling,
                segmentationMode: segmentationMode,
                segmentationNegativePrompt: segmentationNegativePrompt,
                segmentationPrompt: segmentationPrompt,
                shadowMode: shadowMode,
                templateId: templateId,
                textRemovalMode: textRemovalMode,
                uncropMode: uncropMode,
                uncropSeed: uncropSeed,
                upscaleMode: upscaleMode,
                verticalAlignment: verticalAlignment,
                virtualModelAdditionalProductImages: virtualModelAdditionalProductImages,
                virtualModelMode: virtualModelMode,
                virtualModelModel: virtualModelModel,
                virtualModelPose: virtualModelPose,
                virtualModelPrompt: virtualModelPrompt,
                virtualModelQuality: virtualModelQuality,
                virtualModelScene: virtualModelScene,
                virtualModelSize: virtualModelSize);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessEditImageGetResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Bad Request
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::G.EditImageBadRequest? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::G.EditImageBadRequest.FromJson(__content_400, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::G.EditImageBadRequest.FromJson(__content_400, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::G.ApiException<global::G.EditImageBadRequest>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Payment Required
            if ((int)__response.StatusCode == 402)
            {
                string? __content_402 = null;
                global::System.Exception? __exception_402 = null;
                global::G.PaymentError? __value_402 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_402 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_402 = global::G.PaymentError.FromJson(__content_402, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_402 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_402 = global::G.PaymentError.FromJson(__content_402, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_402 = __ex;
                }

                throw new global::G.ApiException<global::G.PaymentError>(
                    message: __content_402 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_402,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_402,
                    ResponseObject = __value_402,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Internal Server Error
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::System.Exception? __exception_500 = null;
                global::G.UnknownError? __value_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_500 = global::G.UnknownError.FromJson(__content_500, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_500 = global::G.UnknownError.FromJson(__content_500, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_500 = __ex;
                }

                throw new global::G.ApiException<global::G.UnknownError>(
                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_500,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
                    ResponseObject = __value_500,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsByteArrayAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessEditImageGetResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return __content;
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::G.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    var __content = await __response.Content.ReadAsByteArrayAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return __content;
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::G.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
    }
}