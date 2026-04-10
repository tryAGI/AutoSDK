//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Synthesia public API endpoints<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// Synthesia public API URL.
        /// </summary>
        public const string DefaultBaseUrl = "https://api.synthesia.io/";

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
                    new global::G.JsonConverters.DubbingOutputLanguageJsonConverter(),
                    new global::G.JsonConverters.DubbingOutputLanguageNullableJsonConverter(),
                    new global::G.JsonConverters.AddLocalesToDubbingProjectRequestVideoDurationJsonConverter(),
                    new global::G.JsonConverters.AddLocalesToDubbingProjectRequestVideoDurationNullableJsonConverter(),
                    new global::G.JsonConverters.AddLocalesToDubbingProjectRequestVisibilityJsonConverter(),
                    new global::G.JsonConverters.AddLocalesToDubbingProjectRequestVisibilityNullableJsonConverter(),
                    new global::G.JsonConverters.DubbingAssetRequestConfigurationNameJsonConverter(),
                    new global::G.JsonConverters.DubbingAssetRequestConfigurationNameNullableJsonConverter(),
                    new global::G.JsonConverters.CreateAssetRequestContentTypeJsonConverter(),
                    new global::G.JsonConverters.CreateAssetRequestContentTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateAssetRequestConfigurationDiscriminatorNameJsonConverter(),
                    new global::G.JsonConverters.CreateAssetRequestConfigurationDiscriminatorNameNullableJsonConverter(),
                    new global::G.JsonConverters.DubbingInputLanguageJsonConverter(),
                    new global::G.JsonConverters.DubbingInputLanguageNullableJsonConverter(),
                    new global::G.JsonConverters.CreateDubbingProjectApiRequestFromSourceAssetIdVideoDurationJsonConverter(),
                    new global::G.JsonConverters.CreateDubbingProjectApiRequestFromSourceAssetIdVideoDurationNullableJsonConverter(),
                    new global::G.JsonConverters.CreateDubbingProjectApiRequestFromSourceAssetIdVisibilityJsonConverter(),
                    new global::G.JsonConverters.CreateDubbingProjectApiRequestFromSourceAssetIdVisibilityNullableJsonConverter(),
                    new global::G.JsonConverters.CreateDubbingProjectApiRequestFromSourceVideoUrlVideoDurationJsonConverter(),
                    new global::G.JsonConverters.CreateDubbingProjectApiRequestFromSourceVideoUrlVideoDurationNullableJsonConverter(),
                    new global::G.JsonConverters.CreateDubbingProjectApiRequestFromSourceVideoUrlVisibilityJsonConverter(),
                    new global::G.JsonConverters.CreateDubbingProjectApiRequestFromSourceVideoUrlVisibilityNullableJsonConverter(),
                    new global::G.JsonConverters.UpsertVideoTranslationsApiRequestAutoGenerateJsonConverter(),
                    new global::G.JsonConverters.UpsertVideoTranslationsApiRequestAutoGenerateNullableJsonConverter(),
                    new global::G.JsonConverters.PublicApiImportedAndDubbedVideosErrorCodeJsonConverter(),
                    new global::G.JsonConverters.PublicApiImportedAndDubbedVideosErrorCodeNullableJsonConverter(),
                    new global::G.JsonConverters.DubbedAssetCompleteStatusJsonConverter(),
                    new global::G.JsonConverters.DubbedAssetCompleteStatusNullableJsonConverter(),
                    new global::G.JsonConverters.DubbedAssetCompleteVisibilityJsonConverter(),
                    new global::G.JsonConverters.DubbedAssetCompleteVisibilityNullableJsonConverter(),
                    new global::G.JsonConverters.DubbedAssetErrorStatusJsonConverter(),
                    new global::G.JsonConverters.DubbedAssetErrorStatusNullableJsonConverter(),
                    new global::G.JsonConverters.DubbedAssetInProgressStatusJsonConverter(),
                    new global::G.JsonConverters.DubbedAssetInProgressStatusNullableJsonConverter(),
                    new global::G.JsonConverters.AssetContentTypeJsonConverter(),
                    new global::G.JsonConverters.AssetContentTypeNullableJsonConverter(),
                    new global::G.JsonConverters.LanguageBCP47JsonConverter(),
                    new global::G.JsonConverters.LanguageBCP47NullableJsonConverter(),
                    new global::G.JsonConverters.PublicApiUserUploadedAssetErrorCodesJsonConverter(),
                    new global::G.JsonConverters.PublicApiUserUploadedAssetErrorCodesNullableJsonConverter(),
                    new global::G.JsonConverters.PublicApiUserUploadedAssetStatusJsonConverter(),
                    new global::G.JsonConverters.PublicApiUserUploadedAssetStatusNullableJsonConverter(),
                    new global::G.JsonConverters.GetDubbingProjectVideosResponseUploadingStatusJsonConverter(),
                    new global::G.JsonConverters.GetDubbingProjectVideosResponseUploadingStatusNullableJsonConverter(),
                    new global::G.JsonConverters.GetDubbingProjectVideosResponseInProgressStatusJsonConverter(),
                    new global::G.JsonConverters.GetDubbingProjectVideosResponseInProgressStatusNullableJsonConverter(),
                    new global::G.JsonConverters.GetDubbingProjectVideosResponseCompleteStatusJsonConverter(),
                    new global::G.JsonConverters.GetDubbingProjectVideosResponseCompleteStatusNullableJsonConverter(),
                    new global::G.JsonConverters.GetDubbingProjectVideosResponseErrorStatusJsonConverter(),
                    new global::G.JsonConverters.GetDubbingProjectVideosResponseErrorStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ActorTypeJsonConverter(),
                    new global::G.JsonConverters.ActorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TargetTypeJsonConverter(),
                    new global::G.JsonConverters.TargetTypeNullableJsonConverter(),
                    new global::G.JsonConverters.UpsertVideoTranslationsRunningWorkflowApiItemStatusJsonConverter(),
                    new global::G.JsonConverters.UpsertVideoTranslationsRunningWorkflowApiItemStatusNullableJsonConverter(),
                    new global::G.JsonConverters.UpsertVideoTranslationsRunningWorkflowApiItemStepJsonConverter(),
                    new global::G.JsonConverters.UpsertVideoTranslationsRunningWorkflowApiItemStepNullableJsonConverter(),
                    new global::G.JsonConverters.TranslationStatusApiItemErrorStatusJsonConverter(),
                    new global::G.JsonConverters.TranslationStatusApiItemErrorStatusNullableJsonConverter(),
                    new global::G.JsonConverters.TranslationStatusApiItemErrorErrorCodeJsonConverter(),
                    new global::G.JsonConverters.TranslationStatusApiItemErrorErrorCodeNullableJsonConverter(),
                    new global::G.JsonConverters.TranslationStatusApiItemSuccessStatusJsonConverter(),
                    new global::G.JsonConverters.TranslationStatusApiItemSuccessStatusNullableJsonConverter(),
                    new global::G.JsonConverters.TranslationStatusApiItemSuccessStepJsonConverter(),
                    new global::G.JsonConverters.TranslationStatusApiItemSuccessStepNullableJsonConverter(),
                    new global::G.JsonConverters.GetVideoTranslationsApiResponseTranslationDiscriminatorStatusJsonConverter(),
                    new global::G.JsonConverters.GetVideoTranslationsApiResponseTranslationDiscriminatorStatusNullableJsonConverter(),
                    new global::G.JsonConverters.TemplateResponseVisibilityJsonConverter(),
                    new global::G.JsonConverters.TemplateResponseVisibilityNullableJsonConverter(),
                    new global::G.JsonConverters.ActorSettingsHorizontalAlignJsonConverter(),
                    new global::G.JsonConverters.ActorSettingsHorizontalAlignNullableJsonConverter(),
                    new global::G.JsonConverters.ActorSettingsStyleJsonConverter(),
                    new global::G.JsonConverters.ActorSettingsStyleNullableJsonConverter(),
                    new global::G.JsonConverters.InputVideoBackgroundSettingsShortBackgroundContentMatchModeJsonConverter(),
                    new global::G.JsonConverters.InputVideoBackgroundSettingsShortBackgroundContentMatchModeNullableJsonConverter(),
                    new global::G.JsonConverters.InputVideoBackgroundSettingsLongBackgroundContentMatchModeJsonConverter(),
                    new global::G.JsonConverters.InputVideoBackgroundSettingsLongBackgroundContentMatchModeNullableJsonConverter(),
                    new global::G.JsonConverters.InputScriptLanguageJsonConverter(),
                    new global::G.JsonConverters.InputScriptLanguageNullableJsonConverter(),
                    new global::G.JsonConverters.InputTransitionJsonConverter(),
                    new global::G.JsonConverters.InputTransitionNullableJsonConverter(),
                    new global::G.JsonConverters.VideoResponseAspectRatioJsonConverter(),
                    new global::G.JsonConverters.VideoResponseAspectRatioNullableJsonConverter(),
                    new global::G.JsonConverters.VideoResponseSoundtrackJsonConverter(),
                    new global::G.JsonConverters.VideoResponseSoundtrackNullableJsonConverter(),
                    new global::G.JsonConverters.VideoResponseVisibilityJsonConverter(),
                    new global::G.JsonConverters.VideoResponseVisibilityNullableJsonConverter(),
                    new global::G.JsonConverters.VideoResponseStatusJsonConverter(),
                    new global::G.JsonConverters.VideoResponseStatusNullableJsonConverter(),
                    new global::G.JsonConverters.VideoFromTemplateApiVisibilityJsonConverter(),
                    new global::G.JsonConverters.VideoFromTemplateApiVisibilityNullableJsonConverter(),
                    new global::G.JsonConverters.CreateVideoRequestAspectRatioJsonConverter(),
                    new global::G.JsonConverters.CreateVideoRequestAspectRatioNullableJsonConverter(),
                    new global::G.JsonConverters.CreateVideoRequestSoundtrackJsonConverter(),
                    new global::G.JsonConverters.CreateVideoRequestSoundtrackNullableJsonConverter(),
                    new global::G.JsonConverters.CreateVideoRequestVisibilityJsonConverter(),
                    new global::G.JsonConverters.CreateVideoRequestVisibilityNullableJsonConverter(),
                    new global::G.JsonConverters.UpdateVideoMetadataRequestVisibilityJsonConverter(),
                    new global::G.JsonConverters.UpdateVideoMetadataRequestVisibilityNullableJsonConverter(),
                    new global::G.JsonConverters.CreateWebhookRequestEventJsonConverter(),
                    new global::G.JsonConverters.CreateWebhookRequestEventNullableJsonConverter(),
                    new global::G.JsonConverters.GetTemplatesSourceItemJsonConverter(),
                    new global::G.JsonConverters.GetTemplatesSourceItemNullableJsonConverter(),
                    new global::G.JsonConverters.GetVideosSourceItemJsonConverter(),
                    new global::G.JsonConverters.GetVideosSourceItemNullableJsonConverter(),
                    new global::G.JsonConverters.GetVideosXliffXliffVersionJsonConverter(),
                    new global::G.JsonConverters.GetVideosXliffXliffVersionNullableJsonConverter(),
                    new global::G.JsonConverters.TranslationsItemJsonConverter(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.DubbedAssetInProgress, global::G.DubbedAssetComplete, global::G.DubbedAssetError>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.DubbedAssetInProgress, global::G.DubbedAssetComplete, global::G.DubbedAssetError>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.DubbedAssetInProgress, global::G.DubbedAssetComplete, global::G.DubbedAssetError>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.CreateDubbingProjectApiRequestFromSourceAssetId, global::G.CreateDubbingProjectApiRequestFromSourceVideoUrl?>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.CreateDubbingProjectApiResponseFail, global::G.CreateDubbingResponse2>(),
                    new global::G.JsonConverters.OneOfJsonConverter<global::G.GetDubbingProjectVideosResponseUploading, global::G.GetDubbingProjectVideosResponseInProgress, global::G.GetDubbingProjectVideosResponseComplete, global::G.GetDubbingProjectVideosResponseError>(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public AssetsClient Assets => new AssetsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AuditLogsClient AuditLogs => new AuditLogsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DubbingClient Dubbing => new DubbingClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TemplatesClient Templates => new TemplatesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TranslationsClient Translations => new TranslationsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public VideosClient Videos => new VideosClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public WebhooksClient Webhooks => new WebhooksClient(HttpClient, authorizations: Authorizations, options: Options)
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