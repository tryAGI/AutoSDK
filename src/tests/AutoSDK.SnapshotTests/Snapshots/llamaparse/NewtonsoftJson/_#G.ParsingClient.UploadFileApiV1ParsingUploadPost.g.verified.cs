//HintName: G.ParsingClient.UploadFileApiV1ParsingUploadPost.g.cs

#nullable enable

namespace G
{
    public partial class ParsingClient
    {


        private static readonly global::G.EndPointSecurityRequirement s_UploadFileApiV1ParsingUploadPostSecurityRequirement0 =
            new global::G.EndPointSecurityRequirement
            {
                Authorizations = new global::G.EndPointAuthorizationRequirement[]
                {                    new global::G.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HTTPBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::G.EndPointSecurityRequirement[] s_UploadFileApiV1ParsingUploadPostSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_UploadFileApiV1ParsingUploadPostSecurityRequirement0,
            };
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ParsingJob> UploadFileApiV1ParsingUploadPostAsync(

            global::G.BodyUploadFileApiV1ParsingUploadPost request,
            global::System.Guid? organizationId = default,
            global::System.Guid? projectId = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await UploadFileApiV1ParsingUploadPostAsResponseAsync(

                request: request,
                organizationId: organizationId,
                projectId: projectId,
                session: session,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Upload File
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="projectId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.AutoSDKHttpResponse<global::G.ParsingJob>> UploadFileApiV1ParsingUploadPostAsResponseAsync(

            global::G.BodyUploadFileApiV1ParsingUploadPost request,
            global::System.Guid? organizationId = default,
            global::System.Guid? projectId = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
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


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_UploadFileApiV1ParsingUploadPostSecurityRequirements,
                operationName: "UploadFileApiV1ParsingUploadPostAsync");

            using var __timeoutCancellationTokenSource = global::G.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::G.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::G.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: false);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::G.PathBuilder(
                                path: "/api/v1/parsing/upload",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("organization_id", organizationId?.ToString())
                                .AddOptionalParameter("project_id", projectId?.ToString())
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::G.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

                var __cookies = new global::System.Collections.Generic.List<string>();

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
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
                            var __session = session;
                            if (__session is not null)
                            {
                                __cookies.Add("session=" + (__session ?? string.Empty));
                            }

                if (__cookies.Count > 0)
                            {
                                __httpRequest.Headers.TryAddWithoutValidation("Cookie", string.Join("; ", __cookies));
                            }

                            var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
                            if (organizationId != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(organizationId.ToString() ?? string.Empty),
                                    name: "\"organization_id\"");

                            }
                            if (projectId != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(projectId.ToString() ?? string.Empty),
                                    name: "\"project_id\"");

                            }
                            if (session != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(session ?? string.Empty),
                                    name: "\"session\"");

                            }
                            if (request.File != default)
                            {

                                var __contentFile = new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>());
                                __contentFile.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.Filename is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.Filename) ?? string.Empty).ToLowerInvariant() switch
                                        {
                                            ".aac" => "audio/aac",
                                            ".flac" => "audio/flac",
                                            ".gif" => "image/gif",
                                            ".jpeg" => "image/jpeg",
                                            ".jpg" => "image/jpeg",
                                            ".json" => "application/json",
                                            ".m4a" => "audio/mp4",
                                            ".mp3" => "audio/mpeg",
                                            ".mp4" => "video/mp4",
                                            ".mpeg" => "audio/mpeg",
                                            ".mpga" => "audio/mpeg",
                                            ".oga" => "audio/ogg",
                                            ".ogg" => "audio/ogg",
                                            ".opus" => "audio/ogg",
                                            ".pdf" => "application/pdf",
                                            ".png" => "image/png",
                                            ".txt" => "text/plain",
                                            ".wav" => "audio/wav",
                                            ".weba" => "audio/webm",
                                            ".webm" => "video/webm",
                                            ".webp" => "image/webp",
                                            _ => "application/octet-stream",
                                        });
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
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.AdaptiveLongTable, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"adaptive_long_table\"");

                            }
                            if (request.AnnotateLinks != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.AnnotateLinks, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"annotate_links\"");

                            }
                            if (request.AutoMode != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.AutoMode, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"auto_mode\"");

                            }
                            if (request.AutoModeTriggerOnImageInPage != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.AutoModeTriggerOnImageInPage, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"auto_mode_trigger_on_image_in_page\"");

                            }
                            if (request.AutoModeTriggerOnTableInPage != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.AutoModeTriggerOnTableInPage, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"auto_mode_trigger_on_table_in_page\"");

                            }
                            if (request.AutoModeTriggerOnTextInPage != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.AutoModeTriggerOnTextInPage ?? string.Empty),
                                    name: "\"auto_mode_trigger_on_text_in_page\"");

                            }
                            if (request.AutoModeTriggerOnRegexpInPage != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.AutoModeTriggerOnRegexpInPage ?? string.Empty),
                                    name: "\"auto_mode_trigger_on_regexp_in_page\"");

                            }
                            if (request.AutoModeConfigurationJson != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.AutoModeConfigurationJson ?? string.Empty),
                                    name: "\"auto_mode_configuration_json\"");

                            }
                            if (request.AzureOpenaiApiVersion != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.AzureOpenaiApiVersion ?? string.Empty),
                                    name: "\"azure_openai_api_version\"");

                            }
                            if (request.AzureOpenaiDeploymentName != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.AzureOpenaiDeploymentName ?? string.Empty),
                                    name: "\"azure_openai_deployment_name\"");

                            }
                            if (request.AzureOpenaiEndpoint != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.AzureOpenaiEndpoint ?? string.Empty),
                                    name: "\"azure_openai_endpoint\"");

                            }
                            if (request.AzureOpenaiKey != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.AzureOpenaiKey ?? string.Empty),
                                    name: "\"azure_openai_key\"");

                            }
                            if (request.BboxBottom != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.BboxBottom, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"bbox_bottom\"");

                            }
                            if (request.BboxLeft != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.BboxLeft, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"bbox_left\"");

                            }
                            if (request.BboxRight != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.BboxRight, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"bbox_right\"");

                            }
                            if (request.BboxTop != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.BboxTop, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"bbox_top\"");

                            }
                            if (request.CompactMarkdownTable != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.CompactMarkdownTable, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"compact_markdown_table\"");

                            }
                            if (request.DisableOcr != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.DisableOcr, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"disable_ocr\"");

                            }
                            if (request.DisableReconstruction != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.DisableReconstruction, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"disable_reconstruction\"");

                            }
                            if (request.DisableImageExtraction != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.DisableImageExtraction, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"disable_image_extraction\"");

                            }
                            if (request.DoNotCache != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.DoNotCache, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"do_not_cache\"");

                            }
                            if (request.DoNotUnrollColumns != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.DoNotUnrollColumns, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"do_not_unroll_columns\"");

                            }
                            if (request.ExtractCharts != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.ExtractCharts, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"extract_charts\"");

                            }
                            if (request.GuessXlsxSheetName != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.GuessXlsxSheetName, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"guess_xlsx_sheet_name\"");

                            }
                            if (request.HighResOcr != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.HighResOcr, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"high_res_ocr\"");

                            }
                            if (request.HtmlMakeAllElementsVisible != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.HtmlMakeAllElementsVisible, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"html_make_all_elements_visible\"");

                            }
                            if (request.LayoutAware != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.LayoutAware, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"layout_aware\"");

                            }
                            if (request.SpecializedChartParsingAgentic != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.SpecializedChartParsingAgentic, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"specialized_chart_parsing_agentic\"");

                            }
                            if (request.SpecializedChartParsingPlus != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.SpecializedChartParsingPlus, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"specialized_chart_parsing_plus\"");

                            }
                            if (request.SpecializedChartParsingEfficient != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.SpecializedChartParsingEfficient, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"specialized_chart_parsing_efficient\"");

                            }
                            if (request.SpecializedImageParsing != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.SpecializedImageParsing, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"specialized_image_parsing\"");

                            }
                            if (request.PreciseBoundingBox != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.PreciseBoundingBox, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"precise_bounding_box\"");

                            }
                            if (request.LineLevelBoundingBox != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.LineLevelBoundingBox, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"line_level_bounding_box\"");

                            }
                            if (request.HtmlRemoveFixedElements != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.HtmlRemoveFixedElements, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"html_remove_fixed_elements\"");

                            }
                            if (request.HtmlRemoveNavigationElements != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.HtmlRemoveNavigationElements, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"html_remove_navigation_elements\"");

                            }
                            if (request.HttpProxy != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.HttpProxy ?? string.Empty),
                                    name: "\"http_proxy\"");

                            }
                            if (request.InputS3Path != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.InputS3Path ?? string.Empty),
                                    name: "\"input_s3_path\"");

                            }
                            if (request.InputS3Region != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.InputS3Region ?? string.Empty),
                                    name: "\"input_s3_region\"");

                            }
                            if (request.InputUrl != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.InputUrl ?? string.Empty),
                                    name: "\"input_url\"");

                            }
                            if (request.InvalidateCache != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.InvalidateCache, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
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
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.ExtractLayout, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"extract_layout\"");

                            }
                            if (request.MaxPages != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.MaxPages, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"max_pages\"");

                            }
                            if (request.MergeTablesAcrossPagesInMarkdown != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.MergeTablesAcrossPagesInMarkdown, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"merge_tables_across_pages_in_markdown\"");

                            }
                            if (request.OutlinedTableExtraction != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.OutlinedTableExtraction, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"outlined_table_extraction\"");

                            }
                            if (request.AggressiveTableExtraction != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.AggressiveTableExtraction, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"aggressive_table_extraction\"");

                            }
                            if (request.OutputPdfOfDocument != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.OutputPdfOfDocument, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"output_pdf_of_document\"");

                            }
                            if (request.OutputS3PathPrefix != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.OutputS3PathPrefix ?? string.Empty),
                                    name: "\"output_s3_path_prefix\"");

                            }
                            if (request.OutputS3Region != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.OutputS3Region ?? string.Empty),
                                    name: "\"output_s3_region\"");

                            }
                            if (request.PagePrefix != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.PagePrefix ?? string.Empty),
                                    name: "\"page_prefix\"");

                            }
                            if (request.PageSeparator != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.PageSeparator ?? string.Empty),
                                    name: "\"page_separator\"");

                            }
                            if (request.PageSuffix != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.PageSuffix ?? string.Empty),
                                    name: "\"page_suffix\"");

                            }
                            if (request.PreserveLayoutAlignmentAcrossPages != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.PreserveLayoutAlignmentAcrossPages, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"preserve_layout_alignment_across_pages\"");

                            }
                            if (request.PreserveVerySmallText != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.PreserveVerySmallText, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"preserve_very_small_text\"");

                            }
                            if (request.SkipDiagonalText != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.SkipDiagonalText, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"skip_diagonal_text\"");

                            }
                            if (request.SpreadsheetExtractSubTables != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.SpreadsheetExtractSubTables, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"spreadsheet_extract_sub_tables\"");

                            }
                            if (request.SpreadsheetForceFormulaComputation != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.SpreadsheetForceFormulaComputation, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"spreadsheet_force_formula_computation\"");

                            }
                            if (request.InlineImagesInMarkdown != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.InlineImagesInMarkdown, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"inline_images_in_markdown\"");

                            }
                            if (request.StructuredOutput != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.StructuredOutput, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"structured_output\"");

                            }
                            if (request.StructuredOutputJsonSchema != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.StructuredOutputJsonSchema ?? string.Empty),
                                    name: "\"structured_output_json_schema\"");

                            }
                            if (request.StructuredOutputJsonSchemaName != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.StructuredOutputJsonSchemaName ?? string.Empty),
                                    name: "\"structured_output_json_schema_name\"");

                            }
                            if (request.TakeScreenshot != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.TakeScreenshot, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"take_screenshot\"");

                            }
                            if (request.TargetPages != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.TargetPages ?? string.Empty),
                                    name: "\"target_pages\"");

                            }
                            if (request.VendorMultimodalApiKey != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.VendorMultimodalApiKey ?? string.Empty),
                                    name: "\"vendor_multimodal_api_key\"");

                            }
                            if (request.VendorMultimodalModelName != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.VendorMultimodalModelName ?? string.Empty),
                                    name: "\"vendor_multimodal_model_name\"");

                            }
                            if (request.Model != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Model ?? string.Empty),
                                    name: "\"model\"");

                            }
                            if (request.WebhookUrl != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.WebhookUrl ?? string.Empty),
                                    name: "\"webhook_url\"");

                            }
                            if (request.WebhookConfigurations != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.WebhookConfigurations ?? string.Empty),
                                    name: "\"webhook_configurations\"");

                            }
                            if (request.Preset != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Preset ?? string.Empty),
                                    name: "\"preset\"");

                            }
                            if (request.ParseMode != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.ParseMode.ToString() ?? string.Empty),
                                    name: "\"parse_mode\"");

                            }
                            if (request.PageErrorTolerance != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.PageErrorTolerance, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"page_error_tolerance\"");

                            }
                            if (request.ReplaceFailedPageMode != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.ReplaceFailedPageMode.ToString() ?? string.Empty),
                                    name: "\"replace_failed_page_mode\"");

                            }
                            if (request.ReplaceFailedPageWithErrorMessagePrefix != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.ReplaceFailedPageWithErrorMessagePrefix ?? string.Empty),
                                    name: "\"replace_failed_page_with_error_message_prefix\"");

                            }
                            if (request.ReplaceFailedPageWithErrorMessageSuffix != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.ReplaceFailedPageWithErrorMessageSuffix ?? string.Empty),
                                    name: "\"replace_failed_page_with_error_message_suffix\"");

                            }
                            if (request.SystemPrompt != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.SystemPrompt ?? string.Empty),
                                    name: "\"system_prompt\"");

                            }
                            if (request.SystemPromptAppend != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.SystemPromptAppend ?? string.Empty),
                                    name: "\"system_prompt_append\"");

                            }
                            if (request.UserPrompt != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.UserPrompt ?? string.Empty),
                                    name: "\"user_prompt\"");

                            }
                            if (request.JobTimeoutInSeconds != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.JobTimeoutInSeconds, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"job_timeout_in_seconds\"");

                            }
                            if (request.JobTimeoutExtraTimePerPageInSeconds != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.JobTimeoutExtraTimePerPageInSeconds, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"job_timeout_extra_time_per_page_in_seconds\"");

                            }
                            if (request.StrictModeImageExtraction != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.StrictModeImageExtraction, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"strict_mode_image_extraction\"");

                            }
                            if (request.StrictModeImageOcr != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.StrictModeImageOcr, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"strict_mode_image_ocr\"");

                            }
                            if (request.StrictModeReconstruction != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.StrictModeReconstruction, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"strict_mode_reconstruction\"");

                            }
                            if (request.StrictModeBuggyFont != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.StrictModeBuggyFont, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"strict_mode_buggy_font\"");

                            }
                            if (request.SaveImages != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.SaveImages, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"save_images\"");

                            }
                            if (request.IgnoreDocumentElementsForLayoutDetection != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.IgnoreDocumentElementsForLayoutDetection, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"ignore_document_elements_for_layout_detection\"");

                            }
                            if (request.KeepPageSeparatorWhenMergingTables != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.KeepPageSeparatorWhenMergingTables, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"keep_page_separator_when_merging_tables\"");

                            }
                            if (request.OutputTablesAsHtml != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.OutputTablesAsHtml, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"output_tables_as_HTML\"");

                            }
                            if (request.MarkdownTableMultilineHeaderSeparator != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.MarkdownTableMultilineHeaderSeparator ?? string.Empty),
                                    name: "\"markdown_table_multiline_header_separator\"");

                            }
                            if (request.UseVendorMultimodalModel != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.UseVendorMultimodalModel, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"use_vendor_multimodal_model\"");

                            }
                            if (request.BoundingBox != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.BoundingBox ?? string.Empty),
                                    name: "\"bounding_box\"");

                            }
                            if (request.Gpt4oMode != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.Gpt4oMode, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"gpt4o_mode\"");

                            }
                            if (request.Gpt4oApiKey != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Gpt4oApiKey ?? string.Empty),
                                    name: "\"gpt4o_api_key\"");

                            }
                            if (request.ComplementalFormattingInstruction != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.ComplementalFormattingInstruction ?? string.Empty),
                                    name: "\"complemental_formatting_instruction\"");

                            }
                            if (request.ContentGuidelineInstruction != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.ContentGuidelineInstruction ?? string.Empty),
                                    name: "\"content_guideline_instruction\"");

                            }
                            if (request.PremiumMode != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.PremiumMode, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"premium_mode\"");

                            }
                            if (request.IsFormattingInstruction != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.IsFormattingInstruction, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"is_formatting_instruction\"");

                            }
                            if (request.ContinuousMode != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.ContinuousMode, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"continuous_mode\"");

                            }
                            if (request.ParsingInstruction != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.ParsingInstruction ?? string.Empty),
                                    name: "\"parsing_instruction\"");

                            }
                            if (request.FastMode != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.FastMode, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"fast_mode\"");

                            }
                            if (request.FormattingInstruction != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.FormattingInstruction ?? string.Empty),
                                    name: "\"formatting_instruction\"");

                            }
                            if (request.HideHeaders != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.HideHeaders, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"hide_headers\"");

                            }
                            if (request.HideFooters != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.HideFooters, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"hide_footers\"");

                            }
                            if (request.PageHeaderPrefix != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.PageHeaderPrefix ?? string.Empty),
                                    name: "\"page_header_prefix\"");

                            }
                            if (request.PageHeaderSuffix != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.PageHeaderSuffix ?? string.Empty),
                                    name: "\"page_header_suffix\"");

                            }
                            if (request.PageFooterPrefix != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.PageFooterPrefix ?? string.Empty),
                                    name: "\"page_footer_prefix\"");

                            }
                            if (request.PageFooterSuffix != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.PageFooterSuffix ?? string.Empty),
                                    name: "\"page_footer_suffix\"");

                            }
                            if (request.RemoveHiddenText != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.RemoveHiddenText, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"remove_hidden_text\"");

                            }
                            if (request.PresentationOutOfBoundsContent != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.PresentationOutOfBoundsContent, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"presentation_out_of_bounds_content\"");

                            }
                            if (request.PresentationSkipEmbeddedData != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.PresentationSkipEmbeddedData, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"presentation_skip_embedded_data\"");

                            }
                            if (request.ExtractPrintedPageNumber != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.ExtractPrintedPageNumber, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"extract_printed_page_number\"");

                            }
                            if (request.Tier != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Tier ?? string.Empty),
                                    name: "\"tier\"");

                            }
                            if (request.Version != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Version ?? string.Empty),
                                    name: "\"version\"");

                            }

                            __httpRequest.Content = __httpRequestContent;

                global::G.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

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

                global::G.AutoSDKHttpRequestOptions.StampAuthorizationOverride(__httpRequest);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::G.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "UploadFileApiV1ParsingUploadPost",
                                methodName: "UploadFileApiV1ParsingUploadPostAsync",
                                pathTemplate: "\"/api/v1/parsing/upload\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::G.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "UploadFileApiV1ParsingUploadPost",
                                methodName: "UploadFileApiV1ParsingUploadPostAsync",
                                pathTemplate: "\"/api/v1/parsing/upload\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::G.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::G.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::G.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "UploadFileApiV1ParsingUploadPost",
                                methodName: "UploadFileApiV1ParsingUploadPostAsync",
                                pathTemplate: "\"/api/v1/parsing/upload\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::G.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessUploadFileApiV1ParsingUploadPostResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::G.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "UploadFileApiV1ParsingUploadPost",
                                methodName: "UploadFileApiV1ParsingUploadPostAsync",
                                pathTemplate: "\"/api/v1/parsing/upload\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::G.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::G.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "UploadFileApiV1ParsingUploadPost",
                                methodName: "UploadFileApiV1ParsingUploadPostAsync",
                                pathTemplate: "\"/api/v1/parsing/upload\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Validation Error
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::G.HTTPValidationError? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::G.HTTPValidationError.FromJson(__content_422, JsonSerializerOptions);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

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

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
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

                                    var __value = global::G.ParsingJob.FromJson(__content, JsonSerializerOptions) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::G.AutoSDKHttpResponse<global::G.ParsingJob>(
                                        statusCode: __response.StatusCode,
                                        headers: global::G.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::G.ParsingJob.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::G.AutoSDKHttpResponse<global::G.ParsingJob>(
                                        statusCode: __response.StatusCode,
                                        headers: global::G.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
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
            }
            finally
            {
                __httpRequest?.Dispose();
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
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
            global::G.AutoSDKRequestOptions? requestOptions = default,
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
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}