//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Bland AI is an enterprise-grade platform for AI-powered phone calls. It enables sending outbound calls, receiving inbound calls, managing conversational pathways, batch calling, voice selection, and post-call analysis.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// Production API
        /// </summary>
        public const string DefaultBaseUrl = "https://api.bland.ai/";

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
                    new global::G.JsonConverters.SendCallRequestModelJsonConverter(),
                    new global::G.JsonConverters.SendCallRequestModelNullableJsonConverter(),
                    new global::G.JsonConverters.SendCallRequestBackgroundTrackJsonConverter(),
                    new global::G.JsonConverters.SendCallRequestBackgroundTrackNullableJsonConverter(),
                    new global::G.JsonConverters.SendCallRequestWebhookEventJsonConverter(),
                    new global::G.JsonConverters.SendCallRequestWebhookEventNullableJsonConverter(),
                    new global::G.JsonConverters.UpdateInboundNumberRequestModelJsonConverter(),
                    new global::G.JsonConverters.UpdateInboundNumberRequestModelNullableJsonConverter(),
                    new global::G.JsonConverters.UpdateInboundNumberRequestBackgroundTrackJsonConverter(),
                    new global::G.JsonConverters.UpdateInboundNumberRequestBackgroundTrackNullableJsonConverter(),
                    new global::G.JsonConverters.PurchaseNumberRequestCountryCodeJsonConverter(),
                    new global::G.JsonConverters.PurchaseNumberRequestCountryCodeNullableJsonConverter(),
                    new global::G.JsonConverters.VoicemailConfigActionJsonConverter(),
                    new global::G.JsonConverters.VoicemailConfigActionNullableJsonConverter(),
                    new global::G.JsonConverters.SendCallResponseStatusJsonConverter(),
                    new global::G.JsonConverters.SendCallResponseStatusNullableJsonConverter(),
                    new global::G.JsonConverters.CallDetailsQueueStatusJsonConverter(),
                    new global::G.JsonConverters.CallDetailsQueueStatusNullableJsonConverter(),
                    new global::G.JsonConverters.CallDetailsAnsweredByJsonConverter(),
                    new global::G.JsonConverters.CallDetailsAnsweredByNullableJsonConverter(),
                    new global::G.JsonConverters.CallDetailsCallEndedByJsonConverter(),
                    new global::G.JsonConverters.CallDetailsCallEndedByNullableJsonConverter(),
                    new global::G.JsonConverters.CallDetailsStatusJsonConverter(),
                    new global::G.JsonConverters.CallDetailsStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ActiveCallStatusJsonConverter(),
                    new global::G.JsonConverters.ActiveCallStatusNullableJsonConverter(),
                    new global::G.JsonConverters.AnalyzeCallResponseStatusJsonConverter(),
                    new global::G.JsonConverters.AnalyzeCallResponseStatusNullableJsonConverter(),
                    new global::G.JsonConverters.StatusResponseStatusJsonConverter(),
                    new global::G.JsonConverters.StatusResponseStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ErrorResponseStatusJsonConverter(),
                    new global::G.JsonConverters.ErrorResponseStatusNullableJsonConverter(),
                    new global::G.JsonConverters.CreatePathwayResponseStatusJsonConverter(),
                    new global::G.JsonConverters.CreatePathwayResponseStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ListCallsSortByJsonConverter(),
                    new global::G.JsonConverters.ListCallsSortByNullableJsonConverter(),
                    new global::G.JsonConverters.GetCallRecordingContentTypeJsonConverter(),
                    new global::G.JsonConverters.GetCallRecordingContentTypeNullableJsonConverter(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// Account information and billing.
        /// </summary>
        public AccountClient Account => new AccountClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Create and manage batch call campaigns.
        /// </summary>
        public BatchesClient Batches => new BatchesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Send, manage, and analyze AI phone calls.
        /// </summary>
        public CallsClient Calls => new CallsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Phone number management (inbound/outbound).
        /// </summary>
        public NumbersClient Numbers => new NumbersClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Conversational pathway CRUD operations.
        /// </summary>
        public PathwaysClient Pathways => new PathwaysClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Voice listing and management.
        /// </summary>
        public VoicesClient Voices => new VoicesClient(HttpClient, authorizations: Authorizations, options: Options)
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