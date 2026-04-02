//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ## Authentication<br/>
    /// Authenticate with the API using [Basic Auth](https://en.wikipedia.org/wiki/Basic_access_authentication), get API keys in the project settings:<br/>
    /// - username: Langfuse Public Key<br/>
    /// - password: Langfuse Secret Key<br/>
    /// ## Exports<br/>
    /// - OpenAPI spec: https://cloud.langfuse.com/generated/api/openapi.yml<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "";

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
                    new global::G.JsonConverters.AnnotationQueueStatusJsonConverter(),
                    new global::G.JsonConverters.AnnotationQueueStatusNullableJsonConverter(),
                    new global::G.JsonConverters.AnnotationQueueObjectTypeJsonConverter(),
                    new global::G.JsonConverters.AnnotationQueueObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BlobStorageIntegrationTypeJsonConverter(),
                    new global::G.JsonConverters.BlobStorageIntegrationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BlobStorageIntegrationFileTypeJsonConverter(),
                    new global::G.JsonConverters.BlobStorageIntegrationFileTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BlobStorageExportModeJsonConverter(),
                    new global::G.JsonConverters.BlobStorageExportModeNullableJsonConverter(),
                    new global::G.JsonConverters.BlobStorageExportFrequencyJsonConverter(),
                    new global::G.JsonConverters.BlobStorageExportFrequencyNullableJsonConverter(),
                    new global::G.JsonConverters.BlobStorageSyncStatusJsonConverter(),
                    new global::G.JsonConverters.BlobStorageSyncStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ScoreV1Variant1DataTypeJsonConverter(),
                    new global::G.JsonConverters.ScoreV1Variant1DataTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScoreV1Variant2DataTypeJsonConverter(),
                    new global::G.JsonConverters.ScoreV1Variant2DataTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScoreV1Variant3DataTypeJsonConverter(),
                    new global::G.JsonConverters.ScoreV1Variant3DataTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScoreVariant1DataTypeJsonConverter(),
                    new global::G.JsonConverters.ScoreVariant1DataTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScoreVariant2DataTypeJsonConverter(),
                    new global::G.JsonConverters.ScoreVariant2DataTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScoreVariant3DataTypeJsonConverter(),
                    new global::G.JsonConverters.ScoreVariant3DataTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScoreVariant4DataTypeJsonConverter(),
                    new global::G.JsonConverters.ScoreVariant4DataTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PricingTierOperatorJsonConverter(),
                    new global::G.JsonConverters.PricingTierOperatorNullableJsonConverter(),
                    new global::G.JsonConverters.ModelUsageUnitJsonConverter(),
                    new global::G.JsonConverters.ModelUsageUnitNullableJsonConverter(),
                    new global::G.JsonConverters.ObservationLevelJsonConverter(),
                    new global::G.JsonConverters.ObservationLevelNullableJsonConverter(),
                    new global::G.JsonConverters.CommentObjectTypeJsonConverter(),
                    new global::G.JsonConverters.CommentObjectTypeNullableJsonConverter(),
                    new global::G.JsonConverters.DatasetStatusJsonConverter(),
                    new global::G.JsonConverters.DatasetStatusNullableJsonConverter(),
                    new global::G.JsonConverters.ScoreSourceJsonConverter(),
                    new global::G.JsonConverters.ScoreSourceNullableJsonConverter(),
                    new global::G.JsonConverters.ScoreConfigDataTypeJsonConverter(),
                    new global::G.JsonConverters.ScoreConfigDataTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScoreDataTypeJsonConverter(),
                    new global::G.JsonConverters.ScoreDataTypeNullableJsonConverter(),
                    new global::G.JsonConverters.IngestionEventVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.IngestionEventVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.IngestionEventVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.IngestionEventVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.IngestionEventVariant3TypeJsonConverter(),
                    new global::G.JsonConverters.IngestionEventVariant3TypeNullableJsonConverter(),
                    new global::G.JsonConverters.IngestionEventVariant4TypeJsonConverter(),
                    new global::G.JsonConverters.IngestionEventVariant4TypeNullableJsonConverter(),
                    new global::G.JsonConverters.IngestionEventVariant5TypeJsonConverter(),
                    new global::G.JsonConverters.IngestionEventVariant5TypeNullableJsonConverter(),
                    new global::G.JsonConverters.IngestionEventVariant6TypeJsonConverter(),
                    new global::G.JsonConverters.IngestionEventVariant6TypeNullableJsonConverter(),
                    new global::G.JsonConverters.IngestionEventVariant7TypeJsonConverter(),
                    new global::G.JsonConverters.IngestionEventVariant7TypeNullableJsonConverter(),
                    new global::G.JsonConverters.IngestionEventVariant8TypeJsonConverter(),
                    new global::G.JsonConverters.IngestionEventVariant8TypeNullableJsonConverter(),
                    new global::G.JsonConverters.IngestionEventVariant9TypeJsonConverter(),
                    new global::G.JsonConverters.IngestionEventVariant9TypeNullableJsonConverter(),
                    new global::G.JsonConverters.IngestionEventVariant10TypeJsonConverter(),
                    new global::G.JsonConverters.IngestionEventVariant10TypeNullableJsonConverter(),
                    new global::G.JsonConverters.ObservationTypeJsonConverter(),
                    new global::G.JsonConverters.ObservationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.LlmAdapterJsonConverter(),
                    new global::G.JsonConverters.LlmAdapterNullableJsonConverter(),
                    new global::G.JsonConverters.MediaContentTypeJsonConverter(),
                    new global::G.JsonConverters.MediaContentTypeNullableJsonConverter(),
                    new global::G.JsonConverters.MembershipRoleJsonConverter(),
                    new global::G.JsonConverters.MembershipRoleNullableJsonConverter(),
                    new global::G.JsonConverters.PromptVariant1TypeJsonConverter(),
                    new global::G.JsonConverters.PromptVariant1TypeNullableJsonConverter(),
                    new global::G.JsonConverters.PromptVariant2TypeJsonConverter(),
                    new global::G.JsonConverters.PromptVariant2TypeNullableJsonConverter(),
                    new global::G.JsonConverters.PromptTypeJsonConverter(),
                    new global::G.JsonConverters.PromptTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChatMessageTypeJsonConverter(),
                    new global::G.JsonConverters.ChatMessageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PlaceholderMessageTypeJsonConverter(),
                    new global::G.JsonConverters.PlaceholderMessageTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateChatPromptTypeJsonConverter(),
                    new global::G.JsonConverters.CreateChatPromptTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateTextPromptTypeJsonConverter(),
                    new global::G.JsonConverters.CreateTextPromptTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetScoresResponseDataVariant1DataTypeJsonConverter(),
                    new global::G.JsonConverters.GetScoresResponseDataVariant1DataTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetScoresResponseDataVariant2DataTypeJsonConverter(),
                    new global::G.JsonConverters.GetScoresResponseDataVariant2DataTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetScoresResponseDataVariant3DataTypeJsonConverter(),
                    new global::G.JsonConverters.GetScoresResponseDataVariant3DataTypeNullableJsonConverter(),
                    new global::G.JsonConverters.GetScoresResponseDataVariant4DataTypeJsonConverter(),
                    new global::G.JsonConverters.GetScoresResponseDataVariant4DataTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ScoreV1JsonConverter(),
                    new global::G.JsonConverters.ScoreJsonConverter(),
                    new global::G.JsonConverters.CreateScoreValueJsonConverter(),
                    new global::G.JsonConverters.MapValueJsonConverter(),
                    new global::G.JsonConverters.IngestionEventJsonConverter(),
                    new global::G.JsonConverters.IngestionUsageJsonConverter(),
                    new global::G.JsonConverters.UsageDetailsJsonConverter(),
                    new global::G.JsonConverters.CreatePromptRequestJsonConverter(),
                    new global::G.JsonConverters.PromptJsonConverter(),
                    new global::G.JsonConverters.ChatMessageWithPlaceholdersJsonConverter(),
                    new global::G.JsonConverters.GetScoresResponseDataJsonConverter(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.ScoreV1Variant12, global::G.NumericScoreV1>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.ScoreV1Variant22, global::G.CategoricalScoreV1>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.ScoreV1Variant32, global::G.BooleanScoreV1>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.ScoreVariant12, global::G.NumericScore>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.ScoreVariant22, global::G.CategoricalScore>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.ScoreVariant32, global::G.BooleanScore>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.ScoreVariant42, global::G.CorrectionScore>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.IngestionEventVariant12, global::G.TraceEvent>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.IngestionEventVariant22, global::G.ScoreEvent>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.IngestionEventVariant32, global::G.CreateSpanEvent>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.IngestionEventVariant42, global::G.UpdateSpanEvent>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.IngestionEventVariant52, global::G.CreateGenerationEvent>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.IngestionEventVariant62, global::G.UpdateGenerationEvent>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.IngestionEventVariant72, global::G.CreateEventEvent>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.IngestionEventVariant82, global::G.SDKLogEvent>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.IngestionEventVariant92, global::G.CreateObservationEvent>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.IngestionEventVariant102, global::G.UpdateObservationEvent>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.PromptVariant12, global::G.ChatPrompt>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.PromptVariant22, global::G.TextPrompt>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.GetScoresResponseDataVariant12, global::G.GetScoresResponseDataNumeric>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.GetScoresResponseDataVariant22, global::G.GetScoresResponseDataCategorical>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.GetScoresResponseDataVariant32, global::G.GetScoresResponseDataBoolean>(),
                    new global::G.JsonConverters.AllOfJsonConverter<global::G.GetScoresResponseDataVariant42, global::G.GetScoresResponseDataCorrection>(),
                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// 
        /// </summary>
        public AnnotationQueuesClient AnnotationQueues => new AnnotationQueuesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public BlobStorageIntegrationsClient BlobStorageIntegrations => new BlobStorageIntegrationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CommentsClient Comments => new CommentsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DatasetItemsClient DatasetItems => new DatasetItemsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DatasetRunItemsClient DatasetRunItems => new DatasetRunItemsClient(HttpClient, authorizations: Authorizations)
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
        public HealthClient Health => new HealthClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public IngestionClient Ingestion => new IngestionClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public LegacyMetricsV1Client LegacyMetricsV1 => new LegacyMetricsV1Client(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public LegacyObservationsV1Client LegacyObservationsV1 => new LegacyObservationsV1Client(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public LegacyScoreV1Client LegacyScoreV1 => new LegacyScoreV1Client(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public LlmConnectionsClient LlmConnections => new LlmConnectionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public MediaClient Media => new MediaClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public MetricsClient Metrics => new MetricsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ModelsClient Models => new ModelsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ObservationsClient Observations => new ObservationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public OpentelemetryClient Opentelemetry => new OpentelemetryClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public OrganizationsClient Organizations => new OrganizationsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ProjectsClient Projects => new ProjectsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PromptVersionClient PromptVersion => new PromptVersionClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PromptsClient Prompts => new PromptsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ScimClient Scim => new ScimClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ScoreConfigsClient ScoreConfigs => new ScoreConfigsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ScoresClient Scores => new ScoresClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SessionsClient Sessions => new SessionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TraceClient Trace => new TraceClient(HttpClient, authorizations: Authorizations)
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