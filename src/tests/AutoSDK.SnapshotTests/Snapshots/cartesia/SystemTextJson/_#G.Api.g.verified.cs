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
        /// Production
        /// </summary>
        public const string DefaultBaseUrl = "https://api.cartesia.ai/";

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
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.AgentCallStatusJsonConverter(),
                    new global::G.JsonConverters.AgentCallStatusNullableJsonConverter(),
                    new global::G.JsonConverters.AgentMetricResultStatusJsonConverter(),
                    new global::G.JsonConverters.AgentMetricResultStatusNullableJsonConverter(),
                    new global::G.JsonConverters.FineTuneStatusJsonConverter(),
                    new global::G.JsonConverters.FineTuneStatusNullableJsonConverter(),
                    new global::G.JsonConverters.TimestampGranularityJsonConverter(),
                    new global::G.JsonConverters.TimestampGranularityNullableJsonConverter(),
                    new global::G.JsonConverters.StreamingTranscriptionResponseVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.StreamingTranscriptionResponseVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.StreamingTranscriptionResponseVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.StreamingTranscriptionResponseVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.StreamingTranscriptionResponseVariant3TypeJsonConverter(),
                    new global::G.JsonConverters.StreamingTranscriptionResponseVariant3TypeNullableJsonConverter(),
                    new global::G.JsonConverters.StreamingTranscriptionResponseVariant4TypeJsonConverter(),
                    new global::G.JsonConverters.StreamingTranscriptionResponseVariant4TypeNullableJsonConverter(),
                    new global::G.JsonConverters.STTEncodingJsonConverter(),
                    new global::G.JsonConverters.STTEncodingNullableJsonConverter(),
                    new global::G.JsonConverters.ModelSpeedJsonConverter(),
                    new global::G.JsonConverters.ModelSpeedNullableJsonConverter(),
                    new global::G.JsonConverters.WebSocketResponseVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.WebSocketResponseVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.WebSocketResponseVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.WebSocketResponseVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.WebSocketResponseVariant3TypeJsonConverter(),
                    new global::G.JsonConverters.WebSocketResponseVariant3TypeNullableJsonConverter(),
                    new global::G.JsonConverters.WebSocketResponseVariant4TypeJsonConverter(),
                    new global::G.JsonConverters.WebSocketResponseVariant4TypeNullableJsonConverter(),
                    new global::G.JsonConverters.WebSocketResponseVariant5TypeJsonConverter(),
                    new global::G.JsonConverters.WebSocketResponseVariant5TypeNullableJsonConverter(),
                    new global::G.JsonConverters.WebSocketResponseVariant6TypeJsonConverter(),
                    new global::G.JsonConverters.WebSocketResponseVariant6TypeNullableJsonConverter(),
                    new global::G.JsonConverters.WebSocketRawOutputFormatContainerJsonConverter(),
                    new global::G.JsonConverters.WebSocketRawOutputFormatContainerNullableJsonConverter(),
                    new global::G.JsonConverters.EmotionJsonConverter(),
                    new global::G.JsonConverters.EmotionNullableJsonConverter(),
                    new global::G.JsonConverters.SupportedLanguageJsonConverter(),
                    new global::G.JsonConverters.SupportedLanguageNullableJsonConverter(),
                    new global::G.JsonConverters.OutputFormatRAWOutputFormatContainerJsonConverter(),
                    new global::G.JsonConverters.OutputFormatRAWOutputFormatContainerNullableJsonConverter(),
                    new global::G.JsonConverters.OutputFormatWAVOutputFormatContainerJsonConverter(),
                    new global::G.JsonConverters.OutputFormatWAVOutputFormatContainerNullableJsonConverter(),
                    new global::G.JsonConverters.OutputFormatMP3OutputFormatContainerJsonConverter(),
                    new global::G.JsonConverters.OutputFormatMP3OutputFormatContainerNullableJsonConverter(),
                    new global::G.JsonConverters.SSEOutputFormatContainerJsonConverter(),
                    new global::G.JsonConverters.SSEOutputFormatContainerNullableJsonConverter(),
                    new global::G.JsonConverters.RawEncodingJsonConverter(),
                    new global::G.JsonConverters.RawEncodingNullableJsonConverter(),
                    new global::G.JsonConverters.TTSRequestVoiceSpecifierModeJsonConverter(),
                    new global::G.JsonConverters.TTSRequestVoiceSpecifierModeNullableJsonConverter(),
                    new global::G.JsonConverters.OutputFormatContainerJsonConverter(),
                    new global::G.JsonConverters.OutputFormatContainerNullableJsonConverter(),
                    new global::G.JsonConverters.StreamingResponseVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.StreamingResponseVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.StreamingResponseVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.StreamingResponseVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.StreamingResponseVariant3TypeJsonConverter(),
                    new global::G.JsonConverters.StreamingResponseVariant3TypeNullableJsonConverter(),
                    new global::G.JsonConverters.LocalizeTargetLanguageJsonConverter(),
                    new global::G.JsonConverters.LocalizeTargetLanguageNullableJsonConverter(),
                    new global::G.JsonConverters.LocalizeEnglishDialectJsonConverter(),
                    new global::G.JsonConverters.LocalizeEnglishDialectNullableJsonConverter(),
                    new global::G.JsonConverters.LocalizeFrenchDialectJsonConverter(),
                    new global::G.JsonConverters.LocalizeFrenchDialectNullableJsonConverter(),
                    new global::G.JsonConverters.LocalizeSpanishDialectJsonConverter(),
                    new global::G.JsonConverters.LocalizeSpanishDialectNullableJsonConverter(),
                    new global::G.JsonConverters.LocalizePortugueseDialectJsonConverter(),
                    new global::G.JsonConverters.LocalizePortugueseDialectNullableJsonConverter(),
                    new global::G.JsonConverters.GenderPresentationJsonConverter(),
                    new global::G.JsonConverters.GenderPresentationNullableJsonConverter(),
                    new global::G.JsonConverters.GenderJsonConverter(),
                    new global::G.JsonConverters.GenderNullableJsonConverter(),
                    new global::G.JsonConverters.VoiceExpandOptionsJsonConverter(),
                    new global::G.JsonConverters.VoiceExpandOptionsNullableJsonConverter(),
                    new global::G.JsonConverters.SttTranscribeRequestLanguageJsonConverter(),
                    new global::G.JsonConverters.SttTranscribeRequestLanguageNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsListCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.AgentsListCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsGetCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.AgentsGetCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsUpdateCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.AgentsUpdateCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsDeleteCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.AgentsDeleteCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsTemplatesCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.AgentsTemplatesCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsListCallsCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.AgentsListCallsCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsGetCallCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.AgentsGetCallCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsDownloadCallAudioCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.AgentsDownloadCallAudioCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsPhoneNumbersCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.AgentsPhoneNumbersCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsListMetricsCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.AgentsListMetricsCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsCreateMetricCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.AgentsCreateMetricCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsGetMetricCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.AgentsGetMetricCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsListMetricResultsCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.AgentsListMetricResultsCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsExportMetricResultsCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.AgentsExportMetricResultsCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsAddMetricToAgentCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.AgentsAddMetricToAgentCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsRemoveMetricFromAgentCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.AgentsRemoveMetricFromAgentCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsListDeploymentsCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.AgentsListDeploymentsCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.AgentsGetDeploymentCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.AgentsGetDeploymentCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.ApiStatusGetCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.ApiStatusGetCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.AuthAccessTokenCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.AuthAccessTokenCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.DatasetsListCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.DatasetsListCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.DatasetsCreateCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.DatasetsCreateCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.DatasetsGetCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.DatasetsGetCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.DatasetsUpdateCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.DatasetsUpdateCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.DatasetsDeleteCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.DatasetsDeleteCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.DatasetsListFilesCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.DatasetsListFilesCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.DatasetsUploadFileCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.DatasetsUploadFileCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.DatasetsDeleteFileCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.DatasetsDeleteFileCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.FineTunesListCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.FineTunesListCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.FineTunesCreateCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.FineTunesCreateCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.FineTunesGetCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.FineTunesGetCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.FineTunesDeleteCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.FineTunesDeleteCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.FineTunesListVoicesCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.FineTunesListVoicesCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.InfillBytesCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.InfillBytesCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.PronunciationDictsListCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.PronunciationDictsListCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.PronunciationDictsCreateCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.PronunciationDictsCreateCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.PronunciationDictsGetCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.PronunciationDictsGetCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.PronunciationDictsUpdateCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.PronunciationDictsUpdateCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.PronunciationDictsDeleteCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.PronunciationDictsDeleteCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.SttTranscribeCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.SttTranscribeCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.TtsBytesCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.TtsBytesCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.TtsSseCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.TtsSseCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.VoiceChangerBytesCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.VoiceChangerBytesCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.VoiceChangerSseCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.VoiceChangerSseCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.VoicesListCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.VoicesListCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.VoicesCloneCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.VoicesCloneCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.VoicesDeleteCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.VoicesDeleteCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.VoicesUpdateCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.VoicesUpdateCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.VoicesGetCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.VoicesGetCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.VoicesLocalizeCartesiaVersionJsonConverter(),
                    new global::G.JsonConverters.VoicesLocalizeCartesiaVersionNullableJsonConverter(),
                    new global::G.JsonConverters.StreamingTranscriptionResponseJsonConverter(),
                    new global::G.JsonConverters.WebSocketResponseJsonConverter(),
                    new global::G.JsonConverters.WebSocketRequestJsonConverter(),
                    new global::G.JsonConverters.OutputFormatJsonConverter(),
                    new global::G.JsonConverters.WAVOutputFormatJsonConverter(),
                    new global::G.JsonConverters.StreamingResponseJsonConverter(),
                    new global::G.JsonConverters.LocalizeDialectJsonConverter(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.StreamingTranscriptionResponseVariant12, global::G.TranscriptMessage>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.StreamingTranscriptionResponseVariant22, global::G.FlushDoneMessage>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.StreamingTranscriptionResponseVariant32, global::G.DoneMessage>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.StreamingTranscriptionResponseVariant42, global::G.ErrorMessage>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.OutputFormatRAWOutputFormat2, global::G.RawOutputFormat>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.OutputFormatWAVOutputFormat2, global::G.WAVOutputFormat?>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.OutputFormatMP3OutputFormat2, global::G.MP3OutputFormat>(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public AgentsClient Agents => new AgentsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ApiStatusClient ApiStatus => new ApiStatusClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AuthClient Auth => new AuthClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DatasetsClient Datasets => new DatasetsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FineTunesClient FineTunes => new FineTunesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public InfillClient Infill => new InfillClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PronunciationDictsClient PronunciationDicts => new PronunciationDictsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SttClient Stt => new SttClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TtsClient Tts => new TtsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public VoiceChangerClient VoiceChanger => new VoiceChangerClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public VoicesClient Voices => new VoicesClient(HttpClient, authorizations: Authorizations)
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