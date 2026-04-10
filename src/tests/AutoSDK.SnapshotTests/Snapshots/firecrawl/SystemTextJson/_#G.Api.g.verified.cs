//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API for interacting with Firecrawl services to perform web scraping and crawling tasks.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.firecrawl.dev/v1";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::G.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif

        /// <inheritdoc/>
        public global::G.AutoSDKClientOptions Options { get; }
        /// <summary>
        /// 
        /// </summary>
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.ScrapeOptionsFormatJsonConverter(),
                    new global::G.JsonConverters.ScrapeOptionsFormatNullableJsonConverter(),
                    new global::G.JsonConverters.ScrapeOptionsActionWaitTypeJsonConverter(),
                    new global::G.JsonConverters.ScrapeOptionsActionWaitTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScrapeOptionsActionScreenshotTypeJsonConverter(),
                    new global::G.JsonConverters.ScrapeOptionsActionScreenshotTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScrapeOptionsActionClickTypeJsonConverter(),
                    new global::G.JsonConverters.ScrapeOptionsActionClickTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScrapeOptionsActionWriteTextTypeJsonConverter(),
                    new global::G.JsonConverters.ScrapeOptionsActionWriteTextTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScrapeOptionsActionPressAKeyTypeJsonConverter(),
                    new global::G.JsonConverters.ScrapeOptionsActionPressAKeyTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScrapeOptionsActionScrollTypeJsonConverter(),
                    new global::G.JsonConverters.ScrapeOptionsActionScrollTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScrapeOptionsActionScrollDirectionJsonConverter(),
                    new global::G.JsonConverters.ScrapeOptionsActionScrollDirectionNullableJsonConverter(),
                    new global::G.JsonConverters.ScrapeOptionsActionScrapeTypeJsonConverter(),
                    new global::G.JsonConverters.ScrapeOptionsActionScrapeTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScrapeOptionsActionExecuteJavaScriptTypeJsonConverter(),
                    new global::G.JsonConverters.ScrapeOptionsActionExecuteJavaScriptTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScrapeOptionsProxyJsonConverter(),
                    new global::G.JsonConverters.ScrapeOptionsProxyNullableJsonConverter(),
                    new global::G.JsonConverters.ScrapeOptionsChangeTrackingOptionsModeJsonConverter(),
                    new global::G.JsonConverters.ScrapeOptionsChangeTrackingOptionsModeNullableJsonConverter(),
                    new global::G.JsonConverters.ScrapeResponseDataChangeTrackingChangeStatusJsonConverter(),
                    new global::G.JsonConverters.ScrapeResponseDataChangeTrackingChangeStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ScrapeResponseDataChangeTrackingVisibilityJsonConverter(),
                    new global::G.JsonConverters.ScrapeResponseDataChangeTrackingVisibilityNullableJsonConverter(),
                    new global::G.JsonConverters.ExtractStatusResponseStatusJsonConverter(),
                    new global::G.JsonConverters.ExtractStatusResponseStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ScrapeAndExtractFromUrlsRequestWebhookEventJsonConverter(),
                    new global::G.JsonConverters.ScrapeAndExtractFromUrlsRequestWebhookEventNullableJsonConverter(),
                    new global::G.JsonConverters.CrawlUrlsRequestWebhookEventJsonConverter(),
                    new global::G.JsonConverters.CrawlUrlsRequestWebhookEventNullableJsonConverter(),
                    new global::G.JsonConverters.StartDeepResearchRequestFormatJsonConverter(),
                    new global::G.JsonConverters.StartDeepResearchRequestFormatNullableJsonConverter(),
                    new global::G.JsonConverters.SearchAndScrapeRequestScrapeOptionsFormatJsonConverter(),
                    new global::G.JsonConverters.SearchAndScrapeRequestScrapeOptionsFormatNullableJsonConverter(),
                    new global::G.JsonConverters.CancelCrawlResponseStatusJsonConverter(),
                    new global::G.JsonConverters.CancelCrawlResponseStatusNullableJsonConverter(),
                    new global::G.JsonConverters.GetDeepResearchStatusResponseDataStatusJsonConverter(),
                    new global::G.JsonConverters.GetDeepResearchStatusResponseDataStatusNullableJsonConverter(),
                    new global::G.JsonConverters.GetLLMsTxtStatusResponseStatusJsonConverter(),
                    new global::G.JsonConverters.GetLLMsTxtStatusResponseStatusNullableJsonConverter(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.ScrapeOptionsActionWait, global::G.ScrapeOptionsActionScreenshot, global::G.ScrapeOptionsActionClick, global::G.ScrapeOptionsActionWriteText, global::G.ScrapeOptionsActionPressAKey, global::G.ScrapeOptionsActionScroll, global::G.ScrapeOptionsActionScrape, global::G.ScrapeOptionsActionExecuteJavaScript>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.ScrapeAndExtractFromUrlRequest2, global::G.ScrapeOptions>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.ScrapeAndExtractFromUrlsRequest2, global::G.ScrapeOptions>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public BillingClient Billing => new BillingClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CrawlingClient Crawling => new CrawlingClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ExtractionClient Extraction => new ExtractionClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public LLMsTxtClient LLMsTxt => new LLMsTxtClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public MappingClient Mapping => new MappingClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ResearchClient Research => new ResearchClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ScrapingClient Scraping => new ScrapingClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SearchClient Search => new SearchClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::G.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri,
                authorizations,
                options: null,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::G.EndPointAuthorization>? authorizations = null,
            global::G.AutoSDKClientOptions? options = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::G.EndPointAuthorization>();
            Options = options ?? new global::G.AutoSDKClientOptions();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}