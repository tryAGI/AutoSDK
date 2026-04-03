//HintName: G.ConvertClient.ProcessFileV1ConvertFilePost.g.cs

#nullable enable

namespace G
{
    public partial class ConvertClient
    {
        partial void PrepareProcessFileV1ConvertFilePostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.BodyProcessFileV1ConvertFilePost request);
        partial void PrepareProcessFileV1ConvertFilePostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.BodyProcessFileV1ConvertFilePost request);
        partial void ProcessProcessFileV1ConvertFilePostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessProcessFileV1ConvertFilePostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Process File
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.ConvertDocumentResponse, global::G.PresignedUrlConvertDocumentResponse>> ProcessFileV1ConvertFilePostAsync(

            global::G.BodyProcessFileV1ConvertFilePost request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareProcessFileV1ConvertFilePostArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/convert/file",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.Files, x => x))}]"),
                name: "\"files\"");
            if (request.TargetType != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.TargetType?.ToValueString()}"),
                    name: "\"target_type\"");
            } 
            if (request.FromFormats != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.FromFormats, x => x.ToValueString()))}]"),
                    name: "\"from_formats\"");
            } 
            if (request.ToFormats != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.ToFormats, x => x.ToValueString()))}]"),
                    name: "\"to_formats\"");
            } 
            if (request.ImageExportMode != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ImageExportMode?.ToValueString()}"),
                    name: "\"image_export_mode\"");
            } 
            if (request.DoOcr != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.DoOcr}"),
                    name: "\"do_ocr\"");
            } 
            if (request.ForceOcr != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ForceOcr}"),
                    name: "\"force_ocr\"");
            } 
            if (request.OcrEngine != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.OcrEngine?.ToValueString()}"),
                    name: "\"ocr_engine\"");
            } 
            if (request.OcrLang != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.OcrLang}"),
                    name: "\"ocr_lang\"");
            } 
            if (request.PdfBackend != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.PdfBackend?.ToValueString()}"),
                    name: "\"pdf_backend\"");
            } 
            if (request.TableMode != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.TableMode?.ToValueString()}"),
                    name: "\"table_mode\"");
            } 
            if (request.TableCellMatching != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.TableCellMatching}"),
                    name: "\"table_cell_matching\"");
            } 
            if (request.Pipeline != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Pipeline?.ToValueString()}"),
                    name: "\"pipeline\"");
            } 
            if (request.PageRange != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.PageRange}"),
                    name: "\"page_range\"");
            } 
            if (request.DocumentTimeout != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.DocumentTimeout}"),
                    name: "\"document_timeout\"");
            } 
            if (request.AbortOnError != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.AbortOnError}"),
                    name: "\"abort_on_error\"");
            } 
            if (request.DoTableStructure != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.DoTableStructure}"),
                    name: "\"do_table_structure\"");
            } 
            if (request.IncludeImages != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.IncludeImages}"),
                    name: "\"include_images\"");
            } 
            if (request.ImagesScale != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ImagesScale}"),
                    name: "\"images_scale\"");
            } 
            if (request.MdPageBreakPlaceholder != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.MdPageBreakPlaceholder}"),
                    name: "\"md_page_break_placeholder\"");
            } 
            if (request.DoCodeEnrichment != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.DoCodeEnrichment}"),
                    name: "\"do_code_enrichment\"");
            } 
            if (request.DoFormulaEnrichment != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.DoFormulaEnrichment}"),
                    name: "\"do_formula_enrichment\"");
            } 
            if (request.DoPictureClassification != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.DoPictureClassification}"),
                    name: "\"do_picture_classification\"");
            } 
            if (request.DoChartExtraction != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.DoChartExtraction}"),
                    name: "\"do_chart_extraction\"");
            } 
            if (request.DoPictureDescription != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.DoPictureDescription}"),
                    name: "\"do_picture_description\"");
            } 
            if (request.PictureDescriptionAreaThreshold != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.PictureDescriptionAreaThreshold}"),
                    name: "\"picture_description_area_threshold\"");
            } 
            if (request.PictureDescriptionLocal != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.PictureDescriptionLocal}"),
                    name: "\"picture_description_local\"");
            } 
            if (request.PictureDescriptionApi != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.PictureDescriptionApi}"),
                    name: "\"picture_description_api\"");
            } 
            if (request.VlmPipelineModel != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.VlmPipelineModel}"),
                    name: "\"vlm_pipeline_model\"");
            } 
            if (request.VlmPipelineModelLocal != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.VlmPipelineModelLocal}"),
                    name: "\"vlm_pipeline_model_local\"");
            } 
            if (request.VlmPipelineModelApi != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.VlmPipelineModelApi}"),
                    name: "\"vlm_pipeline_model_api\"");
            } 
            if (request.VlmPipelinePreset != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.VlmPipelinePreset}"),
                    name: "\"vlm_pipeline_preset\"");
            } 
            if (request.PictureDescriptionPreset != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.PictureDescriptionPreset}"),
                    name: "\"picture_description_preset\"");
            } 
            if (request.CodeFormulaPreset != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.CodeFormulaPreset}"),
                    name: "\"code_formula_preset\"");
            } 
            if (request.VlmPipelineCustomConfig != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.VlmPipelineCustomConfig}"),
                    name: "\"vlm_pipeline_custom_config\"");
            } 
            if (request.PictureDescriptionCustomConfig != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.PictureDescriptionCustomConfig}"),
                    name: "\"picture_description_custom_config\"");
            } 
            if (request.CodeFormulaCustomConfig != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.CodeFormulaCustomConfig}"),
                    name: "\"code_formula_custom_config\"");
            } 
            if (request.TableStructureCustomConfig != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.TableStructureCustomConfig}"),
                    name: "\"table_structure_custom_config\"");
            } 
            if (request.LayoutCustomConfig != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.LayoutCustomConfig}"),
                    name: "\"layout_custom_config\"");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareProcessFileV1ConvertFilePostRequest(
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
            ProcessProcessFileV1ConvertFilePostResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::G.HTTPValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_422 = __ex;
                }

                throw new global::G.ApiException<global::G.HTTPValidationError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_422,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessProcessFileV1ConvertFilePostResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.AnyOf<global::G.ConvertDocumentResponse, global::G.PresignedUrlConvertDocumentResponse>.FromJson(__content, JsonSerializerOptions) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
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
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::G.AnyOf<global::G.ConvertDocumentResponse, global::G.PresignedUrlConvertDocumentResponse>.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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
        /// Process File
        /// </summary>
        /// <param name="files"></param>
        /// <param name="targetType">
        /// Default Value: inbody
        /// </param>
        /// <param name="fromFormats">
        /// Input format(s) to convert from. String or list of strings. Allowed values: docx, pptx, html, image, pdf, asciidoc, md, csv, xlsx, xml_uspto, xml_jats, xml_xbrl, mets_gbs, json_docling, audio, vtt, latex. Optional, defaults to all formats.<br/>
        /// Default Value: [docx, pptx, html, image, pdf, asciidoc, md, csv, xlsx, xml_uspto, xml_jats, xml_xbrl, mets_gbs, json_docling, audio, vtt, latex]
        /// </param>
        /// <param name="toFormats">
        /// Output format(s) to convert to. String or list of strings. Allowed values: md, json, yaml, html, html_split_page, text, doctags, vtt. Optional, defaults to Markdown.<br/>
        /// Default Value: [md]
        /// </param>
        /// <param name="imageExportMode">
        /// Image export mode for the document (in case of JSON, Markdown or HTML). Allowed values: placeholder, embedded, referenced. Optional, defaults to Embedded.<br/>
        /// Default Value: embedded
        /// </param>
        /// <param name="doOcr">
        /// If enabled, the bitmap content will be processed using OCR. Boolean. Optional, defaults to true<br/>
        /// Default Value: true
        /// </param>
        /// <param name="forceOcr">
        /// If enabled, replace existing text with OCR-generated text over content. Boolean. Optional, defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="ocrEngine">
        /// The OCR engine to use. String. Allowed values: auto, easyocr, ocrmac, rapidocr, tesserocr, tesseract. Optional, defaults to easyocr.<br/>
        /// Default Value: easyocr
        /// </param>
        /// <param name="ocrLang">
        /// List of languages used by the OCR engine. Note that each OCR engine has different values for the language names. String or list of strings. Optional, defaults to empty.
        /// </param>
        /// <param name="pdfBackend">
        /// The PDF backend to use. String. Allowed values: pypdfium2, docling_parse, dlparse_v1, dlparse_v2, dlparse_v4. Optional, defaults to docling_parse.<br/>
        /// Default Value: docling_parse
        /// </param>
        /// <param name="tableMode">
        /// Mode to use for table structure, String. Allowed values: fast, accurate. Optional, defaults to accurate.<br/>
        /// Default Value: accurate
        /// </param>
        /// <param name="tableCellMatching">
        /// If true, matches table cells predictions back to PDF cells. Can break table output if PDF cells are merged across table columns. If false, let table structure model define the text cells, ignore PDF cells.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="pipeline">
        /// Choose the pipeline to process PDF or image files.<br/>
        /// Default Value: standard
        /// </param>
        /// <param name="pageRange">
        /// Only convert a range of pages. The page number starts at 1.<br/>
        /// Default Value: [1, 9223372036854775807L]
        /// </param>
        /// <param name="documentTimeout">
        /// The timeout for processing each document, in seconds.<br/>
        /// Default Value: 604800F
        /// </param>
        /// <param name="abortOnError">
        /// Abort on error if enabled. Boolean. Optional, defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="doTableStructure">
        /// If enabled, the table structure will be extracted. Boolean. Optional, defaults to true.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="includeImages">
        /// If enabled, images will be extracted from the document. Boolean. Optional, defaults to true.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="imagesScale">
        /// Scale factor for images. Float. Optional, defaults to 2.0.<br/>
        /// Default Value: 2F
        /// </param>
        /// <param name="mdPageBreakPlaceholder">
        /// Add this placeholder between pages in the markdown output.
        /// </param>
        /// <param name="doCodeEnrichment">
        /// If enabled, perform OCR code enrichment. Boolean. Optional, defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="doFormulaEnrichment">
        /// If enabled, perform formula OCR, return LaTeX code. Boolean. Optional, defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="doPictureClassification">
        /// If enabled, classify pictures in documents. Boolean. Optional, defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="doChartExtraction">
        /// If enabled, extract numeric data from charts. Boolean. Optional, defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="doPictureDescription">
        /// If enabled, describe pictures in documents. Boolean. Optional, defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="pictureDescriptionAreaThreshold">
        /// Minimum percentage of the area for a picture to be processed with the models.<br/>
        /// Default Value: 0.05F
        /// </param>
        /// <param name="pictureDescriptionLocal">
        /// DEPRECATED: Options for running a local vision-language model in the picture description. The parameters refer to a model hosted on Hugging Face. This parameter is mutually exclusive with picture_description_api. Please migrate to picture_description_preset or picture_description_custom_config.
        /// </param>
        /// <param name="pictureDescriptionApi">
        /// DEPRECATED: API details for using a vision-language model in the picture description. This parameter is mutually exclusive with picture_description_local. Please migrate to picture_description_preset or picture_description_custom_config.
        /// </param>
        /// <param name="vlmPipelineModel">
        /// DEPRECATED: Preset of local and API models for the vlm pipeline. This parameter is mutually exclusive with vlm_pipeline_model_local and vlm_pipeline_model_api. Use the other options for more parameters. Please migrate to vlm_pipeline_preset or vlm_pipeline_custom_config.
        /// </param>
        /// <param name="vlmPipelineModelLocal">
        /// DEPRECATED: Options for running a local vision-language model for the vlm pipeline. The parameters refer to a model hosted on Hugging Face. This parameter is mutually exclusive with vlm_pipeline_model_api and vlm_pipeline_model. Please migrate to vlm_pipeline_preset or vlm_pipeline_custom_config.
        /// </param>
        /// <param name="vlmPipelineModelApi">
        /// DEPRECATED: API details for using a vision-language model for the vlm pipeline. This parameter is mutually exclusive with vlm_pipeline_model_local and vlm_pipeline_model. Please migrate to vlm_pipeline_preset or vlm_pipeline_custom_config.
        /// </param>
        /// <param name="vlmPipelinePreset">
        /// Preset ID to use (e.g., "default", "granite_docling"). Use "default" for stable, admin-controlled configuration.
        /// </param>
        /// <param name="pictureDescriptionPreset">
        /// Preset ID for picture description.
        /// </param>
        /// <param name="codeFormulaPreset">
        /// Preset ID for code/formula extraction.
        /// </param>
        /// <param name="vlmPipelineCustomConfig">
        /// Custom VLM configuration including model spec and engine options. Only available if admin allows it. Must include 'model_spec' and 'engine_options'.
        /// </param>
        /// <param name="pictureDescriptionCustomConfig">
        /// Custom picture description configuration including model spec and engine options.
        /// </param>
        /// <param name="codeFormulaCustomConfig">
        /// Custom code/formula extraction configuration including model spec and engine options.
        /// </param>
        /// <param name="tableStructureCustomConfig">
        /// Custom configuration for table structure model. Use this to specify a non-default kind with its options. The 'kind' field in the config dict determines which table structure implementation to use. If not specified, uses the default kind with preset configuration.
        /// </param>
        /// <param name="layoutCustomConfig">
        /// Custom configuration for layout model. Use this to specify a non-default kind with its options. The 'kind' field in the config dict determines which layout implementation to use. If not specified, uses the default kind with preset configuration.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AnyOf<global::G.ConvertDocumentResponse, global::G.PresignedUrlConvertDocumentResponse>> ProcessFileV1ConvertFilePostAsync(
            global::System.Collections.Generic.IList<string> files,
            global::G.TargetName? targetType = default,
            global::System.Collections.Generic.IList<global::G.InputFormat>? fromFormats = default,
            global::System.Collections.Generic.IList<global::G.OutputFormat>? toFormats = default,
            global::G.ImageRefMode? imageExportMode = default,
            bool? doOcr = default,
            bool? forceOcr = default,
            global::G.OcrEnginesEnum? ocrEngine = default,
            global::System.Collections.Generic.IList<string>? ocrLang = default,
            global::G.PdfBackend? pdfBackend = default,
            global::G.TableFormerMode? tableMode = default,
            bool? tableCellMatching = default,
            global::G.ProcessingPipeline? pipeline = default,
            byte[]? pageRange = default,
            double? documentTimeout = default,
            bool? abortOnError = default,
            bool? doTableStructure = default,
            bool? includeImages = default,
            double? imagesScale = default,
            string? mdPageBreakPlaceholder = default,
            bool? doCodeEnrichment = default,
            bool? doFormulaEnrichment = default,
            bool? doPictureClassification = default,
            bool? doChartExtraction = default,
            bool? doPictureDescription = default,
            double? pictureDescriptionAreaThreshold = default,
            string? pictureDescriptionLocal = default,
            string? pictureDescriptionApi = default,
            global::G.VlmModelType? vlmPipelineModel = default,
            string? vlmPipelineModelLocal = default,
            string? vlmPipelineModelApi = default,
            string? vlmPipelinePreset = default,
            string? pictureDescriptionPreset = default,
            string? codeFormulaPreset = default,
            string? vlmPipelineCustomConfig = default,
            string? pictureDescriptionCustomConfig = default,
            string? codeFormulaCustomConfig = default,
            object? tableStructureCustomConfig = default,
            object? layoutCustomConfig = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.BodyProcessFileV1ConvertFilePost
            {
                Files = files,
                TargetType = targetType,
                FromFormats = fromFormats,
                ToFormats = toFormats,
                ImageExportMode = imageExportMode,
                DoOcr = doOcr,
                ForceOcr = forceOcr,
                OcrEngine = ocrEngine,
                OcrLang = ocrLang,
                PdfBackend = pdfBackend,
                TableMode = tableMode,
                TableCellMatching = tableCellMatching,
                Pipeline = pipeline,
                PageRange = pageRange,
                DocumentTimeout = documentTimeout,
                AbortOnError = abortOnError,
                DoTableStructure = doTableStructure,
                IncludeImages = includeImages,
                ImagesScale = imagesScale,
                MdPageBreakPlaceholder = mdPageBreakPlaceholder,
                DoCodeEnrichment = doCodeEnrichment,
                DoFormulaEnrichment = doFormulaEnrichment,
                DoPictureClassification = doPictureClassification,
                DoChartExtraction = doChartExtraction,
                DoPictureDescription = doPictureDescription,
                PictureDescriptionAreaThreshold = pictureDescriptionAreaThreshold,
                PictureDescriptionLocal = pictureDescriptionLocal,
                PictureDescriptionApi = pictureDescriptionApi,
                VlmPipelineModel = vlmPipelineModel,
                VlmPipelineModelLocal = vlmPipelineModelLocal,
                VlmPipelineModelApi = vlmPipelineModelApi,
                VlmPipelinePreset = vlmPipelinePreset,
                PictureDescriptionPreset = pictureDescriptionPreset,
                CodeFormulaPreset = codeFormulaPreset,
                VlmPipelineCustomConfig = vlmPipelineCustomConfig,
                PictureDescriptionCustomConfig = pictureDescriptionCustomConfig,
                CodeFormulaCustomConfig = codeFormulaCustomConfig,
                TableStructureCustomConfig = tableStructureCustomConfig,
                LayoutCustomConfig = layoutCustomConfig,
            };

            return await ProcessFileV1ConvertFilePostAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}