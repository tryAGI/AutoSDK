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
        /// 
        /// </summary>
        public const string BaseUrl = "https://api.smith.langchain.com";

        private readonly global::System.Net.Http.HttpClient _httpClient;
        private global::G.EndPointAuthorization? _authorization;

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.AccessScopeJsonConverter(),
                    new global::G.JsonConverters.AccessScopeNullableJsonConverter(),
                    new global::G.JsonConverters.RunTypeEnumJsonConverter(),
                    new global::G.JsonConverters.RunTypeEnumNullableJsonConverter(),
                    new global::G.JsonConverters.RunsFilterDataSourceTypeEnumJsonConverter(),
                    new global::G.JsonConverters.RunsFilterDataSourceTypeEnumNullableJsonConverter(),
                    new global::G.JsonConverters.RunSelectJsonConverter(),
                    new global::G.JsonConverters.RunSelectNullableJsonConverter(),
                    new global::G.JsonConverters.RunDateOrderJsonConverter(),
                    new global::G.JsonConverters.RunDateOrderNullableJsonConverter(),
                    new global::G.JsonConverters.DataTypeJsonConverter(),
                    new global::G.JsonConverters.DataTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ChangePaymentPlanReqJsonConverter(),
                    new global::G.JsonConverters.ChangePaymentPlanReqNullableJsonConverter(),
                    new global::G.JsonConverters.ConfiguredByJsonConverter(),
                    new global::G.JsonConverters.ConfiguredByNullableJsonConverter(),
                    new global::G.JsonConverters.CreateEventRequestEventTypeJsonConverter(),
                    new global::G.JsonConverters.CreateEventRequestEventTypeNullableJsonConverter(),
                    new global::G.JsonConverters.FeedbackTypeJsonConverter(),
                    new global::G.JsonConverters.FeedbackTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CustomChartTypeJsonConverter(),
                    new global::G.JsonConverters.CustomChartTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CustomChartMetricJsonConverter(),
                    new global::G.JsonConverters.CustomChartMetricNullableJsonConverter(),
                    new global::G.JsonConverters.MissingMissing1JsonConverter(),
                    new global::G.JsonConverters.MissingMissing1NullableJsonConverter(),
                    new global::G.JsonConverters.PaymentPlanTierJsonConverter(),
                    new global::G.JsonConverters.PaymentPlanTierNullableJsonConverter(),
                    new global::G.JsonConverters.ExampleListOrderJsonConverter(),
                    new global::G.JsonConverters.ExampleListOrderNullableJsonConverter(),
                    new global::G.JsonConverters.ExampleSelectJsonConverter(),
                    new global::G.JsonConverters.ExampleSelectNullableJsonConverter(),
                    new global::G.JsonConverters.TraceTier3JsonConverter(),
                    new global::G.JsonConverters.TraceTier3NullableJsonConverter(),
                    new global::G.JsonConverters.FeedbackLevelJsonConverter(),
                    new global::G.JsonConverters.FeedbackLevelNullableJsonConverter(),
                    new global::G.JsonConverters.OrgFeatureFlagsJsonConverter(),
                    new global::G.JsonConverters.OrgFeatureFlagsNullableJsonConverter(),
                    new global::G.JsonConverters.OrganizationDashboardColorSchemeJsonConverter(),
                    new global::G.JsonConverters.OrganizationDashboardColorSchemeNullableJsonConverter(),
                    new global::G.JsonConverters.OrganizationDashboardTypeJsonConverter(),
                    new global::G.JsonConverters.OrganizationDashboardTypeNullableJsonConverter(),
                    new global::G.JsonConverters.PagerdutySeverityJsonConverter(),
                    new global::G.JsonConverters.PagerdutySeverityNullableJsonConverter(),
                    new global::G.JsonConverters.RunsGenerateQueryFeedbackKeysJsonConverter(),
                    new global::G.JsonConverters.RunsGenerateQueryFeedbackKeysNullableJsonConverter(),
                    new global::G.JsonConverters.ResourceTypeJsonConverter(),
                    new global::G.JsonConverters.ResourceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.RuleLogActionOutcomeJsonConverter(),
                    new global::G.JsonConverters.RuleLogActionOutcomeNullableJsonConverter(),
                    new global::G.JsonConverters.RunGroupByJsonConverter(),
                    new global::G.JsonConverters.RunGroupByNullableJsonConverter(),
                    new global::G.JsonConverters.RunRulesAlertTypeJsonConverter(),
                    new global::G.JsonConverters.RunRulesAlertTypeNullableJsonConverter(),
                    new global::G.JsonConverters.SessionSortableColumnsJsonConverter(),
                    new global::G.JsonConverters.SessionSortableColumnsNullableJsonConverter(),
                    new global::G.JsonConverters.SortByComparativeExperimentColumnJsonConverter(),
                    new global::G.JsonConverters.SortByComparativeExperimentColumnNullableJsonConverter(),
                    new global::G.JsonConverters.SortByDatasetColumnJsonConverter(),
                    new global::G.JsonConverters.SortByDatasetColumnNullableJsonConverter(),
                    new global::G.JsonConverters.SourceTypeJsonConverter(),
                    new global::G.JsonConverters.SourceTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TenantShareDatasetTokenTypeJsonConverter(),
                    new global::G.JsonConverters.TenantShareDatasetTokenTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TenantShareRunTokenTypeJsonConverter(),
                    new global::G.JsonConverters.TenantShareRunTokenTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TenantUsageLimitTypeJsonConverter(),
                    new global::G.JsonConverters.TenantUsageLimitTypeNullableJsonConverter(),
                    new global::G.JsonConverters.UsageLimitType2JsonConverter(),
                    new global::G.JsonConverters.UsageLimitType2NullableJsonConverter(),
                    new global::G.JsonConverters.CreateRunRequestRunTypeJsonConverter(),
                    new global::G.JsonConverters.CreateRunRequestRunTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BatchIngestRunsRequestPostItemRunTypeJsonConverter(),
                    new global::G.JsonConverters.BatchIngestRunsRequestPostItemRunTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ListReposApiV1ReposGetIsArchived2JsonConverter(),
                    new global::G.JsonConverters.ListReposApiV1ReposGetIsArchived2NullableJsonConverter(),
                    new global::G.JsonConverters.ListReposApiV1ReposGetIsPublic2JsonConverter(),
                    new global::G.JsonConverters.ListReposApiV1ReposGetIsPublic2NullableJsonConverter(),
                    new global::G.JsonConverters.ListReposApiV1ReposGetSortDirectionVariant1JsonConverter(),
                    new global::G.JsonConverters.ListReposApiV1ReposGetSortDirectionVariant1NullableJsonConverter(),
                    new global::G.JsonConverters.ListReposApiV1ReposGetSortDirectionVariant2JsonConverter(),
                    new global::G.JsonConverters.ListReposApiV1ReposGetSortDirectionVariant2NullableJsonConverter(),
                    new global::G.JsonConverters.ListRepoTagsApiV1ReposTagsGetIsArchived2JsonConverter(),
                    new global::G.JsonConverters.ListRepoTagsApiV1ReposTagsGetIsArchived2NullableJsonConverter(),
                    new global::G.JsonConverters.ListRepoTagsApiV1ReposTagsGetIsPublic2JsonConverter(),
                    new global::G.JsonConverters.ListRepoTagsApiV1ReposTagsGetIsPublic2NullableJsonConverter(),
                    new global::G.JsonConverters.AnyOfJsonConverterFactory2(),
                    new global::G.JsonConverters.AnyOfJsonConverterFactory3(),
                    new global::G.JsonConverters.AnyOfJsonConverterFactory4(),
                    new global::G.JsonConverters.AnyOfJsonConverterFactory6(),
                    new global::G.JsonConverters.AnyOfJsonConverterFactory5(),
                    new global::G.JsonConverters.OneOfJsonConverterFactory2(),
                    new global::G.JsonConverters.OneOfJsonConverterFactory3(),
                    new global::G.JsonConverters.AllOfJsonConverterFactory1(),
                }
            };


        /// <summary>
        /// 
        /// </summary>
        public TracerSessionsClient TracerSessions => new TracerSessionsClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public OrgsClient Orgs => new OrgsClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AuthClient Auth => new AuthClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ApiKeyClient ApiKey => new ApiKeyClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ExamplesClient Examples => new ExamplesClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DatasetsClient Datasets => new DatasetsClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public RunClient Run => new RunClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FeedbackClient Feedback => new FeedbackClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PublicClient Public => new PublicClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AnnotationQueuesClient AnnotationQueues => new AnnotationQueuesClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TenantClient Tenant => new TenantClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public InfoClient Info => new InfoClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FeedbackConfigsClient FeedbackConfigs => new FeedbackConfigsClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ModelPriceMapClient ModelPriceMap => new ModelPriceMapClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public UsageLimitsClient UsageLimits => new UsageLimitsClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TtlSettingsClient TtlSettings => new TtlSettingsClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PromptsClient Prompts => new PromptsClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public WorkspacesClient Workspaces => new WorkspacesClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PlaygroundSettingsClient PlaygroundSettings => new PlaygroundSettingsClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ServiceAccountsClient ServiceAccounts => new ServiceAccountsClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ChartsClient Charts => new ChartsClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ReposClient Repos => new ReposClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public LikesClient Likes => new LikesClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CommitsClient Commits => new CommitsClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SettingsClient Settings => new SettingsClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EventsClient Events => new EventsClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CommentsClient Comments => new CommentsClient(_httpClient, authorization: _authorization)
        {
            JsonSerializerOptions = JsonSerializerOptions,
        };

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
            global::G.EndPointAuthorization? authorization = null)
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(BaseUrl);
            _authorization = authorization;

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