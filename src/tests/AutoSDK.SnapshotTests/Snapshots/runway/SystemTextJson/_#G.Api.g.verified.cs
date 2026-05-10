//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The API makes generative AI models available, at the same credits prices listed here ($0.01 per credit): https://help.runwayml.com/hc/en-us/articles/15124877443219-How-do-credits-work<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api.dev.runwayml.com/";

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
                    new global::G.JsonConverters.CreateImageToVideoRequestGen4TurboRatioJsonConverter(),
                    new global::G.JsonConverters.CreateImageToVideoRequestGen4TurboRatioNullableJsonConverter(),
                    new global::G.JsonConverters.CreateImageToVideoRequestGen4TurboContentModerationPublicFigureThresholdJsonConverter(),
                    new global::G.JsonConverters.CreateImageToVideoRequestGen4TurboContentModerationPublicFigureThresholdNullableJsonConverter(),
                    new global::G.JsonConverters.CreateImageToVideoRequestVeo31PromptImagePromptImagePositionJsonConverter(),
                    new global::G.JsonConverters.CreateImageToVideoRequestVeo31PromptImagePromptImagePositionNullableJsonConverter(),
                    new global::G.JsonConverters.CreateImageToVideoRequestVeo31RatioJsonConverter(),
                    new global::G.JsonConverters.CreateImageToVideoRequestVeo31RatioNullableJsonConverter(),
                    new global::G.JsonConverters.CreateImageToVideoRequestGen3aTurboPromptImagePromptImagePositionJsonConverter(),
                    new global::G.JsonConverters.CreateImageToVideoRequestGen3aTurboPromptImagePromptImagePositionNullableJsonConverter(),
                    new global::G.JsonConverters.CreateImageToVideoRequestGen3aTurboRatioJsonConverter(),
                    new global::G.JsonConverters.CreateImageToVideoRequestGen3aTurboRatioNullableJsonConverter(),
                    new global::G.JsonConverters.CreateImageToVideoRequestGen3aTurboContentModerationPublicFigureThresholdJsonConverter(),
                    new global::G.JsonConverters.CreateImageToVideoRequestGen3aTurboContentModerationPublicFigureThresholdNullableJsonConverter(),
                    new global::G.JsonConverters.CreateImageToVideoRequestVeo31FastPromptImagePromptImagePositionJsonConverter(),
                    new global::G.JsonConverters.CreateImageToVideoRequestVeo31FastPromptImagePromptImagePositionNullableJsonConverter(),
                    new global::G.JsonConverters.CreateImageToVideoRequestVeo31FastRatioJsonConverter(),
                    new global::G.JsonConverters.CreateImageToVideoRequestVeo31FastRatioNullableJsonConverter(),
                    new global::G.JsonConverters.CreateImageToVideoRequestVeo3RatioJsonConverter(),
                    new global::G.JsonConverters.CreateImageToVideoRequestVeo3RatioNullableJsonConverter(),
                    new global::G.JsonConverters.CreateImageToVideoRequestDiscriminatorModelJsonConverter(),
                    new global::G.JsonConverters.CreateImageToVideoRequestDiscriminatorModelNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTextToVideoRequestVeo31RatioJsonConverter(),
                    new global::G.JsonConverters.CreateTextToVideoRequestVeo31RatioNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTextToVideoRequestVeo31FastRatioJsonConverter(),
                    new global::G.JsonConverters.CreateTextToVideoRequestVeo31FastRatioNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTextToVideoRequestVeo3RatioJsonConverter(),
                    new global::G.JsonConverters.CreateTextToVideoRequestVeo3RatioNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTextToVideoRequestDiscriminatorModelJsonConverter(),
                    new global::G.JsonConverters.CreateTextToVideoRequestDiscriminatorModelNullableJsonConverter(),
                    new global::G.JsonConverters.CreateVideoToVideoRequestGen4AlephRatioJsonConverter(),
                    new global::G.JsonConverters.CreateVideoToVideoRequestGen4AlephRatioNullableJsonConverter(),
                    new global::G.JsonConverters.CreateVideoToVideoRequestGen4AlephReferenceDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.CreateVideoToVideoRequestGen4AlephReferenceDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateVideoToVideoRequestGen4AlephContentModerationPublicFigureThresholdJsonConverter(),
                    new global::G.JsonConverters.CreateVideoToVideoRequestGen4AlephContentModerationPublicFigureThresholdNullableJsonConverter(),
                    new global::G.JsonConverters.CreateVideoToVideoRequestDiscriminatorModelJsonConverter(),
                    new global::G.JsonConverters.CreateVideoToVideoRequestDiscriminatorModelNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTextToImageRequestGen4ImageTurboRatioJsonConverter(),
                    new global::G.JsonConverters.CreateTextToImageRequestGen4ImageTurboRatioNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThresholdJsonConverter(),
                    new global::G.JsonConverters.CreateTextToImageRequestGen4ImageTurboContentModerationPublicFigureThresholdNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTextToImageRequestGen4ImageRatioJsonConverter(),
                    new global::G.JsonConverters.CreateTextToImageRequestGen4ImageRatioNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTextToImageRequestGen4ImageContentModerationPublicFigureThresholdJsonConverter(),
                    new global::G.JsonConverters.CreateTextToImageRequestGen4ImageContentModerationPublicFigureThresholdNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTextToImageRequestGemini25FlashRatioJsonConverter(),
                    new global::G.JsonConverters.CreateTextToImageRequestGemini25FlashRatioNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTextToImageRequestDiscriminatorModelJsonConverter(),
                    new global::G.JsonConverters.CreateTextToImageRequestDiscriminatorModelNullableJsonConverter(),
                    new global::G.JsonConverters.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.CreateCharacterPerformanceRequestActTwoCharacterDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateCharacterPerformanceRequestActTwoReferenceDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.CreateCharacterPerformanceRequestActTwoReferenceDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateCharacterPerformanceRequestActTwoRatioJsonConverter(),
                    new global::G.JsonConverters.CreateCharacterPerformanceRequestActTwoRatioNullableJsonConverter(),
                    new global::G.JsonConverters.CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThresholdJsonConverter(),
                    new global::G.JsonConverters.CreateCharacterPerformanceRequestActTwoContentModerationPublicFigureThresholdNullableJsonConverter(),
                    new global::G.JsonConverters.CreateCharacterPerformanceRequestDiscriminatorModelJsonConverter(),
                    new global::G.JsonConverters.CreateCharacterPerformanceRequestDiscriminatorModelNullableJsonConverter(),
                    new global::G.JsonConverters.CreateSoundEffectRequestDiscriminatorModelJsonConverter(),
                    new global::G.JsonConverters.CreateSoundEffectRequestDiscriminatorModelNullableJsonConverter(),
                    new global::G.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2MediaDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetIdJsonConverter(),
                    new global::G.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetIdNullableJsonConverter(),
                    new global::G.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.CreateSpeechToSpeechRequestElevenMultilingualStsV2VoiceDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateSpeechToSpeechRequestDiscriminatorModelJsonConverter(),
                    new global::G.JsonConverters.CreateSpeechToSpeechRequestDiscriminatorModelNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetIdJsonConverter(),
                    new global::G.JsonConverters.CreateTextToSpeechRequestElevenMultilingualV2VoiceRunwayPresetVoicePresetIdNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.CreateTextToSpeechRequestElevenMultilingualV2VoiceDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTextToSpeechRequestDiscriminatorModelJsonConverter(),
                    new global::G.JsonConverters.CreateTextToSpeechRequestDiscriminatorModelNullableJsonConverter(),
                    new global::G.JsonConverters.CreateVoiceDubbingRequestElevenVoiceDubbingTargetLangJsonConverter(),
                    new global::G.JsonConverters.CreateVoiceDubbingRequestElevenVoiceDubbingTargetLangNullableJsonConverter(),
                    new global::G.JsonConverters.CreateVoiceDubbingRequestDiscriminatorModelJsonConverter(),
                    new global::G.JsonConverters.CreateVoiceDubbingRequestDiscriminatorModelNullableJsonConverter(),
                    new global::G.JsonConverters.CreateVoiceIsolationRequestDiscriminatorModelJsonConverter(),
                    new global::G.JsonConverters.CreateVoiceIsolationRequestDiscriminatorModelNullableJsonConverter(),
                    new global::G.JsonConverters.CreateUploadsRequestTypeJsonConverter(),
                    new global::G.JsonConverters.CreateUploadsRequestTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetTasksResponseDiscriminatorStatusJsonConverter(),
                    new global::G.JsonConverters.GetTasksResponseDiscriminatorStatusNullableJsonConverter(),
                    new global::G.JsonConverters.CreateOrganizationUsageResponseResultUsedCreditModelJsonConverter(),
                    new global::G.JsonConverters.CreateOrganizationUsageResponseResultUsedCreditModelNullableJsonConverter(),
                    new global::G.JsonConverters.CreateOrganizationUsageResponseModelJsonConverter(),
                    new global::G.JsonConverters.CreateOrganizationUsageResponseModelNullableJsonConverter(),
                    new global::G.JsonConverters.CreateImageToVideoRequestJsonConverter(),
                    new global::G.JsonConverters.CreateTextToVideoRequestJsonConverter(),
                    new global::G.JsonConverters.CreateVideoToVideoRequestJsonConverter(),
                    new global::G.JsonConverters.ReferencesItemJsonConverter(),
                    new global::G.JsonConverters.CreateTextToImageRequestJsonConverter(),
                    new global::G.JsonConverters.CreateCharacterPerformanceRequestJsonConverter(),
                    new global::G.JsonConverters.CharacterJsonConverter(),
                    new global::G.JsonConverters.CreateSoundEffectRequestJsonConverter(),
                    new global::G.JsonConverters.CreateSpeechToSpeechRequestJsonConverter(),
                    new global::G.JsonConverters.MediaJsonConverter(),
                    new global::G.JsonConverters.CreateTextToSpeechRequestJsonConverter(),
                    new global::G.JsonConverters.CreateVoiceDubbingRequestJsonConverter(),
                    new global::G.JsonConverters.CreateVoiceIsolationRequestJsonConverter(),
                    new global::G.JsonConverters.GetTasksResponseJsonConverter(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::G.CreateImageToVideoRequestGen4TurboPromptImagePromptImage>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::G.CreateImageToVideoRequestVeo31PromptImagePromptImage>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::G.CreateImageToVideoRequestGen3aTurboPromptImagePromptImage>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::G.CreateImageToVideoRequestVeo31FastPromptImagePromptImage>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::G.CreateImageToVideoRequestVeo3PromptImagePromptImage>>(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public OrganizationClient Organization => new OrganizationClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// These endpoints all kick off tasks to create generations.
        /// </summary>
        public StartGeneratingClient StartGenerating => new StartGeneratingClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Endpoints for managing tasks that have been submitted.
        /// </summary>
        public TaskManagementClient TaskManagement => new TaskManagementClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Endpoints for uploading media files.
        /// </summary>
        public UploadsClient Uploads => new UploadsClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
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
        /// Creates a new instance of the Api with explicit options but no base URL override.
        /// Skips passing <c>baseUri</c> so the default base URL from the OpenAPI spec applies.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient,
            global::System.Collections.Generic.List<global::G.EndPointAuthorization>? authorizations,
            global::G.AutoSDKClientOptions? options,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri: null,
                authorizations,
                options,
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
            global::System.Net.Http.HttpClient? httpClient,
            global::System.Uri? baseUri,
            global::System.Collections.Generic.List<global::G.EndPointAuthorization>? authorizations,
            global::G.AutoSDKClientOptions? options,
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