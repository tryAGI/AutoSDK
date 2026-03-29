//HintName: G.Models.LlamaParseParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Settings that can be configured for how to use LlamaParse to parse files within a LlamaCloud pipeline.
    /// </summary>
    public sealed partial class LlamaParseParameters
    {
        /// <summary>
        /// Outbound webhook endpoints to notify on job status changes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_configurations")]
        public global::System.Collections.Generic.IList<global::G.WebhookConfiguration>? WebhookConfigurations { get; set; }

        /// <summary>
        /// The priority for the request. This field may be ignored or overwritten depending on the organization tier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        public global::G.LlamaParseParametersPriority2? Priority { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<global::G.ParserLanguages>? Languages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parsing_instruction")]
        public string? ParsingInstruction { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_ocr")]
        public bool? DisableOcr { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("annotate_links")]
        public bool? AnnotateLinks { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adaptive_long_table")]
        public bool? AdaptiveLongTable { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compact_markdown_table")]
        public bool? CompactMarkdownTable { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_reconstruction")]
        public bool? DisableReconstruction { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_image_extraction")]
        public bool? DisableImageExtraction { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("invalidate_cache")]
        public bool? InvalidateCache { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outlined_table_extraction")]
        public bool? OutlinedTableExtraction { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aggressive_table_extraction")]
        public bool? AggressiveTableExtraction { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_tables_across_pages_in_markdown")]
        public bool? MergeTablesAcrossPagesInMarkdown { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_pdf_of_document")]
        public bool? OutputPdfOfDocument { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("do_not_cache")]
        public bool? DoNotCache { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fast_mode")]
        public bool? FastMode { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_diagonal_text")]
        public bool? SkipDiagonalText { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preserve_layout_alignment_across_pages")]
        public bool? PreserveLayoutAlignmentAcrossPages { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preserve_very_small_text")]
        public bool? PreserveVerySmallText { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpt4o_mode")]
        public bool? Gpt4oMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpt4o_api_key")]
        public string? Gpt4oApiKey { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("do_not_unroll_columns")]
        public bool? DoNotUnrollColumns { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extract_layout")]
        public bool? ExtractLayout { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("high_res_ocr")]
        public bool? HighResOcr { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_make_all_elements_visible")]
        public bool? HtmlMakeAllElementsVisible { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("layout_aware")]
        public bool? LayoutAware { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("specialized_chart_parsing_agentic")]
        public bool? SpecializedChartParsingAgentic { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("specialized_chart_parsing_plus")]
        public bool? SpecializedChartParsingPlus { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("specialized_chart_parsing_efficient")]
        public bool? SpecializedChartParsingEfficient { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("specialized_image_parsing")]
        public bool? SpecializedImageParsing { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("precise_bounding_box")]
        public bool? PreciseBoundingBox { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("line_level_bounding_box")]
        public bool? LineLevelBoundingBox { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_remove_navigation_elements")]
        public bool? HtmlRemoveNavigationElements { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_remove_fixed_elements")]
        public bool? HtmlRemoveFixedElements { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guess_xlsx_sheet_name")]
        public bool? GuessXlsxSheetName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_separator")]
        public string? PageSeparator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bounding_box")]
        public string? BoundingBox { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bbox_top")]
        public double? BboxTop { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bbox_right")]
        public double? BboxRight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bbox_bottom")]
        public double? BboxBottom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bbox_left")]
        public double? BboxLeft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_pages")]
        public string? TargetPages { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_vendor_multimodal_model")]
        public bool? UseVendorMultimodalModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vendor_multimodal_model_name")]
        public string? VendorMultimodalModelName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vendor_multimodal_api_key")]
        public string? VendorMultimodalApiKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_prefix")]
        public string? PagePrefix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_suffix")]
        public string? PageSuffix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_url")]
        public string? WebhookUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset")]
        public string? Preset { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("take_screenshot")]
        public bool? TakeScreenshot { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_formatting_instruction")]
        public bool? IsFormattingInstruction { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("premium_mode")]
        public bool? PremiumMode { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("continuous_mode")]
        public bool? ContinuousMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_s3_path")]
        public string? InputS3Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_s3_region")]
        public string? InputS3Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_s3_path_prefix")]
        public string? OutputS3PathPrefix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_s3_region")]
        public string? OutputS3Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_openai_deployment_name")]
        public string? AzureOpenaiDeploymentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_openai_endpoint")]
        public string? AzureOpenaiEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_openai_api_version")]
        public string? AzureOpenaiApiVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure_openai_key")]
        public string? AzureOpenaiKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_url")]
        public string? InputUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("http_proxy")]
        public string? HttpProxy { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_mode")]
        public bool? AutoMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_mode_trigger_on_regexp_in_page")]
        public string? AutoModeTriggerOnRegexpInPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_mode_trigger_on_text_in_page")]
        public string? AutoModeTriggerOnTextInPage { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_mode_trigger_on_table_in_page")]
        public bool? AutoModeTriggerOnTableInPage { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_mode_trigger_on_image_in_page")]
        public bool? AutoModeTriggerOnImageInPage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_mode_configuration_json")]
        public string? AutoModeConfigurationJson { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structured_output")]
        public bool? StructuredOutput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structured_output_json_schema")]
        public string? StructuredOutputJsonSchema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structured_output_json_schema_name")]
        public string? StructuredOutputJsonSchemaName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_pages")]
        public int? MaxPages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_pages_enforced")]
        public int? MaxPagesEnforced { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extract_charts")]
        public bool? ExtractCharts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formatting_instruction")]
        public string? FormattingInstruction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("complemental_formatting_instruction")]
        public string? ComplementalFormattingInstruction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_guideline_instruction")]
        public string? ContentGuidelineInstruction { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spreadsheet_extract_sub_tables")]
        public bool? SpreadsheetExtractSubTables { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spreadsheet_force_formula_computation")]
        public bool? SpreadsheetForceFormulaComputation { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spreadsheet_include_hidden_sheets")]
        public bool? SpreadsheetIncludeHiddenSheets { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inline_images_in_markdown")]
        public bool? InlineImagesInMarkdown { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_timeout_in_seconds")]
        public double? JobTimeoutInSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("job_timeout_extra_time_per_page_in_seconds")]
        public double? JobTimeoutExtraTimePerPageInSeconds { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict_mode_image_extraction")]
        public bool? StrictModeImageExtraction { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict_mode_image_ocr")]
        public bool? StrictModeImageOcr { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict_mode_reconstruction")]
        public bool? StrictModeReconstruction { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict_mode_buggy_font")]
        public bool? StrictModeBuggyFont { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("save_images")]
        public bool? SaveImages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images_to_save")]
        public global::System.Collections.Generic.IList<global::G.LlamaParseParametersImagesToSaveVariant1Item>? ImagesToSave { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hide_headers")]
        public bool? HideHeaders { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hide_footers")]
        public bool? HideFooters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_header_prefix")]
        public string? PageHeaderPrefix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_header_suffix")]
        public string? PageHeaderSuffix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_footer_prefix")]
        public string? PageFooterPrefix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_footer_suffix")]
        public string? PageFooterSuffix { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remove_hidden_text")]
        public bool? RemoveHiddenText { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keep_page_separator_when_merging_tables")]
        public bool? KeepPageSeparatorWhenMergingTables { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignore_document_elements_for_layout_detection")]
        public bool? IgnoreDocumentElementsForLayoutDetection { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tables_as_HTML")]
        public bool? OutputTablesAsHtml { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("internal_is_screenshot_job")]
        public bool? InternalIsScreenshotJob { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parse_mode")]
        public global::G.ParsingMode? ParseMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_prompt")]
        public string? SystemPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_prompt_append")]
        public string? SystemPromptAppend { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_prompt")]
        public string? UserPrompt { get; set; }

        /// <summary>
        /// Default Value: 0.05F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_error_tolerance")]
        public double? PageErrorTolerance { get; set; }

        /// <summary>
        /// Default Value: raw_text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replace_failed_page_mode")]
        public global::G.FailPageMode? ReplaceFailedPageMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replace_failed_page_with_error_message_prefix")]
        public string? ReplaceFailedPageWithErrorMessagePrefix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replace_failed_page_with_error_message_suffix")]
        public string? ReplaceFailedPageWithErrorMessageSuffix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown_table_multiline_header_separator")]
        public string? MarkdownTableMultilineHeaderSeparator { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presentation_out_of_bounds_content")]
        public bool? PresentationOutOfBoundsContent { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presentation_skip_embedded_data")]
        public bool? PresentationSkipEmbeddedData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tier")]
        public string? Tier { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extract_printed_page_number")]
        public bool? ExtractPrintedPageNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_cost_optimizer")]
        public bool? EnableCostOptimizer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseParameters" /> class.
        /// </summary>
        /// <param name="webhookConfigurations">
        /// Outbound webhook endpoints to notify on job status changes
        /// </param>
        /// <param name="priority">
        /// The priority for the request. This field may be ignored or overwritten depending on the organization tier.
        /// </param>
        /// <param name="languages"></param>
        /// <param name="parsingInstruction"></param>
        /// <param name="disableOcr">
        /// Default Value: false
        /// </param>
        /// <param name="annotateLinks">
        /// Default Value: false
        /// </param>
        /// <param name="adaptiveLongTable">
        /// Default Value: false
        /// </param>
        /// <param name="compactMarkdownTable">
        /// Default Value: false
        /// </param>
        /// <param name="disableReconstruction">
        /// Default Value: false
        /// </param>
        /// <param name="disableImageExtraction">
        /// Default Value: false
        /// </param>
        /// <param name="invalidateCache">
        /// Default Value: false
        /// </param>
        /// <param name="outlinedTableExtraction">
        /// Default Value: false
        /// </param>
        /// <param name="aggressiveTableExtraction">
        /// Default Value: false
        /// </param>
        /// <param name="mergeTablesAcrossPagesInMarkdown">
        /// Default Value: false
        /// </param>
        /// <param name="outputPdfOfDocument">
        /// Default Value: false
        /// </param>
        /// <param name="doNotCache">
        /// Default Value: false
        /// </param>
        /// <param name="fastMode">
        /// Default Value: false
        /// </param>
        /// <param name="skipDiagonalText">
        /// Default Value: false
        /// </param>
        /// <param name="preserveLayoutAlignmentAcrossPages">
        /// Default Value: false
        /// </param>
        /// <param name="preserveVerySmallText">
        /// Default Value: false
        /// </param>
        /// <param name="gpt4oMode">
        /// Default Value: false
        /// </param>
        /// <param name="gpt4oApiKey"></param>
        /// <param name="doNotUnrollColumns">
        /// Default Value: false
        /// </param>
        /// <param name="extractLayout">
        /// Default Value: false
        /// </param>
        /// <param name="highResOcr">
        /// Default Value: false
        /// </param>
        /// <param name="htmlMakeAllElementsVisible">
        /// Default Value: false
        /// </param>
        /// <param name="layoutAware">
        /// Default Value: false
        /// </param>
        /// <param name="specializedChartParsingAgentic">
        /// Default Value: false
        /// </param>
        /// <param name="specializedChartParsingPlus">
        /// Default Value: false
        /// </param>
        /// <param name="specializedChartParsingEfficient">
        /// Default Value: false
        /// </param>
        /// <param name="specializedImageParsing">
        /// Default Value: false
        /// </param>
        /// <param name="preciseBoundingBox">
        /// Default Value: false
        /// </param>
        /// <param name="lineLevelBoundingBox">
        /// Default Value: false
        /// </param>
        /// <param name="htmlRemoveNavigationElements">
        /// Default Value: false
        /// </param>
        /// <param name="htmlRemoveFixedElements">
        /// Default Value: false
        /// </param>
        /// <param name="guessXlsxSheetName">
        /// Default Value: false
        /// </param>
        /// <param name="pageSeparator"></param>
        /// <param name="boundingBox"></param>
        /// <param name="bboxTop"></param>
        /// <param name="bboxRight"></param>
        /// <param name="bboxBottom"></param>
        /// <param name="bboxLeft"></param>
        /// <param name="targetPages"></param>
        /// <param name="useVendorMultimodalModel">
        /// Default Value: false
        /// </param>
        /// <param name="vendorMultimodalModelName"></param>
        /// <param name="model"></param>
        /// <param name="vendorMultimodalApiKey"></param>
        /// <param name="pagePrefix"></param>
        /// <param name="pageSuffix"></param>
        /// <param name="webhookUrl"></param>
        /// <param name="preset"></param>
        /// <param name="takeScreenshot">
        /// Default Value: false
        /// </param>
        /// <param name="isFormattingInstruction">
        /// Default Value: true
        /// </param>
        /// <param name="premiumMode">
        /// Default Value: false
        /// </param>
        /// <param name="continuousMode">
        /// Default Value: false
        /// </param>
        /// <param name="inputS3Path"></param>
        /// <param name="inputS3Region"></param>
        /// <param name="outputS3PathPrefix"></param>
        /// <param name="outputS3Region"></param>
        /// <param name="projectId"></param>
        /// <param name="azureOpenaiDeploymentName"></param>
        /// <param name="azureOpenaiEndpoint"></param>
        /// <param name="azureOpenaiApiVersion"></param>
        /// <param name="azureOpenaiKey"></param>
        /// <param name="inputUrl"></param>
        /// <param name="httpProxy"></param>
        /// <param name="autoMode">
        /// Default Value: false
        /// </param>
        /// <param name="autoModeTriggerOnRegexpInPage"></param>
        /// <param name="autoModeTriggerOnTextInPage"></param>
        /// <param name="autoModeTriggerOnTableInPage">
        /// Default Value: false
        /// </param>
        /// <param name="autoModeTriggerOnImageInPage">
        /// Default Value: false
        /// </param>
        /// <param name="autoModeConfigurationJson"></param>
        /// <param name="structuredOutput">
        /// Default Value: false
        /// </param>
        /// <param name="structuredOutputJsonSchema"></param>
        /// <param name="structuredOutputJsonSchemaName"></param>
        /// <param name="maxPages"></param>
        /// <param name="maxPagesEnforced"></param>
        /// <param name="extractCharts">
        /// Default Value: false
        /// </param>
        /// <param name="formattingInstruction"></param>
        /// <param name="complementalFormattingInstruction"></param>
        /// <param name="contentGuidelineInstruction"></param>
        /// <param name="spreadsheetExtractSubTables">
        /// Default Value: false
        /// </param>
        /// <param name="spreadsheetForceFormulaComputation">
        /// Default Value: false
        /// </param>
        /// <param name="spreadsheetIncludeHiddenSheets">
        /// Default Value: false
        /// </param>
        /// <param name="inlineImagesInMarkdown">
        /// Default Value: false
        /// </param>
        /// <param name="jobTimeoutInSeconds"></param>
        /// <param name="jobTimeoutExtraTimePerPageInSeconds"></param>
        /// <param name="strictModeImageExtraction">
        /// Default Value: false
        /// </param>
        /// <param name="strictModeImageOcr">
        /// Default Value: false
        /// </param>
        /// <param name="strictModeReconstruction">
        /// Default Value: false
        /// </param>
        /// <param name="strictModeBuggyFont">
        /// Default Value: false
        /// </param>
        /// <param name="saveImages">
        /// Default Value: true
        /// </param>
        /// <param name="imagesToSave"></param>
        /// <param name="hideHeaders">
        /// Default Value: false
        /// </param>
        /// <param name="hideFooters">
        /// Default Value: false
        /// </param>
        /// <param name="pageHeaderPrefix"></param>
        /// <param name="pageHeaderSuffix"></param>
        /// <param name="pageFooterPrefix"></param>
        /// <param name="pageFooterSuffix"></param>
        /// <param name="removeHiddenText">
        /// Default Value: false
        /// </param>
        /// <param name="keepPageSeparatorWhenMergingTables">
        /// Default Value: false
        /// </param>
        /// <param name="ignoreDocumentElementsForLayoutDetection">
        /// Default Value: false
        /// </param>
        /// <param name="outputTablesAsHtml">
        /// Default Value: false
        /// </param>
        /// <param name="internalIsScreenshotJob">
        /// Default Value: false
        /// </param>
        /// <param name="parseMode"></param>
        /// <param name="systemPrompt"></param>
        /// <param name="systemPromptAppend"></param>
        /// <param name="userPrompt"></param>
        /// <param name="pageErrorTolerance">
        /// Default Value: 0.05F
        /// </param>
        /// <param name="replaceFailedPageMode">
        /// Default Value: raw_text
        /// </param>
        /// <param name="replaceFailedPageWithErrorMessagePrefix"></param>
        /// <param name="replaceFailedPageWithErrorMessageSuffix"></param>
        /// <param name="markdownTableMultilineHeaderSeparator"></param>
        /// <param name="presentationOutOfBoundsContent">
        /// Default Value: false
        /// </param>
        /// <param name="presentationSkipEmbeddedData">
        /// Default Value: false
        /// </param>
        /// <param name="tier"></param>
        /// <param name="version"></param>
        /// <param name="extractPrintedPageNumber">
        /// Default Value: false
        /// </param>
        /// <param name="enableCostOptimizer"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LlamaParseParameters(
            global::System.Collections.Generic.IList<global::G.WebhookConfiguration>? webhookConfigurations,
            global::G.LlamaParseParametersPriority2? priority,
            global::System.Collections.Generic.IList<global::G.ParserLanguages>? languages,
            string? parsingInstruction,
            bool? disableOcr,
            bool? annotateLinks,
            bool? adaptiveLongTable,
            bool? compactMarkdownTable,
            bool? disableReconstruction,
            bool? disableImageExtraction,
            bool? invalidateCache,
            bool? outlinedTableExtraction,
            bool? aggressiveTableExtraction,
            bool? mergeTablesAcrossPagesInMarkdown,
            bool? outputPdfOfDocument,
            bool? doNotCache,
            bool? fastMode,
            bool? skipDiagonalText,
            bool? preserveLayoutAlignmentAcrossPages,
            bool? preserveVerySmallText,
            bool? gpt4oMode,
            string? gpt4oApiKey,
            bool? doNotUnrollColumns,
            bool? extractLayout,
            bool? highResOcr,
            bool? htmlMakeAllElementsVisible,
            bool? layoutAware,
            bool? specializedChartParsingAgentic,
            bool? specializedChartParsingPlus,
            bool? specializedChartParsingEfficient,
            bool? specializedImageParsing,
            bool? preciseBoundingBox,
            bool? lineLevelBoundingBox,
            bool? htmlRemoveNavigationElements,
            bool? htmlRemoveFixedElements,
            bool? guessXlsxSheetName,
            string? pageSeparator,
            string? boundingBox,
            double? bboxTop,
            double? bboxRight,
            double? bboxBottom,
            double? bboxLeft,
            string? targetPages,
            bool? useVendorMultimodalModel,
            string? vendorMultimodalModelName,
            string? model,
            string? vendorMultimodalApiKey,
            string? pagePrefix,
            string? pageSuffix,
            string? webhookUrl,
            string? preset,
            bool? takeScreenshot,
            bool? isFormattingInstruction,
            bool? premiumMode,
            bool? continuousMode,
            string? inputS3Path,
            string? inputS3Region,
            string? outputS3PathPrefix,
            string? outputS3Region,
            string? projectId,
            string? azureOpenaiDeploymentName,
            string? azureOpenaiEndpoint,
            string? azureOpenaiApiVersion,
            string? azureOpenaiKey,
            string? inputUrl,
            string? httpProxy,
            bool? autoMode,
            string? autoModeTriggerOnRegexpInPage,
            string? autoModeTriggerOnTextInPage,
            bool? autoModeTriggerOnTableInPage,
            bool? autoModeTriggerOnImageInPage,
            string? autoModeConfigurationJson,
            bool? structuredOutput,
            string? structuredOutputJsonSchema,
            string? structuredOutputJsonSchemaName,
            int? maxPages,
            int? maxPagesEnforced,
            bool? extractCharts,
            string? formattingInstruction,
            string? complementalFormattingInstruction,
            string? contentGuidelineInstruction,
            bool? spreadsheetExtractSubTables,
            bool? spreadsheetForceFormulaComputation,
            bool? spreadsheetIncludeHiddenSheets,
            bool? inlineImagesInMarkdown,
            double? jobTimeoutInSeconds,
            double? jobTimeoutExtraTimePerPageInSeconds,
            bool? strictModeImageExtraction,
            bool? strictModeImageOcr,
            bool? strictModeReconstruction,
            bool? strictModeBuggyFont,
            bool? saveImages,
            global::System.Collections.Generic.IList<global::G.LlamaParseParametersImagesToSaveVariant1Item>? imagesToSave,
            bool? hideHeaders,
            bool? hideFooters,
            string? pageHeaderPrefix,
            string? pageHeaderSuffix,
            string? pageFooterPrefix,
            string? pageFooterSuffix,
            bool? removeHiddenText,
            bool? keepPageSeparatorWhenMergingTables,
            bool? ignoreDocumentElementsForLayoutDetection,
            bool? outputTablesAsHtml,
            bool? internalIsScreenshotJob,
            global::G.ParsingMode? parseMode,
            string? systemPrompt,
            string? systemPromptAppend,
            string? userPrompt,
            double? pageErrorTolerance,
            global::G.FailPageMode? replaceFailedPageMode,
            string? replaceFailedPageWithErrorMessagePrefix,
            string? replaceFailedPageWithErrorMessageSuffix,
            string? markdownTableMultilineHeaderSeparator,
            bool? presentationOutOfBoundsContent,
            bool? presentationSkipEmbeddedData,
            string? tier,
            string? version,
            bool? extractPrintedPageNumber,
            bool? enableCostOptimizer)
        {
            this.WebhookConfigurations = webhookConfigurations;
            this.Priority = priority;
            this.Languages = languages;
            this.ParsingInstruction = parsingInstruction;
            this.DisableOcr = disableOcr;
            this.AnnotateLinks = annotateLinks;
            this.AdaptiveLongTable = adaptiveLongTable;
            this.CompactMarkdownTable = compactMarkdownTable;
            this.DisableReconstruction = disableReconstruction;
            this.DisableImageExtraction = disableImageExtraction;
            this.InvalidateCache = invalidateCache;
            this.OutlinedTableExtraction = outlinedTableExtraction;
            this.AggressiveTableExtraction = aggressiveTableExtraction;
            this.MergeTablesAcrossPagesInMarkdown = mergeTablesAcrossPagesInMarkdown;
            this.OutputPdfOfDocument = outputPdfOfDocument;
            this.DoNotCache = doNotCache;
            this.FastMode = fastMode;
            this.SkipDiagonalText = skipDiagonalText;
            this.PreserveLayoutAlignmentAcrossPages = preserveLayoutAlignmentAcrossPages;
            this.PreserveVerySmallText = preserveVerySmallText;
            this.Gpt4oMode = gpt4oMode;
            this.Gpt4oApiKey = gpt4oApiKey;
            this.DoNotUnrollColumns = doNotUnrollColumns;
            this.ExtractLayout = extractLayout;
            this.HighResOcr = highResOcr;
            this.HtmlMakeAllElementsVisible = htmlMakeAllElementsVisible;
            this.LayoutAware = layoutAware;
            this.SpecializedChartParsingAgentic = specializedChartParsingAgentic;
            this.SpecializedChartParsingPlus = specializedChartParsingPlus;
            this.SpecializedChartParsingEfficient = specializedChartParsingEfficient;
            this.SpecializedImageParsing = specializedImageParsing;
            this.PreciseBoundingBox = preciseBoundingBox;
            this.LineLevelBoundingBox = lineLevelBoundingBox;
            this.HtmlRemoveNavigationElements = htmlRemoveNavigationElements;
            this.HtmlRemoveFixedElements = htmlRemoveFixedElements;
            this.GuessXlsxSheetName = guessXlsxSheetName;
            this.PageSeparator = pageSeparator;
            this.BoundingBox = boundingBox;
            this.BboxTop = bboxTop;
            this.BboxRight = bboxRight;
            this.BboxBottom = bboxBottom;
            this.BboxLeft = bboxLeft;
            this.TargetPages = targetPages;
            this.UseVendorMultimodalModel = useVendorMultimodalModel;
            this.VendorMultimodalModelName = vendorMultimodalModelName;
            this.Model = model;
            this.VendorMultimodalApiKey = vendorMultimodalApiKey;
            this.PagePrefix = pagePrefix;
            this.PageSuffix = pageSuffix;
            this.WebhookUrl = webhookUrl;
            this.Preset = preset;
            this.TakeScreenshot = takeScreenshot;
            this.IsFormattingInstruction = isFormattingInstruction;
            this.PremiumMode = premiumMode;
            this.ContinuousMode = continuousMode;
            this.InputS3Path = inputS3Path;
            this.InputS3Region = inputS3Region;
            this.OutputS3PathPrefix = outputS3PathPrefix;
            this.OutputS3Region = outputS3Region;
            this.ProjectId = projectId;
            this.AzureOpenaiDeploymentName = azureOpenaiDeploymentName;
            this.AzureOpenaiEndpoint = azureOpenaiEndpoint;
            this.AzureOpenaiApiVersion = azureOpenaiApiVersion;
            this.AzureOpenaiKey = azureOpenaiKey;
            this.InputUrl = inputUrl;
            this.HttpProxy = httpProxy;
            this.AutoMode = autoMode;
            this.AutoModeTriggerOnRegexpInPage = autoModeTriggerOnRegexpInPage;
            this.AutoModeTriggerOnTextInPage = autoModeTriggerOnTextInPage;
            this.AutoModeTriggerOnTableInPage = autoModeTriggerOnTableInPage;
            this.AutoModeTriggerOnImageInPage = autoModeTriggerOnImageInPage;
            this.AutoModeConfigurationJson = autoModeConfigurationJson;
            this.StructuredOutput = structuredOutput;
            this.StructuredOutputJsonSchema = structuredOutputJsonSchema;
            this.StructuredOutputJsonSchemaName = structuredOutputJsonSchemaName;
            this.MaxPages = maxPages;
            this.MaxPagesEnforced = maxPagesEnforced;
            this.ExtractCharts = extractCharts;
            this.FormattingInstruction = formattingInstruction;
            this.ComplementalFormattingInstruction = complementalFormattingInstruction;
            this.ContentGuidelineInstruction = contentGuidelineInstruction;
            this.SpreadsheetExtractSubTables = spreadsheetExtractSubTables;
            this.SpreadsheetForceFormulaComputation = spreadsheetForceFormulaComputation;
            this.SpreadsheetIncludeHiddenSheets = spreadsheetIncludeHiddenSheets;
            this.InlineImagesInMarkdown = inlineImagesInMarkdown;
            this.JobTimeoutInSeconds = jobTimeoutInSeconds;
            this.JobTimeoutExtraTimePerPageInSeconds = jobTimeoutExtraTimePerPageInSeconds;
            this.StrictModeImageExtraction = strictModeImageExtraction;
            this.StrictModeImageOcr = strictModeImageOcr;
            this.StrictModeReconstruction = strictModeReconstruction;
            this.StrictModeBuggyFont = strictModeBuggyFont;
            this.SaveImages = saveImages;
            this.ImagesToSave = imagesToSave;
            this.HideHeaders = hideHeaders;
            this.HideFooters = hideFooters;
            this.PageHeaderPrefix = pageHeaderPrefix;
            this.PageHeaderSuffix = pageHeaderSuffix;
            this.PageFooterPrefix = pageFooterPrefix;
            this.PageFooterSuffix = pageFooterSuffix;
            this.RemoveHiddenText = removeHiddenText;
            this.KeepPageSeparatorWhenMergingTables = keepPageSeparatorWhenMergingTables;
            this.IgnoreDocumentElementsForLayoutDetection = ignoreDocumentElementsForLayoutDetection;
            this.OutputTablesAsHtml = outputTablesAsHtml;
            this.InternalIsScreenshotJob = internalIsScreenshotJob;
            this.ParseMode = parseMode;
            this.SystemPrompt = systemPrompt;
            this.SystemPromptAppend = systemPromptAppend;
            this.UserPrompt = userPrompt;
            this.PageErrorTolerance = pageErrorTolerance;
            this.ReplaceFailedPageMode = replaceFailedPageMode;
            this.ReplaceFailedPageWithErrorMessagePrefix = replaceFailedPageWithErrorMessagePrefix;
            this.ReplaceFailedPageWithErrorMessageSuffix = replaceFailedPageWithErrorMessageSuffix;
            this.MarkdownTableMultilineHeaderSeparator = markdownTableMultilineHeaderSeparator;
            this.PresentationOutOfBoundsContent = presentationOutOfBoundsContent;
            this.PresentationSkipEmbeddedData = presentationSkipEmbeddedData;
            this.Tier = tier;
            this.Version = version;
            this.ExtractPrintedPageNumber = extractPrintedPageNumber;
            this.EnableCostOptimizer = enableCostOptimizer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LlamaParseParameters" /> class.
        /// </summary>
        public LlamaParseParameters()
        {
        }
    }
}