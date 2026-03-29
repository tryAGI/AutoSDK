//HintName: G.IApi.EditImageGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
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
        global::System.Threading.Tasks.Task<byte[]> EditImageGetAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}