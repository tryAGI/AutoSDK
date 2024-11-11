//HintName: G.Models.OrganizationFull.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Organization Full
    /// </summary>
    public sealed partial class OrganizationFull
    {
        /// <summary>
        /// Example: github
        /// </summary>
        /// <example>github</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("login")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Login { get; set; }

        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Example: MDEyOk9yZ2FuaXphdGlvbjE=
        /// </summary>
        /// <example>MDEyOk9yZ2FuaXphdGlvbjE=</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NodeId { get; set; }

        /// <summary>
        /// Example: https://api.github.com/orgs/github
        /// </summary>
        /// <example>https://api.github.com/orgs/github</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: https://api.github.com/orgs/github/repos
        /// </summary>
        /// <example>https://api.github.com/orgs/github/repos</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("repos_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReposUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/orgs/github/events
        /// </summary>
        /// <example>https://api.github.com/orgs/github/events</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("events_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventsUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/orgs/github/hooks
        /// </summary>
        /// <example>https://api.github.com/orgs/github/hooks</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("hooks_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HooksUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/orgs/github/issues
        /// </summary>
        /// <example>https://api.github.com/orgs/github/issues</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("issues_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IssuesUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/orgs/github/members{/member}
        /// </summary>
        /// <example>https://api.github.com/orgs/github/members{/member}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MembersUrl { get; set; }

        /// <summary>
        /// Example: https://api.github.com/orgs/github/public_members{/member}
        /// </summary>
        /// <example>https://api.github.com/orgs/github/public_members{/member}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_members_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PublicMembersUrl { get; set; }

        /// <summary>
        /// Example: https://github.com/images/error/octocat_happy.gif
        /// </summary>
        /// <example>https://github.com/images/error/octocat_happy.gif</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatar_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AvatarUrl { get; set; }

        /// <summary>
        /// Example: A great organization
        /// </summary>
        /// <example>A great organization</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Description { get; set; }

        /// <summary>
        /// Example: github
        /// </summary>
        /// <example>github</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Example: GitHub
        /// </summary>
        /// <example>GitHub</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("company")]
        public string? Company { get; set; }

        /// <summary>
        /// Example: https://github.com/blog
        /// </summary>
        /// <example>https://github.com/blog</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("blog")]
        public string? Blog { get; set; }

        /// <summary>
        /// Example: San Francisco
        /// </summary>
        /// <example>San Francisco</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("location")]
        public string? Location { get; set; }

        /// <summary>
        /// Example: octocat@github.com
        /// </summary>
        /// <example>octocat@github.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Example: github
        /// </summary>
        /// <example>github</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("twitter_username")]
        public string? TwitterUsername { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_verified")]
        public bool? IsVerified { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_organization_projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasOrganizationProjects { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_repository_projects")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasRepositoryProjects { get; set; }

        /// <summary>
        /// Example: 2
        /// </summary>
        /// <example>2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_repos")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PublicRepos { get; set; }

        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_gists")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PublicGists { get; set; }

        /// <summary>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("followers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Followers { get; set; }

        /// <summary>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("following")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Following { get; set; }

        /// <summary>
        /// Example: https://github.com/octocat
        /// </summary>
        /// <example>https://github.com/octocat</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("html_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HtmlUrl { get; set; }

        /// <summary>
        /// Example: Organization
        /// </summary>
        /// <example>Organization</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_private_repos")]
        public int? TotalPrivateRepos { get; set; }

        /// <summary>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("owned_private_repos")]
        public int? OwnedPrivateRepos { get; set; }

        /// <summary>
        /// Example: 81
        /// </summary>
        /// <example>81</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("private_gists")]
        public int? PrivateGists { get; set; }

        /// <summary>
        /// Example: 10000
        /// </summary>
        /// <example>10000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("disk_usage")]
        public int? DiskUsage { get; set; }

        /// <summary>
        /// Example: org@example.com
        /// </summary>
        /// <example>org@example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_email")]
        public string? BillingEmail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        public global::G.OrganizationFullPlan? Plan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_repository_permission")]
        public string? DefaultRepositoryPermission { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_can_create_repositories")]
        public bool? MembersCanCreateRepositories { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("two_factor_requirement_enabled")]
        public bool? TwoFactorRequirementEnabled { get; set; }

        /// <summary>
        /// Example: all
        /// </summary>
        /// <example>all</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_allowed_repository_creation_type")]
        public string? MembersAllowedRepositoryCreationType { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_can_create_public_repositories")]
        public bool? MembersCanCreatePublicRepositories { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_can_create_private_repositories")]
        public bool? MembersCanCreatePrivateRepositories { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_can_create_internal_repositories")]
        public bool? MembersCanCreateInternalRepositories { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_can_create_pages")]
        public bool? MembersCanCreatePages { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_can_create_public_pages")]
        public bool? MembersCanCreatePublicPages { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_can_create_private_pages")]
        public bool? MembersCanCreatePrivatePages { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("members_can_fork_private_repositories")]
        public bool? MembersCanForkPrivateRepositories { get; set; }

        /// <summary>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("web_commit_signoff_required")]
        public bool? WebCommitSignoffRequired { get; set; }

        /// <summary>
        /// **Deprecated.** Please use [code security configurations](https://docs.github.com/rest/code-security/configurations) instead.<br/>
        /// Whether GitHub Advanced Security is enabled for new repositories and repositories transferred to this organization.<br/>
        /// This field is only visible to organization owners or members of a team with the security manager role.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("advanced_security_enabled_for_new_repositories")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? AdvancedSecurityEnabledForNewRepositories { get; set; }

        /// <summary>
        /// **Deprecated.** Please use [code security configurations](https://docs.github.com/rest/code-security/configurations) instead.<br/>
        /// Whether Dependabot alerts are automatically enabled for new repositories and repositories transferred to this organization.<br/>
        /// This field is only visible to organization owners or members of a team with the security manager role.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot_alerts_enabled_for_new_repositories")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? DependabotAlertsEnabledForNewRepositories { get; set; }

        /// <summary>
        /// **Deprecated.** Please use [code security configurations](https://docs.github.com/rest/code-security/configurations) instead.<br/>
        /// Whether Dependabot security updates are automatically enabled for new repositories and repositories transferred to this organization.<br/>
        /// This field is only visible to organization owners or members of a team with the security manager role.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependabot_security_updates_enabled_for_new_repositories")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? DependabotSecurityUpdatesEnabledForNewRepositories { get; set; }

        /// <summary>
        /// **Deprecated.** Please use [code security configurations](https://docs.github.com/rest/code-security/configurations) instead.<br/>
        /// Whether dependency graph is automatically enabled for new repositories and repositories transferred to this organization.<br/>
        /// This field is only visible to organization owners or members of a team with the security manager role.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependency_graph_enabled_for_new_repositories")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? DependencyGraphEnabledForNewRepositories { get; set; }

        /// <summary>
        /// **Deprecated.** Please use [code security configurations](https://docs.github.com/rest/code-security/configurations) instead.<br/>
        /// Whether secret scanning is automatically enabled for new repositories and repositories transferred to this organization.<br/>
        /// This field is only visible to organization owners or members of a team with the security manager role.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_enabled_for_new_repositories")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? SecretScanningEnabledForNewRepositories { get; set; }

        /// <summary>
        /// **Deprecated.** Please use [code security configurations](https://docs.github.com/rest/code-security/configurations) instead.<br/>
        /// Whether secret scanning push protection is automatically enabled for new repositories and repositories transferred to this organization.<br/>
        /// This field is only visible to organization owners or members of a team with the security manager role.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_push_protection_enabled_for_new_repositories")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? SecretScanningPushProtectionEnabledForNewRepositories { get; set; }

        /// <summary>
        /// Whether a custom link is shown to contributors who are blocked from pushing a secret by push protection.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_push_protection_custom_link_enabled")]
        public bool? SecretScanningPushProtectionCustomLinkEnabled { get; set; }

        /// <summary>
        /// An optional URL string to display to contributors who are blocked from pushing a secret.<br/>
        /// Example: https://github.com/test-org/test-repo/blob/main/README.md
        /// </summary>
        /// <example>https://github.com/test-org/test-repo/blob/main/README.md</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret_scanning_push_protection_custom_link")]
        public string? SecretScanningPushProtectionCustomLink { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

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

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationFull" /> class.
        /// </summary>
        /// <param name="login">
        /// Example: github
        /// </param>
        /// <param name="id">
        /// Example: 1
        /// </param>
        /// <param name="nodeId">
        /// Example: MDEyOk9yZ2FuaXphdGlvbjE=
        /// </param>
        /// <param name="url">
        /// Example: https://api.github.com/orgs/github
        /// </param>
        /// <param name="reposUrl">
        /// Example: https://api.github.com/orgs/github/repos
        /// </param>
        /// <param name="eventsUrl">
        /// Example: https://api.github.com/orgs/github/events
        /// </param>
        /// <param name="hooksUrl">
        /// Example: https://api.github.com/orgs/github/hooks
        /// </param>
        /// <param name="issuesUrl">
        /// Example: https://api.github.com/orgs/github/issues
        /// </param>
        /// <param name="membersUrl">
        /// Example: https://api.github.com/orgs/github/members{/member}
        /// </param>
        /// <param name="publicMembersUrl">
        /// Example: https://api.github.com/orgs/github/public_members{/member}
        /// </param>
        /// <param name="avatarUrl">
        /// Example: https://github.com/images/error/octocat_happy.gif
        /// </param>
        /// <param name="description">
        /// Example: A great organization
        /// </param>
        /// <param name="name">
        /// Example: github
        /// </param>
        /// <param name="company">
        /// Example: GitHub
        /// </param>
        /// <param name="blog">
        /// Example: https://github.com/blog
        /// </param>
        /// <param name="location">
        /// Example: San Francisco
        /// </param>
        /// <param name="email">
        /// Example: octocat@github.com
        /// </param>
        /// <param name="twitterUsername">
        /// Example: github
        /// </param>
        /// <param name="isVerified">
        /// Example: true
        /// </param>
        /// <param name="hasOrganizationProjects">
        /// Example: true
        /// </param>
        /// <param name="hasRepositoryProjects">
        /// Example: true
        /// </param>
        /// <param name="publicRepos">
        /// Example: 2
        /// </param>
        /// <param name="publicGists">
        /// Example: 1
        /// </param>
        /// <param name="followers">
        /// Example: 20
        /// </param>
        /// <param name="following">
        /// Example: 0
        /// </param>
        /// <param name="htmlUrl">
        /// Example: https://github.com/octocat
        /// </param>
        /// <param name="type">
        /// Example: Organization
        /// </param>
        /// <param name="totalPrivateRepos">
        /// Example: 100
        /// </param>
        /// <param name="ownedPrivateRepos">
        /// Example: 100
        /// </param>
        /// <param name="privateGists">
        /// Example: 81
        /// </param>
        /// <param name="diskUsage">
        /// Example: 10000
        /// </param>
        /// <param name="billingEmail">
        /// Example: org@example.com
        /// </param>
        /// <param name="plan"></param>
        /// <param name="defaultRepositoryPermission"></param>
        /// <param name="membersCanCreateRepositories">
        /// Example: true
        /// </param>
        /// <param name="twoFactorRequirementEnabled">
        /// Example: true
        /// </param>
        /// <param name="membersAllowedRepositoryCreationType">
        /// Example: all
        /// </param>
        /// <param name="membersCanCreatePublicRepositories">
        /// Example: true
        /// </param>
        /// <param name="membersCanCreatePrivateRepositories">
        /// Example: true
        /// </param>
        /// <param name="membersCanCreateInternalRepositories">
        /// Example: true
        /// </param>
        /// <param name="membersCanCreatePages">
        /// Example: true
        /// </param>
        /// <param name="membersCanCreatePublicPages">
        /// Example: true
        /// </param>
        /// <param name="membersCanCreatePrivatePages">
        /// Example: true
        /// </param>
        /// <param name="membersCanForkPrivateRepositories">
        /// Example: false
        /// </param>
        /// <param name="webCommitSignoffRequired">
        /// Example: false
        /// </param>
        /// <param name="secretScanningPushProtectionCustomLinkEnabled">
        /// Whether a custom link is shown to contributors who are blocked from pushing a secret by push protection.<br/>
        /// Example: false
        /// </param>
        /// <param name="secretScanningPushProtectionCustomLink">
        /// An optional URL string to display to contributors who are blocked from pushing a secret.<br/>
        /// Example: https://github.com/test-org/test-repo/blob/main/README.md
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="archivedAt"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public OrganizationFull(
            string login,
            int id,
            string nodeId,
            string url,
            string reposUrl,
            string eventsUrl,
            string hooksUrl,
            string issuesUrl,
            string membersUrl,
            string publicMembersUrl,
            string avatarUrl,
            string? description,
            bool hasOrganizationProjects,
            bool hasRepositoryProjects,
            int publicRepos,
            int publicGists,
            int followers,
            int following,
            string htmlUrl,
            string type,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.DateTime? archivedAt,
            string? name,
            string? company,
            string? blog,
            string? location,
            string? email,
            string? twitterUsername,
            bool? isVerified,
            int? totalPrivateRepos,
            int? ownedPrivateRepos,
            int? privateGists,
            int? diskUsage,
            string? billingEmail,
            global::G.OrganizationFullPlan? plan,
            string? defaultRepositoryPermission,
            bool? membersCanCreateRepositories,
            bool? twoFactorRequirementEnabled,
            string? membersAllowedRepositoryCreationType,
            bool? membersCanCreatePublicRepositories,
            bool? membersCanCreatePrivateRepositories,
            bool? membersCanCreateInternalRepositories,
            bool? membersCanCreatePages,
            bool? membersCanCreatePublicPages,
            bool? membersCanCreatePrivatePages,
            bool? membersCanForkPrivateRepositories,
            bool? webCommitSignoffRequired,
            bool? secretScanningPushProtectionCustomLinkEnabled,
            string? secretScanningPushProtectionCustomLink)
        {
            this.Login = login ?? throw new global::System.ArgumentNullException(nameof(login));
            this.Id = id;
            this.NodeId = nodeId ?? throw new global::System.ArgumentNullException(nameof(nodeId));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ReposUrl = reposUrl ?? throw new global::System.ArgumentNullException(nameof(reposUrl));
            this.EventsUrl = eventsUrl ?? throw new global::System.ArgumentNullException(nameof(eventsUrl));
            this.HooksUrl = hooksUrl ?? throw new global::System.ArgumentNullException(nameof(hooksUrl));
            this.IssuesUrl = issuesUrl ?? throw new global::System.ArgumentNullException(nameof(issuesUrl));
            this.MembersUrl = membersUrl ?? throw new global::System.ArgumentNullException(nameof(membersUrl));
            this.PublicMembersUrl = publicMembersUrl ?? throw new global::System.ArgumentNullException(nameof(publicMembersUrl));
            this.AvatarUrl = avatarUrl ?? throw new global::System.ArgumentNullException(nameof(avatarUrl));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.HasOrganizationProjects = hasOrganizationProjects;
            this.HasRepositoryProjects = hasRepositoryProjects;
            this.PublicRepos = publicRepos;
            this.PublicGists = publicGists;
            this.Followers = followers;
            this.Following = following;
            this.HtmlUrl = htmlUrl ?? throw new global::System.ArgumentNullException(nameof(htmlUrl));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ArchivedAt = archivedAt;
            this.Name = name;
            this.Company = company;
            this.Blog = blog;
            this.Location = location;
            this.Email = email;
            this.TwitterUsername = twitterUsername;
            this.IsVerified = isVerified;
            this.TotalPrivateRepos = totalPrivateRepos;
            this.OwnedPrivateRepos = ownedPrivateRepos;
            this.PrivateGists = privateGists;
            this.DiskUsage = diskUsage;
            this.BillingEmail = billingEmail;
            this.Plan = plan;
            this.DefaultRepositoryPermission = defaultRepositoryPermission;
            this.MembersCanCreateRepositories = membersCanCreateRepositories;
            this.TwoFactorRequirementEnabled = twoFactorRequirementEnabled;
            this.MembersAllowedRepositoryCreationType = membersAllowedRepositoryCreationType;
            this.MembersCanCreatePublicRepositories = membersCanCreatePublicRepositories;
            this.MembersCanCreatePrivateRepositories = membersCanCreatePrivateRepositories;
            this.MembersCanCreateInternalRepositories = membersCanCreateInternalRepositories;
            this.MembersCanCreatePages = membersCanCreatePages;
            this.MembersCanCreatePublicPages = membersCanCreatePublicPages;
            this.MembersCanCreatePrivatePages = membersCanCreatePrivatePages;
            this.MembersCanForkPrivateRepositories = membersCanForkPrivateRepositories;
            this.WebCommitSignoffRequired = webCommitSignoffRequired;
            this.SecretScanningPushProtectionCustomLinkEnabled = secretScanningPushProtectionCustomLinkEnabled;
            this.SecretScanningPushProtectionCustomLink = secretScanningPushProtectionCustomLink;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationFull" /> class.
        /// </summary>
        public OrganizationFull()
        {
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.OrganizationFull? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.OrganizationFull),
                jsonSerializerContext) as global::G.OrganizationFull;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.OrganizationFull? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.OrganizationFull>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.OrganizationFull?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.OrganizationFull),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.OrganizationFull;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.OrganizationFull?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.OrganizationFull?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}