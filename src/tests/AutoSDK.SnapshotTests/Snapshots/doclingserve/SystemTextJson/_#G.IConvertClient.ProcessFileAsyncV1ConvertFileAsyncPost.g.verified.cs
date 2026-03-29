//HintName: G.IConvertClient.ProcessFileAsyncV1ConvertFileAsyncPost.g.cs
#nullable enable

namespace G
{
    public partial interface IConvertClient
    {
        /// <summary>
        /// Process File Async
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TaskStatusResponse> ProcessFileAsyncV1ConvertFileAsyncPostAsync(

            global::G.BodyProcessFileAsyncV1ConvertFileAsyncPost request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Process File Async
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
        global::System.Threading.Tasks.Task<global::G.TaskStatusResponse> ProcessFileAsyncV1ConvertFileAsyncPostAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}