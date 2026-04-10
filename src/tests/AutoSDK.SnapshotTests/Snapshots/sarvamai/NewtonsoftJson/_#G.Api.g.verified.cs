//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Indian language AI platform providing speech-to-text, text-to-speech, translation,<br/>
    /// transliteration, and language detection for 22+ Indian languages.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// Production server
        /// </summary>
        public const string DefaultBaseUrl = "https://api.sarvam.ai/";

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
                    new global::G.JsonConverters.ErrorDetailCodeJsonConverter(),

                    new global::G.JsonConverters.ErrorDetailCodeNullableJsonConverter(),

                    new global::G.JsonConverters.TranslateRequestSourceLanguageCodeJsonConverter(),

                    new global::G.JsonConverters.TranslateRequestSourceLanguageCodeNullableJsonConverter(),

                    new global::G.JsonConverters.TranslateRequestTargetLanguageCodeJsonConverter(),

                    new global::G.JsonConverters.TranslateRequestTargetLanguageCodeNullableJsonConverter(),

                    new global::G.JsonConverters.TranslateRequestSpeakerGenderJsonConverter(),

                    new global::G.JsonConverters.TranslateRequestSpeakerGenderNullableJsonConverter(),

                    new global::G.JsonConverters.TranslateRequestModeJsonConverter(),

                    new global::G.JsonConverters.TranslateRequestModeNullableJsonConverter(),

                    new global::G.JsonConverters.TranslateRequestModelJsonConverter(),

                    new global::G.JsonConverters.TranslateRequestModelNullableJsonConverter(),

                    new global::G.JsonConverters.TranslateRequestOutputScriptJsonConverter(),

                    new global::G.JsonConverters.TranslateRequestOutputScriptNullableJsonConverter(),

                    new global::G.JsonConverters.TranslateRequestNumeralsFormatJsonConverter(),

                    new global::G.JsonConverters.TranslateRequestNumeralsFormatNullableJsonConverter(),

                    new global::G.JsonConverters.TransliterateRequestSourceLanguageCodeJsonConverter(),

                    new global::G.JsonConverters.TransliterateRequestSourceLanguageCodeNullableJsonConverter(),

                    new global::G.JsonConverters.TransliterateRequestTargetLanguageCodeJsonConverter(),

                    new global::G.JsonConverters.TransliterateRequestTargetLanguageCodeNullableJsonConverter(),

                    new global::G.JsonConverters.TransliterateRequestNumeralsFormatJsonConverter(),

                    new global::G.JsonConverters.TransliterateRequestNumeralsFormatNullableJsonConverter(),

                    new global::G.JsonConverters.TransliterateRequestSpokenFormNumeralsLanguageJsonConverter(),

                    new global::G.JsonConverters.TransliterateRequestSpokenFormNumeralsLanguageNullableJsonConverter(),

                    new global::G.JsonConverters.TextToSpeechRequestTargetLanguageCodeJsonConverter(),

                    new global::G.JsonConverters.TextToSpeechRequestTargetLanguageCodeNullableJsonConverter(),

                    new global::G.JsonConverters.TextToSpeechRequestModelJsonConverter(),

                    new global::G.JsonConverters.TextToSpeechRequestModelNullableJsonConverter(),

                    new global::G.JsonConverters.TextToSpeechRequestSpeakerJsonConverter(),

                    new global::G.JsonConverters.TextToSpeechRequestSpeakerNullableJsonConverter(),

                    new global::G.JsonConverters.TextToSpeechRequestSpeechSampleRateJsonConverter(),

                    new global::G.JsonConverters.TextToSpeechRequestSpeechSampleRateNullableJsonConverter(),

                    new global::G.JsonConverters.TextToSpeechRequestOutputAudioCodecJsonConverter(),

                    new global::G.JsonConverters.TextToSpeechRequestOutputAudioCodecNullableJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionMessageRoleJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionMessageRoleNullableJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionToolCallTypeJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionToolCallTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionToolTypeJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionToolTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionRequestModelJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionRequestModelNullableJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionRequestReasoningEffortJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionRequestReasoningEffortNullableJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionRequestToolChoiceJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionRequestToolChoiceNullableJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionChoiceFinishReasonJsonConverter(),

                    new global::G.JsonConverters.ChatCompletionChoiceFinishReasonNullableJsonConverter(),

                    new global::G.JsonConverters.TranscribeSpeechRequestModelJsonConverter(),

                    new global::G.JsonConverters.TranscribeSpeechRequestModelNullableJsonConverter(),

                    new global::G.JsonConverters.TranscribeSpeechRequestModeJsonConverter(),

                    new global::G.JsonConverters.TranscribeSpeechRequestModeNullableJsonConverter(),

                    new global::G.JsonConverters.TranscribeSpeechRequestLanguageCodeJsonConverter(),

                    new global::G.JsonConverters.TranscribeSpeechRequestLanguageCodeNullableJsonConverter(),

                    new global::G.JsonConverters.TranscribeSpeechRequestInputAudioCodecJsonConverter(),

                    new global::G.JsonConverters.TranscribeSpeechRequestInputAudioCodecNullableJsonConverter(),

                    new global::G.JsonConverters.TranslateSpeechRequestModelJsonConverter(),

                    new global::G.JsonConverters.TranslateSpeechRequestModelNullableJsonConverter(),

                    new global::G.JsonConverters.TranslateSpeechRequestLanguageCodeJsonConverter(),

                    new global::G.JsonConverters.TranslateSpeechRequestLanguageCodeNullableJsonConverter(),

                    new global::G.JsonConverters.TranslateSpeechRequestInputAudioCodecJsonConverter(),

                    new global::G.JsonConverters.TranslateSpeechRequestInputAudioCodecNullableJsonConverter(),

                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
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