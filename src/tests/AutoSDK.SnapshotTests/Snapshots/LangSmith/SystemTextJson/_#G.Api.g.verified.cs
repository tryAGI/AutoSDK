//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string BaseUrl = "https://api.smith.langchain.com";

        private readonly global::System.Net.Http.HttpClient _httpClient;
        private readonly global::System.Text.Json.JsonSerializerOptions _jsonSerializerOptions;


        /// <summary>
        /// 
        /// </summary>
        public TracerSessionsClient TracerSessions => new TracerSessionsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public OrgsClient Orgs => new OrgsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public AuthClient Auth => new AuthClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public ApiKeyClient ApiKey => new ApiKeyClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public ExamplesClient Examples => new ExamplesClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public DatasetsClient Datasets => new DatasetsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public RunClient Run => new RunClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public FeedbackClient Feedback => new FeedbackClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public PublicClient Public => new PublicClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public AnnotationQueuesClient AnnotationQueues => new AnnotationQueuesClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public TenantClient Tenant => new TenantClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public InfoClient Info => new InfoClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public FeedbackConfigsClient FeedbackConfigs => new FeedbackConfigsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public ModelPriceMapClient ModelPriceMap => new ModelPriceMapClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public UsageLimitsClient UsageLimits => new UsageLimitsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public TtlSettingsClient TtlSettings => new TtlSettingsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public PromptsClient Prompts => new PromptsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public WorkspacesClient Workspaces => new WorkspacesClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public PlaygroundSettingsClient PlaygroundSettings => new PlaygroundSettingsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public ServiceAccountsClient ServiceAccounts => new ServiceAccountsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public ChartsClient Charts => new ChartsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public ReposClient Repos => new ReposClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public LikesClient Likes => new LikesClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public CommitsClient Commits => new CommitsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public SettingsClient Settings => new SettingsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public EventsClient Events => new EventsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

        /// <summary>
        /// 
        /// </summary>
        public CommentsClient Comments => new CommentsClient(_httpClient, jsonSerializerOptions: _jsonSerializerOptions);

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
                    new global::AutoSDK.JsonConverters.AccessScopeJsonConverter(),
                    new global::AutoSDK.JsonConverters.AccessScopeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunTypeEnumJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunTypeEnumNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunsFilterDataSourceTypeEnumJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunsFilterDataSourceTypeEnumNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunSelectJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunSelectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunDateOrderJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunDateOrderNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.DataType2JsonConverter(),
                    new global::AutoSDK.JsonConverters.DataType2NullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChangePaymentPlanReqJsonConverter(),
                    new global::AutoSDK.JsonConverters.ChangePaymentPlanReqNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ConfiguredByJsonConverter(),
                    new global::AutoSDK.JsonConverters.ConfiguredByNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateEventRequestEventTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateEventRequestEventTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.FeedbackTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.FeedbackTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CustomChartTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.CustomChartTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CustomChartMetricJsonConverter(),
                    new global::AutoSDK.JsonConverters.CustomChartMetricNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.MissingMissing1JsonConverter(),
                    new global::AutoSDK.JsonConverters.MissingMissing1NullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.PaymentPlanTierJsonConverter(),
                    new global::AutoSDK.JsonConverters.PaymentPlanTierNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ExampleListOrderJsonConverter(),
                    new global::AutoSDK.JsonConverters.ExampleListOrderNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ExampleSelectJsonConverter(),
                    new global::AutoSDK.JsonConverters.ExampleSelectNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.TraceTier3JsonConverter(),
                    new global::AutoSDK.JsonConverters.TraceTier3NullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.FeedbackLevelJsonConverter(),
                    new global::AutoSDK.JsonConverters.FeedbackLevelNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.OrgFeatureFlagsJsonConverter(),
                    new global::AutoSDK.JsonConverters.OrgFeatureFlagsNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.OrganizationDashboardColorSchemeJsonConverter(),
                    new global::AutoSDK.JsonConverters.OrganizationDashboardColorSchemeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.OrganizationDashboardTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.OrganizationDashboardTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.PagerdutySeverityJsonConverter(),
                    new global::AutoSDK.JsonConverters.PagerdutySeverityNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunsGenerateQueryFeedbackKeysJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunsGenerateQueryFeedbackKeysNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ResourceTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.ResourceTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RuleLogActionOutcomeJsonConverter(),
                    new global::AutoSDK.JsonConverters.RuleLogActionOutcomeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunGroupByJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunGroupByNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunRulesAlertTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.RunRulesAlertTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.SessionSortableColumnsJsonConverter(),
                    new global::AutoSDK.JsonConverters.SessionSortableColumnsNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.SortByComparativeExperimentColumnJsonConverter(),
                    new global::AutoSDK.JsonConverters.SortByComparativeExperimentColumnNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.SortByDatasetColumnJsonConverter(),
                    new global::AutoSDK.JsonConverters.SortByDatasetColumnNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.SourceTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.SourceTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.TenantShareDatasetTokenTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.TenantShareDatasetTokenTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.TenantShareRunTokenTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.TenantShareRunTokenTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.TenantUsageLimitTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.TenantUsageLimitTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.UsageLimitType2JsonConverter(),
                    new global::AutoSDK.JsonConverters.UsageLimitType2NullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateRunRequestRunTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.CreateRunRequestRunTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.BatchIngestRunsRequestPostItemRunTypeJsonConverter(),
                    new global::AutoSDK.JsonConverters.BatchIngestRunsRequestPostItemRunTypeNullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListReposApiV1ReposGetIsArchived2JsonConverter(),
                    new global::AutoSDK.JsonConverters.ListReposApiV1ReposGetIsArchived2NullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListReposApiV1ReposGetIsPublic2JsonConverter(),
                    new global::AutoSDK.JsonConverters.ListReposApiV1ReposGetIsPublic2NullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListReposApiV1ReposGetSortDirectionVariant1JsonConverter(),
                    new global::AutoSDK.JsonConverters.ListReposApiV1ReposGetSortDirectionVariant1NullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListReposApiV1ReposGetSortDirectionVariant2JsonConverter(),
                    new global::AutoSDK.JsonConverters.ListReposApiV1ReposGetSortDirectionVariant2NullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListRepoTagsApiV1ReposTagsGetIsArchived2JsonConverter(),
                    new global::AutoSDK.JsonConverters.ListRepoTagsApiV1ReposTagsGetIsArchived2NullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.ListRepoTagsApiV1ReposTagsGetIsPublic2JsonConverter(),
                    new global::AutoSDK.JsonConverters.ListRepoTagsApiV1ReposTagsGetIsPublic2NullableJsonConverter(),
                    new global::AutoSDK.JsonConverters.AnyOfJsonConverterFactory2(),
                    new global::AutoSDK.JsonConverters.AllOfJsonConverterFactory1(),
                    new global::AutoSDK.JsonConverters.AnyOfJsonConverterFactory3(),
                    new global::AutoSDK.JsonConverters.AnyOfJsonConverterFactory4(),
                    new global::AutoSDK.JsonConverters.AnyOfJsonConverterFactory6(),
                    new global::AutoSDK.JsonConverters.AnyOfJsonConverterFactory5(),
                    new global::AutoSDK.JsonConverters.OneOfJsonConverterFactory2(),
                    new global::AutoSDK.JsonConverters.OneOfJsonConverterFactory3(),
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