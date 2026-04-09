//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// AssemblyAI API<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// AssemblyAI API
        /// </summary>
        public const string DefaultBaseUrl = "https://api.assemblyai.com/";

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
        public global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; } = new global::Newtonsoft.Json.JsonSerializerSettings
            {
                Converters =
                {
                    new global::G.JsonConverters.RedactedAudioStatusJsonConverter(),

                    new global::G.JsonConverters.RedactedAudioStatusNullableJsonConverter(),

                    new global::G.JsonConverters.SubtitleFormatJsonConverter(),

                    new global::G.JsonConverters.SubtitleFormatNullableJsonConverter(),

                    new global::G.JsonConverters.SummaryModelJsonConverter(),

                    new global::G.JsonConverters.SummaryModelNullableJsonConverter(),

                    new global::G.JsonConverters.SummaryTypeJsonConverter(),

                    new global::G.JsonConverters.SummaryTypeNullableJsonConverter(),

                    new global::G.JsonConverters.TranscriptBoostParamJsonConverter(),

                    new global::G.JsonConverters.TranscriptBoostParamNullableJsonConverter(),

                    new global::G.JsonConverters.SubstitutionPolicyJsonConverter(),

                    new global::G.JsonConverters.SubstitutionPolicyNullableJsonConverter(),

                    new global::G.JsonConverters.RedactPiiAudioQualityJsonConverter(),

                    new global::G.JsonConverters.RedactPiiAudioQualityNullableJsonConverter(),

                    new global::G.JsonConverters.PiiPolicyJsonConverter(),

                    new global::G.JsonConverters.PiiPolicyNullableJsonConverter(),

                    new global::G.JsonConverters.SpeechModel2JsonConverter(),

                    new global::G.JsonConverters.SpeechModel2NullableJsonConverter(),

                    new global::G.JsonConverters.TranscriptLanguageCodeJsonConverter(),

                    new global::G.JsonConverters.TranscriptLanguageCodeNullableJsonConverter(),

                    new global::G.JsonConverters.TranscriptStatusJsonConverter(),

                    new global::G.JsonConverters.TranscriptStatusNullableJsonConverter(),

                    new global::G.JsonConverters.TranscriptReadyStatusJsonConverter(),

                    new global::G.JsonConverters.TranscriptReadyStatusNullableJsonConverter(),

                    new global::G.JsonConverters.EntityTypeJsonConverter(),

                    new global::G.JsonConverters.EntityTypeNullableJsonConverter(),

                    new global::G.JsonConverters.SentimentJsonConverter(),

                    new global::G.JsonConverters.SentimentNullableJsonConverter(),

                    new global::G.JsonConverters.AudioIntelligenceModelStatusJsonConverter(),

                    new global::G.JsonConverters.AudioIntelligenceModelStatusNullableJsonConverter(),

                    new global::G.JsonConverters.LemurModelJsonConverter(),

                    new global::G.JsonConverters.LemurModelNullableJsonConverter(),

                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };


        /// <summary>
        /// 
        /// </summary>
        public FilesClient Files => new FilesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public LemurClient Lemur => new LemurClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public RealtimeClient Realtime => new RealtimeClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TranscriptsClient Transcripts => new TranscriptsClient(HttpClient, authorizations: Authorizations, options: Options)
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