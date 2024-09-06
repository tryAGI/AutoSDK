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
                    new global::OpenApiGenerator.JsonConverters.TranscriptReadyStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.TranscriptReadyStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RedactedAudioStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RedactedAudioStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SubtitleFormatJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SubtitleFormatNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.TranscriptLanguageCodeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.TranscriptLanguageCodeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SpeechModel2JsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SpeechModel2NullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.TranscriptBoostParamJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.TranscriptBoostParamNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RedactPiiAudioQualityJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RedactPiiAudioQualityNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PiiPolicyJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PiiPolicyNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SubstitutionPolicyJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SubstitutionPolicyNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SummaryModelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SummaryModelNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SummaryTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SummaryTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.TranscriptStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.TranscriptStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AudioIntelligenceModelStatusJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AudioIntelligenceModelStatusNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SentimentJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SentimentNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EntityTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.EntityTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.LemurModelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.LemurModelNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.TranscriptWebhookNotificationJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RedactedAudioNotificationJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.OneOfJsonConverterFactory2(),
                    new global::OpenApiGenerator.JsonConverters.AnyOfJsonConverterFactory2(),
                    new global::OpenApiGenerator.JsonConverters.TranscriptParamsJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.LemurStringResponseJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.LemurTaskResponseJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.LemurSummaryResponseJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.LemurActionItemsResponseJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.LemurQuestionAnswerResponseJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.LemurResponseJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.LemurTaskParamsJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.LemurSummaryParamsJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.LemurQuestionAnswerParamsJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.LemurActionItemsParamsJsonConverter(),
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