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
        public const string DefaultBaseUrl = "https://api.assemblyai.com";

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
        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.TranscriptReadyStatusJsonConverter(),
                    new global::G.JsonConverters.TranscriptReadyStatusNullableJsonConverter(),
                    new global::G.JsonConverters.RedactedAudioStatusJsonConverter(),
                    new global::G.JsonConverters.RedactedAudioStatusNullableJsonConverter(),
                    new global::G.JsonConverters.SubtitleFormatJsonConverter(),
                    new global::G.JsonConverters.SubtitleFormatNullableJsonConverter(),
                    new global::G.JsonConverters.TranscriptLanguageCodeJsonConverter(),
                    new global::G.JsonConverters.TranscriptLanguageCodeNullableJsonConverter(),
                    new global::G.JsonConverters.SpeechModel2JsonConverter(),
                    new global::G.JsonConverters.SpeechModel2NullableJsonConverter(),
                    new global::G.JsonConverters.TranscriptBoostParamJsonConverter(),
                    new global::G.JsonConverters.TranscriptBoostParamNullableJsonConverter(),
                    new global::G.JsonConverters.RedactPiiAudioQualityJsonConverter(),
                    new global::G.JsonConverters.RedactPiiAudioQualityNullableJsonConverter(),
                    new global::G.JsonConverters.PiiPolicyJsonConverter(),
                    new global::G.JsonConverters.PiiPolicyNullableJsonConverter(),
                    new global::G.JsonConverters.SubstitutionPolicyJsonConverter(),
                    new global::G.JsonConverters.SubstitutionPolicyNullableJsonConverter(),
                    new global::G.JsonConverters.SummaryModelJsonConverter(),
                    new global::G.JsonConverters.SummaryModelNullableJsonConverter(),
                    new global::G.JsonConverters.SummaryTypeJsonConverter(),
                    new global::G.JsonConverters.SummaryTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TranscriptStatusJsonConverter(),
                    new global::G.JsonConverters.TranscriptStatusNullableJsonConverter(),
                    new global::G.JsonConverters.AudioIntelligenceModelStatusJsonConverter(),
                    new global::G.JsonConverters.AudioIntelligenceModelStatusNullableJsonConverter(),
                    new global::G.JsonConverters.SentimentJsonConverter(),
                    new global::G.JsonConverters.SentimentNullableJsonConverter(),
                    new global::G.JsonConverters.EntityTypeJsonConverter(),
                    new global::G.JsonConverters.EntityTypeNullableJsonConverter(),
                    new global::G.JsonConverters.LemurModelJsonConverter(),
                    new global::G.JsonConverters.LemurModelNullableJsonConverter(),
                    new global::G.JsonConverters.TranscriptWebhookNotificationJsonConverter(),
                    new global::G.JsonConverters.RedactedAudioNotificationJsonConverter(),
                    new global::G.JsonConverters.OneOfJsonConverterFactory2(),
                    new global::G.JsonConverters.AnyOfJsonConverterFactory2(),
                    new global::G.JsonConverters.TranscriptParamsJsonConverter(),
                    new global::G.JsonConverters.LemurStringResponseJsonConverter(),
                    new global::G.JsonConverters.LemurTaskResponseJsonConverter(),
                    new global::G.JsonConverters.LemurSummaryResponseJsonConverter(),
                    new global::G.JsonConverters.LemurActionItemsResponseJsonConverter(),
                    new global::G.JsonConverters.LemurQuestionAnswerResponseJsonConverter(),
                    new global::G.JsonConverters.LemurResponseJsonConverter(),
                    new global::G.JsonConverters.LemurTaskParamsJsonConverter(),
                    new global::G.JsonConverters.LemurSummaryParamsJsonConverter(),
                    new global::G.JsonConverters.LemurQuestionAnswerParamsJsonConverter(),
                    new global::G.JsonConverters.LemurActionItemsParamsJsonConverter(),
                }
            };


        /// <summary>
        /// Transcript related operations
        /// </summary>
        public TranscriptClient Transcript => new TranscriptClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// LeMUR related operations
        /// </summary>
        public LeMURClient LeMUR => new LeMURClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Streaming Speech-to-Text
        /// </summary>
        public StreamingClient Streaming => new StreamingClient(HttpClient, authorizations: Authorizations)
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
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::G.EndPointAuthorization>();
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