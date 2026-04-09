//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// Gladia API production URL
        /// </summary>
        public const string DefaultBaseUrl = "https://api.gladia.io/";

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
                    new global::G.JsonConverters.TranscriptionLanguageCodeEnumJsonConverter(),
                    new global::G.JsonConverters.TranscriptionLanguageCodeEnumNullableJsonConverter(),
                    new global::G.JsonConverters.CallbackMethodEnumJsonConverter(),
                    new global::G.JsonConverters.CallbackMethodEnumNullableJsonConverter(),
                    new global::G.JsonConverters.SubtitlesFormatEnumJsonConverter(),
                    new global::G.JsonConverters.SubtitlesFormatEnumNullableJsonConverter(),
                    new global::G.JsonConverters.SubtitlesStyleEnumJsonConverter(),
                    new global::G.JsonConverters.SubtitlesStyleEnumNullableJsonConverter(),
                    new global::G.JsonConverters.TranslationLanguageCodeEnumJsonConverter(),
                    new global::G.JsonConverters.TranslationLanguageCodeEnumNullableJsonConverter(),
                    new global::G.JsonConverters.TranslationModelEnumJsonConverter(),
                    new global::G.JsonConverters.TranslationModelEnumNullableJsonConverter(),
                    new global::G.JsonConverters.SummaryTypesEnumJsonConverter(),
                    new global::G.JsonConverters.SummaryTypesEnumNullableJsonConverter(),
                    new global::G.JsonConverters.PiiRedactionEntityTypeEnumJsonConverter(),
                    new global::G.JsonConverters.PiiRedactionEntityTypeEnumNullableJsonConverter(),
                    new global::G.JsonConverters.PiiRedactionConfigDTOProcessedTextTypeJsonConverter(),
                    new global::G.JsonConverters.PiiRedactionConfigDTOProcessedTextTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PreRecordedResponseStatusJsonConverter(),
                    new global::G.JsonConverters.PreRecordedResponseStatusNullableJsonConverter(),
                    new global::G.JsonConverters.PreRecordedResponseKindJsonConverter(),
                    new global::G.JsonConverters.PreRecordedResponseKindNullableJsonConverter(),
                    new global::G.JsonConverters.CallbackTranscriptionSuccessPayloadEventJsonConverter(),
                    new global::G.JsonConverters.CallbackTranscriptionSuccessPayloadEventNullableJsonConverter(),
                    new global::G.JsonConverters.CallbackTranscriptionErrorPayloadEventJsonConverter(),
                    new global::G.JsonConverters.CallbackTranscriptionErrorPayloadEventNullableJsonConverter(),
                    new global::G.JsonConverters.StreamingSupportedEncodingEnumJsonConverter(),
                    new global::G.JsonConverters.StreamingSupportedEncodingEnumNullableJsonConverter(),
                    new global::G.JsonConverters.StreamingSupportedModelsJsonConverter(),
                    new global::G.JsonConverters.StreamingSupportedModelsNullableJsonConverter(),
                    new global::G.JsonConverters.StreamingResponseStatusJsonConverter(),
                    new global::G.JsonConverters.StreamingResponseStatusNullableJsonConverter(),
                    new global::G.JsonConverters.StreamingResponseKindJsonConverter(),
                    new global::G.JsonConverters.StreamingResponseKindNullableJsonConverter(),
                    new global::G.JsonConverters.ListTranscriptionResponseItemsDiscriminatorKindJsonConverter(),
                    new global::G.JsonConverters.ListTranscriptionResponseItemsDiscriminatorKindNullableJsonConverter(),
                    new global::G.JsonConverters.ListHistoryResponseItemsDiscriminatorKindJsonConverter(),
                    new global::G.JsonConverters.ListHistoryResponseItemsDiscriminatorKindNullableJsonConverter(),
                    new global::G.JsonConverters.AudioChunkActionTypeJsonConverter(),
                    new global::G.JsonConverters.AudioChunkActionTypeNullableJsonConverter(),
                    new global::G.JsonConverters.StopRecordingActionTypeJsonConverter(),
                    new global::G.JsonConverters.StopRecordingActionTypeNullableJsonConverter(),
                    new global::G.JsonConverters.AudioChunkAckMessageTypeJsonConverter(),
                    new global::G.JsonConverters.AudioChunkAckMessageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CallbackLiveAudioChunkAckMessageEventJsonConverter(),
                    new global::G.JsonConverters.CallbackLiveAudioChunkAckMessageEventNullableJsonConverter(),
                    new global::G.JsonConverters.EndRecordingMessageTypeJsonConverter(),
                    new global::G.JsonConverters.EndRecordingMessageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CallbackLiveEndRecordingMessageEventJsonConverter(),
                    new global::G.JsonConverters.CallbackLiveEndRecordingMessageEventNullableJsonConverter(),
                    new global::G.JsonConverters.EndSessionMessageTypeJsonConverter(),
                    new global::G.JsonConverters.EndSessionMessageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CallbackLiveEndSessionMessageEventJsonConverter(),
                    new global::G.JsonConverters.CallbackLiveEndSessionMessageEventNullableJsonConverter(),
                    new global::G.JsonConverters.TranslationMessageTypeJsonConverter(),
                    new global::G.JsonConverters.TranslationMessageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CallbackLiveTranslationMessageEventJsonConverter(),
                    new global::G.JsonConverters.CallbackLiveTranslationMessageEventNullableJsonConverter(),
                    new global::G.JsonConverters.NamedEntityRecognitionMessageTypeJsonConverter(),
                    new global::G.JsonConverters.NamedEntityRecognitionMessageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CallbackLiveNamedEntityRecognitionMessageEventJsonConverter(),
                    new global::G.JsonConverters.CallbackLiveNamedEntityRecognitionMessageEventNullableJsonConverter(),
                    new global::G.JsonConverters.PostChapterizationMessageTypeJsonConverter(),
                    new global::G.JsonConverters.PostChapterizationMessageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CallbackLivePostChapterizationMessageEventJsonConverter(),
                    new global::G.JsonConverters.CallbackLivePostChapterizationMessageEventNullableJsonConverter(),
                    new global::G.JsonConverters.PostFinalTranscriptMessageTypeJsonConverter(),
                    new global::G.JsonConverters.PostFinalTranscriptMessageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CallbackLivePostFinalTranscriptMessageEventJsonConverter(),
                    new global::G.JsonConverters.CallbackLivePostFinalTranscriptMessageEventNullableJsonConverter(),
                    new global::G.JsonConverters.PostSummarizationMessageTypeJsonConverter(),
                    new global::G.JsonConverters.PostSummarizationMessageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CallbackLivePostSummarizationMessageEventJsonConverter(),
                    new global::G.JsonConverters.CallbackLivePostSummarizationMessageEventNullableJsonConverter(),
                    new global::G.JsonConverters.PostTranscriptMessageTypeJsonConverter(),
                    new global::G.JsonConverters.PostTranscriptMessageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CallbackLivePostTranscriptMessageEventJsonConverter(),
                    new global::G.JsonConverters.CallbackLivePostTranscriptMessageEventNullableJsonConverter(),
                    new global::G.JsonConverters.SentimentAnalysisMessageTypeJsonConverter(),
                    new global::G.JsonConverters.SentimentAnalysisMessageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CallbackLiveSentimentAnalysisMessageEventJsonConverter(),
                    new global::G.JsonConverters.CallbackLiveSentimentAnalysisMessageEventNullableJsonConverter(),
                    new global::G.JsonConverters.StartRecordingMessageTypeJsonConverter(),
                    new global::G.JsonConverters.StartRecordingMessageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CallbackLiveStartRecordingMessageEventJsonConverter(),
                    new global::G.JsonConverters.CallbackLiveStartRecordingMessageEventNullableJsonConverter(),
                    new global::G.JsonConverters.StartSessionMessageTypeJsonConverter(),
                    new global::G.JsonConverters.StartSessionMessageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CallbackLiveStartSessionMessageEventJsonConverter(),
                    new global::G.JsonConverters.CallbackLiveStartSessionMessageEventNullableJsonConverter(),
                    new global::G.JsonConverters.StopRecordingAckMessageTypeJsonConverter(),
                    new global::G.JsonConverters.StopRecordingAckMessageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CallbackLiveStopRecordingAckMessageEventJsonConverter(),
                    new global::G.JsonConverters.CallbackLiveStopRecordingAckMessageEventNullableJsonConverter(),
                    new global::G.JsonConverters.TranscriptMessageTypeJsonConverter(),
                    new global::G.JsonConverters.TranscriptMessageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CallbackLiveTranscriptMessageEventJsonConverter(),
                    new global::G.JsonConverters.CallbackLiveTranscriptMessageEventNullableJsonConverter(),
                    new global::G.JsonConverters.SpeechStartMessageTypeJsonConverter(),
                    new global::G.JsonConverters.SpeechStartMessageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CallbackLiveSpeechStartMessageEventJsonConverter(),
                    new global::G.JsonConverters.CallbackLiveSpeechStartMessageEventNullableJsonConverter(),
                    new global::G.JsonConverters.SpeechEndMessageTypeJsonConverter(),
                    new global::G.JsonConverters.SpeechEndMessageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CallbackLiveSpeechEndMessageEventJsonConverter(),
                    new global::G.JsonConverters.CallbackLiveSpeechEndMessageEventNullableJsonConverter(),
                    new global::G.JsonConverters.StreamingSupportedRegionsJsonConverter(),
                    new global::G.JsonConverters.StreamingSupportedRegionsNullableJsonConverter(),
                    new global::G.JsonConverters.WebhookTranscriptionCreatedPayloadEventJsonConverter(),
                    new global::G.JsonConverters.WebhookTranscriptionCreatedPayloadEventNullableJsonConverter(),
                    new global::G.JsonConverters.WebhookTranscriptionSuccessPayloadEventJsonConverter(),
                    new global::G.JsonConverters.WebhookTranscriptionSuccessPayloadEventNullableJsonConverter(),
                    new global::G.JsonConverters.WebhookTranscriptionErrorPayloadEventJsonConverter(),
                    new global::G.JsonConverters.WebhookTranscriptionErrorPayloadEventNullableJsonConverter(),
                    new global::G.JsonConverters.WebhookLiveStartSessionPayloadEventJsonConverter(),
                    new global::G.JsonConverters.WebhookLiveStartSessionPayloadEventNullableJsonConverter(),
                    new global::G.JsonConverters.WebhookLiveStartRecordingPayloadEventJsonConverter(),
                    new global::G.JsonConverters.WebhookLiveStartRecordingPayloadEventNullableJsonConverter(),
                    new global::G.JsonConverters.WebhookLiveEndRecordingPayloadEventJsonConverter(),
                    new global::G.JsonConverters.WebhookLiveEndRecordingPayloadEventNullableJsonConverter(),
                    new global::G.JsonConverters.WebhookLiveEndSessionPayloadEventJsonConverter(),
                    new global::G.JsonConverters.WebhookLiveEndSessionPayloadEventNullableJsonConverter(),
                    new global::G.JsonConverters.AudioToTextControllerAudioTranscriptionRequestLanguageBehaviourJsonConverter(),
                    new global::G.JsonConverters.AudioToTextControllerAudioTranscriptionRequestLanguageBehaviourNullableJsonConverter(),
                    new global::G.JsonConverters.AudioToTextControllerAudioTranscriptionRequestLanguageJsonConverter(),
                    new global::G.JsonConverters.AudioToTextControllerAudioTranscriptionRequestLanguageNullableJsonConverter(),
                    new global::G.JsonConverters.AudioToTextControllerAudioTranscriptionRequestTargetTranslationLanguageJsonConverter(),
                    new global::G.JsonConverters.AudioToTextControllerAudioTranscriptionRequestTargetTranslationLanguageNullableJsonConverter(),
                    new global::G.JsonConverters.AudioToTextControllerAudioTranscriptionRequestOutputFormatJsonConverter(),
                    new global::G.JsonConverters.AudioToTextControllerAudioTranscriptionRequestOutputFormatNullableJsonConverter(),
                    new global::G.JsonConverters.VideoToTextControllerVideoTranscriptionRequestLanguageBehaviourJsonConverter(),
                    new global::G.JsonConverters.VideoToTextControllerVideoTranscriptionRequestLanguageBehaviourNullableJsonConverter(),
                    new global::G.JsonConverters.VideoToTextControllerVideoTranscriptionRequestLanguageJsonConverter(),
                    new global::G.JsonConverters.VideoToTextControllerVideoTranscriptionRequestLanguageNullableJsonConverter(),
                    new global::G.JsonConverters.VideoToTextControllerVideoTranscriptionRequestTargetTranslationLanguageJsonConverter(),
                    new global::G.JsonConverters.VideoToTextControllerVideoTranscriptionRequestTargetTranslationLanguageNullableJsonConverter(),
                    new global::G.JsonConverters.VideoToTextControllerVideoTranscriptionRequestOutputFormatJsonConverter(),
                    new global::G.JsonConverters.VideoToTextControllerVideoTranscriptionRequestOutputFormatNullableJsonConverter(),
                    new global::G.JsonConverters.PreRecordedControllerGetPreRecordedJobsV2StatuJsonConverter(),
                    new global::G.JsonConverters.PreRecordedControllerGetPreRecordedJobsV2StatuNullableJsonConverter(),
                    new global::G.JsonConverters.TranscriptionControllerListV2StatuJsonConverter(),
                    new global::G.JsonConverters.TranscriptionControllerListV2StatuNullableJsonConverter(),
                    new global::G.JsonConverters.TranscriptionControllerListV2KindItemJsonConverter(),
                    new global::G.JsonConverters.TranscriptionControllerListV2KindItemNullableJsonConverter(),
                    new global::G.JsonConverters.HistoryControllerGetListV1StatuJsonConverter(),
                    new global::G.JsonConverters.HistoryControllerGetListV1StatuNullableJsonConverter(),
                    new global::G.JsonConverters.HistoryControllerGetListV1KindItemJsonConverter(),
                    new global::G.JsonConverters.HistoryControllerGetListV1KindItemNullableJsonConverter(),
                    new global::G.JsonConverters.StreamingControllerGetStreamingJobsV2StatuJsonConverter(),
                    new global::G.JsonConverters.StreamingControllerGetStreamingJobsV2StatuNullableJsonConverter(),
                    new global::G.JsonConverters.TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKindJsonConverter(),
                    new global::G.JsonConverters.TranscriptionControllerGetTranscriptV2ResponseDiscriminatorKindNullableJsonConverter(),
                    new global::G.JsonConverters.TranscriptionControllerGetTranscriptV2ResponseJsonConverter(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.CustomVocabularyEntryDTO, string>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.PreRecordedResponse, global::G.StreamingResponse>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.PreRecordedResponse, global::G.StreamingResponse>(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public AudioToTextClient AudioToText => new AudioToTextClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FileManagementClient FileManagement => new FileManagementClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public JobHistoryClient JobHistory => new JobHistoryClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public LiveV2Client LiveV2 => new LiveV2Client(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PreRecordedV2Client PreRecordedV2 => new PreRecordedV2Client(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TranscriptionV1Client TranscriptionV1 => new TranscriptionV1Client(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TranscriptionV2Client TranscriptionV2 => new TranscriptionV2Client(HttpClient, authorizations: Authorizations, options: Options)
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