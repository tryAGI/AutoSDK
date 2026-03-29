//HintName: G.Models.BodyProcessFileAsyncV1ConvertFileAsyncPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyProcessFileAsyncV1ConvertFileAsyncPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Files { get; set; }

        /// <summary>
        /// Default Value: inbody
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TargetNameJsonConverter))]
        public global::G.TargetName? TargetType { get; set; }

        /// <summary>
        /// Input format(s) to convert from. String or list of strings. Allowed values: docx, pptx, html, image, pdf, asciidoc, md, csv, xlsx, xml_uspto, xml_jats, xml_xbrl, mets_gbs, json_docling, audio, vtt, latex. Optional, defaults to all formats.<br/>
        /// Default Value: [docx, pptx, html, image, pdf, asciidoc, md, csv, xlsx, xml_uspto, xml_jats, xml_xbrl, mets_gbs, json_docling, audio, vtt, latex]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_formats")]
        public global::System.Collections.Generic.IList<global::G.InputFormat>? FromFormats { get; set; }

        /// <summary>
        /// Output format(s) to convert to. String or list of strings. Allowed values: md, json, yaml, html, html_split_page, text, doctags, vtt. Optional, defaults to Markdown.<br/>
        /// Default Value: [md]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to_formats")]
        public global::System.Collections.Generic.IList<global::G.OutputFormat>? ToFormats { get; set; }

        /// <summary>
        /// Image export mode for the document (in case of JSON, Markdown or HTML). Allowed values: placeholder, embedded, referenced. Optional, defaults to Embedded.<br/>
        /// Default Value: embedded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_export_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ImageRefModeJsonConverter))]
        public global::G.ImageRefMode? ImageExportMode { get; set; }

        /// <summary>
        /// If enabled, the bitmap content will be processed using OCR. Boolean. Optional, defaults to true<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("do_ocr")]
        public bool? DoOcr { get; set; }

        /// <summary>
        /// If enabled, replace existing text with OCR-generated text over content. Boolean. Optional, defaults to false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("force_ocr")]
        public bool? ForceOcr { get; set; }

        /// <summary>
        /// The OCR engine to use. String. Allowed values: auto, easyocr, ocrmac, rapidocr, tesserocr, tesseract. Optional, defaults to easyocr.<br/>
        /// Default Value: easyocr
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ocr_engine")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OcrEnginesEnumJsonConverter))]
        public global::G.OcrEnginesEnum? OcrEngine { get; set; }

        /// <summary>
        /// List of languages used by the OCR engine. Note that each OCR engine has different values for the language names. String or list of strings. Optional, defaults to empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ocr_lang")]
        public global::System.Collections.Generic.IList<string>? OcrLang { get; set; }

        /// <summary>
        /// The PDF backend to use. String. Allowed values: pypdfium2, docling_parse, dlparse_v1, dlparse_v2, dlparse_v4. Optional, defaults to docling_parse.<br/>
        /// Default Value: docling_parse
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pdf_backend")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PdfBackendJsonConverter))]
        public global::G.PdfBackend? PdfBackend { get; set; }

        /// <summary>
        /// Mode to use for table structure, String. Allowed values: fast, accurate. Optional, defaults to accurate.<br/>
        /// Default Value: accurate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TableFormerModeJsonConverter))]
        public global::G.TableFormerMode? TableMode { get; set; }

        /// <summary>
        /// If true, matches table cells predictions back to PDF cells. Can break table output if PDF cells are merged across table columns. If false, let table structure model define the text cells, ignore PDF cells.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table_cell_matching")]
        public bool? TableCellMatching { get; set; }

        /// <summary>
        /// Choose the pipeline to process PDF or image files.<br/>
        /// Default Value: standard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pipeline")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProcessingPipelineJsonConverter))]
        public global::G.ProcessingPipeline? Pipeline { get; set; }

        /// <summary>
        /// Only convert a range of pages. The page number starts at 1.<br/>
        /// Default Value: [1, 9223372036854775807L]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_range")]
        public byte[]? PageRange { get; set; }

        /// <summary>
        /// The timeout for processing each document, in seconds.<br/>
        /// Default Value: 604800F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_timeout")]
        public double? DocumentTimeout { get; set; }

        /// <summary>
        /// Abort on error if enabled. Boolean. Optional, defaults to false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("abort_on_error")]
        public bool? AbortOnError { get; set; }

        /// <summary>
        /// If enabled, the table structure will be extracted. Boolean. Optional, defaults to true.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("do_table_structure")]
        public bool? DoTableStructure { get; set; }

        /// <summary>
        /// If enabled, images will be extracted from the document. Boolean. Optional, defaults to true.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_images")]
        public bool? IncludeImages { get; set; }

        /// <summary>
        /// Scale factor for images. Float. Optional, defaults to 2.0.<br/>
        /// Default Value: 2F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images_scale")]
        public double? ImagesScale { get; set; }

        /// <summary>
        /// Add this placeholder between pages in the markdown output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("md_page_break_placeholder")]
        public string? MdPageBreakPlaceholder { get; set; }

        /// <summary>
        /// If enabled, perform OCR code enrichment. Boolean. Optional, defaults to false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("do_code_enrichment")]
        public bool? DoCodeEnrichment { get; set; }

        /// <summary>
        /// If enabled, perform formula OCR, return LaTeX code. Boolean. Optional, defaults to false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("do_formula_enrichment")]
        public bool? DoFormulaEnrichment { get; set; }

        /// <summary>
        /// If enabled, classify pictures in documents. Boolean. Optional, defaults to false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("do_picture_classification")]
        public bool? DoPictureClassification { get; set; }

        /// <summary>
        /// If enabled, extract numeric data from charts. Boolean. Optional, defaults to false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("do_chart_extraction")]
        public bool? DoChartExtraction { get; set; }

        /// <summary>
        /// If enabled, describe pictures in documents. Boolean. Optional, defaults to false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("do_picture_description")]
        public bool? DoPictureDescription { get; set; }

        /// <summary>
        /// Minimum percentage of the area for a picture to be processed with the models.<br/>
        /// Default Value: 0.05F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("picture_description_area_threshold")]
        public double? PictureDescriptionAreaThreshold { get; set; }

        /// <summary>
        /// DEPRECATED: Options for running a local vision-language model in the picture description. The parameters refer to a model hosted on Hugging Face. This parameter is mutually exclusive with picture_description_api. Please migrate to picture_description_preset or picture_description_custom_config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("picture_description_local")]
        public string? PictureDescriptionLocal { get; set; }

        /// <summary>
        /// DEPRECATED: API details for using a vision-language model in the picture description. This parameter is mutually exclusive with picture_description_local. Please migrate to picture_description_preset or picture_description_custom_config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("picture_description_api")]
        public string? PictureDescriptionApi { get; set; }

        /// <summary>
        /// DEPRECATED: Preset of local and API models for the vlm pipeline. This parameter is mutually exclusive with vlm_pipeline_model_local and vlm_pipeline_model_api. Use the other options for more parameters. Please migrate to vlm_pipeline_preset or vlm_pipeline_custom_config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vlm_pipeline_model")]
        public global::G.VlmModelType? VlmPipelineModel { get; set; }

        /// <summary>
        /// DEPRECATED: Options for running a local vision-language model for the vlm pipeline. The parameters refer to a model hosted on Hugging Face. This parameter is mutually exclusive with vlm_pipeline_model_api and vlm_pipeline_model. Please migrate to vlm_pipeline_preset or vlm_pipeline_custom_config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vlm_pipeline_model_local")]
        public string? VlmPipelineModelLocal { get; set; }

        /// <summary>
        /// DEPRECATED: API details for using a vision-language model for the vlm pipeline. This parameter is mutually exclusive with vlm_pipeline_model_local and vlm_pipeline_model. Please migrate to vlm_pipeline_preset or vlm_pipeline_custom_config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vlm_pipeline_model_api")]
        public string? VlmPipelineModelApi { get; set; }

        /// <summary>
        /// Preset ID to use (e.g., "default", "granite_docling"). Use "default" for stable, admin-controlled configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vlm_pipeline_preset")]
        public string? VlmPipelinePreset { get; set; }

        /// <summary>
        /// Preset ID for picture description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("picture_description_preset")]
        public string? PictureDescriptionPreset { get; set; }

        /// <summary>
        /// Preset ID for code/formula extraction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_formula_preset")]
        public string? CodeFormulaPreset { get; set; }

        /// <summary>
        /// Custom VLM configuration including model spec and engine options. Only available if admin allows it. Must include 'model_spec' and 'engine_options'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vlm_pipeline_custom_config")]
        public string? VlmPipelineCustomConfig { get; set; }

        /// <summary>
        /// Custom picture description configuration including model spec and engine options.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("picture_description_custom_config")]
        public string? PictureDescriptionCustomConfig { get; set; }

        /// <summary>
        /// Custom code/formula extraction configuration including model spec and engine options.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_formula_custom_config")]
        public string? CodeFormulaCustomConfig { get; set; }

        /// <summary>
        /// Custom configuration for table structure model. Use this to specify a non-default kind with its options. The 'kind' field in the config dict determines which table structure implementation to use. If not specified, uses the default kind with preset configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("table_structure_custom_config")]
        public object? TableStructureCustomConfig { get; set; }

        /// <summary>
        /// Custom configuration for layout model. Use this to specify a non-default kind with its options. The 'kind' field in the config dict determines which layout implementation to use. If not specified, uses the default kind with preset configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layout_custom_config")]
        public object? LayoutCustomConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyProcessFileAsyncV1ConvertFileAsyncPost" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyProcessFileAsyncV1ConvertFileAsyncPost(
            global::System.Collections.Generic.IList<string> files,
            global::G.TargetName? targetType,
            global::System.Collections.Generic.IList<global::G.InputFormat>? fromFormats,
            global::System.Collections.Generic.IList<global::G.OutputFormat>? toFormats,
            global::G.ImageRefMode? imageExportMode,
            bool? doOcr,
            bool? forceOcr,
            global::G.OcrEnginesEnum? ocrEngine,
            global::System.Collections.Generic.IList<string>? ocrLang,
            global::G.PdfBackend? pdfBackend,
            global::G.TableFormerMode? tableMode,
            bool? tableCellMatching,
            global::G.ProcessingPipeline? pipeline,
            byte[]? pageRange,
            double? documentTimeout,
            bool? abortOnError,
            bool? doTableStructure,
            bool? includeImages,
            double? imagesScale,
            string? mdPageBreakPlaceholder,
            bool? doCodeEnrichment,
            bool? doFormulaEnrichment,
            bool? doPictureClassification,
            bool? doChartExtraction,
            bool? doPictureDescription,
            double? pictureDescriptionAreaThreshold,
            string? pictureDescriptionLocal,
            string? pictureDescriptionApi,
            global::G.VlmModelType? vlmPipelineModel,
            string? vlmPipelineModelLocal,
            string? vlmPipelineModelApi,
            string? vlmPipelinePreset,
            string? pictureDescriptionPreset,
            string? codeFormulaPreset,
            string? vlmPipelineCustomConfig,
            string? pictureDescriptionCustomConfig,
            string? codeFormulaCustomConfig,
            object? tableStructureCustomConfig,
            object? layoutCustomConfig)
        {
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
            this.TargetType = targetType;
            this.FromFormats = fromFormats;
            this.ToFormats = toFormats;
            this.ImageExportMode = imageExportMode;
            this.DoOcr = doOcr;
            this.ForceOcr = forceOcr;
            this.OcrEngine = ocrEngine;
            this.OcrLang = ocrLang;
            this.PdfBackend = pdfBackend;
            this.TableMode = tableMode;
            this.TableCellMatching = tableCellMatching;
            this.Pipeline = pipeline;
            this.PageRange = pageRange;
            this.DocumentTimeout = documentTimeout;
            this.AbortOnError = abortOnError;
            this.DoTableStructure = doTableStructure;
            this.IncludeImages = includeImages;
            this.ImagesScale = imagesScale;
            this.MdPageBreakPlaceholder = mdPageBreakPlaceholder;
            this.DoCodeEnrichment = doCodeEnrichment;
            this.DoFormulaEnrichment = doFormulaEnrichment;
            this.DoPictureClassification = doPictureClassification;
            this.DoChartExtraction = doChartExtraction;
            this.DoPictureDescription = doPictureDescription;
            this.PictureDescriptionAreaThreshold = pictureDescriptionAreaThreshold;
            this.PictureDescriptionLocal = pictureDescriptionLocal;
            this.PictureDescriptionApi = pictureDescriptionApi;
            this.VlmPipelineModel = vlmPipelineModel;
            this.VlmPipelineModelLocal = vlmPipelineModelLocal;
            this.VlmPipelineModelApi = vlmPipelineModelApi;
            this.VlmPipelinePreset = vlmPipelinePreset;
            this.PictureDescriptionPreset = pictureDescriptionPreset;
            this.CodeFormulaPreset = codeFormulaPreset;
            this.VlmPipelineCustomConfig = vlmPipelineCustomConfig;
            this.PictureDescriptionCustomConfig = pictureDescriptionCustomConfig;
            this.CodeFormulaCustomConfig = codeFormulaCustomConfig;
            this.TableStructureCustomConfig = tableStructureCustomConfig;
            this.LayoutCustomConfig = layoutCustomConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyProcessFileAsyncV1ConvertFileAsyncPost" /> class.
        /// </summary>
        public BodyProcessFileAsyncV1ConvertFileAsyncPost()
        {
        }
    }
}