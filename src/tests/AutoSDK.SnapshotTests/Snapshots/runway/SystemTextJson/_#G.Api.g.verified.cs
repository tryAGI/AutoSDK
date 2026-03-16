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
        public const string DefaultBaseUrl = "https://api.dev.runwayml.com";

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
                    new global::G.JsonConverters.RequestGen4TurboRatioJsonConverter(),
                    new global::G.JsonConverters.RequestGen4TurboRatioNullableJsonConverter(),
                    new global::G.JsonConverters.RequestGen4TurboContentModerationPublicFigureThresholdJsonConverter(),
                    new global::G.JsonConverters.RequestGen4TurboContentModerationPublicFigureThresholdNullableJsonConverter(),
                    new global::G.JsonConverters.RequestVeo31PromptImagePromptImagePositionJsonConverter(),
                    new global::G.JsonConverters.RequestVeo31PromptImagePromptImagePositionNullableJsonConverter(),
                    new global::G.JsonConverters.RequestVeo31RatioJsonConverter(),
                    new global::G.JsonConverters.RequestVeo31RatioNullableJsonConverter(),
                    new global::G.JsonConverters.RequestGen3aTurboPromptImagePromptImagePositionJsonConverter(),
                    new global::G.JsonConverters.RequestGen3aTurboPromptImagePromptImagePositionNullableJsonConverter(),
                    new global::G.JsonConverters.RequestGen3aTurboRatioJsonConverter(),
                    new global::G.JsonConverters.RequestGen3aTurboRatioNullableJsonConverter(),
                    new global::G.JsonConverters.RequestGen3aTurboContentModerationPublicFigureThresholdJsonConverter(),
                    new global::G.JsonConverters.RequestGen3aTurboContentModerationPublicFigureThresholdNullableJsonConverter(),
                    new global::G.JsonConverters.RequestVeo31FastPromptImagePromptImagePositionJsonConverter(),
                    new global::G.JsonConverters.RequestVeo31FastPromptImagePromptImagePositionNullableJsonConverter(),
                    new global::G.JsonConverters.RequestVeo31FastRatioJsonConverter(),
                    new global::G.JsonConverters.RequestVeo31FastRatioNullableJsonConverter(),
                    new global::G.JsonConverters.RequestVeo3RatioJsonConverter(),
                    new global::G.JsonConverters.RequestVeo3RatioNullableJsonConverter(),
                    new global::G.JsonConverters.RequestVeo31Ratio2JsonConverter(),
                    new global::G.JsonConverters.RequestVeo31Ratio2NullableJsonConverter(),
                    new global::G.JsonConverters.RequestVeo31FastRatio2JsonConverter(),
                    new global::G.JsonConverters.RequestVeo31FastRatio2NullableJsonConverter(),
                    new global::G.JsonConverters.RequestVeo3Ratio2JsonConverter(),
                    new global::G.JsonConverters.RequestVeo3Ratio2NullableJsonConverter(),
                    new global::G.JsonConverters.RequestGen4AlephRatioJsonConverter(),
                    new global::G.JsonConverters.RequestGen4AlephRatioNullableJsonConverter(),
                    new global::G.JsonConverters.RequestGen4AlephContentModerationPublicFigureThresholdJsonConverter(),
                    new global::G.JsonConverters.RequestGen4AlephContentModerationPublicFigureThresholdNullableJsonConverter(),
                    new global::G.JsonConverters.RequestGen4ImageTurboRatioJsonConverter(),
                    new global::G.JsonConverters.RequestGen4ImageTurboRatioNullableJsonConverter(),
                    new global::G.JsonConverters.RequestGen4ImageTurboContentModerationPublicFigureThresholdJsonConverter(),
                    new global::G.JsonConverters.RequestGen4ImageTurboContentModerationPublicFigureThresholdNullableJsonConverter(),
                    new global::G.JsonConverters.RequestGen4ImageRatioJsonConverter(),
                    new global::G.JsonConverters.RequestGen4ImageRatioNullableJsonConverter(),
                    new global::G.JsonConverters.RequestGen4ImageContentModerationPublicFigureThresholdJsonConverter(),
                    new global::G.JsonConverters.RequestGen4ImageContentModerationPublicFigureThresholdNullableJsonConverter(),
                    new global::G.JsonConverters.RequestGemini25FlashRatioJsonConverter(),
                    new global::G.JsonConverters.RequestGemini25FlashRatioNullableJsonConverter(),
                    new global::G.JsonConverters.RequestActTwoRatioJsonConverter(),
                    new global::G.JsonConverters.RequestActTwoRatioNullableJsonConverter(),
                    new global::G.JsonConverters.RequestActTwoContentModerationPublicFigureThresholdJsonConverter(),
                    new global::G.JsonConverters.RequestActTwoContentModerationPublicFigureThresholdNullableJsonConverter(),
                    new global::G.JsonConverters.RequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetIdJsonConverter(),
                    new global::G.JsonConverters.RequestElevenMultilingualStsV2VoiceRunwayPresetVoicePresetIdNullableJsonConverter(),
                    new global::G.JsonConverters.RequestElevenMultilingualV2VoiceRunwayPresetVoicePresetIdJsonConverter(),
                    new global::G.JsonConverters.RequestElevenMultilingualV2VoiceRunwayPresetVoicePresetIdNullableJsonConverter(),
                    new global::G.JsonConverters.RequestElevenVoiceDubbingTargetLangJsonConverter(),
                    new global::G.JsonConverters.RequestElevenVoiceDubbingTargetLangNullableJsonConverter(),
                    new global::G.JsonConverters.RequestTypeJsonConverter(),
                    new global::G.JsonConverters.RequestTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseResultUsedCreditModelJsonConverter(),
                    new global::G.JsonConverters.ResponseResultUsedCreditModelNullableJsonConverter(),
                    new global::G.JsonConverters.ResponseModelJsonConverter(),
                    new global::G.JsonConverters.ResponseModelNullableJsonConverter(),
                    new global::G.JsonConverters.RequestJsonConverter(),
                    new global::G.JsonConverters.Request2JsonConverter(),
                    new global::G.JsonConverters.Request3JsonConverter(),
                    new global::G.JsonConverters.ReferencesItemJsonConverter(),
                    new global::G.JsonConverters.Request4JsonConverter(),
                    new global::G.JsonConverters.Request5JsonConverter(),
                    new global::G.JsonConverters.CharacterJsonConverter(),
                    new global::G.JsonConverters.Request6JsonConverter(),
                    new global::G.JsonConverters.Request7JsonConverter(),
                    new global::G.JsonConverters.MediaJsonConverter(),
                    new global::G.JsonConverters.Request8JsonConverter(),
                    new global::G.JsonConverters.Request9JsonConverter(),
                    new global::G.JsonConverters.Request10JsonConverter(),
                    new global::G.JsonConverters.ResponseJsonConverter(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::G.RequestGen4TurboPromptImagePromptImage>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::G.RequestVeo31PromptImagePromptImage>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::G.RequestGen3aTurboPromptImagePromptImage>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::G.RequestVeo31FastPromptImagePromptImage>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string?, global::System.Collections.Generic.IList<global::G.RequestVeo3PromptImagePromptImage>>(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };


        /// <summary>
        /// These endpoints all kick off tasks to create generations.
        /// </summary>
        public StartGeneratingClient StartGenerating => new StartGeneratingClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Endpoints for managing tasks that have been submitted.
        /// </summary>
        public TaskManagementClient TaskManagement => new TaskManagementClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// Endpoints for uploading media files.
        /// </summary>
        public UploadsClient Uploads => new UploadsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public OrganizationClient Organization => new OrganizationClient(HttpClient, authorizations: Authorizations)
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