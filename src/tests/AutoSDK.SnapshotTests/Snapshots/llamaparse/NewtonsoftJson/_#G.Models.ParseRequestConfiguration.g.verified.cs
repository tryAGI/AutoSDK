//HintName: G.Models.ParseRequestConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Unified configuration for parsing with flexible input source.<br/>
    /// Specify exactly one input source: either an existing file by ID or a URL to fetch.<br/>
    /// This endpoint consolidates file-based and URL-based parsing into a single interface.
    /// </summary>
    public sealed partial class ParseRequestConfiguration
    {
        /// <summary>
        /// Parsing tier: 'fast' (rule-based, cheapest), 'cost_effective' (balanced), 'agentic' (AI-powered with custom prompts), or 'agentic_plus' (premium AI with highest accuracy)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tier", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ParseRequestConfigurationTierJsonConverter))]
        public global::G.ParseRequestConfigurationTier Tier { get; set; } = default!;

        /// <summary>
        /// Tier version. Use 'latest' for the current stable version, or specify a specific version (e.g., '1.0', '2.0') for reproducible results
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AnyOf<global::G.ParseRequestConfigurationVersion?, string> Version { get; set; } = default!;

        /// <summary>
        /// Identifier for the client/application making the request. Used for analytics and debugging. Example: 'my-app-v2'
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_name")]
        public string? ClientName { get; set; }

        /// <summary>
        /// Document processing options including OCR, table extraction, and chart parsing
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("processing_options")]
        public global::G.LlamaParseProcessingOptions? ProcessingOptions { get; set; }

        /// <summary>
        /// Fast tier configuration options. Auto-initialized when tier='fast'. Cannot be used with other tiers
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fast_options")]
        public global::G.LlamaParseFastOptions? FastOptions { get; set; }

        /// <summary>
        /// AI-powered tier configuration (custom prompts). Auto-initialized for cost_effective/agentic/agentic_plus tiers. Cannot be used with fast tier
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("agentic_options")]
        public global::G.LlamaParseAgenticOptions? AgenticOptions { get; set; }

        /// <summary>
        /// Webhook endpoints for job status notifications. Multiple webhooks can be configured for different events or services
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook_configurations")]
        public global::System.Collections.Generic.IList<global::G.LlamaParseWebhookConfiguration>? WebhookConfigurations { get; set; }

        /// <summary>
        /// Format-specific options (HTML, PDF, spreadsheet, presentation). Applied based on detected input file type
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_options")]
        public global::G.LlamaParseInputOptions? InputOptions { get; set; }

        /// <summary>
        /// Crop boundaries to process only a portion of each page. Values are ratios 0-1 from page edges
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("crop_box")]
        public global::G.LlamaParseCropBox? CropBox { get; set; }

        /// <summary>
        /// Page selection: limit total pages or specify exact pages to process
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_ranges")]
        public global::G.LlamaParsePageRanges? PageRanges { get; set; }

        /// <summary>
        /// Bypass result caching and force re-parsing. Use when document content may have changed or you need fresh results
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("disable_cache")]
        public bool? DisableCache { get; set; }

        /// <summary>
        /// Output formatting options for markdown, text, and extracted images
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_options")]
        public global::G.LlamaParseOutputOptions? OutputOptions { get; set; }

        /// <summary>
        /// Job execution controls including timeouts and failure thresholds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("processing_control")]
        public global::G.LlamaParseProcessingControl? ProcessingControl { get; set; }

        /// <summary>
        /// ID of an existing file in the project to parse. Mutually exclusive with source_url
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// Public URL of the document to parse. Mutually exclusive with file_id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_url")]
        public string? SourceUrl { get; set; }

        /// <summary>
        /// HTTP/HTTPS proxy for fetching source_url. Ignored if using file_id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("http_proxy")]
        public string? HttpProxy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseRequestConfiguration" /> class.
        /// </summary>
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
        public ParseRequestConfiguration(
            global::G.ParseRequestConfigurationTier tier,
            global::G.AnyOf<global::G.ParseRequestConfigurationVersion?, string> version,
            string? clientName,
            global::G.LlamaParseProcessingOptions? processingOptions,
            global::G.LlamaParseFastOptions? fastOptions,
            global::G.LlamaParseAgenticOptions? agenticOptions,
            global::System.Collections.Generic.IList<global::G.LlamaParseWebhookConfiguration>? webhookConfigurations,
            global::G.LlamaParseInputOptions? inputOptions,
            global::G.LlamaParseCropBox? cropBox,
            global::G.LlamaParsePageRanges? pageRanges,
            bool? disableCache,
            global::G.LlamaParseOutputOptions? outputOptions,
            global::G.LlamaParseProcessingControl? processingControl,
            string? fileId,
            string? sourceUrl,
            string? httpProxy)
        {
            this.Tier = tier;
            this.Version = version;
            this.ClientName = clientName;
            this.ProcessingOptions = processingOptions;
            this.FastOptions = fastOptions;
            this.AgenticOptions = agenticOptions;
            this.WebhookConfigurations = webhookConfigurations;
            this.InputOptions = inputOptions;
            this.CropBox = cropBox;
            this.PageRanges = pageRanges;
            this.DisableCache = disableCache;
            this.OutputOptions = outputOptions;
            this.ProcessingControl = processingControl;
            this.FileId = fileId;
            this.SourceUrl = sourceUrl;
            this.HttpProxy = httpProxy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParseRequestConfiguration" /> class.
        /// </summary>
        public ParseRequestConfiguration()
        {
        }
    }
}