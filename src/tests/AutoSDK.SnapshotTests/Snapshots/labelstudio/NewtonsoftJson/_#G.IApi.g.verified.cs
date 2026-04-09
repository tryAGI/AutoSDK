//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Label Studio API for data annotation and labeling<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IApi : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::G.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }

        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::G.AutoSDKClientOptions Options { get; }

        /// <summary>
        /// 
        /// </summary>
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public ActionsClient Actions { get; }

        /// <summary>
        /// 
        /// </summary>
        public ActivityLogsClient ActivityLogs { get; }

        /// <summary>
        /// 
        /// </summary>
        public AnalyticsClient Analytics { get; }

        /// <summary>
        /// 
        /// </summary>
        public AnnotationHistoryClient AnnotationHistory { get; }

        /// <summary>
        /// 
        /// </summary>
        public AnnotationReviewsClient AnnotationReviews { get; }

        /// <summary>
        /// 
        /// </summary>
        public AnnotationReviews2Client AnnotationReviews2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public AnnotationsClient Annotations { get; }

        /// <summary>
        /// 
        /// </summary>
        public AwsClient Aws { get; }

        /// <summary>
        /// 
        /// </summary>
        public BillingClient Billing { get; }

        /// <summary>
        /// 
        /// </summary>
        public BlueprintsClient Blueprints { get; }

        /// <summary>
        /// 
        /// </summary>
        public Blueprints2Client Blueprints2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public CommentsClient Comments { get; }

        /// <summary>
        /// 
        /// </summary>
        public Comments2Client Comments2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public DashboardClient Dashboard { get; }

        /// <summary>
        /// 
        /// </summary>
        public DataExplorerClient DataExplorer { get; }

        /// <summary>
        /// 
        /// </summary>
        public DataManagerClient DataManager { get; }

        /// <summary>
        /// 
        /// </summary>
        public DatasetStorageAzureClient DatasetStorageAzure { get; }

        /// <summary>
        /// 
        /// </summary>
        public DatasetStorageGcsClient DatasetStorageGcs { get; }

        /// <summary>
        /// 
        /// </summary>
        public DatasetStorageS3Client DatasetStorageS3 { get; }

        /// <summary>
        /// 
        /// </summary>
        public DatasetsClient Datasets { get; }

        /// <summary>
        /// 
        /// </summary>
        public DimensionsClient Dimensions { get; }

        /// <summary>
        /// 
        /// </summary>
        public Dimensions2Client Dimensions2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public ExportClient Export { get; }

        /// <summary>
        /// 
        /// </summary>
        public ImportClient Import { get; }

        /// <summary>
        /// 
        /// </summary>
        public JwtSettingsClient JwtSettings { get; }

        /// <summary>
        /// 
        /// </summary>
        public LabelsClient Labels { get; }

        /// <summary>
        /// 
        /// </summary>
        public Labels2Client Labels2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public LlmClient Llm { get; }

        /// <summary>
        /// 
        /// </summary>
        public MlClient Ml { get; }

        /// <summary>
        /// 
        /// </summary>
        public ModelProviderConnectionClient ModelProviderConnection { get; }

        /// <summary>
        /// 
        /// </summary>
        public ModelProvidersClient ModelProviders { get; }

        /// <summary>
        /// 
        /// </summary>
        public OrganizationsClient Organizations { get; }

        /// <summary>
        /// 
        /// </summary>
        public Organizations2Client Organizations2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public PausesClient Pauses { get; }

        /// <summary>
        /// 
        /// </summary>
        public PredictionsClient Predictions { get; }

        /// <summary>
        /// 
        /// </summary>
        public Predictions2Client Predictions2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public ProjectRolesClient ProjectRoles { get; }

        /// <summary>
        /// 
        /// </summary>
        public ProjectTemplatesClient ProjectTemplates { get; }

        /// <summary>
        /// 
        /// </summary>
        public ProjectsClient Projects { get; }

        /// <summary>
        /// 
        /// </summary>
        public Projects2Client Projects2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public PromptsClient Prompts { get; }

        /// <summary>
        /// 
        /// </summary>
        public Prompts2Client Prompts2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public SessionPolicyClient SessionPolicy { get; }

        /// <summary>
        /// 
        /// </summary>
        public SsoClient Sso { get; }

        /// <summary>
        /// 
        /// </summary>
        public StatesClient States { get; }

        /// <summary>
        /// 
        /// </summary>
        public StatsClient Stats { get; }

        /// <summary>
        /// 
        /// </summary>
        public StorageClient Storage { get; }

        /// <summary>
        /// 
        /// </summary>
        public StorageAzureClient StorageAzure { get; }

        /// <summary>
        /// 
        /// </summary>
        public StorageAzureSpiClient StorageAzureSpi { get; }

        /// <summary>
        /// 
        /// </summary>
        public StorageDatabricksFilesClient StorageDatabricksFiles { get; }

        /// <summary>
        /// 
        /// </summary>
        public StorageGcsClient StorageGcs { get; }

        /// <summary>
        /// 
        /// </summary>
        public StorageGcsWifClient StorageGcsWif { get; }

        /// <summary>
        /// 
        /// </summary>
        public StorageLocalClient StorageLocal { get; }

        /// <summary>
        /// 
        /// </summary>
        public StorageRedisClient StorageRedis { get; }

        /// <summary>
        /// 
        /// </summary>
        public StorageS3Client StorageS3 { get; }

        /// <summary>
        /// 
        /// </summary>
        public StorageS3RolesClient StorageS3Roles { get; }

        /// <summary>
        /// 
        /// </summary>
        public TasksClient Tasks { get; }

        /// <summary>
        /// 
        /// </summary>
        public Tasks2Client Tasks2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public TokensClient Tokens { get; }

        /// <summary>
        /// 
        /// </summary>
        public UsersClient Users { get; }

        /// <summary>
        /// 
        /// </summary>
        public VersionsClient Versions { get; }

        /// <summary>
        /// 
        /// </summary>
        public ViewsClient Views { get; }

        /// <summary>
        /// 
        /// </summary>
        public WebhooksClient Webhooks { get; }

        /// <summary>
        /// 
        /// </summary>
        public Webhooks2Client Webhooks2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public WorkspacesClient Workspaces { get; }

        /// <summary>
        /// 
        /// </summary>
        public Workspaces2Client Workspaces2 { get; }

    }
}