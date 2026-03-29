//HintName: G.IChunkClient.ChunkFilesWithHybridChunkerAsAsyncTaskV1ChunkHybridFileAsyncPost.g.cs
#nullable enable

namespace G
{
    public partial interface IChunkClient
    {
        /// <summary>
        /// Chunk Files With Hybridchunker As Async Task
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TaskStatusResponse> ChunkFilesWithHybridChunkerAsAsyncTaskV1ChunkHybridFileAsyncPostAsync(

            global::G.BodyChunkFilesWithHybridChunkerAsAsyncTaskV1ChunkHybridFileAsyncPost request,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        global::System.Threading.Tasks.Task<global::G.TaskStatusResponse> ChunkFilesWithHybridChunkerAsAsyncTaskV1ChunkHybridFileAsyncPostAsync(
            global::System.Collections.Generic.IList<string> files,
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
            byte[]? convertPageRange = default,
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
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}