//HintName: G.IApi.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GitHub's v3 REST API.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IApi : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::Newtonsoft.Json.JsonSerializerSettings JsonSerializerOptions { get; set; }


        /// <summary>
        /// Endpoints to manage GitHub Actions using the REST API.
        /// </summary>
        public ActionsClient Actions { get; }

        /// <summary>
        /// Activity APIs provide access to notifications, subscriptions, and timelines.
        /// </summary>
        public ActivityClient Activity { get; }

        /// <summary>
        /// Information for integrations and installations.
        /// </summary>
        public AppsClient Apps { get; }

        /// <summary>
        /// Monitor charges and usage from Actions and Packages.
        /// </summary>
        public BillingClient Billing { get; }

        /// <summary>
        /// Rich interactions with checks run by your integrations.
        /// </summary>
        public ChecksClient Checks { get; }

        /// <summary>
        /// Retrieve code scanning alerts from a repository.
        /// </summary>
        public CodeScanningClient CodeScanning { get; }

        /// <summary>
        /// Insight into codes of conduct for your communities.
        /// </summary>
        public CodesOfConductClient CodesOfConduct { get; }

        /// <summary>
        /// List emojis available to use on GitHub.
        /// </summary>
        public EmojisClient Emojis { get; }

        /// <summary>
        /// Endpoints to manage Dependabot.
        /// </summary>
        public DependabotClient Dependabot { get; }

        /// <summary>
        /// Endpoints to access Dependency Graph features.
        /// </summary>
        public DependencyGraphClient DependencyGraph { get; }

        /// <summary>
        /// View, modify your gists.
        /// </summary>
        public GistsClient Gists { get; }

        /// <summary>
        /// Raw Git functionality.
        /// </summary>
        public GitClient Git { get; }

        /// <summary>
        /// View gitignore templates
        /// </summary>
        public GitignoreClient Gitignore { get; }

        /// <summary>
        /// Interact with GitHub Issues.
        /// </summary>
        public IssuesClient Issues { get; }

        /// <summary>
        /// View various OSS licenses.
        /// </summary>
        public LicensesClient Licenses { get; }

        /// <summary>
        /// Render GitHub flavored markdown
        /// </summary>
        public MarkdownClient Markdown { get; }

        /// <summary>
        /// Interact with GitHub Merge Queues.
        /// </summary>
        public MergeQueueClient MergeQueue { get; }

        /// <summary>
        /// Endpoints that give information about the API.
        /// </summary>
        public MetaClient Meta { get; }

        /// <summary>
        /// Move projects to or from GitHub.
        /// </summary>
        public MigrationsClient Migrations { get; }

        /// <summary>
        /// Endpoints to manage GitHub OIDC configuration using the REST API.
        /// </summary>
        public OidcClient Oidc { get; }

        /// <summary>
        /// Interact with GitHub Orgs.
        /// </summary>
        public OrgsClient Orgs { get; }

        /// <summary>
        /// Manage packages for authenticated users and organizations.
        /// </summary>
        public PackagesClient Packages { get; }

        /// <summary>
        /// Interact with GitHub Projects.
        /// </summary>
        public ProjectsClient Projects { get; }

        /// <summary>
        /// Interact with GitHub Pull Requests.
        /// </summary>
        public PullsClient Pulls { get; }

        /// <summary>
        /// Check your current rate limit status
        /// </summary>
        public RateLimitClient RateLimit { get; }

        /// <summary>
        /// Interact with reactions to various GitHub entities.
        /// </summary>
        public ReactionsClient Reactions { get; }

        /// <summary>
        /// Interact with GitHub Repos.
        /// </summary>
        public ReposClient Repos { get; }

        /// <summary>
        /// Look for stuff on GitHub.
        /// </summary>
        public SearchClient Search { get; }

        /// <summary>
        /// Retrieve secret scanning alerts from a repository.
        /// </summary>
        public SecretScanningClient SecretScanning { get; }

        /// <summary>
        /// Interact with GitHub Teams.
        /// </summary>
        public TeamsClient Teams { get; }

        /// <summary>
        /// Interact with and view information about users and also current user.
        /// </summary>
        public UsersClient Users { get; }

        /// <summary>
        /// Endpoints to manage Codespaces using the REST API.
        /// </summary>
        public CodespacesClient Codespaces { get; }

        /// <summary>
        /// Endpoints to manage Copilot using the REST API.
        /// </summary>
        public CopilotClient Copilot { get; }

        /// <summary>
        /// Manage security advisories.
        /// </summary>
        public SecurityAdvisoriesClient SecurityAdvisories { get; }

        /// <summary>
        /// Owner or admin management of users interactions.
        /// </summary>
        public InteractionsClient Interactions { get; }

        /// <summary>
        /// Interact with GitHub Classroom.
        /// </summary>
        public ClassroomClient Classroom { get; }

        /// <summary>
        /// Desktop specific endpoints.
        /// </summary>
        public DesktopClient Desktop { get; }

        /// <summary>
        /// Endpoints to manage GitHub Enterprise Teams.
        /// </summary>
        public EnterpriseTeamsClient EnterpriseTeams { get; }

    }
}