//HintName: G.ParsingClient.UploadFileApiV1ParsingUploadPost.g.cs

#nullable enable

namespace G
{
    public partial class ParsingClient
    {
        partial void PrepareUploadFileApiV1ParsingUploadPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Guid? organizationId,
            global::System.Guid? projectId,
            ref string? session,
            global::G.BodyUploadFileApiV1ParsingUploadPost request);
        partial void PrepareUploadFileApiV1ParsingUploadPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid? organizationId,
            global::System.Guid? projectId,
            string? session,
            global::G.BodyUploadFileApiV1ParsingUploadPost request);
        partial void ProcessUploadFileApiV1ParsingUploadPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUploadFileApiV1ParsingUploadPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Upload File
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="projectId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ParsingJob> UploadFileApiV1ParsingUploadPostAsync(

            global::G.BodyUploadFileApiV1ParsingUploadPost request,
            global::System.Guid? organizationId = default,
            global::System.Guid? projectId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUploadFileApiV1ParsingUploadPostArguments(
                httpClient: HttpClient,
                organizationId: organizationId,
                projectId: projectId,
                session: ref session,
                request: request);

            var __pathBuilder = new global::G.PathBuilder(
                path: "/api/v1/parsing/upload",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("organization_id", organizationId?.ToString())
                .AddOptionalParameter("project_id", projectId?.ToString()) 
                ; 
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
            if (organizationId != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{organizationId}"),
                    name: "\"organization_id\"");
            } 
            if (projectId != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{projectId}"),
                    name: "\"project_id\"");
            } 
            if (session != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{session}"),
                    name: "\"session\"");
            } 
            if (request.File != default)
            {

                var __contentFile = new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>());
                __httpRequestContent.Add(
                    content: __contentFile,
                    name: "\"file\"",
                    fileName: request.Filename != null ? $"\"{request.Filename}\"" : string.Empty);
                if (__contentFile.Headers.ContentDisposition != null)
                {
                    __contentFile.Headers.ContentDisposition.FileNameStar = null;
                }
            } 
            if (request.AdaptiveLongTable != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.AdaptiveLongTable}"),
                    name: "\"adaptive_long_table\"");
            } 
            if (request.AnnotateLinks != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.AnnotateLinks}"),
                    name: "\"annotate_links\"");
            } 
            if (request.AutoMode != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.AutoMode}"),
                    name: "\"auto_mode\"");
            } 
            if (request.AutoModeTriggerOnImageInPage != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.AutoModeTriggerOnImageInPage}"),
                    name: "\"auto_mode_trigger_on_image_in_page\"");
            } 
            if (request.AutoModeTriggerOnTableInPage != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.AutoModeTriggerOnTableInPage}"),
                    name: "\"auto_mode_trigger_on_table_in_page\"");
            } 
            if (request.AutoModeTriggerOnTextInPage != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.AutoModeTriggerOnTextInPage}"),
                    name: "\"auto_mode_trigger_on_text_in_page\"");
            } 
            if (request.AutoModeTriggerOnRegexpInPage != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.AutoModeTriggerOnRegexpInPage}"),
                    name: "\"auto_mode_trigger_on_regexp_in_page\"");
            } 
            if (request.AutoModeConfigurationJson != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.AutoModeConfigurationJson}"),
                    name: "\"auto_mode_configuration_json\"");
            } 
            if (request.AzureOpenaiApiVersion != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.AzureOpenaiApiVersion}"),
                    name: "\"azure_openai_api_version\"");
            } 
            if (request.AzureOpenaiDeploymentName != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.AzureOpenaiDeploymentName}"),
                    name: "\"azure_openai_deployment_name\"");
            } 
            if (request.AzureOpenaiEndpoint != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.AzureOpenaiEndpoint}"),
                    name: "\"azure_openai_endpoint\"");
            } 
            if (request.AzureOpenaiKey != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.AzureOpenaiKey}"),
                    name: "\"azure_openai_key\"");
            } 
            if (request.BboxBottom != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.BboxBottom}"),
                    name: "\"bbox_bottom\"");
            } 
            if (request.BboxLeft != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.BboxLeft}"),
                    name: "\"bbox_left\"");
            } 
            if (request.BboxRight != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.BboxRight}"),
                    name: "\"bbox_right\"");
            } 
            if (request.BboxTop != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.BboxTop}"),
                    name: "\"bbox_top\"");
            } 
            if (request.CompactMarkdownTable != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.CompactMarkdownTable}"),
                    name: "\"compact_markdown_table\"");
            } 
            if (request.DisableOcr != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.DisableOcr}"),
                    name: "\"disable_ocr\"");
            } 
            if (request.DisableReconstruction != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.DisableReconstruction}"),
                    name: "\"disable_reconstruction\"");
            } 
            if (request.DisableImageExtraction != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.DisableImageExtraction}"),
                    name: "\"disable_image_extraction\"");
            } 
            if (request.DoNotCache != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.DoNotCache}"),
                    name: "\"do_not_cache\"");
            } 
            if (request.DoNotUnrollColumns != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.DoNotUnrollColumns}"),
                    name: "\"do_not_unroll_columns\"");
            } 
            if (request.ExtractCharts != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ExtractCharts}"),
                    name: "\"extract_charts\"");
            } 
            if (request.GuessXlsxSheetName != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.GuessXlsxSheetName}"),
                    name: "\"guess_xlsx_sheet_name\"");
            } 
            if (request.HighResOcr != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.HighResOcr}"),
                    name: "\"high_res_ocr\"");
            } 
            if (request.HtmlMakeAllElementsVisible != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.HtmlMakeAllElementsVisible}"),
                    name: "\"html_make_all_elements_visible\"");
            } 
            if (request.LayoutAware != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.LayoutAware}"),
                    name: "\"layout_aware\"");
            } 
            if (request.SpecializedChartParsingAgentic != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.SpecializedChartParsingAgentic}"),
                    name: "\"specialized_chart_parsing_agentic\"");
            } 
            if (request.SpecializedChartParsingPlus != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.SpecializedChartParsingPlus}"),
                    name: "\"specialized_chart_parsing_plus\"");
            } 
            if (request.SpecializedChartParsingEfficient != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.SpecializedChartParsingEfficient}"),
                    name: "\"specialized_chart_parsing_efficient\"");
            } 
            if (request.SpecializedImageParsing != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.SpecializedImageParsing}"),
                    name: "\"specialized_image_parsing\"");
            } 
            if (request.PreciseBoundingBox != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.PreciseBoundingBox}"),
                    name: "\"precise_bounding_box\"");
            } 
            if (request.LineLevelBoundingBox != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.LineLevelBoundingBox}"),
                    name: "\"line_level_bounding_box\"");
            } 
            if (request.HtmlRemoveFixedElements != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.HtmlRemoveFixedElements}"),
                    name: "\"html_remove_fixed_elements\"");
            } 
            if (request.HtmlRemoveNavigationElements != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.HtmlRemoveNavigationElements}"),
                    name: "\"html_remove_navigation_elements\"");
            } 
            if (request.HttpProxy != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.HttpProxy}"),
                    name: "\"http_proxy\"");
            } 
            if (request.InputS3Path != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.InputS3Path}"),
                    name: "\"input_s3_path\"");
            } 
            if (request.InputS3Region != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.InputS3Region}"),
                    name: "\"input_s3_region\"");
            } 
            if (request.InputUrl != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.InputUrl}"),
                    name: "\"input_url\"");
            } 
            if (request.InvalidateCache != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.InvalidateCache}"),
                    name: "\"invalidate_cache\"");
            } 
            if (request.Language != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.Language, x => x.ToValueString()))}]"),
                    name: "\"language\"");
            } 
            if (request.ExtractLayout != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ExtractLayout}"),
                    name: "\"extract_layout\"");
            } 
            if (request.MaxPages != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.MaxPages}"),
                    name: "\"max_pages\"");
            } 
            if (request.MergeTablesAcrossPagesInMarkdown != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.MergeTablesAcrossPagesInMarkdown}"),
                    name: "\"merge_tables_across_pages_in_markdown\"");
            } 
            if (request.OutlinedTableExtraction != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.OutlinedTableExtraction}"),
                    name: "\"outlined_table_extraction\"");
            } 
            if (request.AggressiveTableExtraction != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.AggressiveTableExtraction}"),
                    name: "\"aggressive_table_extraction\"");
            } 
            if (request.OutputPdfOfDocument != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.OutputPdfOfDocument}"),
                    name: "\"output_pdf_of_document\"");
            } 
            if (request.OutputS3PathPrefix != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.OutputS3PathPrefix}"),
                    name: "\"output_s3_path_prefix\"");
            } 
            if (request.OutputS3Region != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.OutputS3Region}"),
                    name: "\"output_s3_region\"");
            } 
            if (request.PagePrefix != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.PagePrefix}"),
                    name: "\"page_prefix\"");
            } 
            if (request.PageSeparator != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.PageSeparator}"),
                    name: "\"page_separator\"");
            } 
            if (request.PageSuffix != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.PageSuffix}"),
                    name: "\"page_suffix\"");
            } 
            if (request.PreserveLayoutAlignmentAcrossPages != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.PreserveLayoutAlignmentAcrossPages}"),
                    name: "\"preserve_layout_alignment_across_pages\"");
            } 
            if (request.PreserveVerySmallText != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.PreserveVerySmallText}"),
                    name: "\"preserve_very_small_text\"");
            } 
            if (request.SkipDiagonalText != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.SkipDiagonalText}"),
                    name: "\"skip_diagonal_text\"");
            } 
            if (request.SpreadsheetExtractSubTables != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.SpreadsheetExtractSubTables}"),
                    name: "\"spreadsheet_extract_sub_tables\"");
            } 
            if (request.SpreadsheetForceFormulaComputation != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.SpreadsheetForceFormulaComputation}"),
                    name: "\"spreadsheet_force_formula_computation\"");
            } 
            if (request.InlineImagesInMarkdown != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.InlineImagesInMarkdown}"),
                    name: "\"inline_images_in_markdown\"");
            } 
            if (request.StructuredOutput != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.StructuredOutput}"),
                    name: "\"structured_output\"");
            } 
            if (request.StructuredOutputJsonSchema != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.StructuredOutputJsonSchema}"),
                    name: "\"structured_output_json_schema\"");
            } 
            if (request.StructuredOutputJsonSchemaName != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.StructuredOutputJsonSchemaName}"),
                    name: "\"structured_output_json_schema_name\"");
            } 
            if (request.TakeScreenshot != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.TakeScreenshot}"),
                    name: "\"take_screenshot\"");
            } 
            if (request.TargetPages != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.TargetPages}"),
                    name: "\"target_pages\"");
            } 
            if (request.VendorMultimodalApiKey != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.VendorMultimodalApiKey}"),
                    name: "\"vendor_multimodal_api_key\"");
            } 
            if (request.VendorMultimodalModelName != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.VendorMultimodalModelName}"),
                    name: "\"vendor_multimodal_model_name\"");
            } 
            if (request.Model != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Model}"),
                    name: "\"model\"");
            } 
            if (request.WebhookUrl != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.WebhookUrl}"),
                    name: "\"webhook_url\"");
            } 
            if (request.WebhookConfigurations != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.WebhookConfigurations}"),
                    name: "\"webhook_configurations\"");
            } 
            if (request.Preset != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Preset}"),
                    name: "\"preset\"");
            } 
            if (request.ParseMode != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ParseMode}"),
                    name: "\"parse_mode\"");
            } 
            if (request.PageErrorTolerance != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.PageErrorTolerance}"),
                    name: "\"page_error_tolerance\"");
            } 
            if (request.ReplaceFailedPageMode != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ReplaceFailedPageMode}"),
                    name: "\"replace_failed_page_mode\"");
            } 
            if (request.ReplaceFailedPageWithErrorMessagePrefix != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ReplaceFailedPageWithErrorMessagePrefix}"),
                    name: "\"replace_failed_page_with_error_message_prefix\"");
            } 
            if (request.ReplaceFailedPageWithErrorMessageSuffix != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ReplaceFailedPageWithErrorMessageSuffix}"),
                    name: "\"replace_failed_page_with_error_message_suffix\"");
            } 
            if (request.SystemPrompt != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.SystemPrompt}"),
                    name: "\"system_prompt\"");
            } 
            if (request.SystemPromptAppend != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.SystemPromptAppend}"),
                    name: "\"system_prompt_append\"");
            } 
            if (request.UserPrompt != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.UserPrompt}"),
                    name: "\"user_prompt\"");
            } 
            if (request.JobTimeoutInSeconds != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.JobTimeoutInSeconds}"),
                    name: "\"job_timeout_in_seconds\"");
            } 
            if (request.JobTimeoutExtraTimePerPageInSeconds != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.JobTimeoutExtraTimePerPageInSeconds}"),
                    name: "\"job_timeout_extra_time_per_page_in_seconds\"");
            } 
            if (request.StrictModeImageExtraction != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.StrictModeImageExtraction}"),
                    name: "\"strict_mode_image_extraction\"");
            } 
            if (request.StrictModeImageOcr != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.StrictModeImageOcr}"),
                    name: "\"strict_mode_image_ocr\"");
            } 
            if (request.StrictModeReconstruction != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.StrictModeReconstruction}"),
                    name: "\"strict_mode_reconstruction\"");
            } 
            if (request.StrictModeBuggyFont != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.StrictModeBuggyFont}"),
                    name: "\"strict_mode_buggy_font\"");
            } 
            if (request.SaveImages != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.SaveImages}"),
                    name: "\"save_images\"");
            } 
            if (request.IgnoreDocumentElementsForLayoutDetection != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.IgnoreDocumentElementsForLayoutDetection}"),
                    name: "\"ignore_document_elements_for_layout_detection\"");
            } 
            if (request.KeepPageSeparatorWhenMergingTables != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.KeepPageSeparatorWhenMergingTables}"),
                    name: "\"keep_page_separator_when_merging_tables\"");
            } 
            if (request.OutputTablesAsHtml != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.OutputTablesAsHtml}"),
                    name: "\"output_tables_as_HTML\"");
            } 
            if (request.MarkdownTableMultilineHeaderSeparator != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.MarkdownTableMultilineHeaderSeparator}"),
                    name: "\"markdown_table_multiline_header_separator\"");
            } 
            if (request.UseVendorMultimodalModel != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.UseVendorMultimodalModel}"),
                    name: "\"use_vendor_multimodal_model\"");
            } 
            if (request.BoundingBox != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.BoundingBox}"),
                    name: "\"bounding_box\"");
            } 
            if (request.Gpt4oMode != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Gpt4oMode}"),
                    name: "\"gpt4o_mode\"");
            } 
            if (request.Gpt4oApiKey != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Gpt4oApiKey}"),
                    name: "\"gpt4o_api_key\"");
            } 
            if (request.ComplementalFormattingInstruction != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ComplementalFormattingInstruction}"),
                    name: "\"complemental_formatting_instruction\"");
            } 
            if (request.ContentGuidelineInstruction != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ContentGuidelineInstruction}"),
                    name: "\"content_guideline_instruction\"");
            } 
            if (request.PremiumMode != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.PremiumMode}"),
                    name: "\"premium_mode\"");
            } 
            if (request.IsFormattingInstruction != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.IsFormattingInstruction}"),
                    name: "\"is_formatting_instruction\"");
            } 
            if (request.ContinuousMode != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ContinuousMode}"),
                    name: "\"continuous_mode\"");
            } 
            if (request.ParsingInstruction != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ParsingInstruction}"),
                    name: "\"parsing_instruction\"");
            } 
            if (request.FastMode != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.FastMode}"),
                    name: "\"fast_mode\"");
            } 
            if (request.FormattingInstruction != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.FormattingInstruction}"),
                    name: "\"formatting_instruction\"");
            } 
            if (request.HideHeaders != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.HideHeaders}"),
                    name: "\"hide_headers\"");
            } 
            if (request.HideFooters != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.HideFooters}"),
                    name: "\"hide_footers\"");
            } 
            if (request.PageHeaderPrefix != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.PageHeaderPrefix}"),
                    name: "\"page_header_prefix\"");
            } 
            if (request.PageHeaderSuffix != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.PageHeaderSuffix}"),
                    name: "\"page_header_suffix\"");
            } 
            if (request.PageFooterPrefix != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.PageFooterPrefix}"),
                    name: "\"page_footer_prefix\"");
            } 
            if (request.PageFooterSuffix != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.PageFooterSuffix}"),
                    name: "\"page_footer_suffix\"");
            } 
            if (request.RemoveHiddenText != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.RemoveHiddenText}"),
                    name: "\"remove_hidden_text\"");
            } 
            if (request.PresentationOutOfBoundsContent != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.PresentationOutOfBoundsContent}"),
                    name: "\"presentation_out_of_bounds_content\"");
            } 
            if (request.PresentationSkipEmbeddedData != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.PresentationSkipEmbeddedData}"),
                    name: "\"presentation_skip_embedded_data\"");
            } 
            if (request.ExtractPrintedPageNumber != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.ExtractPrintedPageNumber}"),
                    name: "\"extract_printed_page_number\"");
            } 
            if (request.Tier != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Tier}"),
                    name: "\"tier\"");
            } 
            if (request.Version != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Version}"),
                    name: "\"version\"");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUploadFileApiV1ParsingUploadPostRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                organizationId: organizationId,
                projectId: projectId,
                session: session,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUploadFileApiV1ParsingUploadPostResponse(
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
                ProcessUploadFileApiV1ParsingUploadPostResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.ParsingJob.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.ParsingJob.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Upload File
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="projectId"></param>
        /// <param name="session"></param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="adaptiveLongTable">
        /// Default Value: false
        /// </param>
        /// <param name="annotateLinks">
        /// Default Value: false
        /// </param>
        /// <param name="autoMode">
        /// Default Value: false
        /// </param>
        /// <param name="autoModeTriggerOnImageInPage">
        /// Default Value: false
        /// </param>
        /// <param name="autoModeTriggerOnTableInPage">
        /// Default Value: false
        /// </param>
        /// <param name="autoModeTriggerOnTextInPage"></param>
        /// <param name="autoModeTriggerOnRegexpInPage"></param>
        /// <param name="autoModeConfigurationJson"></param>
        /// <param name="azureOpenaiApiVersion"></param>
        /// <param name="azureOpenaiDeploymentName"></param>
        /// <param name="azureOpenaiEndpoint"></param>
        /// <param name="azureOpenaiKey"></param>
        /// <param name="bboxBottom"></param>
        /// <param name="bboxLeft"></param>
        /// <param name="bboxRight"></param>
        /// <param name="bboxTop"></param>
        /// <param name="compactMarkdownTable">
        /// Default Value: false
        /// </param>
        /// <param name="disableOcr">
        /// Default Value: false
        /// </param>
        /// <param name="disableReconstruction">
        /// Default Value: false
        /// </param>
        /// <param name="disableImageExtraction">
        /// Default Value: false
        /// </param>
        /// <param name="doNotCache">
        /// Default Value: false
        /// </param>
        /// <param name="doNotUnrollColumns">
        /// Default Value: false
        /// </param>
        /// <param name="extractCharts">
        /// Default Value: false
        /// </param>
        /// <param name="guessXlsxSheetName">
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
        /// <param name="htmlRemoveFixedElements">
        /// Default Value: false
        /// </param>
        /// <param name="htmlRemoveNavigationElements">
        /// Default Value: false
        /// </param>
        /// <param name="httpProxy"></param>
        /// <param name="inputS3Path"></param>
        /// <param name="inputS3Region"></param>
        /// <param name="inputUrl"></param>
        /// <param name="invalidateCache">
        /// Default Value: false
        /// </param>
        /// <param name="language">
        /// Default Value: [en]
        /// </param>
        /// <param name="extractLayout">
        /// Default Value: false
        /// </param>
        /// <param name="maxPages"></param>
        /// <param name="mergeTablesAcrossPagesInMarkdown">
        /// Default Value: false
        /// </param>
        /// <param name="outlinedTableExtraction">
        /// Default Value: false
        /// </param>
        /// <param name="aggressiveTableExtraction">
        /// Default Value: false
        /// </param>
        /// <param name="outputPdfOfDocument">
        /// Default Value: false
        /// </param>
        /// <param name="outputS3PathPrefix"></param>
        /// <param name="outputS3Region"></param>
        /// <param name="pagePrefix"></param>
        /// <param name="pageSeparator"></param>
        /// <param name="pageSuffix"></param>
        /// <param name="preserveLayoutAlignmentAcrossPages">
        /// Default Value: false
        /// </param>
        /// <param name="preserveVerySmallText">
        /// Default Value: false
        /// </param>
        /// <param name="skipDiagonalText">
        /// Default Value: false
        /// </param>
        /// <param name="spreadsheetExtractSubTables">
        /// Default Value: true
        /// </param>
        /// <param name="spreadsheetForceFormulaComputation">
        /// Default Value: false
        /// </param>
        /// <param name="inlineImagesInMarkdown">
        /// Default Value: false
        /// </param>
        /// <param name="structuredOutput">
        /// Default Value: false
        /// </param>
        /// <param name="structuredOutputJsonSchema"></param>
        /// <param name="structuredOutputJsonSchemaName"></param>
        /// <param name="takeScreenshot">
        /// Default Value: false
        /// </param>
        /// <param name="targetPages"></param>
        /// <param name="vendorMultimodalApiKey"></param>
        /// <param name="vendorMultimodalModelName"></param>
        /// <param name="model"></param>
        /// <param name="webhookUrl"></param>
        /// <param name="webhookConfigurations"></param>
        /// <param name="preset"></param>
        /// <param name="parseMode"></param>
        /// <param name="pageErrorTolerance">
        /// Default Value: 0.05F
        /// </param>
        /// <param name="replaceFailedPageMode"></param>
        /// <param name="replaceFailedPageWithErrorMessagePrefix"></param>
        /// <param name="replaceFailedPageWithErrorMessageSuffix"></param>
        /// <param name="systemPrompt"></param>
        /// <param name="systemPromptAppend"></param>
        /// <param name="userPrompt"></param>
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
        /// <param name="ignoreDocumentElementsForLayoutDetection">
        /// Default Value: false
        /// </param>
        /// <param name="keepPageSeparatorWhenMergingTables">
        /// Default Value: false
        /// </param>
        /// <param name="outputTablesAsHtml">
        /// Default Value: false
        /// </param>
        /// <param name="markdownTableMultilineHeaderSeparator"></param>
        /// <param name="useVendorMultimodalModel">
        /// Default Value: false
        /// </param>
        /// <param name="boundingBox"></param>
        /// <param name="gpt4oMode">
        /// Default Value: false
        /// </param>
        /// <param name="gpt4oApiKey"></param>
        /// <param name="complementalFormattingInstruction"></param>
        /// <param name="contentGuidelineInstruction"></param>
        /// <param name="premiumMode">
        /// Default Value: false
        /// </param>
        /// <param name="isFormattingInstruction">
        /// Default Value: true
        /// </param>
        /// <param name="continuousMode">
        /// Default Value: false
        /// </param>
        /// <param name="parsingInstruction"></param>
        /// <param name="fastMode">
        /// Default Value: false
        /// </param>
        /// <param name="formattingInstruction"></param>
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
        /// <param name="presentationOutOfBoundsContent">
        /// Default Value: false
        /// </param>
        /// <param name="presentationSkipEmbeddedData">
        /// Default Value: false
        /// </param>
        /// <param name="extractPrintedPageNumber">
        /// Default Value: false
        /// </param>
        /// <param name="tier"></param>
        /// <param name="version"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ParsingJob> UploadFileApiV1ParsingUploadPostAsync(
            global::System.Guid? organizationId = default,
            global::System.Guid? projectId = default,
            string? session = default,
            byte[]? file = default,
            string? filename = default,
            bool? adaptiveLongTable = default,
            bool? annotateLinks = default,
            bool? autoMode = default,
            bool? autoModeTriggerOnImageInPage = default,
            bool? autoModeTriggerOnTableInPage = default,
            string? autoModeTriggerOnTextInPage = default,
            string? autoModeTriggerOnRegexpInPage = default,
            string? autoModeConfigurationJson = default,
            string? azureOpenaiApiVersion = default,
            string? azureOpenaiDeploymentName = default,
            string? azureOpenaiEndpoint = default,
            string? azureOpenaiKey = default,
            double? bboxBottom = default,
            double? bboxLeft = default,
            double? bboxRight = default,
            double? bboxTop = default,
            bool? compactMarkdownTable = default,
            bool? disableOcr = default,
            bool? disableReconstruction = default,
            bool? disableImageExtraction = default,
            bool? doNotCache = default,
            bool? doNotUnrollColumns = default,
            bool? extractCharts = default,
            bool? guessXlsxSheetName = default,
            bool? highResOcr = default,
            bool? htmlMakeAllElementsVisible = default,
            bool? layoutAware = default,
            bool? specializedChartParsingAgentic = default,
            bool? specializedChartParsingPlus = default,
            bool? specializedChartParsingEfficient = default,
            bool? specializedImageParsing = default,
            bool? preciseBoundingBox = default,
            bool? lineLevelBoundingBox = default,
            bool? htmlRemoveFixedElements = default,
            bool? htmlRemoveNavigationElements = default,
            string? httpProxy = default,
            string? inputS3Path = default,
            string? inputS3Region = default,
            string? inputUrl = default,
            bool? invalidateCache = default,
            global::System.Collections.Generic.IList<global::G.ParserLanguages>? language = default,
            bool? extractLayout = default,
            int? maxPages = default,
            bool? mergeTablesAcrossPagesInMarkdown = default,
            bool? outlinedTableExtraction = default,
            bool? aggressiveTableExtraction = default,
            bool? outputPdfOfDocument = default,
            string? outputS3PathPrefix = default,
            string? outputS3Region = default,
            string? pagePrefix = default,
            string? pageSeparator = default,
            string? pageSuffix = default,
            bool? preserveLayoutAlignmentAcrossPages = default,
            bool? preserveVerySmallText = default,
            bool? skipDiagonalText = default,
            bool? spreadsheetExtractSubTables = default,
            bool? spreadsheetForceFormulaComputation = default,
            bool? inlineImagesInMarkdown = default,
            bool? structuredOutput = default,
            string? structuredOutputJsonSchema = default,
            string? structuredOutputJsonSchemaName = default,
            bool? takeScreenshot = default,
            string? targetPages = default,
            string? vendorMultimodalApiKey = default,
            string? vendorMultimodalModelName = default,
            string? model = default,
            string? webhookUrl = default,
            string? webhookConfigurations = default,
            string? preset = default,
            global::G.ParsingMode? parseMode = default,
            double? pageErrorTolerance = default,
            global::G.FailPageMode? replaceFailedPageMode = default,
            string? replaceFailedPageWithErrorMessagePrefix = default,
            string? replaceFailedPageWithErrorMessageSuffix = default,
            string? systemPrompt = default,
            string? systemPromptAppend = default,
            string? userPrompt = default,
            double? jobTimeoutInSeconds = default,
            double? jobTimeoutExtraTimePerPageInSeconds = default,
            bool? strictModeImageExtraction = default,
            bool? strictModeImageOcr = default,
            bool? strictModeReconstruction = default,
            bool? strictModeBuggyFont = default,
            bool? saveImages = default,
            bool? ignoreDocumentElementsForLayoutDetection = default,
            bool? keepPageSeparatorWhenMergingTables = default,
            bool? outputTablesAsHtml = default,
            string? markdownTableMultilineHeaderSeparator = default,
            bool? useVendorMultimodalModel = default,
            string? boundingBox = default,
            bool? gpt4oMode = default,
            string? gpt4oApiKey = default,
            string? complementalFormattingInstruction = default,
            string? contentGuidelineInstruction = default,
            bool? premiumMode = default,
            bool? isFormattingInstruction = default,
            bool? continuousMode = default,
            string? parsingInstruction = default,
            bool? fastMode = default,
            string? formattingInstruction = default,
            bool? hideHeaders = default,
            bool? hideFooters = default,
            string? pageHeaderPrefix = default,
            string? pageHeaderSuffix = default,
            string? pageFooterPrefix = default,
            string? pageFooterSuffix = default,
            bool? removeHiddenText = default,
            bool? presentationOutOfBoundsContent = default,
            bool? presentationSkipEmbeddedData = default,
            bool? extractPrintedPageNumber = default,
            string? tier = default,
            string? version = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.BodyUploadFileApiV1ParsingUploadPost
            {
                File = file,
                Filename = filename,
                AdaptiveLongTable = adaptiveLongTable,
                AnnotateLinks = annotateLinks,
                AutoMode = autoMode,
                AutoModeTriggerOnImageInPage = autoModeTriggerOnImageInPage,
                AutoModeTriggerOnTableInPage = autoModeTriggerOnTableInPage,
                AutoModeTriggerOnTextInPage = autoModeTriggerOnTextInPage,
                AutoModeTriggerOnRegexpInPage = autoModeTriggerOnRegexpInPage,
                AutoModeConfigurationJson = autoModeConfigurationJson,
                AzureOpenaiApiVersion = azureOpenaiApiVersion,
                AzureOpenaiDeploymentName = azureOpenaiDeploymentName,
                AzureOpenaiEndpoint = azureOpenaiEndpoint,
                AzureOpenaiKey = azureOpenaiKey,
                BboxBottom = bboxBottom,
                BboxLeft = bboxLeft,
                BboxRight = bboxRight,
                BboxTop = bboxTop,
                CompactMarkdownTable = compactMarkdownTable,
                DisableOcr = disableOcr,
                DisableReconstruction = disableReconstruction,
                DisableImageExtraction = disableImageExtraction,
                DoNotCache = doNotCache,
                DoNotUnrollColumns = doNotUnrollColumns,
                ExtractCharts = extractCharts,
                GuessXlsxSheetName = guessXlsxSheetName,
                HighResOcr = highResOcr,
                HtmlMakeAllElementsVisible = htmlMakeAllElementsVisible,
                LayoutAware = layoutAware,
                SpecializedChartParsingAgentic = specializedChartParsingAgentic,
                SpecializedChartParsingPlus = specializedChartParsingPlus,
                SpecializedChartParsingEfficient = specializedChartParsingEfficient,
                SpecializedImageParsing = specializedImageParsing,
                PreciseBoundingBox = preciseBoundingBox,
                LineLevelBoundingBox = lineLevelBoundingBox,
                HtmlRemoveFixedElements = htmlRemoveFixedElements,
                HtmlRemoveNavigationElements = htmlRemoveNavigationElements,
                HttpProxy = httpProxy,
                InputS3Path = inputS3Path,
                InputS3Region = inputS3Region,
                InputUrl = inputUrl,
                InvalidateCache = invalidateCache,
                Language = language,
                ExtractLayout = extractLayout,
                MaxPages = maxPages,
                MergeTablesAcrossPagesInMarkdown = mergeTablesAcrossPagesInMarkdown,
                OutlinedTableExtraction = outlinedTableExtraction,
                AggressiveTableExtraction = aggressiveTableExtraction,
                OutputPdfOfDocument = outputPdfOfDocument,
                OutputS3PathPrefix = outputS3PathPrefix,
                OutputS3Region = outputS3Region,
                PagePrefix = pagePrefix,
                PageSeparator = pageSeparator,
                PageSuffix = pageSuffix,
                PreserveLayoutAlignmentAcrossPages = preserveLayoutAlignmentAcrossPages,
                PreserveVerySmallText = preserveVerySmallText,
                SkipDiagonalText = skipDiagonalText,
                SpreadsheetExtractSubTables = spreadsheetExtractSubTables,
                SpreadsheetForceFormulaComputation = spreadsheetForceFormulaComputation,
                InlineImagesInMarkdown = inlineImagesInMarkdown,
                StructuredOutput = structuredOutput,
                StructuredOutputJsonSchema = structuredOutputJsonSchema,
                StructuredOutputJsonSchemaName = structuredOutputJsonSchemaName,
                TakeScreenshot = takeScreenshot,
                TargetPages = targetPages,
                VendorMultimodalApiKey = vendorMultimodalApiKey,
                VendorMultimodalModelName = vendorMultimodalModelName,
                Model = model,
                WebhookUrl = webhookUrl,
                WebhookConfigurations = webhookConfigurations,
                Preset = preset,
                ParseMode = parseMode,
                PageErrorTolerance = pageErrorTolerance,
                ReplaceFailedPageMode = replaceFailedPageMode,
                ReplaceFailedPageWithErrorMessagePrefix = replaceFailedPageWithErrorMessagePrefix,
                ReplaceFailedPageWithErrorMessageSuffix = replaceFailedPageWithErrorMessageSuffix,
                SystemPrompt = systemPrompt,
                SystemPromptAppend = systemPromptAppend,
                UserPrompt = userPrompt,
                JobTimeoutInSeconds = jobTimeoutInSeconds,
                JobTimeoutExtraTimePerPageInSeconds = jobTimeoutExtraTimePerPageInSeconds,
                StrictModeImageExtraction = strictModeImageExtraction,
                StrictModeImageOcr = strictModeImageOcr,
                StrictModeReconstruction = strictModeReconstruction,
                StrictModeBuggyFont = strictModeBuggyFont,
                SaveImages = saveImages,
                IgnoreDocumentElementsForLayoutDetection = ignoreDocumentElementsForLayoutDetection,
                KeepPageSeparatorWhenMergingTables = keepPageSeparatorWhenMergingTables,
                OutputTablesAsHtml = outputTablesAsHtml,
                MarkdownTableMultilineHeaderSeparator = markdownTableMultilineHeaderSeparator,
                UseVendorMultimodalModel = useVendorMultimodalModel,
                BoundingBox = boundingBox,
                Gpt4oMode = gpt4oMode,
                Gpt4oApiKey = gpt4oApiKey,
                ComplementalFormattingInstruction = complementalFormattingInstruction,
                ContentGuidelineInstruction = contentGuidelineInstruction,
                PremiumMode = premiumMode,
                IsFormattingInstruction = isFormattingInstruction,
                ContinuousMode = continuousMode,
                ParsingInstruction = parsingInstruction,
                FastMode = fastMode,
                FormattingInstruction = formattingInstruction,
                HideHeaders = hideHeaders,
                HideFooters = hideFooters,
                PageHeaderPrefix = pageHeaderPrefix,
                PageHeaderSuffix = pageHeaderSuffix,
                PageFooterPrefix = pageFooterPrefix,
                PageFooterSuffix = pageFooterSuffix,
                RemoveHiddenText = removeHiddenText,
                PresentationOutOfBoundsContent = presentationOutOfBoundsContent,
                PresentationSkipEmbeddedData = presentationSkipEmbeddedData,
                ExtractPrintedPageNumber = extractPrintedPageNumber,
                Tier = tier,
                Version = version,
            };

            return await UploadFileApiV1ParsingUploadPostAsync(
                organizationId: organizationId,
                projectId: projectId,
                session: session,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}