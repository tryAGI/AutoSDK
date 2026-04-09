//HintName: G.Models.BodyChunkFilesWithHybridChunkerV1ChunkHybridFilePost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyChunkFilesWithHybridChunkerV1ChunkHybridFilePost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<byte[]> Files { get; set; }

        /// <summary>
        /// If true, the output will include both the chunks and the converted document.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_converted_doc")]
        public bool? IncludeConvertedDoc { get; set; }

        /// <summary>
        /// Specification for the type of output target.<br/>
        /// Default Value: inbody
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TargetNameJsonConverter))]
        public global::G.TargetName? TargetType { get; set; }

        /// <summary>
        /// Input format(s) to convert from. String or list of strings. Allowed values: docx, pptx, html, image, pdf, asciidoc, md, csv, xlsx, xml_uspto, xml_jats, xml_xbrl, mets_gbs, json_docling, audio, vtt, latex. Optional, defaults to all formats.<br/>
        /// Default Value: [docx, pptx, html, image, pdf, asciidoc, md, csv, xlsx, xml_uspto, xml_jats, xml_xbrl, mets_gbs, json_docling, audio, vtt, latex]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_from_formats")]
        public global::System.Collections.Generic.IList<global::G.InputFormat>? ConvertFromFormats { get; set; }

        /// <summary>
        /// Image export mode for the document (in case of JSON, Markdown or HTML). Allowed values: placeholder, embedded, referenced. Optional, defaults to Embedded.<br/>
        /// Default Value: embedded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_image_export_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ImageRefModeJsonConverter))]
        public global::G.ImageRefMode? ConvertImageExportMode { get; set; }

        /// <summary>
        /// If enabled, the bitmap content will be processed using OCR. Boolean. Optional, defaults to true<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_do_ocr")]
        public bool? ConvertDoOcr { get; set; }

        /// <summary>
        /// If enabled, replace existing text with OCR-generated text over content. Boolean. Optional, defaults to false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_force_ocr")]
        public bool? ConvertForceOcr { get; set; }

        /// <summary>
        /// The OCR engine to use. String. Allowed values: auto, easyocr, ocrmac, rapidocr, tesserocr, tesseract. Optional, defaults to easyocr.<br/>
        /// Default Value: easyocr
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_ocr_engine")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OcrEnginesEnumJsonConverter))]
        public global::G.OcrEnginesEnum? ConvertOcrEngine { get; set; }

        /// <summary>
        /// List of languages used by the OCR engine. Note that each OCR engine has different values for the language names. String or list of strings. Optional, defaults to empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_ocr_lang")]
        public global::System.Collections.Generic.IList<string>? ConvertOcrLang { get; set; }

        /// <summary>
        /// The PDF backend to use. String. Allowed values: pypdfium2, docling_parse, dlparse_v1, dlparse_v2, dlparse_v4. Optional, defaults to docling_parse.<br/>
        /// Default Value: docling_parse
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_pdf_backend")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PdfBackendJsonConverter))]
        public global::G.PdfBackend? ConvertPdfBackend { get; set; }

        /// <summary>
        /// Mode to use for table structure, String. Allowed values: fast, accurate. Optional, defaults to accurate.<br/>
        /// Default Value: accurate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_table_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TableFormerModeJsonConverter))]
        public global::G.TableFormerMode? ConvertTableMode { get; set; }

        /// <summary>
        /// If true, matches table cells predictions back to PDF cells. Can break table output if PDF cells are merged across table columns. If false, let table structure model define the text cells, ignore PDF cells.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_table_cell_matching")]
        public bool? ConvertTableCellMatching { get; set; }

        /// <summary>
        /// Choose the pipeline to process PDF or image files.<br/>
        /// Default Value: standard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_pipeline")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ProcessingPipelineJsonConverter))]
        public global::G.ProcessingPipeline? ConvertPipeline { get; set; }

        /// <summary>
        /// Only convert a range of pages. The page number starts at 1.<br/>
        /// Default Value: [1, 9223372036854775807L]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_page_range")]
        public global::System.Collections.Generic.IList<int>? ConvertPageRange { get; set; }

        /// <summary>
        /// The timeout for processing each document, in seconds.<br/>
        /// Default Value: 604800F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_document_timeout")]
        public double? ConvertDocumentTimeout { get; set; }

        /// <summary>
        /// Abort on error if enabled. Boolean. Optional, defaults to false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_abort_on_error")]
        public bool? ConvertAbortOnError { get; set; }

        /// <summary>
        /// If enabled, the table structure will be extracted. Boolean. Optional, defaults to true.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_do_table_structure")]
        public bool? ConvertDoTableStructure { get; set; }

        /// <summary>
        /// If enabled, images will be extracted from the document. Boolean. Optional, defaults to true.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_include_images")]
        public bool? ConvertIncludeImages { get; set; }

        /// <summary>
        /// Scale factor for images. Float. Optional, defaults to 2.0.<br/>
        /// Default Value: 2F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_images_scale")]
        public double? ConvertImagesScale { get; set; }

        /// <summary>
        /// Add this placeholder between pages in the markdown output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_md_page_break_placeholder")]
        public string? ConvertMdPageBreakPlaceholder { get; set; }

        /// <summary>
        /// If enabled, perform OCR code enrichment. Boolean. Optional, defaults to false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_do_code_enrichment")]
        public bool? ConvertDoCodeEnrichment { get; set; }

        /// <summary>
        /// If enabled, perform formula OCR, return LaTeX code. Boolean. Optional, defaults to false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_do_formula_enrichment")]
        public bool? ConvertDoFormulaEnrichment { get; set; }

        /// <summary>
        /// If enabled, classify pictures in documents. Boolean. Optional, defaults to false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_do_picture_classification")]
        public bool? ConvertDoPictureClassification { get; set; }

        /// <summary>
        /// If enabled, extract numeric data from charts. Boolean. Optional, defaults to false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_do_chart_extraction")]
        public bool? ConvertDoChartExtraction { get; set; }

        /// <summary>
        /// If enabled, describe pictures in documents. Boolean. Optional, defaults to false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_do_picture_description")]
        public bool? ConvertDoPictureDescription { get; set; }

        /// <summary>
        /// Minimum percentage of the area for a picture to be processed with the models.<br/>
        /// Default Value: 0.05F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_picture_description_area_threshold")]
        public double? ConvertPictureDescriptionAreaThreshold { get; set; }

        /// <summary>
        /// DEPRECATED: Options for running a local vision-language model in the picture description. The parameters refer to a model hosted on Hugging Face. This parameter is mutually exclusive with picture_description_api. Please migrate to picture_description_preset or picture_description_custom_config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_picture_description_local")]
        public string? ConvertPictureDescriptionLocal { get; set; }

        /// <summary>
        /// DEPRECATED: API details for using a vision-language model in the picture description. This parameter is mutually exclusive with picture_description_local. Please migrate to picture_description_preset or picture_description_custom_config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_picture_description_api")]
        public string? ConvertPictureDescriptionApi { get; set; }

        /// <summary>
        /// DEPRECATED: Preset of local and API models for the vlm pipeline. This parameter is mutually exclusive with vlm_pipeline_model_local and vlm_pipeline_model_api. Use the other options for more parameters. Please migrate to vlm_pipeline_preset or vlm_pipeline_custom_config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_vlm_pipeline_model")]
        public global::G.VlmModelType? ConvertVlmPipelineModel { get; set; }

        /// <summary>
        /// DEPRECATED: Options for running a local vision-language model for the vlm pipeline. The parameters refer to a model hosted on Hugging Face. This parameter is mutually exclusive with vlm_pipeline_model_api and vlm_pipeline_model. Please migrate to vlm_pipeline_preset or vlm_pipeline_custom_config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_vlm_pipeline_model_local")]
        public string? ConvertVlmPipelineModelLocal { get; set; }

        /// <summary>
        /// DEPRECATED: API details for using a vision-language model for the vlm pipeline. This parameter is mutually exclusive with vlm_pipeline_model_local and vlm_pipeline_model. Please migrate to vlm_pipeline_preset or vlm_pipeline_custom_config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_vlm_pipeline_model_api")]
        public string? ConvertVlmPipelineModelApi { get; set; }

        /// <summary>
        /// Preset ID to use (e.g., "default", "granite_docling"). Use "default" for stable, admin-controlled configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_vlm_pipeline_preset")]
        public string? ConvertVlmPipelinePreset { get; set; }

        /// <summary>
        /// Preset ID for picture description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_picture_description_preset")]
        public string? ConvertPictureDescriptionPreset { get; set; }

        /// <summary>
        /// Preset ID for code/formula extraction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_code_formula_preset")]
        public string? ConvertCodeFormulaPreset { get; set; }

        /// <summary>
        /// Custom VLM configuration including model spec and engine options. Only available if admin allows it. Must include 'model_spec' and 'engine_options'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_vlm_pipeline_custom_config")]
        public string? ConvertVlmPipelineCustomConfig { get; set; }

        /// <summary>
        /// Custom picture description configuration including model spec and engine options.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_picture_description_custom_config")]
        public string? ConvertPictureDescriptionCustomConfig { get; set; }

        /// <summary>
        /// Custom code/formula extraction configuration including model spec and engine options.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_code_formula_custom_config")]
        public string? ConvertCodeFormulaCustomConfig { get; set; }

        /// <summary>
        /// Custom configuration for table structure model. Use this to specify a non-default kind with its options. The 'kind' field in the config dict determines which table structure implementation to use. If not specified, uses the default kind with preset configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_table_structure_custom_config")]
        public object? ConvertTableStructureCustomConfig { get; set; }

        /// <summary>
        /// Custom configuration for layout model. Use this to specify a non-default kind with its options. The 'kind' field in the config dict determines which layout implementation to use. If not specified, uses the default kind with preset configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("convert_layout_custom_config")]
        public object? ConvertLayoutCustomConfig { get; set; }

        /// <summary>
        /// Use markdown table format instead of triplets for table serialization.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunking_use_markdown_tables")]
        public bool? ChunkingUseMarkdownTables { get; set; }

        /// <summary>
        /// Include both raw_text and text (contextualized) in response. If False, only text is included.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunking_include_raw_text")]
        public bool? ChunkingIncludeRawText { get; set; }

        /// <summary>
        /// Maximum number of tokens per chunk. When left to none, the value is automatically extracted from the tokenizer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunking_max_tokens")]
        public int? ChunkingMaxTokens { get; set; }

        /// <summary>
        /// HuggingFace model name for custom tokenization. If not specified, uses 'sentence-transformers/all-MiniLM-L6-v2' as default.<br/>
        /// Default Value: sentence-transformers/all-MiniLM-L6-v2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunking_tokenizer")]
        public string? ChunkingTokenizer { get; set; }

        /// <summary>
        /// Merge undersized successive chunks with same headings.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunking_merge_peers")]
        public bool? ChunkingMergePeers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyChunkFilesWithHybridChunkerV1ChunkHybridFilePost" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyChunkFilesWithHybridChunkerV1ChunkHybridFilePost(
            global::System.Collections.Generic.IList<byte[]> files,
            bool? includeConvertedDoc,
            global::G.TargetName? targetType,
            global::System.Collections.Generic.IList<global::G.InputFormat>? convertFromFormats,
            global::G.ImageRefMode? convertImageExportMode,
            bool? convertDoOcr,
            bool? convertForceOcr,
            global::G.OcrEnginesEnum? convertOcrEngine,
            global::System.Collections.Generic.IList<string>? convertOcrLang,
            global::G.PdfBackend? convertPdfBackend,
            global::G.TableFormerMode? convertTableMode,
            bool? convertTableCellMatching,
            global::G.ProcessingPipeline? convertPipeline,
            global::System.Collections.Generic.IList<int>? convertPageRange,
            double? convertDocumentTimeout,
            bool? convertAbortOnError,
            bool? convertDoTableStructure,
            bool? convertIncludeImages,
            double? convertImagesScale,
            string? convertMdPageBreakPlaceholder,
            bool? convertDoCodeEnrichment,
            bool? convertDoFormulaEnrichment,
            bool? convertDoPictureClassification,
            bool? convertDoChartExtraction,
            bool? convertDoPictureDescription,
            double? convertPictureDescriptionAreaThreshold,
            string? convertPictureDescriptionLocal,
            string? convertPictureDescriptionApi,
            global::G.VlmModelType? convertVlmPipelineModel,
            string? convertVlmPipelineModelLocal,
            string? convertVlmPipelineModelApi,
            string? convertVlmPipelinePreset,
            string? convertPictureDescriptionPreset,
            string? convertCodeFormulaPreset,
            string? convertVlmPipelineCustomConfig,
            string? convertPictureDescriptionCustomConfig,
            string? convertCodeFormulaCustomConfig,
            object? convertTableStructureCustomConfig,
            object? convertLayoutCustomConfig,
            bool? chunkingUseMarkdownTables,
            bool? chunkingIncludeRawText,
            int? chunkingMaxTokens,
            string? chunkingTokenizer,
            bool? chunkingMergePeers)
        {
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
            this.IncludeConvertedDoc = includeConvertedDoc;
            this.TargetType = targetType;
            this.ConvertFromFormats = convertFromFormats;
            this.ConvertImageExportMode = convertImageExportMode;
            this.ConvertDoOcr = convertDoOcr;
            this.ConvertForceOcr = convertForceOcr;
            this.ConvertOcrEngine = convertOcrEngine;
            this.ConvertOcrLang = convertOcrLang;
            this.ConvertPdfBackend = convertPdfBackend;
            this.ConvertTableMode = convertTableMode;
            this.ConvertTableCellMatching = convertTableCellMatching;
            this.ConvertPipeline = convertPipeline;
            this.ConvertPageRange = convertPageRange;
            this.ConvertDocumentTimeout = convertDocumentTimeout;
            this.ConvertAbortOnError = convertAbortOnError;
            this.ConvertDoTableStructure = convertDoTableStructure;
            this.ConvertIncludeImages = convertIncludeImages;
            this.ConvertImagesScale = convertImagesScale;
            this.ConvertMdPageBreakPlaceholder = convertMdPageBreakPlaceholder;
            this.ConvertDoCodeEnrichment = convertDoCodeEnrichment;
            this.ConvertDoFormulaEnrichment = convertDoFormulaEnrichment;
            this.ConvertDoPictureClassification = convertDoPictureClassification;
            this.ConvertDoChartExtraction = convertDoChartExtraction;
            this.ConvertDoPictureDescription = convertDoPictureDescription;
            this.ConvertPictureDescriptionAreaThreshold = convertPictureDescriptionAreaThreshold;
            this.ConvertPictureDescriptionLocal = convertPictureDescriptionLocal;
            this.ConvertPictureDescriptionApi = convertPictureDescriptionApi;
            this.ConvertVlmPipelineModel = convertVlmPipelineModel;
            this.ConvertVlmPipelineModelLocal = convertVlmPipelineModelLocal;
            this.ConvertVlmPipelineModelApi = convertVlmPipelineModelApi;
            this.ConvertVlmPipelinePreset = convertVlmPipelinePreset;
            this.ConvertPictureDescriptionPreset = convertPictureDescriptionPreset;
            this.ConvertCodeFormulaPreset = convertCodeFormulaPreset;
            this.ConvertVlmPipelineCustomConfig = convertVlmPipelineCustomConfig;
            this.ConvertPictureDescriptionCustomConfig = convertPictureDescriptionCustomConfig;
            this.ConvertCodeFormulaCustomConfig = convertCodeFormulaCustomConfig;
            this.ConvertTableStructureCustomConfig = convertTableStructureCustomConfig;
            this.ConvertLayoutCustomConfig = convertLayoutCustomConfig;
            this.ChunkingUseMarkdownTables = chunkingUseMarkdownTables;
            this.ChunkingIncludeRawText = chunkingIncludeRawText;
            this.ChunkingMaxTokens = chunkingMaxTokens;
            this.ChunkingTokenizer = chunkingTokenizer;
            this.ChunkingMergePeers = chunkingMergePeers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyChunkFilesWithHybridChunkerV1ChunkHybridFilePost" /> class.
        /// </summary>
        public BodyChunkFilesWithHybridChunkerV1ChunkHybridFilePost()
        {
        }
    }
}