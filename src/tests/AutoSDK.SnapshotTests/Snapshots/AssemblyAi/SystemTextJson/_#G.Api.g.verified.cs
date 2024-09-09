//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// AssemblyAI API<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::System.IDisposable
    {
        /// <summary>
        /// AssemblyAI API
        /// </summary>
        public const string BaseUrl = "https://api.assemblyai.com";

        private readonly global::System.Net.Http.HttpClient _httpClient;
        private readonly global::System.Text.Json.JsonSerializerOptions _jsonSerializerOptions;


        /// <summary>
        /// Transcript related operations
        /// </summary>
        public TranscriptClient Transcript => new TranscriptClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// LeMUR related operations
        /// </summary>
        public LeMURClient LeMUR => new LeMURClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Streaming Speech-to-Text
        /// </summary>
        public StreamingClient Streaming => new StreamingClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param>
        /// <param name="jsonSerializerOptions"></param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null
            )
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(BaseUrl);
            _jsonSerializerOptions = _jsonSerializerOptions ?? new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::AutoSDK.JsonConverters.TranscriptReadyStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.TranscriptReadyStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RedactedAudioStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.RedactedAudioStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.SubtitleFormatJsonConverter(),
                    new global::AutoSDK.JsonConverters.SubtitleFormatNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.TranscriptLanguageCodeJsonConverter(),
                    new global::AutoSDK.JsonConverters.TranscriptLanguageCodeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.SpeechModel2JsonConverter(),
                    new global::AutoSDK.JsonConverters.SpeechModel2NullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.TranscriptBoostParamJsonConverter(),
                    new global::AutoSDK.JsonConverters.TranscriptBoostParamNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RedactPiiAudioQualityJsonConverter(),
                    new global::AutoSDK.JsonConverters.RedactPiiAudioQualityNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.PiiPolicyJsonConverter(),
                    new global::AutoSDK.JsonConverters.PiiPolicyNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.SubstitutionPolicyJsonConverter(),
                    new global::AutoSDK.JsonConverters.SubstitutionPolicyNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.SummaryModelJsonConverter(),
                    new global::AutoSDK.JsonConverters.SummaryModelNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.SummaryTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.SummaryTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.TranscriptStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.TranscriptStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.AudioIntelligenceModelStatusJsonConverter(),
                    new global::AutoSDK.JsonConverters.AudioIntelligenceModelStatusNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.SentimentJsonConverter(),
                    new global::AutoSDK.JsonConverters.SentimentNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.EntityTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.EntityTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.LemurModelJsonConverter(),
                    new global::AutoSDK.JsonConverters.LemurModelNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.TranscriptWebhookNotificationJsonConverter(),
                    new global::AutoSDK.JsonConverters.RedactedAudioNotificationJsonConverter(),
                    new global::AutoSDK.JsonConverters.OneOfJsonConverterFactory2(),
                    new global::AutoSDK.JsonConverters.AnyOfJsonConverterFactory2(),
                    new global::AutoSDK.JsonConverters.TranscriptParamsJsonConverter(),
                    new global::AutoSDK.JsonConverters.LemurStringResponseJsonConverter(),
                    new global::AutoSDK.JsonConverters.LemurTaskResponseJsonConverter(),
                    new global::AutoSDK.JsonConverters.LemurSummaryResponseJsonConverter(),
                    new global::AutoSDK.JsonConverters.LemurActionItemsResponseJsonConverter(),
                    new global::AutoSDK.JsonConverters.LemurQuestionAnswerResponseJsonConverter(),
                    new global::AutoSDK.JsonConverters.LemurResponseJsonConverter(),
                    new global::AutoSDK.JsonConverters.LemurTaskParamsJsonConverter(),
                    new global::AutoSDK.JsonConverters.LemurSummaryParamsJsonConverter(),
                    new global::AutoSDK.JsonConverters.LemurQuestionAnswerParamsJsonConverter(),
                    new global::AutoSDK.JsonConverters.LemurActionItemsParamsJsonConverter(),
                }
            };

            Initialized(_httpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
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