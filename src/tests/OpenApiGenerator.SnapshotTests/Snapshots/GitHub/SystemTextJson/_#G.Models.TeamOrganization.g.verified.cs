//HintName: G.Models.TeamOrganization.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Team Organization
    /// </summary>
    public sealed partial class TeamOrganization
    {
        /// <summary>
        /// <br/>Example: github
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Login { get; set; }

        /// <summary>
        /// <br/>Example: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// <br/>Example: MDEyOk9yZ2FuaXphdGlvbjE=
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/orgs/github
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/orgs/github/repos
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repos_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReposUrl { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/orgs/github/events
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventsUrl { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/orgs/github/hooks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hooks_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HooksUrl { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/orgs/github/issues
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssuesUrl { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/orgs/github/members{/member}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MembersUrl { get; set; }

        /// <summary>
        /// <br/>Example: https://api.github.com/orgs/github/public_members{/member}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_members_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PublicMembersUrl { get; set; }

        /// <summary>
        /// <br/>Example: https://github.com/images/error/octocat_happy.gif
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AvatarUrl { get; set; }

        /// <summary>
        /// <br/>Example: A great organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Description { get; set; }

        /// <summary>
        /// <br/>Example: github
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// <br/>Example: GitHub
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("company")]
        public string? Company { get; set; }

        /// <summary>
        /// <br/>Example: https://github.com/blog
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blog")]
        public string? Blog { get; set; }

        /// <summary>
        /// <br/>Example: San Francisco
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public string? Location { get; set; }

        /// <summary>
        /// <br/>Example: octocat@github.com
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// <br/>Example: github
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("twitter_username")]
        public string? TwitterUsername { get; set; }

        /// <summary>
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_verified")]
        public bool IsVerified { get; set; }

        /// <summary>
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_organization_projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasOrganizationProjects { get; set; }

        /// <summary>
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_repository_projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasRepositoryProjects { get; set; }

        /// <summary>
        /// <br/>Example: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_repos")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PublicRepos { get; set; }

        /// <summary>
        /// <br/>Example: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_gists")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PublicGists { get; set; }

        /// <summary>
        /// <br/>Example: 20
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("followers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Followers { get; set; }

        /// <summary>
        /// <br/>Example: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("following")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Following { get; set; }

        /// <summary>
        /// <br/>Example: https://github.com/octocat
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// <br/>Example: Organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// <br/>Example: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_private_repos")]
        public int TotalPrivateRepos { get; set; }

        /// <summary>
        /// <br/>Example: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owned_private_repos")]
        public int OwnedPrivateRepos { get; set; }

        /// <summary>
        /// <br/>Example: 81
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("private_gists")]
        public int? PrivateGists { get; set; }

        /// <summary>
        /// <br/>Example: 10000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disk_usage")]
        public int? DiskUsage { get; set; }

        /// <summary>
        /// <br/>Example: 8
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collaborators")]
        public int? Collaborators { get; set; }

        /// <summary>
        /// <br/>Example: org@example.com
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_email")]
        public string? BillingEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        public TeamOrganizationPlan? Plan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_repository_permission")]
        public string? DefaultRepositoryPermission { get; set; }

        /// <summary>
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_can_create_repositories")]
        public bool? MembersCanCreateRepositories { get; set; }

        /// <summary>
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("two_factor_requirement_enabled")]
        public bool? TwoFactorRequirementEnabled { get; set; }

        /// <summary>
        /// <br/>Example: all
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_allowed_repository_creation_type")]
        public string? MembersAllowedRepositoryCreationType { get; set; }

        /// <summary>
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_can_create_public_repositories")]
        public bool MembersCanCreatePublicRepositories { get; set; }

        /// <summary>
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_can_create_private_repositories")]
        public bool MembersCanCreatePrivateRepositories { get; set; }

        /// <summary>
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_can_create_internal_repositories")]
        public bool MembersCanCreateInternalRepositories { get; set; }

        /// <summary>
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_can_create_pages")]
        public bool MembersCanCreatePages { get; set; }

        /// <summary>
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_can_create_public_pages")]
        public bool MembersCanCreatePublicPages { get; set; }

        /// <summary>
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_can_create_private_pages")]
        public bool MembersCanCreatePrivatePages { get; set; }

        /// <summary>
        /// <br/>Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_can_fork_private_repositories")]
        public bool? MembersCanForkPrivateRepositories { get; set; }

        /// <summary>
        /// <br/>Example: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_commit_signoff_required")]
        public bool WebCommitSignoffRequired { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? ArchivedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}