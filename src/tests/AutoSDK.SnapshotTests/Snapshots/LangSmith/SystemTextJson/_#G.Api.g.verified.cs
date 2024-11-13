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
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::G.JsonConverters.AccessScopeJsonConverter(),
                    new global::G.JsonConverters.AccessScopeNullableJsonConverter(),
                    new global::G.JsonConverters.AuthProviderJsonConverter(),
                    new global::G.JsonConverters.AuthProviderNullableJsonConverter(),
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
                    new global::G.JsonConverters.BulkExportFormatJsonConverter(),
                    new global::G.JsonConverters.BulkExportFormatNullableJsonConverter(),
                    new global::G.JsonConverters.BulkExportCompressionJsonConverter(),
                    new global::G.JsonConverters.BulkExportCompressionNullableJsonConverter(),
                    new global::G.JsonConverters.BulkExportStatusJsonConverter(),
                    new global::G.JsonConverters.BulkExportStatusNullableJsonConverter(),
                    new global::G.JsonConverters.BulkExportDestinationTypeJsonConverter(),
                    new global::G.JsonConverters.BulkExportDestinationTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BulkExportRunStatusJsonConverter(),
                    new global::G.JsonConverters.BulkExportRunStatusNullableJsonConverter(),
                    new global::G.JsonConverters.BulkExportUpdateStatusJsonConverter(),
                    new global::G.JsonConverters.BulkExportUpdateStatusNullableJsonConverter(),
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
                    new global::G.JsonConverters.TraceTierJsonConverter(),
                    new global::G.JsonConverters.TraceTierNullableJsonConverter(),
                    new global::G.JsonConverters.FeedbackLevelJsonConverter(),
                    new global::G.JsonConverters.FeedbackLevelNullableJsonConverter(),
                    new global::G.JsonConverters.OAuthProviderJsonConverter(),
                    new global::G.JsonConverters.OAuthProviderNullableJsonConverter(),
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
                    new global::G.JsonConverters.TenantShareTokensResponseEntitieDiscriminatorTypeJsonConverter(),
                    new global::G.JsonConverters.TenantShareTokensResponseEntitieDiscriminatorTypeNullableJsonConverter(),
                    new global::G.JsonConverters.TenantUsageLimitTypeJsonConverter(),
                    new global::G.JsonConverters.TenantUsageLimitTypeNullableJsonConverter(),
                    new global::G.JsonConverters.UsageLimitTypeJsonConverter(),
                    new global::G.JsonConverters.UsageLimitTypeNullableJsonConverter(),
                    new global::G.JsonConverters.CreateRunRequestRunTypeJsonConverter(),
                    new global::G.JsonConverters.CreateRunRequestRunTypeNullableJsonConverter(),
                    new global::G.JsonConverters.BatchIngestRunsRequestPostItemRunTypeJsonConverter(),
                    new global::G.JsonConverters.BatchIngestRunsRequestPostItemRunTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ListRulesApiV1RunsRulesGetTypeJsonConverter(),
                    new global::G.JsonConverters.ListRulesApiV1RunsRulesGetTypeNullableJsonConverter(),
                    new global::G.JsonConverters.ListReposApiV1ReposGetIsArchivedJsonConverter(),
                    new global::G.JsonConverters.ListReposApiV1ReposGetIsArchivedNullableJsonConverter(),
                    new global::G.JsonConverters.ListReposApiV1ReposGetIsPublicJsonConverter(),
                    new global::G.JsonConverters.ListReposApiV1ReposGetIsPublicNullableJsonConverter(),
                    new global::G.JsonConverters.ListReposApiV1ReposGetSortDirectionVariant1JsonConverter(),
                    new global::G.JsonConverters.ListReposApiV1ReposGetSortDirectionVariant1NullableJsonConverter(),
                    new global::G.JsonConverters.ListReposApiV1ReposGetSortDirectionVariant2JsonConverter(),
                    new global::G.JsonConverters.ListReposApiV1ReposGetSortDirectionVariant2NullableJsonConverter(),
                    new global::G.JsonConverters.ListRepoTagsApiV1ReposTagsGetIsArchivedJsonConverter(),
                    new global::G.JsonConverters.ListRepoTagsApiV1ReposTagsGetIsArchivedNullableJsonConverter(),
                    new global::G.JsonConverters.ListRepoTagsApiV1ReposTagsGetIsPublicJsonConverter(),
                    new global::G.JsonConverters.ListRepoTagsApiV1ReposTagsGetIsPublicNullableJsonConverter(),
                    new global::G.JsonConverters.EntitiesItemJsonConverter(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.Missing>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.Missing>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<int?, global::G.Missing>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.CustomChartType?, global::G.Missing>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.CustomChartSeriesUpdate>, global::G.Missing>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Guid?, global::G.Missing>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::G.Missing>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.CustomChartSeriesFilters, global::G.Missing>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<int?, double?, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.Missing>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.Missing>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<int?, global::G.Missing>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.Missing>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, global::G.Missing>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::G.Missing>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, global::G.Missing>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<double?, int?, bool?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.AppFeedbackSource, global::G.APIFeedbackSource, global::G.ModelFeedbackSource, global::G.AutoEvalFeedbackSource>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<double?, int?, bool?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.AppFeedbackSource, global::G.APIFeedbackSource, global::G.ModelFeedbackSource, global::G.AutoEvalFeedbackSource>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<double?, int?, bool?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<double?, int?, bool?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<double?, int?, bool?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<object, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<string, int?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<double?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<double?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<double?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<double?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<object>, object>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, double?>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, double?>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, double?>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, double?>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, double?>(),
                    new global::G.JsonConverters.OneOfJsonConverter<string, double?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.FeedbackIngestTokenCreateSchema, global::System.Collections.Generic.IList<global::G.FeedbackIngestTokenCreateSchema>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.DataType>, global::G.DataType?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<double?, int?, bool?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.DateTime?, string>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.ListReposApiV1ReposGetSortDirectionVariant1?, global::G.ListReposApiV1ReposGetSortDirectionVariant2?>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.ExampleWithRuns>, global::System.Collections.Generic.IList<global::G.ExampleWithRunsCH>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::G.FeedbackIngestTokenSchema, global::System.Collections.Generic.IList<global::G.FeedbackIngestTokenSchema>>(),
                    new global::G.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::G.PublicExampleWithRuns>, global::System.Collections.Generic.IList<global::G.ExampleWithRunsCH>>(),
                }
            };


        /// <summary>
        /// 
        /// </summary>
        public TracerSessionsClient TracerSessions => new TracerSessionsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public OrgsClient Orgs => new OrgsClient(HttpClient, authorizations: Authorizations)
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
        public ApiKeyClient ApiKey => new ApiKeyClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ExamplesClient Examples => new ExamplesClient(HttpClient, authorizations: Authorizations)
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
        public RunClient Run => new RunClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FeedbackClient Feedback => new FeedbackClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PublicClient Public => new PublicClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

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
        public AceClient Ace => new AceClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public BulkExportsClient BulkExports => new BulkExportsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TenantClient Tenant => new TenantClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public InfoClient Info => new InfoClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public FeedbackConfigsClient FeedbackConfigs => new FeedbackConfigsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ModelPriceMapClient ModelPriceMap => new ModelPriceMapClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public UsageLimitsClient UsageLimits => new UsageLimitsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TtlSettingsClient TtlSettings => new TtlSettingsClient(HttpClient, authorizations: Authorizations)
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
        public WorkspacesClient Workspaces => new WorkspacesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PlaygroundSettingsClient PlaygroundSettings => new PlaygroundSettingsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ServiceAccountsClient ServiceAccounts => new ServiceAccountsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ChartsClient Charts => new ChartsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ReposClient Repos => new ReposClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public LikesClient Likes => new LikesClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CommitsClient Commits => new CommitsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SettingsClient Settings => new SettingsClient(HttpClient, authorizations: Authorizations)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public EventsClient Events => new EventsClient(HttpClient, authorizations: Authorizations)
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