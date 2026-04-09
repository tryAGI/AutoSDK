//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Label Studio API for data annotation and labeling<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::G.IApi, global::System.IDisposable
    {
        /// <summary>
        /// Label Studio
        /// </summary>
        public const string DefaultBaseUrl = "http://localhost:8000/";

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
        public global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; } = new global::Newtonsoft.Json.JsonSerializerSettings
            {
                Converters =
                {
                    new global::G.JsonConverters.ActionEnumJsonConverter(),

                    new global::G.JsonConverters.ActionEnumNullableJsonConverter(),

                    new global::G.JsonConverters.ActionsEnumJsonConverter(),

                    new global::G.JsonConverters.ActionsEnumNullableJsonConverter(),

                    new global::G.JsonConverters.AgreementMethodologyEnumJsonConverter(),

                    new global::G.JsonConverters.AgreementMethodologyEnumNullableJsonConverter(),

                    new global::G.JsonConverters.AgreementV2BackfillJobStatusEnumJsonConverter(),

                    new global::G.JsonConverters.AgreementV2BackfillJobStatusEnumNullableJsonConverter(),

                    new global::G.JsonConverters.AnnotatedEnumJsonConverter(),

                    new global::G.JsonConverters.AnnotatedEnumNullableJsonConverter(),

                    new global::G.JsonConverters.AuthMethodEnumJsonConverter(),

                    new global::G.JsonConverters.AuthMethodEnumNullableJsonConverter(),

                    new global::G.JsonConverters.AuthTypeEnumJsonConverter(),

                    new global::G.JsonConverters.AuthTypeEnumNullableJsonConverter(),

                    new global::G.JsonConverters.BudgetResetPeriodEnumJsonConverter(),

                    new global::G.JsonConverters.BudgetResetPeriodEnumNullableJsonConverter(),

                    new global::G.JsonConverters.DashboardTypeEnumJsonConverter(),

                    new global::G.JsonConverters.DashboardTypeEnumNullableJsonConverter(),

                    new global::G.JsonConverters.Default165EnumJsonConverter(),

                    new global::G.JsonConverters.Default165EnumNullableJsonConverter(),

                    new global::G.JsonConverters.EditionEnumJsonConverter(),

                    new global::G.JsonConverters.EditionEnumNullableJsonConverter(),

                    new global::G.JsonConverters.FinishedEnumJsonConverter(),

                    new global::G.JsonConverters.FinishedEnumNullableJsonConverter(),

                    new global::G.JsonConverters.LabelStreamTaskDistributionEnumJsonConverter(),

                    new global::G.JsonConverters.LabelStreamTaskDistributionEnumNullableJsonConverter(),

                    new global::G.JsonConverters.LastActionEnumJsonConverter(),

                    new global::G.JsonConverters.LastActionEnumNullableJsonConverter(),

                    new global::G.JsonConverters.ModeEnumJsonConverter(),

                    new global::G.JsonConverters.ModeEnumNullableJsonConverter(),

                    new global::G.JsonConverters.ModelRunStatusEnumJsonConverter(),

                    new global::G.JsonConverters.ModelRunStatusEnumNullableJsonConverter(),

                    new global::G.JsonConverters.OnboardingStateEnumJsonConverter(),

                    new global::G.JsonConverters.OnboardingStateEnumNullableJsonConverter(),

                    new global::G.JsonConverters.Options165EnumJsonConverter(),

                    new global::G.JsonConverters.Options165EnumNullableJsonConverter(),

                    new global::G.JsonConverters.OrganizationMemberTagImportStatusStatusEnumJsonConverter(),

                    new global::G.JsonConverters.OrganizationMemberTagImportStatusStatusEnumNullableJsonConverter(),

                    new global::G.JsonConverters.ProjectGroupRoleEnumJsonConverter(),

                    new global::G.JsonConverters.ProjectGroupRoleEnumNullableJsonConverter(),

                    new global::G.JsonConverters.ProjectSubsetEnumJsonConverter(),

                    new global::G.JsonConverters.ProjectSubsetEnumNullableJsonConverter(),

                    new global::G.JsonConverters.PromptsStatusEnumJsonConverter(),

                    new global::G.JsonConverters.PromptsStatusEnumNullableJsonConverter(),

                    new global::G.JsonConverters.ProviderEnumJsonConverter(),

                    new global::G.JsonConverters.ProviderEnumNullableJsonConverter(),

                    new global::G.JsonConverters.ReasonEnumJsonConverter(),

                    new global::G.JsonConverters.ReasonEnumNullableJsonConverter(),

                    new global::G.JsonConverters.RequeueRejectedTasksModeEnumJsonConverter(),

                    new global::G.JsonConverters.RequeueRejectedTasksModeEnumNullableJsonConverter(),

                    new global::G.JsonConverters.ReviewCriteriaEnumJsonConverter(),

                    new global::G.JsonConverters.ReviewCriteriaEnumNullableJsonConverter(),

                    new global::G.JsonConverters.ReviewSettingsSamplingEnumJsonConverter(),

                    new global::G.JsonConverters.ReviewSettingsSamplingEnumNullableJsonConverter(),

                    new global::G.JsonConverters.ReviewedEnumJsonConverter(),

                    new global::G.JsonConverters.ReviewedEnumNullableJsonConverter(),

                    new global::G.JsonConverters.Role9e7EnumJsonConverter(),

                    new global::G.JsonConverters.Role9e7EnumNullableJsonConverter(),

                    new global::G.JsonConverters.SamplingDe5EnumJsonConverter(),

                    new global::G.JsonConverters.SamplingDe5EnumNullableJsonConverter(),

                    new global::G.JsonConverters.ScopeEnumJsonConverter(),

                    new global::G.JsonConverters.ScopeEnumNullableJsonConverter(),

                    new global::G.JsonConverters.SegmentationEnumJsonConverter(),

                    new global::G.JsonConverters.SegmentationEnumNullableJsonConverter(),

                    new global::G.JsonConverters.SkillNameEnumJsonConverter(),

                    new global::G.JsonConverters.SkillNameEnumNullableJsonConverter(),

                    new global::G.JsonConverters.SkipQueueEnumJsonConverter(),

                    new global::G.JsonConverters.SkipQueueEnumNullableJsonConverter(),

                    new global::G.JsonConverters.SkippedEnumJsonConverter(),

                    new global::G.JsonConverters.SkippedEnumNullableJsonConverter(),

                    new global::G.JsonConverters.StateEnumJsonConverter(),

                    new global::G.JsonConverters.StateEnumNullableJsonConverter(),

                    new global::G.JsonConverters.Status7bfEnumJsonConverter(),

                    new global::G.JsonConverters.Status7bfEnumNullableJsonConverter(),

                    new global::G.JsonConverters.StatusC5aEnumJsonConverter(),

                    new global::G.JsonConverters.StatusC5aEnumNullableJsonConverter(),

                    new global::G.JsonConverters.TrialRoleEnumJsonConverter(),

                    new global::G.JsonConverters.TrialRoleEnumNullableJsonConverter(),

                    new global::G.JsonConverters.TypeEnumJsonConverter(),

                    new global::G.JsonConverters.TypeEnumNullableJsonConverter(),

                    new global::G.JsonConverters.ApiDmActionsCreateRequestFiltersConjunctionJsonConverter(),

                    new global::G.JsonConverters.ApiDmActionsCreateRequestFiltersConjunctionNullableJsonConverter(),

                    new global::G.JsonConverters.ApiDmActionsCreateRequestFiltersItemFilterJsonConverter(),

                    new global::G.JsonConverters.ApiDmActionsCreateRequestFiltersItemFilterNullableJsonConverter(),

                    new global::G.JsonConverters.ApiDmActionsCreateRequestFiltersItemOperatorJsonConverter(),

                    new global::G.JsonConverters.ApiDmActionsCreateRequestFiltersItemOperatorNullableJsonConverter(),

                    new global::G.JsonConverters.ApiDmActionsCreateRequestOrderingItemJsonConverter(),

                    new global::G.JsonConverters.ApiDmActionsCreateRequestOrderingItemNullableJsonConverter(),

                    new global::G.JsonConverters.ApiDmViewsCreateRequestDataFiltersConjunctionJsonConverter(),

                    new global::G.JsonConverters.ApiDmViewsCreateRequestDataFiltersConjunctionNullableJsonConverter(),

                    new global::G.JsonConverters.ApiDmViewsCreateRequestDataFiltersItemFilterJsonConverter(),

                    new global::G.JsonConverters.ApiDmViewsCreateRequestDataFiltersItemFilterNullableJsonConverter(),

                    new global::G.JsonConverters.ApiDmViewsCreateRequestDataFiltersItemOperatorJsonConverter(),

                    new global::G.JsonConverters.ApiDmViewsCreateRequestDataFiltersItemOperatorNullableJsonConverter(),

                    new global::G.JsonConverters.ApiDmViewsCreateRequestDataOrderingItemJsonConverter(),

                    new global::G.JsonConverters.ApiDmViewsCreateRequestDataOrderingItemNullableJsonConverter(),

                    new global::G.JsonConverters.ApiDmViewsPartialUpdateRequestDataFiltersConjunctionJsonConverter(),

                    new global::G.JsonConverters.ApiDmViewsPartialUpdateRequestDataFiltersConjunctionNullableJsonConverter(),

                    new global::G.JsonConverters.ApiDmViewsPartialUpdateRequestDataFiltersItemFilterJsonConverter(),

                    new global::G.JsonConverters.ApiDmViewsPartialUpdateRequestDataFiltersItemFilterNullableJsonConverter(),

                    new global::G.JsonConverters.ApiDmViewsPartialUpdateRequestDataFiltersItemOperatorJsonConverter(),

                    new global::G.JsonConverters.ApiDmViewsPartialUpdateRequestDataFiltersItemOperatorNullableJsonConverter(),

                    new global::G.JsonConverters.ApiDmViewsPartialUpdateRequestDataOrderingItemJsonConverter(),

                    new global::G.JsonConverters.ApiDmViewsPartialUpdateRequestDataOrderingItemNullableJsonConverter(),

                    new global::G.JsonConverters.ApiDmViewsUpdateRequestDataFiltersConjunctionJsonConverter(),

                    new global::G.JsonConverters.ApiDmViewsUpdateRequestDataFiltersConjunctionNullableJsonConverter(),

                    new global::G.JsonConverters.ApiDmViewsUpdateRequestDataFiltersItemFilterJsonConverter(),

                    new global::G.JsonConverters.ApiDmViewsUpdateRequestDataFiltersItemFilterNullableJsonConverter(),

                    new global::G.JsonConverters.ApiDmViewsUpdateRequestDataFiltersItemOperatorJsonConverter(),

                    new global::G.JsonConverters.ApiDmViewsUpdateRequestDataFiltersItemOperatorNullableJsonConverter(),

                    new global::G.JsonConverters.ApiDmViewsUpdateRequestDataOrderingItemJsonConverter(),

                    new global::G.JsonConverters.ApiDmViewsUpdateRequestDataOrderingItemNullableJsonConverter(),

                    new global::G.JsonConverters.ApiLlmOpenaiChatCompletionsCreateRequestMessageRoleJsonConverter(),

                    new global::G.JsonConverters.ApiLlmOpenaiChatCompletionsCreateRequestMessageRoleNullableJsonConverter(),

                    new global::G.JsonConverters.ApiMlCreateRequestAuthMethodJsonConverter(),

                    new global::G.JsonConverters.ApiMlCreateRequestAuthMethodNullableJsonConverter(),

                    new global::G.JsonConverters.ApiMlPartialUpdateRequestAuthMethodJsonConverter(),

                    new global::G.JsonConverters.ApiMlPartialUpdateRequestAuthMethodNullableJsonConverter(),

                    new global::G.JsonConverters.ApiProjectsTasksAssigneesCreateRequestFiltersConjunctionJsonConverter(),

                    new global::G.JsonConverters.ApiProjectsTasksAssigneesCreateRequestFiltersConjunctionNullableJsonConverter(),

                    new global::G.JsonConverters.ApiProjectsTasksAssigneesCreateRequestFiltersItemFilterJsonConverter(),

                    new global::G.JsonConverters.ApiProjectsTasksAssigneesCreateRequestFiltersItemFilterNullableJsonConverter(),

                    new global::G.JsonConverters.ApiProjectsTasksAssigneesCreateRequestFiltersItemOperatorJsonConverter(),

                    new global::G.JsonConverters.ApiProjectsTasksAssigneesCreateRequestFiltersItemOperatorNullableJsonConverter(),

                    new global::G.JsonConverters.ApiProjectsTasksAssigneesCreateRequestTypeJsonConverter(),

                    new global::G.JsonConverters.ApiProjectsTasksAssigneesCreateRequestTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ApiProjectsTasksAssigneesPartialUpdateRequestTypeJsonConverter(),

                    new global::G.JsonConverters.ApiProjectsTasksAssigneesPartialUpdateRequestTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ApiProjectsTasksAssigneesCreate2RequestTypeJsonConverter(),

                    new global::G.JsonConverters.ApiProjectsTasksAssigneesCreate2RequestTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ApiActivityLogsListMethodJsonConverter(),

                    new global::G.JsonConverters.ApiActivityLogsListMethodNullableJsonConverter(),

                    new global::G.JsonConverters.ApiDmActionsCreateIdJsonConverter(),

                    new global::G.JsonConverters.ApiDmActionsCreateIdNullableJsonConverter(),

                    new global::G.JsonConverters.ApiProjectsTasksAssigneesDestroyTypeJsonConverter(),

                    new global::G.JsonConverters.ApiProjectsTasksAssigneesDestroyTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ApiPromptsCompatibleProjectsListProjectTypeJsonConverter(),

                    new global::G.JsonConverters.ApiPromptsCompatibleProjectsListProjectTypeNullableJsonConverter(),

                    new global::G.JsonConverters.ApiPromptsVersionsInferenceRunsListProjectSubsetJsonConverter(),

                    new global::G.JsonConverters.ApiPromptsVersionsInferenceRunsListProjectSubsetNullableJsonConverter(),

                    new global::G.JsonConverters.ApiTasksListFieldsJsonConverter(),

                    new global::G.JsonConverters.ApiTasksListFieldsNullableJsonConverter(),

                    new global::G.JsonConverters.ApiProjectsAwsCustomFunctionRetrieveResponseStatusJsonConverter(),

                    new global::G.JsonConverters.ApiProjectsAwsCustomFunctionRetrieveResponseStatusNullableJsonConverter(),

                    new global::G.JsonConverters.UnixTimestampJsonConverter(),
                }
            };


        /// <summary>
        /// 
        /// </summary>
        public ActionsClient Actions => new ActionsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ActivityLogsClient ActivityLogs => new ActivityLogsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AnalyticsClient Analytics => new AnalyticsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AnnotationHistoryClient AnnotationHistory => new AnnotationHistoryClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AnnotationReviewsClient AnnotationReviews => new AnnotationReviewsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AnnotationReviews2Client AnnotationReviews2 => new AnnotationReviews2Client(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AnnotationsClient Annotations => new AnnotationsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public AwsClient Aws => new AwsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public BillingClient Billing => new BillingClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public BlueprintsClient Blueprints => new BlueprintsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public Blueprints2Client Blueprints2 => new Blueprints2Client(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public CommentsClient Comments => new CommentsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public Comments2Client Comments2 => new Comments2Client(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DashboardClient Dashboard => new DashboardClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DataExplorerClient DataExplorer => new DataExplorerClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DataManagerClient DataManager => new DataManagerClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DatasetStorageAzureClient DatasetStorageAzure => new DatasetStorageAzureClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DatasetStorageGcsClient DatasetStorageGcs => new DatasetStorageGcsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DatasetStorageS3Client DatasetStorageS3 => new DatasetStorageS3Client(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DatasetsClient Datasets => new DatasetsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public DimensionsClient Dimensions => new DimensionsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public Dimensions2Client Dimensions2 => new Dimensions2Client(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ExportClient Export => new ExportClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ImportClient Import => new ImportClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public JwtSettingsClient JwtSettings => new JwtSettingsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public LabelsClient Labels => new LabelsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public Labels2Client Labels2 => new Labels2Client(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public LlmClient Llm => new LlmClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public MlClient Ml => new MlClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ModelProviderConnectionClient ModelProviderConnection => new ModelProviderConnectionClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ModelProvidersClient ModelProviders => new ModelProvidersClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public OrganizationsClient Organizations => new OrganizationsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public Organizations2Client Organizations2 => new Organizations2Client(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PausesClient Pauses => new PausesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PredictionsClient Predictions => new PredictionsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public Predictions2Client Predictions2 => new Predictions2Client(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ProjectRolesClient ProjectRoles => new ProjectRolesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ProjectTemplatesClient ProjectTemplates => new ProjectTemplatesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ProjectsClient Projects => new ProjectsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public Projects2Client Projects2 => new Projects2Client(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public PromptsClient Prompts => new PromptsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public Prompts2Client Prompts2 => new Prompts2Client(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SessionPolicyClient SessionPolicy => new SessionPolicyClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public SsoClient Sso => new SsoClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public StatesClient States => new StatesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public StatsClient Stats => new StatsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public StorageClient Storage => new StorageClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public StorageAzureClient StorageAzure => new StorageAzureClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public StorageAzureSpiClient StorageAzureSpi => new StorageAzureSpiClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public StorageDatabricksFilesClient StorageDatabricksFiles => new StorageDatabricksFilesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public StorageGcsClient StorageGcs => new StorageGcsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public StorageGcsWifClient StorageGcsWif => new StorageGcsWifClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public StorageLocalClient StorageLocal => new StorageLocalClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public StorageRedisClient StorageRedis => new StorageRedisClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public StorageS3Client StorageS3 => new StorageS3Client(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public StorageS3RolesClient StorageS3Roles => new StorageS3RolesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TasksClient Tasks => new TasksClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public Tasks2Client Tasks2 => new Tasks2Client(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public TokensClient Tokens => new TokensClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public UsersClient Users => new UsersClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public VersionsClient Versions => new VersionsClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public ViewsClient Views => new ViewsClient(HttpClient, authorizations: Authorizations, options: Options)
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
        /// 
        /// </summary>
        public Webhooks2Client Webhooks2 => new Webhooks2Client(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public WorkspacesClient Workspaces => new WorkspacesClient(HttpClient, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerOptions = JsonSerializerOptions,
        };

        /// <summary>
        /// 
        /// </summary>
        public Workspaces2Client Workspaces2 => new Workspaces2Client(HttpClient, authorizations: Authorizations, options: Options)
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