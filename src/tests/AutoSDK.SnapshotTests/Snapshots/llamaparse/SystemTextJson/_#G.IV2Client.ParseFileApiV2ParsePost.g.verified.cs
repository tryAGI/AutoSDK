//HintName: G.IV2Client.ParseFileApiV2ParsePost.g.cs
#nullable enable

namespace G
{
    public partial interface IV2Client
    {
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ParseJobResponse> ParseFileApiV2ParsePostAsync(

            global::G.ParseRequestConfiguration request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ParseJobResponse> ParseFileApiV2ParsePostAsync(
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
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}