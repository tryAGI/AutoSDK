//HintName: G.V2Client.ParseFileApiV2ParsePost.g.cs

#nullable enable

namespace G
{
    public partial class V2Client
    {


        private static readonly global::G.EndPointSecurityRequirement s_ParseFileApiV2ParsePostSecurityRequirement0 =
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
        private static readonly global::G.EndPointSecurityRequirement[] s_ParseFileApiV2ParsePostSecurityRequirements =
            new global::G.EndPointSecurityRequirement[]
            {                s_ParseFileApiV2ParsePostSecurityRequirement0,
            };
        partial void PrepareParseFileApiV2ParsePostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Guid? projectId,
            global::System.Guid? organizationId,
            ref string? session,
            global::G.ParseRequestConfiguration request);
        partial void PrepareParseFileApiV2ParsePostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid? projectId,
            global::System.Guid? organizationId,
            string? session,
            global::G.ParseRequestConfiguration request);
        partial void ProcessParseFileApiV2ParsePostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessParseFileApiV2ParsePostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Parse File<br/>
        /// Parse a file by file ID or URL.<br/>
        /// Provide either `file_id` (a previously uploaded file) or<br/>
        /// `source_url` (a publicly accessible URL). Configure parsing<br/>
        /// with options like `tier`, `target_pages`, and `lang`.<br/>
        /// ## Tiers<br/>
        /// - `fast` — rule-based, cheapest, no AI<br/>
        /// - `cost_effective` — balanced speed and quality<br/>
        /// - `agentic` — full AI-powered parsing<br/>
        /// - `agentic_plus` — premium AI with specialized features<br/>
        /// The job runs asynchronously. Poll `GET /parse/{job_id}` with<br/>
        /// `expand=text` or `expand=markdown` to retrieve results.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ParseJobResponse> ParseFileApiV2ParsePostAsync(

            global::G.ParseRequestConfiguration request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareParseFileApiV2ParsePostArguments(
                httpClient: HttpClient,
                projectId: projectId,
                organizationId: organizationId,
                session: ref session,
                request: request);


            var __authorizations = global::G.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ParseFileApiV2ParsePostSecurityRequirements,
                operationName: "ParseFileApiV2ParsePostAsync");

            var __pathBuilder = new global::G.PathBuilder(
                path: "/api/v2/parse",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("project_id", projectId?.ToString())
                .AddOptionalParameter("organization_id", organizationId?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
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
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Cookie")
                {
                    var __cookieValue = global::System.Uri.EscapeDataString(__authorization.Value);
                    __cookies.Add($"{__authorization.Name}={__cookieValue}");
                }
            }

            if (__cookies.Count > 0)
            {
                __httpRequest.Headers.TryAddWithoutValidation("Cookie", string.Join("; ", __cookies));
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerOptions);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareParseFileApiV2ParsePostRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                projectId: projectId,
                organizationId: organizationId,
                session: session,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessParseFileApiV2ParsePostResponse(
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
                ProcessParseFileApiV2ParsePostResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::G.ParseJobResponse.FromJson(__content, JsonSerializerOptions) ??
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
                        await global::G.ParseJobResponse.FromJsonStreamAsync(__content, JsonSerializerOptions).ConfigureAwait(false) ??
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
        /// Parse File<br/>
        /// Parse a file by file ID or URL.<br/>
        /// Provide either `file_id` (a previously uploaded file) or<br/>
        /// `source_url` (a publicly accessible URL). Configure parsing<br/>
        /// with options like `tier`, `target_pages`, and `lang`.<br/>
        /// ## Tiers<br/>
        /// - `fast` — rule-based, cheapest, no AI<br/>
        /// - `cost_effective` — balanced speed and quality<br/>
        /// - `agentic` — full AI-powered parsing<br/>
        /// - `agentic_plus` — premium AI with specialized features<br/>
        /// The job runs asynchronously. Poll `GET /parse/{job_id}` with<br/>
        /// `expand=text` or `expand=markdown` to retrieve results.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="tier">
        /// Parsing tier: 'fast' (rule-based, cheapest), 'cost_effective' (balanced), 'agentic' (AI-powered with custom prompts), or 'agentic_plus' (premium AI with highest accuracy)
        /// </param>
        /// <param name="version">
        /// Tier version. Use 'latest' for the current stable version, or specify a specific version (e.g., '1.0', '2.0') for reproducible results
        /// </param>
        /// <param name="clientName">
        /// Identifier for the client/application making the request. Used for analytics and debugging. Example: 'my-app-v2'
        /// </param>
        /// <param name="processingOptions">
        /// Document processing options including OCR, table extraction, and chart parsing
        /// </param>
        /// <param name="fastOptions">
        /// Fast tier configuration options. Auto-initialized when tier='fast'. Cannot be used with other tiers
        /// </param>
        /// <param name="agenticOptions">
        /// AI-powered tier configuration (custom prompts). Auto-initialized for cost_effective/agentic/agentic_plus tiers. Cannot be used with fast tier
        /// </param>
        /// <param name="webhookConfigurations">
        /// Webhook endpoints for job status notifications. Multiple webhooks can be configured for different events or services
        /// </param>
        /// <param name="inputOptions">
        /// Format-specific options (HTML, PDF, spreadsheet, presentation). Applied based on detected input file type
        /// </param>
        /// <param name="cropBox">
        /// Crop boundaries to process only a portion of each page. Values are ratios 0-1 from page edges
        /// </param>
        /// <param name="pageRanges">
        /// Page selection: limit total pages or specify exact pages to process
        /// </param>
        /// <param name="disableCache">
        /// Bypass result caching and force re-parsing. Use when document content may have changed or you need fresh results
        /// </param>
        /// <param name="outputOptions">
        /// Output formatting options for markdown, text, and extracted images
        /// </param>
        /// <param name="processingControl">
        /// Job execution controls including timeouts and failure thresholds
        /// </param>
        /// <param name="fileId">
        /// ID of an existing file in the project to parse. Mutually exclusive with source_url
        /// </param>
        /// <param name="sourceUrl">
        /// Public URL of the document to parse. Mutually exclusive with file_id
        /// </param>
        /// <param name="httpProxy">
        /// HTTP/HTTPS proxy for fetching source_url. Ignored if using file_id
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::G.ParseJobResponse> ParseFileApiV2ParsePostAsync(
            global::G.ParseRequestConfigurationTier tier,
            global::G.AnyOf<global::G.ParseRequestConfigurationVersion?, string> version,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            string? clientName = default,
            global::G.LlamaParseProcessingOptions? processingOptions = default,
            global::G.LlamaParseFastOptions? fastOptions = default,
            global::G.LlamaParseAgenticOptions? agenticOptions = default,
            global::System.Collections.Generic.IList<global::G.LlamaParseWebhookConfiguration>? webhookConfigurations = default,
            global::G.LlamaParseInputOptions? inputOptions = default,
            global::G.LlamaParseCropBox? cropBox = default,
            global::G.LlamaParsePageRanges? pageRanges = default,
            bool? disableCache = default,
            global::G.LlamaParseOutputOptions? outputOptions = default,
            global::G.LlamaParseProcessingControl? processingControl = default,
            string? fileId = default,
            string? sourceUrl = default,
            string? httpProxy = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::G.ParseRequestConfiguration
            {
                Tier = tier,
                Version = version,
                ClientName = clientName,
                ProcessingOptions = processingOptions,
                FastOptions = fastOptions,
                AgenticOptions = agenticOptions,
                WebhookConfigurations = webhookConfigurations,
                InputOptions = inputOptions,
                CropBox = cropBox,
                PageRanges = pageRanges,
                DisableCache = disableCache,
                OutputOptions = outputOptions,
                ProcessingControl = processingControl,
                FileId = fileId,
                SourceUrl = sourceUrl,
                HttpProxy = httpProxy,
            };

            return await ParseFileApiV2ParsePostAsync(
                projectId: projectId,
                organizationId: organizationId,
                session: session,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}