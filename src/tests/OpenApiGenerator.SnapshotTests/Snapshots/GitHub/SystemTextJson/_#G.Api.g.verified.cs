//HintName: G.Api.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// If no httpClient is provided, a new one will be created.
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class Api : global::System.IDisposable
    {
        private readonly global::System.Net.Http.HttpClient _httpClient;

        public ActionsClient Actions => new ActionsClient(_httpClient);
        public ActivityClient Activity => new ActivityClient(_httpClient);
        public AppsClient Apps => new AppsClient(_httpClient);
        public BillingClient Billing => new BillingClient(_httpClient);
        public ChecksClient Checks => new ChecksClient(_httpClient);
        public CodeScanningClient CodeScanning => new CodeScanningClient(_httpClient);
        public CodesOfConductClient CodesOfConduct => new CodesOfConductClient(_httpClient);
        public EmojisClient Emojis => new EmojisClient(_httpClient);
        public DependabotClient Dependabot => new DependabotClient(_httpClient);
        public DependencyGraphClient DependencyGraph => new DependencyGraphClient(_httpClient);
        public GistsClient Gists => new GistsClient(_httpClient);
        public GitClient Git => new GitClient(_httpClient);
        public GitignoreClient Gitignore => new GitignoreClient(_httpClient);
        public IssuesClient Issues => new IssuesClient(_httpClient);
        public LicensesClient Licenses => new LicensesClient(_httpClient);
        public MarkdownClient Markdown => new MarkdownClient(_httpClient);
        public MergeQueueClient MergeQueue => new MergeQueueClient(_httpClient);
        public MetaClient Meta => new MetaClient(_httpClient);
        public MigrationsClient Migrations => new MigrationsClient(_httpClient);
        public OidcClient Oidc => new OidcClient(_httpClient);
        public OrgsClient Orgs => new OrgsClient(_httpClient);
        public PackagesClient Packages => new PackagesClient(_httpClient);
        public ProjectsClient Projects => new ProjectsClient(_httpClient);
        public PullsClient Pulls => new PullsClient(_httpClient);
        public RateLimitClient RateLimit => new RateLimitClient(_httpClient);
        public ReactionsClient Reactions => new ReactionsClient(_httpClient);
        public ReposClient Repos => new ReposClient(_httpClient);
        public SearchClient Search => new SearchClient(_httpClient);
        public SecretScanningClient SecretScanning => new SecretScanningClient(_httpClient);
        public TeamsClient Teams => new TeamsClient(_httpClient);
        public UsersClient Users => new UsersClient(_httpClient);
        public CodespacesClient Codespaces => new CodespacesClient(_httpClient);
        public CopilotClient Copilot => new CopilotClient(_httpClient);
        public SecurityAdvisoriesClient SecurityAdvisories => new SecurityAdvisoriesClient(_httpClient);
        public InteractionsClient Interactions => new InteractionsClient(_httpClient);
        public ClassroomClient Classroom => new ClassroomClient(_httpClient);
        public DesktopClient Desktop => new DesktopClient(_httpClient);
        public EnterpriseTeamsClient EnterpriseTeams => new EnterpriseTeamsClient(_httpClient);

        /// <summary>
        /// Creates a new instance of the Api.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param>
        public Api(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null)
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri("https://api.github.com");
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
        }
    }
}