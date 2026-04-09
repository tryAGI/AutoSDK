//HintName: G.ChunkClient.ChunkFilesWithHybridChunkerAsAsyncTaskV1ChunkHybridFileAsyncPost.g.cs

#nullable enable

namespace G
{
    public partial class ChunkClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_ChunkFilesWithHybridChunkerAsAsyncTaskV1ChunkHybridFileAsyncPostSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "",
                        Location = "",
                        Name = "",
                        FriendlyName = "Authorization",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_ChunkFilesWithHybridChunkerAsAsyncTaskV1ChunkHybridFileAsyncPostSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_ChunkFilesWithHybridChunkerAsAsyncTaskV1ChunkHybridFileAsyncPostSecurityRequirement0,
            };
        partial void PrepareChunkFilesWithHybridChunkerAsAsyncTaskV1ChunkHybridFileAsyncPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::G.BodyChunkFilesWithHybridChunkerAsAsyncTaskV1ChunkHybridFileAsyncPost request);
        partial void PrepareChunkFilesWithHybridChunkerAsAsyncTaskV1ChunkHybridFileAsyncPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::G.BodyChunkFilesWithHybridChunkerAsAsyncTaskV1ChunkHybridFileAsyncPost request);
        partial void ProcessChunkFilesWithHybridChunkerAsAsyncTaskV1ChunkHybridFileAsyncPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessChunkFilesWithHybridChunkerAsAsyncTaskV1ChunkHybridFileAsyncPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Chunk Files With Hybridchunker As Async Task
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TaskStatusResponse> ChunkFilesWithHybridChunkerAsAsyncTaskV1ChunkHybridFileAsyncPostAsync(

            global::G.BodyChunkFilesWithHybridChunkerAsAsyncTaskV1ChunkHybridFileAsyncPost request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareChunkFilesWithHybridChunkerAsAsyncTaskV1ChunkHybridFileAsyncPostArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ChunkFilesWithHybridChunkerAsAsyncTaskV1ChunkHybridFileAsyncPostSecurityRequirements,
                operationName: "ChunkFilesWithHybridChunkerAsAsyncTaskV1ChunkHybridFileAsyncPostAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/v1/chunk/hybrid/file/async",
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
            for (var __iFiles = 0; __iFiles < request.Files.Count; __iFiles++)
            {
                var __contentFiles = new global::System.Net.Http.ByteArrayContent(request.Files[__iFiles]);
                __httpRequestContent.Add(
                    content: __contentFiles,
                    name: "\"files\"",
                    fileName: $"\"file{__iFiles}.bin\"");
                if (__contentFiles.Headers.ContentDisposition != null)
                {
                    __contentFiles.Headers.ContentDisposition.FileNameStar = null;
                }
            }
            if (request.IncludeConvertedDoc != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.IncludeConvertedDoc}"),
                    name: "\"include_converted_doc\"");
            } 
            if (request.TargetType != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.TargetType?.ToValueString()}"),
                    name: "\"target_type\"");
            } 
            if (request.ConvertFromFormats != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.ConvertFromFormats, x => x.ToValueString()))}]"),
                    name: "\"convert_from_formats\"");
            } 
            if (request.ConvertImageExportMode != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ConvertImageExportMode?.ToValueString()}"),
                    name: "\"convert_image_export_mode\"");
            } 
            if (request.ConvertDoOcr != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ConvertDoOcr}"),
                    name: "\"convert_do_ocr\"");
            } 
            if (request.ConvertForceOcr != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ConvertForceOcr}"),
                    name: "\"convert_force_ocr\"");
            } 
            if (request.ConvertOcrEngine != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ConvertOcrEngine?.ToValueString()}"),
                    name: "\"convert_ocr_engine\"");
            } 
            if (request.ConvertOcrLang != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ConvertOcrLang}"),
                    name: "\"convert_ocr_lang\"");
            } 
            if (request.ConvertPdfBackend != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ConvertPdfBackend?.ToValueString()}"),
                    name: "\"convert_pdf_backend\"");
            } 
            if (request.ConvertTableMode != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ConvertTableMode?.ToValueString()}"),
                    name: "\"convert_table_mode\"");
            } 
            if (request.ConvertTableCellMatching != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ConvertTableCellMatching}"),
                    name: "\"convert_table_cell_matching\"");
            } 
            if (request.ConvertPipeline != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ConvertPipeline?.ToValueString()}"),
                    name: "\"convert_pipeline\"");
            } 
            if (request.ConvertPageRange != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.ConvertPageRange, x => x))}]"),
                    name: "\"convert_page_range\"");
            } 
            if (request.ConvertDocumentTimeout != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ConvertDocumentTimeout}"),
                    name: "\"convert_document_timeout\"");
            } 
            if (request.ConvertAbortOnError != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ConvertAbortOnError}"),
                    name: "\"convert_abort_on_error\"");
            } 
            if (request.ConvertDoTableStructure != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ConvertDoTableStructure}"),
                    name: "\"convert_do_table_structure\"");
            } 
            if (request.ConvertIncludeImages != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ConvertIncludeImages}"),
                    name: "\"convert_include_images\"");
            } 
            if (request.ConvertImagesScale != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ConvertImagesScale}"),
                    name: "\"convert_images_scale\"");
            } 
            if (request.ConvertMdPageBreakPlaceholder != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ConvertMdPageBreakPlaceholder}"),
                    name: "\"convert_md_page_break_placeholder\"");
            } 
            if (request.ConvertDoCodeEnrichment != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ConvertDoCodeEnrichment}"),
                    name: "\"convert_do_code_enrichment\"");
            } 
            if (request.ConvertDoFormulaEnrichment != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ConvertDoFormulaEnrichment}"),
                    name: "\"convert_do_formula_enrichment\"");
            } 
            if (request.ConvertDoPictureClassification != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ConvertDoPictureClassification}"),
                    name: "\"convert_do_picture_classification\"");
            } 
            if (request.ConvertDoChartExtraction != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ConvertDoChartExtraction}"),
                    name: "\"convert_do_chart_extraction\"");
            } 
            if (request.ConvertDoPictureDescription != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ConvertDoPictureDescription}"),
                    name: "\"convert_do_picture_description\"");
            } 
            if (request.ConvertPictureDescriptionAreaThreshold != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ConvertPictureDescriptionAreaThreshold}"),
                    name: "\"convert_picture_description_area_threshold\"");
            } 
            if (request.ConvertPictureDescriptionLocal != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ConvertPictureDescriptionLocal}"),
                    name: "\"convert_picture_description_local\"");
            } 
            if (request.ConvertPictureDescriptionApi != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ConvertPictureDescriptionApi}"),
                    name: "\"convert_picture_description_api\"");
            } 
            if (request.ConvertVlmPipelineModel != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ConvertVlmPipelineModel}"),
                    name: "\"convert_vlm_pipeline_model\"");
            } 
            if (request.ConvertVlmPipelineModelLocal != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ConvertVlmPipelineModelLocal}"),
                    name: "\"convert_vlm_pipeline_model_local\"");
            } 
            if (request.ConvertVlmPipelineModelApi != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ConvertVlmPipelineModelApi}"),
                    name: "\"convert_vlm_pipeline_model_api\"");
            } 
            if (request.ConvertVlmPipelinePreset != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ConvertVlmPipelinePreset}"),
                    name: "\"convert_vlm_pipeline_preset\"");
            } 
            if (request.ConvertPictureDescriptionPreset != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ConvertPictureDescriptionPreset}"),
                    name: "\"convert_picture_description_preset\"");
            } 
            if (request.ConvertCodeFormulaPreset != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ConvertCodeFormulaPreset}"),
                    name: "\"convert_code_formula_preset\"");
            } 
            if (request.ConvertVlmPipelineCustomConfig != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ConvertVlmPipelineCustomConfig}"),
                    name: "\"convert_vlm_pipeline_custom_config\"");
            } 
            if (request.ConvertPictureDescriptionCustomConfig != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ConvertPictureDescriptionCustomConfig}"),
                    name: "\"convert_picture_description_custom_config\"");
            } 
            if (request.ConvertCodeFormulaCustomConfig != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ConvertCodeFormulaCustomConfig}"),
                    name: "\"convert_code_formula_custom_config\"");
            } 
            if (request.ConvertTableStructureCustomConfig != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ConvertTableStructureCustomConfig}"),
                    name: "\"convert_table_structure_custom_config\"");
            } 
            if (request.ConvertLayoutCustomConfig != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ConvertLayoutCustomConfig}"),
                    name: "\"convert_layout_custom_config\"");
            } 
            if (request.ChunkingUseMarkdownTables != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ChunkingUseMarkdownTables}"),
                    name: "\"chunking_use_markdown_tables\"");
            } 
            if (request.ChunkingIncludeRawText != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ChunkingIncludeRawText}"),
                    name: "\"chunking_include_raw_text\"");
            } 
            if (request.ChunkingMaxTokens != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ChunkingMaxTokens}"),
                    name: "\"chunking_max_tokens\"");
            } 
            if (request.ChunkingTokenizer != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ChunkingTokenizer}"),
                    name: "\"chunking_tokenizer\"");
            } 
            if (request.ChunkingMergePeers != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ChunkingMergePeers}"),
                    name: "\"chunking_merge_peers\"");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareChunkFilesWithHybridChunkerAsAsyncTaskV1ChunkHybridFileAsyncPostRequest(
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
            ProcessChunkFilesWithHybridChunkerAsAsyncTaskV1ChunkHybridFileAsyncPostResponse(
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
                ProcessChunkFilesWithHybridChunkerAsAsyncTaskV1ChunkHybridFileAsyncPostResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.TaskStatusResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.TaskStatusResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Chunk Files With Hybridchunker As Async Task
        /// </summary>
        /// <param name="files"></param>
        /// <param name="includeConvertedDoc">
        /// If true, the output will include both the chunks and the converted document.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="targetType">
        /// Specification for the type of output target.<br/>
        /// Default Value: inbody
        /// </param>
        /// <param name="convertFromFormats">
        /// Input format(s) to convert from. String or list of strings. Allowed values: docx, pptx, html, image, pdf, asciidoc, md, csv, xlsx, xml_uspto, xml_jats, xml_xbrl, mets_gbs, json_docling, audio, vtt, latex. Optional, defaults to all formats.<br/>
        /// Default Value: [docx, pptx, html, image, pdf, asciidoc, md, csv, xlsx, xml_uspto, xml_jats, xml_xbrl, mets_gbs, json_docling, audio, vtt, latex]
        /// </param>
        /// <param name="convertImageExportMode">
        /// Image export mode for the document (in case of JSON, Markdown or HTML). Allowed values: placeholder, embedded, referenced. Optional, defaults to Embedded.<br/>
        /// Default Value: embedded
        /// </param>
        /// <param name="convertDoOcr">
        /// If enabled, the bitmap content will be processed using OCR. Boolean. Optional, defaults to true<br/>
        /// Default Value: true
        /// </param>
        /// <param name="convertForceOcr">
        /// If enabled, replace existing text with OCR-generated text over content. Boolean. Optional, defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="convertOcrEngine">
        /// The OCR engine to use. String. Allowed values: auto, easyocr, ocrmac, rapidocr, tesserocr, tesseract. Optional, defaults to easyocr.<br/>
        /// Default Value: easyocr
        /// </param>
        /// <param name="convertOcrLang">
        /// List of languages used by the OCR engine. Note that each OCR engine has different values for the language names. String or list of strings. Optional, defaults to empty.
        /// </param>
        /// <param name="convertPdfBackend">
        /// The PDF backend to use. String. Allowed values: pypdfium2, docling_parse, dlparse_v1, dlparse_v2, dlparse_v4. Optional, defaults to docling_parse.<br/>
        /// Default Value: docling_parse
        /// </param>
        /// <param name="convertTableMode">
        /// Mode to use for table structure, String. Allowed values: fast, accurate. Optional, defaults to accurate.<br/>
        /// Default Value: accurate
        /// </param>
        /// <param name="convertTableCellMatching">
        /// If true, matches table cells predictions back to PDF cells. Can break table output if PDF cells are merged across table columns. If false, let table structure model define the text cells, ignore PDF cells.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="convertPipeline">
        /// Choose the pipeline to process PDF or image files.<br/>
        /// Default Value: standard
        /// </param>
        /// <param name="convertPageRange">
        /// Only convert a range of pages. The page number starts at 1.<br/>
        /// Default Value: [1, 9223372036854775807L]
        /// </param>
        /// <param name="convertDocumentTimeout">
        /// The timeout for processing each document, in seconds.<br/>
        /// Default Value: 604800F
        /// </param>
        /// <param name="convertAbortOnError">
        /// Abort on error if enabled. Boolean. Optional, defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="convertDoTableStructure">
        /// If enabled, the table structure will be extracted. Boolean. Optional, defaults to true.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="convertIncludeImages">
        /// If enabled, images will be extracted from the document. Boolean. Optional, defaults to true.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="convertImagesScale">
        /// Scale factor for images. Float. Optional, defaults to 2.0.<br/>
        /// Default Value: 2F
        /// </param>
        /// <param name="convertMdPageBreakPlaceholder">
        /// Add this placeholder between pages in the markdown output.
        /// </param>
        /// <param name="convertDoCodeEnrichment">
        /// If enabled, perform OCR code enrichment. Boolean. Optional, defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="convertDoFormulaEnrichment">
        /// If enabled, perform formula OCR, return LaTeX code. Boolean. Optional, defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="convertDoPictureClassification">
        /// If enabled, classify pictures in documents. Boolean. Optional, defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="convertDoChartExtraction">
        /// If enabled, extract numeric data from charts. Boolean. Optional, defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="convertDoPictureDescription">
        /// If enabled, describe pictures in documents. Boolean. Optional, defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="convertPictureDescriptionAreaThreshold">
        /// Minimum percentage of the area for a picture to be processed with the models.<br/>
        /// Default Value: 0.05F
        /// </param>
        /// <param name="convertPictureDescriptionLocal">
        /// DEPRECATED: Options for running a local vision-language model in the picture description. The parameters refer to a model hosted on Hugging Face. This parameter is mutually exclusive with picture_description_api. Please migrate to picture_description_preset or picture_description_custom_config.
        /// </param>
        /// <param name="convertPictureDescriptionApi">
        /// DEPRECATED: API details for using a vision-language model in the picture description. This parameter is mutually exclusive with picture_description_local. Please migrate to picture_description_preset or picture_description_custom_config.
        /// </param>
        /// <param name="convertVlmPipelineModel">
        /// DEPRECATED: Preset of local and API models for the vlm pipeline. This parameter is mutually exclusive with vlm_pipeline_model_local and vlm_pipeline_model_api. Use the other options for more parameters. Please migrate to vlm_pipeline_preset or vlm_pipeline_custom_config.
        /// </param>
        /// <param name="convertVlmPipelineModelLocal">
        /// DEPRECATED: Options for running a local vision-language model for the vlm pipeline. The parameters refer to a model hosted on Hugging Face. This parameter is mutually exclusive with vlm_pipeline_model_api and vlm_pipeline_model. Please migrate to vlm_pipeline_preset or vlm_pipeline_custom_config.
        /// </param>
        /// <param name="convertVlmPipelineModelApi">
        /// DEPRECATED: API details for using a vision-language model for the vlm pipeline. This parameter is mutually exclusive with vlm_pipeline_model_local and vlm_pipeline_model. Please migrate to vlm_pipeline_preset or vlm_pipeline_custom_config.
        /// </param>
        /// <param name="convertVlmPipelinePreset">
        /// Preset ID to use (e.g., "default", "granite_docling"). Use "default" for stable, admin-controlled configuration.
        /// </param>
        /// <param name="convertPictureDescriptionPreset">
        /// Preset ID for picture description.
        /// </param>
        /// <param name="convertCodeFormulaPreset">
        /// Preset ID for code/formula extraction.
        /// </param>
        /// <param name="convertVlmPipelineCustomConfig">
        /// Custom VLM configuration including model spec and engine options. Only available if admin allows it. Must include 'model_spec' and 'engine_options'.
        /// </param>
        /// <param name="convertPictureDescriptionCustomConfig">
        /// Custom picture description configuration including model spec and engine options.
        /// </param>
        /// <param name="convertCodeFormulaCustomConfig">
        /// Custom code/formula extraction configuration including model spec and engine options.
        /// </param>
        /// <param name="convertTableStructureCustomConfig">
        /// Custom configuration for table structure model. Use this to specify a non-default kind with its options. The 'kind' field in the config dict determines which table structure implementation to use. If not specified, uses the default kind with preset configuration.
        /// </param>
        /// <param name="convertLayoutCustomConfig">
        /// Custom configuration for layout model. Use this to specify a non-default kind with its options. The 'kind' field in the config dict determines which layout implementation to use. If not specified, uses the default kind with preset configuration.
        /// </param>
        /// <param name="chunkingUseMarkdownTables">
        /// Use markdown table format instead of triplets for table serialization.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="chunkingIncludeRawText">
        /// Include both raw_text and text (contextualized) in response. If False, only text is included.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="chunkingMaxTokens">
        /// Maximum number of tokens per chunk. When left to none, the value is automatically extracted from the tokenizer.
        /// </param>
        /// <param name="chunkingTokenizer">
        /// HuggingFace model name for custom tokenization. If not specified, uses 'sentence-transformers/all-MiniLM-L6-v2' as default.<br/>
        /// Default Value: sentence-transformers/all-MiniLM-L6-v2
        /// </param>
        /// <param name="chunkingMergePeers">
        /// Merge undersized successive chunks with same headings.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.TaskStatusResponse> ChunkFilesWithHybridChunkerAsAsyncTaskV1ChunkHybridFileAsyncPostAsync(
            global::System.Collections.Generic.IList<byte[]> files,
            bool? includeConvertedDoc = default,
            global::G.TargetName? targetType = default,
            global::System.Collections.Generic.IList<global::G.InputFormat>? convertFromFormats = default,
            global::G.ImageRefMode? convertImageExportMode = default,
            bool? convertDoOcr = default,
            bool? convertForceOcr = default,
            global::G.OcrEnginesEnum? convertOcrEngine = default,
            global::System.Collections.Generic.IList<string>? convertOcrLang = default,
            global::G.PdfBackend? convertPdfBackend = default,
            global::G.TableFormerMode? convertTableMode = default,
            bool? convertTableCellMatching = default,
            global::G.ProcessingPipeline? convertPipeline = default,
            global::System.Collections.Generic.IList<int>? convertPageRange = default,
            double? convertDocumentTimeout = default,
            bool? convertAbortOnError = default,
            bool? convertDoTableStructure = default,
            bool? convertIncludeImages = default,
            double? convertImagesScale = default,
            string? convertMdPageBreakPlaceholder = default,
            bool? convertDoCodeEnrichment = default,
            bool? convertDoFormulaEnrichment = default,
            bool? convertDoPictureClassification = default,
            bool? convertDoChartExtraction = default,
            bool? convertDoPictureDescription = default,
            double? convertPictureDescriptionAreaThreshold = default,
            string? convertPictureDescriptionLocal = default,
            string? convertPictureDescriptionApi = default,
            global::G.VlmModelType? convertVlmPipelineModel = default,
            string? convertVlmPipelineModelLocal = default,
            string? convertVlmPipelineModelApi = default,
            string? convertVlmPipelinePreset = default,
            string? convertPictureDescriptionPreset = default,
            string? convertCodeFormulaPreset = default,
            string? convertVlmPipelineCustomConfig = default,
            string? convertPictureDescriptionCustomConfig = default,
            string? convertCodeFormulaCustomConfig = default,
            object? convertTableStructureCustomConfig = default,
            object? convertLayoutCustomConfig = default,
            bool? chunkingUseMarkdownTables = default,
            bool? chunkingIncludeRawText = default,
            int? chunkingMaxTokens = default,
            string? chunkingTokenizer = default,
            bool? chunkingMergePeers = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.BodyChunkFilesWithHybridChunkerAsAsyncTaskV1ChunkHybridFileAsyncPost
            {
                Files = files,
                IncludeConvertedDoc = includeConvertedDoc,
                TargetType = targetType,
                ConvertFromFormats = convertFromFormats,
                ConvertImageExportMode = convertImageExportMode,
                ConvertDoOcr = convertDoOcr,
                ConvertForceOcr = convertForceOcr,
                ConvertOcrEngine = convertOcrEngine,
                ConvertOcrLang = convertOcrLang,
                ConvertPdfBackend = convertPdfBackend,
                ConvertTableMode = convertTableMode,
                ConvertTableCellMatching = convertTableCellMatching,
                ConvertPipeline = convertPipeline,
                ConvertPageRange = convertPageRange,
                ConvertDocumentTimeout = convertDocumentTimeout,
                ConvertAbortOnError = convertAbortOnError,
                ConvertDoTableStructure = convertDoTableStructure,
                ConvertIncludeImages = convertIncludeImages,
                ConvertImagesScale = convertImagesScale,
                ConvertMdPageBreakPlaceholder = convertMdPageBreakPlaceholder,
                ConvertDoCodeEnrichment = convertDoCodeEnrichment,
                ConvertDoFormulaEnrichment = convertDoFormulaEnrichment,
                ConvertDoPictureClassification = convertDoPictureClassification,
                ConvertDoChartExtraction = convertDoChartExtraction,
                ConvertDoPictureDescription = convertDoPictureDescription,
                ConvertPictureDescriptionAreaThreshold = convertPictureDescriptionAreaThreshold,
                ConvertPictureDescriptionLocal = convertPictureDescriptionLocal,
                ConvertPictureDescriptionApi = convertPictureDescriptionApi,
                ConvertVlmPipelineModel = convertVlmPipelineModel,
                ConvertVlmPipelineModelLocal = convertVlmPipelineModelLocal,
                ConvertVlmPipelineModelApi = convertVlmPipelineModelApi,
                ConvertVlmPipelinePreset = convertVlmPipelinePreset,
                ConvertPictureDescriptionPreset = convertPictureDescriptionPreset,
                ConvertCodeFormulaPreset = convertCodeFormulaPreset,
                ConvertVlmPipelineCustomConfig = convertVlmPipelineCustomConfig,
                ConvertPictureDescriptionCustomConfig = convertPictureDescriptionCustomConfig,
                ConvertCodeFormulaCustomConfig = convertCodeFormulaCustomConfig,
                ConvertTableStructureCustomConfig = convertTableStructureCustomConfig,
                ConvertLayoutCustomConfig = convertLayoutCustomConfig,
                ChunkingUseMarkdownTables = chunkingUseMarkdownTables,
                ChunkingIncludeRawText = chunkingIncludeRawText,
                ChunkingMaxTokens = chunkingMaxTokens,
                ChunkingTokenizer = chunkingTokenizer,
                ChunkingMergePeers = chunkingMergePeers,
            };

            return await ChunkFilesWithHybridChunkerAsAsyncTaskV1ChunkHybridFileAsyncPostAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}