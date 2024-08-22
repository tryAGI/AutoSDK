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
                    new global::OpenApiGenerator.JsonConverters.AccessScopeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AccessScopeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunTypeEnumJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunTypeEnumNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunsFilterDataSourceTypeEnumJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunsFilterDataSourceTypeEnumNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunSelectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunSelectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunDateOrderJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunDateOrderNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DataType2JsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.DataType2NullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChangePaymentPlanReqJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ChangePaymentPlanReqNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ConfiguredByJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ConfiguredByNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateEventRequestEventTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateEventRequestEventTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FeedbackTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FeedbackTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CustomChartTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CustomChartTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CustomChartMetricJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CustomChartMetricNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PaymentPlanTierJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PaymentPlanTierNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ExampleListOrderJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ExampleListOrderNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ExampleSelectJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ExampleSelectNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.TraceTier3JsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.TraceTier3NullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FeedbackLevelJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.FeedbackLevelNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.OrgFeatureFlagsJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.OrgFeatureFlagsNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.OrganizationDashboardColorSchemeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.OrganizationDashboardColorSchemeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.OrganizationDashboardTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.OrganizationDashboardTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PagerdutySeverityJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.PagerdutySeverityNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunsGenerateQueryFeedbackKeysJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunsGenerateQueryFeedbackKeysNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ResourceTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ResourceTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RuleLogActionOutcomeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RuleLogActionOutcomeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunGroupByJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunGroupByNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunRulesAlertTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.RunRulesAlertTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SessionSortableColumnsJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SessionSortableColumnsNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SortByComparativeExperimentColumnJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SortByComparativeExperimentColumnNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SortByDatasetColumnJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SortByDatasetColumnNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SourceTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.SourceTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.TenantShareDatasetTokenTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.TenantShareDatasetTokenTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.TenantShareRunTokenTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.TenantShareRunTokenTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.TenantUsageLimitTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.TenantUsageLimitTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UsageLimitType2JsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.UsageLimitType2NullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateRunRequestRunTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.CreateRunRequestRunTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.BatchIngestRunsRequestPostItemRunTypeJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.BatchIngestRunsRequestPostItemRunTypeNullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListReposApiV1ReposGetIsArchived2JsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListReposApiV1ReposGetIsArchived2NullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListReposApiV1ReposGetIsPublic2JsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListReposApiV1ReposGetIsPublic2NullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListReposApiV1ReposGetSortDirectionVariant1JsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListReposApiV1ReposGetSortDirectionVariant1NullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListReposApiV1ReposGetSortDirectionVariant2JsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListReposApiV1ReposGetSortDirectionVariant2NullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListRepoTagsApiV1ReposTagsGetIsArchived2JsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListRepoTagsApiV1ReposTagsGetIsArchived2NullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListRepoTagsApiV1ReposTagsGetIsPublic2JsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.ListRepoTagsApiV1ReposTagsGetIsPublic2NullableJsonConverter(),
                    new global::OpenApiGenerator.JsonConverters.AnyOfJsonConverterFactory2(),
                    new global::OpenApiGenerator.JsonConverters.AllOfJsonConverterFactory1(),
                    new global::OpenApiGenerator.JsonConverters.AnyOfJsonConverterFactory3(),
                    new global::OpenApiGenerator.JsonConverters.AnyOfJsonConverterFactory4(),
                    new global::OpenApiGenerator.JsonConverters.AnyOfJsonConverterFactory6(),
                    new global::OpenApiGenerator.JsonConverters.AnyOfJsonConverterFactory5(),
                    new global::OpenApiGenerator.JsonConverters.OneOfJsonConverterFactory2(),
                    new global::OpenApiGenerator.JsonConverters.OneOfJsonConverterFactory3(),
                }
            };
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
        }

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