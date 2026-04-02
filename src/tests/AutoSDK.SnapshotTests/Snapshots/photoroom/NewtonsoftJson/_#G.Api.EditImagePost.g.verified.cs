//HintName: G.Api.EditImagePost.g.cs

#nullable enable

namespace G
{
    public partial class Api
    {
        partial void PrepareEditImagePostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.EditImagePostRequest request);
        partial void PrepareEditImagePostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.EditImagePostRequest request);
        partial void ProcessEditImagePostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessEditImagePostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref byte[] content);

        /// <summary>
        /// Image Editing v2 (Plus plan)<br/>
        /// This endpoint processes an image and applies one or more edits: background removal, AI-generated backgrounds (background.prompt), realistic shadows (shadow.mode), relighting (lighting.mode), text removal (textRemoval.mode), background blur (background.blur.*), subject outline (outline.*), AI beautification (beautify.mode), Flat Lay (flatLay.*), Ghost Mannequin (ghostMannequin.*), Virtual Model (virtualModel.*), AI expand (expand.mode), AI uncrop (uncrop.mode), AI upscale (upscale.mode), and positioning/resizing (padding, margin, outputSize).<br/>
        /// Parameters are grouped by feature using dot notation: background.* for backgrounds, shadow.* for shadows, lighting.* for relighting, outline.* for subject outlines, beautify.* for AI beautification, flatLay.* for flat lay generation, ghostMannequin.* for ghost mannequin generation, virtualModel.* for virtual model generation, expand.* for AI expand, uncrop.* for AI uncrop, upscale.* for AI upscale, export.* for output format, and segmentation.* for text-guided segmentation.<br/>
        /// Edits can be combined in a single call.<br/>
        /// It accepts an image file for the image. If you want to send a URL, please use the GET endpoint. For more details on the difference between the GET and POST endpoints, please have a look at our documentation: https://docs.photoroom.com/image-editing-api/which-endpoints-are-available.<br/>
        /// If you only have a URL for your image (not a local file), use the GET endpoint instead — it is simpler to integrate. Use this POST endpoint when you need to upload image files directly as multipart/form-data.<br/>
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
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<byte[]> EditImagePostAsync(

            global::G.EditImagePostRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await EditImagePostAsResponseAsync(

                request: request,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Image Editing v2 (Plus plan)<br/>
        /// This endpoint processes an image and applies one or more edits: background removal, AI-generated backgrounds (background.prompt), realistic shadows (shadow.mode), relighting (lighting.mode), text removal (textRemoval.mode), background blur (background.blur.*), subject outline (outline.*), AI beautification (beautify.mode), Flat Lay (flatLay.*), Ghost Mannequin (ghostMannequin.*), Virtual Model (virtualModel.*), AI expand (expand.mode), AI uncrop (uncrop.mode), AI upscale (upscale.mode), and positioning/resizing (padding, margin, outputSize).<br/>
        /// Parameters are grouped by feature using dot notation: background.* for backgrounds, shadow.* for shadows, lighting.* for relighting, outline.* for subject outlines, beautify.* for AI beautification, flatLay.* for flat lay generation, ghostMannequin.* for ghost mannequin generation, virtualModel.* for virtual model generation, expand.* for AI expand, uncrop.* for AI uncrop, upscale.* for AI upscale, export.* for output format, and segmentation.* for text-guided segmentation.<br/>
        /// Edits can be combined in a single call.<br/>
        /// It accepts an image file for the image. If you want to send a URL, please use the GET endpoint. For more details on the difference between the GET and POST endpoints, please have a look at our documentation: https://docs.photoroom.com/image-editing-api/which-endpoints-are-available.<br/>
        /// If you only have a URL for your image (not a local file), use the GET endpoint instead — it is simpler to integrate. Use this POST endpoint when you need to upload image files directly as multipart/form-data.<br/>
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
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<byte[]>> EditImagePostAsResponseAsync(

            global::G.EditImagePostRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareEditImagePostArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v2/edit",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            if (request.BackgroundBlurMode != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.BackgroundBlurMode}"),
                    name: "\"background.blur.mode\"");
            } 
            if (request.BackgroundBlurRadius != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.BackgroundBlurRadius}"),
                    name: "\"background.blur.radius\"");
            } 
            if (request.BackgroundColor != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.BackgroundColor}"),
                    name: "\"background.color\"");
            } 
            if (request.BackgroundExpandPrompt != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.BackgroundExpandPrompt}"),
                    name: "\"background.expandPrompt\"");
            } 
            if (request.BackgroundGuidanceImageFile != default)
            {

                var __contentBackgroundGuidanceImageFile = new global::System.Net.Http.ByteArrayContent(request.BackgroundGuidanceImageFile ?? global::System.Array.Empty<byte>());
                __httpRequestContent.Add(
                    content: __contentBackgroundGuidanceImageFile,
                    name: "\"background.guidance.imageFile\"",
                    fileName: request.BackgroundGuidanceImageFilename != null ? $"\"{request.BackgroundGuidanceImageFilename}\"" : string.Empty);
                if (__contentBackgroundGuidanceImageFile.Headers.ContentDisposition != null)
                {
                    __contentBackgroundGuidanceImageFile.Headers.ContentDisposition.FileNameStar = null;
                }
            } 
            if (request.BackgroundGuidanceScale != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.BackgroundGuidanceScale}"),
                    name: "\"background.guidance.scale\"");
            } 
            if (request.BackgroundImageFile != default)
            {

                var __contentBackgroundImageFile = new global::System.Net.Http.ByteArrayContent(request.BackgroundImageFile ?? global::System.Array.Empty<byte>());
                __httpRequestContent.Add(
                    content: __contentBackgroundImageFile,
                    name: "\"background.imageFile\"",
                    fileName: request.BackgroundImageFilename != null ? $"\"{request.BackgroundImageFilename}\"" : string.Empty);
                if (__contentBackgroundImageFile.Headers.ContentDisposition != null)
                {
                    __contentBackgroundImageFile.Headers.ContentDisposition.FileNameStar = null;
                }
            } 
            if (request.BackgroundNegativePrompt != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.BackgroundNegativePrompt}"),
                    name: "\"background.negativePrompt\"");
            } 
            if (request.BackgroundPrompt != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.BackgroundPrompt}"),
                    name: "\"background.prompt\"");
            } 
            if (request.BackgroundScaling != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.BackgroundScaling}"),
                    name: "\"background.scaling\"");
            } 
            if (request.BackgroundSeed != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.BackgroundSeed}"),
                    name: "\"background.seed\"");
            } 
            if (request.BeautifyMode != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.BeautifyMode}"),
                    name: "\"beautify.mode\"");
            } 
            if (request.BeautifySeed != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.BeautifySeed}"),
                    name: "\"beautify.seed\"");
            } 
            if (request.DescribeAnyChangeMode != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.DescribeAnyChangeMode}"),
                    name: "\"describeAnyChange.mode\"");
            } 
            if (request.DescribeAnyChangePrompt != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.DescribeAnyChangePrompt}"),
                    name: "\"describeAnyChange.prompt\"");
            } 
            if (request.DescribeAnyChangeSeed != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.DescribeAnyChangeSeed}"),
                    name: "\"describeAnyChange.seed\"");
            } 
            if (request.EditWithAIMode != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.EditWithAIMode}"),
                    name: "\"editWithAI.mode\"");
            } 
            if (request.EditWithAIPrompt != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.EditWithAIPrompt}"),
                    name: "\"editWithAI.prompt\"");
            } 
            if (request.EditWithAISeed != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.EditWithAISeed}"),
                    name: "\"editWithAI.seed\"");
            } 
            if (request.ExpandMode != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ExpandMode}"),
                    name: "\"expand.mode\"");
            } 
            if (request.ExpandSeed != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ExpandSeed}"),
                    name: "\"expand.seed\"");
            } 
            if (request.ExportDpi != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ExportDpi}"),
                    name: "\"export.dpi\"");
            } 
            if (request.ExportFormat != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ExportFormat}"),
                    name: "\"export.format\"");
            } 
            if (request.FlatLayMode != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.FlatLayMode}"),
                    name: "\"flatLay.mode\"");
            } 
            if (request.FlatLayPrompt != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.FlatLayPrompt}"),
                    name: "\"flatLay.prompt\"");
            } 
            if (request.FlatLaySize != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.FlatLaySize}"),
                    name: "\"flatLay.size\"");
            } 
            if (request.GhostMannequinMode != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.GhostMannequinMode}"),
                    name: "\"ghostMannequin.mode\"");
            } 
            if (request.GhostMannequinPrompt != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.GhostMannequinPrompt}"),
                    name: "\"ghostMannequin.prompt\"");
            } 
            if (request.GhostMannequinSize != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.GhostMannequinSize}"),
                    name: "\"ghostMannequin.size\"");
            } 
            if (request.HorizontalAlignment != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.HorizontalAlignment}"),
                    name: "\"horizontalAlignment\"");
            } 
            if (request.IgnorePaddingAndSnapOnCroppedSides != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.IgnorePaddingAndSnapOnCroppedSides}"),
                    name: "\"ignorePaddingAndSnapOnCroppedSides\"");
            } 
            if (request.ImageFile != default)
            {

                var __contentImageFile = new global::System.Net.Http.ByteArrayContent(request.ImageFile ?? global::System.Array.Empty<byte>());
                __httpRequestContent.Add(
                    content: __contentImageFile,
                    name: "\"imageFile\"",
                    fileName: request.ImageFilename != null ? $"\"{request.ImageFilename}\"" : string.Empty);
                if (__contentImageFile.Headers.ContentDisposition != null)
                {
                    __contentImageFile.Headers.ContentDisposition.FileNameStar = null;
                }
            } 
            if (request.ImageFromPromptPrompt != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ImageFromPromptPrompt}"),
                    name: "\"imageFromPrompt.prompt\"");
            } 
            if (request.ImageFromPromptSeed != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ImageFromPromptSeed}"),
                    name: "\"imageFromPrompt.seed\"");
            } 
            if (request.ImageFromPromptSize != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ImageFromPromptSize}"),
                    name: "\"imageFromPrompt.size\"");
            } 
            if (request.KeepExistingAlphaChannel != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.KeepExistingAlphaChannel}"),
                    name: "\"keepExistingAlphaChannel\"");
            } 
            if (request.Layers != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Layers}"),
                    name: "\"layers\"");
            } 
            if (request.LightingMode != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.LightingMode}"),
                    name: "\"lighting.mode\"");
            } 
            if (request.Margin != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Margin}"),
                    name: "\"margin\"");
            } 
            if (request.MarginBottom != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.MarginBottom}"),
                    name: "\"marginBottom\"");
            } 
            if (request.MarginLeft != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.MarginLeft}"),
                    name: "\"marginLeft\"");
            } 
            if (request.MarginRight != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.MarginRight}"),
                    name: "\"marginRight\"");
            } 
            if (request.MarginTop != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.MarginTop}"),
                    name: "\"marginTop\"");
            } 
            if (request.MaxHeight != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.MaxHeight}"),
                    name: "\"maxHeight\"");
            } 
            if (request.MaxWidth != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.MaxWidth}"),
                    name: "\"maxWidth\"");
            } 
            if (request.OutlineBlurRadius != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.OutlineBlurRadius}"),
                    name: "\"outline.blurRadius\"");
            } 
            if (request.OutlineColor != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.OutlineColor}"),
                    name: "\"outline.color\"");
            } 
            if (request.OutlineWidth != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.OutlineWidth}"),
                    name: "\"outline.width\"");
            } 
            if (request.OutputSize != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.OutputSize}"),
                    name: "\"outputSize\"");
            } 
            if (request.Padding != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Padding}"),
                    name: "\"padding\"");
            } 
            if (request.PaddingBottom != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.PaddingBottom}"),
                    name: "\"paddingBottom\"");
            } 
            if (request.PaddingLeft != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.PaddingLeft}"),
                    name: "\"paddingLeft\"");
            } 
            if (request.PaddingRight != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.PaddingRight}"),
                    name: "\"paddingRight\"");
            } 
            if (request.PaddingTop != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.PaddingTop}"),
                    name: "\"paddingTop\"");
            } 
            if (request.PreserveMetadata != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.PreserveMetadata}"),
                    name: "\"preserveMetadata\"");
            } 
            if (request.ReferenceBox != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ReferenceBox}"),
                    name: "\"referenceBox\"");
            } 
            if (request.RemoveBackground != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.RemoveBackground}"),
                    name: "\"removeBackground\"");
            } 
            if (request.Scaling != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Scaling}"),
                    name: "\"scaling\"");
            } 
            if (request.SegmentationMode != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.SegmentationMode}"),
                    name: "\"segmentation.mode\"");
            } 
            if (request.SegmentationNegativePrompt != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.SegmentationNegativePrompt}"),
                    name: "\"segmentation.negativePrompt\"");
            } 
            if (request.SegmentationPrompt != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.SegmentationPrompt}"),
                    name: "\"segmentation.prompt\"");
            } 
            if (request.ShadowMode != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ShadowMode}"),
                    name: "\"shadow.mode\"");
            } 
            if (request.TemplateId != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.TemplateId}"),
                    name: "\"templateId\"");
            } 
            if (request.TextRemovalMode != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.TextRemovalMode}"),
                    name: "\"textRemoval.mode\"");
            } 
            if (request.UncropMode != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.UncropMode}"),
                    name: "\"uncrop.mode\"");
            } 
            if (request.UncropSeed != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.UncropSeed}"),
                    name: "\"uncrop.seed\"");
            } 
            if (request.UpscaleMode != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.UpscaleMode}"),
                    name: "\"upscale.mode\"");
            } 
            if (request.VerticalAlignment != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.VerticalAlignment}"),
                    name: "\"verticalAlignment\"");
            } 
            if (request.VirtualModelAdditionalProductImages != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.VirtualModelAdditionalProductImages}"),
                    name: "\"virtualModel.additionalProductImages\"");
            } 
            if (request.VirtualModelMode != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.VirtualModelMode}"),
                    name: "\"virtualModel.mode\"");
            } 
            if (request.VirtualModelModel != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.VirtualModelModel}"),
                    name: "\"virtualModel.model\"");
            } 
            if (request.VirtualModelPose != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.VirtualModelPose}"),
                    name: "\"virtualModel.pose\"");
            } 
            if (request.VirtualModelPrompt != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.VirtualModelPrompt}"),
                    name: "\"virtualModel.prompt\"");
            } 
            if (request.VirtualModelQuality != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.VirtualModelQuality}"),
                    name: "\"virtualModel.quality\"");
            } 
            if (request.VirtualModelScene != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.VirtualModelScene}"),
                    name: "\"virtualModel.scene\"");
            } 
            if (request.VirtualModelSize != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.VirtualModelSize}"),
                    name: "\"virtualModel.size\"");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareEditImagePostRequest(
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
            ProcessEditImagePostResponse(
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

                ProcessEditImagePostResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return new global::G.AutoSDKHttpResponse<byte[]>(
                        statusCode: __response.StatusCode,
                        headers: global::G.AutoSDKHttpResponse.CreateHeaders(__response),
                        body: __content);
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

                    return new global::G.AutoSDKHttpResponse<byte[]>(
                        statusCode: __response.StatusCode,
                        headers: global::G.AutoSDKHttpResponse.CreateHeaders(__response),
                        body: __content);
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
        /// <summary>
        /// Image Editing v2 (Plus plan)<br/>
        /// This endpoint processes an image and applies one or more edits: background removal, AI-generated backgrounds (background.prompt), realistic shadows (shadow.mode), relighting (lighting.mode), text removal (textRemoval.mode), background blur (background.blur.*), subject outline (outline.*), AI beautification (beautify.mode), Flat Lay (flatLay.*), Ghost Mannequin (ghostMannequin.*), Virtual Model (virtualModel.*), AI expand (expand.mode), AI uncrop (uncrop.mode), AI upscale (upscale.mode), and positioning/resizing (padding, margin, outputSize).<br/>
        /// Parameters are grouped by feature using dot notation: background.* for backgrounds, shadow.* for shadows, lighting.* for relighting, outline.* for subject outlines, beautify.* for AI beautification, flatLay.* for flat lay generation, ghostMannequin.* for ghost mannequin generation, virtualModel.* for virtual model generation, expand.* for AI expand, uncrop.* for AI uncrop, upscale.* for AI upscale, export.* for output format, and segmentation.* for text-guided segmentation.<br/>
        /// Edits can be combined in a single call.<br/>
        /// It accepts an image file for the image. If you want to send a URL, please use the GET endpoint. For more details on the difference between the GET and POST endpoints, please have a look at our documentation: https://docs.photoroom.com/image-editing-api/which-endpoints-are-available.<br/>
        /// If you only have a URL for your image (not a local file), use the GET endpoint instead — it is simpler to integrate. Use this POST endpoint when you need to upload image files directly as multipart/form-data.<br/>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<byte[]> EditImagePostAsync(
            string? backgroundBlurMode = default,
            double? backgroundBlurRadius = default,
            string? backgroundColor = default,
            object? backgroundExpandPrompt = default,
            byte[]? backgroundGuidanceImageFile = default,
            string? backgroundGuidanceImageFilename = default,
            double? backgroundGuidanceScale = default,
            byte[]? backgroundImageFile = default,
            string? backgroundImageFilename = default,
            string? backgroundNegativePrompt = default,
            string? backgroundPrompt = default,
            string? backgroundScaling = default,
            double? backgroundSeed = default,
            string? beautifyMode = default,
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
            string? exportFormat = default,
            string? flatLayMode = default,
            string? flatLayPrompt = default,
            string? flatLaySize = default,
            string? ghostMannequinMode = default,
            string? ghostMannequinPrompt = default,
            string? ghostMannequinSize = default,
            string? horizontalAlignment = default,
            bool? ignorePaddingAndSnapOnCroppedSides = default,
            byte[]? imageFile = default,
            string? imageFilename = default,
            string? imageFromPromptPrompt = default,
            double? imageFromPromptSeed = default,
            string? imageFromPromptSize = default,
            string? keepExistingAlphaChannel = default,
            object? layers = default,
            string? lightingMode = default,
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
            string? preserveMetadata = default,
            string? referenceBox = default,
            bool? removeBackground = default,
            string? scaling = default,
            string? segmentationMode = default,
            string? segmentationNegativePrompt = default,
            string? segmentationPrompt = default,
            string? shadowMode = default,
            global::System.Guid? templateId = default,
            string? textRemovalMode = default,
            string? uncropMode = default,
            double? uncropSeed = default,
            string? upscaleMode = default,
            string? verticalAlignment = default,
            byte[]? virtualModelAdditionalProductImages = default,
            string? virtualModelMode = default,
            object? virtualModelModel = default,
            string? virtualModelPose = default,
            string? virtualModelPrompt = default,
            string? virtualModelQuality = default,
            object? virtualModelScene = default,
            string? virtualModelSize = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.EditImagePostRequest
            {
                BackgroundBlurMode = backgroundBlurMode,
                BackgroundBlurRadius = backgroundBlurRadius,
                BackgroundColor = backgroundColor,
                BackgroundExpandPrompt = backgroundExpandPrompt,
                BackgroundGuidanceImageFile = backgroundGuidanceImageFile,
                BackgroundGuidanceImageFilename = backgroundGuidanceImageFilename,
                BackgroundGuidanceScale = backgroundGuidanceScale,
                BackgroundImageFile = backgroundImageFile,
                BackgroundImageFilename = backgroundImageFilename,
                BackgroundNegativePrompt = backgroundNegativePrompt,
                BackgroundPrompt = backgroundPrompt,
                BackgroundScaling = backgroundScaling,
                BackgroundSeed = backgroundSeed,
                BeautifyMode = beautifyMode,
                BeautifySeed = beautifySeed,
                DescribeAnyChangeMode = describeAnyChangeMode,
                DescribeAnyChangePrompt = describeAnyChangePrompt,
                DescribeAnyChangeSeed = describeAnyChangeSeed,
                EditWithAIMode = editWithAIMode,
                EditWithAIPrompt = editWithAIPrompt,
                EditWithAISeed = editWithAISeed,
                ExpandMode = expandMode,
                ExpandSeed = expandSeed,
                ExportDpi = exportDpi,
                ExportFormat = exportFormat,
                FlatLayMode = flatLayMode,
                FlatLayPrompt = flatLayPrompt,
                FlatLaySize = flatLaySize,
                GhostMannequinMode = ghostMannequinMode,
                GhostMannequinPrompt = ghostMannequinPrompt,
                GhostMannequinSize = ghostMannequinSize,
                HorizontalAlignment = horizontalAlignment,
                IgnorePaddingAndSnapOnCroppedSides = ignorePaddingAndSnapOnCroppedSides,
                ImageFile = imageFile,
                ImageFilename = imageFilename,
                ImageFromPromptPrompt = imageFromPromptPrompt,
                ImageFromPromptSeed = imageFromPromptSeed,
                ImageFromPromptSize = imageFromPromptSize,
                KeepExistingAlphaChannel = keepExistingAlphaChannel,
                Layers = layers,
                LightingMode = lightingMode,
                Margin = margin,
                MarginBottom = marginBottom,
                MarginLeft = marginLeft,
                MarginRight = marginRight,
                MarginTop = marginTop,
                MaxHeight = maxHeight,
                MaxWidth = maxWidth,
                OutlineBlurRadius = outlineBlurRadius,
                OutlineColor = outlineColor,
                OutlineWidth = outlineWidth,
                OutputSize = outputSize,
                Padding = padding,
                PaddingBottom = paddingBottom,
                PaddingLeft = paddingLeft,
                PaddingRight = paddingRight,
                PaddingTop = paddingTop,
                PreserveMetadata = preserveMetadata,
                ReferenceBox = referenceBox,
                RemoveBackground = removeBackground,
                Scaling = scaling,
                SegmentationMode = segmentationMode,
                SegmentationNegativePrompt = segmentationNegativePrompt,
                SegmentationPrompt = segmentationPrompt,
                ShadowMode = shadowMode,
                TemplateId = templateId,
                TextRemovalMode = textRemovalMode,
                UncropMode = uncropMode,
                UncropSeed = uncropSeed,
                UpscaleMode = upscaleMode,
                VerticalAlignment = verticalAlignment,
                VirtualModelAdditionalProductImages = virtualModelAdditionalProductImages,
                VirtualModelMode = virtualModelMode,
                VirtualModelModel = virtualModelModel,
                VirtualModelPose = virtualModelPose,
                VirtualModelPrompt = virtualModelPrompt,
                VirtualModelQuality = virtualModelQuality,
                VirtualModelScene = virtualModelScene,
                VirtualModelSize = virtualModelSize,
            };

            return await EditImagePostAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}